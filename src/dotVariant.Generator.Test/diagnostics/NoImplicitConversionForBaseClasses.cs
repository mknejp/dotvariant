//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

[dotVariant.Variant]
partial class Variant1
{
    static partial void VariantOf(int a, object b); // expected-warning:49 dotVariant.NoImplicitConversionForBaseClasses
}
