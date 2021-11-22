//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable enable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(Variant<>.__DebuggerTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    partial class Variant<T>
        : global::System.IEquatable<Variant<T>>
    {
        private readonly global::dotVariant._G.Foo.Variant<T> _variant;

        /// <summary>
        /// Create a Variant with a value of type <see cref="T"/>.
        /// </summary>
        /// <param name="value">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant(T value)
            => _variant = new global::dotVariant._G.Foo.Variant<T>(value);

        /// <summary>
        /// Create a Variant with a value of type <see cref="T"/>.
        /// </summary>
        /// <param name="value">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant<T>(T value)
            => new Variant<T>(value);

        /// <summary>
        /// Create a Variant with a value of type <see cref="T"/>.
        /// </summary>
        /// <param name="value">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant<T> Create(T value)
            => new Variant<T>(value);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.IsEmpty"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool IsEmpty
            => _variant.IsEmpty;

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object? other)
            => other is Variant<T> v
            && Equals(v);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(Variant<T>? other)
            => !(other is null) && _variant.Equals(other._variant);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator ==(Variant<T>? lhs, Variant<T>? rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator !=(Variant<T>? lhs, Variant<T>? rhs)
            => !(lhs == rhs);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override int GetHashCode()
            => _variant.GetHashCode();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override string ToString()
            => _variant.ToString();

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.TryMatch(out T?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(out T? value)
            => _variant.TryMatch(out value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.TryMatch(global::System.Action{T})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<T> value)
            => _variant.TryMatch(value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match(out T?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(out T? value)
            => _variant.Match(out value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match(global::System.Action{T})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T> value)
            => _variant.Match(value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match(global::System.Action{T}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T> value, global::System.Action _)
            => _variant.Match(value, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match{TResult}(global::System.Func{T, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T, TResult> value)
            => _variant.Match(value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match{TResult}(global::System.Func{T, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T, TResult> value, TResult _)
            => _variant.Match(value, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Match{TResult}(global::System.Func{T, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T, TResult> value, global::System.Func<TResult> _)
            => _variant.Match(value, _);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Visit(global::System.Action{T})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<T> value)
            => _variant.Visit(value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Visit(global::System.Action{T}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<T> value, global::System.Action _)
            => _variant.Visit(value, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Visit{TResult}(global::System.Func{T, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<T, TResult> value)
            => _variant.Visit(value);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T}.Visit{TResult}(global::System.Func{T, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<T, TResult> value, global::System.Func<TResult> _)
            => _variant.Visit(value, _);

        private sealed class __DebuggerTypeProxy
        {
            public object? Value { get; }
            public __DebuggerTypeProxy(Variant<T> v)
            {
                Value = v._variant.AsObject;
                #pragma warning disable 8604 // Possible null reference argument for parameter
                #pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type
                VariantOf(default);
                #pragma warning restore 8604, 8625
            }
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static explicit operator global::dotVariant.GeneratorSupport.Discriminator(Variant<T> v)
            => (global::dotVariant.GeneratorSupport.Discriminator)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_1<T>(Variant<T> v)
            => (global::dotVariant.GeneratorSupport.Accessor_1<T>)v._variant;
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    [global::System.Diagnostics.DebuggerDisplay("{AsObject}", Type = "{TypeString,nq}")]
    internal readonly struct Variant<T>
    {
        private readonly struct Union
        {
            public readonly T _1;
            public Union(T value)
            {
                _1 = value;
            }
        }

        private readonly Union _x;
        private readonly byte _n;

        public Variant(T value)
        {
            _n = 1;
            _x = new Union(value);
        }


        public static explicit operator global::dotVariant.GeneratorSupport.Discriminator(in Variant<T> v)
            => (global::dotVariant.GeneratorSupport.Discriminator)v._n;
        public static explicit operator global::dotVariant.GeneratorSupport.Accessor_1<T>(in Variant<T> v)
            => new global::dotVariant.GeneratorSupport.Accessor_1<T>(v._x._1);

        /// <summary>
        /// <see langword="true"/> if Variant was constructed without a value.
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
                        return "T";
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant<T>");
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
                    return _x._1?.ToString() ?? "null";
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant<T>");
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
                        return _x._1;
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<object?>("Foo.Variant<T>");
                }
            }
        }

        public bool Equals(in Variant<T> other)
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
                    return global::System.Collections.Generic.EqualityComparer<T>.Default.Equals(_x._1, other._x._1);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<bool>("Foo.Variant<T>");
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
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<int>("Foo.Variant<T>");
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T"/>.
        /// </summary>
        /// <param name="value">Receives the stored value if it is of type <see cref="T"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T"/>.</returns>
        public bool TryMatch(out T? value)
        {
            value = _n == 1 ? _x._1 : default;
            return _n == 1;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/>.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<T> value)
        {
            if (_n == 1)
            {
                value(_x._1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value">Receives the stored value if it is of type <see cref="T"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T"/>.</exception>
        public void Match(out T? value)
        {
            if (_n == 1)
            {
                value = _x._1;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant<T>", "T", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"/> is rethrown.</exception>
        public void Match(global::System.Action<T> value)
        {
            if (_n == 1)
            {
                value(_x._1);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant<T>", "T", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<T> value, global::System.Action _)
        {
            if (_n == 1)
            {
                value(_x._1);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <returns>The value returned from invoking <paramref name="value"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T, TResult> value)
        {
            if (_n == 1)
            {
                return value(_x._1);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant<T>", "T", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="value"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T, TResult> value, TResult _)
        {
            return _n == 1 ? value(_x._1) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="value">The delegate to invoke with the stored value if it is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="value"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T, TResult> value, global::System.Func<TResult> _)
        {
            return _n == 1 ? value(_x._1) : _();
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant,
        /// and invoke a special delegate if Variant is empty.
        /// </summary>
        /// <param name="value">The delegate to invoke if the stored value is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if Variant is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<T> value, global::System.Action _)
        {
            switch (_n)
            {
                case 0:
                    _();
                    break;
                case 1:
                    value(_x._1);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T>");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant,
        /// and throw an exception if Variant is empty.
        /// </summary>
        /// <param name="value">The delegate to invoke if the stored value is of type <see cref="T"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<T> value)
        {
            switch (_n)
            {
                case 0:
                    global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant<T>");
                    break;
                case 1:
                    value(_x._1);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T>");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant and return the result,
        /// and invoke a special delegate if Variant is empty and return its result.
        /// </summary>
        /// <param name="value">The delegate to invoke if the stored value is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if Variant is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<T, TResult> value, global::System.Func<TResult> _)
        {
            switch (_n)
            {
                case 0:
                    return _();
                case 1:
                    return value(_x._1);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T>");
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant and return the result,
        /// and throw an exception if Variant is empty.
        /// </summary>
        /// <param name="value">The delegate to invoke if the stored value is of type <see cref="T"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<T, TResult> value)
        {
            switch (_n)
            {
                case 0:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant<T>");
                case 1:
                    return value(_x._1);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T>");
            }
        }
    }
}


namespace Foo
{
    public static partial class _Variant_Ex
    {
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T>> source,
                global::System.Func<T, TResult> value)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 1)
                {
                    yield return value(((global::dotVariant.GeneratorSupport.Accessor_1<T>)variant).Value);
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T>> source,
                global::System.Func<T, TResult> value,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 1)
                {
                    yield return value(((global::dotVariant.GeneratorSupport.Accessor_1<T>)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T>> source,
                global::System.Func<T, TResult> value,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant) == 1)
                {
                    yield return value(((global::dotVariant.GeneratorSupport.Accessor_1<T>)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException"/>
        /// if an element is empty.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value">The delegate to invoke if the element's value is of type <see cref="T"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult, T>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T>> source,
                global::System.Func<T, TResult> value)
        {
            foreach (var variant in source)
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)variant))
                {
                    case 0:
                        global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant<T>");
                        yield break;
                    case 1:
                        yield return value(((global::dotVariant.GeneratorSupport.Accessor_1<T>)variant).Value);
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T>");
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="value">The delegate to invoke if the element's value is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult, T>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T>> source,
                global::System.Func<T, TResult> value,
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
                        yield return value(((global::dotVariant.GeneratorSupport.Accessor_1<T>)variant).Value);
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T>");
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    public static partial class _Variant_Ex
    {
        /// <summary>
        /// Projects each <see cref="T"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> source,
                global::System.Func<T, TResult> value)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 1),
                _variant => value(((global::dotVariant.GeneratorSupport.Accessor_1<T>)_variant).Value));
        }

        /// <summary>
        /// Projects each <see cref="T"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> source,
                global::System.Func<T, TResult> value,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 1)
                {
                    return value(((global::dotVariant.GeneratorSupport.Accessor_1<T>)_variant).Value);
                }
                else
                {
                    return _;
                }
            });
        }

        /// <summary>
        /// Projects each <see cref="T"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="value">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> source,
                global::System.Func<T, TResult> value,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant) == 1)
                {
                    return value(((global::dotVariant.GeneratorSupport.Accessor_1<T>)_variant).Value);
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
        /// <param name="value">The delegate to invoke if the element's value is of type <see cref="T"/>.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> source,
                global::System.Func<T, TResult> value)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant))
                {
                    case 0:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant<T>");
                    case 1:
                        return value(((global::dotVariant.GeneratorSupport.Accessor_1<T>)_variant).Value);
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T>");
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to visit.</param>
        /// <param name="value">The delegate to invoke if the element's value is of type <see cref="T"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> source,
                global::System.Func<T, TResult> value,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (((int)(global::dotVariant.GeneratorSupport.Discriminator)_variant))
                {
                    case 0:
                        return _();
                    case 1:
                        return value(((global::dotVariant.GeneratorSupport.Accessor_1<T>)_variant).Value);
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T>");
                }
            });
        }


        /// <summary>
        /// Splits the observable sequence of Variant elements into one independent sub-sequences per value type,
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
        /// <param name="value">Transform an observable sequence of <see cref="T"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="_">Transform a sequence of <see cref="global::System.Reactive.Unit"/> values (each representing an empty variant) into a sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> source,
                global::System.Func<global::System.IObservable<T>, global::System.IObservable<TResult>> value,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
        {
            return VisitMany(source, (_1, _0) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(value(_1), _(_0));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant elements into one independent sub-sequences per value type,
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
            VisitMany<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> source,
                global::System.Func<global::System.IObservable<T>, global::System.IObservable<TResult>> selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver<T>(false);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(source, _mo),
                    _mo);
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant elements into one independent sub-sequences per value type,
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
            VisitMany<TResult, T>(
                this global::System.IObservable<global::Foo.Variant<T>> source,
                global::System.Func<global::System.IObservable<T>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver<T>(true);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject0).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(source, _mo),
                    _mo);
            });
        }

        private sealed class VisitManyObserver<T>
            : global::System.IObserver<global::Foo.Variant<T>>, global::System.IDisposable
        {
            public readonly global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit> Subject0 = new global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit>();
            public readonly global::System.Reactive.Subjects.Subject<T> Subject1 = new global::System.Reactive.Subjects.Subject<T>();
            private readonly bool _accept0;

            public VisitManyObserver(bool _accept0)
            {
                this._accept0 = _accept0;
            }

            public void Dispose()
            {
                Subject1.Dispose();
                Subject0.Dispose();
            }

            public void OnNext(global::Foo.Variant<T> _variant)
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
                            OnError(global::dotVariant.GeneratorSupport.Errors.MakeEmptyError("Foo.Variant<T>"));
                        }
                        break;
                    case 1:
                        Subject1.OnNext(((global::dotVariant.GeneratorSupport.Accessor_1<T>)_variant).Value);
                        break;
                    default:
                        OnError(global::dotVariant.GeneratorSupport.Errors.MakeInternalError("Foo.Variant<T>"));
                        break;
                }
            }

            public void OnError(global::System.Exception _ex)
            {
                Subject1.OnError(_ex);
                if (_accept0)
                {
                    Subject0.OnError(_ex);
                }
            }

            public void OnCompleted()
            {
                Subject1.OnCompleted();
                if (_accept0)
                {
                    Subject0.OnCompleted();
                }
            }
        }

    }
}
