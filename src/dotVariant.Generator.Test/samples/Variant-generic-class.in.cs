// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

#nullable enable
namespace Foo
{
    [dotVariant.Variant]
    public partial class Variant<T>
        where T : class
    {
        static partial void VariantOf(T value);
    }
}
