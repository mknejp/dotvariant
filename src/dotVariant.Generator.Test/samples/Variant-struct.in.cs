//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using dotVariant;
namespace Foo
{
    [Variant]
    public partial struct Variant_struct
    {
        static partial void VariantOf(long l, double d, object o);
    }
}
