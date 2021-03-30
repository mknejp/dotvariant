//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

[dotVariant.Variant]
partial class Variant1
{
    static partial void VariantOf(int a, float _); // expected-error:48 dotVariant.HasNoReservedName
}

[dotVariant.Variant]
partial class Variant2
{
    static partial void VariantOf(int _a, float b); // expected-error:39 dotVariant.HasNoReservedName
}

[dotVariant.Variant]
partial class Variant3
{
    static partial void VariantOf(int a, float _2); // expected-error:48 dotVariant.HasNoReservedName
}
