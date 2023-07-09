// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dotVariant.Generator.Test
{
    internal static partial class RenderInfo_Test
    {
        [TestCaseSource(nameof(ParamsTestCases))]
        public static void Params(string source, Action<RenderInfo> check)
        {
            var ris = GetRenderInfoFromCompilation(source);
            Assert.That(ris, Is.Not.Empty);
            check(ris[0]);
        }

        public static IEnumerable<TestCaseData> ParamsTestCases()
            => new (string Name, string Source, Action<RenderInfo> Check)[]
            {
                (
                    "parameters: 1",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(int a);
                    }",
                    ri => Assert.That(ri.Params.Length, Is.EqualTo(1))
                ),
                (
                    "parameters: 2",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(int a, double b);
                    }",
                    ri => Assert.That(ri.Params.Length, Is.EqualTo(2))
                ),
                (
                    "parameters: 3",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(int a, double b, string c);
                    }",
                    ri => Assert.That(ri.Params.Length, Is.EqualTo(3))
                ),
                (
                    "1-based index",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(int a, double b, string c);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Params[0].Index, Is.EqualTo(1));
                        Assert.That(ri.Params[1].Index, Is.EqualTo(2));
                        Assert.That(ri.Params[2].Index, Is.EqualTo(3));
                    })
                ),
                (
                    "identifier and name",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(int a, double b, string c);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Params[0].Identifier, Is.EqualTo("a"));
                        Assert.That(ri.Params[1].Identifier, Is.EqualTo("b"));
                        Assert.That(ri.Params[2].Identifier, Is.EqualTo("c"));
                        Assert.That(ri.Params[0].Name, Is.EqualTo("a"));
                        Assert.That(ri.Params[1].Name, Is.EqualTo("b"));
                        Assert.That(ri.Params[2].Name, Is.EqualTo("c"));
                    })
                ),
                (
                    "escaped identifier and name",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(int @true);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Params[0].Identifier, Is.EqualTo("@true"));
                        Assert.That(ri.Params[0].Name, Is.EqualTo("true"));
                    })
                ),
                (
                    "qualified type with type parameters",
                    @"
                    using System;
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(Action<TimeSpan> a);
                    }",
                    ri => Assert.That(ri.Params[0].Type, Is.EqualTo("global::System.Action<global::System.TimeSpan>"))
                ),
                (
                    "qualified type with generic type",
                    @"
                    using System;
                    [dotVariant.Variant]
                    public partial class Variant<T>
                    {
                        static partial void VariantOf(Action<T> a);
                    }",
                    ri => Assert.That(ri.Params[0].Type, Is.EqualTo("global::System.Action<T>"))
                ),
                (
                    "diagnostic type with type parameters",
                    @"
                    using System;
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(Action<TimeSpan> a);
                    }",
                    ri => Assert.That(ri.Params[0].DiagType, Is.EqualTo("System.Action<System.TimeSpan>"))
                ),
                (
                    "diagnostic type with generic type",
                    @"
                    using System;
                    [dotVariant.Variant]
                    public partial class Variant<T>
                    {
                        static partial void VariantOf(Action<T> a);
                    }",
                    ri => Assert.That(ri.Params[0].DiagType, Is.EqualTo("System.Action<T>"))
                ),
                (
                    "emit implicit cast",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(int a);
                    }",
                    ri => Assert.That(ri.Params[0].EmitImplicitCast, Is.True)
                ),
                (
                    "emit no implicit cast for explicitly attributed parameters",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf([dotVariant.NoImplicitConversion] int a);
                    }",
                    ri => Assert.That(ri.Params[0].EmitImplicitCast, Is.False)
                ),
                (
                    "emit no implicit cast for base types",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(object a);
                    }",
                    ri => Assert.That(ri.Params[0].EmitImplicitCast, Is.False)
                ),
                (
                    "emit no implicit cast for interfaces",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(System.IDisposable a);
                    }",
                    ri => Assert.That(ri.Params[0].EmitImplicitCast, Is.False)
                ),
                (
                    "object padding",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(TwoObjects a, OneObject b, NoObjects c, OneNestedObject d, int e, string f, System.TimeSpan g);

                        struct TwoObjects
                        {
                            public string a;
                            public string b;
                        }
                        struct OneObject
                        {
                            public string a;
                            public int b;
                        }
                        struct NoObjects
                        {
                            public int a;
                            public int b;
                        }
                        struct OneNestedObject
                        {
                            struct OneObject
                            {
                                public string a;
                            }
                            public OneObejct a;
                            public int b;
                        }
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Params[0].ObjectPadding, Is.EqualTo(0));
                        Assert.That(ri.Params[1].ObjectPadding, Is.EqualTo(1));
                        Assert.That(ri.Params[2].ObjectPadding, Is.EqualTo(2));
                        Assert.That(ri.Params[3].ObjectPadding, Is.EqualTo(1));
                        Assert.That(ri.Params[4].ObjectPadding, Is.EqualTo(2));
                        Assert.That(ri.Params[5].ObjectPadding, Is.EqualTo(1));
                        Assert.That(ri.Params[6].ObjectPadding, Is.EqualTo(2));
                    })
                ),
            }
            .Select(test => new TestCaseData(test.Source, test.Check).SetName($"{nameof(Params)}({test.Name})"));
    }
}
