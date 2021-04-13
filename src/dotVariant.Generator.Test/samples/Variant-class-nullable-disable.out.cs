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
    partial class Variant_class_nullable_disable
        : global::System.IEquatable<Variant_class_nullable_disable>
    {
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly global::dotVariant._G.Foo.Variant_class_nullable_disable _variant;

        /// <summary>
        /// Create a Variant_class_nullable_disable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public Variant_class_nullable_disable(int i)
            => _variant = new global::dotVariant._G.Foo.Variant_class_nullable_disable(i);
        /// <summary>
        /// Create a Variant_class_nullable_disable with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        public Variant_class_nullable_disable(float f)
            => _variant = new global::dotVariant._G.Foo.Variant_class_nullable_disable(f);
        /// <summary>
        /// Create a Variant_class_nullable_disable with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        public Variant_class_nullable_disable(string s)
            => _variant = new global::dotVariant._G.Foo.Variant_class_nullable_disable(s);

        /// <summary>
        /// Create a Variant_class_nullable_disable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public static implicit operator Variant_class_nullable_disable(int i)
            => new Variant_class_nullable_disable(i);
        /// <summary>
        /// Create a Variant_class_nullable_disable with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        public static implicit operator Variant_class_nullable_disable(float f)
            => new Variant_class_nullable_disable(f);
        /// <summary>
        /// Create a Variant_class_nullable_disable with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        public static implicit operator Variant_class_nullable_disable(string s)
            => new Variant_class_nullable_disable(s);

        /// <summary>
        /// Create a Variant_class_nullable_disable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public static Variant_class_nullable_disable Create(int i)
            => new Variant_class_nullable_disable(i);
        /// <summary>
        /// Create a Variant_class_nullable_disable with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        public static Variant_class_nullable_disable Create(float f)
            => new Variant_class_nullable_disable(f);
        /// <summary>
        /// Create a Variant_class_nullable_disable with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        public static Variant_class_nullable_disable Create(string s)
            => new Variant_class_nullable_disable(s);


        /// <summary>
        /// <see langword="true"/> if Variant_class_nullable_disable was constructed without a value.
        /// </summary>
        public bool IsEmpty
            => _variant.IsEmpty;

        public override bool Equals(object other)
            => other is Variant_class_nullable_disable v && Equals(v);

        public bool Equals(Variant_class_nullable_disable other)
            => !(other is null) && _variant.Equals(other._variant);

        public static bool operator ==(Variant_class_nullable_disable lhs, Variant_class_nullable_disable rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        public static bool operator !=(Variant_class_nullable_disable lhs, Variant_class_nullable_disable rhs)
            => !(lhs == rhs);

        public override int GetHashCode()
            => _variant.GetHashCode();

        public override string ToString()
            => _variant.ValueString;

        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_disable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_disable does not contain a value of type <see cref="int"/></exception>
        public void Match(out int i)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 1)
            {
                i = ((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_disable' (expected 'int', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_disable if it is of type <see cref="float"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="f">Receives the stored value if it is of type <see cref="float"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_disable does not contain a value of type <see cref="float"/></exception>
        public void Match(out float f)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 2)
            {
                f = ((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_disable' (expected 'float', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_disable if it is of type <see cref="string"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">Receives the stored value if it is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_disable does not contain a value of type <see cref="string"/></exception>
        public void Match(out string s)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 3)
            {
                s = ((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_disable' (expected 'string', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_disable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_disable contained a value of type <see cref="int"/>.</returns>
        public bool TryMatch(out int i)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 1)
            {
                i = ((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value;
                return true;
            }
            else
            {
                i = default;
                return false;
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_disable if it is of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">Receives the stored value if it is of type <see cref="float"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_disable contained a value of type <see cref="float"/>.</returns>
        public bool TryMatch(out float f)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 2)
            {
                f = ((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value;
                return true;
            }
            else
            {
                f = default;
                return false;
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_disable if it is of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">Receives the stored value if it is of type <see cref="string"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_disable contained a value of type <see cref="string"/>.</returns>
        public bool TryMatch(out string s)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 3)
            {
                s = ((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value;
                return true;
            }
            else
            {
                s = default;
                return false;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_disable contained a value of type <see cref="int"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<int> i)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 1)
            {
                i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_disable contained a value of type <see cref="float"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<float> f)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 2)
            {
                f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_disable contained a value of type <see cref="string"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<string> s)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 3)
            {
                s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_disable does not contain a value of type <see cref="int"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public void Match(global::System.Action<int> i)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 1)
            {
                i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_disable' (expected 'int', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="float"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_disable does not contain a value of type <see cref="float"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> is rethrown.</exception>
        public void Match(global::System.Action<float> f)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 2)
            {
                f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_disable' (expected 'float', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="string"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_disable does not contain a value of type <see cref="string"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> is rethrown.</exception>
        public void Match(global::System.Action<string> s)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 3)
            {
                s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_disable' (expected 'string', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="int"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="_"> is rethrown.</exception>
        public void Match(global::System.Action<int> i, global::System.Action _)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 1)
            {
                i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="float"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> or <paramref name="_"> is rethrown.</exception>
        public void Match(global::System.Action<float> f, global::System.Action _)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 2)
            {
                f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="string"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> or <paramref name="_"> is rethrown.</exception>
        public void Match(global::System.Action<string> s, global::System.Action _)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 3)
            {
                s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="int"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_disable does not contain a value of type <see cref="int"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 1)
            {
                return i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_disable' (expected 'int', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="float"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <returns>The value returned from invoking <paramref name="f"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_disable does not contain a value of type <see cref="float"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<float, TResult> f)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 2)
            {
                return f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_disable' (expected 'float', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="string"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <returns>The value returned from invoking <paramref name="s"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_disable does not contain a value of type <see cref="string"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 3)
            {
                return s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_disable' (expected 'string', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="int"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="other"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 1)
            {
                return i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value);
            }
            else
            {
                return _;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="float"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="f"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> or <paramref name="other"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<float, TResult> f, TResult _)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 2)
            {
                return f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value);
            }
            else
            {
                return _;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="string"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="s"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> or <paramref name="other"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s, TResult _)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 3)
            {
                return s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value);
            }
            else
            {
                return _;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="int"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="_"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<TResult> _)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 1)
            {
                return i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value);
            }
            else
            {
                return _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="float"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> or <paramref name="_"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<float, TResult> f, global::System.Func<TResult> _)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 2)
            {
                return f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value);
            }
            else
            {
                return _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_disable if it is of type <see cref="string"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> or <paramref name="_"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s, global::System.Func<TResult> _)
        {
            if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N == 3)
            {
                return s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value);
            }
            else
            {
                return _();
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_class_nullable_disable,
        /// and throw an exception if Variant_class_nullable_disable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_disable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s)
        {
            switch (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N)
            {
                case 0:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable is empty.");
                case 1:
                    i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value);
                    break;
                case 2:
                    f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value);
                    break;
                case 3:
                    s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value);
                    break;
                default:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_class_nullable_disable,
        /// and invoke a special delegate if Variant_class_nullable_disable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_class_nullable_disable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action _)
        {
            switch (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N)
            {
                case 0:
                    _();
                    break;
                case 1:
                    i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value);
                    break;
                case 2:
                    f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value);
                    break;
                case 3:
                    s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value);
                    break;
                default:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_class_nullable_disable and return the result,
        /// and throw an exception if Variant_class_nullable_disable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_disable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s)
        {
            switch (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N)
            {
                case 0:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable is empty.");
                case 1:
                    return i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value);
                case 2:
                    return f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value);
                case 3:
                    return s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value);
                default:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_class_nullable_disable and return the result,
        /// and invoke a special delegate if Variant_class_nullable_disable is empty and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_class_nullable_disable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<TResult> _)
        {
            switch (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)_variant).N)
            {
                case 0:
                    return _();
                case 1:
                    return i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)_variant).Value);
                case 2:
                    return f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)_variant).Value);
                case 3:
                    return s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)_variant).Value);
                default:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

        private sealed class _VariantTypeProxy
        {
            public object Value { get; }
            public _VariantTypeProxy(Variant_class_nullable_disable v)
            {
                Value = v._variant.AsObject;
                VariantOf(default, default, default);
            }
        }

        public static explicit operator global::dotVariant._G.Foo.Variant_class_nullable_disable_N(Variant_class_nullable_disable v) => (global::dotVariant._G.Foo.Variant_class_nullable_disable_N)v._variant;
        public static explicit operator global::dotVariant._G.Foo.Variant_class_nullable_disable_1(Variant_class_nullable_disable v) => (global::dotVariant._G.Foo.Variant_class_nullable_disable_1)v._variant;
        public static explicit operator global::dotVariant._G.Foo.Variant_class_nullable_disable_2(Variant_class_nullable_disable v) => (global::dotVariant._G.Foo.Variant_class_nullable_disable_2)v._variant;
        public static explicit operator global::dotVariant._G.Foo.Variant_class_nullable_disable_3(Variant_class_nullable_disable v) => (global::dotVariant._G.Foo.Variant_class_nullable_disable_3)v._variant;
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_class_nullable_disable
    {
        private readonly Variant_class_nullable_disable_Union _x;
        private readonly uint _n;

        public Variant_class_nullable_disable(int i)
        {
            _n = 1;
            _x = new Variant_class_nullable_disable_Union(i);
        }
        public Variant_class_nullable_disable(float f)
        {
            _n = 2;
            _x = new Variant_class_nullable_disable_Union(f);
        }
        public Variant_class_nullable_disable(string s)
        {
            _n = 3;
            _x = new Variant_class_nullable_disable_Union(s);
        }


        public static explicit operator Variant_class_nullable_disable_N(Variant_class_nullable_disable v) => new Variant_class_nullable_disable_N(v._n);
        public static explicit operator Variant_class_nullable_disable_1(Variant_class_nullable_disable v) => v._x._1;
        public static explicit operator Variant_class_nullable_disable_2(Variant_class_nullable_disable v) => v._x._2;
        public static explicit operator Variant_class_nullable_disable_3(Variant_class_nullable_disable v) => v._x._3;

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
                        return "float";
                    case 3:
                        return "string";
                    default:
                        throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
                        return _x._2.Value.ToString();
                    case 3:
                        return _x._3.Value?.ToString() ?? "null";
                    default:
                        throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
                    case 3:
                        return _x._3.Value;
                    default:
                        throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
                }
            }
        }

        public bool Equals(in Variant_class_nullable_disable other)
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
                    return global::System.Collections.Generic.EqualityComparer<float>.Default.Equals(_x._2.Value, other._x._2.Value);
                case 3:
                    return global::System.Collections.Generic.EqualityComparer<string>.Default.Equals(_x._3.Value, other._x._3.Value);
                default:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
                    case 3:
                        return global::System.HashCode.Combine(_x._3.Value);
                    default:
                        throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
                }
            }
        }

        public bool TryMatch(out int i)
        {
            i = _n == 1 ? _x._1.Value : default;
            return _n == 1;
        }
        public bool TryMatch(out float f)
        {
            f = _n == 2 ? _x._2.Value : default;
            return _n == 2;
        }
        public bool TryMatch(out string s)
        {
            s = _n == 3 ? _x._3.Value : default;
            return _n == 3;
        }

        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action _)
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
                    f(_x._2.Value);
                    break;
                case 3:
                    s(_x._3.Value);
                    break;
                default:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s)
        {
            switch (_n)
            {
                case 0:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable is empty.");
                case 1:
                    i(_x._1.Value);
                    break;
                case 2:
                    f(_x._2.Value);
                    break;
                case 3:
                    s(_x._3.Value);
                    break;
                default:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<TResult> _)
        {
            switch (_n)
            {
                case 0:
                    return _();
                case 1:
                    return i(_x._1.Value);
                case 2:
                    return f(_x._2.Value);
                case 3:
                    return s(_x._3.Value);
                default:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }

        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s)
        {
            switch (_n)
            {
                case 0:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable is empty.");
                case 1:
                    return i(_x._1.Value);
                case 2:
                    return f(_x._2.Value);
                case 3:
                    return s(_x._3.Value);
                default:
                    throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
            }
        }
    }

    internal readonly ref struct Variant_class_nullable_disable_N
    {
        public readonly uint N;
        public Variant_class_nullable_disable_N(uint n) => N = n;
    }

    [global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit)]
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_class_nullable_disable_Union
    {
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public readonly Variant_class_nullable_disable_1 _1;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public readonly Variant_class_nullable_disable_2 _2;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public readonly Variant_class_nullable_disable_3 _3;

        public Variant_class_nullable_disable_Union(int value)
        {
            _2 = default;
            _3 = default;
            _1 = new Variant_class_nullable_disable_1(value);
        }
        public Variant_class_nullable_disable_Union(float value)
        {
            _1 = default;
            _3 = default;
            _2 = new Variant_class_nullable_disable_2(value);
        }
        public Variant_class_nullable_disable_Union(string value)
        {
            _1 = default;
            _2 = default;
            _3 = new Variant_class_nullable_disable_3(value);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_class_nullable_disable_1
    {
        public readonly int Value;
        public readonly object _dummy1;

        public Variant_class_nullable_disable_1(int value)
        {
            _dummy1 = null;
            Value = value;
        }
    }
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_class_nullable_disable_2
    {
        public readonly float Value;
        public readonly object _dummy1;

        public Variant_class_nullable_disable_2(float value)
        {
            _dummy1 = null;
            Value = value;
        }
    }
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_class_nullable_disable_3
    {
        public readonly string Value;

        public Variant_class_nullable_disable_3(string value)
        {
            Value = value;
        }
    }
}


namespace Foo
{
    public static partial class _Variant_class_nullable_disable_Ex
    {
        /// <summary>
        /// Transform a Variant_class_nullable_disable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_disable> source,
                global::System.Func<int, TResult> i)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)variant).N == 1)
                {
                    yield return i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)variant).Value);
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_disable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="float"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_disable> source,
                global::System.Func<float, TResult> f)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)variant).N == 2)
                {
                    yield return f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)variant).Value);
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_disable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="string"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_disable> source,
                global::System.Func<string, TResult> s)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)variant).N == 3)
                {
                    yield return s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)variant).Value);
                }
            }
        }

        /// <summary>
        /// Transform a Variant_class_nullable_disable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_disable> source,
                global::System.Func<int, TResult> i,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)variant).N == 1)
                {
                    yield return i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_disable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="float"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_disable> source,
                global::System.Func<float, TResult> f,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)variant).N == 2)
                {
                    yield return f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_disable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_disable> source,
                global::System.Func<string, TResult> s,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)variant).N == 3)
                {
                    yield return s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_class_nullable_disable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_disable> source,
                global::System.Func<int, TResult> i,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)variant).N == 1)
                {
                    yield return i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_disable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="float"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_disable> source,
                global::System.Func<float, TResult> f,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)variant).N == 2)
                {
                    yield return f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_disable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_disable> source,
                global::System.Func<string, TResult> s,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)variant).N == 3)
                {
                    yield return s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant_class_nullable_disable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException">
        /// if an element is empty.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the element's value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant_class_nullable_disable.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_disable> source,
                global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s)
        {
            foreach (var variant in source)
            {
                switch (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)variant).N)
                {
                    case 0:
                        throw new global::System.InvalidOperationException("Variant_class_nullable_disable is empty.");
                    case 1:
                        yield return i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)variant).Value);
                        break;
                    case 2:
                        yield return f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)variant).Value);
                        break;
                    case 3:
                        yield return s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)variant).Value);
                        break;
                    default:
                        throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
                }
            }
        }

        /// <summary>
        /// Transform a Variant_class_nullable_disable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the element's value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_disable> source,
                global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                switch (((global::dotVariant._G.Foo.Variant_class_nullable_disable_N)variant).N)
                {
                    case 0:
                        yield return _();
                        break;
                    case 1:
                        yield return i(((global::dotVariant._G.Foo.Variant_class_nullable_disable_1)variant).Value);
                        break;
                    case 2:
                        yield return f(((global::dotVariant._G.Foo.Variant_class_nullable_disable_2)variant).Value);
                        break;
                    case 3:
                        yield return s(((global::dotVariant._G.Foo.Variant_class_nullable_disable_3)variant).Value);
                        break;
                    default:
                        throw new global::System.InvalidOperationException("Variant_class_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
                }
            }
        }
    }
}
