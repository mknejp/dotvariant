//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable disable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(Variant_public.__DebuggerTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    partial class Variant_public
        : global::System.IEquatable<Variant_public>
    {
        private readonly global::dotVariant._G.Foo.Variant_public _variant;

        /// <summary>
        /// Create a Variant_public with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_public(int i)
            => _variant = new global::dotVariant._G.Foo.Variant_public(i);
        /// <summary>
        /// Create a Variant_public with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_public(string s)
            => _variant = new global::dotVariant._G.Foo.Variant_public(s);

        /// <summary>
        /// Create a Variant_public with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_public(int i)
            => new Variant_public(i);
        /// <summary>
        /// Create a Variant_public with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_public(string s)
            => new Variant_public(s);

        /// <summary>
        /// Create a Variant_public with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_public Create(int i)
            => new Variant_public(i);
        /// <summary>
        /// Create a Variant_public with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_public Create(string s)
            => new Variant_public(s);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.IsEmpty"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool IsEmpty
            => _variant.IsEmpty;

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
            => other is Variant_public v
            && Equals(v);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(Variant_public other)
            => !(other is null) && _variant.Equals(other._variant);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator ==(Variant_public lhs, Variant_public rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator !=(Variant_public lhs, Variant_public rhs)
            => !(lhs == rhs);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override int GetHashCode()
            => _variant.GetHashCode();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override string ToString()
            => _variant.ToString();

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.TryMatch(out int)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(out int i)
            => _variant.TryMatch(out i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.TryMatch(global::System.Action{int})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<int> i)
            => _variant.TryMatch(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match(out int)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(out int i)
            => _variant.Match(out i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match(global::System.Action{int})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<int> i)
            => _variant.Match(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match(global::System.Action{int}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<int> i, global::System.Action _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match{TResult}(global::System.Func{int, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i)
            => _variant.Match(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match{TResult}(global::System.Func{int, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match{TResult}(global::System.Func{int, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<TResult> _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.TryMatch(out string)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(out string s)
            => _variant.TryMatch(out s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.TryMatch(global::System.Action{string})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<string> s)
            => _variant.TryMatch(s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match(out string)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(out string s)
            => _variant.Match(out s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match(global::System.Action{string})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<string> s)
            => _variant.Match(s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match(global::System.Action{string}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<string> s, global::System.Action _)
            => _variant.Match(s, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match{TResult}(global::System.Func{string, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<string, TResult> s)
            => _variant.Match(s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match{TResult}(global::System.Func{string, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<string, TResult> s, TResult _)
            => _variant.Match(s, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Match{TResult}(global::System.Func{string, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<string, TResult> s, global::System.Func<TResult> _)
            => _variant.Match(s, _);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Visit(global::System.Action{int}, global::System.Action{string})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<int> i, global::System.Action<string> s)
            => _variant.Visit(i, s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Visit(global::System.Action{int}, global::System.Action{string}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<int> i, global::System.Action<string> s, global::System.Action _)
            => _variant.Visit(i, s, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Visit{TResult}(global::System.Func{int, TResult}, global::System.Func{string, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<string, TResult> s)
            => _variant.Visit(i, s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_public.Visit{TResult}(global::System.Func{int, TResult}, global::System.Func{string, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<string, TResult> s, global::System.Func<TResult> _)
            => _variant.Visit(i, s, _);

        private sealed class __DebuggerTypeProxy
        {
            public object Value { get; }
            public __DebuggerTypeProxy(Variant_public v)
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
        public static explicit operator global::dotVariant.GeneratorSupport.Discriminator(Variant_public v)
            => (global::dotVariant.GeneratorSupport.Discriminator)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_1<int>(Variant_public v)
            => (global::dotVariant.GeneratorSupport.Accessor_1<int>)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_2<string>(Variant_public v)
            => (global::dotVariant.GeneratorSupport.Accessor_2<string>)v._variant;
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    [global::System.Diagnostics.DebuggerDisplay("{AsObject}", Type = "{TypeString,nq}")]
    internal readonly struct Variant_public
    {
        private readonly struct Union
        {
            public readonly int _1;
            public Union(int value)
            {
                _2 = default;
                _1 = value;
            }
            public readonly string _2;
            public Union(string value)
            {
                _1 = default;
                _2 = value;
            }
        }

        private readonly Union _x;
        private readonly byte _n;

        public Variant_public(int i)
        {
            _n = 1;
            _x = new Union(i);
        }
        public Variant_public(string s)
        {
            _n = 2;
            _x = new Union(s);
        }


        public static explicit operator global::dotVariant.GeneratorSupport.Discriminator(in Variant_public v)
            => (global::dotVariant.GeneratorSupport.Discriminator)v._n;
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_1<int>(in Variant_public v)
            => new global::dotVariant.GeneratorSupport.Accessor_1<int>(v._x._1);
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_2<string>(in Variant_public v)
            => new global::dotVariant.GeneratorSupport.Accessor_2<string>(v._x._2);

        /// <summary>
        /// <see langword="true"/> if Variant_public was constructed without a value.
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
                        return "string";
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant_public");
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
                    return _x._1.ToString();
                case 2:
                    return _x._2?.ToString() ?? "null";
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant_public");
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
                        return _x._1;
                    case 2:
                        return _x._2;
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<object>("Foo.Variant_public");
                }
            }
        }

        public bool Equals(in Variant_public other)
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
                    return global::System.Collections.Generic.EqualityComparer<int>.Default.Equals(_x._1, other._x._1);
                case 2:
                    return global::System.Collections.Generic.EqualityComparer<string>.Default.Equals(_x._2, other._x._2);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<bool>("Foo.Variant_public");
            }
        }

        public override int GetHashCode()
        {
            switch (_n)
            {
                case 0:
                    return 0;
                case 1:
                    return global::System.HashCode.Combine(_x._1);
                case 2:
                    return global::System.HashCode.Combine(_x._2);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<int>("Foo.Variant_public");
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant_public if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_public contained a value of type <see cref="int"/>.</returns>
        public bool TryMatch(out int i)
        {
            i = _n == 1 ? _x._1 : default;
            return _n == 1;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_public contained a value of type <see cref="int"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<int> i)
        {
            if (_n == 1)
            {
                i(_x._1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_public if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_public does not contain a value of type <see cref="int"/>.</exception>
        public void Match(out int i)
        {
            if (_n == 1)
            {
                i = _x._1;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_public", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_public does not contain a value of type <see cref="int"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> is rethrown.</exception>
        public void Match(global::System.Action<int> i)
        {
            if (_n == 1)
            {
                i(_x._1);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_public", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="int"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<int> i, global::System.Action _)
        {
            if (_n == 1)
            {
                i(_x._1);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="int"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_public does not contain a value of type <see cref="int"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i)
        {
            if (_n == 1)
            {
                return i(_x._1);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_public", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="int"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
        {
            return _n == 1 ? i(_x._1) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="int"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<TResult> _)
        {
            return _n == 1 ? i(_x._1) : _();
        }
        /// <summary>
        /// Retrieve the value stored within Variant_public if it is of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">Receives the stored value if it is of type <see cref="string"/>.</param>
        /// <returns><see langword="true"/> if Variant_public contained a value of type <see cref="string"/>.</returns>
        public bool TryMatch(out string s)
        {
            s = _n == 2 ? _x._2 : default;
            return _n == 2;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <returns><see langword="true"/> if Variant_public contained a value of type <see cref="string"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<string> s)
        {
            if (_n == 2)
            {
                s(_x._2);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_public if it is of type <see cref="string"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">Receives the stored value if it is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_public does not contain a value of type <see cref="string"/>.</exception>
        public void Match(out string s)
        {
            if (_n == 2)
            {
                s = _x._2;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_public", "string", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="string"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_public does not contain a value of type <see cref="string"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"/> is rethrown.</exception>
        public void Match(global::System.Action<string> s)
        {
            if (_n == 2)
            {
                s(_x._2);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_public", "string", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="string"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<string> s, global::System.Action _)
        {
            if (_n == 2)
            {
                s(_x._2);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="string"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <returns>The value returned from invoking <paramref name="s"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_public does not contain a value of type <see cref="string"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s)
        {
            if (_n == 2)
            {
                return s(_x._2);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_public", "string", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="string"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="s"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s, TResult _)
        {
            return _n == 2 ? s(_x._2) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_public if it is of type <see cref="string"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s, global::System.Func<TResult> _)
        {
            return _n == 2 ? s(_x._2) : _();
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_public,
        /// and invoke a special delegate if Variant_public is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_public is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int> i, global::System.Action<string> s, global::System.Action _)
        {
            switch (_n)
            {
                case 0:
                    _();
                    break;
                case 1:
                    i(_x._1);
                    break;
                case 2:
                    s(_x._2);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_public");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_public,
        /// and throw an exception if Variant_public is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_public is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int> i, global::System.Action<string> s)
        {
            switch (_n)
            {
                case 0:
                    global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant_public");
                    break;
                case 1:
                    i(_x._1);
                    break;
                case 2:
                    s(_x._2);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_public");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_public and return the result,
        /// and invoke a special delegate if Variant_public is empty and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_public is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<string, TResult> s, global::System.Func<TResult> _)
        {
            switch (_n)
            {
                case 0:
                    return _();
                case 1:
                    return i(_x._1);
                case 2:
                    return s(_x._2);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_public");
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_public and return the result,
        /// and throw an exception if Variant_public is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_public is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<string, TResult> s)
        {
            switch (_n)
            {
                case 0:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant_public");
                case 1:
                    return i(_x._1);
                case 2:
                    return s(_x._2);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_public");
            }
        }
    }
}


namespace Foo
{
    public static partial class Variant_publicEx
    {
        /// <summary>
        /// Transform a Variant_public-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_public> source,
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
        /// Transform a Variant_public-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="string"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_public> source,
                global::System.Func<string, TResult> s)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 2)
                {
                    yield return s(((global::dotVariant.GeneratorSupport.Accessor_2<string>)variant).Value);
                }
            }
        }

        /// <summary>
        /// Transform a Variant_public-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_public> source,
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
        /// Transform a Variant_public-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="string"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_public> source,
                global::System.Func<string, TResult> s,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 2)
                {
                    yield return s(((global::dotVariant.GeneratorSupport.Accessor_2<string>)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_public-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_public> source,
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
        /// Transform a Variant_public-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="string"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_public> source,
                global::System.Func<string, TResult> s,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 2)
                {
                    yield return s(((global::dotVariant.GeneratorSupport.Accessor_2<string>)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant_public-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException"/>
        /// if an element is empty.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant_public.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_public> source,
                global::System.Func<int, TResult> i, global::System.Func<string, TResult> s)
        {
            foreach (var variant in source)
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant))
                {
                    case 0:
                        global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant_public");
                        yield break;
                    case 1:
                        yield return i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)variant).Value);
                        break;
                    case 2:
                        yield return s(((global::dotVariant.GeneratorSupport.Accessor_2<string>)variant).Value);
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_public");
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_public-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_public> source,
                global::System.Func<int, TResult> i, global::System.Func<string, TResult> s,
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
                        yield return s(((global::dotVariant.GeneratorSupport.Accessor_2<string>)variant).Value);
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_public");
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    public static partial class Variant_publicEx
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
                this global::System.IObservable<global::Foo.Variant_public> source,
                global::System.Func<int, TResult> i)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 1),
                _variant => i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)_variant).Value));
        }
        /// <summary>
        /// Projects each <see cref="string"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_public> source,
                global::System.Func<string, TResult> s)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 2),
                _variant => s(((global::dotVariant.GeneratorSupport.Accessor_2<string>)_variant).Value));
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
                this global::System.IObservable<global::Foo.Variant_public> source,
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
        /// Projects each <see cref="string"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_public> source,
                global::System.Func<string, TResult> s,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 2)
                {
                    return s(((global::dotVariant.GeneratorSupport.Accessor_2<string>)_variant).Value);
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
                this global::System.IObservable<global::Foo.Variant_public> source,
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
        /// Projects each <see cref="string"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_public> source,
                global::System.Func<string, TResult> s,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 2)
                {
                    return s(((global::dotVariant.GeneratorSupport.Accessor_2<string>)_variant).Value);
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
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_public> source,
                global::System.Func<int, TResult> i, global::System.Func<string, TResult> s)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant))
                {
                    case 0:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant_public");
                    case 1:
                        return i(((global::dotVariant.GeneratorSupport.Accessor_1<int>)_variant).Value);
                    case 2:
                        return s(((global::dotVariant.GeneratorSupport.Accessor_2<string>)_variant).Value);
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_public");
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to visit.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_public> source,
                global::System.Func<int, TResult> i, global::System.Func<string, TResult> s,
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
                        return s(((global::dotVariant.GeneratorSupport.Accessor_2<string>)_variant).Value);
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_public");
                }
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_public elements into one independent sub-sequences per value type,
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
        /// <param name="s">Transform an observable sequence of <see cref="string"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_public> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<TResult>> i, global::System.Func<global::System.IObservable<string>, global::System.IObservable<TResult>> s)
        {
            return VisitMany(source, (_1, _2) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(i(_1), s(_2));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_public elements into one independent sub-sequences per value type,
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
        /// <param name="s">Transform an observable sequence of <see cref="string"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="_">Transform a sequence of <see cref="global::System.Reactive.Unit"/> values (each representing an empty variant) into a sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_public> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<TResult>> i, global::System.Func<global::System.IObservable<string>, global::System.IObservable<TResult>> s,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
        {
            return VisitMany(source, (_1, _2, _0) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(i(_1), s(_2), _(_0));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_public elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_public> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<string>, global::System.IObservable<TResult>> selector)
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
        /// Splits the observable sequence of Variant_public elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_public> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<string>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> selector)
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
            : global::System.IObserver<global::Foo.Variant_public>, global::System.IDisposable
        {
            public readonly global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit> Subject0 = new global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit>();
            public readonly global::System.Reactive.Subjects.Subject<int> Subject1 = new global::System.Reactive.Subjects.Subject<int>();
            public readonly global::System.Reactive.Subjects.Subject<string> Subject2 = new global::System.Reactive.Subjects.Subject<string>();
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

            public void OnNext(global::Foo.Variant_public _variant)
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
                            OnError(global::dotVariant.GeneratorSupport.Errors.MakeEmptyError("Foo.Variant_public"));
                        }
                        break;
                    case 1:
                        Subject1.OnNext(((global::dotVariant.GeneratorSupport.Accessor_1<int>)_variant).Value);
                        break;
                    case 2:
                        Subject2.OnNext(((global::dotVariant.GeneratorSupport.Accessor_2<string>)_variant).Value);
                        break;
                    default:
                        OnError(global::dotVariant.GeneratorSupport.Errors.MakeInternalError("Foo.Variant_public"));
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
