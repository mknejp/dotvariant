//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis.CSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using static dotVariant.Generator.Test.GeneratorTools;

namespace dotVariant.Generator.Test
{
    [TestOf(typeof(RenderInfo))]
    [Parallelizable(ParallelScope.All)]
    internal static class RenderInfo_Test
    {
        [TestCaseSource(nameof(VariantTestCases))]
        public static void Variant(string source, Action<RenderInfo> check)
        {
            var ris = GetRenderInfoFromCompilation(source);
            Assert.That(ris, Is.Not.Empty);
            check(ris[0]);
        }

        [TestCaseSource(nameof(ParamsTestCases))]
        public static void Params(string source, Action<RenderInfo> check)
        {
            var ris = GetRenderInfoFromCompilation(source);
            Assert.That(ris, Is.Not.Empty);
            check(ris[0]);
        }

        [TestCaseSource(nameof(ExtensionClassNamespaceTestCases))]
        public static void ExtensionClassNamespace(string source, Dictionary<string, string> properties, Action<RenderInfo> check)
        {
            var ris = GetRenderInfoFromCompilation(source, properties.ToImmutableDictionary());
            Assert.That(ris, Is.Not.Empty);
            check(ris[0]);
        }

        private static ImmutableArray<RenderInfo> GetRenderInfoFromCompilation(string source, ImmutableDictionary<string, string>? msBuildProperties = null)
        {
            var compilation = Compile(SupportSources.Add("input", source));
            var generator = new SourceGenerator();
            var driver = CSharpGeneratorDriver.Create(
                new[] { generator },
                optionsProvider: new AnalyzerConfigOptionsProvider(msBuildProperties));
            _ = driver.RunGeneratorsAndUpdateCompilation(compilation, out var _, out var _);
            return generator.RenderInfos;
        }

