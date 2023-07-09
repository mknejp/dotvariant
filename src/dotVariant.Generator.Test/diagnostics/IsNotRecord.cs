// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

[dotVariant.Variant]
partial record Variant1 // expected-error:9 dotVariant.IsNotRecord
{
    static partial void VariantOf(int a, float b);
}
