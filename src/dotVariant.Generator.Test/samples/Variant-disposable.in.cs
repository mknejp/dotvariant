//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

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
