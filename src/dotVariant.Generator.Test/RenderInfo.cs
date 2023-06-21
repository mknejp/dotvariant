//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis.CSharp;
using NUnit.Framework;
using System.Collections.Immutable;
using static dotVariant.Generator.Test.GeneratorTools;

namespace dotVariant.Generator.Test
{
    [TestOf(typeof(RenderInfo))]
    [Parallelizable(ParallelScope.All)]
    internal static partial class RenderInfo_Test
    {
        private static ImmutableArray<RenderInfo> GetRenderInfoFromCompilation(
            string source,
            LanguageVersion version = LanguageVersion.Default,
            ImmutableDictionary<string, string>? msBuildProperties = null)
        {
            var compilation = Compile(SupportSources.Add("input", source), version);
            var generator = new SourceGenerator();
            var driver = CSharpGeneratorDriver.Create(generator)
                .WithUpdatedAnalyzerConfigOptions(new AnalyzerConfigOptionsProvider(msBuildProperties))
                .WithUpdatedParseOptions(new CSharpParseOptions(version));
            _ = driver.RunGeneratorsAndUpdateCompilation(compilation, out var _, out var _);
            return generator.RenderInfos.ToImmutableArray();
        }
    }
}
