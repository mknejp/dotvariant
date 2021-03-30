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
            driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var generateDiagnostics);
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
            driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var generateDiagnostics);

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

        public static IEnumerable<(int Line, int Column, string Id)> ExtractExpectations(string input)
        {
            input = input.Replace( "\r\n", "\n").Replace("\r", "\n");
            return
                Regex.Matches(input, @"// (expected-error)(?::(\d+))? (.+)$", RegexOptions.Multiline | RegexOptions.ECMAScript)
                .Select(m => (Line(m.Index), m.Groups[2].Success ? int.Parse(m.Groups[2].Value) : -1, m.Groups[3].Value));

            int Line(int position) => input[..position].Count(ch => ch == '\n') + 1;
        }

        [TestCaseSource(nameof(ExtractExpectationsTest_cases))]
        public static void ExtractExpectationsTest(string input, (int Line, int Column, string Id)[] expected)
        {
            Assert.That(ExtractExpectations(input), Is.EquivalentTo(expected));
        }

        public static IEnumerable<TestCaseData> ExtractExpectationsTest_cases()
        {
            return
                new (string Input, (int Line, int Column, string Id)[] Expectations)[]
                {
                    (
                        "// expected-error Foo",
                        new[]
                        {
                            (1, -1, "Foo"),
                        }
                    ),
                    (
                        "// expected-error:51 Foo",
                        new[]
                        {
                            (1, 51, "Foo"),
                        }
                    ),
                    (
                        @"line 1
                        line 2
                        line 3 // expected-error Foo",
                        new[]
                        {
                            (3, -1, "Foo"),
                        }
                    ),
                    (
                        @"line 1
                        line 2 // expected-error Foo
                        line 3
                        line 4 // expected-error:14 Bar
                        line 5",
                        new[]
                        {
                            (2, -1, "Foo"),
                            (4, 14, "Bar"),
                        }
                    ),
                }
                .Select((test, i) =>
                    new TestCaseData(test.Input, test.Expectations)
                    .SetName($"{nameof(ExtractExpectationsTest)}({i})"));
        }

    }
}
