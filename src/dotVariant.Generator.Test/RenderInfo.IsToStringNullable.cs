// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace dotVariant.Generator.Test
{
    internal static partial class RenderInfo_Test
    {
        [TestCaseSource(nameof(IsToStringNullableCases))]
        public static void IsToStringNullable(string source, bool expected)
        {
            var ris = GetRenderInfoFromCompilation(source);
            Assert.That(ris, Is.Not.Empty);
            Assert.That(ris[0].Params[0].IsToStringNullable, Is.EqualTo(expected));
        }

        public static IEnumerable<TestCaseData> IsToStringNullableCases()
            => new (string Name, string Source, bool Nullable)[]
            {
                (
                    "class - nullable disable",
                    @"
                    #nullable disable

                    public class C { public override string ToString() => """"; }

                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(C a);
                    }",
                    true
                ),
                (
                    "class - nullable enable",
                    @"
                    #nullable enable

                    public class C { public override string ToString() => """"; }

                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(C a);
                    }",
                    false
                ),
                (
                    "class nullable - nullable enable",
                    @"
                    #nullable enable

                    public class C { public override string? ToString() => """"; }

                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(C a);
                    }",
                    true
                ),
                (
                    "struct - nullable disable",
                    @"
                    #nullable disable

                    public struct S { public override string ToString() => """"; }

                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(S a);
                    }",
                    true
                ),
                (
                    "struct - nullable enable",
                    @"
                    #nullable enable

                    public struct S { public override string ToString() => """"; }

                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(S a);
                    }",
                    false
                ),
                (
                    "struct nullable - nullable enable",
                    @"
                    #nullable enable

                    public struct S { public override string? ToString() => """"; }

                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(S a);
                    }",
                    true
                ),
                (
                    "object - nullable enable",
                    @"
                    #nullable enable
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(object a);
                    }",
                    true
                ),
                (
                    "object - nullable disable",
                    @"
                    #nullable disable
                    [dotVariant.Variant]
                    public partial class Variant
                    {
                        static partial void VariantOf(object a);
                    }",
                    true
                ),
                (
                    "int? - nullable enable",
                    @"
                    #nullable enable
                    [dotVariant.Variant]
                    public partial class Variant
                    {   
                        static partial void VariantOf(int? a);
                    }",
                    true
                ),
                (
                    "int? - nullable disable",
                    @"
                    #nullable disable
                    [dotVariant.Variant]
                    public partial class Variant
                    {   
                        static partial void VariantOf(int? a);
                    }",
                    true
                ),
                (
                    "generic",
                    @"
                    [dotVariant.Variant]
                    public partial class Variant<T>
                    {   
                        static partial void VariantOf(T a);
                    }",
                    true
                ),
            }
            .Concat(
                new[]
                {
                    "bool", "char", "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong", "decimal",
                    "float", "double",
                    "string", "System.DateTime", "System.IntPtr", "System.UIntPtr"
                }
                .Select(t =>
                (
                    Name: t,
                    Source: @$"
                        #nullable disable
                        [dotVariant.Variant]
                        public partial class Variant
                        {{
                            static partial void VariantOf({t} a);
                        }}",
                    Nullable: false
                )))
            .Select(test =>
                new TestCaseData(test.Source, test.Nullable).SetName($"{nameof(IsToStringNullable)}({test.Name})"));
    }
}
