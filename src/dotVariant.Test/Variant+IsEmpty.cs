// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

using dotVariant.Test.Variants;
using NUnit.Framework;

namespace dotVariant.Test
{
    public static partial class Variant_Test
    {
        public static class IsEmpty
        {
            [Test]
            public static void Default_constructed_struct_variants_are_empty()
            {
                var a = new Struct_int_float_object();
                Assert.That(a.IsEmpty, Is.True);
            }

            [Test]
            public static void Default_constructed_class_variants_are_empty()
            {
                var a = new Class_with_default_ctor();
                Assert.That(a.IsEmpty, Is.True);
            }
        }
    }
}
