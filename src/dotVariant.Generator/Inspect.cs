//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
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
            => FindMethod(type, m => m.IsDefinition && m.MethodKind == MethodKind.Ordinary && m.Name == "VariantOf");

        public static ImmutableArray<IParameterSymbol> GetOptions(ITypeSymbol type)
            => VariantOfMethod(type)?.Parameters
            ?? ImmutableArray<IParameterSymbol>.Empty;

        public static bool IsAncestorOf(ITypeSymbol ancestor, ITypeSymbol type)
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

        public static IMethodSymbol? FindMethod(ITypeSymbol type, Func<IMethodSymbol, bool> pred)
            => type
                .GetMembers()
                .OfType<IMethodSymbol>()
                .FirstOrDefault(pred);

        public static IMethodSymbol? FindNullaryToString(ITypeSymbol type)
            => FindMethod(type, m => m.MethodKind == MethodKind.Ordinary && m.Name == "ToString()" && m.Parameters.IsEmpty);

        public static Accessibility EffectiveAccessibility(ITypeSymbol type)
            => type.DeclaredAccessibility;

        public static bool ImplementsDispose(ITypeSymbol type, CSharpCompilation compilation)
        {
            var dispose =
                FindMethod(
                    compilation.GetTypeByMetadataName($"{nameof(System)}.{nameof(IDisposable)}")!,
                    m => m.Name == nameof(IDisposable.Dispose));
            return type.FindImplementationForInterfaceMember(dispose!) is not null;
        }

        public static bool HasAnyDisposeMethod(ITypeSymbol type)
            => type
                .GetMembers()
                .OfType<IMethodSymbol>()
                .Any(m => m.Name == nameof(IDisposable.Dispose));

        public static bool IsDisposable(ITypeSymbol type, CSharpCompilation compilation)
        {
            var disposable = compilation.GetTypeByMetadataName($"{nameof(System)}.{nameof(IDisposable)}")!;
            return SymbolEqualityComparer.Default.Equals(type, disposable)
                || type.AllInterfaces.Contains(disposable, SymbolEqualityComparer.Default);
        }

        public static int NumReferenceFields(IParameterSymbol param)
            => NumReferenceFields(param.Type);

        public static int NumReferenceFields(ITypeSymbol type)
            => type.IsReferenceType
                ? 1
                : type
                    .GetMembers()
                    .OfType<IFieldSymbol>() // Inludes backing fields of auto-properties
                    .Where(m => !m.IsStatic)
                    .Sum(m => NumReferenceFields(m.Type));

        public static bool CanBeNull(IParameterSymbol p)
        {
            if (p.Type.IsReferenceType)
            {
                return p.NullableAnnotation != NullableAnnotation.NotAnnotated;
            }
            if (p.Type.IsValueType)
            {
                return p.NullableAnnotation == NullableAnnotation.Annotated;
            }
            return false;
        }
    }
}
