using System;

namespace dotVariant
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
    public sealed class VariantAttribute : Attribute
    {
        public VariantAttribute() { }
    }
}
