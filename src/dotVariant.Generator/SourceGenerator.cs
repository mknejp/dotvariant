//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace dotVariant.Generator
{
    [Generator]
    public sealed class SourceGenerator : IIncrementalGenerator
    {
#if DEBUG
        public List<RenderInfo> RenderInfos { get; } = new();
#endif

        public void Initialize(IncrementalGeneratorInitializationContext generatorContext)
        {
            var variantDecls = generatorContext.SyntaxProvider.CreateSyntaxProvider((node, ct) =>
            {
                return node.Kind() is SyntaxKind.ClassDeclaration
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

                var diagnostics = Diagnose.Variant(symbol, syntax, ct).ToImmutableArray();

                var decl = new VariantDecl(symbol, syntax, sema.GetNullableContext(syntax.GetLocation().SourceSpan.Start), diagnostics);
                var compInfo = CompilationInfo.FromCompilation(comp);
                return (decl, compInfo).AsNullable();
            }).SelectNotNull();

            var descriptors = variantDecls.Select((tuple, _) =>
            {
                var (decl, compInfo) = tuple;
                return new DiagnosedResult<(Descriptor, CompilationInfo)>(decl.Diags,
                    () => (Descriptor.FromDeclaration(decl.Symbol, decl.Syntax, decl.Nullable), compInfo));
            });

            var renderInfos = descriptors.Combine(generatorContext.AnalyzerConfigOptionsProvider).Select(
                (tuple, ct) =>
                {
                    var (source, analyzerOptionProvider) = tuple;
                    return source.Select(tuple =>
                    {
                        var (desc, compInfo) = tuple;
                        return (desc.HintName, RenderInfo.FromDescriptor(desc, compInfo, analyzerOptionProvider, ct));
                    });
                });

            generatorContext.RegisterImplementationSourceOutput(renderInfos, (context, source) =>
            {
                source.Diagnostics.ForEach(context.ReportDiagnostic);
                if (!source.TryGetValue(out var tuple))
                {
                    return;
                }
                var (name, info) = tuple;
#if DEBUG
                RenderInfos.Add(info);
#endif
                context.AddSource(name, Renderer.Render(info));
            });
        }
    }
}
