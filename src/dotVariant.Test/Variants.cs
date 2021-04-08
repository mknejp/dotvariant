//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

namespace dotVariant.Test.Variants
{
    [Variant]
    internal sealed partial class Class_int_float_string
    {
        static partial void VariantOf(int i, float f, string s);
    }

    [Variant]
    internal sealed partial class Class_int_float_object
    {
        static partial void VariantOf(int i, float f, Helper o);
    }

    [Variant]
    internal readonly partial struct Struct_int_float_object
    {
        static partial void VariantOf(int i, float f, Helper o);
    }

    [Variant]
    internal sealed partial class Class_with_default_ctor
    {
        static partial void VariantOf(int i, float f, Helper o);

        public Class_with_default_ctor()
        {
            _variant = default;
        }
    }

#if NULLABLE_ENABLED

    [Variant]
    internal sealed partial class Class_int_float_nullable
    {
        static partial void VariantOf(int i, float f, Helper? o);
    }

#endif
}
