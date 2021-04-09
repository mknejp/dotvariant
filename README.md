# dotVariant
A type-safe and space-efficient sum type for C# (comparable to unions in C or C++)

## What is a Variant?
A variant is similar to a struct or class, except that it can always only contain _one_ of its fields. A `class` declared with an `int` and a `string` property always contains one `int` value and one `string` value. In comparison to that a variant declared with an `int` option and a `string` option always contains _either_ an `int` value _or_ a `string` value, but never both. The library also makes a best effort at minimizing the amount of storage required by the variant as it can always only contain a single value. This is similar to C and C++ `union`, but tweaked to work under the restrictions of the .NET runtime.

### Declaring a Variant
You declare your own variant as follows:
```csharp
using namespace dotVariant;

namespace MyNamespace
{
    [Variant]
    partial class MyVariant
    {
        partial void VariantOf(int a, double d, string s);
    }
}
```
Note that your type (`class` or `struct`) must be declared `partial` otherwise it is not compatible with source generators. The addition of the `[Variant]` attribute triggers code generation for this type. The `VariantOf` method is how you tell the generator what the possible values of this variant are.

`MyVariant` will receive a rich set of public properties and methods for you to use. In addition you will find a private `_variant` field which hides away all the implementation details, which you can access in your own methods, as nothing stops you from adding your own members to `MyVariant` if you chose to.

### Using a Variant
With the above declaration, you are ready to use your new variant:
```csharp
var variant1 = new MyVaraint(1);
variant1.Match(out int i);
Console.WriteLine(i); // prints 1

var variant2 = new MyVariant(2.5);
variant2.Match(out double d);
Console.WriteLine(d); // prints 2.5

var variant3 = new MyVariant("hello");
variant3.Match(out string s);
Console.WriteLine(s); // prints "hello"
```
Note how we used the same type to store and retrieve different types. However, you are not limited to just `out` variables, you can also pass in functions:
```csharp
var variant1 = new MyVaraint(1);
variant1.Match((int i) => Console.WriteLine(i)); // prints 1

var variant2 = new MyVaraint(2.5);
variant2.Match((double d) => Console.WriteLine(d)); // prints 2.5

var variant3 = new MyVaraint("world");
variant3.Match((string s) => Console.WriteLine(s)); // prints "world"
```
And you can even return values from these functions, which are returned from `Match`:
```csharp
var variant1 = new MyVaraint(2);
var i = variant1.Match((int i) => i * 5); // i = 10

var variant2 = new MyVaraint(2.5);
var d = variant2.Match((double d) => Math.Sin(d)); // d = 0.90929742682568171

var variant3 = new MyVaraint("world");
var s = variant3.Match((string s) => $"hello {s}!"); // s = "hello world!"
```
The real power behind variants, however, comes from visitation. In this case you receive a variant of which you do not know which type it contains, and you process each type differently:
```csharp
string GetContainedType(MyVaraint variant)
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
`Visit` accepts one delegate per possible type it _might_ contain, and invokes the one corresponding to the value it _does_ contain at runtime. Natiurally, all delegates must return the same type.

There are many available overloads of `Match` and `Visit` which hopefully fulfill all your needs.

## License
Licensed under the [Boost Software License 1.0](LICENSE.txt).
