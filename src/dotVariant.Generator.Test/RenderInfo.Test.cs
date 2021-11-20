//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
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

        [TestCaseSource(nameof(ParamTypeTestCases))]
        public static void ParamType(string source, Action<RenderInfo.ParamInfo> check)
        {
            var ris = GetRenderInfoFromCompilation(source);
            Assert.That(ris, Is.Not.Empty);
            check(ris[0].Params[0]);
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
            _ = driver.RunGeneratorsAndUpdateCompilation(compilation, out var _, out var diagnostics);
            Assert.That(diagnostics, Has.None.Matches((Diagnostic d) => d.Severity == DiagnosticSeverity.Error));
            return generator.RenderInfos;
        }

        public static IEnumerable<TestCaseData> VariantTestCases()
            => new (string Name, string Source, Action<RenderInfo> Check)[]
                {
                    ///////////////////////////////////////////////////////////
                    // VariantInfo properties
                    //
                    (
                        "identifier",
                        @"
                        [dotVariant.Variant]
                        public partial class XyzVariant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.That(ri.Variant.Identifier, Is.EqualTo("XyzVariant"))
                    ),
                    (
                        "type",
                        @"
                        [dotVariant.Variant]
                        public partial class XyzVariant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.Multiple(() =>
                        {
                            Assert.That(ri.Variant.Type, Is.EqualTo("XyzVariant"));
                            Assert.That(ri.Variant.QualifiedType, Is.EqualTo("global::XyzVariant"));
                        })
                    ),
                    (
                        "type with namespace",
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
                            Assert.That(ri.Variant.Type, Is.EqualTo("XyzVariant"));
                            Assert.That(ri.Variant.QualifiedType, Is.EqualTo("global::Foo.Bar.XyzVariant"));
                        })
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
                        "diagnostic type",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a, float b);
                        }",
                        ri => Assert.That(ri.Variant.DiagType, Is.EqualTo("Variant"))
                    ),
                    (
                        "diagnostic type with namesapce",
                        @"
                        namespace Foo.Bar
                        {
                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(int a, float b);
                            }
                        }",
                        ri => Assert.That(ri.Variant.DiagType, Is.EqualTo("Foo.Bar.Variant"))
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
                            Assert.That(ri.Variant.CanBeNull, Is.True);
                            Assert.That(ri.Variant.IsReferenceType, Is.True);
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
                            Assert.That(ri.Variant.CanBeNull, Is.False);
                            Assert.That(ri.Variant.IsReferenceType, Is.False);
                            Assert.That(ri.Variant.Keyword, Is.EqualTo("struct"));
                        })
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
                        "identifier",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a, double b, string c;
                        }",
                        ri => Assert.Multiple(() =>
                        {
                            Assert.That(ri.Params[0].Identifier, Is.EqualTo("a"));
                            Assert.That(ri.Params[1].Identifier, Is.EqualTo("b"));
                            Assert.That(ri.Params[2].Identifier, Is.EqualTo("c"));
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
                        "ToString returns notnull string for most class types",
                        @"
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(string a);
                        }",
                        ri => Assert.That(ri.Params[0].ToStringNullability, Is.EqualTo("notnull"))
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
                        "ToString returns notnull for struct types",
                        @"
                        #nullable enable
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(int a);
                        }",
                        ri => Assert.That(ri.Params[0].ToStringNullability, Is.EqualTo("notnull"))
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

        public static IEnumerable<TestCaseData> ParamTypeTestCases()
            => new (string Name, string Source, Action<RenderInfo.ParamInfo> Check)[]
                {
                    (
                        "struct",
                        @"
                        namespace N
                        {
                            struct S {}

                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(S a);
                            }
                        }",
                        p => Assert.Multiple(() =>
                        {
                            Assert.That(p.CanBeNull, Is.False, nameof(p.CanBeNull));
                            Assert.That(p.DiagType, Is.EqualTo("N.S"), nameof(p.DiagType));
                            Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                            Assert.That(p.OutType, Is.EqualTo("global::N.S"), nameof(p.OutType));
                            Assert.That(p.Type, Is.EqualTo("global::N.S"), nameof(p.Type));
                        })
                    ),
                    (
                        "special: int",
                        @"
                        namespace N
                        {
                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(System.Int32 a);
                            }
                        }",
                        p => Assert.Multiple(() =>
                        {
                            Assert.That(p.CanBeNull, Is.False, nameof(p.CanBeNull));
                            Assert.That(p.DiagType, Is.EqualTo("int"), nameof(p.DiagType));
                            Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                            Assert.That(p.OutType, Is.EqualTo("int"), nameof(p.OutType));
                            Assert.That(p.Type, Is.EqualTo("int"), nameof(p.Type));
                        })
                    ),
                    (
                        "special: string",
                        @"
                        namespace N
                        {
                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(System.String a);
                            }
                        }",
                        p => Assert.Multiple(() =>
                        {
                            Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                            Assert.That(p.DiagType, Is.EqualTo("string"), nameof(p.DiagType));
                            Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                            Assert.That(p.OutType, Is.EqualTo("string"), nameof(p.OutType));
                            Assert.That(p.Type, Is.EqualTo("string"), nameof(p.Type));
                        })
                    ),
                    (
                        "struct? - nullable disable",
                        @"
                        namespace N
                        {
                            struct S {}

                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(S? a);
                            }
                        }",
                        p => Assert.Multiple(() =>
                        {
                            Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                            Assert.That(p.DiagType, Is.EqualTo("N.S?"), nameof(p.DiagType));
                            Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                            Assert.That(p.OutType, Is.EqualTo("global::N.S?"), nameof(p.OutType));
                            Assert.That(p.Type, Is.EqualTo("global::N.S?"), nameof(p.Type));
                        })
                    ),
                    (
                        "struct? - nullable enable",
                        @"
                        namespace N
                        {
                            struct S {}

                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(S? a);
                            }
                        }",
                        p => Assert.Multiple(() =>
                        {
                            Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                            Assert.That(p.DiagType, Is.EqualTo("N.S?"), nameof(p.DiagType));
                            Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                            Assert.That(p.OutType, Is.EqualTo("global::N.S?"), nameof(p.OutType));
                            Assert.That(p.Type, Is.EqualTo("global::N.S?"), nameof(p.Type));
                        })
                    ),
                    (
                        "class - nullable disable",
                        @"
                        #nullable disable
                        namespace N
                        {
                            class C {}

                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(C a);
                            }
                        }",
                        p => Assert.Multiple(() =>
                        {
                            Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                            Assert.That(p.DiagType, Is.EqualTo("N.C"), nameof(p.DiagType));
                            Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                            Assert.That(p.OutType, Is.EqualTo("global::N.C"), nameof(p.OutType));
                            Assert.That(p.Type, Is.EqualTo("global::N.C"), nameof(p.Type));
                        })
                    ),
                    (
                        "class - nullable enable",
                        @"
                        #nullable enable
                        namespace N
                        {
                            class C {}

                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(C a);
                            }
                        }",
                        p => Assert.Multiple(() =>
                        {
                            Assert.That(p.CanBeNull, Is.False, nameof(p.CanBeNull));
                            Assert.That(p.DiagType, Is.EqualTo("N.C"), nameof(p.DiagType));
                            Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                            Assert.That(p.OutType, Is.EqualTo("global::N.C?"), nameof(p.OutType));
                            Assert.That(p.Type, Is.EqualTo("global::N.C"), nameof(p.Type));
                        })
                    ),
                    (
                        "class? - nullable enable",
                        @"
                        #nullable enable
                        namespace N
                        {
                            class C {}

                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(C? a);
                            }
                        }",
                        p => Assert.Multiple(() =>
                        {
                            Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                            Assert.That(p.DiagType, Is.EqualTo("N.C"), nameof(p.DiagType));
                            Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                            Assert.That(p.OutType, Is.EqualTo("global::N.C?"), nameof(p.OutType));
                            Assert.That(p.Type, Is.EqualTo("global::N.C?"), nameof(p.Type));
                        })
                    ),
                    (
                        "delegate - nullable disable",
                        @"
                        #nullable disable
                        namespace N
                        {
                            delegate void D();

                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(D a);
                            }
                        }",
                        p => Assert.Multiple(() =>
                        {
                            Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                            Assert.That(p.DiagType, Is.EqualTo("N.D"), nameof(p.DiagType));
                            Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                            Assert.That(p.OutType, Is.EqualTo("global::N.D"), nameof(p.OutType));
                            Assert.That(p.Type, Is.EqualTo("global::N.D"), nameof(p.Type));
                        })
                    ),
                    (
                        "delegate - nullable enable",
                        @"
                        #nullable enable
                        namespace N
                        {
                            delegate void D();

                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(D a);
                            }
                        }",
                        p => Assert.Multiple(() =>
                        {
                            Assert.That(p.CanBeNull, Is.False, nameof(p.CanBeNull));
                            Assert.That(p.DiagType, Is.EqualTo("N.D"), nameof(p.DiagType));
                            Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                            Assert.That(p.OutType, Is.EqualTo("global::N.D?"), nameof(p.OutType));
                            Assert.That(p.Type, Is.EqualTo("global::N.D"), nameof(p.Type));
                        })
                    ),
                    (
                        "delegate? - nullable enable",
                        @"
                        #nullable enable
                        namespace N
                        {
                            delegate void D();

                            [dotVariant.Variant]
                            public partial class Variant
                            {
                                static partial void VariantOf(D? a);
                            }
                        }",
                        p => Assert.Multiple(() =>
                        {
                            Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                            Assert.That(p.DiagType, Is.EqualTo("N.D"), nameof(p.DiagType));
                            Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                            Assert.That(p.OutType, Is.EqualTo("global::N.D?"), nameof(p.OutType));
                            Assert.That(p.Type, Is.EqualTo("global::N.D?"), nameof(p.Type));
                        })
                    ),
                }
                .Select(test =>
                    new TestCaseData(test.Source, test.Check).SetName($"{nameof(ParamType)}({test.Name})"));

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
