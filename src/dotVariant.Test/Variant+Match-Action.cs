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
                var called = false;
                v.Match((int x) => { Assert.That(x, Is.EqualTo(1)); called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }

            [Test]
            public static void Match_succeeds_on_active_value_2()
            {
                var v = new Class_int_float_string(1f);
                var called = false;
                v.Match((float x) => { Assert.That(x, Is.EqualTo(1f)); called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }

            [Test]
            public static void Match_succeeds_on_active_value_3()
            {
                var v = new Class_int_float_string("s");
                var called = false;
                v.Match((string x) => { Assert.That(x, Is.EqualTo("s")); called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }

            [Test]
            public static void Match_fails_on_inactive_value_1()
            {
                var v = new Class_int_float_string(1);
                Assert.That(() => v.Match((float _) => { }),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: float").And.Message.Contains("actual: int"));
                Assert.That(() => v.Match((string _) => { }),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: string").And.Message.Contains("actual: int"));
            }

            [Test]
            public static void Match_fails_on_inactive_value_2()
            {
                var v = new Class_int_float_string(1f);
                Assert.That(() => v.Match((int _) => { }),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: int").And.Message.Contains("actual: float"));
                Assert.That(() => v.Match((string _) => { }),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: string").And.Message.Contains("actual: float"));
            }

            [Test]
            public static void Match_fails_on_inactive_value_3()
            {
                var v = new Class_int_float_string("s");
                Assert.That(() => v.Match((int _) => { }),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: int").And.Message.Contains("actual: string"));
                Assert.That(() => v.Match((float _) => { }),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: float").And.Message.Contains("actual: string"));
            }

            [Test]
            public static void Match_fails_on_empty_variant()
            {
                var v = new Class_with_default_ctor();
                Assert.That(() => v.Match((int _) => { }),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: int").And.Message.Contains("actual: <empty>"));
                Assert.That(() => v.Match((float _) => { }),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: float").And.Message.Contains("actual: <empty>"));
                Assert.That(() => v.Match((Helper _) => { }),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: dotVariant.Test.Helper").And.Message.Contains("actual: <empty>"));
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_1_1()
            {
                var v = new Class_int_float_string(1);
                var called = false;
                v.Match((float _) => { Assert.Fail("wrong delegate called"); }, () => { called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_1_2()
            {
                var v = new Class_int_float_string(1);
                var called = false;
                v.Match((string _) => { Assert.Fail("wrong delegate called"); }, () => { called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_2_1()
            {
                var v = new Class_int_float_string(1f);
                var called = false;
                v.Match((int _) => { Assert.Fail("wrong delegate called"); }, () => { called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_2_2()
            {
                var v = new Class_int_float_string(1f);
                var called = false;
                v.Match((string _) => { Assert.Fail("wrong delegate called"); }, () => { called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_3_1()
            {
                var v = new Class_int_float_string("s");
                var called = false;
                v.Match((int _) => { Assert.Fail("wrong delegate called"); }, () => { called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }

            [Test]
            public static void Match_calls_alternative_on_inactive_value_3_2()
            {
                var v = new Class_int_float_string("s");
                var called = false;
                v.Match((float _) => { Assert.Fail("wrong delegate called"); }, () => { called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }

            [Test]
            public static void Match_calls_alternative_on_empty_value_1()
            {
                var v = new Class_with_default_ctor();
                var called = false;
                v.Match((int _) => { Assert.Fail("wrong delegate called"); }, () => { called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }

            [Test]
            public static void Match_calls_alternative_on_empty_value_2()
            {
                var v = new Class_with_default_ctor();
                var called = false;
                v.Match((float _) => { Assert.Fail("wrong delegate called"); }, () => { called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }

            [Test]
            public static void Match_calls_alternative_on_empty_value_3()
            {
                var v = new Class_with_default_ctor();
                var called = false;
                v.Match((Helper _) => { Assert.Fail("wrong delegate called"); }, () => { called = true; });
                Assert.That(called, Is.True, "delegate not called");
            }
        }
    }
}
