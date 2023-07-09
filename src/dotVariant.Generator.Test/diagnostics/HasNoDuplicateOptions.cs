// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

#nullable enable
[dotVariant.Variant]
partial class Variant1
{
    static partial void VariantOf(int a, int b); // expected-error:25 dotVariant.HasNoDuplicateOptions
}

[dotVariant.Variant]
partial class Variant2
{
    static partial void VariantOf(string a, string b); // expected-error:25 dotVariant.HasNoDuplicateOptions
}

[dotVariant.Variant]
partial class Variant3
{
    static partial void VariantOf(string a, string? b); // expected-error:25 dotVariant.HasNoDuplicateOptions
}

#nullable disable
[dotVariant.Variant]
partial class Variant4
{
    static partial void VariantOf(string a, string b); // expected-error:25 dotVariant.HasNoDuplicateOptions
}

[dotVariant.Variant]
partial class Variant5
{
    static partial void VariantOf(string a, string! b); // expected-error:25 dotVariant.HasNoDuplicateOptions
}
