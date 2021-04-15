//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using static dotVariant.Generator.Inspect;

namespace dotVariant.Generator
{
    public sealed record RenderInfo(
        RenderInfo.LanguageInfo Language,
        RenderInfo.OptionsInfo Options,
        ImmutableArray<RenderInfo.ParamInfo> Params,
        RenderInfo.RuntimeInfo Runtime,
        RenderInfo.VariantInfo Variant)
    // TODO: emptiness possible?
    // TODO: user-defined constructors
    // TODO: user-defined ToString()
    // TODO: user-defined Equals()
    // TODO: user-defined GetHashCode()
    // TODO: nested class
    {
        public sealed record LanguageInfo(
            /// <summary>
            /// Either <c>"enable"</c> or <c>"disable"</c>.
            /// </summary>
            string Nullable,
            /// <summary>
            /// Integer of the form ABB where A=major and BB=minor version of the language (i.e. 703 -> 7.3)
            /// </summary>
            int Version);

        public sealed record OptionsInfo(
            /// <summary>
            /// The namespace in which to generate extension method implementations. If <see langword="null"/> use the global namespace.
            /// </summary>
            string? ExtensionClassNamespace);

        public sealed record RuntimeInfo(
            /// <summary>
            /// <see langword="true"/> if <see cref="System.HashCode"/> is found.
            /// </summary>
            bool HasHashCode,
            /// <summary>
            /// <see langword="true"/> if <see cref="System.Reactive.Linq"/> namespace is found.
            /// </summary>
            bool HasSystemReactiveLinq);

        public sealed record VariantInfo(
            /// <summary>
            /// The fully qualified name of the type (without global:: alias, for diagnostic strings/messages)
            /// </summary>
            string DiagName,
            /// <summary>
            /// The accessibility to use for the class containing extension methods. <see langword="null"/> if extensions are impossible to define.
            /// </summary>
            string? ExtensionsAccessibility,
            /// <summary>
            /// The fully qualified name of the type.
            /// </summary>
            string FullName,
            /// <summary>
            /// <see langword="true"/> if this is an object type.
            /// </summary>
            bool IsClass,
            /// <summary>
            /// <see langword="true"/> if this type was declared with the <see langword="readonly"/> modifier.
            /// </summary>
            bool IsReadonly,
            /// <summary>
            /// The C# keyword used to define this type.
            /// </summary>
            string Keyword,
            /// <summary>
            /// Namespace of the variant type, or <see langword="null"/> if in the global namespace.
            /// </summary>
            string? Namespace,
            /// <summary>
            /// Name of the variant type within the context of its namespace.
            /// </summary>
            string Name,
            /// <summary>
            /// <c>"nonnull"</c> or <c>"nullable"</c>. For a class this determines if certain public methods need nullability annotations.
            /// Always <c>"nonnull"</c> for a value type.
            /// </summary>
            string Nullability,
            /// <summary>
            /// Contains info about relevant members the user has defined.
            /// </summary>
            VariantInfo.UserDefinitions UserDefined)
        {
            public sealed record UserDefinitions(
                /// <summary>
                /// <see langword="true"/> if a user-defined <see cref="IDisposable.Dispose()"/> exists.
                /// </summary>
                bool Dispose);
        }


        public sealed record ParamInfo(
            /// <summary>
            /// A shorter type name (without global:: qualifier, for diagnostic strings/messages, may contain nullability annotation).
            /// </summary>
            string DiagName,
            /// <summary>
            /// <see langword="true"/> if the implicit cast from option to variant should be emitted for this type.
            /// </summary>
            bool EmitImplicitCast,
            /// <summary>
            /// The user-provided parameter name in <c>VariantOf</c>.
            /// </summary>
            string Hint,
            /// <summary>
            /// The 1-based index of the type within the variant.
            /// </summary>
            int Index,
            /// <summary>
            /// <see langword="true"/> if this is an object type (or generic with class constraint).
            /// </summary>
            bool IsClass,
            /// <summary>
            /// <see langword="true"/> if this type implements <see cref="IDisposable"/>.
            /// </summary>
            bool IsDisposable,
            /// <summary>
            /// The fully qualified name of the type. Never contains a nullability annotation.
            /// </summary>
            string Name,
            /// <summary>
            /// <c>"nonnull"</c> or <c>"nullable"</c>. For classes this determines whether the parameter was originally as nullable or null oblivious verses not nullable. For value types this determines whether it's a <see cref="Nullable{T}"/>.
            /// </summary>
            string Nullability,
            /// <summary>
            /// The number of <see langword="object"/> padding fields required for this type.
            /// </summary>
            int ObjectPadding,
            /// <summary>
            /// <c>"nonnull"</c> or <c>"nullable"</c> annotation of the parameters's <see cref="object.ToString()"/> return type.
            /// </summary>
            string ToStringNullability);

        public static RenderInfo FromDescriptor(
            Descriptor desc,
            CSharpCompilation compilation,
            AnalyzerConfigOptionsProvider options,
            CancellationToken token)
        {
            var maxObjects = desc.Options.Max(NumReferenceFields);
            var type = desc.Type;

            var paramDescriptors =
                desc
                .Options
                .Select((p, i) => new ParamInfo(
                    Name: p.Type.WithNullableAnnotation(NullableAnnotation.None).ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
                    DiagName: p.Type.ToDisplayString(),
                    Hint: p.Name,
                    ObjectPadding: maxObjects - NumReferenceFields(p),
                    Index: i + 1,
                    IsClass: p.Type.IsReferenceType,
                    IsDisposable: IsDisposable(p.Type, compilation),
                    Nullability: p.Type.NullableAnnotation == NullableAnnotation.NotAnnotated ? "nonnull" : "nullable",
                    EmitImplicitCast: !(p.Type.TypeKind == TypeKind.Interface || IsAncestorOf(p.Type, desc.Type)),
                    ToStringNullability: IsToStringNullable(p.Type) ? "nullable" : "nonnull"));

            var typeNamespace = type.ContainingNamespace.IsGlobalNamespace ? null : type.ContainingNamespace.ToDisplayString();

            return new(
                Language: new(
                    Nullable: (desc.NullableContext & NullableContext.Enabled) != NullableContext.Disabled ? "enable" : "disable",
                    Version: ConvertLanguageVersion(compilation.LanguageVersion)),
                Options: new(
                    ExtensionClassNamespace: ExtensionsNamespace(options, typeNamespace)),
                Params: paramDescriptors.ToImmutableArray(),
                Runtime: new(
                    HasHashCode: compilation.GetTypeByMetadataName("System.HashCode") is not null,
                    HasSystemReactiveLinq: HasReactive(compilation)),
                Variant: new(
                    DiagName: type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat),
                    ExtensionsAccessibility: ExtensionsAccessibility(type),
                    FullName: type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
                    IsClass: type.IsReferenceType,
                    IsReadonly: IsReadonly(type, token),
                    Keyword: desc.Syntax.Keyword.Text,
                    Namespace: typeNamespace,
                    Name: type.Name,
                    Nullability: type.IsReferenceType ? "nullable" : "nonnull",
                    UserDefined: new(
                        // If the user defined any method named Dispose() bail out. Too risky!
                        Dispose: ImplementsDispose(type, compilation) || HasAnyDisposeMethod(type))));
        }

