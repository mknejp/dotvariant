// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

using Microsoft.CodeAnalysis;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static dotVariant.Generator.Test.GeneratorTools;

namespace dotVariant.Generator.Test
{
    internal static class GeneratorTools_Test
    {
        [TestCaseSource(nameof(ExtractExpectationsTest_cases))]
        public static void ExtractExpectationsTest(string input, DiagnosticExpectation[] expected)
        {
            Assert.That(ExtractExpectations(input), Is.EquivalentTo(expected));
        }

        public static IEnumerable<TestCaseData> ExtractExpectationsTest_cases()
        {
            return
                new (string Input, DiagnosticExpectation[] Expectations)[]
                {
                    (
                        "// expected-error Foo",
                        new DiagnosticExpectation[]
                        {
                            new(1, -1, "Foo", DiagnosticSeverity.Error),
                        }
                    ),
                    (
                        "// expected-warning Foo",
                        new DiagnosticExpectation[]
                        {
                            new(1, -1, "Foo", DiagnosticSeverity.Warning),
                        }
                    ),
                    (
                        "// expected-error:51 Foo",
                        new DiagnosticExpectation[]
                        {
                            new(1, 51, "Foo", DiagnosticSeverity.Error),
                        }
                    ),
                    (
                        @"line 1
                        line 2
                        line 3 // expected-error Foo",
                        new DiagnosticExpectation[]
                        {
                            new(3, -1, "Foo", DiagnosticSeverity.Error),
                        }
                    ),
                    (
                        @"line 1
                        line 2 // expected-error Foo
                        line 3
                        line 4 // expected-error:14 Bar
                        line 5",
                        new DiagnosticExpectation[]
                        {
                            new(2, -1, "Foo", DiagnosticSeverity.Error),
                            new(4, 14, "Bar", DiagnosticSeverity.Error),
                        }
                    ),
                }
                .Select((test, i) =>
                    new TestCaseData(test.Input, test.Expectations)
                    .SetName($"{nameof(ExtractExpectationsTest)}({i})"));
        }

    }
}
