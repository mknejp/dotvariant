//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;

namespace dotVariant.Generator
{
    internal static class Diagnose
    {
        public static IEnumerable<Diagnostic> Variant(ITypeSymbol type, TypeDeclarationSyntax syntax, CancellationToken token)
            => new[]
                {
                    CheckType(type, syntax, token),
                    CheckOptions(type, token),
                }
                .Concat();

        private static IEnumerable<Diagnostic> CheckType(ITypeSymbol type, TypeDeclarationSyntax syntax, CancellationToken token)
            => new Func<ITypeSymbol, TypeDeclarationSyntax, CancellationToken, IEnumerable<Diagnostic>>[]
                {
                    CheckThat.IsNotRecord,
                    CheckThat.IsNotStatic,
                    CheckThat.IsPartial,
                    CheckThat.HasVariantOf,
                }
                .SelectMany(f => f(type, syntax, token));

        private static IEnumerable<Diagnostic> CheckOptions(ITypeSymbol type, CancellationToken token)
        {
            var variantOf = Inspect.VariantOfMethod(type);
            if (variantOf is null)
            {
                return Enumerable.Empty<Diagnostic>();
            }
            var methodSyntax = variantOf.DeclaringSyntaxReferences[0].GetSyntax(token) as MethodDeclarationSyntax;
            var options = Inspect.GetOptions(type);
            return
                new Func<ITypeSymbol, MethodDeclarationSyntax, IMethodSymbol, ImmutableArray<IParameterSymbol>, CancellationToken, IEnumerable<Diagnostic>>[]
                {
                    CheckThat.HasAtLeastOneOption,
                    CheckThat.NotTooManyOptions,
                    CheckThat.HasNoDuplicateOptions,
                    CheckThat.HasNoReservedName,
                    CheckThat.NoImplicitConversionForBaseClasses,
                    CheckThat.NoImplicitConversionForInterfaces,
                }
                .SelectMany(f => f(type, methodSyntax!, variantOf, options, token));
        }

        private static class CheckThat
        {
            public static IEnumerable<Diagnostic> IsNotRecord(
                ITypeSymbol type,
                TypeDeclarationSyntax syntax,
                CancellationToken _)
            {
                if (type.IsRecord)
                {
                    // We are only testing for records here because the attribute
                    // is only permitted on classes and structs, which is already
                    // enforced by the compiler.
                    yield return MakeError(
                        nameof(IsNotRecord),
                        "Variant types cannot be records.",
                        $"Type '{type.ToDisplayString()}' must be either a 'class' or a 'struct'.",
                        LocationOfFirstToken(syntax, SyntaxKind.RecordKeyword));
                }
            }

            public static IEnumerable<Diagnostic> IsNotStatic(
                ITypeSymbol type,
                TypeDeclarationSyntax syntax,
                CancellationToken _)
            {
                if (type.IsStatic)
                {
                    yield return MakeError(
                        nameof(IsNotStatic),
                        "Variant types cannot be static.",
                        $"Type '{type.ToDisplayString()}' must not be a static class.",
                        LocationOfFirstToken(syntax, SyntaxKind.StaticKeyword));
                }
            }

            public static IEnumerable<Diagnostic> IsPartial(
                ITypeSymbol type,
                TypeDeclarationSyntax syntax,
                CancellationToken token)
            {
                if (!Inspect.IsPartial(type, token))
                {
                    yield return MakeError(
                        nameof(IsPartial),
                        "Variant declaration must be 'partial'.",
                        $"Type '{type.ToDisplayString()}' must be declared 'partial' to be compatible with source generation.",
                        LocationOfFirstToken(syntax, SyntaxKind.ClassKeyword, SyntaxKind.StructKeyword));
                }
            }

            public static IEnumerable<Diagnostic> HasVariantOf(
                ITypeSymbol type,
                TypeDeclarationSyntax syntax,
                CancellationToken token)
            {
                var variantOf = Inspect.VariantOfMethod(type);
                if (variantOf is null || !(IsUnique() && IsStatic(variantOf) && IsPartial(variantOf) && IsUnimplemented(variantOf)))
                {
                    // If the method is declared point to it, otherwise to the class
                    var location = variantOf is null
                        ? LocationOfFirstToken(syntax, SyntaxKind.IdentifierToken)
                        : LocationOfFirstToken(variantOf.DeclaringSyntaxReferences[0].GetSyntax(token), SyntaxKind.IdentifierToken);

                    yield return MakeError(
                        nameof(HasVariantOf),
                        $"Type '{type.ToDisplayString()}' must contain a single unimplemented static partial 'VariantOf()' method declaration.",
                        $"A variant type declaration must contain a method named 'VariantOf' which specifies the variant's options in its parameter signature. This method must be static, partial and unimplemented. The parameter names are used as hints in the generated interface. Example: 'static partial void VariantOf(int value1, float value2, string? value3);'.",
                        location);
                }

                bool IsUnique() => type.GetMembers("VariantOf").Length == 1;
                bool IsStatic(IMethodSymbol m) => m.IsStatic;
                bool IsUnimplemented(IMethodSymbol m) => m.PartialImplementationPart == null;
                bool IsPartial(IMethodSymbol m) => Inspect.IsPartial(m, token);
            }

