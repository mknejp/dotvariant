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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace dotVariant.Generator.Test
{
    internal static class GeneratorTools
    {
        public static Dictionary<string, string> GetGeneratedOutput(IDictionary<string, string> sources, Func<ISourceGenerator> makeGenerator, bool failOnInvalidSource = false)
        {
            var compilation = CSharpCompilation.Create(
                "compilation",
                sources.Select(s => CSharpSyntaxTree.ParseText(s.Value, path: s.Key)),
                new[] { MetadataReference.CreateFromFile(typeof(Binder).GetTypeInfo().Assembly.Location) },
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            if (failOnInvalidSource)
            {
                FailIfError(compilation.GetDiagnostics());
            }

            var generator = makeGenerator();

            var driver = CSharpGeneratorDriver.Create(generator);
            _ = driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var generateDiagnostics);
            var output = outputCompilation.SyntaxTrees.ToDictionary(tree => tree.FilePath, tree => tree.ToString());
            FailIfError(generateDiagnostics);

            return output;
        }

        public static Dictionary<string, string> GetGeneratedOutput<TGenerator>(IDictionary<string, string> sources, bool failOnInvalidSource = false)
            where TGenerator : ISourceGenerator, new()
            => GetGeneratedOutput(sources, () => new TGenerator(), failOnInvalidSource);

        public static ImmutableArray<Diagnostic> GetGeneratorDiagnostics(IDictionary<string, string> sources, Func<ISourceGenerator> makeGenerator)
        {
            var compilation = CSharpCompilation.Create(
                "compilation",
                sources.Select(s => CSharpSyntaxTree.ParseText(s.Value, path: s.Key)),
                new[] { MetadataReference.CreateFromFile(typeof(Binder).GetTypeInfo().Assembly.Location) },
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            var generator = makeGenerator();

            var driver = CSharpGeneratorDriver.Create(generator);
            _ = driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var generateDiagnostics);

            return generateDiagnostics;
        }

        public static ImmutableArray<Diagnostic> GetGeneratorDiagnostics<TGenerator>(IDictionary<string, string> sources)
            where TGenerator : ISourceGenerator, new()
            => GetGeneratorDiagnostics(sources, () => new TGenerator());

        public static string TrimLines(string s)
            => string.Join(
                Environment.NewLine,
                s
                .Split(Environment.NewLine)
                .Select(line => line.Trim())
                .Where(line => line.Any()));

        private static void FailIfError(IEnumerable<Diagnostic> diag)
        {
            var errors = diag.Where(d => d.Severity == DiagnosticSeverity.Error);
            var msg = "Failed: " + errors.FirstOrDefault()?.GetMessage();
            Assert.That(errors, Is.Empty, msg);
        }

        public static string LoadSample(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.samples.{name}");

            return new StreamReader(stream!).ReadToEnd();
        }

        public static IEnumerable<DiagnosticExpectation> ExtractExpectations(string input)
        {
            input = input.Replace("\r\n", "\n").Replace("\r", "\n");
            return
                Regex.Matches(input, @"// (?:expected-(error|warning))(?::(\d+))? (.+)$", RegexOptions.Multiline | RegexOptions.ECMAScript)
                .Select(ToExpectation);

            DiagnosticExpectation ToExpectation(Match m)
                => new(
                    Line: input[..m.Index].Count(ch => ch == '\n') + 1,
                    Column: m.Groups[2].Success ? int.Parse(m.Groups[2].Value) : -1,
                    Id: m.Groups[3].Value,
                    Severity: m.Groups[1].Value == "error" ? DiagnosticSeverity.Error : DiagnosticSeverity.Warning);
        }

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

    public record DiagnosticExpectation(int Line, int Column, string Id, DiagnosticSeverity Severity)
    {
        public static implicit operator DiagnosticExpectation(Diagnostic diag)
        {
            var position = diag.Location.GetMappedLineSpan().StartLinePosition;
            return new(Line: position.Line + 1, Column: position.Character + 1, diag.Id, Severity: diag.Severity);
        }
    }
}
