//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using dotVariant.Test.Variants;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace dotVariant.Test
{
    public static partial class Variant_Test
    {
        public static class IEnumerable_Ex
        {
            [Test]
            public static void Match_transforms_matching_elements_and_drops_rest_1()
            {
                var input = new Class_int_float_string[]
                {
                    1, 2f, "3", 4, 5f, "6",
                };

                Assert.That(
                    input.Match((int x) => x * 3),
                    Is.EqualTo(new[] { 3, 12 }));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_drops_rest_2()
            {
                var input = new Class_int_float_string[]
                {
                    1, 2f, "3", 4, 5f, "6",
                };

                Assert.That(
                    input.Match((float x) => x * 3),
                    Is.EqualTo(new[] { 2f * 3, 5f * 3 }));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_drops_rest_3()
            {
                var input = new Class_int_float_string[]
                {
                    1, 2f, "3", 4, 5f, "6",
                };

                Assert.That(
                    input.Match((string x) => x + x),
                    Is.EqualTo(new[] { "33", "66" }));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_value_1()
            {
                var input = new Class_int_float_string[]
                {
                    1, 2f, "3", 4, 5f, "6",
                };

                Assert.That(
                    input.Match((int x) => x * 3, -1),
                    Is.EqualTo(new[] { 3, -1, -1, 12, -1, -1 }));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_value_2()
            {
                var input = new Class_int_float_string[]
                {
                    1, 2f, "3", 4, 5f, "6",
                };

                Assert.That(
                    input.Match((float x) => x * 3, -1f),
                    Is.EqualTo(new[] { -1f, 2f * 3, -1f, -1f, 5f * 3, -1f }));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_value_3()
            {
                var input = new Class_int_float_string[]
                {
                    1, 2f, "3", 4, 5f, "6",
                };

                Assert.That(
                    input.Match((string x) => x + x, "-"),
                    Is.EqualTo(new[] { "-", "-", "33", "-", "-", "66" }));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_selector_1()
            {
                var input = new Class_int_float_string[]
                {
                    1, 2f, "3", 4, 5f, "6",
                };

                Assert.That(
                    input.Match((int x) => x * 3, () => -1),
                    Is.EqualTo(new[] { 3, -1, -1, 12, -1, -1 }));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_selector_2()
            {
                var input = new Class_int_float_string[]
                {
                    1, 2f, "3", 4, 5f, "6",
                };

                Assert.That(
                    input.Match((float x) => x * 3, () => -1f),
                    Is.EqualTo(new[] { -1f, 2f * 3, -1f, -1f, 5f * 3, -1f }));
            }

            [Test]
            public static void Match_transforms_matching_elements_and_replaces_rest_with_fallback_selector_3()
            {
                var input = new Class_int_float_string[]
                {
                    1, 2f, "3", 4, 5f, "6",
                };

                Assert.That(
                    input.Match((string x) => x + x, () => "-"),
                    Is.EqualTo(new[] { "-", "-", "33", "-", "-", "66" }));
            }

            [Test]
            public static void Visit_transforms_each_element()
            {
                var input = new Class_int_float_string[]
                {
                    1, 2f, "3", 4, 5f, "6",
                };

                Assert.That(
                    input.Visit(
                        (int x) => $"int: {x}",
                        (float x) => $"float: {x}",
                        (string x) => $"string: {x}"),
                    Is.EqualTo(new[]
                    {
                        "int: 1", "float: 2", "string: 3", "int: 4", "float: 5", "string: 6",
                    }));
            }

            [Test]
            public static void Visit_throws_on_empty_element()
            {
                var input = new Struct_int_float_object[]
                {
                    1, 2f, default,
                };

                var processed = new List<string>();
                Assert.That(
                    () =>
                        input.Visit(
                            (int x) => $"int",
                            (float x) => $"float",
                            (Helper x) => $"Helper")
                        .ForEach(processed.Add),
                    Throws.InvalidOperationException);
                Assert.That(processed, Is.EqualTo(new[] { "int", "float" }));
            }

            [Test]
            public static void Visit_transforms_each_element_and_calls_empty_fallback()
            {
                var input = new Struct_int_float_object[]
                {
                    1, 2f, default,
                };

                Assert.That(
                    input.Visit(
                        (int x) => $"int",
                        (float x) => $"float",
                        (Helper x) => $"Helper",
                        () => "empty"),
                    Is.EqualTo(new[] { "int", "float", "empty" }));
            }
        }
    }
}