            public static IEnumerable<Diagnostic> HasAtLeastOneOption(
                ITypeSymbol type,
                MethodDeclarationSyntax syntax,
                IMethodSymbol variantOf,
                ImmutableArray<IParameterSymbol> options,
                CancellationToken token)
            {
                if (options.IsEmpty)
                {
                    yield return MakeError(
                        nameof(HasAtLeastOneOption),
                        "'VariantOf()' must have at least one parameter.",
                        $"Variant types must have at least one parameter in their 'VariantOf()' method.",
                        LocationOfFirstToken(syntax, SyntaxKind.IdentifierToken));
                }
            }

            public static IEnumerable<Diagnostic> NotTooManyOptions(
                ITypeSymbol type,
                MethodDeclarationSyntax syntax,
                IMethodSymbol variantOf,
                ImmutableArray<IParameterSymbol> options,
                CancellationToken token)
            {
                const int max = byte.MaxValue;

                if (options.Count() > max)
                {
                    yield return MakeError(
                        nameof(NotTooManyOptions),
                        $"'VariantOf()' must not have more than {max} parameters.",
                        $"Variant types must not have more than {max} parameters in their 'VariantOf()' method.",
                        LocationOfFirstToken(syntax, SyntaxKind.IdentifierToken));
                }
            }

            public static IEnumerable<Diagnostic> HasNoDuplicateOptions(
                ITypeSymbol type,
                MethodDeclarationSyntax syntax,
                IMethodSymbol variantOf,
                ImmutableArray<IParameterSymbol> options,
                CancellationToken token)
            {
                var distinctOptions =
                    options
                    .Select(p => p.Type)
                    .Distinct(SymbolEqualityComparer.Default);

                if (distinctOptions.Count() < options.Length)
                {
                    yield return MakeError(
                        nameof(HasNoDuplicateOptions),
                        "'VariantOf()' parameters contain duplicate types.",
                        $"The parameter types specified in the 'VariantOf' method must not contain duplicates, or contain types which only differ by nullability annotation.",
                        LocationOfFirstToken(syntax, SyntaxKind.IdentifierToken));
                }
            }

            public static IEnumerable<Diagnostic> HasNoReservedName(
                ITypeSymbol type,
                MethodDeclarationSyntax syntax,
                IMethodSymbol variantOf,
                ImmutableArray<IParameterSymbol> options,
                CancellationToken token)
            {
                foreach (var p in options)
                {
                    if (p.Name.StartsWith("_"))
                    {
                        yield return MakeError(
                            nameof(HasNoReservedName),
                            "'VariantOf()' parameter name must not begin with '_'.",
                            $"Names beginning with '_' are reserved for identifiers used within the generated implementation.",
                            p.Locations[0]);
                    }
                }
            }

            public static IEnumerable<Diagnostic> NoImplicitConversionForBaseClasses(
                ITypeSymbol type,
                MethodDeclarationSyntax syntax,
                IMethodSymbol variantOf,
                ImmutableArray<IParameterSymbol> options,
                CancellationToken token)
            {
                foreach (var p in options)
                {
                    if (Inspect.IsAncestorOf(p.Type, type))
                    {
                        yield return MakeWarning(
                            nameof(NoImplicitConversionForBaseClasses),
                            "No implicit conversion for base class option.",
                            $"Option '{p.Name}' has type '{p.Type.ToDisplayString()}', which is a base class of {type.Name} and thus no implicit conversion from '{p.Type.ToDisplayString()}' to '{type.Name}' will be created.",
                            p.Locations[0]);
                    }
                }
            }

            public static IEnumerable<Diagnostic> NoImplicitConversionForInterfaces(
                ITypeSymbol type,
                MethodDeclarationSyntax syntax,
                IMethodSymbol variantOf,
                ImmutableArray<IParameterSymbol> options,
                CancellationToken token)
            {
                foreach (var p in options)
                {
                    if (p.Type.TypeKind == TypeKind.Interface)
                    {
                        yield return MakeWarning(
                            nameof(NoImplicitConversionForInterfaces),
                            "No implicit conversion for interface option.",
                            $"Option '{p.Name}' has type '{p.Type.ToDisplayString()}', which is an interface and thus no implicit conversion from '{p.Type.ToDisplayString()}' to '{type.Name}' will be created.",
                            p.Locations[0]);
                    }
                }
            }

            private static Diagnostic MakeError(string id, string title, string message, Location location)
                => MakeDiagnostic(id, title, message, location, DiagnosticSeverity.Error, WellKnownDiagnosticTags.NotConfigurable);

            private static Diagnostic MakeWarning(string id, string title, string message, Location location)
                => MakeDiagnostic(id, title, message, location, DiagnosticSeverity.Warning);

            private static Diagnostic MakeDiagnostic(string id, string title, string message, Location location, DiagnosticSeverity severity, params string[] customTags)
                => Diagnostic.Create(
                    new DiagnosticDescriptor(
                        $"{nameof(dotVariant)}.{id}",
                        title,
                        message,
                        "dotVariant",
                        severity,
                        true,
                        customTags: customTags),
                    location);

            private static Location LocationOfFirstToken(SyntaxNode syntax, params SyntaxKind[] kind)
                => syntax.ChildTokens().First(t => kind.Contains(t.Kind())).GetLocation();

            private static Location LocationOfParameterList(SyntaxNode syntax)
                => ((MethodDeclarationSyntax)syntax).ParameterList.GetLocation();
        }
    }
}
