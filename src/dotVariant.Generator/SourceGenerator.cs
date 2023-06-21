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
using System.Threading;

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
            var variantDecls = generatorContext.SyntaxProvider.CreateSyntaxProvider((node, ct) => NodeIsTypeDeclaration(node), (context, ct) =>
                {
                    return TryCreateCompilationInfo(context, ct);
                })
                .SelectNotNull()
                .Diagnose((tuple, ct) => Diagnose.Variant(tuple.decl.Type, ct).ToImmutableArray());

            var descriptors = variantDecls.Select((tuple, _) =>
            {
                var (decl, compInfo) = tuple;
                return (desc: Descriptor.FromDeclaration(decl.Type, decl.Nullable), nested: decl.NestingTrace.Select((type, _) => Descriptor.FromDeclaration(type, decl.Nullable)).ToImmutableArray(), compInfo);
            });

            var renderInfos = descriptors.Combine(generatorContext.AnalyzerConfigOptionsProvider).Select(
                (tuple, ct) =>
                {
                    var (source, analyzerOptionProvider) = tuple;
                    var (desc, nested, compInfo) = source;
                    return (desc.HintName, RenderInfo.FromDescriptor(desc, compInfo, analyzerOptionProvider, ct));
                });

            generatorContext.RegisterSourceOutput(renderInfos, (context, source) =>
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

        private static (VariantDecl decl, CompilationInfo compInfo)? TryCreateCompilationInfo(GeneratorSyntaxContext context, CancellationToken ct)
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

            var type = new SemanticType(symbol, syntax);
            var decl = new VariantDecl(type, CreateNestingTrace(type, sema),
                sema.GetNullableContext(syntax.GetLocation().SourceSpan.Start));
            var compInfo = CompilationInfo.FromCompilation(comp);
            return (decl, compInfo).AsNullable();
        }

        private static bool NodeIsTypeDeclaration(SyntaxNode node)
        {
            return node.Kind() is SyntaxKind.ClassDeclaration
                or SyntaxKind.StructDeclaration
                or SyntaxKind.RecordDeclaration or SyntaxKind.RecordStructDeclaration;
        }

        private static ImmutableArray<SemanticType> CreateNestingTrace(SemanticType semanticType, SemanticModel semanticModel)
        {
            var trace = ImmutableArray.CreateBuilder<SemanticType>();
            var parent = semanticType.Syntax.Parent;
            while (parent is TypeDeclarationSyntax current)
            {
                trace.Add(new(semanticModel.GetDeclaredSymbol(current)!, current));
                parent = current.Parent;
            }
            trace.Reverse();
            return trace.ToImmutable();
        }
    }
}
