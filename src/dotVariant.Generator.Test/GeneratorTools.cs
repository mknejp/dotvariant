// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace dotVariant.Generator.Test
{
    internal static class GeneratorTools
    {
        public static Dictionary<string, string> GetGeneratedOutput(IDictionary<string, string> sources, Func<IIncrementalGenerator> makeGenerator, bool failOnInvalidSource = false)
        {
            var compilation = Compile(sources);

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
            where TGenerator : IIncrementalGenerator, new()
            => GetGeneratedOutput(sources, () => new TGenerator(), failOnInvalidSource);

        public static ImmutableArray<Diagnostic> GetGeneratorDiagnostics(IDictionary<string, string> sources, Func<IIncrementalGenerator> makeGenerator)
        {
            var compilation = Compile(sources);

            var generator = makeGenerator();

            var driver = CSharpGeneratorDriver.Create(generator);
            _ = driver.RunGeneratorsAndUpdateCompilation(compilation, out var _, out var generateDiagnostics);

            return generateDiagnostics;
        }

        public static ImmutableArray<Diagnostic> GetGeneratorDiagnostics<TGenerator>(IDictionary<string, string> sources)
            where TGenerator : IIncrementalGenerator, new()
            => GetGeneratorDiagnostics(sources, () => new TGenerator());

        public static CSharpCompilation Compile(
            IDictionary<string, string> sources,
            LanguageVersion version = LanguageVersion.Default)
            => CSharpCompilation.Create(
                "test",
                sources.Select(s => CSharpSyntaxTree.ParseText(s.Value, new CSharpParseOptions(version), path: s.Key)),
                new[]
                {
                    MetadataReference.CreateFromFile(typeof(Binder).GetTypeInfo().Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(Observable).GetTypeInfo().Assembly.Location),
                },
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

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
            using var reader = new StreamReader(stream!);

            return reader.ReadToEnd();
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

        public static readonly ImmutableDictionary<string, string> SupportSources =
            new Dictionary<string, string>()
                {
                    { "VariantAttribute.cs", LoadSample("VariantAttribute.cs") },
                    { "NoImplicitConversionAttribute.cs", LoadSample("NoImplicitConversionAttribute.cs") },
                }
                .ToImmutableDictionary();
    }

    public record DiagnosticExpectation(int Line, int Column, string Id, DiagnosticSeverity Severity)
    {
        public static implicit operator DiagnosticExpectation(Diagnostic diag)
        {
            var position = diag.Location.GetMappedLineSpan().StartLinePosition;
            return new(Line: position.Line + 1, Column: position.Character + 1, diag.Id, Severity: diag.Severity);
        }
    }

    public sealed class AnalyzerConfigOptionsProvider : Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
    {
        public AnalyzerConfigOptionsProvider(ImmutableDictionary<string, string>? msBuildProperties)
        {
            GlobalOptions = new Options
            {
                // Properties are looked up with the build_property prefix
                MSBbuildProperties =
                    (msBuildProperties ?? ImmutableDictionary<string, string>.Empty)
                    .ToImmutableDictionary(p => "build_property." + p.Key, p => p.Value)
            };
        }

        public override Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions GlobalOptions { get; }

        public override Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions GetOptions(SyntaxTree tree) => GlobalOptions;

        public override Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions GetOptions(AdditionalText textFile) => GlobalOptions;

        private class Options : Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptions
        {
            public ImmutableDictionary<string, string>? MSBbuildProperties { get; init; }

            public override bool TryGetValue(string key, [NotNullWhen(true)] out string? value)
                => MSBbuildProperties!.TryGetValue(key, out value);
        }
    }
}
