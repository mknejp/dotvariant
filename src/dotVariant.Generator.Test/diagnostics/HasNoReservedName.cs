// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

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
