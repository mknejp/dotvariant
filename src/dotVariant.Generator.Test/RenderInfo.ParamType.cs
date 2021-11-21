//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis.CSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dotVariant.Generator.Test
{
    internal static partial class RenderInfo_Test
    {

        [TestCaseSource(nameof(ParamTypeTestCases))]
        public static void ParamType(LanguageVersion version, string source, Action<RenderInfo.ParamInfo> check)
        {
            var ris = GetRenderInfoFromCompilation(source, version);
            Assert.That(ris, Is.Not.Empty);
            check(ris[0].Params[0]);
        }

        public static IEnumerable<TestCaseData> ParamTypeTestCases()
            => new (string Name, LanguageVersion Version, string Source, Action<RenderInfo.ParamInfo> Check)[]
            {
                (
                    "struct",
                    LanguageVersion.Latest,
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
                        Assert.That(p.IsGeneric, Is.False, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("global::N.S"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("global::N.S"), nameof(p.Type));
                    })
                ),
                (
                    "special: int",
                    LanguageVersion.Latest,
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
                        Assert.That(p.IsGeneric, Is.False, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("int"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("int"), nameof(p.Type));
                    })
                ),
                (
                    "special: string",
                    LanguageVersion.Latest,
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
                        Assert.That(p.IsGeneric, Is.False, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("string"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("string"), nameof(p.Type));
                    })
                ),
                (
                    "struct? - nullable disable",
                    LanguageVersion.Latest,
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
                        Assert.That(p.IsGeneric, Is.False, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("global::N.S?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("global::N.S?"), nameof(p.Type));
                    })
                ),
                (
                    "struct? - nullable enable",
                    LanguageVersion.Latest,
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
                        Assert.That(p.IsGeneric, Is.False, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("global::N.S?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("global::N.S?"), nameof(p.Type));
                    })
                ),
                (
                    "class - nullable disable",
                    LanguageVersion.Latest,
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
                        Assert.That(p.IsGeneric, Is.False, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("global::N.C"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("global::N.C"), nameof(p.Type));
                    })
                ),
                (
                    "class - nullable enable",
                    LanguageVersion.Latest,
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
                        Assert.That(p.IsGeneric, Is.False, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("global::N.C?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("global::N.C"), nameof(p.Type));
                    })
                ),
                (
                    "class? - nullable enable",
                    LanguageVersion.Latest,
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
                        Assert.That(p.IsGeneric, Is.False, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("global::N.C?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("global::N.C?"), nameof(p.Type));
                    })
                ),
                (
                    "delegate - nullable disable",
                    LanguageVersion.Latest,
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
                        Assert.That(p.IsGeneric, Is.False, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("global::N.D"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("global::N.D"), nameof(p.Type));
                    })
                ),
                (
                    "delegate - nullable enable",
                    LanguageVersion.Latest,
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
                        Assert.That(p.IsGeneric, Is.False, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("global::N.D?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("global::N.D"), nameof(p.Type));
                    })
                ),
                (
                    "delegate? - nullable enable",
                    LanguageVersion.Latest,
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
                        Assert.That(p.IsGeneric, Is.False, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("global::N.D?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("global::N.D?"), nameof(p.Type));
                    })
                ),
                (
                    "generic: unbounded - nullable disable",
                    LanguageVersion.Latest,
                    @"
                    #nullable disable
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant<T>
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: unbounded - nullable enable - C# 8.0",
                    LanguageVersion.CSharp8, // Unconstrained generics in C# 8 could not use T?
                    @"
                    #nullable enable
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant<T>
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: unbounded - nullable enable",
                    LanguageVersion.Latest,
                    @"
                    #nullable enable
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant<T>
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: class - nullable disable",
                    LanguageVersion.Latest,
                    @"
                    #nullable disable
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant<T> where T : class
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: class - nullable enable",
                    LanguageVersion.Latest,
                    @"
                    #nullable enable
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant<T> where T : class
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.False, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: class? - nullable enable",
                    LanguageVersion.Latest,
                    @"
                    #nullable enable
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant<T> where T : class?
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: struct",
                    LanguageVersion.Latest,
                    @"
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant<T> where T : struct
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.False, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: unmanaged",
                    LanguageVersion.Latest,
                    @"
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant<T> where T : unmanaged
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.False, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: notnull - nullable disable",
                    LanguageVersion.Latest,
                    @"
                    #nullable disable
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant<T> where T : notnull
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.False, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: notnull - nullable enable",
                    LanguageVersion.Latest,
                    @"
                    #nullable enable
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant<T> where T : notnull
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.False, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: base class - nullable disable",
                    LanguageVersion.Latest,
                    @"
                    #nullable disable
                    namespace N
                    {
                        class C { }

                        [dotVariant.Variant]
                        public partial class Variant<T> where T : C
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: base class - nullable enable",
                    LanguageVersion.Latest,
                    @"
                    #nullable enable
                    namespace N
                    {
                        class C { }

                        [dotVariant.Variant]
                        public partial class Variant<T> where T : C
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.False, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: base class? - nullable enable",
                    LanguageVersion.Latest,
                    @"
                    #nullable enable
                    namespace N
                    {
                        class C { }

                        [dotVariant.Variant]
                        public partial class Variant<T> where T : C?
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.True, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: interface - nullable disable",
                    LanguageVersion.Latest,
                    @"
                    #nullable disable
                    namespace N
                    {
                        interface I { }

                        [dotVariant.Variant]
                        public partial class Variant<T> where T : I
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: interface - nullable enable",
                    LanguageVersion.Latest,
                    @"
                    #nullable enable
                    namespace N
                    {
                        interface I { }

                        [dotVariant.Variant]
                        public partial class Variant<T> where T : I
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.False, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "generic: interface? - nullable enable",
                    LanguageVersion.Latest,
                    @"
                    #nullable enable
                    namespace N
                    {
                        interface I { }

                        [dotVariant.Variant]
                        public partial class Variant<T> where T : I?
                        {
                            static partial void VariantOf(T a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.CanBeNull, Is.True, nameof(p.CanBeNull));
                        Assert.That(p.DiagType, Is.EqualTo("T"), nameof(p.DiagType));
                        Assert.That(p.IsGeneric, Is.True, nameof(p.IsGeneric));
                        Assert.That(p.IsReferenceType, Is.False, nameof(p.IsReferenceType));
                        Assert.That(p.OutType, Is.EqualTo("T?"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("T"), nameof(p.Type));
                    })
                ),
                (
                    "value with fixed type parameter",
                    LanguageVersion.Latest,
                    @"
                    using System;
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant
                        {
                            static partial void VariantOf(Action<TimeSpan> a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.DiagType, Is.EqualTo("System.Action<System.TimeSpan>"), nameof(p.DiagType));
                        Assert.That(p.OutType, Is.EqualTo("global::System.Action<global::System.TimeSpan>"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("global::System.Action<global::System.TimeSpan>"), nameof(p.Type));
                    })
                ),
                (
                    "value with custom type parameter",
                    LanguageVersion.Latest,
                    @"
                    using System;
                    namespace N
                    {
                        [dotVariant.Variant]
                        public partial class Variant<T>
                        {
                            static partial void VariantOf(Action<T> a);
                        }
                    }",
                    p => Assert.Multiple(() =>
                    {
                        Assert.That(p.DiagType, Is.EqualTo("System.Action<T>"), nameof(p.DiagType));
                        Assert.That(p.OutType, Is.EqualTo("global::System.Action<T>"), nameof(p.OutType));
                        Assert.That(p.Type, Is.EqualTo("global::System.Action<T>"), nameof(p.Type));
                    })
                ),
                (
                    "disposable: IDisposable class",
                    LanguageVersion.Latest,
                    @"
                    public class C : System.IDisposable { public void Dispose() {} }

                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(C a);
                    }",
                    p => Assert.That(p.IsDisposable, Is.True)
                ),
                (
                    "disposable: System.IDisposable constraint",
                    LanguageVersion.Latest,
                    @"
                    [dotVariant.Variant]
                    public partial class Variant<T> where T : System.IDisposable
                    {
                        static partial void VariantOf(T a);
                    }",
                    p => Assert.That(p.IsDisposable, Is.True)
                ),
                (
                    "disposable: IDisposable transitive interface constraint",
                    LanguageVersion.Latest,
                    @"
                    public interface I : System.IDisposable {}

                    [dotVariant.Variant]
                    public partial class Variant<T> where T : I
                    {
                        static partial void VariantOf(T a);
                    }",
                    p => Assert.That(p.IsDisposable, Is.True)
                ),
                (
                    "disposable: IDisposable transitive class constraint",
                    LanguageVersion.Latest,
                    @"
                    public class C : System.IDisposable { public void Dispose() {} }

                    [dotVariant.Variant]
                    public partial class Variant<T> where T : C
                    {
                        static partial void VariantOf(T a);
                    }",
                    p => Assert.That(p.IsDisposable, Is.True)
                ),
            }
            .Select(test =>
                new TestCaseData(test.Version, test.Source, test.Check).SetName($"{nameof(ParamType)}({test.Name})"));
    }
}
