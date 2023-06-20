//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace dotVariant.Generator;

public readonly record struct VariantDecl(INamedTypeSymbol Symbol, TypeDeclarationSyntax Syntax,
    NullableContext Nullable, IEnumerable<Diagnostic> Diags)
{
    public const string AttributeName = nameof(dotVariant) + "." + nameof(VariantAttribute);
}
