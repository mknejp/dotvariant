using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using System.Linq;

namespace dotVariant.Generator
{
    internal sealed record Descriptor(
        ITypeSymbol Type,
        ImmutableArray<IParameterSymbol> Options
        // TODO: disposable types
        // TODO: nullability
        // TODO: emptiness possible?
        // TODO: user-defined constructors
        // TODO: user-defined ToString()
        // TODO: user-defined Equals()
        // TODO: user-defined GetHashCode()
        // TODO: user-defined Dispose()
        // TODO: nested class
        )
    {
        public static Descriptor FromDeclaration(GeneratorExecutionContext context, ITypeSymbol type, TypeDeclarationSyntax syntax)
        {
            var options = Inspect.GetOptions(type);
            return new(type, options);
        }
    }

}
