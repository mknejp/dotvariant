// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

[dotVariant.Variant]
partial class Variant1
{
    static partial void VariantOf(int a, System.Collections.IEnumerable b); // expected-warning:73 dotVariant.NoImplicitConversionForInterfaces
}

[dotVariant.Variant]
partial class Variant2
{
    static partial void VariantOf(int a, [dotVariant.NoImplicitConversion] System.Collections.IEnumerable b);
}
