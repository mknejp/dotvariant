//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Scriban;
using Scriban.Parsing;
using Scriban.Runtime;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace dotVariant.Generator
{
    internal static partial class Renderer
    {
        private static readonly Lazy<Template> _template = new(() => Template.Parse(LoadFromResource("Variant")));

        private static string LoadFromResource(string name)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var reader = new StreamReader(
                assembly.GetManifestResourceStream($"{assembly.GetName().Name}.templates.{name}.scriban-cs"));
            return reader.ReadToEnd();
        }

        public static string Render(RenderInfo info)
            => Render(info, _template.Value);

        private static string Render(RenderInfo info, Template template)
        {
            var templateContext = new TemplateContext
            {
                MemberRenamer = m => m.Name,
                StrictVariables = true,
                TemplateLoader = new IncludeLoader(),
            };
            var globals = new ScriptObject();
            globals.Import(info, renamer: m => m.Name);
            templateContext.PushGlobal(globals);
            return template.Render(templateContext);
        }

        private sealed class IncludeLoader : ITemplateLoader
        {
            public string GetPath(TemplateContext context, SourceSpan callerSpan, string templateName)
                => templateName;

            public string Load(TemplateContext context, SourceSpan callerSpan, string templatePath)
                => LoadFromResource(templatePath);

            public ValueTask<string> LoadAsync(TemplateContext context, SourceSpan callerSpan, string templatePath)
                => new(Load(context, callerSpan, templatePath));
        }
    }
}
