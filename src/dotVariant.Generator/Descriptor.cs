// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;

namespace dotVariant.Generator
{
    public sealed record Descriptor(
        INamedTypeSymbol Type,
        TypeDeclarationSyntax Syntax,
        ImmutableArray<IParameterSymbol> Options,
        NullableContext NullableContext)
    {
        public static Descriptor FromDeclaration(
            INamedTypeSymbol type,
            TypeDeclarationSyntax syntax,
            NullableContext nullability)
        {
            var options = Inspect.GetOptions(type);
            return new(type, syntax, options, nullability);
        }
    }
}
