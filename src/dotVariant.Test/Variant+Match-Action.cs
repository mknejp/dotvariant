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
        public static class Match_Action
        {
            [Test]
            public static void Match_succeeds_on_active_value_1()
            {
                var v = new Class_int_float_string(1);
                v.Match((int x) => { Assert.That(x, Is.EqualTo(1)); Assert.Pass(); });
                Assert.Fail("delegate not called");
            }

            [Test]
            public static void Match_succeeds_on_active_value_2()
            {
                var v = new Class_int_float_string(1f);
                v.Match((float x) => { Assert.That(x, Is.EqualTo(1f)); Assert.Pass(); });
                Assert.Fail("delegate not called");
            }

            [Test]
            public static void Match_succeeds_on_active_value_3()
            {
                var v = new Class_int_float_string("s");
                v.Match((string x) => { Assert.That(x, Is.EqualTo("s")); Assert.Pass(); });
                Assert.Fail("delegate not called");
            }

            [Test]
            public static void Match_fails_on_inactive_value_1()
            {
                var v = new Class_int_float_string(1);
                Assert.That(() => v.Match((float _) => { }), Throws.InvalidOperationException);
                Assert.That(() => v.Match((string _) => { }), Throws.InvalidOperationException);
            }

            [Test]
            public static void Match_fails_on_inactive_value_2()
            {
                var v = new Class_int_float_string(1f);
                Assert.That(() => v.Match((int _) => { }), Throws.InvalidOperationException);
                Assert.That(() => v.Match((string _) => { }), Throws.InvalidOperationException);
            }

            [Test]
            public static void Match_fails_on_inactive_value_3()
            {
                var v = new Class_int_float_string("s");
                Assert.That(() => v.Match((int _) => { }), Throws.InvalidOperationException);
                Assert.That(() => v.Match((float _) => { }), Throws.InvalidOperationException);
            }

            [Test]
            public static void Match_fails_on_empty_variant()
            {
                var v = new Class_with_default_ctor();
                Assert.That(() => v.Match((int _) => { }), Throws.InvalidOperationException);
                Assert.That(() => v.Match((float _) => { }), Throws.InvalidOperationException);
                Assert.That(() => v.Match((Helper _) => { }), Throws.InvalidOperationException);
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_1_1()
            {
                var v = new Class_int_float_string(1);
                v.Match((float _) => { Assert.Fail("wrong delegate called"); }, () => { Assert.Pass(); });
                Assert.Fail("no delegate called");
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_1_2()
            {
                var v = new Class_int_float_string(1);
                v.Match((string _) => { Assert.Fail("wrong delegate called"); }, () => { Assert.Pass(); });
                Assert.Fail("no delegate called");
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_2_1()
            {
                var v = new Class_int_float_string(1f);
                v.Match((int _) => { Assert.Fail("wrong delegate called"); }, () => { Assert.Pass(); });
                Assert.Fail("no delegate called");
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_2_2()
            {
                var v = new Class_int_float_string(1f);
                v.Match((string _) => { Assert.Fail("wrong delegate called"); }, () => { Assert.Pass(); });
                Assert.Fail("no delegate called");
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_3_1()
            {
                var v = new Class_int_float_string("s");
                v.Match((int _) => { Assert.Fail("wrong delegate called"); }, () => { Assert.Pass(); });
                Assert.Fail("no delegate called");
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_3_2()
            {
                var v = new Class_int_float_string("s");
                v.Match((float _) => { Assert.Fail("wrong delegate called"); }, () => { Assert.Pass(); });
                Assert.Fail("no delegate called");
            }

            [Test]
            public static void Match_calls_alternative_on_empty_value_1()
            {
                var v = new Class_with_default_ctor();
                v.Match((int _) => { Assert.Fail("wrong delegate called"); }, () => { Assert.Pass(); });
                Assert.Fail("no delegate called");
            }

            [Test]
            public static void Match_calls_alternative_on_empty_value_2()
            {
                var v = new Class_with_default_ctor();
                v.Match((float _) => { Assert.Fail("wrong delegate called"); }, () => { Assert.Pass(); });
                Assert.Fail("no delegate called");
            }

            [Test]
            public static void Match_calls_alternative_on_empty_value_3()
            {
                var v = new Class_with_default_ctor();
                v.Match((Helper _) => { Assert.Fail("wrong delegate called"); }, () => { Assert.Pass(); });
                Assert.Fail("no delegate called");
            }
        }
    }
}
