// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

using dotVariant.Test.Variants;
using NUnit.Framework;

namespace dotVariant.Test
{
    public static partial class Variant_Test
    {
        public static new class ToString
        {
            [Test]
            public static void ToString_forwards_to_value_1()
            {
                var a = new Class_int_float_object(1);
                Assert.That(a.ToString(), Is.EqualTo(1.ToString()));
            }

            [Test]
            public static void ToString_forwards_to_value_2()
            {
                var a = new Class_int_float_object(1f);
                Assert.That(a.ToString(), Is.EqualTo(1f.ToString()));
            }

            [Test]
            public static void ToString_forwards_to_value_3()
            {
                var a = new Class_int_float_object(new ClassWithToString("s"));
                Assert.That(a.ToString(), Is.EqualTo("s"));
            }

            [Test]
            public static void Empty_variant_has_empty_ToString()
            {
                var a = new Class_with_default_ctor();
                Assert.That(a.ToString(), Is.EqualTo(""));
            }
        }
    }
}
