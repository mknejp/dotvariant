//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using static dotVariant.Generator.Inspect;

namespace dotVariant.Generator
{
    /// <summary>
    /// Holds all the information required by Scriban to generate the variant's source.
    /// </summary>
    /// <param name="Language">Information about the language context we are generating code in.</param>
    /// <param name="Options">Options specified externally (via MSBuild or attributes).</param>
    /// <param name="Params">Properties of the parameters provided to <c>VariantOf</c>.</param>
    /// <param name="Runtime">Information about the .NET runtime we are generating code for.</param>
    /// <param name="Variant">Properties of the variant class.</param>
    public sealed record RenderInfo(
        RenderInfo.LanguageInfo Language,
        RenderInfo.OptionsInfo Options,
        ImmutableArray<RenderInfo.ParamInfo> Params,
        RenderInfo.RuntimeInfo Runtime,
        RenderInfo.VariantInfo Variant)
    {
        /// <param name="Nullable">
        /// Either <c>"enable"</c> or <c>"disable"</c>.
        /// </param>
        /// <param name="Version">
        /// Integer of the form ABB where A=major and BB=minor version of the language (i.e. 703 -> 7.3)
        /// </param>
        public sealed record LanguageInfo(
            string Nullable,
            int Version);

        /// <param name="ExtensionClassNamespace">
        /// The namespace in which to generate extension method implementations. If <see langword="null"/> use the global namespace.
        /// </param>
        public sealed record OptionsInfo(
            string? ExtensionClassNamespace);

        /// <param name="HasHashCode">
        /// <see langword="true"/> if <see cref="System.HashCode"/> is found.
        /// </param>
        /// <param name="HasSystemReactiveLinq">
        /// <see langword="true"/> if <see cref="System.Reactive.Linq"/> namespace is found.
        /// </param>
        public sealed record RuntimeInfo(
            bool HasHashCode,
            bool HasSystemReactiveLinq);

        /// <param name="Accessibility">
        /// The accessibility modifier of the variant class.
        /// </param>
        /// <param name="CanBeNull">
        /// <see langword="true"/> if <see langword="null"/> is a valid value for the variant type.
        /// </param>
        /// <param name="DiagType">
        /// The fully qualified name of the type (without <c>global::</c> qualifier) used for diagnostic strings/messages.
        /// </param>
        /// <param name="ExtensionsAccessibility">
        /// The accessibility to use for the class containing extension methods. <see langword="null"/> if extensions are impossible to define.
        /// </param>
        /// <param name="Identifier">
        /// The identifier of the type, i.e. without type parameters or enclsoing namespace/type qualifiers.
        /// </param>
        /// <param name="IsReadonly">
        /// <see langword="true"/> if this type was declared with the <see langword="readonly"/> modifier.
        /// </param>
        /// <param name="IsReferenceType">
        /// <see langword="true"/> if this is an object type.
        /// </param>
        /// <param name="Keyword">
        /// The C# keyword used to define this type.
        /// </param>
        /// <param name="Namespace">
        /// Namespace of the variant type, or <see langword="null"/> if in the global namespace.
        /// </param>
        /// <param name="QualifiedType">
        /// The fully qualified name of the type including type parameters.
        /// </param>
        /// <param name="Type">
        /// Top-level name of the variant's type including type parameter list.
        /// </param>
        /// <param name="UserDefined">
        /// Contains info about relevant members the user has defined.
        /// </param>
        public sealed record VariantInfo(
            string? Accessibility,
            bool CanBeNull,
            string DiagType,
            string? ExtensionsAccessibility,
            string Identifier,
            bool IsReadonly,
            bool IsReferenceType,
            string Keyword,
            string? Namespace,
            string QualifiedType,
            string Type,
            VariantInfo.UserDefinitions UserDefined)
        {
            /// <param name="Dispose">
            /// <see langword="true"/> if a user-defined <see cref="IDisposable.Dispose()"/> exists.
            /// </param>
            public sealed record UserDefinitions(
                bool Dispose);
        }

        /// <param name="CanBeNull">
        /// <see langword="true"/> if <see langword="null"/> is a valid value for this parameter.
        /// </param>
        /// <param name="DiagType">
        /// A shorter type name (without <c>global::</c> qualifier) for diagnostic strings/messages, may contain nullability annotation).
        /// </param>
        /// <param name="EmitImplicitCast">
        /// <see langword="true"/> if the implicit cast from option to variant should be emitted for this type.
        /// </param>
        /// <param name="Identifier">
        /// The user-provided parameter name in <c>VariantOf</c>.
        /// </param>
        /// <param name="Index">
        /// The 1-based index of the type within the variant.
        /// </param>
        /// <param name="IsDisposable">
        /// <see langword="true"/> if this type implements <see cref="IDisposable"/>.
        /// </param>
        /// <param name="IsReferenceType">
        /// <see langword="true"/> if this is an object type (or generic with class constraint).
        /// </param>
        /// <param name="IsToStringNullable">
        /// <see langword="true"/> if the parameters's <see cref="object.ToString()"/> can return <see langword="null"/>.
        /// </param>
        /// <param name="ObjectPadding">
        /// The number of <see langword="object"/> padding fields required for this type.
        /// </param>
        /// <param name="OutType">
        /// The type to use for <c>out</c>-qualified function parameters.
        /// </param>
        /// <param name="Type">
        /// The fully qualified name of the type including type parameter list, without nullability annotation.
        /// </param>
        public sealed record ParamInfo(
            bool CanBeNull,
            string DiagType,
            bool EmitImplicitCast,
            string Identifier,
            int Index,
            bool IsDisposable,
            bool IsReferenceType,
            bool IsToStringNullable,
            int ObjectPadding,
            string OutType,
            string Type);

        public static RenderInfo FromDescriptor(
            Descriptor desc,
            CSharpCompilation compilation,
            AnalyzerConfigOptionsProvider options,
            CancellationToken token)
        {
            var maxObjects = desc.Options.Max(NumReferenceFields);
            var type = desc.Type;
            var emitNullable = desc.NullableContext.HasFlag(NullableContext.Enabled);

            var paramDescriptors =
                desc
                .Options
                .Select((p, i) => new ParamInfo(
                    CanBeNull: CanBeNull(p),
                    DiagType: p.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat).Replace("global::", ""),
                    EmitImplicitCast: !(p.Type.TypeKind == TypeKind.Interface || IsAncestorOf(p.Type, desc.Type)),
                    Identifier: p.Name,
                    Index: i + 1,
                    IsDisposable: IsDisposable(p.Type, compilation),
                    IsReferenceType: p.Type.IsReferenceType,
                    IsToStringNullable: IsToStringNullable(p.Type, NullableContext.Enabled),
                    ObjectPadding: maxObjects - NumReferenceFields(p),
                    OutType: DetermineOutType(p, emitNullable),
                    Type: AppendNullable(p.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat), p.Type.IsReferenceType ? p.NullableAnnotation : NullableAnnotation.NotAnnotated)));

