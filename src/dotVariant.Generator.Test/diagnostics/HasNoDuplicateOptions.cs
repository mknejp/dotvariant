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