        public static IEnumerable<TestCaseData> VariantTestCases()
            => new (string Name, string Source, Action<RenderInfo> Check)[]
                {
                    ///////////////////////////////////////////////////////////
                    // VariantInfo properties
                    //
                    (
                        "type name",
                        @"
                        [dotVariant.Variant]
                        public partial class XyzVariant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.That(ri.Variant.Name, Is.EqualTo("XyzVariant"))
                    ),
                    (
                        "namespace name",
                        @"
                        namespace Foo.Bar
                        {
                            [dotVariant.Variant]
                            public partial class XyzVariant
                            {
                                static partial void VariantOf(int a, float b);
                            }
                        }",
                        ri => Assert.Multiple(() =>
                        {
                            Assert.That(ri.Variant.Namespace, Is.EqualTo("Foo.Bar"));
                            Assert.That(ri.Options.ExtensionClassNamespace, Is.EqualTo("Foo.Bar"));
                        })
                    ),
                    (
                        "global namespace",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.That(ri.Variant.Namespace, Is.Null)
                    ),
                    (
                        "diagnostic name",
                        @"
                        namespace Foo.Bar
                        {
                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(int a, float b);
                            }
                        }",
                        ri => Assert.That(ri.Variant.DiagName, Is.EqualTo("Foo.Bar.Variant"))
                    ),
                    (
                        "class type",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.Multiple(() =>
                        {
                            Assert.That(ri.Variant.IsClass, Is.True);
                            Assert.That(ri.Variant.Keyword, Is.EqualTo("class"));
                        })
                    ),
                    (
                        "struct type",
                        @"
                        [dotVariant.Variant]
                        public partial struct Variant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.Multiple(() =>
                        {
                            Assert.That(ri.Variant.IsClass, Is.False);
                            Assert.That(ri.Variant.Keyword, Is.EqualTo("struct"));
                        })
                    ),
                    (
                        "classes are nullable",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.That(ri.Variant.Nullability, Is.EqualTo("nullable"))
                    ),
                    (
                        "struct are nonnull",
                        @"
                        [dotVariant.Variant]
                        public partial struct Variant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.That(ri.Variant.Nullability, Is.EqualTo("nonnull"))
                    ),
                    (
                        "non-readonly struct type",
                        @"
                        [dotVariant.Variant]
                        public partial struct Variant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.That(ri.Variant.IsReadonly, Is.False)
                    ),
                    (
                        "readonly struct type",
                        @"
                        [dotVariant.Variant]
                        public readonly partial struct Variant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.That(ri.Variant.IsReadonly, Is.True)
                    ),
                    (
                        "public extensions methods",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.That(ri.Variant.ExtensionsAccessibility, Is.EqualTo("public"))
                    ),
                    (
                        "internal extensions methods",
                        @"
                        [dotVariant.Variant]
                        internal partial class Variant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.That(ri.Variant.ExtensionsAccessibility, Is.EqualTo("internal"))
                    ),
                    (
                        "Dispose: false",
                        @"
                        [dotVariant.Variant]
                        internal partial class Variant
                        {
                            static partial void VariantOf(int a, System.IO.Stream b);
                        }",
                        ri => Assert.That(ri.Variant.UserDefined.Dispose, Is.False)
                    ),
                    (
                        "Dispose: user-defined",
                        @"
                        [dotVariant.Variant]
                        internal partial class Variant
                        {
                            static partial void VariantOf(int a, System.IO.Stream b);
                            public void Dispose() {}
                        }",
                        ri => Assert.That(ri.Variant.UserDefined.Dispose, Is.True)
                    ),
                    (
                        "Dispose: implementated explicitly",
                        @"
                        [dotVariant.Variant]
                        internal partial class Variant : System.IDisposable
                        {
                            static partial void VariantOf(int a, System.IO.Stream b);
                            void System.IDisposable.Dispose() {}
                        }",
                        ri => Assert.That(ri.Variant.UserDefined.Dispose, Is.True)
                    ),
                    (
                        "Dispose: implementated",
                        @"
                        [dotVariant.Variant]
                        internal partial class Variant : System.IDisposable
                        {
                            static partial void VariantOf(int a, System.IO.Stream b);
                            public void Dispose() {}
                        }",
                        ri => Assert.That(ri.Variant.UserDefined.Dispose, Is.True)
                    ),
                    (
                        "Dispose: implementated in base",
                        @"
                        class Base : System.IDisposable
                        {
                            public void Dispose() {}
                        }
                        [dotVariant.Variant]
                        internal partial class Variant : Base
                        {
                            static partial void VariantOf(int a, System.IO.Stream b);
                        }",
                        ri => Assert.That(ri.Variant.UserDefined.Dispose, Is.True)
                    ),
                }
                .Select(test => new TestCaseData(test.Source, test.Check).SetName($"{nameof(Variant)}({test.Name})"));

