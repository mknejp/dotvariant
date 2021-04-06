//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using dotVariant.Test.Variants;
using NUnit.Framework;

namespace dotVariant.Test
{
    public class Variant_Test
    {
        // Don't use NUnit's equality comparison as it has builtin short-circuiting
        public static class Equality
        {
            [Test]
            public static void Empty_struct_variants_are_equal()
            {
                var a = new Struct_int_float_object();
                var b = new Struct_int_float_object();

                Assert.Multiple(() =>
                {
                    Assert.That(a.Equals(b), Is.True);
                    Assert.That(b.Equals(a), Is.True);
                    Assert.That(a.Equals((object)b), Is.True);
                    Assert.That(b.Equals((object)a), Is.True);
                    Assert.That(a == b, Is.True);
                    Assert.That(b == a, Is.True);
                    Assert.That(a != b, Is.False);
                    Assert.That(b != a, Is.False);
                });
            }

            [Test]
            public static void Empty_class_variants_are_equal()
            {
                var a = new Class_with_default_ctor();
                var b = new Class_with_default_ctor();

                Assert.Multiple(() =>
                {
                    Assert.That(a.Equals(b), Is.True);
                    Assert.That(b.Equals(a), Is.True);
                    Assert.That(a.Equals((object)b), Is.True);
                    Assert.That(b.Equals((object)a), Is.True);
                    Assert.That(a == b, Is.True);
                    Assert.That(b == a, Is.True);
                    Assert.That(a != b, Is.False);
                    Assert.That(b != a, Is.False);
                });
            }

            [Test]
            public static void Empty_struct_variants_dont_equal_non_empty()
            {
                var a = new Struct_int_float_object();
                var b = new Struct_int_float_object(1);

                Assert.Multiple(() =>
                {
                    Assert.That(a.Equals(b), Is.False);
                    Assert.That(b.Equals(a), Is.False);
                    Assert.That(a.Equals((object)b), Is.False);
                    Assert.That(b.Equals((object)a), Is.False);
                    Assert.That(a == b, Is.False);
                    Assert.That(b == a, Is.False);
                    Assert.That(a != b, Is.True);
                    Assert.That(b != a, Is.True);
                });
            }

            [Test]
            public static void Empty_class_variants_dont_equal_non_empty()
            {
                var a = new Class_with_default_ctor();
                var b = new Class_with_default_ctor(1);

                Assert.Multiple(() =>
                {
                    Assert.That(a.Equals(b), Is.False);
                    Assert.That(b.Equals(a), Is.False);
                    Assert.That(a.Equals((object)b), Is.False);
                    Assert.That(b.Equals((object)a), Is.False);
                    Assert.That(a == b, Is.False);
                    Assert.That(b == a, Is.False);
                    Assert.That(a != b, Is.True);
                    Assert.That(b != a, Is.True);
                });
            }

            [Test]
            public static void Class_variants_dont_compare_equal_to_null()
            {
                var a = new Class_int_float_string(1);

                Assert.Multiple(() =>
                {
                    Assert.That(a.Equals(null), Is.False);
                    Assert.That(a!.Equals((object?)null), Is.False);

                    Assert.That(a == null, Is.False);
                    Assert.That(null == a, Is.False);

                    Assert.That(a == (object?)null, Is.False);
                    Assert.That((object?)null == a, Is.False);

                    Assert.That(a != null, Is.True);
                    Assert.That(null != a, Is.True);

                    Assert.That(a != (object?)null, Is.True);
                    Assert.That((object?)null != a, Is.True);
                });
            }

            [Test]
            public static void Variants_with_equal_values_are_equal()
            {
                var a = new Class_int_float_string(1);
                var b = new Class_int_float_string(1);

                Assert.Multiple(() =>
                {
                    Assert.That(a.Equals(b), Is.True);
                    Assert.That(b.Equals(a), Is.True);
                    Assert.That(a.Equals((object)b), Is.True);
                    Assert.That(b.Equals((object)a), Is.True);
                    Assert.That(a == b, Is.True);
                    Assert.That(b == a, Is.True);
                    Assert.That(a != b, Is.False);
                    Assert.That(b != a, Is.False);
                });
            }

