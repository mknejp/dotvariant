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
                Assert.That(() => v.Match(out float _), Throws.InvalidOperationException);
#if NULLABLE_ENABLED
                Assert.That(() => v.Match(out string? _), Throws.InvalidOperationException);
#else
                Assert.That(() => v.Match(out string _), Throws.InvalidOperationException);
#endif
            }

            [Test]
            public static void Match_fails_on_inactive_value_2()
            {
                var v = new Class_int_float_string(1f);
                Assert.That(() => v.Match(out int _), Throws.InvalidOperationException);
#if NULLABLE_ENABLED
                Assert.That(() => v.Match(out string? _), Throws.InvalidOperationException);
#else
                Assert.That(() => v.Match(out string _), Throws.InvalidOperationException);
#endif
            }

            [Test]
            public static void Match_fails_on_inactive_value_3()
            {
                var v = new Class_int_float_string("s");
                Assert.That(() => v.Match(out int _), Throws.InvalidOperationException);
                Assert.That(() => v.Match(out float _), Throws.InvalidOperationException);
            }

            [Test]
            public static void Match_fails_on_empty_variant()
            {
                var v = new Class_with_default_ctor();
                Assert.That(() => v.Match(out int _), Throws.InvalidOperationException);
                Assert.That(() => v.Match(out float _), Throws.InvalidOperationException);
#if NULLABLE_ENABLED
                Assert.That(() => v.Match(out Helper? _), Throws.InvalidOperationException);
#else
                Assert.That(() => v.Match(out Helper _), Throws.InvalidOperationException);
#endif
            }
        }
    }
}
