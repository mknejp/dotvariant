//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace dotVariant.Generator
{
    [Generator]
    public sealed class SourceGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext generatorContext)
        {
            var variantDecls = generatorContext.SyntaxProvider.CreateSyntaxProvider((node, ct) =>
            {
                const nuint declarationBloom = (nuint)SyntaxKind.ClassDeclaration | (nuint)SyntaxKind.StructDeclaration |
                                             (nuint)SyntaxKind.RecordDeclaration | (nuint)SyntaxKind.RecordStructDeclaration;
                var nodeKind = node.Kind();
                return ((nuint)nodeKind & declarationBloom) != default && nodeKind is SyntaxKind.ClassDeclaration
                    or SyntaxKind.StructDeclaration
                    or SyntaxKind.RecordDeclaration or SyntaxKind.RecordStructDeclaration;
            }, (context, ct) =>
            {
                var sema = context.SemanticModel;
                if (context.Node is not TypeDeclarationSyntax syntax)
                {
                    return default;
                }
                if (sema.GetDeclaredSymbol(syntax, ct) is not { } symbol)
                {
                    return default;
                }
                if (sema.Compilation is not CSharpCompilation comp)
                {
                    return default;
                }
                if (!symbol.GetAttributes().Any(a => a.AttributeClass?.ToDisplayString() == VariantDecl.AttributeName))
                {
                    return default;
                }

                var diagnostics = Diagnose.Variant(symbol, syntax, ct);

                var decl = new VariantDecl(symbol, syntax, sema.GetNullableContext(syntax.GetLocation().SourceSpan.Start), diagnostics);
                var compInfo = CompilationInfo.FromCompilation(comp);
                (VariantDecl decl, CompilationInfo compInfo)? nullable = (decl, compInfo);
                return nullable;
            }).Where(t => t.HasValue).Select((t, ct) => t!.Value);

            var descriptorsAndrenderInfos = variantDecls.Combine(generatorContext.AnalyzerConfigOptionsProvider).Select(
                (tuple, ct) =>
                {
                    var ((decl, compInfo), analyzerOptionProvider) = tuple;
                    if (decl.Diags.Any(static diag => diag.Severity >= DiagnosticSeverity.Error))
                    {
                        return default;
                    }
                    var desc = Descriptor.FromDeclaration(decl.Symbol, decl.Syntax, decl.Nullable);
                    var renderInfo = RenderInfo.FromDescriptor(desc, compInfo, analyzerOptionProvider, ct);
                    return (desc, renderInfo);
                });

            generatorContext.RegisterImplementationSourceOutput(descriptorsAndrenderInfos, (context, tuple) =>
            {
                var (desc, renderInfo) = tuple;
                context.AddSource(desc.SanitizedTypeName, Renderer.Render(renderInfo));
            });
        }
    }
}
