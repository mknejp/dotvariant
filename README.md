# dotVariant
A type-safe and space-efficient sum type for C# (comparable to unions in C or C++)

- [Overview of Variants](#overview-of-variants)
  - [Declaring a Variant](#declaring-a-variant)
  - [Using a Variant](#using-a-variant)
  - [Custom Value Types](#custom-value-types)
  - [Nullability](#nullability)
  - [Emptiness](#emptiness)
- [Customization](#customization)
- [Additional Considerations in Generated Code](#additional-considerations-in-generated-code)
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
        partial void VariantOf(int a, double d, string s); // "partial" is mandatory. do not implement!
    }
}
```
You are not restricted to just `class`. You can also use `struct`, `readonly struct`, `ref struct`, and so on. Only `record` is currently not supported and probably never will, but that should not stop you, as variants are immutable and have by-value comparison, just like records.

The `VariantOf` method is how you tell the generator what the possible values of this variant are. Anything that is a valid parameter is also a valid option here and the parameter names will be used as hints throughout the generated interface. Do not use `out`, `in` or `ref` modifiers, as those are reserved for future use.

`MyVariant` will receive a rich set of public properties and methods for you to enjoy. In addition you will find a private `_variant` field which hides away all the implementation details. If you chose to add your own custom members to `MyVariant` you may safely access this field.

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
What happens if you try to retrieve a value from a variant it currently does not contain? It throws an `InvalidOperationException`. To avoid this there are overloads of `Match` that give you ways to avoid this disappointing outcome:
```csharp
var variant = new MyVariant("not an int");

variant.Match(out int i); // throws InvalidOperationException
variant.Match((int x) => x); // throws InvalidOperationException

var b1 = variant.TryMatch(out int i); // b1 = false, i = default
var b2 = variant.TryMatch(out string s); // b2 = true, s = "not an int"

var i = variant.Match((int x) => x, 42); // i = 42
var j = variant.Match((int x) => x, () => 1337); // j = 1337
```
The real power behind variants, however, comes from visitation, where you provide the variant with a delegate for each possible type:
```csharp
string GetContainedType(MyVariant variant)
{
  return variant.Visit(
      i => "int",
      d => "double"
      s => "string");
}
GetContainedType(new MyVariant(12)); // returns "int"
GetContainedType(new MyVariant(3.14)); // returns "double"
GetContainedType(new MyVariant("blubb")); // returns "string"
```
`Visit` accepts one delegate per possible type it _might_ contain, and at runtime invokes the one corresponding to the value it _does_ contain. Naturally, all delegates must return the same type.

There are many available overloads of `Match` and `Visit` which hopefully help you achieve your goal in any scenario.

### Custom Value Types
Of course you are not restricted to just using builtin types like `int` or `double`. Any type that is valid for fields and parameters is valid for variants. A useful pattern is to declare your own types nested to the variant.
```csharp
[Variant]
readonly partial struct MyAdvancedVariant
{
    partial void VariantOf(Option1 first, Option2 second, Option3 third);
    
    public readonly struct Option1
    {
        public int Value { get; }
        public Option1(int value) { Value = value; }
    }
    public readonly struct Option2 { ... }
    public readonly struct Option3 { ... }
}
MyAdvancedVariant v = new MyAdvancedVariant.Option1(13); // implicitly converts to MyAdvancedVariant
```

### Nullability
The generator fully supports nullability annotations. The generated source code honors the nullability context of where the class is defined and its generated interface will match the nullability annotations of the `VariantOf` parameters.
```csharp
#nullable enable

[Variant]
class Variant1 // code generated with #nullable enable
{
    partial void VariantOf(int a, string s); // s is non-null in all generated code
}

[Variant]
class Variant2 // code generated with #nullable enable
{
    partial void VariantOf(int a, string? s); // s is nullable in all generated code
}

#nullable disable

[Variant]
class Variant3 // code generated with #nullable disable
{
    partial void VariantOf(int a, string s); // s is nullable in all generated code
}
```
And of course nullable value types are also supported.
```csharp
[Variant]
class SomeVariant
{
    partial void VariantOf(int? a, string s); // OK
}
```

### Emptiness
If you declare your variant as a `struct`-type, you need to be aware that a variant can be _empty_, meaning it does not hold _any_ value. This is an unfortunate consequence of value types always having a default constructor in .NET. A `class` variant should never be empty unless you define your own constructor and default-construct the private `_variant` field. Use the public `IsEmpty` property to check for emptiness. Attempting to retrieve a value out of an empty variant results in a `InvalidOperationException`, however there are overloads of `Match` and `Visit` with ways to deal with emptiness in a more fluid manner.
```csharp
[Variant]
struct MyStructVariant
{
    partial void VariantOf(int first, string second?, byte[] third);
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

## Customization
TODO

## Additional Considerations in Generated Code
TODO

## Compatibility
- As this library is based on source generators you have to use the .NET 5 SDK to compile your project.
- The generated code is compatible down to C#` 7.3` and adjusts itself to the available language version and runtime facilities.
- The required runtime library targets `netstandard1.0`.

## License
Licensed under the [Boost Software License 1.0](LICENSE.txt).
