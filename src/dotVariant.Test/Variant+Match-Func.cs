//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using dotVariant.Test.Variants;
using NUnit.Framework;

namespace dotVariant.Test
{
    public static partial class Variant_Test
    {
        public static class Match_Func
        {
            [Test]
            public static void Match_succeeds_on_active_value_1()
            {
                var v = new Class_int_float_string(1);
                Assert.That(v.Match((int x) => x), Is.EqualTo(1));
            }

            [Test]
            public static void Match_succeeds_on_active_value_2()
            {
                var v = new Class_int_float_string(1f);
                Assert.That(v.Match((float x) => x), Is.EqualTo(1f));
            }

            [Test]
            public static void Match_succeeds_on_active_value_3()
            {
                var v = new Class_int_float_string("s");
                Assert.That(v.Match((string x) => x), Is.EqualTo("s"));
            }

            [Test]
            public static void Match_fails_on_inactive_value_1()
            {
                var v = new Class_int_float_string(1);
                Assert.That(() => v.Match((float x) => x), Throws.InvalidOperationException);
                Assert.That(() => v.Match((string x) => x), Throws.InvalidOperationException);
            }

            [Test]
            public static void Match_fails_on_inactive_value_2()
            {
                var v = new Class_int_float_string(1f);
                Assert.That(() => v.Match((int x) => x), Throws.InvalidOperationException);
                Assert.That(() => v.Match((string x) => x), Throws.InvalidOperationException);
            }

            [Test]
            public static void Match_fails_on_inactive_value_3()
            {
                var v = new Class_int_float_string("s");
                Assert.That(() => v.Match((int x) => x), Throws.InvalidOperationException);
                Assert.That(() => v.Match((float x) => x), Throws.InvalidOperationException);
            }

            [Test]
            public static void Match_fails_on_empty_variant()
            {
                var v = new Class_with_default_ctor();
                Assert.That(() => v.Match((int x) => x), Throws.InvalidOperationException);
                Assert.That(() => v.Match((float x) => x), Throws.InvalidOperationException);
                Assert.That(() => v.Match((Helper x) => x), Throws.InvalidOperationException);
            }

            [Test]
            public static void Match_returns_alternative_value_on_inactive_value_1()
            {
                var v = new Class_int_float_string(1);
                Assert.That(v.Match((float x) => x, 1f), Is.EqualTo(1f));
                Assert.That(v.Match((string x) => x, "s"), Is.EqualTo("s"));
            }

            [Test]
            public static void Match_returns_alternative_value_on_inactive_value_2()
            {
                var v = new Class_int_float_string(1f);
                Assert.That(v.Match((int x) => x, 1), Is.EqualTo(1));
                Assert.That(v.Match((string x) => x, "s"), Is.EqualTo("s"));
            }

            [Test]
            public static void Match_returns_alternative_value_on_inactive_value_3()
            {
                var v = new Class_int_float_string("s");
                Assert.That(v.Match((int x) => x, 1), Is.EqualTo(1));
                Assert.That(v.Match((float x) => x, 1f), Is.EqualTo(1f));
            }

            [Test]
            public static void Match_calls_alternative_function_on_inactive_value_1()
            {
                var v = new Class_int_float_string(1);
                Assert.That(v.Match((float x) => x, () => 1f), Is.EqualTo(1f));
                Assert.That(v.Match((string x) => x, () => "s"), Is.EqualTo("s"));
            }

            [Test]
            public static void Match_calls_alternative_function_on_inactive_value_2()
            {
                var v = new Class_int_float_string(1f);
                Assert.That(v.Match((int x) => x, () => 1), Is.EqualTo(1));
                Assert.That(v.Match((string x) => x, () => "s"), Is.EqualTo("s"));
            }

            [Test]
            public static void Match_calls_alternative_function_on_inactive_value_3()
            {
                var v = new Class_int_float_string("s");
                Assert.That(v.Match((int x) => x, () => 1), Is.EqualTo(1));
                Assert.That(v.Match((float x) => x, () => 1f), Is.EqualTo(1f));
            }

            [Test]
            public static void Match_calls_alternative_on_empty_value()
            {
                var v = new Class_with_default_ctor();
                var helper = new Helper();
                Assert.That(v.Match((int x) => x, () => 1), Is.EqualTo(1));
                Assert.That(v.Match((float x) => x, () => 1f), Is.EqualTo(1f));
                Assert.That(v.Match((Helper x) => x, helper), Is.SameAs(helper));
            }
        }
    }
}
