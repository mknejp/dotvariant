//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable enable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(_VariantTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    partial class Variant_class_nullable_enable
        : global::System.IEquatable<Variant_class_nullable_enable>
    {
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly global::dotVariant._G.Foo.Variant_class_nullable_enable _variant;

        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public Variant_class_nullable_enable(int i)
            => _variant = new global::dotVariant._G.Foo.Variant_class_nullable_enable(i);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        public Variant_class_nullable_enable(float f)
            => _variant = new global::dotVariant._G.Foo.Variant_class_nullable_enable(f);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        public Variant_class_nullable_enable(string s)
            => _variant = new global::dotVariant._G.Foo.Variant_class_nullable_enable(s);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="global::System.Array"/>.
        /// </summary>
        /// <param name="a">The value to initlaize the variant with.</param>
        public Variant_class_nullable_enable(global::System.Array? a)
            => _variant = new global::dotVariant._G.Foo.Variant_class_nullable_enable(a);

        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public static implicit operator Variant_class_nullable_enable(int i)
            => new Variant_class_nullable_enable(i);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        public static implicit operator Variant_class_nullable_enable(float f)
            => new Variant_class_nullable_enable(f);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        public static implicit operator Variant_class_nullable_enable(string s)
            => new Variant_class_nullable_enable(s);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="global::System.Array"/>.
        /// </summary>
        /// <param name="a">The value to initlaize the variant with.</param>
        public static implicit operator Variant_class_nullable_enable(global::System.Array? a)
            => new Variant_class_nullable_enable(a);

        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public static Variant_class_nullable_enable Create(int i)
            => new Variant_class_nullable_enable(i);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        public static Variant_class_nullable_enable Create(float f)
            => new Variant_class_nullable_enable(f);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        public static Variant_class_nullable_enable Create(string s)
            => new Variant_class_nullable_enable(s);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="global::System.Array"/>.
        /// </summary>
        /// <param name="a">The value to initlaize the variant with.</param>
        public static Variant_class_nullable_enable Create(global::System.Array? a)
            => new Variant_class_nullable_enable(a);


        /// <summary>
        /// <see langword="true"/> if Variant_class_nullable_enable was constructed without a value.
        /// </summary>
        public bool IsEmpty
            => _variant.IsEmpty;

        public override bool Equals(object? other)
            => other is Variant_class_nullable_enable v && Equals(v);

        public bool Equals(Variant_class_nullable_enable? other)
            => !(other is null) && _variant.Equals(other._variant);

        public static bool operator ==(Variant_class_nullable_enable? lhs, Variant_class_nullable_enable? rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        public static bool operator !=(Variant_class_nullable_enable? lhs, Variant_class_nullable_enable? rhs)
            => !(lhs == rhs);

        public override int GetHashCode()
            => _variant.GetHashCode();

        public override string ToString()
            => _variant.ValueString;

        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="int"/></exception>
        public void Match(out int i)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 1)
            {
                i = ((global::dotVariant._Private.Accessor_1<int>)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'int', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="f">Receives the stored value if it is of type <see cref="float"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="float"/></exception>
        public void Match(out float f)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 2)
            {
                f = ((global::dotVariant._Private.Accessor_2<float>)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'float', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">Receives the stored value if it is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="string"/></exception>
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out string? s)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 3)
            {
                s = ((global::dotVariant._Private.Accessor_3<string>)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'string', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="a">Receives the stored value if it is of type <see cref="global::System.Array"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="global::System.Array"/></exception>
        public void Match(out global::System.Array? a)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 4)
            {
                a = ((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value;
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'System.Array?', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="int"/>.</returns>
        public bool TryMatch(out int i)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 1)
            {
                i = ((global::dotVariant._Private.Accessor_1<int>)_variant).Value;
                return true;
            }
            else
            {
                i = default;
                return false;
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">Receives the stored value if it is of type <see cref="float"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="float"/>.</returns>
        public bool TryMatch(out float f)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 2)
            {
                f = ((global::dotVariant._Private.Accessor_2<float>)_variant).Value;
                return true;
            }
            else
            {
                f = default;
                return false;
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">Receives the stored value if it is of type <see cref="string"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="string"/>.</returns>
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string? s)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 3)
            {
                s = ((global::dotVariant._Private.Accessor_3<string>)_variant).Value;
                return true;
            }
            else
            {
                s = default;
                return false;
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array"/>.
        /// </summary>
        /// <param name="a">Receives the stored value if it is of type <see cref="global::System.Array"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="global::System.Array"/>.</returns>
        public bool TryMatch(out global::System.Array? a)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 4)
            {
                a = ((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value;
                return true;
            }
            else
            {
                a = default;
                return false;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="int"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<int> i)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 1)
            {
                i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="float"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<float> f)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 2)
            {
                f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="string"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<string> s)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 3)
            {
                s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array"/>.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="global::System.Array"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<global::System.Array?> a)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 4)
            {
                a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="int"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public void Match(global::System.Action<int> i)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 1)
            {
                i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'int', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="float"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> is rethrown.</exception>
        public void Match(global::System.Action<float> f)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 2)
            {
                f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'float', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="string"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> is rethrown.</exception>
        public void Match(global::System.Action<string> s)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 3)
            {
                s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'string', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="global::System.Array"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"> is rethrown.</exception>
        public void Match(global::System.Action<global::System.Array?> a)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 4)
            {
                a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'System.Array?', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="_"> is rethrown.</exception>
        public void Match(global::System.Action<int> i, global::System.Action _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 1)
            {
                i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> or <paramref name="_"> is rethrown.</exception>
        public void Match(global::System.Action<float> f, global::System.Action _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 2)
            {
                f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> or <paramref name="_"> is rethrown.</exception>
        public void Match(global::System.Action<string> s, global::System.Action _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 3)
            {
                s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"> or <paramref name="_"> is rethrown.</exception>
        public void Match(global::System.Action<global::System.Array?> a, global::System.Action _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 4)
            {
                a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="int"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 1)
            {
                return i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'int', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <returns>The value returned from invoking <paramref name="f"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="float"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<float, TResult> f)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 2)
            {
                return f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'float', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <returns>The value returned from invoking <paramref name="s"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="string"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 3)
            {
                return s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'string', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array"/>.</param>
        /// <returns>The value returned from invoking <paramref name="a"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="global::System.Array"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.Array?, TResult> a)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 4)
            {
                return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_class_nullable_enable' (expected 'System.Array?', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="other"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 1)
            {
                return i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
            }
            else
            {
                return _;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="f"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> or <paramref name="other"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<float, TResult> f, TResult _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 2)
            {
                return f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
            }
            else
            {
                return _;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="s"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> or <paramref name="other"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s, TResult _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 3)
            {
                return s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
            }
            else
            {
                return _;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="a"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"> or <paramref name="other"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.Array?, TResult> a, TResult _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 4)
            {
                return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
            }
            else
            {
                return _;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="_"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<TResult> _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 1)
            {
                return i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
            }
            else
            {
                return _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> or <paramref name="_"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<float, TResult> f, global::System.Func<TResult> _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 2)
            {
                return f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
            }
            else
            {
                return _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> or <paramref name="_"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s, global::System.Func<TResult> _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 3)
            {
                return s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
            }
            else
            {
                return _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"> or <paramref name="_"> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.Array?, TResult> a, global::System.Func<TResult> _)
        {
            if (((int)(global::dotVariant._Private.Discriminator)_variant) == 4)
            {
                return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
            }
            else
            {
                return _();
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_class_nullable_enable,
        /// and throw an exception if Variant_class_nullable_enable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="global::System.Array"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action<global::System.Array?> a)
        {
            switch (((int)(global::dotVariant._Private.Discriminator)_variant))
            {
                case 0:
                    global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowEmptyError();
                    break;
                case 1:
                    i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
                    break;
                case 2:
                    f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
                    break;
                case 3:
                    s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
                    break;
                case 4:
                    a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
                    break;
                default:
                    global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowInternalError();
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_class_nullable_enable,
        /// and invoke a special delegate if Variant_class_nullable_enable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="global::System.Array"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_class_nullable_enable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action<global::System.Array?> a, global::System.Action _)
        {
            switch (((int)(global::dotVariant._Private.Discriminator)_variant))
            {
                case 0:
                    _();
                    break;
                case 1:
                    i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
                    break;
                case 2:
                    f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
                    break;
                case 3:
                    s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
                    break;
                case 4:
                    a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
                    break;
                default:
                    global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowInternalError();
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_class_nullable_enable and return the result,
        /// and throw an exception if Variant_class_nullable_enable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="global::System.Array"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a)
        {
            switch (((int)(global::dotVariant._Private.Discriminator)_variant))
            {
                case 0:
                    return global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowEmptyError<TResult>();
                case 1:
                    return i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
                case 2:
                    return f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
                case 3:
                    return s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
                case 4:
                    return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
                default:
                    return global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowInternalError<TResult>();
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_class_nullable_enable and return the result,
        /// and invoke a special delegate if Variant_class_nullable_enable is empty and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="global::System.Array"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_class_nullable_enable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a, global::System.Func<TResult> _)
        {
            switch (((int)(global::dotVariant._Private.Discriminator)_variant))
            {
                case 0:
                    return _();
                case 1:
                    return i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
                case 2:
                    return f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
                case 3:
                    return s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
                case 4:
                    return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
                default:
                    return global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowInternalError<TResult>();
            }
        }

        private sealed class _VariantTypeProxy
        {
            public object? Value { get; }
            public _VariantTypeProxy(Variant_class_nullable_enable v)
            {
                Value = v._variant.AsObject;
                VariantOf(default, default, default!, default);
            }
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static explicit operator global::dotVariant._Private.Discriminator(Variant_class_nullable_enable v) => (global::dotVariant._Private.Discriminator)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static explicit operator global::dotVariant._Private.Accessor_1<int>(Variant_class_nullable_enable v) => (global::dotVariant._Private.Accessor_1<int>)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static explicit operator global::dotVariant._Private.Accessor_2<float>(Variant_class_nullable_enable v) => (global::dotVariant._Private.Accessor_2<float>)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static explicit operator global::dotVariant._Private.Accessor_3<string>(Variant_class_nullable_enable v) => (global::dotVariant._Private.Accessor_3<string>)v._variant;
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static explicit operator global::dotVariant._Private.Accessor_4<global::System.Array?>(Variant_class_nullable_enable v) => (global::dotVariant._Private.Accessor_4<global::System.Array?>)v._variant;
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    internal readonly struct Variant_class_nullable_enable
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
            [global::System.Runtime.InteropServices.FieldOffset(0)]
            public readonly Value_4 _4;

            public Union(int value)
            {
                _2 = default;
                _3 = default;
                _4 = default;
                _1 = new Value_1(value);
            }
            public Union(float value)
            {
                _1 = default;
                _3 = default;
                _4 = default;
                _2 = new Value_2(value);
            }
            public Union(string value)
            {
                _1 = default;
                _2 = default;
                _4 = default;
                _3 = new Value_3(value);
            }
            public Union(global::System.Array? value)
            {
                _1 = default;
                _2 = default;
                _3 = default;
                _4 = new Value_4(value);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        private readonly struct Value_1
        {
            public readonly int Value;
            public readonly object _dummy1;

            public Value_1(int value)
            {
                _dummy1 = null!;
                Value = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCode]
        private readonly struct Value_2
        {
            public readonly float Value;
            public readonly object _dummy1;

            public Value_2(float value)
            {
                _dummy1 = null!;
                Value = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCode]
        private readonly struct Value_3
        {
            public readonly string Value;

            public Value_3(string value)
            {
                Value = value;
            }
        }
        [global::System.Diagnostics.DebuggerNonUserCode]
        private readonly struct Value_4
        {
            public readonly global::System.Array? Value;

            public Value_4(global::System.Array? value)
            {
                Value = value;
            }
        }

        private readonly Union _x;
        private readonly byte _n;

        public Variant_class_nullable_enable(int i)
        {
            _n = 1;
            _x = new Union(i);
        }
        public Variant_class_nullable_enable(float f)
        {
            _n = 2;
            _x = new Union(f);
        }
        public Variant_class_nullable_enable(string s)
        {
            _n = 3;
            _x = new Union(s);
        }
        public Variant_class_nullable_enable(global::System.Array? a)
        {
            _n = 4;
            _x = new Union(a);
        }


        public static explicit operator global::dotVariant._Private.Discriminator(Variant_class_nullable_enable v)
            => (global::dotVariant._Private.Discriminator)v._n;
        public static explicit operator global::dotVariant._Private.Accessor_1<int>(in Variant_class_nullable_enable v)
            => new global::dotVariant._Private.Accessor_1<int>(v._x._1.Value);
        public static explicit operator global::dotVariant._Private.Accessor_2<float>(in Variant_class_nullable_enable v)
            => new global::dotVariant._Private.Accessor_2<float>(v._x._2.Value);
        public static explicit operator global::dotVariant._Private.Accessor_3<string>(in Variant_class_nullable_enable v)
            => new global::dotVariant._Private.Accessor_3<string>(v._x._3.Value);
        public static explicit operator global::dotVariant._Private.Accessor_4<global::System.Array?>(in Variant_class_nullable_enable v)
            => new global::dotVariant._Private.Accessor_4<global::System.Array?>(v._x._4.Value);

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
            return new global::System.InvalidOperationException("Variant_class_nullable_enable is empty.");
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
            return new global::System.InvalidOperationException("Variant_class_nullable_enable has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
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
                        return "int";
                    case 2:
                        return "float";
                    case 3:
                        return "string";
                    case 4:
                        return "System.Array?";
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
                        return _x._1.Value.ToString();
                    case 2:
                        return _x._2.Value.ToString();
                    case 3:
                        return _x._3.Value.ToString();
                    case 4:
                        return _x._4.Value?.ToString() ?? "null";
                    default:
                        return ThrowInternalError<string>();
                }
            }
        }

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
                    case 4:
                        return _x._4.Value;
                    default:
                        return ThrowInternalError<object?>();
                }
            }
        }

        public bool Equals(in Variant_class_nullable_enable other)
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
                case 4:
                    return global::System.Collections.Generic.EqualityComparer<global::System.Array>.Default.Equals(_x._4.Value, other._x._4.Value);
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
                    case 2:
                        return global::System.HashCode.Combine(_x._2.Value);
                    case 3:
                        return global::System.HashCode.Combine(_x._3.Value);
                    case 4:
                        return global::System.HashCode.Combine(_x._4.Value);
                    default:
                        return ThrowInternalError<int>();
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
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string? s)
        {
            s = _n == 3 ? _x._3.Value : default;
            return _n == 3;
        }
        public bool TryMatch(out global::System.Array? a)
        {
            a = _n == 4 ? _x._4.Value : default;
            return _n == 4;
        }

        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action<global::System.Array?> a, global::System.Action _)
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
                case 4:
                    a(_x._4.Value);
                    break;
                default:
                    ThrowInternalError();
                    break;
            }
        }

        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action<global::System.Array?> a)
        {
            switch (_n)
            {
                case 0:
                    ThrowEmptyError();
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
                case 4:
                    a(_x._4.Value);
                    break;
                default:
                    ThrowInternalError();
                    break;
            }
        }

        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a, global::System.Func<TResult> _)
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
                case 4:
                    return a(_x._4.Value);
                default:
                    return ThrowInternalError<TResult>();
            }
        }

        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a)
        {
            switch (_n)
            {
                case 0:
                    return ThrowEmptyError<TResult>();
                case 1:
                    return i(_x._1.Value);
                case 2:
                    return f(_x._2.Value);
                case 3:
                    return s(_x._3.Value);
                case 4:
                    return a(_x._4.Value);
                default:
                    return ThrowInternalError<TResult>();
            }
        }
    }
}


namespace Foo
{
    public static partial class _Variant_class_nullable_enable_Ex
    {
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<int, TResult> i)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 1)
                {
                    yield return i(((global::dotVariant._Private.Accessor_1<int>)variant).Value);
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="float"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<float, TResult> f)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 2)
                {
                    yield return f(((global::dotVariant._Private.Accessor_2<float>)variant).Value);
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="string"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<string, TResult> s)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 3)
                {
                    yield return s(((global::dotVariant._Private.Accessor_3<string>)variant).Value);
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="global::System.Array"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<global::System.Array?, TResult> a)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 4)
                {
                    yield return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)variant).Value);
                }
            }
        }

        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<int, TResult> i,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 1)
                {
                    yield return i(((global::dotVariant._Private.Accessor_1<int>)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<float, TResult> f,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 2)
                {
                    yield return f(((global::dotVariant._Private.Accessor_2<float>)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<string, TResult> s,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 3)
                {
                    yield return s(((global::dotVariant._Private.Accessor_3<string>)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="global::System.Array"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<global::System.Array?, TResult> a,
                TResult _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 4)
                {
                    yield return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)variant).Value);
                }
                else
                {
                    yield return _;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<int, TResult> i,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 1)
                {
                    yield return i(((global::dotVariant._Private.Accessor_1<int>)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<float, TResult> f,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 2)
                {
                    yield return f(((global::dotVariant._Private.Accessor_2<float>)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<string, TResult> s,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 3)
                {
                    yield return s(((global::dotVariant._Private.Accessor_3<string>)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="global::System.Array"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<global::System.Array?, TResult> a,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                if (((int)(global::dotVariant._Private.Discriminator)variant) == 4)
                {
                    yield return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)variant).Value);
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException">
        /// if an element is empty.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the element's value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="global::System.Array"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant_class_nullable_enable.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a)
        {
            foreach (var variant in source)
            {
                switch (((int)(global::dotVariant._Private.Discriminator)variant))
                {
                    case 0:
                        global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowEmptyError();
                        yield break;
                    case 1:
                        yield return i(((global::dotVariant._Private.Accessor_1<int>)variant).Value);
                        break;
                    case 2:
                        yield return f(((global::dotVariant._Private.Accessor_2<float>)variant).Value);
                        break;
                    case 3:
                        yield return s(((global::dotVariant._Private.Accessor_3<string>)variant).Value);
                        break;
                    case 4:
                        yield return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)variant).Value);
                        break;
                    default:
                        global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowInternalError();
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the element's value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="global::System.Array"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a,
                global::System.Func<TResult> _)
        {
            foreach (var variant in source)
            {
                switch (((int)(global::dotVariant._Private.Discriminator)variant))
                {
                    case 0:
                        yield return _();
                        break;
                    case 1:
                        yield return i(((global::dotVariant._Private.Accessor_1<int>)variant).Value);
                        break;
                    case 2:
                        yield return f(((global::dotVariant._Private.Accessor_2<float>)variant).Value);
                        break;
                    case 3:
                        yield return s(((global::dotVariant._Private.Accessor_3<string>)variant).Value);
                        break;
                    case 4:
                        yield return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)variant).Value);
                        break;
                    default:
                        global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowInternalError();
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    public static partial class _Variant_class_nullable_enable_Ex
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
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<int, TResult> i)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant._Private.Discriminator)_variant) == 1),
                _variant => i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value));
        }
        /// <summary>
        /// Projects each <see cref="float"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<float, TResult> f)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant._Private.Discriminator)_variant) == 2),
                _variant => f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value));
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
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<string, TResult> s)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant._Private.Discriminator)_variant) == 3),
                _variant => s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value));
        }
        /// <summary>
        /// Projects each <see cref="global::System.Array"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<global::System.Array?, TResult> a)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => ((int)(global::dotVariant._Private.Discriminator)_variant) == 4),
                _variant => a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value));
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
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<int, TResult> i,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant._Private.Discriminator)_variant) == 1)
                {
                    return i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
                }
                else
                {
                    return _;
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="float"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<float, TResult> f,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant._Private.Discriminator)_variant) == 2)
                {
                    return f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
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
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<string, TResult> s,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant._Private.Discriminator)_variant) == 3)
                {
                    return s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
                }
                else
                {
                    return _;
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="global::System.Array"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<global::System.Array?, TResult> a,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant._Private.Discriminator)_variant) == 4)
                {
                    return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
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
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<int, TResult> i,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant._Private.Discriminator)_variant) == 1)
                {
                    return i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
                }
                else
                {
                    return _();
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="float"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<float, TResult> f,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant._Private.Discriminator)_variant) == 2)
                {
                    return f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
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
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<string, TResult> s,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant._Private.Discriminator)_variant) == 3)
                {
                    return s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
                }
                else
                {
                    return _();
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="global::System.Array"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<global::System.Array?, TResult> a,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (((int)(global::dotVariant._Private.Discriminator)_variant) == 4)
                {
                    return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
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
        /// <param name="f">The delegate to invoke if the element's value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="global::System.Array"/>.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (((int)(global::dotVariant._Private.Discriminator)_variant))
                {
                    case 0:
                        return global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowEmptyError<TResult>();
                    case 1:
                        return i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
                    case 2:
                        return f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
                    case 3:
                        return s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
                    case 4:
                        return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
                    default:
                        return global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowInternalError<TResult>();
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to visit.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the element's value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="global::System.Array"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (((int)(global::dotVariant._Private.Discriminator)_variant))
                {
                    case 0:
                        return _();
                    case 1:
                        return i(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
                    case 2:
                        return f(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
                    case 3:
                        return s(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
                    case 4:
                        return a(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
                    default:
                        return global::dotVariant._G.Foo.Variant_class_nullable_enable.ThrowInternalError<TResult>();
                }
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_class_nullable_enable elements into one independent sub-sequences per value type,
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
        /// <param name="f">Transform an observable sequence of <see cref="float"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="s">Transform an observable sequence of <see cref="string"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="a">Transform an observable sequence of <see cref="global::System.Array"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<TResult>> i, global::System.Func<global::System.IObservable<float>, global::System.IObservable<TResult>> f, global::System.Func<global::System.IObservable<string>, global::System.IObservable<TResult>> s, global::System.Func<global::System.IObservable<global::System.Array?>, global::System.IObservable<TResult>> a)
        {
            return VisitMany(source, (_1, _2, _3, _4) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(i(_1), f(_2), s(_3), a(_4));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_class_nullable_enable elements into one independent sub-sequences per value type,
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
        /// <param name="f">Transform an observable sequence of <see cref="float"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="s">Transform an observable sequence of <see cref="string"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="a">Transform an observable sequence of <see cref="global::System.Array"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="_">Transform a sequence of <see cref="global::System.Reactive.Unit"/> values (each representing an empty variant) into a sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<TResult>> i, global::System.Func<global::System.IObservable<float>, global::System.IObservable<TResult>> f, global::System.Func<global::System.IObservable<string>, global::System.IObservable<TResult>> s, global::System.Func<global::System.IObservable<global::System.Array?>, global::System.IObservable<TResult>> a,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
        {
            return VisitMany(source, (_1, _2, _3, _4, _0) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(i(_1), f(_2), s(_3), a(_4), _(_0));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_class_nullable_enable elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<float>, global::System.IObservable<string>, global::System.IObservable<global::System.Array?>, global::System.IObservable<TResult>> selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(false);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject2, _mo.Subject3, _mo.Subject4).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(source, _mo),
                    _mo);
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_class_nullable_enable elements into one independent sub-sequences per value type,
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
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<float>, global::System.IObservable<string>, global::System.IObservable<global::System.Array?>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(true);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject2, _mo.Subject3, _mo.Subject4, _mo.Subject0).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(source, _mo),
                    _mo);
            });
        }

        private sealed class VisitManyObserver : global::System.IObserver<global::Foo.Variant_class_nullable_enable>, global::System.IDisposable
        {
            public readonly global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit> Subject0 = new global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit>();
            public readonly global::System.Reactive.Subjects.Subject<int> Subject1 = new global::System.Reactive.Subjects.Subject<int>();
            public readonly global::System.Reactive.Subjects.Subject<float> Subject2 = new global::System.Reactive.Subjects.Subject<float>();
            public readonly global::System.Reactive.Subjects.Subject<string> Subject3 = new global::System.Reactive.Subjects.Subject<string>();
            public readonly global::System.Reactive.Subjects.Subject<global::System.Array?> Subject4 = new global::System.Reactive.Subjects.Subject<global::System.Array?>();
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
                Subject4.Dispose();
                Subject0.Dispose();
            }

            public void OnNext(global::Foo.Variant_class_nullable_enable _variant)
            {
                switch (((int)(global::dotVariant._Private.Discriminator)_variant))
                {
                    case 0:
                        if (_accept0)
                        {
                            Subject0.OnNext(global::System.Reactive.Unit.Default);
                        }
                        else
                        {
                            OnError(global::dotVariant._G.Foo.Variant_class_nullable_enable.MakeEmptyError());
                        }
                        break;
                    case 1:
                        Subject1.OnNext(((global::dotVariant._Private.Accessor_1<int>)_variant).Value);
                        break;
                    case 2:
                        Subject2.OnNext(((global::dotVariant._Private.Accessor_2<float>)_variant).Value);
                        break;
                    case 3:
                        Subject3.OnNext(((global::dotVariant._Private.Accessor_3<string>)_variant).Value);
                        break;
                    case 4:
                        Subject4.OnNext(((global::dotVariant._Private.Accessor_4<global::System.Array?>)_variant).Value);
                        break;
                    default:
                        OnError(global::dotVariant._G.Foo.Variant_class_nullable_enable.MakeInternalError());
                        break;
                }
            }

            public void OnError(global::System.Exception _ex)
            {
                Subject1.OnError(_ex);
                Subject2.OnError(_ex);
                Subject3.OnError(_ex);
                Subject4.OnError(_ex);
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
                Subject4.OnCompleted();
                if (_accept0)
                {
                    Subject0.OnCompleted();
                }
            }
        }

    }
}
