// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

[dotVariant.Variant]
partial class Variant1
{
    static partial void VariantOf(int a, object b); // expected-warning:49 dotVariant.NoImplicitConversionForBaseClasses
}

[dotVariant.Variant]
partial class Variant2
{
    static partial void VariantOf(int a, [dotVariant.NoImplicitConversion] object b);
}
