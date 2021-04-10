//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Scriban;
using Scriban.Runtime;
using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;

namespace dotVariant.Generator
{
    internal static partial class Renderer
    {
        private static readonly Lazy<Template> _template = new(() =>
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.templates.Variant.scriban-cs");

            return Template.Parse(new StreamReader(stream).ReadToEnd());
        });

        public static string Render(GeneratorExecutionContext context, Descriptor type)
            => Render(context, type, _template.Value);

        public static string Render(GeneratorExecutionContext context, Descriptor type, Template template)
        {
            var templateContext = new TemplateContext
            {
                MemberRenamer = m => m.Name,
                StrictVariables = true,
            };
            var globals = new ScriptObject();
            globals.Import(CreateRenderInfo(context, type), renamer: m => m.Name);
            templateContext.PushGlobal(globals);
            return template.Render(templateContext);
        }

        private static RenderInfo CreateRenderInfo(GeneratorExecutionContext context, Descriptor desc)
        {
            var compilation = (CSharpCompilation)context.Compilation;
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
                    Nullability: p.Type.NullableAnnotation == NullableAnnotation.NotAnnotated ? "nonnull" : "nullable",
                    EmitImplicitCast: !Inspect.IsAncestorOf(p.Type, desc.Type),
                    ToStringNullability: ToStringNullability(p.Type)));

            var ns = type.ContainingNamespace.IsGlobalNamespace ? null : type.ContainingNamespace.ToDisplayString();

            if (context.AnalyzerConfigOptions.GlobalOptions.TryGetValue(
                "build_property.dotVariant-ExtensionClassNamespace", out var extensionClassNamespace))
            {
                extensionClassNamespace = extensionClassNamespace.Trim('.');
                if (string.IsNullOrWhiteSpace(extensionClassNamespace))
                {
                    extensionClassNamespace = null;
                }
            }
            else
            {
                extensionClassNamespace = ns;
            }

            return new RenderInfo(
                Language: new LanguageInfo(
                    Nullable: (desc.NullableContext & NullableContext.Enabled) != NullableContext.Disabled ? "enable" : "disable",
                    Version: ConvertLanguageVersion(compilation.LanguageVersion)),
                Options: new OptionsInfo(
                    ExtensionClassNamespace: extensionClassNamespace),
                Params: paramDescriptors.ToImmutableArray(),
                Runtime: new RuntimeInfo(
                    HasHashCode: compilation.GetTypeByMetadataName("System.HashCode") is not null),
                Variant: new VariantInfo(
                    DiagName: type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat),
                    ExtensionsAccessibility: ExtensionsAccessibility(type),
                    FullName: type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
                    IsClass: type.IsReferenceType,
                    IsReadonly: Inspect.IsReadonly(type, context.CancellationToken),
                    Keyword: desc.Syntax.Keyword.Text,
                    Namespace: ns,
                    Name: type.Name,
                    Nullability: type.IsReferenceType ? "nullable" : "nonnull"));
        }

        private static string? ExtensionsAccessibility(ITypeSymbol type)
            => Inspect.EffectiveAccessibility(type) switch
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

        private static string ToStringNullability(ITypeSymbol type)
        {
            var method = Inspect.FindMethod(type, m => m.Name == "ToString" && m.Parameters.IsEmpty);
            return method?.ReturnNullableAnnotation == NullableAnnotation.NotAnnotated ? "nonnull" : "nullable";
        }

        private static int ConvertLanguageVersion(LanguageVersion v)
        {
            // Versions up to C# 7 have values 1..7
            // 7.1 and higher have values 701..
            // Pass the script a unified numbering scheme
            return (int)v < 100 ? (int)v * 100 : (int)v;
        }

        private static int NumReferenceFields(IParameterSymbol param)
            => NumReferenceFields(param.Type);

        private static int NumReferenceFields(ITypeSymbol type)
            => type.IsReferenceType
                ? 1
                : type
                    .GetMembers()
                    .OfType<IFieldSymbol>() // Inludes backing fields of auto-properties
                    .Where(m => !m.IsStatic)
                    .Sum(m => NumReferenceFields(m.Type));

        public sealed record RenderInfo(
            LanguageInfo Language,
            OptionsInfo Options,
            ImmutableArray<ParamInfo> Params,
            RuntimeInfo Runtime,
            VariantInfo Variant);

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
            bool HasHashCode);

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
            string Nullability);

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
    }
}
