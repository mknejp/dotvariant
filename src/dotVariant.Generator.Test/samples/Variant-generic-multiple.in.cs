// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

#nullable enable
namespace Foo
{
    [dotVariant.Variant]
    public partial class Variant<T1, T2, T3>
        where T1 : class, System.IDisposable
        where T2 : notnull
        where T3 : struct
    {
        static partial void VariantOf(T1 a, T2 b, T3 c);
    }
}
