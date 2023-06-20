//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace dotVariant.Generator;

public readonly record struct CompilationInfo(LanguageVersion LanguageVersion, bool HasReactive,
    INamedTypeSymbol DisposableInterface, bool HasHashCode)
{
    public static CompilationInfo FromCompilation(CSharpCompilation compilation)
    {
        var hasReactive = compilation.GetTypeByMetadataName("System.Reactive.Linq.Observable") is not null;
        var disposableInterface = compilation.GetTypeByMetadataName("System.IDisposable")!;
        var hasHashCode = compilation.GetTypeByMetadataName("System.HashCode") is not null;
        return new(compilation.LanguageVersion, hasReactive, disposableInterface, hasHashCode);
    }
}
