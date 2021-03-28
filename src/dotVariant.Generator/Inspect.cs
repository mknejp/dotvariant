using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;

namespace dotVariant.Generator
{
    internal static class Inspect
    {
        public static bool IsPartial(ITypeSymbol type, CancellationToken token)
            => type
                .DeclaringSyntaxReferences
                .Any(r => ((TypeDeclarationSyntax)r.GetSyntax(token)).Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)));

        public static bool IsPartial(IMethodSymbol method, CancellationToken token)
            => method
                .DeclaringSyntaxReferences
                .Any(r => ((MethodDeclarationSyntax)r.GetSyntax(token)).Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)));

        public static bool IsReadonly(ITypeSymbol type, CancellationToken token)
            => type
                .DeclaringSyntaxReferences
                .Any(r => ((TypeDeclarationSyntax)r.GetSyntax(token)).Modifiers.Any(m => m.IsKind(SyntaxKind.ReadOnlyKeyword)));

        public static string TypeDeclarationKeyword(ITypeSymbol type, CancellationToken token)
            => ((TypeDeclarationSyntax)type.DeclaringSyntaxReferences[0].GetSyntax(token)).Keyword.ValueText;

        public static IMethodSymbol? VariantOfMethod(ITypeSymbol type)
            => type
                .GetMembers()
                .OfType<IMethodSymbol>()
                .FirstOrDefault(m => m.IsDefinition && m.MethodKind == MethodKind.Ordinary && m.Name == "VariantOf");

        public static ImmutableArray<IParameterSymbol> GetOptions(ITypeSymbol type)
            => VariantOfMethod(type)?.Parameters
            ?? ImmutableArray<IParameterSymbol>.Empty;
    }
}
