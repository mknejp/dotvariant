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
    partial struct Variant_struct_nullable_enable : global::System.IEquatable<Variant_struct_nullable_enable>
    {
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly _VariantStorage _variant;

        private sealed class _VariantTypeProxy
        {
            public object? Value { get; }
            public _VariantTypeProxy(Variant_struct_nullable_enable v)
            {
                Value = v._variant.AsObject;
                VariantOf(default, default, default!);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        private readonly struct _VariantStorage
        {
            private readonly int _n;
            private readonly Union _x;

            public _VariantStorage(long l)
            {
                _n = 1;
                _x = new Union(l);
            }
            public _VariantStorage(double d)
            {
                _n = 2;
                _x = new Union(d);
            }
            public _VariantStorage(object o)
            {
                _n = 3;
                _x = new Union(o);
            }

            [global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit)]
            [global::System.Diagnostics.DebuggerNonUserCode]
            private readonly struct Union
            {
                [global::System.Runtime.InteropServices.FieldOffset(0)]
                public readonly Union1 _1;
                [global::System.Runtime.InteropServices.FieldOffset(0)]
                public readonly Union2 _2;
                [global::System.Runtime.InteropServices.FieldOffset(0)]
                public readonly Union3 _3;

                public Union(long value)
                {
                    _2 = default;
                    _3 = default;
                    _1 = new Union1(value);
                }
                public Union(double value)
                {
                    _1 = default;
                    _3 = default;
                    _2 = new Union2(value);
                }
                public Union(object value)
                {
                    _1 = default;
                    _2 = default;
                    _3 = new Union3(value);
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public readonly struct Union1
                {
                    public readonly long Value;
                    public readonly object _dummy1;

                    public Union1(long value)
                    {
                        _dummy1 = null!;
                        Value = value;
                    }
                }
                [global::System.Diagnostics.DebuggerNonUserCode]
                public readonly struct Union2
                {
                    public readonly double Value;
                    public readonly object _dummy1;

                    public Union2(double value)
                    {
                        _dummy1 = null!;
                        Value = value;
                    }
                }
                [global::System.Diagnostics.DebuggerNonUserCode]
                public readonly struct Union3
                {
                    public readonly object Value;

                    public Union3(object value)
                    {
                        Value = value;
                    }
                }
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
                        default:
                            throw new global::System.InvalidOperationException("Variant_struct_nullable_enable is in a corrupted state.");
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
                            return _x._3.Value.ToString() ?? "null";
                        default:
                            throw new global::System.InvalidOperationException("Variant_struct_nullable_enable is in a corrupted state.");
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
                        default:
                            throw new global::System.InvalidOperationException("Variant_struct_nullable_enable is in a corrupted state.");
                    }
                }
            }

            public bool Equals(in _VariantStorage other)
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
                        throw new global::System.InvalidOperationException("Variant_struct_nullable_enable is in a corrupted state.");
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
                            throw new global::System.InvalidOperationException("Variant_struct_nullable_enable is in a corrupted state.");
                    }
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
            public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out object? o)
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
                    default:
                        throw new global::System.InvalidOperationException("Variant_struct_nullable_enable is in a corrupted state.");
                }
            }

            public void Visit(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o)
            {
                switch (_n)
                {
                    case 0:
                        throw new global::System.InvalidOperationException("Variant_struct_nullable_enable is empty.");
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
                        throw new global::System.InvalidOperationException("Variant_struct_nullable_enable is in a corrupted state.");
                }
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
                    default:
                        throw new global::System.InvalidOperationException("Variant_struct_nullable_enable is in a corrupted state.");
                }
            }

            public TResult Visit<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
            {
                switch (_n)
                {
                    case 0:
                        throw new global::System.InvalidOperationException("Variant_struct_nullable_enable is empty.");
                    case 1:
                        return l(_x._1.Value);
                    case 2:
                        return d(_x._2.Value);
                    case 3:
                        return o(_x._3.Value);
                    default:
                        throw new global::System.InvalidOperationException("Variant_struct_nullable_enable is in a corrupted state.");
                }
            }
        }

        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        public Variant_struct_nullable_enable(long l)
            => _variant = new _VariantStorage(l);
        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        public Variant_struct_nullable_enable(double d)
            => _variant = new _VariantStorage(d);
        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The value to initlaize the variant with.</param>
        public Variant_struct_nullable_enable(object o)
            => _variant = new _VariantStorage(o);

        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        public static implicit operator Variant_struct_nullable_enable(long l)
            => new Variant_struct_nullable_enable(l);
        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        public static implicit operator Variant_struct_nullable_enable(double d)
            => new Variant_struct_nullable_enable(d);

        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        public static Variant_struct_nullable_enable Create(long l)
            => new Variant_struct_nullable_enable(l);
        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        public static Variant_struct_nullable_enable Create(double d)
            => new Variant_struct_nullable_enable(d);
        /// <summary>
        /// Create a Variant_struct_nullable_enable with a value of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The value to initlaize the variant with.</param>
        public static Variant_struct_nullable_enable Create(object o)
            => new Variant_struct_nullable_enable(o);

        /// <summary>
        /// <see langword="true"/> if Variant_struct_nullable_enable was constructed without a value.
        /// </summary>
        /// <remarks>
        /// Because Variant_struct_nullable_enable is a value type, its default constructor cannot be disabled.
        /// A default-constructed Variant_struct_nullable_enable will always have a <see cref="IsEmpty"/> value of <see langword"true"/>
        /// and never satisfy any matching attempts except for the wildcard <c>_</c> parameter.
        /// </remarks>
        public readonly bool IsEmpty
            => _variant.IsEmpty;

        public readonly override bool Equals(object? other)
            => other is Variant_struct_nullable_enable v && Equals(v);

        public readonly bool Equals(Variant_struct_nullable_enable other)
            => _variant.Equals(other._variant);

        public static bool operator ==(Variant_struct_nullable_enable lhs, Variant_struct_nullable_enable rhs)
            => lhs.Equals(rhs);

        public static bool operator !=(Variant_struct_nullable_enable lhs, Variant_struct_nullable_enable rhs)
            => !(lhs == rhs);

        public readonly override int GetHashCode()
            => _variant.GetHashCode();

        public readonly override string ToString()
            => _variant.ValueString;

        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="l">Receives the stored value if it is of type <see cref="long"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="long"/></exception>
        public readonly void Match(out long l)
        {
            if (!_variant.TryMatch(out l))
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_enable' (expected 'long', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="d">Receives the stored value if it is of type <see cref="double"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="double"/></exception>
        public readonly void Match(out double d)
        {
            if (!_variant.TryMatch(out d))
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_enable' (expected 'double', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="o">Receives the stored value if it is of type <see cref="object"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="object"/></exception>
        public readonly void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out object? o)
        {
            if (!_variant.TryMatch(out o!))
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_enable' (expected 'object', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">Receives the stored value if it is of type <see cref="long"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="long"/>.</returns>
        public readonly bool TryMatch(out long l)
            => _variant.TryMatch(out l);
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">Receives the stored value if it is of type <see cref="double"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="double"/>.</returns>
        public readonly bool TryMatch(out double d)
            => _variant.TryMatch(out d);
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">Receives the stored value if it is of type <see cref="object"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="object"/>.</returns>
        public readonly bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out object? o)
            => _variant.TryMatch(out o);

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="long"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> is rethrown.</exception>
        public readonly bool TryMatch(global::System.Action<long> l)
        {
            if (_variant.TryMatch(out long _value))
            {
                l(_value);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="double"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> is rethrown.</exception>
        public readonly bool TryMatch(global::System.Action<double> d)
        {
            if (_variant.TryMatch(out double _value))
            {
                d(_value);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_enable contained a value of type <see cref="object"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> is rethrown.</exception>
        public readonly bool TryMatch(global::System.Action<object> o)
        {
            if (_variant.TryMatch(out object? _value))
            {
                o(_value!);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="long"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> is rethrown.</exception>
        public readonly void Match(global::System.Action<long> l)
        {
            if (_variant.TryMatch(out long _value))
            {
                l(_value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_enable' (expected 'long', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="double"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> is rethrown.</exception>
        public readonly void Match(global::System.Action<double> d)
        {
            if (_variant.TryMatch(out double _value))
            {
                d(_value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_enable' (expected 'double', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="object"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> is rethrown.</exception>
        public readonly void Match(global::System.Action<object> o)
        {
            if (_variant.TryMatch(out object? _value))
            {
                o(_value!);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_enable' (expected 'object', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> or <paramref name="_"> is rethrown.</exception>
        public readonly void Match(global::System.Action<long> l, global::System.Action _)
        {
            if (_variant.TryMatch(out long _value))
            {
                l(_value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> or <paramref name="_"> is rethrown.</exception>
        public readonly void Match(global::System.Action<double> d, global::System.Action _)
        {
            if (_variant.TryMatch(out double _value))
            {
                d(_value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> or <paramref name="_"> is rethrown.</exception>
        public readonly void Match(global::System.Action<object> o, global::System.Action _)
        {
            if (_variant.TryMatch(out object? _value))
            {
                o(_value!);
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
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="long"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l)
        {
            if (_variant.TryMatch(out long _value))
            {
                return l(_value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_enable' (expected 'long', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <returns>The value returned from invoking <paramref name="d"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="double"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d)
        {
            if (_variant.TryMatch(out double _value))
            {
                return d(_value);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_enable' (expected 'double', actual '{_variant.TypeString}').");
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <returns>The value returned from invoking <paramref name="o"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_enable does not contain a value of type <see cref="object"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o)
        {
            if (_variant.TryMatch(out object? _value))
            {
                return o(_value!);
            }
            else
            {
                throw new global::System.InvalidOperationException($"Failed to match on 'Foo.Variant_struct_nullable_enable' (expected 'object', actual '{_variant.TypeString}').");
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="l"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> or <paramref name="other"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l, TResult _)
        {
            if (_variant.TryMatch(out long _value))
            {
                return l(_value);
            }
            else
            {
                return _;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="d"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> or <paramref name="other"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d, TResult _)
        {
            if (_variant.TryMatch(out double _value))
            {
                return d(_value);
            }
            else
            {
                return _;
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="o"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> or <paramref name="other"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o, TResult _)
        {
            if (_variant.TryMatch(out object? _value))
            {
                return o(_value!);
            }
            else
            {
                return _;
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="long"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> or <paramref name="_"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l, global::System.Func<TResult> _)
        {
            if (_variant.TryMatch(out long _value))
            {
                return l(_value);
            }
            else
            {
                return _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="double"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> or <paramref name="_"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d, global::System.Func<TResult> _)
        {
            if (_variant.TryMatch(out double _value))
            {
                return d(_value);
            }
            else
            {
                return _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_enable if it is of type <see cref="object"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> or <paramref name="_"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o, global::System.Func<TResult> _)
        {
            if (_variant.TryMatch(out object? _value))
            {
                return o(_value!);
            }
            else
            {
                return _();
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
        public readonly void Visit(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o)
            => _variant.Visit(l, d, o);

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_struct_nullable_enable,
        /// and invoke a special delegate if Variant_struct_nullable_enable is empty.
        /// </summary>
        /// <param name="l">The delegate to invoke if the stored value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the stored value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the stored value is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_struct_nullable_enable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public readonly void Visit(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o, global::System.Action _)
            => _variant.Visit(l, d, o, _);

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
        public readonly TResult Visit<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
            => _variant.Visit(l, d, o);

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
        public readonly TResult Visit<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o, global::System.Func<TResult> _)
            => _variant.Visit(l, d, o, _);
    }
}

namespace Foo
{
    public static partial class _Variant_struct_nullable_enable_Ex
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
                if (variant.TryMatch(out long value))
                {
                    yield return l(value);
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
                if (variant.TryMatch(out double value))
                {
                    yield return d(value);
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
                if (variant.TryMatch(out object? value))
                {
                    yield return o(value);
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
                yield return variant.Match(l, _);
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
                yield return variant.Match(d, _);
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
                yield return variant.Match(o, _);
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
                yield return variant.Match(l, _);
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
                yield return variant.Match(d, _);
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
                yield return variant.Match(o, _);
            }
        }

        /// <summary>
        /// Transform a Variant_struct_nullable_enable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException">
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
                yield return variant.Visit(l, d, o);
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
                yield return variant.Visit(l, d, o, _);
            }
        }
    }
}
