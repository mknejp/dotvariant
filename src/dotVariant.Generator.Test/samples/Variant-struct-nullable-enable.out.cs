//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable enable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(Variant_struct_nullable_enable.__DebuggerTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    partial struct Variant_struct_nullable_enable
        : global::System.IEquatable<Variant_struct_nullable_enable>
    {
        private readonly global::dotVariant._G.Foo.Variant_struct_nullable_enable _variant;

        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_struct_nullable_enable(long l)
            => _variant = new global::dotVariant._G.Foo.Variant_struct_nullable_enable(l);
        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_struct_nullable_enable(double d)
            => _variant = new global::dotVariant._G.Foo.Variant_struct_nullable_enable(d);
        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_struct_nullable_enable(object o)
            => _variant = new global::dotVariant._G.Foo.Variant_struct_nullable_enable(o);

        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_struct_nullable_enable(long l)
            => new Variant_struct_nullable_enable(l);
        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_struct_nullable_enable(double d)
            => new Variant_struct_nullable_enable(d);

        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_struct_nullable_enable Create(long l)
            => new Variant_struct_nullable_enable(l);
        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_struct_nullable_enable Create(double d)
            => new Variant_struct_nullable_enable(d);
        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_struct_nullable_enable Create(object o)
            => new Variant_struct_nullable_enable(o);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.IsEmpty"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly bool IsEmpty
            => _variant.IsEmpty;

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly override bool Equals(object? other)
            => other is Variant_struct_nullable_enable v
            && Equals(v);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly bool Equals(Variant_struct_nullable_enable other)
            => _variant.Equals(other._variant);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator ==(Variant_struct_nullable_enable lhs, Variant_struct_nullable_enable rhs)
            => lhs.Equals(rhs);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator !=(Variant_struct_nullable_enable lhs, Variant_struct_nullable_enable rhs)
            => !(lhs == rhs);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly override int GetHashCode()
            => _variant.GetHashCode();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly override string ToString()
            => _variant.ToString();

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.TryMatch(out long)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out long l)
            => _variant.TryMatch(out l);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.TryMatch(global::System.Action{long})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly bool TryMatch(global::System.Action<long> l)
            => _variant.TryMatch(l);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match(out long)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out long l)
            => _variant.Match(out l);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match(global::System.Action{long})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly void Match(global::System.Action<long> l)
            => _variant.Match(l);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match(global::System.Action{long}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly void Match(global::System.Action<long> l, global::System.Action _)
            => _variant.Match(l, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match{TResult}(global::System.Func{long, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l)
            => _variant.Match(l);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match{TResult}(global::System.Func{long, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l, TResult _)
            => _variant.Match(l, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match{TResult}(global::System.Func{long, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l, global::System.Func<TResult> _)
            => _variant.Match(l, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.TryMatch(out double)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out double d)
            => _variant.TryMatch(out d);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.TryMatch(global::System.Action{double})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly bool TryMatch(global::System.Action<double> d)
            => _variant.TryMatch(d);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match(out double)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out double d)
            => _variant.Match(out d);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match(global::System.Action{double})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly void Match(global::System.Action<double> d)
            => _variant.Match(d);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match(global::System.Action{double}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly void Match(global::System.Action<double> d, global::System.Action _)
            => _variant.Match(d, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match{TResult}(global::System.Func{double, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d)
            => _variant.Match(d);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match{TResult}(global::System.Func{double, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d, TResult _)
            => _variant.Match(d, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match{TResult}(global::System.Func{double, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d, global::System.Func<TResult> _)
            => _variant.Match(d, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.TryMatch(out object?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out object? o)
            => _variant.TryMatch(out o);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.TryMatch(global::System.Action{object})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly bool TryMatch(global::System.Action<object> o)
            => _variant.TryMatch(o);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match(out object?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out object? o)
            => _variant.Match(out o);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match(global::System.Action{object})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly void Match(global::System.Action<object> o)
            => _variant.Match(o);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match(global::System.Action{object}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly void Match(global::System.Action<object> o, global::System.Action _)
            => _variant.Match(o, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match{TResult}(global::System.Func{object, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o)
            => _variant.Match(o);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match{TResult}(global::System.Func{object, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o, TResult _)
            => _variant.Match(o, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Match{TResult}(global::System.Func{object, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o, global::System.Func<TResult> _)
            => _variant.Match(o, _);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Visit(global::System.Action{long}, global::System.Action{double}, global::System.Action{object})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly void Visit(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o)
            => _variant.Visit(l, d, o);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Visit(global::System.Action{long}, global::System.Action{double}, global::System.Action{object}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly void Visit(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o, global::System.Action _)
            => _variant.Visit(l, d, o, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Visit{TResult}(global::System.Func{long, TResult}, global::System.Func{double, TResult}, global::System.Func{object, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly TResult Visit<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
            => _variant.Visit(l, d, o);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_struct_nullable_enable.Visit{TResult}(global::System.Func{long, TResult}, global::System.Func{double, TResult}, global::System.Func{object, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public readonly TResult Visit<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o, global::System.Func<TResult> _)
            => _variant.Visit(l, d, o, _);

        private sealed class __DebuggerTypeProxy
        {
            public object? Value { get; }
            public __DebuggerTypeProxy(Variant_struct_nullable_enable v)
            {
                Value = v._variant.AsObject;
                #pragma warning disable 8604 // Possible null reference argument for parameter
                #pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type
                VariantOf(default, default, default);
                #pragma warning restore 8604, 8625
            }
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static explicit operator global::dotVariant.GeneratorSupport.Discriminator(Variant_struct_nullable_enable v)
            => (global::dotVariant.GeneratorSupport.Discriminator)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_1<long>(Variant_struct_nullable_enable v)
            => (global::dotVariant.GeneratorSupport.Accessor_1<long>)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_2<double>(Variant_struct_nullable_enable v)
            => (global::dotVariant.GeneratorSupport.Accessor_2<double>)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_3<object>(Variant_struct_nullable_enable v)
            => (global::dotVariant.GeneratorSupport.Accessor_3<object>)v._variant;
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    [global::System.Diagnostics.DebuggerDisplay("{AsObject}", Type = "{TypeString,nq}")]
    internal readonly struct Variant_struct_nullable_enable
    {
        [global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit)]
        private readonly struct Union
        {
            [global::System.Runtime.InteropServices.FieldOffset(0)]
            public readonly Value_1 _1;
            [global::System.Runtime.InteropServices.FieldOffset(0)]
            public readonly Value_2 _2;
            [global::System.Runtime.InteropServices.FieldOffset(0)]
            public readonly Value_3 _3;

            public Union(long value)
            {
                _2 = default;
                _3 = default;
                _1 = new Value_1(value);
            }
            public Union(double value)
            {
                _1 = default;
                _3 = default;
                _2 = new Value_2(value);
            }
            public Union(object value)
            {
                _1 = default;
                _2 = default;
                _3 = new Value_3(value);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        private readonly struct Value_1
        {
            public readonly long Value;
            public readonly object _dummy1;

            public Value_1(long value)
            {
                _dummy1 = null!;
                Value = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCode]
        private readonly struct Value_2
        {
            public readonly double Value;
            public readonly object _dummy1;

            public Value_2(double value)
            {
                _dummy1 = null!;
                Value = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCode]
        private readonly struct Value_3
        {
            public readonly object Value;

            public Value_3(object value)
            {
                Value = value;
            }
        }

        private readonly Union _x;
        private readonly byte _n;

        public Variant_struct_nullable_enable(long l)
        {
            _n = 1;
            _x = new Union(l);
        }
        public Variant_struct_nullable_enable(double d)
        {
            _n = 2;
            _x = new Union(d);
        }
        public Variant_struct_nullable_enable(object o)
        {
            _n = 3;
            _x = new Union(o);
        }


        public static explicit operator global::dotVariant.GeneratorSupport.Discriminator(in Variant_struct_nullable_enable v)
            => (global::dotVariant.GeneratorSupport.Discriminator)v._n;
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_1<long>(in Variant_struct_nullable_enable v)
            => new global::dotVariant.GeneratorSupport.Accessor_1<long>(v._x._1.Value);
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_2<double>(in Variant_struct_nullable_enable v)
            => new global::dotVariant.GeneratorSupport.Accessor_2<double>(v._x._2.Value);
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_3<object>(in Variant_struct_nullable_enable v)
            => new global::dotVariant.GeneratorSupport.Accessor_3<object>(v._x._3.Value);

        /// <summary>
        /// <see langword="true"/> if Variant_struct_nullable_enable was constructed without a value.
        /// </summary>
        /// <remarks>
        /// Because Variant_struct_nullable_enable is a value type, its default constructor cannot be disabled.
        /// A default-constructed Variant_struct_nullable_enable will always have a <c>IsEmpty</c> value of <see langword="true"/>
        /// and never satisfy any matching attempts except for the wildcard <c>_</c> parameter.
        /// </remarks>
        public bool IsEmpty => _n == 0;

        /// <summary>
        /// The string representation of the stored value's type.
        /// </summary>
        public string TypeString
        {
            get
            {
                switch (_n)
                {
                    case 0:
                        return "<empty>";
                    case 1:
                        return "long";
                    case 2:
                        return "double";
                    case 3:
                        return "object";
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant_struct_nullable_enable");
                }
            }
        }

        /// <summary>
        /// The stored value's <see cref="object.ToString()"/> result, or <c>""</c> if empty.
        /// </summary>
        public override string ToString()
        {
            switch (_n)
            {
                case 0:
                    return "";
                case 1:
                    return _x._1.Value.ToString();
                case 2:
                    return _x._2.Value.ToString();
                case 3:
                    return _x._3.Value.ToString() ?? "null";
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant_struct_nullable_enable");
            }
        }

        /// <summary>
        /// The stored value cast to type <see cref="object"/>.
        /// </summary>
        public object? AsObject
        {
            get
            {
                switch (_n)
                {
                    case 0:
                        return null;
                    case 1:
                        return _x._1.Value;
                    case 2:
                        return _x._2.Value;
                    case 3:
                        return _x._3.Value;
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<object?>("Foo.Variant_struct_nullable_enable");
                }
            }
        }

        public bool Equals(in Variant_struct_nullable_enable other)
        {
            if (_n != other._n)
            {
                return false;
            }
            switch (_n)
            {
                case 0:
                    return true;
                case 1:
                    return global::System.Collections.Generic.EqualityComparer<long>.Default.Equals(_x._1.Value, other._x._1.Value);
                case 2:
                    return global::System.Collections.Generic.EqualityComparer<double>.Default.Equals(_x._2.Value, other._x._2.Value);
                case 3:
                    return global::System.Collections.Generic.EqualityComparer<object>.Default.Equals(_x._3.Value, other._x._3.Value);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<bool>("Foo.Variant_struct_nullable_enable");
            }
        }

        public override int GetHashCode()
        {
            switch (_n)
            {
                case 0:
                    return 0;
                case 1:
                    return global::System.HashCode.Combine(_x._1.Value);
                case 2:
                    return global::System.HashCode.Combine(_x._2.Value);
                case 3:
                    return global::System.HashCode.Combine(_x._3.Value);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<int>("Foo.Variant_struct_nullable_enable");
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">Receives the stored value if it is of type <see cref="long"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="long"/>.</returns>
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out long l)
        {
            l = _n == 1 ? _x._1.Value : default;
            return _n == 1;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="long"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<long> l)
        {
            if (_n == 1)
            {
                l(_x._1.Value);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="l">Receives the stored value if it is of type <see cref="long"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="long"/>.</exception>
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out long l)
        {
            if (_n == 1)
            {
                l = _x._1.Value;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_struct_nullable_enable", "long", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="long"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"/> is rethrown.</exception>
        public void Match(global::System.Action<long> l)
        {
            if (_n == 1)
            {
                l(_x._1.Value);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_struct_nullable_enable", "long", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<long> l, global::System.Action _)
        {
            if (_n == 1)
            {
                l(_x._1.Value);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <returns>The value returned from invoking <paramref name="l"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="long"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<long, TResult> l)
        {
            if (_n == 1)
            {
                return l(_x._1.Value);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_struct_nullable_enable", "long", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="l"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<long, TResult> l, TResult _)
        {
            return _n == 1 ? l(_x._1.Value) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<long, TResult> l, global::System.Func<TResult> _)
        {
            return _n == 1 ? l(_x._1.Value) : _();
        }
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">Receives the stored value if it is of type <see cref="double"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="double"/>.</returns>
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out double d)
        {
            d = _n == 2 ? _x._2.Value : default;
            return _n == 2;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="double"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<double> d)
        {
            if (_n == 2)
            {
                d(_x._2.Value);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="d">Receives the stored value if it is of type <see cref="double"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="double"/>.</exception>
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out double d)
        {
            if (_n == 2)
            {
                d = _x._2.Value;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_struct_nullable_enable", "double", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="double"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"/> is rethrown.</exception>
        public void Match(global::System.Action<double> d)
        {
            if (_n == 2)
            {
                d(_x._2.Value);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_struct_nullable_enable", "double", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<double> d, global::System.Action _)
        {
            if (_n == 2)
            {
                d(_x._2.Value);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <returns>The value returned from invoking <paramref name="d"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="double"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<double, TResult> d)
        {
            if (_n == 2)
            {
                return d(_x._2.Value);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_struct_nullable_enable", "double", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="d"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<double, TResult> d, TResult _)
        {
            return _n == 2 ? d(_x._2.Value) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<double, TResult> d, global::System.Func<TResult> _)
        {
            return _n == 2 ? d(_x._2.Value) : _();
        }
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">Receives the stored value if it is of type <see cref="object"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="object"/>.</returns>
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out object? o)
        {
            o = _n == 3 ? _x._3.Value : default;
            return _n == 3;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="object"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<object> o)
        {
            if (_n == 3)
            {
                o(_x._3.Value);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="o">Receives the stored value if it is of type <see cref="object"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="object"/>.</exception>
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out object? o)
        {
            if (_n == 3)
            {
                o = _x._3.Value;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_struct_nullable_enable", "object", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="object"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"/> is rethrown.</exception>
        public void Match(global::System.Action<object> o)
        {
            if (_n == 3)
            {
                o(_x._3.Value);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_struct_nullable_enable", "object", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<object> o, global::System.Action _)
        {
            if (_n == 3)
            {
                o(_x._3.Value);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <returns>The value returned from invoking <paramref name="o"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="object"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<object, TResult> o)
        {
            if (_n == 3)
            {
                return o(_x._3.Value);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_struct_nullable_enable", "object", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="o"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<object, TResult> o, TResult _)
        {
            return _n == 3 ? o(_x._3.Value) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<object, TResult> o, global::System.Func<TResult> _)
        {
            return _n == 3 ? o(_x._3.Value) : _();
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_struct_nullable_enable,
        /// and invoke a special delegate if Variant_struct_nullable_enable is empty.
        /// </summary>
        /// <param name="l">The delegate to invoke if the stored value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the stored value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the stored value is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_struct_nullable_enable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o, global::System.Action _)
        {
            switch (_n)
            {
                case 0:
                    _();
                    break;
                case 1:
                    l(_x._1.Value);
                    break;
                case 2:
                    d(_x._2.Value);
                    break;
                case 3:
                    o(_x._3.Value);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_struct_nullable_enable");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_struct_nullable_enable,
        /// and throw an exception if Variant_struct_nullable_enable is empty.
        /// </summary>
        /// <param name="l">The delegate to invoke if the stored value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the stored value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the stored value is of type <see cref="object"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o)
        {
            switch (_n)
            {
                case 0:
                    global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant_struct_nullable_enable");
                    break;
                case 1:
                    l(_x._1.Value);
                    break;
                case 2:
                    d(_x._2.Value);
                    break;
                case 3:
                    o(_x._3.Value);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_struct_nullable_enable");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_struct_nullable_enable and return the result,
        /// and invoke a special delegate if Variant_struct_nullable_enable is empty and return its result.
        /// </summary>
        /// <param name="l">The delegate to invoke if the stored value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the stored value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the stored value is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_struct_nullable_enable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o, global::System.Func<TResult> _)
        {
            switch (_n)
            {
                case 0:
                    return _();
                case 1:
                    return l(_x._1.Value);
                case 2:
                    return d(_x._2.Value);
                case 3:
                    return o(_x._3.Value);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_struct_nullable_enable");
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_struct_nullable_enable and return the result,
        /// and throw an exception if Variant_struct_nullable_enable is empty.
        /// </summary>
        /// <param name="l">The delegate to invoke if the stored value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the stored value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the stored value is of type <see cref="object"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
        {
            switch (_n)
            {
                case 0:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant_struct_nullable_enable");
                case 1:
                    return l(_x._1.Value);
                case 2:
                    return d(_x._2.Value);
                case 3:
                    return o(_x._3.Value);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_struct_nullable_enable");
            }
        }
    }
}


namespace Foo
{
    public static partial class Variant_struct_nullable_enableEx
    {
        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="long"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="l">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<long, TResult> l)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 1)
                {
                    yield return l(((global::dotVariant.GeneratorSupport.Accessor_1<long>)variant).Value);
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="double"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="d">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<double, TResult> d)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 2)
                {
                    yield return d(((global::dotVariant.GeneratorSupport.Accessor_2<double>)variant).Value);
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="object"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="o">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<object, TResult> o)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 3)
                {
                    yield return o(((global::dotVariant.GeneratorSupport.Accessor_3<object>)variant).Value);
                }
            }
        }

        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="long"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="l">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<long, TResult> l,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 1)
                {
                    yield return l(((global::dotVariant.GeneratorSupport.Accessor_1<long>)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="double"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="d">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<double, TResult> d,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 2)
                {
                    yield return d(((global::dotVariant.GeneratorSupport.Accessor_2<double>)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="object"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="o">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<object, TResult> o,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 3)
                {
                    yield return o(((global::dotVariant.GeneratorSupport.Accessor_3<object>)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="long"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="l">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<long, TResult> l,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 1)
                {
                    yield return l(((global::dotVariant.GeneratorSupport.Accessor_1<long>)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="double"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="d">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<double, TResult> d,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 2)
                {
                    yield return d(((global::dotVariant.GeneratorSupport.Accessor_2<double>)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="object"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="o">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<object, TResult> o,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 3)
                {
                    yield return o(((global::dotVariant.GeneratorSupport.Accessor_3<object>)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException"/>
        /// if an element is empty.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="l">The delegate to invoke if the element's value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the element's value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the element's value is of type <see cref="object"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant_struct_nullable_enable.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
        {
            foreach (var variant in source)
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant))
                {
                    case 0:
                        global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant_struct_nullable_enable");
                        yield break;
                    case 1:
                        yield return l(((global::dotVariant.GeneratorSupport.Accessor_1<long>)variant).Value);
                        break;
                    case 2:
                        yield return d(((global::dotVariant.GeneratorSupport.Accessor_2<double>)variant).Value);
                        break;
                    case 3:
                        yield return o(((global::dotVariant.GeneratorSupport.Accessor_3<object>)variant).Value);
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_struct_nullable_enable");
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="l">The delegate to invoke if the element's value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the element's value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the element's value is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant))
                {
                    case 0:
                        yield return _();
                        break;
                    case 1:
                        yield return l(((global::dotVariant.GeneratorSupport.Accessor_1<long>)variant).Value);
                        break;
                    case 2:
                        yield return d(((global::dotVariant.GeneratorSupport.Accessor_2<double>)variant).Value);
                        break;
                    case 3:
                        yield return o(((global::dotVariant.GeneratorSupport.Accessor_3<object>)variant).Value);
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_struct_nullable_enable");
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    public static partial class Variant_struct_nullable_enableEx
    {
        /// <summary>
        /// Projects each <see cref="long"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="l">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<long, TResult> l)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 1),
                _variant => l(((global::dotVariant.GeneratorSupport.Accessor_1<long>)_variant).Value));
        }
        /// <summary>
        /// Projects each <see cref="double"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="d">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<double, TResult> d)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 2),
                _variant => d(((global::dotVariant.GeneratorSupport.Accessor_2<double>)_variant).Value));
        }
        /// <summary>
        /// Projects each <see cref="object"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="o">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<object, TResult> o)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 3),
                _variant => o(((global::dotVariant.GeneratorSupport.Accessor_3<object>)_variant).Value));
        }

        /// <summary>
        /// Projects each <see cref="long"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="l">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<long, TResult> l,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 1)
                {
                    return l(((global::dotVariant.GeneratorSupport.Accessor_1<long>)_variant).Value);
                }
                else
                {
                    return _;
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="double"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="d">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<double, TResult> d,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 2)
                {
                    return d(((global::dotVariant.GeneratorSupport.Accessor_2<double>)_variant).Value);
                }
                else
                {
                    return _;
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="object"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="o">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<object, TResult> o,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 3)
                {
                    return o(((global::dotVariant.GeneratorSupport.Accessor_3<object>)_variant).Value);
                }
                else
                {
                    return _;
                }
            });
        }

        /// <summary>
        /// Projects each <see cref="long"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="l">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<long, TResult> l,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 1)
                {
                    return l(((global::dotVariant.GeneratorSupport.Accessor_1<long>)_variant).Value);
                }
                else
                {
                    return _();
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="double"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="d">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<double, TResult> d,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 2)
                {
                    return d(((global::dotVariant.GeneratorSupport.Accessor_2<double>)_variant).Value);
                }
                else
                {
                    return _();
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="object"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="o">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<object, TResult> o,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 3)
                {
                    return o(((global::dotVariant.GeneratorSupport.Accessor_3<object>)_variant).Value);
                }
                else
                {
                    return _();
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to visit.</param>
        /// <param name="l">The delegate to invoke if the element's value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the element's value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the element's value is of type <see cref="object"/>.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant))
                {
                    case 0:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant_struct_nullable_enable");
                    case 1:
                        return l(((global::dotVariant.GeneratorSupport.Accessor_1<long>)_variant).Value);
                    case 2:
                        return d(((global::dotVariant.GeneratorSupport.Accessor_2<double>)_variant).Value);
                    case 3:
                        return o(((global::dotVariant.GeneratorSupport.Accessor_3<object>)_variant).Value);
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_struct_nullable_enable");
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to visit.</param>
        /// <param name="l">The delegate to invoke if the element's value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the element's value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the element's value is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant))
                {
                    case 0:
                        return _();
                    case 1:
                        return l(((global::dotVariant.GeneratorSupport.Accessor_1<long>)_variant).Value);
                    case 2:
                        return d(((global::dotVariant.GeneratorSupport.Accessor_2<double>)_variant).Value);
                    case 3:
                        return o(((global::dotVariant.GeneratorSupport.Accessor_3<object>)_variant).Value);
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_struct_nullable_enable");
                }
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_struct_nullable_enable elements into one independent sub-sequences per value type,
        /// transforming each sub-sequence by the provided selector, and merges the resulting values into one observable sequence,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>While the subscription to the source is active the sub-sequences are hot.</item>
        ///     <item>Multiple subscriptions and repeated subscriptions within the sub-sequences will not cause repeated subscriptions to the source.</item>
        ///     <item>Once the source sequence terminates it cannot be re-subscribed to with operators like <c>Repeat</c> or <c>Retry</c> from within a sub-sequence.</item>
        ///     <item>The first sub-sequence to produce an OnError message terminates the resulting sequence with OnError.</item>
        ///     <item>When all sub-sequences terminate with OnCompleted (even before the source does) the resulting sequence terminates.</item>
        /// </list>
        /// </remarks>
        /// <param name="source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="l">Transform an observable sequence of <see cref="long"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="d">Transform an observable sequence of <see cref="double"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="o">Transform an observable sequence of <see cref="object"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<global::System.IObservable<long>, global::System.IObservable<TResult>> l, global::System.Func<global::System.IObservable<double>, global::System.IObservable<TResult>> d, global::System.Func<global::System.IObservable<object>, global::System.IObservable<TResult>> o)
        {
            return VisitMany(source, (_1, _2, _3) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(l(_1), d(_2), o(_3));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_struct_nullable_enable elements into one independent sub-sequences per value type,
        /// transforming each sub-sequence by the provided selector, and merges the resulting values into one observable sequence.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>While the subscription to the source is active the sub-sequences are hot.</item>
        ///     <item>Multiple subscriptions and repeated subscriptions within the sub-sequences will not cause repeated subscriptions to the source.</item>
        ///     <item>Once the source sequence terminates it cannot be re-subscribed to with operators like <c>Repeat</c> or <c>Retry</c> from within a sub-sequence.</item>
        ///     <item>The first sub-sequence to produce an OnError message terminates the resulting sequence with OnError.</item>
        ///     <item>When all sub-sequences terminate with OnCompleted (even before the source does) the resulting sequence terminates.</item>
        /// </list>
        /// </remarks>
        /// <param name="source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="l">Transform an observable sequence of <see cref="long"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="d">Transform an observable sequence of <see cref="double"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="o">Transform an observable sequence of <see cref="object"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="_">Transform a sequence of <see cref="global::System.Reactive.Unit"/> values (each representing an empty variant) into a sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<global::System.IObservable<long>, global::System.IObservable<TResult>> l, global::System.Func<global::System.IObservable<double>, global::System.IObservable<TResult>> d, global::System.Func<global::System.IObservable<object>, global::System.IObservable<TResult>> o,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
        {
            return VisitMany(source, (_1, _2, _3, _0) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(l(_1), d(_2), o(_3), _(_0));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_struct_nullable_enable elements into one independent sub-sequences per value type,
        /// and combines the resulting values into one observable sequence according to the combining selector,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>While the subscription to the source is active the sub-sequences are hot.</item>
        ///     <item>Multiple subscriptions and repeated subscriptions within the sub-sequences will not cause repeated subscriptions to the source.</item>
        ///     <item>Once the source sequence terminates it cannot be re-subscribed to with operators like <c>Repeat</c> or <c>Retry</c> from within a sub-sequence.</item>
        ///     <item>How termination (successful or error) of sub-sequences affects the resulting sequence depends on the combining operation.</item>
        /// </list>
        /// </remarks>
        /// <param name="source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="selector">Combine the individual sub-sequences into one resulting sequence.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<global::System.IObservable<long>, global::System.IObservable<double>, global::System.IObservable<object>, global::System.IObservable<TResult>> selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(false);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject2, _mo.Subject3).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(source, _mo),
                    _mo);
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_struct_nullable_enable elements into one independent sub-sequences per value type,
        /// and combines the resulting values into one observable sequence according to the combining selector.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        ///     <item>While the subscription to the source is active the sub-sequences are hot.</item>
        ///     <item>Multiple subscriptions and repeated subscriptions within the sub-sequences will not cause repeated subscriptions to the source.</item>
        ///     <item>Once the source sequence terminates it cannot be re-subscribed to with operators like <c>Repeat</c> or <c>Retry</c> from within a sub-sequence.</item>
        ///     <item>How termination (successful or error) of sub-sequences affects the resulting sequence depends on the combining operation.</item>
        /// </list>
        /// </remarks>
        /// <param name="source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="selector">Combine the individual sub-sequences into one resulting sequence.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_struct_nullable_enable> source,
                global::System.Func<global::System.IObservable<long>, global::System.IObservable<double>, global::System.IObservable<object>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(true);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject2, _mo.Subject3, _mo.Subject0).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(source, _mo),
                    _mo);
            });
        }

        private sealed class VisitManyObserver
            : global::System.IObserver<global::Foo.Variant_struct_nullable_enable>, global::System.IDisposable
        {
            public readonly global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit> Subject0 = new global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit>();
            public readonly global::System.Reactive.Subjects.Subject<long> Subject1 = new global::System.Reactive.Subjects.Subject<long>();
            public readonly global::System.Reactive.Subjects.Subject<double> Subject2 = new global::System.Reactive.Subjects.Subject<double>();
            public readonly global::System.Reactive.Subjects.Subject<object> Subject3 = new global::System.Reactive.Subjects.Subject<object>();
            private readonly bool _accept0;

            public VisitManyObserver(bool _accept0)
            {
                this._accept0 = _accept0;
            }

            public void Dispose()
            {
                Subject1.Dispose();
                Subject2.Dispose();
                Subject3.Dispose();
                Subject0.Dispose();
            }

            public void OnNext(global::Foo.Variant_struct_nullable_enable _variant)
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant))
                {
                    case 0:
                        if (_accept0)
                        {
                            Subject0.OnNext(global::System.Reactive.Unit.Default);
                        }
                        else
                        {
                            OnError(global::dotVariant.GeneratorSupport.Errors.MakeEmptyError("Foo.Variant_struct_nullable_enable"));
                        }
                        break;
                    case 1:
                        Subject1.OnNext(((global::dotVariant.GeneratorSupport.Accessor_1<long>)_variant).Value);
                        break;
                    case 2:
                        Subject2.OnNext(((global::dotVariant.GeneratorSupport.Accessor_2<double>)_variant).Value);
                        break;
                    case 3:
                        Subject3.OnNext(((global::dotVariant.GeneratorSupport.Accessor_3<object>)_variant).Value);
                        break;
                    default:
                        OnError(global::dotVariant.GeneratorSupport.Errors.MakeInternalError("Foo.Variant_struct_nullable_enable"));
                        break;
                }
            }

            public void OnError(global::System.Exception _ex)
            {
                Subject1.OnError(_ex);
                Subject2.OnError(_ex);
                Subject3.OnError(_ex);
                if (_accept0)
                {
                    Subject0.OnError(_ex);
                }
            }

            public void OnCompleted()
            {
                Subject1.OnCompleted();
                Subject2.OnCompleted();
                Subject3.OnCompleted();
                if (_accept0)
                {
                    Subject0.OnCompleted();
                }
            }
        }

    }
}