            var typeNamespace = type.ContainingNamespace.IsGlobalNamespace ? null : type.ContainingNamespace.ToDisplayString();

            return new(
                Language: new(
                    Nullable: emitNullable ? "enable" : "disable",
                    Version: ConvertLanguageVersion(compilation.LanguageVersion)),
                Options: new(
                    ExtensionClassNamespace: ExtensionsNamespace(options, typeNamespace)),
                Params: paramDescriptors.ToImmutableArray(),
                Runtime: new(
                    HasHashCode: compilation.GetTypeByMetadataName("System.HashCode") is not null,
                    HasSystemReactiveLinq: HasReactive(compilation)),
                Variant: new(
                    Accessibility: VariantAccessibility(type),
                    CanBeNull: type.IsReferenceType,
                    DiagType: type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat),
                    ExtensionsAccessibility: ExtensionsAccessibility(type),
                    Identifier: type.Name,
                    IsReferenceType: type.IsReferenceType,
                    IsReadonly: IsReadonly(type, token),
                    Keyword: desc.Syntax.Keyword.Text,
                    Namespace: typeNamespace,
                    QualifiedType: type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
                    Type: type.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat).Replace("global::", ""),
                    UserDefined: new(
                        // If the user defined any method named Dispose() bail out. Too risky!
                        Dispose: ImplementsDispose(type, compilation) || HasAnyDisposeMethod(type))));
        }

        private static string DetermineOutType(IParameterSymbol p, bool emitNullable)
        {
            var type = p.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
            if (!emitNullable)
            {
                return type;
            }

            if (p.Type.IsReferenceType)
            {
                return AppendNullable(type, NullableAnnotation.Annotated);
            }
            return type;
        }

        private static string AppendNullable(string s, NullableAnnotation na)
            => na == NullableAnnotation.Annotated ? s + "?" : s;

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

        private static string? VariantAccessibility(ITypeSymbol type)
            => EffectiveAccessibility(type) switch
            {
                Accessibility.Internal => SyntaxFactory.Token(SyntaxKind.InternalKeyword).Text,
                Accessibility.Public => SyntaxFactory.Token(SyntaxKind.PublicKeyword).Text,
                // These only apply to nested types which are currently not supported
                Accessibility.Private => null,
                Accessibility.ProtectedAndInternal => null,
                Accessibility.Protected => null,
                Accessibility.ProtectedOrInternal => null,
                Accessibility.NotApplicable => null,
                _ => null,
            };

        private static int ConvertLanguageVersion(LanguageVersion v)
        {
            // Versions up to C# 7 have values 1..7
            // 7.1 and higher have values 701..
            // Pass the script a unified numbering scheme
            return (int)v < 100 ? (int)v * 100 : (int)v;
        }

        private static string? ExtensionsNamespace(AnalyzerConfigOptionsProvider options, string? typeNamespace)
        {
            // All compiler-visible properties exist. If not set they are an empty string. Thus the "Try" part is meaningless.
            _ = options.GlobalOptions.TryGetValue("build_property.dotVariant-ExtensionClassNamespace", out var value);
            value = value?.Trim('.');
            return string.IsNullOrWhiteSpace(value) ? typeNamespace : value;
        }

        private static bool HasReactive(CSharpCompilation compilation)
            => compilation.GetTypeByMetadataName("System.Reactive.Linq.Observable") is not null;
    }
}
