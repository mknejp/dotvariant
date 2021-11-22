//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable enable
namespace Foo
{
    [dotVariant.Variant]
    public partial class Variant<T1, T2, T3>
        where T1 : class, System.IDisposable
        where T2 : notnull
        where T3 : struct
    {
        static partial void VariantOf(T1 a, T2 b, T3 c);
    }
}
