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
    partial struct Variant_struct_nullable_disable
        : global::System.IEquatable<Variant_struct_nullable_disable>
    {
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly global::dotVariant._G.Foo.Variant_struct_nullable_disable _variant;

        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        public Variant_struct_nullable_disable(long l)
            => _variant = new global::dotVariant._G.Foo.Variant_struct_nullable_disable(l);
        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        public Variant_struct_nullable_disable(double d)
            => _variant = new global::dotVariant._G.Foo.Variant_struct_nullable_disable(d);
        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The value to initlaize the variant with.</param>
        public Variant_struct_nullable_disable(object o)
            => _variant = new global::dotVariant._G.Foo.Variant_struct_nullable_disable(o);

        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        public static implicit operator Variant_struct_nullable_disable(long l)
            => new Variant_struct_nullable_disable(l);
        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        public static implicit operator Variant_struct_nullable_disable(double d)
            => new Variant_struct_nullable_disable(d);

        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        public static Variant_struct_nullable_disable Create(long l)
            => new Variant_struct_nullable_disable(l);
        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        public static Variant_struct_nullable_disable Create(double d)
            => new Variant_struct_nullable_disable(d);
        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The value to initlaize the variant with.</param>
        public static Variant_struct_nullable_disable Create(object o)
            => new Variant_struct_nullable_disable(o);


        /// <summary>
        /// <see langword="true"/> if Variant_struct_nullable_disable was constructed without a value.
        /// </summary>
        /// <remarks>
        /// Because Variant_struct_nullable_disable is a value type, its default constructor cannot be disabled.
        /// A default-constructed Variant_struct_nullable_disable will always have a <see cref="IsEmpty"/> value of <see langword"true"/>
        /// and never satisfy any matching attempts except for the wildcard <c>_</c> parameter.
        /// </remarks>
        public readonly bool IsEmpty
            => _variant.IsEmpty;

        public readonly override bool Equals(object other)
            => other is Variant_struct_nullable_disable v && Equals(v);

        public readonly bool Equals(Variant_struct_nullable_disable other)
            => _variant.Equals(other._variant);

        public static bool operator ==(Variant_struct_nullable_disable lhs, Variant_struct_nullable_disable rhs)
            => lhs.Equals(rhs);

        public static bool operator !=(Variant_struct_nullable_disable lhs, Variant_struct_nullable_disable rhs)
            => !(lhs == rhs);

        public readonly override int GetHashCode()
            => _variant.GetHashCode();

        public readonly override string ToString()
            => _variant.ValueString;

        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="l">Receives the stored value if it is of type <see cref="long"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable does not contain a value of type <see cref="long"/></exception>
        public readonly void Match(out long l)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 1)
            {
                l = ((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_disable' (expected 'long', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="d">Receives the stored value if it is of type <see cref="double"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable does not contain a value of type <see cref="double"/></exception>
        public readonly void Match(out double d)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 2)
            {
                d = ((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_disable' (expected 'double', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="o">Receives the stored value if it is of type <see cref="object"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable does not contain a value of type <see cref="object"/></exception>
        public readonly void Match(out object o)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 3)
            {
                o = ((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_disable' (expected 'object', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">Receives the stored value if it is of type <see cref="long"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="long"/>.</returns>
        public readonly bool TryMatch(out long l)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 1)
            {
                l = ((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value;
                return true;
            }
            else
            {
                l = default;
                return false;
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">Receives the stored value if it is of type <see cref="double"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="double"/>.</returns>
        public readonly bool TryMatch(out double d)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 2)
            {
                d = ((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value;
                return true;
            }
            else
            {
                d = default;
                return false;
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">Receives the stored value if it is of type <see cref="object"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="object"/>.</returns>
        public readonly bool TryMatch(out object o)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 3)
            {
                o = ((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value;
                return true;
            }
            else
            {
                o = default;
                return false;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="long"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> is rethrown.</exception>
        public readonly bool TryMatch(global::System.Action<long> l)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 1)
            {
                l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="double"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> is rethrown.</exception>
        public readonly bool TryMatch(global::System.Action<double> d)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 2)
            {
                d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="object"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> is rethrown.</exception>
        public readonly bool TryMatch(global::System.Action<object> o)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 3)
            {
                o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable does not contain a value of type <see cref="long"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> is rethrown.</exception>
        public readonly void Match(global::System.Action<long> l)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 1)
            {
                l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_disable' (expected 'long', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable does not contain a value of type <see cref="double"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> is rethrown.</exception>
        public readonly void Match(global::System.Action<double> d)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 2)
            {
                d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_disable' (expected 'double', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable does not contain a value of type <see cref="object"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> is rethrown.</exception>
        public readonly void Match(global::System.Action<object> o)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 3)
            {
                o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_disable' (expected 'object', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> or <paramref name="_"> is rethrown.</exception>
        public readonly void Match(global::System.Action<long> l, global::System.Action _)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 1)
            {
                l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> or <paramref name="_"> is rethrown.</exception>
        public readonly void Match(global::System.Action<double> d, global::System.Action _)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 2)
            {
                d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> or <paramref name="_"> is rethrown.</exception>
        public readonly void Match(global::System.Action<object> o, global::System.Action _)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 3)
            {
                o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <returns>The value returned from invoking <paramref name="l"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable does not contain a value of type <see cref="long"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 1)
            {
                return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_disable' (expected 'long', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <returns>The value returned from invoking <paramref name="d"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable does not contain a value of type <see cref="double"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 2)
            {
                return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_disable' (expected 'double', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <returns>The value returned from invoking <paramref name="o"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable does not contain a value of type <see cref="object"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 3)
            {
                return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_disable' (expected 'object', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="l"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> or <paramref name="other"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l, TResult _)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 1)
            {
                return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
            }
            else
            {
                return _;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="d"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> or <paramref name="other"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d, TResult _)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 2)
            {
                return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
            }
            else
            {
                return _;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="o"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> or <paramref name="other"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o, TResult _)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 3)
            {
                return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
            }
            else
            {
                return _;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> or <paramref name="_"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l, global::System.Func<TResult> _)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 1)
            {
                return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
            }
            else
            {
                return _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> or <paramref name="_"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d, global::System.Func<TResult> _)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 2)
            {
                return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
            }
            else
            {
                return _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> or <paramref name="_"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o, global::System.Func<TResult> _)
        {
            if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 3)
            {
                return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
            }
            else
            {
                return _();
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_struct_nullable_disable,
        /// and throw an exception if Variant_struct_nullable_disable is empty.
        /// </summary>
        /// <param name="l">The delegate to invoke if the stored value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the stored value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the stored value is of type <see cref="object"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public readonly void Visit(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o)
        {
            switch (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N)
            {
                case 0:
                    global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowEmptyError();
                    break;
                case 1:
                    l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
                    break;
                case 2:
                    d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
                    break;
                case 3:
                    o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
                    break;
            }
            global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowInternalError();
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_struct_nullable_disable,
        /// and invoke a special delegate if Variant_struct_nullable_disable is empty.
        /// </summary>
        /// <param name="l">The delegate to invoke if the stored value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the stored value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the stored value is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_struct_nullable_disable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public readonly void Visit(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o, global::System.Action _)
        {
            switch (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N)
            {
                case 0:
                    _();
                    break;
                case 1:
                    l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
                    break;
                case 2:
                    d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
                    break;
                case 3:
                    o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
                    break;
                }
            global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowInternalError();
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_struct_nullable_disable and return the result,
        /// and throw an exception if Variant_struct_nullable_disable is empty.
        /// </summary>
        /// <param name="l">The delegate to invoke if the stored value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the stored value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the stored value is of type <see cref="object"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public readonly TResult Visit<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
        {
            switch (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N)
            {
                case 0:
                    return global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowEmptyError<TResult>();
                case 1:
                    return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
                case 2:
                    return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
                case 3:
                    return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
            }
            return global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowInternalError<TResult>();
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_struct_nullable_disable and return the result,
        /// and invoke a special delegate if Variant_struct_nullable_disable is empty and return its result.
        /// </summary>
        /// <param name="l">The delegate to invoke if the stored value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the stored value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the stored value is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_struct_nullable_disable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public readonly TResult Visit<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o, global::System.Func<TResult> _)
        {
            switch (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N)
            {
                case 0:
                    return _();
                case 1:
                    return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
                case 2:
                    return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
                case 3:
                    return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
            }
            return global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowInternalError<TResult>();
        }

        private sealed class _VariantTypeProxy
        {
            public object Value { get; }
            public _VariantTypeProxy(Variant_struct_nullable_disable v)
            {
                Value = v._variant.AsObject;
                VariantOf(default, default, default);
            }
        }

        public static explicit operator global::dotVariant._G.Foo.Variant_struct_nullable_disable_N(Variant_struct_nullable_disable v) => (global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)v._variant;
        public static explicit operator global::dotVariant._G.Foo.Variant_struct_nullable_disable_1(Variant_struct_nullable_disable v) => (global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)v._variant;
        public static explicit operator global::dotVariant._G.Foo.Variant_struct_nullable_disable_2(Variant_struct_nullable_disable v) => (global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)v._variant;
        public static explicit operator global::dotVariant._G.Foo.Variant_struct_nullable_disable_3(Variant_struct_nullable_disable v) => (global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)v._variant;
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_struct_nullable_disable
    {
        private readonly Variant_struct_nullable_disable_Union _x;
        private readonly uint _n;

        public Variant_struct_nullable_disable(long l)
        {
            _n = 1;
            _x = new Variant_struct_nullable_disable_Union(l);
        }
        public Variant_struct_nullable_disable(double d)
        {
            _n = 2;
            _x = new Variant_struct_nullable_disable_Union(d);
        }
        public Variant_struct_nullable_disable(object o)
        {
            _n = 3;
            _x = new Variant_struct_nullable_disable_Union(o);
        }


        public static explicit operator Variant_struct_nullable_disable_N(Variant_struct_nullable_disable v) => new Variant_struct_nullable_disable_N(v._n);
        public static explicit operator Variant_struct_nullable_disable_1(Variant_struct_nullable_disable v) => v._x._1;
        public static explicit operator Variant_struct_nullable_disable_2(Variant_struct_nullable_disable v) => v._x._2;
        public static explicit operator Variant_struct_nullable_disable_3(Variant_struct_nullable_disable v) => v._x._3;

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
            return new global::System.InvalidOperationException("Variant_struct_nullable_disable is empty.");
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
            return new global::System.InvalidOperationException("Variant_struct_nullable_disable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
                        return "long";
                    case 2:
                        return "double";
                    case 3:
                        return "object";
                }
                return ThrowInternalError<string>();
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
                }
                return ThrowInternalError<string>();
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
                }
                return ThrowInternalError<object>();
            }
        }

        public bool Equals(in Variant_struct_nullable_disable other)
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
            }
            return ThrowInternalError<bool>();
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
                }
                return ThrowInternalError<int>();
            }
        }

        public bool TryMatch(out long l)
        {
            l = _n == 1 ? _x._1.Value : default;
            return _n == 1;
        }
        public bool TryMatch(out double d)
        {
            d = _n == 2 ? _x._2.Value : default;
            return _n == 2;
        }
        public bool TryMatch(out object o)
        {
            o = _n == 3 ? _x._3.Value : default;
            return _n == 3;
        }

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
            }
            ThrowInternalError();
        }

        public void Visit(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o)
        {
            switch (_n)
            {
                case 0:
                    ThrowEmptyError();
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
            }
            ThrowInternalError();
        }

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
            }
            return ThrowInternalError<TResult>();
        }

        public TResult Visit<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
        {
            switch (_n)
            {
                case 0:
                    return ThrowEmptyError<TResult>();
                case 1:
                    return l(_x._1.Value);
                case 2:
                    return d(_x._2.Value);
                case 3:
                    return o(_x._3.Value);
            }
            return ThrowInternalError<TResult>();
        }
    }

    internal readonly ref struct Variant_struct_nullable_disable_N
    {
        public readonly uint N;
        public Variant_struct_nullable_disable_N(uint n) => N = n;
    }

    [global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit)]
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_struct_nullable_disable_Union
    {
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public readonly Variant_struct_nullable_disable_1 _1;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public readonly Variant_struct_nullable_disable_2 _2;
        [global::System.Runtime.InteropServices.FieldOffset(0)]
        public readonly Variant_struct_nullable_disable_3 _3;

        public Variant_struct_nullable_disable_Union(long value)
        {
            _2 = default;
            _3 = default;
            _1 = new Variant_struct_nullable_disable_1(value);
        }
        public Variant_struct_nullable_disable_Union(double value)
        {
            _1 = default;
            _3 = default;
            _2 = new Variant_struct_nullable_disable_2(value);
        }
        public Variant_struct_nullable_disable_Union(object value)
        {
            _1 = default;
            _2 = default;
            _3 = new Variant_struct_nullable_disable_3(value);
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_struct_nullable_disable_1
    {
        public readonly long Value;
        public readonly object _dummy1;

        public Variant_struct_nullable_disable_1(long value)
        {
            _dummy1 = null;
            Value = value;
        }
    }
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_struct_nullable_disable_2
    {
        public readonly double Value;
        public readonly object _dummy1;

        public Variant_struct_nullable_disable_2(double value)
        {
            _dummy1 = null;
            Value = value;
        }
    }
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_struct_nullable_disable_3
    {
        public readonly object Value;

        public Variant_struct_nullable_disable_3(object value)
        {
            Value = value;
        }
    }
}


namespace Foo
{
    public static partial class _Variant_struct_nullable_disable_Ex
    {
        /// <summary>
        /// Transform a Variant_struct_nullable_disable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="long"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="l">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<long, TResult> l)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)variant).N == 1)
                {
                    yield return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)variant).Value);
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_disable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="double"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="d">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<double, TResult> d)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)variant).N == 2)
                {
                    yield return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)variant).Value);
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_disable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="object"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="o">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<object, TResult> o)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)variant).N == 3)
                {
                    yield return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)variant).Value);
                }
            }
        }

        /// <summary>
        /// Transform a Variant_struct_nullable_disable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<long, TResult> l,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)variant).N == 1)
                {
                    yield return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_disable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<double, TResult> d,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)variant).N == 2)
                {
                    yield return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_disable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<object, TResult> o,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)variant).N == 3)
                {
                    yield return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_struct_nullable_disable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<long, TResult> l,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)variant).N == 1)
                {
                    yield return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_disable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<double, TResult> d,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)variant).N == 2)
                {
                    yield return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant_struct_nullable_disable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<object, TResult> o,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)variant).N == 3)
                {
                    yield return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant_struct_nullable_disable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException">
        /// if an element is empty.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="l">The delegate to invoke if the element's value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the element's value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the element's value is of type <see cref="object"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant_struct_nullable_disable.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
        {
            foreach (var variant in source)
            {
                switch (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)variant).N)
                {
                    case 0:
                        global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowEmptyError();
                        yield break;
                    case 1:
                        yield return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)variant).Value);
                        break;
                    case 2:
                        yield return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)variant).Value);
                        break;
                    case 3:
                        yield return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)variant).Value);
                        break;
                    default:
                        global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowInternalError();
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_struct_nullable_disable-based enumerable sequence by applying a selector function to each element
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                switch (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)variant).N)
                {
                    case 0:
                        yield return _();
                        break;
                    case 1:
                        yield return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)variant).Value);
                        break;
                    case 2:
                        yield return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)variant).Value);
                        break;
                    case 3:
                        yield return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)variant).Value);
                        break;
                    default:
                        global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowInternalError();
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    using System;
    using System.Reactive.Linq;

    public static partial class _Variant_struct_nullable_disable_Ex
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<long, TResult> l)
        {
            return source
                .Where(_variant => ((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 1)
                .Select(_variant => l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value));
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<double, TResult> d)
        {
            return source
                .Where(_variant => ((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 2)
                .Select(_variant => d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value));
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<object, TResult> o)
        {
            return source
                .Where(_variant => ((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 3)
                .Select(_variant => o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value));
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<long, TResult> l,
                TResult _)
        {
            return source.Select(_variant =>
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 1)
                {
                    return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<double, TResult> d,
                TResult _)
        {
            return source.Select(_variant =>
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 2)
                {
                    return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<object, TResult> o,
                TResult _)
        {
            return source.Select(_variant =>
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 3)
                {
                    return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<long, TResult> l,
                global::System.Func<TResult> _)
        {
            return source.Select(_variant =>
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 1)
                {
                    return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<double, TResult> d,
                global::System.Func<TResult> _)
        {
            return source.Select(_variant =>
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 2)
                {
                    return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<object, TResult> o,
                global::System.Func<TResult> _)
        {
            return source.Select(_variant =>
            {
                if (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N == 3)
                {
                    return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
        {
            return source.Select(_variant =>
            {
                switch (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N)
                {
                    case 0:
                        return global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowEmptyError<TResult>();
                    case 1:
                        return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
                    case 2:
                        return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
                    case 3:
                        return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
                    default:
                        return global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowInternalError<TResult>();
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o,
                global::System.Func<TResult> _)
        {
            return source.Select(_variant =>
            {
                switch (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N)
                {
                    case 0:
                        return _();
                    case 1:
                        return l(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
                    case 2:
                        return d(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
                    case 3:
                        return o(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
                    default:
                        return global::dotVariant._G.Foo.Variant_struct_nullable_disable.ThrowInternalError<TResult>();
                }
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_struct_nullable_disable elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<global::System.IObservable<long>, global::System.IObservable<TResult>> l, global::System.Func<global::System.IObservable<double>, global::System.IObservable<TResult>> d, global::System.Func<global::System.IObservable<object>, global::System.IObservable<TResult>> o)
        {
            return VisitMany(source, (_1, _2, _3) =>
            {
                return Observable.Merge(l(_1), d(_2), o(_3));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_struct_nullable_disable elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<global::System.IObservable<long>, global::System.IObservable<TResult>> l, global::System.Func<global::System.IObservable<double>, global::System.IObservable<TResult>> d, global::System.Func<global::System.IObservable<object>, global::System.IObservable<TResult>> o,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
        {
            return VisitMany(source, (_1, _2, _3, _0) =>
            {
                return Observable.Merge(l(_1), d(_2), o(_3), _(_0));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_struct_nullable_disable elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<global::System.IObservable<long>, global::System.IObservable<double>, global::System.IObservable<object>, global::System.IObservable<TResult>> selector)
        {
            return Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(false);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject2, _mo.Subject3)
                        .Subscribe(_o),
                    source
                        .SubscribeSafe(_mo),
                    _mo);
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_struct_nullable_disable elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_struct_nullable_disable> source,
                global::System.Func<global::System.IObservable<long>, global::System.IObservable<double>, global::System.IObservable<object>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> selector)
        {
            return Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(true);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject2, _mo.Subject3, _mo.Subject0)
                        .Subscribe(_o),
                    source
                        .SubscribeSafe(_mo),
                    _mo);
            });
        }

        private sealed class VisitManyObserver : global::System.IObserver<global::Foo.Variant_struct_nullable_disable>, global::System.IDisposable
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

            public void OnNext(global::Foo.Variant_struct_nullable_disable _variant)
            {
                switch (((global::dotVariant._G.Foo.Variant_struct_nullable_disable_N)_variant).N)
                {
                    case 0:
                        if (_accept0)
                        {
                            Subject0.OnNext(global::System.Reactive.Unit.Default);
                        }
                        else
                        {
                            OnError(global::dotVariant._G.Foo.Variant_struct_nullable_disable.MakeEmptyError());
                        }
                        break;
                    case 1:
                        Subject1.OnNext(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_1)_variant).Value);
                        break;
                    case 2:
                        Subject2.OnNext(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_2)_variant).Value);
                        break;
                    case 3:
                        Subject3.OnNext(((global::dotVariant._G.Foo.Variant_struct_nullable_disable_3)_variant).Value);
                        break;
                    default:
                        OnError(global::dotVariant._G.Foo.Variant_struct_nullable_disable.MakeInternalError());
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
