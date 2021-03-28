[dotVariant.Variant]
static partial class Variant1 // expected-error:1 dotVariant.IsNotStatic
{
    static partial void VariantOf(int a, float b);
}
