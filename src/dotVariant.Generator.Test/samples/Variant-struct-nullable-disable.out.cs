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
    partial struct Variant_struct_nullable_disable : global::System.IEquatable<Variant_struct_nullable_disable>
    {
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly _VariantStorage _variant;

        private sealed class _VariantTypeProxy
        {
            public object Value { get; }
            public _VariantTypeProxy(Variant_struct_nullable_disable v)
            {
                Value = v._variant.AsObject;
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
                VariantOf(default, default, default);
            }
            public _VariantStorage(double d)
            {
                _n = 2;
                _x = new Union(d);
                VariantOf(default, default, default);
            }
            public _VariantStorage(object o)
            {
                _n = 3;
                _x = new Union(o);
                VariantOf(default, default, default);
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
                        _dummy1 = null;
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
                        _dummy1 = null;
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
                        case 0: return "<empty>";
                        case 1: return "long";
                        case 2: return "double";
                        case 3: return "object";
                        default: throw new global::System.InvalidOperationException("Variant_struct_nullable_disable is in a corrupted state.");
                    }
                }
            }

            public string ValueString
            {
                get
                {
                    switch (_n)
                    {
                        case 0: return "<empty>";
                        case 1: return _x._1.Value.ToString();
                        case 2: return _x._2.Value.ToString();
                        case 3: return _x._3.Value?.ToString() ?? "null";
                        default: throw new global::System.InvalidOperationException("Variant_struct_nullable_disable is in a corrupted state.");
                    }
                }
            }

            public object AsObject
            {
                get
                {
                    switch (_n)
                    {
                        case 0: return null;
                        case 1: return _x._1.Value;
                        case 2: return _x._2.Value;
                        case 3: return _x._3.Value;
                        default: throw new global::System.InvalidOperationException("Variant_struct_nullable_disable is in a corrupted state.");
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
                    case 0: return true;
                    case 1: return global::System.Collections.Generic.EqualityComparer<long>.Default.Equals(_x._1.Value, other._x._1.Value);
                    case 2: return global::System.Collections.Generic.EqualityComparer<double>.Default.Equals(_x._2.Value, other._x._2.Value);
                    case 3: return global::System.Collections.Generic.EqualityComparer<object>.Default.Equals(_x._3.Value, other._x._3.Value);
                    default: throw new global::System.InvalidOperationException("Variant_struct_nullable_disable is in a corrupted state.");
                }
            }

            public readonly override int GetHashCode()
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
                            throw new global::System.InvalidOperationException("Variant_struct_nullable_disable is in a corrupted state.");
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
            public bool TryMatch(out object o)
            {
                o = _n == 3 ? _x._3.Value : default;
                return _n == 3;
            }

            public void Match(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o, global::System.Action _)
            {
                switch (_n)
                {
                    case 0: _(); break;
                    case 1: l(_x._1.Value); break;
                    case 2: d(_x._2.Value); break;
                    case 3: o(_x._3.Value); break;
                    default: throw new global::System.InvalidOperationException("Variant_struct_nullable_disable is in a corrupted state.");
                }
            }

            public void Match(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o)
            {
                switch (_n)
                {
                    case 0: throw new global::System.InvalidOperationException("Variant_struct_nullable_disable is empty.");
                    case 1: l(_x._1.Value); break;
                    case 2: d(_x._2.Value); break;
                    case 3: o(_x._3.Value); break;
                    default: throw new global::System.InvalidOperationException("Variant_struct_nullable_disable is in a corrupted state.");
                }
            }

            public TResult Match<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o, global::System.Func<TResult> _)
            {
                switch (_n)
                {
                    case 0: return _();
                    case 1: return l(_x._1.Value);
                    case 2: return d(_x._2.Value);
                    case 3: return o(_x._3.Value);
                    default: throw new global::System.InvalidOperationException("Variant_struct_nullable_disable is in a corrupted state.");
                }
            }

            public TResult Match<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
            {
                switch (_n)
                {
                    case 0: throw new global::System.InvalidOperationException("Variant_struct_nullable_disable is empty.");
                    case 1: return l(_x._1.Value);
                    case 2: return d(_x._2.Value);
                    case 3: return o(_x._3.Value);
                    default: throw new global::System.InvalidOperationException("Variant_struct_nullable_disable is in a corrupted state.");
                }
            }
        }

        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        public Variant_struct_nullable_disable(long l) => _variant = new _VariantStorage(l);
        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        public Variant_struct_nullable_disable(double d) => _variant = new _VariantStorage(d);
        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The value to initlaize the variant with.</param>
        public Variant_struct_nullable_disable(object o) => _variant = new _VariantStorage(o);

        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        public static implicit operator Variant_struct_nullable_disable(long l) => new Variant_struct_nullable_disable(l);
        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        public static implicit operator Variant_struct_nullable_disable(double d) => new Variant_struct_nullable_disable(d);

        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The value to initlaize the variant with.</param>
        public static Variant_struct_nullable_disable Create(long l) => new Variant_struct_nullable_disable(l);
        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The value to initlaize the variant with.</param>
        public static Variant_struct_nullable_disable Create(double d) => new Variant_struct_nullable_disable(d);
        /// <summary>
        /// Create a Variant_struct_nullable_disable with a value of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The value to initlaize the variant with.</param>
        public static Variant_struct_nullable_disable Create(object o) => new Variant_struct_nullable_disable(o);

        /// <summary>
        /// <see langword="true"/> if Variant_struct_nullable_disable was constructed without a value.
        /// </summary>
        /// <remarks>
        /// Because Variant_struct_nullable_disable is a value type, its default constructor cannot be disabled.
        /// A default-constructed Variant_struct_nullable_disable will always have a <see cref="IsEmpty"/> value of <see langword"true"/>
        /// and never satisfy any matching attempts except for the wildcard <c>_</c> parameter.
        /// </remarks>
        public readonly bool IsEmpty => _variant.IsEmpty;

        public readonly override bool Equals(object other) => other is Variant_struct_nullable_disable v && Equals(v);
        public readonly bool Equals(Variant_struct_nullable_disable other)
            => _variant.Equals(other._variant);

        public static bool operator ==(Variant_struct_nullable_disable lhs, Variant_struct_nullable_disable rhs)
            => lhs.Equals(rhs);

        public static bool operator !=(Variant_struct_nullable_disable lhs, Variant_struct_nullable_disable rhs)
            => !(lhs == rhs);

        public readonly override int GetHashCode() => _variant.GetHashCode();

        public readonly override string ToString() => _variant.ValueString;

        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="l">Receives the stored value if it is of type <see cref="long"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_struct_nullable_disable does not contain a value of type <see cref="long"/></exception>
        public readonly void Match(out long l)
        {
            if (!_variant.TryMatch(out l))
            {
                throw new dotVariant.TypeMismatchException(expected: "long", actual: _variant.TypeString);
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="d">Receives the stored value if it is of type <see cref="double"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_struct_nullable_disable does not contain a value of type <see cref="double"/></exception>
        public readonly void Match(out double d)
        {
            if (!_variant.TryMatch(out d))
            {
                throw new dotVariant.TypeMismatchException(expected: "double", actual: _variant.TypeString);
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="o">Receives the stored value if it is of type <see cref="object"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_struct_nullable_disable does not contain a value of type <see cref="object"/></exception>
        public readonly void Match(out object o)
        {
            if (!_variant.TryMatch(out o))
            {
                throw new dotVariant.TypeMismatchException(expected: "object", actual: _variant.TypeString);
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">Receives the stored value if it is of type <see cref="long"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="long"/>.</returns>
        public readonly bool TryMatch(out long l)
            => _variant.TryMatch(out l);
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">Receives the stored value if it is of type <see cref="double"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="double"/>.</returns>
        public readonly bool TryMatch(out double d)
            => _variant.TryMatch(out d);
        /// <summary>
        /// Retrieve the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">Receives the stored value if it is of type <see cref="object"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="object"/>.</returns>
        public readonly bool TryMatch(out object o)
            => _variant.TryMatch(out o);

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/>.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="long"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> is rethrown.</exception>
        public readonly bool TryMatch(global::System.Action<long> l)
        {
            bool result = _variant.TryMatch(out long _value);
            if (result)
            {
                l(_value);
            }
            return result;
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="double"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> is rethrown.</exception>
        public readonly bool TryMatch(global::System.Action<double> d)
        {
            bool result = _variant.TryMatch(out double _value);
            if (result)
            {
                d(_value);
            }
            return result;
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <returns><see langword="true"/> if Variant_struct_nullable_disable contained a value of type <see cref="object"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> is rethrown.</exception>
        public readonly bool TryMatch(global::System.Action<object> o)
        {
            bool result = _variant.TryMatch(out object _value);
            if (result)
            {
                o(_value);
            }
            return result;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_struct_nullable_disable does not contain a value of type <see cref="long"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> is rethrown.</exception>
        public readonly void Match(global::System.Action<long> l)
        {
            if (_variant.TryMatch(out long _value))
            {
                l(_value);
            }
            else
            {
                throw new dotVariant.TypeMismatchException(expected: "long", actual: _variant.TypeString);
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_struct_nullable_disable does not contain a value of type <see cref="double"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> is rethrown.</exception>
        public readonly void Match(global::System.Action<double> d)
        {
            if (_variant.TryMatch(out double _value))
            {
                d(_value);
            }
            else
            {
                throw new dotVariant.TypeMismatchException(expected: "double", actual: _variant.TypeString);
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_struct_nullable_disable does not contain a value of type <see cref="object"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> is rethrown.</exception>
        public readonly void Match(global::System.Action<object> o)
        {
            if (_variant.TryMatch(out object _value))
            {
                o(_value);
            }
            else
            {
                throw new dotVariant.TypeMismatchException(expected: "object", actual: _variant.TypeString);
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
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/>,
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
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> or <paramref name="_"> is rethrown.</exception>
        public readonly void Match(global::System.Action<object> o, global::System.Action _)
        {
            if (_variant.TryMatch(out object _value))
            {
                o(_value);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/> and return the result,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <returns>The value returned from invoking <paramref name="l"/>.</returns>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_struct_nullable_disable does not contain a value of type <see cref="long"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l)
            => _variant.TryMatch(out long _value) ? l(_value) : throw new dotVariant.TypeMismatchException(expected: "long", actual: _variant.TypeString);
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/> and return the result,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <returns>The value returned from invoking <paramref name="d"/>.</returns>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_struct_nullable_disable does not contain a value of type <see cref="double"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d)
            => _variant.TryMatch(out double _value) ? d(_value) : throw new dotVariant.TypeMismatchException(expected: "double", actual: _variant.TypeString);
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/> and return the result,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <returns>The value returned from invoking <paramref name="o"/>.</returns>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_struct_nullable_disable does not contain a value of type <see cref="object"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o)
            => _variant.TryMatch(out object _value) ? o(_value) : throw new dotVariant.TypeMismatchException(expected: "object", actual: _variant.TypeString);

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="l"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> or <paramref name="other"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l, TResult _)
            => _variant.TryMatch(out long _value) ? l(_value) : _;
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="d"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> or <paramref name="other"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d, TResult _)
            => _variant.TryMatch(out double _value) ? d(_value) : _;
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="o"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> or <paramref name="other"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o, TResult _)
            => _variant.TryMatch(out object _value) ? o(_value) : _;

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="long"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="l">The delegate to invoke with the stored value if it is of type <see cref="long"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="l"> or <paramref name="_"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l, global::System.Func<TResult> _)
            => _variant.TryMatch(out long _value) ? l(_value) : _();
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="double"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="d">The delegate to invoke with the stored value if it is of type <see cref="double"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="d"> or <paramref name="_"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<double, TResult> d, global::System.Func<TResult> _)
            => _variant.TryMatch(out double _value) ? d(_value) : _();
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_struct_nullable_disable if it is of type <see cref="object"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="o">The delegate to invoke with the stored value if it is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="o"> or <paramref name="_"> is rethrown.</exception>
        public readonly TResult Match<TResult>(global::System.Func<object, TResult> o, global::System.Func<TResult> _)
            => _variant.TryMatch(out object _value) ? o(_value) : _();

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_struct_nullable_disable,
        /// and throw an exception if Variant_struct_nullable_disable is empty.
        /// </summary>
        /// <param name="l">The delegate to invoke if the stored value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the stored value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the stored value is of type <see cref="object"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_struct_nullable_disable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public readonly void Match(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o)
            => _variant.Match(l, d, o);

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_struct_nullable_disable,
        /// and invoke a special delegate if Variant_struct_nullable_disable is empty.
        /// </summary>
        /// <param name="l">The delegate to invoke if the stored value is of type <see cref="long"/>.</param>
        /// <param name="d">The delegate to invoke if the stored value is of type <see cref="double"/>.</param>
        /// <param name="o">The delegate to invoke if the stored value is of type <see cref="object"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_struct_nullable_disable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public readonly void Match(global::System.Action<long> l, global::System.Action<double> d, global::System.Action<object> o, global::System.Action _)
            => _variant.Match(l, d, o, _);

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
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o)
            => _variant.Match(l, d, o);

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
        public readonly TResult Match<TResult>(global::System.Func<long, TResult> l, global::System.Func<double, TResult> d, global::System.Func<object, TResult> o, global::System.Func<TResult> _)
            => _variant.Match(l, d, o, _);

    }
}
