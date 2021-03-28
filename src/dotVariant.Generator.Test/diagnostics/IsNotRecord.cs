[dotVariant.Variant]
partial record Variant1 // expected-error:9 dotVariant.IsNotRecord
{
    static partial void VariantOf(int a, float b);
}
