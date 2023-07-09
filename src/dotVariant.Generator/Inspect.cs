// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

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

        public static bool Implements(ITypeSymbol type, INamedTypeSymbol interfaceSymbol)
        {
            return SymbolEqualityComparer.Default.Equals(type, interfaceSymbol)
                || type.AllInterfaces.Contains(interfaceSymbol, SymbolEqualityComparer.Default);
        }

        public static bool Implements(IParameterSymbol param, INamedTypeSymbol interfaceSymbol)
        {
            if (param.Type is ITypeParameterSymbol tp)
            {
                return tp.ConstraintTypes.Any(t => Implements(t, interfaceSymbol));
            }
            return Implements(param.Type, interfaceSymbol);
        }

        public static int NumReferenceFields(IParameterSymbol param)
            => NumReferenceFields(param.Type);

        public static bool HasImplicitConversionDisabled(IParameterSymbol param)
        {
            const string attributeName = nameof(dotVariant) + "." + nameof(NoImplicitConversionAttribute);
            return param.GetAttributes().Any(a => a.AttributeClass?.ToDisplayString() == attributeName);
        }

        public static int NumReferenceFields(ITypeSymbol type)
            => type.IsReferenceType
                ? 1
                : type
                    .GetMembers()
                    .OfType<IFieldSymbol>() // Inludes backing fields of auto-properties
                    .Where(m => !m.IsStatic)
                    .Sum(m => NumReferenceFields(m.Type));

        public static bool CanBeNull(IParameterSymbol p, NullableContext nullable)
        {
            if (p.NullableAnnotation == NullableAnnotation.Annotated)
            {
                return true;
            }
            if (p.Type is ITypeParameterSymbol tp)
            {
                if (tp.HasNotNullConstraint || tp.HasValueTypeConstraint || tp.HasUnmanagedTypeConstraint)
                {
                    return false;
                }
                if (tp.HasReferenceTypeConstraint)
                {
                    return nullable.HasFlag(NullableContext.Enabled)
                        ? tp.ReferenceTypeConstraintNullableAnnotation != NullableAnnotation.NotAnnotated
                        : true;
                }
                if (tp.ConstraintTypes.Any())
                {
                    return tp.ConstraintNullableAnnotations.All(a => a != NullableAnnotation.NotAnnotated);
                }
                return true;
            }
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

        public static bool IsToStringNullable(ITypeSymbol type, NullableContext context)
            => type switch
            {
                // These are known statically
                { SpecialType: SpecialType.System_Object } => true,
                { SpecialType: SpecialType.System_Nullable_T } => true,
                { SpecialType: SpecialType.System_Enum } => false,
                { SpecialType: SpecialType.System_Boolean } => false,
                { SpecialType: SpecialType.System_Char } => false,
                { SpecialType: SpecialType.System_SByte } => false,
                { SpecialType: SpecialType.System_Byte } => false,
                { SpecialType: SpecialType.System_Int16 } => false,
                { SpecialType: SpecialType.System_UInt16 } => false,
                { SpecialType: SpecialType.System_Int32 } => false,
                { SpecialType: SpecialType.System_UInt32 } => false,
                { SpecialType: SpecialType.System_Int64 } => false,
                { SpecialType: SpecialType.System_UInt64 } => false,
                { SpecialType: SpecialType.System_Decimal } => false,
                { SpecialType: SpecialType.System_Single } => false,
                { SpecialType: SpecialType.System_Double } => false,
                { SpecialType: SpecialType.System_String } => false,
                { SpecialType: SpecialType.System_IntPtr } => false,
                { SpecialType: SpecialType.System_UIntPtr } => false,
                { SpecialType: SpecialType.System_DateTime } => false,
                // If nullable annotations are disabled assume nullable
                _ when !context.HasFlag(NullableContext.AnnotationsEnabled) => true,
                // Otherwise check the signature of ToString()
                _ => FindMethod(type, m => m.Name == nameof(ToString) && m.Parameters.IsEmpty)
                    ?.ReturnNullableAnnotation != NullableAnnotation.NotAnnotated,
            };
    }
}
