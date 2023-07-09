// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

using dotVariant.Test.Variants;
using NUnit.Framework;

namespace dotVariant.Test
{
    public static partial class Variant_Test
    {
        public static class Visit
        {
            [Test]
            public static void Visit_calls_corresponding_action_1()
            {
                var v = new Class_int_float_string(1);
                var called = false;
                v.Visit(
                    x => { Assert.That(x, Is.EqualTo(1)); called = true; },
                    _ => { Assert.Fail("wrong delegate called"); },
                    _ => { Assert.Fail("wrong delegate called"); });
                Assert.That(called, Is.True, "no delegate called");
            }

            [Test]
            public static void Visit_calls_corresponding_action_2()
            {
                var v = new Class_int_float_string(1f);
                var called = false;
                v.Visit(
                    _ => { Assert.Fail("wrong delegate called"); },
                    x => { Assert.That(x, Is.EqualTo(1f)); called = true; },
                    _ => { Assert.Fail("wrong delegate called"); });
                Assert.That(called, Is.True, "no delegate called");
            }

            [Test]
            public static void Visit_calls_corresponding_action_3()
            {
                var v = new Class_int_float_string("s");
                var called = false;
                v.Visit(
                    _ => { Assert.Fail("wrong delegate called"); },
                    _ => { Assert.Fail("wrong delegate called"); },
                    x => { Assert.That(x, Is.EqualTo("s")); called = true; });
                Assert.That(called, Is.True, "no delegate called");
            }

            [Test]
            public static void Visit_with_action_fails_on_empty_variant()
            {
                var v = new Class_with_default_ctor();
                Assert.That(
                    () => v.Visit(
                        _ => { Assert.Fail("wrong delegate called"); },
                        _ => { Assert.Fail("wrong delegate called"); },
                        _ => { Assert.Fail("wrong delegate called"); }),
                    Throws.InvalidOperationException);
            }

            [Test]
            public static void Visit_with_action_calls_empty_handler()
            {
                var v = new Class_with_default_ctor();
                v.Visit(
                    _ => { Assert.Fail("wrong delegate called"); },
                    _ => { Assert.Fail("wrong delegate called"); },
                    _ => { Assert.Fail("wrong delegate called"); },
                    () => { Assert.Pass(); });
                Assert.Fail("no delegate called");
            }

            [Test]
            public static void Visit_calls_corresponding_function_1()
            {
                var v = new Class_int_float_string(1);
                Assert.That(
                    v.Visit(
                        _ => "a",
                        _ => "b",
                        _ => "c"),
                    Is.EqualTo("a"));
            }

            [Test]
            public static void Visit_calls_corresponding_function_2()
            {
                var v = new Class_int_float_string(1f);
                Assert.That(
                    v.Visit(
                        _ => "a",
                        _ => "b",
                        _ => "c"),
                    Is.EqualTo("b"));
            }

            [Test]
            public static void Visit_calls_corresponding_function_3()
            {
                var v = new Class_int_float_object(new Helper());
                Assert.That(
                    v.Visit(
                        _ => "a",
                        _ => "b",
                        _ => "c"),
                    Is.EqualTo("c"));
            }

            [Test]
            public static void Visit_with_function_fails_on_empty_variant()
            {
                var v = new Class_with_default_ctor();
                Assert.That(
                    () => v.Visit(
                        _ => "a",
                        _ => "b",
                        _ => "c"),
                    Throws.InvalidOperationException);
            }

            [Test]
            public static void Visit_with_function_calles_empty_handler()
            {
                var v = new Class_with_default_ctor();
                Assert.That(
                    v.Visit(
                        _ => "a",
                        _ => "b",
                        _ => "c",
                        () => "d"),
                    Is.EqualTo("d"));
            }
        }
    }
}
