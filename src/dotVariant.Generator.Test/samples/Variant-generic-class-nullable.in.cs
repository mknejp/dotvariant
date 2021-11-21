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
        where T : class?
    {
        static partial void VariantOf(T value);
    }
}
