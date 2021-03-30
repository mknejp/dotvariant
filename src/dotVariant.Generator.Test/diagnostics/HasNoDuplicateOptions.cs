//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable enable
[dotVariant.Variant]
partial class Variant1
{
    static partial void VariantOf(int a, int b); // expected-error:25 dotVariant.HasNoDuplicateOptions
}

[dotVariant.Variant]
partial class Variant2
{
    static partial void VariantOf(object a, object b); // expected-error:25 dotVariant.HasNoDuplicateOptions
}

[dotVariant.Variant]
partial class Variant3
{
    static partial void VariantOf(object a, object? b); // expected-error:25 dotVariant.HasNoDuplicateOptions
}

#nullable disable
[dotVariant.Variant]
partial class Variant4
{
    static partial void VariantOf(object a, object b); // expected-error:25 dotVariant.HasNoDuplicateOptions
}

[dotVariant.Variant]
partial class Variant5
{
    static partial void VariantOf(object a, object! b); // expected-error:25 dotVariant.HasNoDuplicateOptions
}
