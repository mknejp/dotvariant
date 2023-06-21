//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable enable
namespace Foo
{
    [dotVariant.Variant]
    public partial class Variant<T>
    {
        static partial void VariantOf(T value);
    }


    [dotVariant.Variant]
    internal partial class Variant<T1, T2>
    {
        static partial void VariantOf(T1 value1, T2 value2);
    }
}