        private static string? ExtensionsAccessibility(ITypeSymbol type)
            => EffectiveAccessibility(type) switch
            {
                Accessibility.Internal => SyntaxFactory.Token(SyntaxKind.InternalKeyword).Text,
                Accessibility.NotApplicable => null,
                Accessibility.Public => SyntaxFactory.Token(SyntaxKind.PublicKeyword).Text,
                Accessibility.Private => null,
                Accessibility.ProtectedAndInternal => null,
                Accessibility.Protected => null,
                Accessibility.ProtectedOrInternal => SyntaxFactory.Token(SyntaxKind.InternalKeyword).Text,
                _ => null,
            };

        private static int ConvertLanguageVersion(LanguageVersion v)
        {
            // Versions up to C# 7 have values 1..7
            // 7.1 and higher have values 701..
            // Pass the script a unified numbering scheme
            return (int)v < 100 ? (int)v * 100 : (int)v;
        }

        private static bool IsToStringNullable(ITypeSymbol type)
            => FindMethod(type, m => m.Name == "ToString" && m.Parameters.IsEmpty)?
                .ReturnNullableAnnotation != NullableAnnotation.NotAnnotated;

        private static string? ExtensionsNamespace(AnalyzerConfigOptionsProvider options, string? typeNamespace)
        {
            if (options.GlobalOptions.TryGetValue("build_property.dotVariant-ExtensionClassNamespace", out var property))
            {
                property = property.Trim('.');
                return string.IsNullOrWhiteSpace(property) ? null : property;
            }
            else
            {
                return typeNamespace;
            }
        }

        private static bool HasReactive(CSharpCompilation compilation)
            => compilation.GetTypeByMetadataName("System.Reactive.Linq.Observable") is not null;
    }
}
