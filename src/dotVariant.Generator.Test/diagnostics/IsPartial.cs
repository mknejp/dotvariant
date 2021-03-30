//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

[dotVariant.Variant]
class Variant1 // expected-error:1 dotVariant.IsPartial
{
    static partial void VariantOf(int a, float b);
}

[dotVariant.Variant]
struct Variant2 // expected-error:1 dotVariant.IsPartial
{
    static partial void VariantOf(int a, float b);
}

[dotVariant.Variant]
ref struct Variant3 // expected-error:5 dotVariant.IsPartial
{
    static partial void VariantOf(int a, float b);
}

[dotVariant.Variant]
readonly struct Variant4 // expected-error:10 dotVariant.IsPartial
{
    static partial void VariantOf(int a, float b);
}
