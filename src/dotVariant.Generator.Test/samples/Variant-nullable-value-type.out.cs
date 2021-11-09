//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable disable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(_VariantTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    partial class Variant_nullable_value_type
        : global::System.IEquatable<Variant_nullable_value_type>
    {
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly global::dotVariant._G.Foo.Variant_nullable_value_type _variant;

        /// <summary>
        /// Create a Variant_nullable_value_type with a value of type <see cref="int?"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public Variant_nullable_value_type(int? i)
            => _variant = new global::dotVariant._G.Foo.Variant_nullable_value_type(i);

        /// <summary>
        /// Create a Variant_nullable_value_type with a value of type <see cref="int?"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public static implicit operator Variant_nullable_value_type(int? i)
            => new Variant_nullable_value_type(i);

        /// <summary>
        /// Create a Variant_nullable_value_type with a value of type <see cref="int?"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public static Variant_nullable_value_type Create(int? i)
            => new Variant_nullable_value_type(i);


        /// <summary>
        /// <see langword="true"/> if Variant_nullable_value_type was constructed without a value.
        /// </summary>
        public bool IsEmpty
            => _variant.IsEmpty;

        public override bool Equals(object other)
            => other is Variant_nullable_value_type v && Equals(v);

        public bool Equals(Variant_nullable_value_type other)
            => !(other is null) && _variant.Equals(other._variant);

        public static bool operator ==(Variant_nullable_value_type lhs, Variant_nullable_value_type rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        public static bool operator !=(Variant_nullable_value_type lhs, Variant_nullable_value_type rhs)
            => !(lhs == rhs);

        public override int GetHashCode()
            => _variant.GetHashCode();

        public override string ToString()
            => _variant.ValueString;

        /// <summary>
        /// Retrieve the value stored within Variant_nullable_value_type if it is of type <see cref="int?"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int?"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_nullable_value_type does not contain a value of type <see cref="int?"/></exception>
        public void Match(out int? i)
        {
            if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N == 1)
            {
                i = ((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_nullable_value_type' (expected 'int?', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant_nullable_value_type if it is of type <see cref="int?"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int?"/>.</param>
        /// <returns><see langword="true"/> if Variant_nullable_value_type contained a value of type <see cref="int?"/>.</returns>
        public bool TryMatch(out int? i)
        {
            if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N == 1)
            {
                i = ((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value;
                return true;
            }
            else
            {
                i = default;
                return false;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_nullable_value_type if it is of type <see cref="int?"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int?"/>.</param>
        /// <returns><see langword="true"/> if Variant_nullable_value_type contained a value of type <see cref="int?"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<int?> i)
        {
            if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N == 1)
            {
                i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_nullable_value_type if it is of type <see cref="int?"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int?"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_nullable_value_type does not contain a value of type <see cref="int?"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public void Match(global::System.Action<int?> i)
        {
            if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N == 1)
            {
                i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_nullable_value_type' (expected 'int?', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_nullable_value_type if it is of type <see cref="int?"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int?"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="_"> is rethrown.</exception>
        public void Match(global::System.Action<int?> i, global::System.Action _)
        {
            if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N == 1)
            {
                i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_nullable_value_type if it is of type <see cref="int?"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int?"/>.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_nullable_value_type does not contain a value of type <see cref="int?"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int?, TResult> i)
        {
            if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N == 1)
            {
                return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_nullable_value_type' (expected 'int?', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_nullable_value_type if it is of type <see cref="int?"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int?"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="other"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int?, TResult> i, TResult _)
        {
            if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N == 1)
            {
                return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
            }
            else
            {
                return _;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_nullable_value_type if it is of type <see cref="int?"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int?"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="_"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int?, TResult> i, global::System.Func<TResult> _)
        {
            if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N == 1)
            {
                return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
            }
            else
            {
                return _();
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_nullable_value_type,
        /// and throw an exception if Variant_nullable_value_type is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int?"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_nullable_value_type is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int?> i)
        {
            switch (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N)
            {
                case 0:
                    global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowEmptyError();
                    break;
                case 1:
                    i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
                    break;
                default:
                    global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowInternalError();
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_nullable_value_type,
        /// and invoke a special delegate if Variant_nullable_value_type is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int?"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_nullable_value_type is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int?> i, global::System.Action _)
        {
            switch (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N)
            {
                case 0:
                    _();
                    break;
                case 1:
                    i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
                    break;
                default:
                    global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowInternalError();
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_nullable_value_type and return the result,
        /// and throw an exception if Variant_nullable_value_type is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int?"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_nullable_value_type is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int?, TResult> i)
        {
            switch (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N)
            {
                case 0:
                    return global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowEmptyError<TResult>();
                case 1:
                    return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
                default:
                    return global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowInternalError<TResult>();
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_nullable_value_type and return the result,
        /// and invoke a special delegate if Variant_nullable_value_type is empty and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int?"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_nullable_value_type is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int?, TResult> i, global::System.Func<TResult> _)
        {
            switch (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N)
            {
                case 0:
                    return _();
                case 1:
                    return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
                default:
                    return global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowInternalError<TResult>();
            }
        }

        private sealed class _VariantTypeProxy
        {
            public object Value { get; }
            public _VariantTypeProxy(Variant_nullable_value_type v)
            {
                Value = v._variant.AsObject;
                VariantOf(default);
            }
        }

        public static explicit operator global::dotVariant._G.Foo.Variant_nullable_value_type_N(Variant_nullable_value_type v) => (global::dotVariant._G.Foo.Variant_nullable_value_type_N)v._variant;
        public static explicit operator global::dotVariant._G.Foo.Variant_nullable_value_type_1(Variant_nullable_value_type v) => (global::dotVariant._G.Foo.Variant_nullable_value_type_1)v._variant;
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_nullable_value_type
    {
        private readonly Variant_nullable_value_type_Union _x;
        private readonly uint _n;

        public Variant_nullable_value_type(int? i)
        {
            _n = 1;
            _x = new Variant_nullable_value_type_Union(i);
        }


        public static explicit operator Variant_nullable_value_type_N(Variant_nullable_value_type v) => new Variant_nullable_value_type_N(v._n);
        public static explicit operator Variant_nullable_value_type_1(Variant_nullable_value_type v) => v._x._1;

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        [global::System.Diagnostics.CodeAnalysis.DoesNotReturn]
        public static void ThrowEmptyError()
        {
            throw MakeEmptyError();
        }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        [global::System.Diagnostics.CodeAnalysis.DoesNotReturn]
        public static T ThrowEmptyError<T>()
        {
            throw MakeEmptyError();
        }

        public static global::System.Exception MakeEmptyError()
        {
            return new global::System.InvalidOperationException("Variant_nullable_value_type is empty.");
        }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        [global::System.Diagnostics.CodeAnalysis.DoesNotReturn]
        public static void ThrowInternalError()
        {
            throw MakeInternalError();
        }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        [global::System.Diagnostics.CodeAnalysis.DoesNotReturn]
        public static T ThrowInternalError<T>()
        {
            throw MakeInternalError();
        }

        public static global::System.Exception MakeInternalError()
        {
            return new global::System.InvalidOperationException("Variant_nullable_value_type has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
        }

        public bool IsEmpty => _n == 0;

        public string TypeString
        {
            get
            {
                switch (_n)
                {
                    case 0:
                        return "<empty>";
                    case 1:
                        return "int?";
                    default:
                        return ThrowInternalError<string>();
                }
            }
        }

        public string ValueString
        {
            get
            {
                switch (_n)
                {
                    case 0:
                        return "";
                    case 1:
                        return _x._1.Value?.ToString() ?? "null";
                    default:
                        return ThrowInternalError<string>();
                }
            }
        }

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
                    default:
                        return ThrowInternalError<object>();
                }
            }
        }

        public bool Equals(in Variant_nullable_value_type other)
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
                    return global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(_x._1.Value, other._x._1.Value);
                default:
                    return ThrowInternalError<bool>();
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                switch (_n)
                {
                    case 0:
                        return 0;
                    case 1:
                        return global::System.HashCode.Combine(_x._1.Value);
                    default:
                        return ThrowInternalError<int>();
                }
            }
        }

        public bool TryMatch(out int? i)
        {
            i = _n == 1 ? _x._1.Value : default;
            return _n == 1;
        }

        public void Visit(global::System.Action<int?> i, global::System.Action _)
        {
            switch (_n)
            {
                case 0:
                    _();
                    break;
                case 1:
                    i(_x._1.Value);
                    break;
                default:
                    ThrowInternalError();
                    break;
            }
        }

        public void Visit(global::System.Action<int?> i)
        {
            switch (_n)
            {
                case 0:
                    ThrowEmptyError();
                    break;
                case 1:
                    i(_x._1.Value);
                    break;
                default:
                    ThrowInternalError();
                    break;
            }
        }

        public TResult Visit<TResult>(global::System.Func<int?, TResult> i, global::System.Func<TResult> _)
        {
            switch (_n)
            {
                case 0:
                    return _();
                case 1:
                    return i(_x._1.Value);
                default:
                    return ThrowInternalError<TResult>();
            }
        }

        public TResult Visit<TResult>(global::System.Func<int?, TResult> i)
        {
            switch (_n)
            {
                case 0:
                    return ThrowEmptyError<TResult>();
                case 1:
                    return i(_x._1.Value);
                default:
                    return ThrowInternalError<TResult>();
            }
        }
    }

    public readonly ref struct Variant_nullable_value_type_N
    {
        public readonly uint N;
        public Variant_nullable_value_type_N(uint n) => N = n;
    }

    [global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit)]
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_nullable_value_type_Union
    {
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public readonly Variant_nullable_value_type_1 _1;

        public Variant_nullable_value_type_Union(int? value)
        {
            _1 = new Variant_nullable_value_type_1(value);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    public readonly struct Variant_nullable_value_type_1
    {
        public readonly int? Value;

        public Variant_nullable_value_type_1(int? value)
        {
            Value = value;
        }
    }
}


namespace Foo
{
    public static partial class _Variant_nullable_value_type_Ex
    {
        /// <summary>
        /// Transform a Variant_nullable_value_type-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int?"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<int?, TResult> i)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)variant).N == 1)
                {
                    yield return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)variant).Value);
                }
            }
        }

        /// <summary>
        /// Transform a Variant_nullable_value_type-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int?"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<int?, TResult> i,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)variant).N == 1)
                {
                    yield return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_nullable_value_type-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int?"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<int?, TResult> i,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)variant).N == 1)
                {
                    yield return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant_nullable_value_type-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException">
        /// if an element is empty.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int?"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant_nullable_value_type.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<int?, TResult> i)
        {
            foreach (var variant in source)
            {
                switch (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)variant).N)
                {
                    case 0:
                        global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowEmptyError();
                        yield break;
                    case 1:
                        yield return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)variant).Value);
                        break;
                    default:
                        global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowInternalError();
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_nullable_value_type-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int?"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<int?, TResult> i,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                switch (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)variant).N)
                {
                    case 0:
                        yield return _();
                        break;
                    case 1:
                        yield return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)variant).Value);
                        break;
                    default:
                        global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowInternalError();
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    public static partial class _Variant_nullable_value_type_Ex
    {
        /// <summary>
        /// Projects each <see cref="int?"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<int?, TResult> i)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N == 1),
                _variant => i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value));
        }

        /// <summary>
        /// Projects each <see cref="int?"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<int?, TResult> i,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N == 1)
                {
                    return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
                }
                else
                {
                    return _;
                }
            });
        }

        /// <summary>
        /// Projects each <see cref="int?"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<int?, TResult> i,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N == 1)
                {
                    return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
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
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int?"/>.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<int?, TResult> i)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N)
                {
                    case 0:
                        return global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowEmptyError<TResult>();
                    case 1:
                        return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
                    default:
                        return global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowInternalError<TResult>();
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to visit.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int?"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<int?, TResult> i,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N)
                {
                    case 0:
                        return _();
                    case 1:
                        return i(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
                    default:
                        return global::dotVariant._G.Foo.Variant_nullable_value_type.ThrowInternalError<TResult>();
                }
            });
        }


        /// <summary>
        /// Splits the observable sequence of Variant_nullable_value_type elements into one independent sub-sequences per value type,
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
        /// <param name="i">Transform an observable sequence of <see cref="int?"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="_">Transform a sequence of <see cref="global::System.Reactive.Unit"/> values (each representing an empty variant) into a sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<global::System.IObservable<int?>, global::System.IObservable<TResult>> i,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
        {
            return VisitMany(source, (_1, _0) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(i(_1), _(_0));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_nullable_value_type elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<global::System.IObservable<int?>, global::System.IObservable<TResult>> selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(false);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(source, _mo),
                    _mo);
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_nullable_value_type elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_nullable_value_type> source,
                global::System.Func<global::System.IObservable<int?>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(true);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject0).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(source, _mo),
                    _mo);
            });
        }

        private sealed class VisitManyObserver : global::System.IObserver<global::Foo.Variant_nullable_value_type>, global::System.IDisposable
        {
            public readonly global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit> Subject0 = new global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit>();
            public readonly global::System.Reactive.Subjects.Subject<int?> Subject1 = new global::System.Reactive.Subjects.Subject<int?>();
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

            public void OnNext(global::Foo.Variant_nullable_value_type _variant)
            {
                switch (((global::dotVariant._G.Foo.Variant_nullable_value_type_N)_variant).N)
                {
                    case 0:
                        if (_accept0)
                        {
                            Subject0.OnNext(global::System.Reactive.Unit.Default);
                        }
                        else
                        {
                            OnError(global::dotVariant._G.Foo.Variant_nullable_value_type.MakeEmptyError());
                        }
                        break;
                    case 1:
                        Subject1.OnNext(((global::dotVariant._G.Foo.Variant_nullable_value_type_1)_variant).Value);
                        break;
                    default:
                        OnError(global::dotVariant._G.Foo.Variant_nullable_value_type.MakeInternalError());
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
