//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable disable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(Variant_disposable.__DebuggerTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    partial class Variant_disposable
        : global::System.IEquatable<Variant_disposable>
        , global::System.IDisposable
    {
        private readonly global::dotVariant._G.Foo.Variant_disposable _variant;

        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_disposable(int i)
            => _variant = new global::dotVariant._G.Foo.Variant_disposable(i);
        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_disposable(global::System.IO.Stream stream)
            => _variant = new global::dotVariant._G.Foo.Variant_disposable(stream);

        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_disposable(int i)
            => new Variant_disposable(i);
        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_disposable(global::System.IO.Stream stream)
            => new Variant_disposable(stream);

        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_disposable Create(int i)
            => new Variant_disposable(i);
        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_disposable Create(global::System.IO.Stream stream)
            => new Variant_disposable(stream);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Dispose()"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Dispose()
        {
            _variant.Dispose();
        }

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.IsEmpty"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool IsEmpty
            => _variant.IsEmpty;

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
            => other is Variant_disposable v
            && Equals(v);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(Variant_disposable other)
            => !(other is null) && _variant.Equals(other._variant);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator ==(Variant_disposable lhs, Variant_disposable rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator !=(Variant_disposable lhs, Variant_disposable rhs)
            => !(lhs == rhs);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override int GetHashCode()
            => _variant.GetHashCode();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override string ToString()
            => _variant.ToString();

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.TryMatch(out int)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(out int i)
            => _variant.TryMatch(out i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.TryMatch(global::System.Action{int})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<int> i)
            => _variant.TryMatch(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(out int)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(out int i)
            => _variant.Match(out i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(global::System.Action{int})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<int> i)
            => _variant.Match(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(global::System.Action{int}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<int> i, global::System.Action _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{int, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i)
            => _variant.Match(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{int, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{int, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<TResult> _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.TryMatch(out global::System.IO.Stream)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(out global::System.IO.Stream stream)
            => _variant.TryMatch(out stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.TryMatch(global::System.Action{global::System.IO.Stream})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<global::System.IO.Stream> stream)
            => _variant.TryMatch(stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(out global::System.IO.Stream)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(out global::System.IO.Stream stream)
            => _variant.Match(out stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(global::System.Action{global::System.IO.Stream})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<global::System.IO.Stream> stream)
            => _variant.Match(stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(global::System.Action{global::System.IO.Stream}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<global::System.IO.Stream> stream, global::System.Action _)
            => _variant.Match(stream, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{global::System.IO.Stream, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream)
            => _variant.Match(stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{global::System.IO.Stream, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream, TResult _)
            => _variant.Match(stream, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{global::System.IO.Stream, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream, global::System.Func<TResult> _)
            => _variant.Match(stream, _);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Visit(global::System.Action{int}, global::System.Action{global::System.IO.Stream})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<int> i, global::System.Action<global::System.IO.Stream> stream)
            => _variant.Visit(i, stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Visit(global::System.Action{int}, global::System.Action{global::System.IO.Stream}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<int> i, global::System.Action<global::System.IO.Stream> stream, global::System.Action _)
            => _variant.Visit(i, stream, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Visit{TResult}(global::System.Func{int, TResult}, global::System.Func{global::System.IO.Stream, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream)
            => _variant.Visit(i, stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Visit{TResult}(global::System.Func{int, TResult}, global::System.Func{global::System.IO.Stream, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream, global::System.Func<TResult> _)
            => _variant.Visit(i, stream, _);

        private sealed class __DebuggerTypeProxy
        {
            public object Value { get; }
            public __DebuggerTypeProxy(Variant_disposable v)
            {
                Value = v._variant.AsObject;
                #pragma warning disable 8604 // Possible null reference argument for parameter
                #pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type
                VariantOf(default, default);
                #pragma warning restore 8604, 8625
            }
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static explicit operator global::dotVariant.GeneratorSupport.Discriminator(Variant_disposable v)
            => (global::dotVariant.GeneratorSupport.Discriminator)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_1<int>(Variant_disposable v)
            => (global::dotVariant.GeneratorSupport.Accessor_1<int>)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>(Variant_disposable v)
            => (global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)v._variant;
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    [global::System.Diagnostics.DebuggerDisplay("{AsObject}", Type = "{TypeString,nq}")]
    internal readonly struct Variant_disposable
        : global::System.IDisposable
    {
        [global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit)]
        private readonly struct Union
        {
            [global::System.Runtime.InteropServices.FieldOffset(0)]
            public readonly Value_1 _1;
            [global::System.Runtime.InteropServices.FieldOffset(0)]
            public readonly Value_2 _2;

            public Union(int value)
            {
                _2 = default;
                _1 = new Value_1(value);
            }
            public Union(global::System.IO.Stream value)
            {
                _1 = default;
                _2 = new Value_2(value);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        private readonly struct Value_1
        {
            public readonly int Value;
            public readonly object _dummy1;

            public Value_1(int value)
            {
                _dummy1 = null;
                Value = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCode]
        private readonly struct Value_2
        {
            public readonly global::System.IO.Stream Value;

            public Value_2(global::System.IO.Stream value)
            {
                Value = value;
            }
        }

        private readonly Union _x;
        private readonly byte _n;

        public Variant_disposable(int i)
        {
            _n = 1;
            _x = new Union(i);
        }
        public Variant_disposable(global::System.IO.Stream stream)
        {
            _n = 2;
            _x = new Union(stream);
        }

        /// <summary>
        /// If the stored value implements <see cref="global::System.IDisposable"/>,
        /// call its <see cref="global::System.IDisposable.Dispose()"/> method.
        /// </summary>
        public void Dispose()
        {
            switch (_n)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    _x._2.Value?.Dispose();
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_disposable");
                    break;
            }
        }

        public static explicit operator global::dotVariant.GeneratorSupport.Discriminator(in Variant_disposable v)
            => (global::dotVariant.GeneratorSupport.Discriminator)v._n;
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_1<int>(in Variant_disposable v)
            => new global::dotVariant.GeneratorSupport.Accessor_1<int>(v._x._1.Value);
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>(in Variant_disposable v)
            => new global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>(v._x._2.Value);

        /// <summary>
        /// <see langword="true"/> if Variant_disposable was constructed without a value.
        /// </summary>
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
                        return "int";
                    case 2:
                        return "System.IO.Stream";
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant_disposable");
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
                    return _x._2.Value?.ToString() ?? "null";
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant_disposable");
            }
        }

        /// <summary>
        /// The stored value cast to type <see cref="object"/>.
        /// </summary>
        public object AsObject
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
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<object>("Foo.Variant_disposable");
                }
            }
        }

        public bool Equals(in Variant_disposable other)
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
                    return global::System.Collections.Generic.EqualityComparer<int>.Default.Equals(_x._1.Value, other._x._1.Value);
                case 2:
                    return global::System.Collections.Generic.EqualityComparer<global::System.IO.Stream>.Default.Equals(_x._2.Value, other._x._2.Value);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<bool>("Foo.Variant_disposable");
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
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<int>("Foo.Variant_disposable");
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="int"/>.</returns>
        public bool TryMatch(out int i)
        {
            i = _n == 1 ? _x._1.Value : default;
            return _n == 1;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="int"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<int> i)
        {
            if (_n == 1)
            {
                i(_x._1.Value);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="int"/>.</exception>
        public void Match(out int i)
        {
            if (_n == 1)
            {
                i = _x._1.Value;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_disposable", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="int"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> is rethrown.</exception>
        public void Match(global::System.Action<int> i)
        {
            if (_n == 1)
            {
                i(_x._1.Value);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_disposable", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<int> i, global::System.Action _)
        {
            if (_n == 1)
            {
                i(_x._1.Value);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="int"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i)
        {
            if (_n == 1)
            {
                return i(_x._1.Value);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_disposable", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
        {
            return _n == 1 ? i(_x._1.Value) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<TResult> _)
        {
            return _n == 1 ? i(_x._1.Value) : _();
        }
        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">Receives the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="global::System.IO.Stream"/>.</returns>
        public bool TryMatch(out global::System.IO.Stream stream)
        {
            stream = _n == 2 ? _x._2.Value : default;
            return _n == 2;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="global::System.IO.Stream"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<global::System.IO.Stream> stream)
        {
            if (_n == 2)
            {
                stream(_x._2.Value);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="stream">Receives the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="global::System.IO.Stream"/>.</exception>
        public void Match(out global::System.IO.Stream stream)
        {
            if (_n == 2)
            {
                stream = _x._2.Value;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_disposable", "System.IO.Stream", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="global::System.IO.Stream"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"/> is rethrown.</exception>
        public void Match(global::System.Action<global::System.IO.Stream> stream)
        {
            if (_n == 2)
            {
                stream(_x._2.Value);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_disposable", "System.IO.Stream", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<global::System.IO.Stream> stream, global::System.Action _)
        {
            if (_n == 2)
            {
                stream(_x._2.Value);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns>The value returned from invoking <paramref name="stream"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="global::System.IO.Stream"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            if (_n == 2)
            {
                return stream(_x._2.Value);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_disposable", "System.IO.Stream", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="stream"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream, TResult _)
        {
            return _n == 2 ? stream(_x._2.Value) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream, global::System.Func<TResult> _)
        {
            return _n == 2 ? stream(_x._2.Value) : _();
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_disposable,
        /// and invoke a special delegate if Variant_disposable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the stored value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_disposable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int> i, global::System.Action<global::System.IO.Stream> stream, global::System.Action _)
        {
            switch (_n)
            {
                case 0:
                    _();
                    break;
                case 1:
                    i(_x._1.Value);
                    break;
                case 2:
                    stream(_x._2.Value);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_disposable");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_disposable,
        /// and throw an exception if Variant_disposable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the stored value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int> i, global::System.Action<global::System.IO.Stream> stream)
        {
            switch (_n)
            {
                case 0:
                    global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant_disposable");
                    break;
                case 1:
                    i(_x._1.Value);
                    break;
                case 2:
                    stream(_x._2.Value);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_disposable");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_disposable and return the result,
        /// and invoke a special delegate if Variant_disposable is empty and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the stored value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_disposable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream, global::System.Func<TResult> _)
        {
            switch (_n)
            {
                case 0:
                    return _();
                case 1:
                    return i(_x._1.Value);
                case 2:
                    return stream(_x._2.Value);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_disposable");
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_disposable and return the result,
        /// and throw an exception if Variant_disposable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the stored value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            switch (_n)
            {
                case 0:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant_disposable");
                case 1:
                    return i(_x._1.Value);
                case 2:
                    return stream(_x._2.Value);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_disposable");
            }
        }
    }
}


namespace Foo
{
    public static partial class Variant_disposableEx
    {
        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> source,
                global::System.Func<int, TResult> i)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 1)
                {
                    yield return i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)variant).Value);
                }
            }
        }
        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="global::System.IO.Stream"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> source,
                global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 2)
                {
                    yield return stream(((global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)variant).Value);
                }
            }
        }

        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> source,
                global::System.Func<int, TResult> i,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 1)
                {
                    yield return i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="global::System.IO.Stream"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> source,
                global::System.Func<global::System.IO.Stream, TResult> stream,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 2)
                {
                    yield return stream(((global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> source,
                global::System.Func<int, TResult> i,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 1)
                {
                    yield return i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="global::System.IO.Stream"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> source,
                global::System.Func<global::System.IO.Stream, TResult> stream,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 2)
                {
                    yield return stream(((global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException"/>
        /// if an element is empty.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the element's value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant_disposable.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> source,
                global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            foreach (var variant in source)
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant))
                {
                    case 0:
                        global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant_disposable");
                        yield break;
                    case 1:
                        yield return i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)variant).Value);
                        break;
                    case 2:
                        yield return stream(((global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)variant).Value);
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_disposable");
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the element's value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> source,
                global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream,
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
                        yield return i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)variant).Value);
                        break;
                    case 2:
                        yield return stream(((global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)variant).Value);
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_disposable");
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    public static partial class Variant_disposableEx
    {
        /// <summary>
        /// Projects each <see cref="int"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<int, TResult> i)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 1),
                _variant => i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)_variant).Value));
        }
        /// <summary>
        /// Projects each <see cref="global::System.IO.Stream"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 2),
                _variant => stream(((global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)_variant).Value));
        }

        /// <summary>
        /// Projects each <see cref="int"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<int, TResult> i,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 1)
                {
                    return i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)_variant).Value);
                }
                else
                {
                    return _;
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="global::System.IO.Stream"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<global::System.IO.Stream, TResult> stream,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 2)
                {
                    return stream(((global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)_variant).Value);
                }
                else
                {
                    return _;
                }
            });
        }

        /// <summary>
        /// Projects each <see cref="int"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<int, TResult> i,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 1)
                {
                    return i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)_variant).Value);
                }
                else
                {
                    return _();
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="global::System.IO.Stream"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<global::System.IO.Stream, TResult> stream,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 2)
                {
                    return stream(((global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)_variant).Value);
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
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the element's value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant))
                {
                    case 0:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant_disposable");
                    case 1:
                        return i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)_variant).Value);
                    case 2:
                        return stream(((global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)_variant).Value);
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_disposable");
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to visit.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the element's value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant))
                {
                    case 0:
                        return _();
                    case 1:
                        return i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)_variant).Value);
                    case 2:
                        return stream(((global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)_variant).Value);
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_disposable");
                }
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_disposable elements into one independent sub-sequences per value type,
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
        /// <param name="i">Transform an observable sequence of <see cref="int"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="stream">Transform an observable sequence of <see cref="global::System.IO.Stream"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<TResult>> i, global::System.Func<global::System.IObservable<global::System.IO.Stream>, global::System.IObservable<TResult>> stream)
        {
            return VisitMany(source, (_1, _2) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(i(_1), stream(_2));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_disposable elements into one independent sub-sequences per value type,
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
        /// <param name="i">Transform an observable sequence of <see cref="int"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="stream">Transform an observable sequence of <see cref="global::System.IO.Stream"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="_">Transform a sequence of <see cref="global::System.Reactive.Unit"/> values (each representing an empty variant) into a sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<TResult>> i, global::System.Func<global::System.IObservable<global::System.IO.Stream>, global::System.IObservable<TResult>> stream,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
        {
            return VisitMany(source, (_1, _2, _0) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(i(_1), stream(_2), _(_0));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_disposable elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<global::System.IO.Stream>, global::System.IObservable<TResult>> selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(false);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject2).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(source, _mo),
                    _mo);
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_disposable elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_disposable> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<global::System.IO.Stream>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(true);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject2, _mo.Subject0).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(source, _mo),
                    _mo);
            });
        }

        private sealed class VisitManyObserver
            : global::System.IObserver<global::Foo.Variant_disposable>, global::System.IDisposable
        {
            public readonly global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit> Subject0 = new global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit>();
            public readonly global::System.Reactive.Subjects.Subject<int> Subject1 = new global::System.Reactive.Subjects.Subject<int>();
            public readonly global::System.Reactive.Subjects.Subject<global::System.IO.Stream> Subject2 = new global::System.Reactive.Subjects.Subject<global::System.IO.Stream>();
            private readonly bool _accept0;

            public VisitManyObserver(bool _accept0)
            {
                this._accept0 = _accept0;
            }

            public void Dispose()
            {
                Subject1.Dispose();
                Subject2.Dispose();
                Subject0.Dispose();
            }

            public void OnNext(global::Foo.Variant_disposable _variant)
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
                            OnError(global::dotVariant.GeneratorSupport.Errors.MakeEmptyError("Foo.Variant_disposable"));
                        }
                        break;
                    case 1:
                        Subject1.OnNext(((global::dotVariant.GeneratorSupport.Accessor_1<int>)_variant).Value);
                        break;
                    case 2:
                        Subject2.OnNext(((global::dotVariant.GeneratorSupport.Accessor_2<global::System.IO.Stream>)_variant).Value);
                        break;
                    default:
                        OnError(global::dotVariant.GeneratorSupport.Errors.MakeInternalError("Foo.Variant_disposable"));
                        break;
                }
            }

            public void OnError(global::System.Exception _ex)
            {
                Subject1.OnError(_ex);
                Subject2.OnError(_ex);
                if (_accept0)
                {
                    Subject0.OnError(_ex);
                }
            }

            public void OnCompleted()
            {
                Subject1.OnCompleted();
                Subject2.OnCompleted();
                if (_accept0)
                {
                    Subject0.OnCompleted();
                }
            }
        }

    }
}
