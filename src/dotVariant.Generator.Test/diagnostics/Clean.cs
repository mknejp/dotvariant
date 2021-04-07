//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

[dotVariant.Variant]
partial class Variant1
{
    static partial void VariantOf(int a, float b);
}

[dotVariant.Variant]
partial struct Variant2
{
    static partial void VariantOf(int a, float b, string c);
}

[dotVariant.Variant]
ref partial struct Variant3
{
    static partial void VariantOf(int a, float b, string c);
}

[dotVariant.Variant]
readonly partial struct Variant4
{
    static partial void VariantOf(int a, float b, string c);
}

[dotVariant.Variant]
partial class Variant5
{
    static partial void VariantOf(int a, int? b);
}

#nullable enable
[dotVariant.Variant]
partial class Variant6
{
    static partial void VariantOf(int a, string? b);
}

[dotVariant.Variant]
partial class Variant7
{
    static partial void VariantOf(int a, string b);
}

#nullable disable
[dotVariant.Variant]
partial class Variant8
{
    static partial void VariantOf(int a, string b);
}
