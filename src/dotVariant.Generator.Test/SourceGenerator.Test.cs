// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using static dotVariant.Generator.Test.GeneratorTools;

namespace dotVariant.Generator.Test
{
    [TestOf(typeof(SourceGenerator))]
    [Parallelizable(ParallelScope.All)]
    internal static class SourceGenerator_Test
    {
        [TestCaseSource(nameof(TranslationCases))]
        public static void Translation(string typeName, string fileName, string input, string expected)
        {
            var sources = SupportSources.Add("input", input);
            var outputs = GetGeneratedOutput<SourceGenerator>(sources, true);
            var file =
                Path.Combine(
                    $"{typeof(SourceGenerator).Assembly.GetName().Name}",
                    $"{typeof(SourceGenerator).FullName}",
                    $"{typeName}.cs");
            var output = outputs[file];
            output = _copyrightHeader + output;

            if (output != expected)
            {
                if (_commitTranslations)
                {
                    WriteSample(fileName, output);
                }
                Assert.That(output, Is.EqualTo(expected));
            }
        }

        private static readonly bool _commitTranslations = false;

        [Test]
        public static void PreventCommitInMain()
        {
#if CI
            Assert.That(_commitTranslations, Is.False);
#endif
        }

        private static readonly string _samplesDir
            = Assembly
                .GetExecutingAssembly()
                .GetCustomAttributes<AssemblyMetadataAttribute>()
                .Single(a => a.Key == "SamplesDir")
                .Value!;

        private static void WriteSample(string name, string content)
        {
            var path = Path.Combine(_samplesDir, $"{name}.out.cs");
            using var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.Write(content);
        }

        public static IEnumerable<TestCaseData> TranslationCases()
            => new (string FileName, string TypeName)[]
                {
                    ("Variant-class-nullable-disable", "Foo.Variant_class_nullable_disable"),
                    ("Variant-class-nullable-enable", "Foo.Variant_class_nullable_enable"),
                    ("Variant-disposable", "Foo.Variant_disposable"),
                    ("Variant-generic-class", "Foo.Variant{T}"),
                    ("Variant-generic-class-nullable", "Foo.Variant{T}"),
                    ("Variant-generic-multiple", "Foo.Variant{T1, T2, T3}"),
                    ("Variant-generic-notnull", "Foo.Variant{T}"),
                    ("Variant-generic-struct", "Foo.Variant{T}"),
                    ("Variant-generic-T-as-nullable", "Foo.Variant{T1, T2, T3, T4, T5, T6}"),
                    ("Variant-generic-unbounded", "Foo.Variant{T}"),
                    ("Variant-nullable-value-type", "Foo.Variant_nullable_value_type"),
                    ("Variant-public", "Foo.Variant_public"),
                    ("Variant-no-implicit-conversion", "Foo.Variant_no_implicit_conversion"),
                    ("Variant-struct-nullable-disable", "Foo.Variant_struct_nullable_disable"),
                    ("Variant-struct-nullable-enable", "Foo.Variant_struct_nullable_enable"),
                }
                .Select(
                    test => new TestCaseData(
                        test.TypeName,
                        test.FileName,
                        LoadSample($"{test.FileName}.in.cs"),
                        LoadSample($"{test.FileName}.out.cs"))
                    .SetName($"{nameof(Translation)}({test.FileName})"));

        private static readonly string _copyrightHeader = LoadSample("copyright.cs");

        [TestCaseSource(nameof(DiagnosticsCases))]
        public static void Diagnostics(string input)
        {
            var sources = SupportSources.Add("input", input);
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
                    using var reader = new StreamReader(assembly.GetManifestResourceStream(name)!);
                    return (Name: match.Groups[1].Value, Input: reader.ReadToEnd());
                })
                .Select(test =>
                    new TestCaseData(test.Input)
                    .SetName($"{nameof(Diagnostics)}({test.Name})"));
        }
    }
}
