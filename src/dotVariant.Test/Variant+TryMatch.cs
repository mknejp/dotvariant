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
        public static class TryMatch
        {
            [Test]
            public static void TryMatch_succeeds_on_active_value_1()
            {
                var v = new Class_int_float_string(1);
                Assert.That(v.TryMatch(out int x), Is.True);
                Assert.That(x, Is.EqualTo(1));
            }

            [Test]
            public static void TryMatch_succeeds_on_active_value_2()
            {
                var v = new Class_int_float_string(1f);
                Assert.That(v.TryMatch(out float x), Is.True);
                Assert.That(x, Is.EqualTo(1f));
            }

            [Test]
            public static void TryMatch_succeeds_on_active_value_3()
            {
                var v = new Class_int_float_string("s");
#if NULLABLE_ENABLED
                Assert.That(v.TryMatch(out string? x), Is.True);
#else
                Assert.That(v.TryMatch(out string x), Is.True);
#endif
                Assert.That(x, Is.EqualTo("s"));
            }

            [Test]
            public static void TryMatch_fails_on_inactive_value_1()
            {
                var v = new Class_int_float_string(1);
                Assert.That(v.TryMatch(out float _), Is.False);
                Assert.That(v.TryMatch(out string _), Is.False);
            }

            [Test]
            public static void TryMatch_fails_on_inactive_value_2()
            {
                var v = new Class_int_float_string(1f);
                Assert.That(v.TryMatch(out int _), Is.False);
                Assert.That(v.TryMatch(out string _), Is.False);
            }

            [Test]
            public static void TryMatch_fails_on_inactive_value_3()
            {
                var v = new Class_int_float_string("s");
                Assert.That(v.TryMatch(out int _), Is.False);
                Assert.That(v.TryMatch(out float _), Is.False);
            }

            [Test]
            public static void TryMatch_fails_on_empty_variant()
            {
                var v = new Struct_int_float_object();
                Assert.That(v.TryMatch(out int _), Is.False);
                Assert.That(v.TryMatch(out float _), Is.False);
#if NULLABLE_ENABLED
                Assert.That(v.TryMatch(out Helper? _), Is.False);
#else
                Assert.That(v.TryMatch(out Helper _), Is.False);
#endif
            }
        }
    }
}
