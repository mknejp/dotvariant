// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

using dotVariant.Test.Variants;
using NUnit.Framework;

namespace dotVariant.Test
{
    public static partial class Variant_Test
    {
        public static class Match_out
        {
            [Test]
            public static void Match_succeeds_on_active_value_1()
            {
                var v = new Class_int_float_string(1);
                v.Match(out int x);
                Assert.That(x, Is.EqualTo(1));
            }

            [Test]
            public static void Match_succeeds_on_active_value_2()
            {
                var v = new Class_int_float_string(1f);
                v.Match(out float x);
                Assert.That(x, Is.EqualTo(1f));
            }

            [Test]
            public static void Match_succeeds_on_active_value_3()
            {
                var v = new Class_int_float_string("s");
#if NULLABLE_ENABLED
                v.Match(out string? x);
#else
                v.Match(out string x);
#endif
                Assert.That(x, Is.SameAs("s"));
            }

            [Test]
            public static void Match_fails_on_inactive_value_1()
            {
                var v = new Class_int_float_string(1);
                Assert.That(() => v.Match(out float _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: float").And.Message.Contains("actual: int"));
#if NULLABLE_ENABLED
                Assert.That(() => v.Match(out string? _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: string").And.Message.Contains("actual: int"));
#else
                Assert.That(() => v.Match(out string _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: string").And.Message.Contains("actual: int"));
#endif
            }

            [Test]
            public static void Match_fails_on_inactive_value_2()
            {
                var v = new Class_int_float_string(1f);
                Assert.That(() => v.Match(out int _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: int").And.Message.Contains("actual: float"));
#if NULLABLE_ENABLED
                Assert.That(() => v.Match(out string? _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: string").And.Message.Contains("actual: float"));
#else
                Assert.That(() => v.Match(out string _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: string").And.Message.Contains("actual: float"));
#endif
            }

            [Test]
            public static void Match_fails_on_inactive_value_3()
            {
                var v = new Class_int_float_string("s");
                Assert.That(() => v.Match(out int _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: int").And.Message.Contains("actual: string"));
                Assert.That(() => v.Match(out float _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: float").And.Message.Contains("actual: string"));
            }

            [Test]
            public static void Match_fails_on_empty_variant()
            {
                var v = new Class_with_default_ctor();
                Assert.That(() => v.Match(out int _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: int").And.Message.Contains("actual: <empty>"));
                Assert.That(() => v.Match(out float _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: float").And.Message.Contains("actual: <empty>"));
#if NULLABLE_ENABLED
                Assert.That(() => v.Match(out Helper? _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: dotVariant.Test.Helper").And.Message.Contains("actual: <empty>"));
#else
                Assert.That(() => v.Match(out Helper _),
                    Throws.InvalidOperationException
                    .With.Message.Contains("expected: dotVariant.Test.Helper").And.Message.Contains("actual: <empty>"));
#endif
            }
        }
    }
}
