//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable disable

namespace Foo
{
    [dotVariant.Variant]
    partial class Variant_no_implicit_conversion
    {
        static partial void VariantOf([dotVariant.NoImplicitConversion] int i, string s);
    }
}
