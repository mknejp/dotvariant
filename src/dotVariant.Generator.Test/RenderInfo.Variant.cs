//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dotVariant.Generator.Test
{
    internal static partial class RenderInfo_Test
    {
        [TestCaseSource(nameof(VariantTestCases))]
        public static void Variant(string source, Action<RenderInfo> check)
        {
            var ris = GetRenderInfoFromCompilation(source);
            Assert.That(ris, Is.Not.Empty);
            check(ris[0]);
        }

        public static IEnumerable<TestCaseData> VariantTestCases()
            => new (string Name, string Source, Action<RenderInfo> Check)[]
            {
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
                    "identifier with type parameters",
                    @"
                    [dotVariant.Variant]
                    public partial class XyzVariant<A, B>
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
                    "type with type parameters",
                    @"
                    [dotVariant.Variant]
                    public partial class XyzVariant<A, B>
                    {
                        static partial void VariantOf(int a, float b);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Type, Is.EqualTo("XyzVariant<A, B>"));
                        Assert.That(ri.Variant.QualifiedType, Is.EqualTo("global::XyzVariant<A, B>"));
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
                    "type with namespace and type parameters",
                    @"
                    namespace Foo.Bar
                    {
                        [dotVariant.Variant]
                        public partial class XyzVariant<A, B>
                        {
                            static partial void VariantOf(int a, float b);
                        }
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Type, Is.EqualTo("XyzVariant<A, B>"));
                        Assert.That(ri.Variant.QualifiedType, Is.EqualTo("global::Foo.Bar.XyzVariant<A, B>"));
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
                    "diagnostic type with type parameters",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant<A, B>
                    {
                        static partial void VariantOf(int a, float b);
                    }",
                    ri => Assert.That(ri.Variant.DiagType, Is.EqualTo("Variant<A, B>"))
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
                    "diagnostic type with namespace and type parameters",
                    @"
                    namespace Foo.Bar
                    {
                        [dotVariant.Variant]
                        public partial class Variant<A, B>
                        {
                            static partial void VariantOf(int a, float b);
                        }
                    }",
                    ri => Assert.That(ri.Variant.DiagType, Is.EqualTo("Foo.Bar.Variant<A, B>"))
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
                (
                    "type constraints: none",
                    @"
                    #nullable disable
                    [dotVariant.Variant]
                    internal partial class Variant<T>
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Is.Empty);
                    })
                ),
                (
                    "type constraints: class",
                    @"
                    #nullable disable
                    [dotVariant.Variant]
                    partial class Variant<T> where T : class
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Is.EquivalentTo(new[] { "class" }));
                    })
                ),
                (
                    "type constraints: class?",
                    @"
                    #nullable enable
                    [dotVariant.Variant]
                    partial class Variant<T> where T : class?
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Is.EquivalentTo(new[] { "class?" }));
                    })
                ),
                (
                    "type constraints: struct",
                    @"
                    #nullable disable
                    [dotVariant.Variant]
                    partial class Variant<T> where T : struct
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Is.EquivalentTo(new[] { "struct" }));
                    })
                ),
                (
                    "type constraints: unmanaged",
                    @"
                    #nullable disable
                    [dotVariant.Variant]
                    partial class Variant<T> where T : unmanaged
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Is.EquivalentTo(new[] { "unmanaged" }));
                    })
                ),
                (
                    "type constraints: notnull",
                    @"
                    #nullable enable
                    [dotVariant.Variant]
                    partial class Variant<T> where T : notnull
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Is.EquivalentTo(new[] { "notnull" }));
                    })
                ),
                (
                    "type constraints: new()",
                    @"
                    #nullable disable
                    [dotVariant.Variant]
                    partial class Variant<T> where T : new()
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Is.EquivalentTo(new[] { "new()" }));
                    })
                ),
                (
                    "type constraints: base class",
                    @"
                    #nullable disable
                    class C { }

                    [dotVariant.Variant]
                    partial class Variant<T> where T : C
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Is.EquivalentTo(new[] { "global::C" }));
                    })
                ),
                (
                    "type constraints: base class?",
                    @"
                    #nullable enable
                    class C { }

                    [dotVariant.Variant]
                    partial class Variant<T> where T : C?
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Is.EquivalentTo(new[] { "global::C?" }));
                    })
                ),
                (
                    "type constraints: interface",
                    @"
                    #nullable disable
                    interface I { }

                    [dotVariant.Variant]
                    partial class Variant<T> where T : I
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Is.EquivalentTo(new[] { "global::I" }));
                    })
                ),
                (
                    "type constraints: interface?",
                    @"
                    #nullable enable
                    interface I { }

                    [dotVariant.Variant]
                    partial class Variant<T> where T : I?
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Is.EquivalentTo(new[] { "global::I?" }));
                    })
                ),
                (
                    "type constraints: multiple",
                    @"
                    #nullable enable
                    interface I { }

                    [dotVariant.Variant]
                    partial class Variant<T> where T : class?, I?, new()
                    {
                        static partial void VariantOf(T value);
                    }",
                    ri => Assert.Multiple(() =>
                    {
                        Assert.That(ri.Variant.Generics, Is.Not.Empty);
                        Assert.That(ri.Variant.Generics[0].Constraints, Has.Length.EqualTo(3));
                        Assert.That(ri.Variant.Generics[0].Constraints[0], Is.EqualTo("class?")); // Must be first
                        Assert.That(ri.Variant.Generics[0].Constraints[1], Is.EqualTo("global::I?"));
                        Assert.That(ri.Variant.Generics[0].Constraints[2], Is.EqualTo("new()")); // Must be last
                    })
                ),
            }
            .Select(test => new TestCaseData(test.Source, test.Check).SetName($"{nameof(Variant)}({test.Name})"));
    }
}
