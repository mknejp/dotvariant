#nullable enable
using Microsoft.CodeAnalysis;
using Scriban;
using Scriban.Runtime;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace dotVariant.Generator
{
    internal static class Renderer
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
            // TODO: take the project's LangVersion into consideration
            var templateContext = new TemplateContext();
            templateContext.PushGlobal(CreateGlobals(context, type));
            return template.Render(templateContext);
        }

        private static ScriptObject CreateGlobals(GeneratorExecutionContext context, Descriptor desc)
        {
            var maxObjects = desc.Options.Max(NumReferenceFields);
            var typeDescriptors =
                desc
                .Options
                .Select((p, i) => new
                {
                    Name = p.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat),
                    ShortName = p.Type.ToDisplayString(),
                    Hint = p.Name,
                    Dummies = maxObjects - NumReferenceFields(p),
                    Index = i + 1,
                    IsObject = p.Type.IsReferenceType,
                    Nullable = p.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat) + (p.Type.IsReferenceType ? "?" : ""),
                    Coalesce = p.Type.NullableAnnotation == NullableAnnotation.Annotated ? "?" : "",
                    EmitImplicitCast = !IsAncestorOf(p.Type, desc.Type)
                });

            var exception = context.Compilation.GetTypeByMetadataName("dotVariant.TypeMismatchException");
            // TODO: exception not found?

            var type = desc.Type;
            return new ScriptObject
            {
                { "in", (type.TypeKind == TypeKind.Struct && Inspect.IsReadonly(type, context.CancellationToken)) ? "in" : "" },
                { "keyword", type.TypeKind == TypeKind.Class ? "class" : "struct" },
                { "mismatch_exception", exception!.ToDisplayString() },
                { "name", type.Name },
                { "full_name", type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) },
                { "namespace", type.ContainingNamespace.IsGlobalNamespace ? null : type.ContainingNamespace.ToDisplayString() },
                { "nullable", type.TypeKind == TypeKind.Class ? type.Name + "?" : type.Name },
                { "readonly", type.TypeKind == TypeKind.Struct ? "readonly" : "" },
                { "types", typeDescriptors.ToArray() },
            };
        }

        private static bool IsAncestorOf(ITypeSymbol ancestor, ITypeSymbol type)
        {
            var current = (ITypeSymbol?)type;
            while (current is not null)
            {
                if (SymbolEqualityComparer.Default.Equals(ancestor, current))
                {
                    return true;
                }
                current = current.BaseType;
            }
            return false;
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
    }
}
