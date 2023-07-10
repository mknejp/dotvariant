// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;

namespace dotVariant.Generator
{
    public readonly record struct Descriptor(
        INamedTypeSymbol Type,
        TypeDeclarationSyntax Syntax,
        ImmutableArray<IParameterSymbol> Options,
        NullableContext NullableContext)
    {
        public static Descriptor FromDeclaration(
            SemanticType type,
            NullableContext nullability)
        {
            var options = Inspect.GetOptions(type.Symbol);
            return new(type.Symbol, type.Syntax, options, nullability);
        }

        public string HintName => $"{Type.ToString()
            // If the type contains type parameters replace angle brackets as those are not allowed in AddSource()
            .Replace('<', '{')
            .Replace('>', '}')
            // Escaped names like @class or @event aren't supported either
            .Replace('@', '.')}.cs";
    }
}
