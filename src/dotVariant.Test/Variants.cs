//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using NUnit.Framework;
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
    internal sealed partial class InternalVariant
    {
        static partial void VariantOf(int a, string b);
    }

    [Variant]
    public sealed partial class PublicVariant
    {
        static partial void VariantOf(int a, string b);
    }

    public static class TypeLoadTest
    {
        [Test]
        public static void Load()
        {
            Assert.That(
                () => new object[]
                {
                    // Make sure we don't get any TypeLoadException
                    new Class_int_float_string("s"),
                    new Class_int_float_object(new Helper()),
                    new Struct_int_float_object(new Helper()),
                    new Class_with_default_ctor(),
#if NULLABLE_ENABLED
                    new Class_int_float_nullable(default(Helper?)),
#endif
                    new Class_int(1),
                    new DisposableVariant(new Disposable(() => { })),
                    new DisposableVariantWithImpl(new Disposable(() => { })),
                    new InternalVariant(1),
                    new PublicVariant(1),
                },
                Throws.Nothing);
        }
    }
}
