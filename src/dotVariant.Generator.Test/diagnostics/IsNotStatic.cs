// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

[dotVariant.Variant]
static partial class Variant1 // expected-error:1 dotVariant.IsNotStatic
{
    static partial void VariantOf(int a, float b);
}
