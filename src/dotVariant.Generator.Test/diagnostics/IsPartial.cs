// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

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
