// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

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

#nullable restore
[dotVariant.Variant]
partial class Variant9
{
    static partial void VariantOf(int a);
}
