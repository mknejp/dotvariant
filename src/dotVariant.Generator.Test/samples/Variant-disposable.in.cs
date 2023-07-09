// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

#nullable disable
namespace Foo
{
    [dotVariant.Variant]
    public partial class Variant_disposable
    {
        // "stream" is disposable and we don't have a user-defined Dispose()
        // so we expect one to be generated.
        // The generated Dispose() is supposed to ignore "i" and dispose "stream".
        static partial void VariantOf(int i, System.IO.Stream stream);
    }
}
