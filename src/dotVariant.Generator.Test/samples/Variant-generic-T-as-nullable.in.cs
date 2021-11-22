//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable enable
namespace Foo
{
    [dotVariant.Variant]
    public sealed partial class Variant<T1, T2, T3, T4, T5, T6>
        where T1 : class
        where T2 : struct
        where T3 : class?
        where T4 : unmanaged
        where T5 : notnull
    {
        // Regardless of type parameter constraints,
        // if the user asks for nullable here we have to honor it.
        static partial void VariantOf(T1? a, T2? b, T3? c, T4? d, T5? e, T6? f);
    }
}
