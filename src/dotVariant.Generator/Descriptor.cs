//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;

namespace dotVariant.Generator
{
    internal sealed record Descriptor(
        ITypeSymbol Type,
        TypeDeclarationSyntax Syntax,
        ImmutableArray<IParameterSymbol> Options,
        NullableContext NullableContext
        // TODO: emptiness possible?
        // TODO: user-defined constructors
        // TODO: user-defined ToString()
        // TODO: user-defined Equals()
        // TODO: user-defined GetHashCode()
        // TODO: user-defined Dispose()
        // TODO: nested class
        )
    {
        public static Descriptor FromDeclaration(
            ITypeSymbol type,
            TypeDeclarationSyntax syntax,
            NullableContext nullability)
        {
            var options = Inspect.GetOptions(type);
            return new(type, syntax, options, nullability);
        }
    }
}
