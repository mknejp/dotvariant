# dotVariant [![GitHub](https://img.shields.io/github/license/mknejp/dotVariant)](/LICENSE.txt) [![Nuget verion](https://img.shields.io/nuget/v/dotVariant)](https://www.nuget.org/packages/dotVariant/) [![GitHub Workflow Status](https://img.shields.io/github/workflow/status/mknejp/dotvariant/test-package)](https://github.com/mknejp/dotvariant/actions)

A type-safe and space-efficient sum type for C# (comparable to unions in C or C++)

- [Overview of Variants](#overview-of-variants)
  - [Declaring a Variant](#declaring-a-variant)
  - [Using a Variant](#using-a-variant)
  - [Custom Value Types](#custom-value-types)
  - [Nullability](#nullability)
  - [Emptiness](#emptiness)
- [Generated Code Features](#generated-code-features)
  - [`IDisposable` Support](#idisposable-support)
  - [External Integrations: `IEnumerable<T>`, `IObservable<T>`](#external-integrations)
- [Customization](#customization)
  - [Extension Class Namespace](#extension-class-namespace)
- [Compatibility](#compatibility)
- [License](#license)

## Overview of Variants

A variant is similar to a struct or class, except that it can always only contain _one_ of its fields. A `class` declared with an `int` and a `string` property always contains one `int` value and one `string` value. In comparison to that a variant declared with an `int` option and a `string` option always contains _either_ an `int` value _or_ a `string` value, but never both. The library also makes a best effort at minimizing the amount of storage required by the variant as it can always only contain a single value. This is similar to C and C++ `union`, but tweaked to work under the restrictions of the .NET runtime.

### Declaring a Variant

Declaring a variant is very easy and requires only minimal amount of

```csharp
using dotVariant;

namespace MyNamespace
{
  [Variant] // required attribute
  partial class MyVariant // "partial" is mandatory
  {
      // "static partial" is mandatory. Do not implement!
      static partial void VariantOf(int a, double d, string s);
  }
  [Variant]
  partial class MyVariant<A, B, C> // Variants can have type parameters
  {
      static partial void VariantOf(A a, B b, C c);
  }
}
```

You are not restricted to just `class`. You can also use `struct`, `readonly struct`, `ref struct`, and so on. Only `record` is currently not supported and probably never will, but that should not stop you, as variants are immutable and have by-value comparison, just like records.

The `VariantOf` method is how you tell the generator what the possible values of this variant are. Anything that is a valid parameter and field is also a valid option here and the parameter names will be used as hints throughout the generated interface. Do not use `out`, `in` or `ref` modifiers, as those are reserved for future use.

`MyVariant` will receive a rich set of public properties and methods for you to enjoy. In addition you will find a private `_variant` field which hides away all the implementation details. If you chose to add your own custom members to `MyVariant` you may safely access this field.

Any constraints you put on the type parameters will be taken into consideration and affect the generated code.

**Note**: The .NET runtime forbids layout manipulation on generic types, so in the above example `MyVariant` will occupy less memory than `MyVariant<int, double, string>` despite seemingly having the same content. Be aware of this when using generic variants and try to use concrete types whenever possible.

### Using a Variant

With the above declaration, you are ready to use your new variant:

```csharp
var variant1 = new MyVariant(1);
variant1.Match(out int i);
Console.WriteLine(i); // prints 1

var variant2 = new MyVariant(2.5);
variant2.Match(out double d);
Console.WriteLine(d); // prints 2.5

var variant3 = new MyVariant("hello");
variant3.Match(out string s);
Console.WriteLine(s); // prints "hello"

MyVariant variant4 = 42; // implicitly create from accepted value type
void Foo(MyVariant x) { }
Foo("a string"); // implicitly create MyVariant instance
```

Note how we used the same type to store and retrieve different types of values. However, you are not limited to just `out` variables, you can also pass in functions:

```csharp
var variant1 = new MyVariant(1);
variant1.Match((int i) => Console.WriteLine(i)); // prints 1

var variant2 = new MyVariant(2.5);
variant2.Match((double d) => Console.WriteLine(d)); // prints 2.5

var variant3 = new MyVariant("world");
variant3.Match((string s) => Console.WriteLine(s)); // prints "world"
```

And you can even return values from these functions, which get piped through `Match`:

```csharp
var variant1 = new MyVariant(2);
var i = variant1.Match((int x) => x * 5); // i = 10

var variant2 = new MyVariant(2.5);
var d = variant2.Match((double x) => Math.Sin(x)); // d = 0.90929742682568171

var variant3 = new MyVariant("world");
var s = variant3.Match((string x) => $"hello {x}!"); // s = "hello world!"
```

What happens if you try to retrieve a value from a variant it currently does not contain? It throws an `InvalidOperationException`. To avoid this there are overloads of `Match` and `TryMatch` giving you tools to avoid this disappointing outcome:

```csharp
var variant = new MyVariant("not an int");

variant.Match(out int i); // throws InvalidOperationException
variant.Match((int x) => x); // throws InvalidOperationException

var b1 = variant.TryMatch(out int i); // b1 = false, i = default
var b2 = variant.TryMatch(out string s); // b2 = true, s = "not an int"

var i = variant.Match((int x) => x, 42); // i = 42
var j = variant.Match((int x) => x, () => 1337); // j = 1337
```

Until now all you could do was get a single type of value out of the variant using `Match` or `TryMatch`, and these two functions are designed to do only that. The real power behind variants, however, comes from visitation, where you provide a delegate to handle each possibility.

```csharp
string GetContainedType(MyVariant variant)
{
  return variant.Visit(
      i => "int",
      d => "double"
      s => "string");
}
GetContainedType(12); // returns "int"
GetContainedType(3.14); // returns "double"
GetContainedType("blubb"); // returns "string"
```

`Visit` accepts one delegate per possible type it _might_ contain, and at runtime invokes the one corresponding to the value it _does_ contain. Naturally, all delegates must return the same type.

There are many available overloads of `Match` and `Visit` which hopefully help you achieve your goal in every scenario.

### Custom Value Types

Of course you are not restricted to just using builtin types like `int` or `double`. Any type that is valid for fields and parameters is valid for variants. A useful pattern is to declare your own types nested to the variant.

```csharp
[Variant]
readonly partial struct MyAdvancedVariant
{
    static partial void VariantOf(Option1 first, Option2 second, Option3 third);
    
    public readonly struct Option1
    {
        public int Value { get; }
        public Option1(int value) { Value = value; }
    }
    public readonly struct Option2 { ... }
    public class Option3 { ... }
}
MyAdvancedVariant v = new MyAdvancedVariant.Option1(13); // implicitly converts to MyAdvancedVariant
```

### Nullability

The generator fully supports nullability annotations. The generated source code honors the nullability context of where the class is defined and its generated interface will match the nullability annotations of the `VariantOf` parameters.

```csharp
#nullable enable

[Variant]
partial class Variant1 // code generated with #nullable enable
{
    static partial void VariantOf(int a, string s); // s is non-null in all generated code
}

[Variant]
partial class Variant2 // code generated with #nullable enable
{
    static partial void VariantOf(int a, string? s); // s is nullable in all generated code
}

[Variant]
partial class Variant3<T> // code generated with #nullable enable
    where T : class
{
    // Even though T is constrained to not-null reference types,
    // the actual value in the variant is nullable.
    static partial void VariantOf(int i, T? t);
}

#nullable disable

[Variant]
partial class Variant4 // code generated with #nullable disable
{
    static partial void VariantOf(int a, string s); // s is nullable in all generated code
}
```

And of course nullable value types are also supported.

```csharp
[Variant]
partial class SomeVariant
{
    static partial void VariantOf(int? a, string s); // OK
}
```

### Emptiness

If you declare your variant as a `struct`-type, you need to be aware that a variant can be _empty_, meaning it does not hold _any_ value. This is an unfortunate consequence of value types always having a default constructor in .NET. A `class` variant should never be empty unless you define your own constructor and default-construct the private `_variant` field. Use the public `IsEmpty` property to check for emptiness. Attempting to retrieve a value out of an empty variant results in a `InvalidOperationException`, however there are overloads of `Match` and `Visit` with ways to deal with emptiness in a more fluid manner.

```csharp
[Variant]
partial struct MyStructVariant
{
    static partial void VariantOf(int first, string second?, byte[] third);
}

var variant = default(MyStructVariant);
variant.IsEmpty; // true
variant.Match(out int i); // throws InvalidOperationException
var i = variant.Match(x => i + 1, 0); // i = 0

variant.Match(
    x => "first",
    x => "second",
    x => "third",
    () => "empty"); // Fourth option called when empty
```

## Generated Code Features

The generated implemenation provides some additional features depending on the types you provide it, or third-party libraries available to you.

### `IDisposable` Support

If _at least one_ of the types included in the `VariantOf()` parameters implements `System.IDisposable`, or is a type parameter with a transitive `System.IDisposable` constraint, then the generated variant will also implement this interface and provide a public `Dispose()` member which delegates to the stored value's `Dispose()` if applicable.

If there already exists an implementation of `IDisposable.Dispose()` (either you defined one, or it is present in a base class) then the public `Dispose()` method is _not_ generated and it is your responsibility to take care of calling the private `_variant.Dispose()`.

### External Integrations

If your type is declared in such a way that providing extensions methods is possible you will get additional integration with .NET facilities, or popular external libraries, listed in this section. The visibility (`public` or `internal`) of the extension methods is made to match the accessibility of your type declaration.

The `static class` containing all extension methods is by default generated in the same namespace containing the variant type, but that is configurable (see [Extension Class Namespace](#extension-class-namespace)).

#### `IEnumerable<T>`

These allow for easy and powerful integration into `System.Linq`-like queries on `IEnumerable<T>` sequences, that let you manipulate a stream of variants based on the contained type.

```csharp
[Variant]
public readonly partial struct MyVariant
{
    static partial void VariantOf(int i, double d, string s);
}

var xs = new MyVariant[] { 1, 2.0, "3", 4, 5.0, "6" };

// Unary Match only transforms the matching type and drops all others
xs.Match((int i) => i); // result: IEnumerable<int> [1, 4]

// Binary Match lets you provide a fallback value or delegate to replace non-matching values with
xs.Match((int i) => i, 0); // result: IEnumerable<int> [1, 0, 0, 4, 0, 0]
xs.Match((int i) => i, () => -1); // result: IEnumerable<int> [1, -1, -1, 4, -1, -1]

// Visit transform each possible value type individually
xs.Visit(
    i => $"int {i}",
    d => $"double {d}"
    s=> $"string {s}");
// result: IEnumerable<string> ["int 1", "double 2", "string 3", "int 4", "double 5", "string 6"]
```

#### `IObservable<T>`

These allow for easy and powerful integration into `System.Reactive.Linq`-like queries on `IObservable<T>` sequences, that let you manipulate an asynchronous stream of variants based on the contained type.

```csharp
[Variant]
public readonly partial struct MyVariant
{
    static partial void VariantOf(int i, double d, string s);
}

var xs = new MyVariant[] { 1, 2.0, "3", 4, 5.0, "6" }.ToObservable();

// Unary Match only transforms the matching type and drops all others
xs.Match((int i) => i); // result: IObservable<int> [1, 4]

// Binary Match lets you provide a fallback value or delegate to replace non-matching values with
xs.Match((int i) => i, 0); // result: IObservable<int> [1, 0, 0, 4, 0, 0]
xs.Match((int i) => i, () => -1); // result: IObservable<int> [1, -1, -1, 4, -1, -1]

// Visit transform each possible value type individually
xs.Visit(
    i => $"int {i}",
    d => $"double {d}"
    s=> $"string {s}");
// result: IObservable<string> ["int 1", "double 2", "string 3", "int 4", "double 5", "string 6"]

// VisitMany splits the sequence into multiple customizable sub-sequences which are then merged into one
xs.VisitMany(
    i => i.Where(ix => ix > 1).Select(ix => $"int {ix}"),
    d => d.Delay(dx => dx * 1000).Select(dx => $"double {dx}"),
    s => s.Zip(Observable.Interval(100), (sx, _) => $"string {sx}");
// results with timestamps: IObservable<string> [
//   "int 4" @0,
//   "string 3" @100,
//   "string 6" @200,
//   "double 2" @2000,
//   "double 5" @5000,
// ]

// Altenatively VisitMany allows you to transform and combine the split streams however you want.
xs.VisitMany((i, d, s) => CombineLatest(i, d, s, (ix, dx, sx) => (ix, dx, sx));
// results: IObservable<string> [
//   (1, 2.0, "3"),
//   (4, 2.0, "3"),
//   (4, 5.0, "3"),
//   (4, 5.0, "6"),
// ]
```

## Customization

An overview of how you can customize the generated source code.

### Extension Class Namespace

As mentioned in [Third-party Integrations](#third-party-integrations) if the circumstances are right extension methods for integration with third-party libraries can be generated. By default the accompanying `static class` is put in the namespace containing the variant type.

```csharp
// Your declaration
namespace Foo.Bar.Baz
{
  [Variant]
  internal partial class MyVariant
  {
    static partial void VariantOf(int i, double d, string s);
  }
}
// Generated code
namespace Foo.Bar.Baz
{
  partial class MyVariant { /* variant implementation */ }
  
  internal static class _MyVariant_Ex { /* all extension methods for MyVariant go here */ }
}
```

However this means the extension methods are only accessible if you are inside namespace `Foo.Bar.Baz` or have `using Foo.Bar.Baz;` active in your scope. Thus if you are in namespace `Foo.Bar` and are handled a `IEnumerable<Foo.Bar.Baz.MyVariant>` then the extension methods won't be visible to you. If this is not what you want you can set a MSBuild property to change the namespace where all extension classes are generated (an additional per-class option is planned) to whichever place you put common extension methods. I highly recomment making them visible everywhere, you don't want to miss out on them!

```xml
<PropertyGroup>
  <dotVariant-ExtensionClassNamespace>Foo.Extensions</dotVariant-ExtensionClassNamespace>
</PropertyGroup>
```

## Compatibility

- To use the generator you must use the latest .NET SDK
- The generated code is compatible down to C# `7.3` and adjusts itself to the available language version and runtime facilities.
- The required runtime support library targets `netstandard1.0`.

## License

Licensed under the [Boost Software License 1.0](LICENSE.txt).
