//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace dotVariant.Generator.Test
{
    internal static partial class RenderInfo_Test
    {
        [TestCaseSource(nameof(ExtensionClassNamespaceTestCases))]
        public static void ExtensionClassNamespace(string source, Dictionary<string, string> properties, Action<RenderInfo> check)
        {
            var ris = GetRenderInfoFromCompilation(source, msBuildProperties: properties.ToImmutableDictionary());
            Assert.That(ris, Is.Not.Empty);
            check(ris[0]);
        }

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
