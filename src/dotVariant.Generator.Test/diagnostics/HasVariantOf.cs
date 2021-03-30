//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

[dotVariant.Variant]
partial class Variant1 // expected-error:15 dotVariant.HasVariantOf
{
}

[dotVariant.Variant]
partial class Variant2
{
    // not static
    partial void VariantOf(int a, string b); // expected-error:18 dotVariant.HasVariantOf
}

[dotVariant.Variant]
partial class Variant3
{
    // not partial
    static void VariantOf(int a, string b); // expected-error:17 dotVariant.HasVariantOf
}

[dotVariant.Variant]
partial class Variant4
{
    // partial but with implementation
    static partial void VariantOf(int a, string b); // expected-error:25 dotVariant.HasVariantOf
}
partial class Variant4
{
    static partial void VariantOf(int a, string b) { }
}

[dotVariant.Variant]
partial class Variant5
{
    // Multiple methods with same name
    static partial void VariantOf(int a, string b); // expected-error:25 dotVariant.HasVariantOf
    static partial void VariantOf(int a, object b);
}
