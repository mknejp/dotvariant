// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace dotVariant.Generator
{
    [Generator]
    public sealed class SourceGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            var receiver = (SyntaxReceiver)context.SyntaxContextReceiver!;

            var decls =
                receiver
                .VariantDecls
                .Select(decl => (decl.Symbol, decl.Syntax, decl.Nullable, Diags: Diagnose.Variant(decl.Symbol, decl.Syntax, context.CancellationToken)))
                .Memoize();

            decls
                .SelectMany(desc => desc.Diags)
                .ForEach(context.ReportDiagnostic);

            Descriptors =
                decls
                .Where(decl => !decl.Diags.Any(d => d.Severity == DiagnosticSeverity.Error))
                .Select(decl => Descriptor.FromDeclaration(decl.Symbol, decl.Syntax, decl.Nullable))
                .ToImmutableArray();

            RenderInfos =
                Descriptors
                .Select(desc => RenderInfo.FromDescriptor(desc, (CSharpCompilation)context.Compilation, context.AnalyzerConfigOptions, context.CancellationToken))
                .ToImmutableArray();

            Enumerable
                .Zip(Descriptors, RenderInfos, (desc, ri) => (desc, ri))
                .ForEach(v => context.AddSource(SanitizeName(v.desc.Type.ToDisplayString()), Renderer.Render(v.ri)));

            static string SanitizeName(string name)
                => name
                // If the contains type parameters replace angle brackets as those are not allowed in AddSource()
                .Replace('<', '{')
                .Replace('>', '}')
                // Escaped names like @class or @event aren't supported either
                .Replace('@', '.');
        }

        public ImmutableArray<Descriptor> Descriptors { get; private set; }
        public ImmutableArray<RenderInfo> RenderInfos { get; private set; }

        public void Initialize(GeneratorInitializationContext context)
        {
            context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
        }

        private sealed class SyntaxReceiver : ISyntaxContextReceiver
        {
            public List<(INamedTypeSymbol Symbol, TypeDeclarationSyntax Syntax, NullableContext Nullable)> VariantDecls { get; } = new();

            public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
            {
                if (context.Node is not TypeDeclarationSyntax tds || tds.AttributeLists.IsEmpty())
                {
                    return;
                }

                var sema = context.SemanticModel;

                if (sema.GetDeclaredSymbol(tds) is not INamedTypeSymbol symbol)
                {
                    return;
                }

                const string attributeName = nameof(dotVariant) + "." + nameof(VariantAttribute);
                if (symbol.GetAttributes().Any(a => a.AttributeClass?.ToDisplayString() == attributeName))
                {
                    VariantDecls.Add((symbol, tds, sema.GetNullableContext(context.Node.GetLocation().SourceSpan.Start)));
                }
            }
        }
    }
}
