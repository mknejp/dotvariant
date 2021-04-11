//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Scriban;
using Scriban.Runtime;
using System;
using System.IO;
using System.Reflection;

namespace dotVariant.Generator
{
    internal static partial class Renderer
    {
        private static readonly Lazy<Template> _template = new(() =>
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.templates.Variant.scriban-cs");

            return Template.Parse(new StreamReader(stream).ReadToEnd());
        });

        public static string Render(RenderInfo info)
            => Render(info, _template.Value);

        private static string Render(RenderInfo info, Template template)
        {
            var templateContext = new TemplateContext
            {
                MemberRenamer = m => m.Name,
                StrictVariables = true,
            };
            var globals = new ScriptObject();
            globals.Import(info, renamer: m => m.Name);
            templateContext.PushGlobal(globals);
            return template.Render(templateContext);
        }
    }
}
