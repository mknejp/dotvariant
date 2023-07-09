// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

[dotVariant.Variant]
partial class Variant1
{
    static partial void VariantOf(); // expected-error:25 dotVariant.HasAtLeastOneOption
}
