//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

[dotVariant.Variant]
static partial class Variant1 // expected-error:1 dotVariant.IsNotStatic
{
    static partial void VariantOf(int a, float b);
}
