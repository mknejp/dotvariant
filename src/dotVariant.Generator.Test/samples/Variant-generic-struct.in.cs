// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

#nullable enable
namespace Foo
{
    [dotVariant.Variant]
    public partial class Variant<T>
        where T : struct
    {
        static partial void VariantOf(T value);
    }
}
