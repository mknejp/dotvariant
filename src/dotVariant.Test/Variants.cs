//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using System;

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
    internal readonly partial struct Struct_int_float_string
    {
        static partial void VariantOf(int i, float f, string o);
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

    [Variant]
    internal sealed partial class Class_int
    {
        static partial void VariantOf(int i);
    }

    [Variant]
    internal sealed partial class DisposableVariant
    {
        static partial void VariantOf(int i, Disposable d);
    }

    [Variant]
    internal sealed partial class DisposableVariantWithImpl : IDisposable
    {
        static partial void VariantOf(int i, Disposable d);

        public void Dispose()
        {
            _variant.Dispose();
        }
    }

    [Variant]
    internal readonly partial struct NullableValueType
    {
        static partial void VariantOf(int? i);
    }

    [Variant]
    internal sealed partial class InternalVariant
    {
        static partial void VariantOf(int a, string b);
    }

    [Variant]
    public sealed partial class PublicVariant
    {
        static partial void VariantOf(int a, string b);
    }

    [Variant]
    public sealed partial class Generic<T>
    {
        static partial void VariantOf(T value);
    }

    [Variant]
    public sealed partial class Generic<T1, T2>
    {
        static partial void VariantOf(T1 a, T2 b);
    }

    [Variant]
    public sealed partial class Generic_class<T>
        where T : class
    {
        static partial void VariantOf(T value);
    }

    [Variant]
    public sealed partial class Generic_struct<T>
        where T : struct
    {
        static partial void VariantOf(T value);
    }

    [Variant]
    public sealed partial class Generic_unmanaged<T>
        where T : unmanaged
    {
        static partial void VariantOf(T value);
    }

    [Variant]
    public sealed partial class Generic_multiple<T1, T2, T3>
        where T1 : unmanaged
        where T2 : class, IDisposable
        where T3 : struct
    {
        static partial void VariantOf(T1 a, T2 b, T3 c);
    }

#if NULLABLE_ENABLED

    [Variant]
    public sealed partial class Generic_class_nullable<T>
        where T : class?
    {
        static partial void VariantOf(T value);
    }

    [Variant]
    public sealed partial class Generic_notnull<T>
        where T : notnull
    {
        static partial void VariantOf(T value);
    }

#endif
}

[dotVariant.Variant]
internal partial class GlobalVariant
{
    static partial void VariantOf(int a, string b);
}
