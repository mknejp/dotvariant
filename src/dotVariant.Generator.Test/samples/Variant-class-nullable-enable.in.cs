// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

#nullable enable
namespace Foo
{
    [dotVariant.Variant]
    public partial class Variant_class_nullable_enable
    {
        static partial void VariantOf(int i, float f, string s, System.Array? a);
    }
}
