[dotVariant.Variant]
partial class Variant1
{
    static partial void VariantOf(); // expected-error:25 dotVariant.HasAtLeastTwoOptions
}

[dotVariant.Variant]
partial class Variant2
{
    static partial void VariantOf(int a); // expected-error:25 dotVariant.HasAtLeastTwoOptions
}
