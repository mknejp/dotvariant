//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using static dotVariant.Generator.Test.GeneratorTools;

namespace dotVariant.Generator.Test
{
    [TestOf(typeof(SourceGenerator))]
    [Parallelizable(ParallelScope.All)]
    internal static class VariantSourceGenerator_Test
    {
        private static Dictionary<string, string>? _extraSources;

        [OneTimeSetUp]
        public static void LoadAttribute()
        {
            _extraSources = new()
            {
                { "VariantAttribute.cs", LoadSample("VariantAttribute.cs") },
                { "TypeMismatchException.cs", LoadSample("TypeMismatchException.cs") },
            };
        }

        [TestCaseSource(nameof(TranslationCases))]
        public static void Translation(string typeName, string input, string expected)
        {
            var sources = new Dictionary<string, string>(_extraSources!)
            {
                ["input"] = input
            };
            var outputs = GetGeneratedOutput<SourceGenerator>(sources);
            var file =
                Path.Combine(
                    $"{typeof(SourceGenerator).Assembly.GetName().Name}",
                    $"{typeof(SourceGenerator).FullName}",
                    $"{typeName}.cs");
            var output = outputs[file];
            output = GetCopyrightHeader(input).ToString() + output;
            if (output != expected)
            {
                // TODO: create diff
                Assert.That(output, Is.EqualTo(expected));
            }
        }

        public static IEnumerable<TestCaseData> TranslationCases()
            => new (string FileName, string TypeName)[]
                {
                    ("Variant-class-nullable-disable", "Foo.Variant_class_nullable_disable"),
                    ("Variant-class-nullable-enable", "Foo.Variant_class_nullable_enable"),
                    ("Variant-struct-nullable-disable", "Foo.Variant_struct_nullable_disable"),
                    ("Variant-struct-nullable-enable", "Foo.Variant_struct_nullable_enable"),
                }
                .Select(
                    test => new TestCaseData(
                        test.TypeName,
                        LoadSample($"{test.FileName}.in.cs"),
                        LoadSample($"{test.FileName}.out.cs"))
                    .SetName($"{nameof(Translation)}({test.FileName})"));

        private static ReadOnlySpan<char> GetCopyrightHeader(ReadOnlySpan<char> input)
        {
            // The test file saved on disk contains a copyright header that is not
            // produced by the generator. Extract it from the input so we can
            // prepend it to the output for test comparison.

            var start = input;
            var header = 0;
            var eol = 0;
            do
            {
                eol = input.IndexOf(Environment.NewLine.AsSpan());
                if (eol > 0 && input[0] != '/')
                {
                    break;
                }
                var line = eol + Environment.NewLine.Length;
                header += line;
                input = input[line..];
            }
            while (eol != -1);
            return start.Slice(0, header);
        }

        [TestCaseSource(nameof(DiagnosticsCases))]
        public static void Diagnostics(string input)
        {
            var sources = new Dictionary<string, string>(_extraSources!)
            {
                ["input"] = input
            };
            var expectations = ExtractExpectations(input);
            var diags =
                GetGeneratorDiagnostics<SourceGenerator>(sources)
                .Select(diag => (DiagnosticExpectation)diag);

            var unfulfilledExpectations =
                expectations
                .Where(exp => !diags.Any(diag => CompareDiagnostics(diag, exp)))
                .ToImmutableArray();
            var unexpectedDiagnostics =
                diags
                .Where(diag => !expectations.Any(exp => CompareDiagnostics(diag, exp)))
                .ToImmutableArray();

            Assert.Multiple(() =>
            {
                if (unfulfilledExpectations.Any())
                {
                    Assert.Fail(
                        string.Join(
                            Environment.NewLine,
                            unfulfilledExpectations.Select(ex => $"    {ex.Severity} {ex.Line}:{ex.Column}: {ex.Id}")
                            .Prepend("Unfilfilled diagnostic expectations:")));
                }
                if (unexpectedDiagnostics.Any())
                {
                    Assert.Fail(
                        string.Join(
                            Environment.NewLine,
                            unexpectedDiagnostics.Select(ex => $"    {ex.Severity} {ex.Line}:{ex.Column}: {ex.Id}")
                            .Prepend("Unexpected diagnostics:")));
                }
            });
        }

        private static bool CompareDiagnostics(DiagnosticExpectation lhs, DiagnosticExpectation rhs)
        {
            if (lhs.Severity != rhs.Severity)
            {
                return false;
            }
            if (lhs.Line != rhs.Line || lhs.Id != rhs.Id)
            {
                return false;
            }
            else if (lhs.Column == rhs.Column)
            {
                return true;
            }
            else if (lhs.Column == -1 || rhs.Column == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static IEnumerable<TestCaseData> DiagnosticsCases()
        {
            var assembly = Assembly.GetExecutingAssembly()!;
            var prefix = $"{assembly.GetName().Name!}.diagnostics.";
            var testPattern = new Regex($@"^(.*)\.cs$");

            return
                assembly
                .GetManifestResourceNames()
                .Where(name => name.StartsWith(prefix))
                .Select(name =>
                {
                    var match = testPattern.Match(name[prefix.Length..]);
                    return (Name: match.Groups[1].Value, Input: Load());

                    string Load()
                    {
                        using var stream = assembly.GetManifestResourceStream(name);
                        return new StreamReader(stream!).ReadToEnd();
                    }
                })
                .Select(test =>
                    new TestCaseData(test.Input)
                    .SetName($"{nameof(Diagnostics)}({test.Name})"));
        }
    }
}
