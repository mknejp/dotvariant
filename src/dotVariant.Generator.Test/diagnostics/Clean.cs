[dotVariant.Variant]
partial class Variant1
{
    static partial void VariantOf(int a, float b);
}

[dotVariant.Variant]
partial struct Variant2
{
    static partial void VariantOf(int a, object b, string c);
}

[dotVariant.Variant]
ref partial struct Variant3
{
    static partial void VariantOf(int a, object b, string c);
}

[dotVariant.Variant]
readonly partial struct Variant4
{
    static partial void VariantOf(int a, object b, string c);
}

[dotVariant.Variant]
partial class Variant5
{
    static partial void VariantOf(int a, int? b);
}