            [Test]
            public static void Variants_with_inequal_values_are_inequal()
            {
                var a = new Class_int_float_string(1);
                var b = new Class_int_float_string(2);

                Assert.Multiple(() =>
                {
                    Assert.That(a.Equals(b), Is.False);
                    Assert.That(b.Equals(a), Is.False);
                    Assert.That(a.Equals((object)b), Is.False);
                    Assert.That(b.Equals((object)a), Is.False);
                    Assert.That(a == b, Is.False);
                    Assert.That(b == a, Is.False);
                    Assert.That(a != b, Is.True);
                    Assert.That(b != a, Is.True);
                });
            }

            [Test]
            public static void Variants_with_equal_objects_are_equal()
            {
                var a = new Class_int_float_object(new AlwaysEqual());
                var b = new Class_int_float_object(new AlwaysEqual());

                Assert.Multiple(() =>
                {
                    Assert.That(a.Equals(b), Is.True);
                    Assert.That(b.Equals(a), Is.True);
                    Assert.That(a.Equals((object)b), Is.True);
                    Assert.That(b.Equals((object)a), Is.True);
                    Assert.That(a == b, Is.True);
                    Assert.That(b == a, Is.True);
                    Assert.That(a != b, Is.False);
                    Assert.That(b != a, Is.False);
                });
            }

            [Test]
            public static void Variants_with_inequal_objects_are_inequal()
            {
                var a = new Class_int_float_object(new NeverEqual());
                var b = new Class_int_float_object(new NeverEqual());

                Assert.Multiple(() =>
                {
                    Assert.That(a.Equals(b), Is.False);
                    Assert.That(b.Equals(a), Is.False);
                    Assert.That(a.Equals((object)b), Is.False);
                    Assert.That(b.Equals((object)a), Is.False);
                    Assert.That(a == b, Is.False);
                    Assert.That(b == a, Is.False);
                    Assert.That(a != b, Is.True);
                    Assert.That(b != a, Is.True);
                });
            }

            // TODO: handle nullability correctly
            //[Test]
            //public static void Null_reference_types()
            //{
            //    var s = default(string);
            //    var a = new Variant_int_float_string(s);
            //    var b = Variant_int_float_string.Create(s);
            //    var c = (Variant_int_float_string)s;

            //    Assert.Multiple(() =>
            //    {
            //        Assert.That(a.Equals(b), Is.True);
            //        Assert.That(b.Equals(a), Is.True);
            //        Assert.That(a.Equals((object)b), Is.True);
            //        Assert.That(b.Equals((object)a), Is.True);
            //        Assert.That(a == b, Is.True);
            //        Assert.That(b == a, Is.True);
            //        Assert.That(a != b, Is.False);
            //        Assert.That(b != a, Is.False);

            //        Assert.That(a.Equals(c), Is.True);
            //        Assert.That(c.Equals(a), Is.True);
            //        Assert.That(a.Equals((object)c), Is.True);
            //        Assert.That(c.Equals((object)a), Is.True);
            //        Assert.That(a == c, Is.True);
            //        Assert.That(c == a, Is.True);
            //        Assert.That(a != c, Is.False);
            //        Assert.That(c != a, Is.False);

            //        Assert.That(b.Equals(c), Is.True);
            //        Assert.That(c.Equals(b), Is.True);
            //        Assert.That(b.Equals((object)c), Is.True);
            //        Assert.That(c.Equals((object)b), Is.True);
            //        Assert.That(b == c, Is.True);
            //        Assert.That(c == b, Is.True);
            //        Assert.That(b != c, Is.False);
            //        Assert.That(c != b, Is.False);
            //    });
            //}

        }
    }
}
