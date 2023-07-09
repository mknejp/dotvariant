// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

#nullable disable

namespace Foo
{
    [dotVariant.Variant]
    partial class Variant_no_implicit_conversion
    {
        static partial void VariantOf([dotVariant.NoImplicitConversion] int i, string s);
    }
}