        public static IEnumerable<TestCaseData> ParamsTestCases()
            => new (string Name, string Source, Action<RenderInfo> Check)[]
                {
                    (
                        "parametrs: 1",
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
                        "hint",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int foobar);
                        }",
                        ri => Assert.That(ri.Params[0].Hint, Is.EqualTo("foobar"))
                    ),
                    (
                        "fully qualified type name",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(System.TimeSpan a);
                        }",
                        ri => Assert.That(ri.Params[0].Name, Is.EqualTo("global::System.TimeSpan"))
                    ),
                    (
                        "shortened specila type name",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a);
                        }",
                        ri => Assert.That(ri.Params[0].Name, Is.EqualTo("int"))
                    ),
                    (
                        "diagnostic type name",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(System.TimeStamp a);
                        }",
                        ri => Assert.That(ri.Params[0].DiagName, Is.EqualTo("System.TimeStamp"))
                    ),
                    (
                        "diagnostic special type name",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a);
                        }",
                        ri => Assert.That(ri.Params[0].DiagName, Is.EqualTo("int"))
                    ),
                    (
                        "class type",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(string a);
                        }",
                        ri => Assert.That(ri.Params[0].IsClass, Is.True)
                    ),
                    (
                        "struct type",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(System.TimeSpan a, int b, System.AttributeTargets c);
                        }",
                        ri => Assert.Multiple(() =>
                        {
                            Assert.That(ri.Params[0].IsClass, Is.False);
                            Assert.That(ri.Params[1].IsClass, Is.False);
                            Assert.That(ri.Params[2].IsClass, Is.False);
                        })
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
                        "disposable: false",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(object a);
                        }",
                        ri => Assert.That(ri.Params[0].IsDisposable, Is.False)
                    ),
                    (
                        "disposable: true",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(System.IO.Stream a);
                        }",
                        ri => Assert.That(ri.Params[0].IsDisposable, Is.True)
                    ),
                    (
                        "nonnull value type",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a);
                        }",
                        ri => Assert.That(ri.Params[0].Nullability, Is.EqualTo("nonnull"))
                    ),
                    (
                        "nullable value type",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int? a);
                        }",
                        ri => Assert.That(ri.Params[0].Nullability, Is.EqualTo("nullable"))
                    ),
                    (
                        "nullable class type in nullable-disable context",
                        @"
                        #nullable disable
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(string a);
                        }",
                        ri => Assert.That(ri.Params[0].Nullability, Is.EqualTo("nullable"))
                    ),
                    (
                        "nullable class type in nullable-enable context",
                        @"
                        #nullable enable
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(string? a);
                        }",
                        ri => Assert.That(ri.Params[0].Nullability, Is.EqualTo("nullable"))
                    ),
                    (
                        "nonnull class type in nullable-enable context",
                        @"
                        #nullable enable
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(string a);
                        }",
                        ri => Assert.That(ri.Params[0].Nullability, Is.EqualTo("nonnull"))
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
                    (
                        "ToString returns nonull string for most class types",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(string a);
                        }",
                        ri => Assert.That(ri.Params[0].ToStringNullability, Is.EqualTo("nonnull"))
                    ),
                    (
                        "ToString returns nullable string for some class types",
                        @"
                        #nullable enable
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(object a); // ToString() returns string?
                        }",
                        ri => Assert.That(ri.Params[0].ToStringNullability, Is.EqualTo("nullable"))
                    ),
                    (
                        "ToString returns nonnull for struct types",
                        @"
                        #nullable enable
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a);
                        }",
                        ri => Assert.That(ri.Params[0].ToStringNullability, Is.EqualTo("nonnull"))
                    ),
                    (
                        "ToString returns nullable for nullable value types",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int? a);
                        }",
                        ri => Assert.That(ri.Params[0].ToStringNullability, Is.EqualTo("nullable"))
                    ),
                }
                .Select(test => new TestCaseData(test.Source, test.Check).SetName($"{nameof(Params)}({test.Name})"));

        public static IEnumerable<TestCaseData> ExtensionClassNamespaceTestCases()
            => new (string Name, string Source, string ExtensionClassNamespace, Action<RenderInfo> Check)[]
                {
                    (
                        "global namespace with empty property",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a);
                        }",
                        "",
                        ri => Assert.That(ri.Options.ExtensionClassNamespace, Is.Null)
                    ),
                    (
                        "global namespace with non-empty property",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a);
                        }",
                        "Baz.Qux",
                        ri => Assert.That(ri.Options.ExtensionClassNamespace, Is.EqualTo("Baz.Qux"))
                    ),
                    (
                        "non-global namespace with empty property",
                        @"
                        namespace Foo.Bar
                        {
                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(int a);
                            }
                        }",
                        "",
                        ri => Assert.That(ri.Options.ExtensionClassNamespace, Is.EqualTo("Foo.Bar"))
                    ),
                    (
                        "non-global namespace with non-empty property",
                        @"
                        namespace Foo.Bar
                        {
                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(int a);
                            }
                        }",
                        "Baz.Qux",
                        ri => Assert.That(ri.Options.ExtensionClassNamespace, Is.EqualTo("Baz.Qux"))
                    ),
                    (
                        "property dots are trimmed",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a);
                        }",
                        ".Baz.Qux.",
                        ri => Assert.That(ri.Options.ExtensionClassNamespace, Is.EqualTo("Baz.Qux"))
                    ),
                }
                .Select(test =>
                    new TestCaseData(
                        test.Source,
                        new Dictionary<string, string> { ["dotVariant-ExtensionClassNamespace"] = test.ExtensionClassNamespace },
                        test.Check)
                    .SetName($"{nameof(ExtensionClassNamespace)}({test.Name})"));
    }
}
