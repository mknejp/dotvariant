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
    partial class Variant_disposable
        : global::System.IEquatable<Variant_disposable>
        , global::System.IDisposable
    {
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly global::dotVariant._G.Foo.Variant_disposable _variant;

        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public Variant_disposable(int i)
            => _variant = new global::dotVariant._G.Foo.Variant_disposable(i);
        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The value to initlaize the variant with.</param>
        public Variant_disposable(global::System.IO.Stream stream)
            => _variant = new global::dotVariant._G.Foo.Variant_disposable(stream);

        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public static implicit operator Variant_disposable(int i)
            => new Variant_disposable(i);
        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The value to initlaize the variant with.</param>
        public static implicit operator Variant_disposable(global::System.IO.Stream stream)
            => new Variant_disposable(stream);

        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public static Variant_disposable Create(int i)
            => new Variant_disposable(i);
        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The value to initlaize the variant with.</param>
        public static Variant_disposable Create(global::System.IO.Stream stream)
            => new Variant_disposable(stream);


        /// <inheritdoc/>
        public void Dispose()
        {
            _variant.Dispose();
        }

        /// <summary>
        /// <see langword="true"/> if Variant_disposable was constructed without a value.
        /// </summary>
        public bool IsEmpty
            => _variant.IsEmpty;

        public override bool Equals(object other)
            => other is Variant_disposable v && Equals(v);

        public bool Equals(Variant_disposable other)
            => !(other is null) && _variant.Equals(other._variant);

        public static bool operator ==(Variant_disposable lhs, Variant_disposable rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        public static bool operator !=(Variant_disposable lhs, Variant_disposable rhs)
            => !(lhs == rhs);

        public override int GetHashCode()
            => _variant.GetHashCode();

        public override string ToString()
            => _variant.ValueString;

        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="int"/></exception>
        public void Match(out int i)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 1)
            {
                i = ((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_disposable' (expected 'int', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="stream">Receives the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="global::System.IO.Stream"/></exception>
        public void Match(out global::System.IO.Stream stream)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 2)
            {
                stream = ((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_disposable' (expected 'System.IO.Stream', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="int"/>.</returns>
        public bool TryMatch(out int i)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 1)
            {
                i = ((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value;
                return true;
            }
            else
            {
                i = default;
                return false;
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">Receives the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="global::System.IO.Stream"/>.</returns>
        public bool TryMatch(out global::System.IO.Stream stream)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 2)
            {
                stream = ((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value;
                return true;
            }
            else
            {
                stream = default;
                return false;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="int"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<int> i)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 1)
            {
                i(((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="global::System.IO.Stream"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<global::System.IO.Stream> stream)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 2)
            {
                stream(((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="int"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public void Match(global::System.Action<int> i)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 1)
            {
                i(((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_disposable' (expected 'int', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="global::System.IO.Stream"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"> is rethrown.</exception>
        public void Match(global::System.Action<global::System.IO.Stream> stream)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 2)
            {
                stream(((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_disposable' (expected 'System.IO.Stream', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="_"> is rethrown.</exception>
        public void Match(global::System.Action<int> i, global::System.Action _)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 1)
            {
                i(((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"> or <paramref name="_"> is rethrown.</exception>
        public void Match(global::System.Action<global::System.IO.Stream> stream, global::System.Action _)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 2)
            {
                stream(((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value);
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
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="int"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 1)
            {
                return i(((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_disposable' (expected 'int', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns>The value returned from invoking <paramref name="stream"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="global::System.IO.Stream"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 2)
            {
                return stream(((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_disposable' (expected 'System.IO.Stream', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="other"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 1)
            {
                return i(((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value);
            }
            else
            {
                return _;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="stream"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"> or <paramref name="other"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream, TResult _)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 2)
            {
                return stream(((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value);
            }
            else
            {
                return _;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="_"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<TResult> _)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 1)
            {
                return i(((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value);
            }
            else
            {
                return _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"> or <paramref name="_"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream, global::System.Func<TResult> _)
        {
            if (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N == 2)
            {
                return stream(((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value);
            }
            else
            {
                return _();
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
            switch (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N)
            {
                case 0:
                    throw new global::System.InvalidOperationException("Variant_disposable is empty.");
                case 1:
                    i(((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value);
                    break;
                case 2:
                    stream(((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value);
                    break;
                default:
                    throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
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
            switch (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N)
            {
                case 0:
                    _();
                    break;
                case 1:
                    i(((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value);
                    break;
                case 2:
                    stream(((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value);
                    break;
                default:
                    throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
            switch (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N)
            {
                case 0:
                    throw new global::System.InvalidOperationException("Variant_disposable is empty.");
                case 1:
                    return i(((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value);
                case 2:
                    return stream(((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value);
                default:
                    throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
            switch (((global::dotVariant._G.Foo.Variant_disposable_N)_variant).N)
            {
                case 0:
                    return _();
                case 1:
                    return i(((global::dotVariant._G.Foo.Variant_disposable_1)_variant).Value);
                case 2:
                    return stream(((global::dotVariant._G.Foo.Variant_disposable_2)_variant).Value);
                default:
                    throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

        private sealed class _VariantTypeProxy
        {
            public object Value { get; }
            public _VariantTypeProxy(Variant_disposable v)
            {
                Value = v._variant.AsObject;
                VariantOf(default, default);
            }
        }

        public static explicit operator global::dotVariant._G.Foo.Variant_disposable_N(Variant_disposable v) => (global::dotVariant._G.Foo.Variant_disposable_N)v._variant;
        public static explicit operator global::dotVariant._G.Foo.Variant_disposable_1(Variant_disposable v) => (global::dotVariant._G.Foo.Variant_disposable_1)v._variant;
        public static explicit operator global::dotVariant._G.Foo.Variant_disposable_2(Variant_disposable v) => (global::dotVariant._G.Foo.Variant_disposable_2)v._variant;
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_disposable
        : global::System.IDisposable
    {
        private readonly Variant_disposable_Union _x;
        private readonly uint _n;

        public Variant_disposable(int i)
        {
            _n = 1;
            _x = new Variant_disposable_Union(i);
        }
        public Variant_disposable(global::System.IO.Stream stream)
        {
            _n = 2;
            _x = new Variant_disposable_Union(stream);
        }

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
                    throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

        public static explicit operator Variant_disposable_N(Variant_disposable v) => new Variant_disposable_N(v._n);
        public static explicit operator Variant_disposable_1(Variant_disposable v) => v._x._1;
        public static explicit operator Variant_disposable_2(Variant_disposable v) => v._x._2;

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
                        return "int";
                    case 2:
                        return "System.IO.Stream";
                    default:
                        throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
                        return _x._1.Value.ToString();
                    case 2:
                        return _x._2.Value?.ToString() ?? "null";
                    default:
                        throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
                    case 2:
                        return _x._2.Value;
                    default:
                        throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
                    throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
                    case 2:
                        return global::System.HashCode.Combine(_x._2.Value);
                    default:
                        throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
                }
            }
        }

        public bool TryMatch(out int i)
        {
            i = _n == 1 ? _x._1.Value : default;
            return _n == 1;
        }
        public bool TryMatch(out global::System.IO.Stream stream)
        {
            stream = _n == 2 ? _x._2.Value : default;
            return _n == 2;
        }

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
                    throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

        public void Visit(global::System.Action<int> i, global::System.Action<global::System.IO.Stream> stream)
        {
            switch (_n)
            {
                case 0:
                    throw new global::System.InvalidOperationException("Variant_disposable is empty.");
                case 1:
                    i(_x._1.Value);
                    break;
                case 2:
                    stream(_x._2.Value);
                    break;
                default:
                    throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

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
                    throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            switch (_n)
            {
                case 0:
                    throw new global::System.InvalidOperationException("Variant_disposable is empty.");
                case 1:
                    return i(_x._1.Value);
                case 2:
                    return stream(_x._2.Value);
                default:
                    throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }
    }

    internal readonly ref struct Variant_disposable_N
    {
        public readonly uint N;
        public Variant_disposable_N(uint n) => N = n;
    }

    [global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit)]
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_disposable_Union
    {
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public readonly Variant_disposable_1 _1;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public readonly Variant_disposable_2 _2;

        public Variant_disposable_Union(int value)
        {
            _2 = default;
            _1 = new Variant_disposable_1(value);
        }
        public Variant_disposable_Union(global::System.IO.Stream value)
        {
            _1 = default;
            _2 = new Variant_disposable_2(value);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_disposable_1
    {
        public readonly int Value;
        public readonly object _dummy1;

        public Variant_disposable_1(int value)
        {
            _dummy1 = null;
            Value = value;
        }
    }
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_disposable_2
    {
        public readonly global::System.IO.Stream Value;

        public Variant_disposable_2(global::System.IO.Stream value)
        {
            Value = value;
        }
    }
}


namespace Foo
{
    public static partial class _Variant_disposable_Ex
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
                if (((global::dotVariant._G.Foo.Variant_disposable_N)variant).N == 1)
                {
                    yield return i(((global::dotVariant._G.Foo.Variant_disposable_1)variant).Value);
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
                if (((global::dotVariant._G.Foo.Variant_disposable_N)variant).N == 2)
                {
                    yield return stream(((global::dotVariant._G.Foo.Variant_disposable_2)variant).Value);
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
                if (((global::dotVariant._G.Foo.Variant_disposable_N)variant).N == 1)
                {
                    yield return i(((global::dotVariant._G.Foo.Variant_disposable_1)variant).Value);
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
                if (((global::dotVariant._G.Foo.Variant_disposable_N)variant).N == 2)
                {
                    yield return stream(((global::dotVariant._G.Foo.Variant_disposable_2)variant).Value);
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
                if (((global::dotVariant._G.Foo.Variant_disposable_N)variant).N == 1)
                {
                    yield return i(((global::dotVariant._G.Foo.Variant_disposable_1)variant).Value);
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
                if (((global::dotVariant._G.Foo.Variant_disposable_N)variant).N == 2)
                {
                    yield return stream(((global::dotVariant._G.Foo.Variant_disposable_2)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException">
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
                switch (((global::dotVariant._G.Foo.Variant_disposable_N)variant).N)
                {
                    case 0:
                        throw new global::System.InvalidOperationException("Variant_disposable is empty.");
                    case 1:
                        yield return i(((global::dotVariant._G.Foo.Variant_disposable_1)variant).Value);
                        break;
                    case 2:
                        yield return stream(((global::dotVariant._G.Foo.Variant_disposable_2)variant).Value);
                        break;
                    default:
                        throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
                switch (((global::dotVariant._G.Foo.Variant_disposable_N)variant).N)
                {
                    case 0:
                        yield return _();
                        break;
                    case 1:
                        yield return i(((global::dotVariant._G.Foo.Variant_disposable_1)variant).Value);
                        break;
                    case 2:
                        yield return stream(((global::dotVariant._G.Foo.Variant_disposable_2)variant).Value);
                        break;
                    default:
                        throw new global::System.InvalidOperationException("Variant_disposable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
                }
            }
        }
    }
}
