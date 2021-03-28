#nullable enable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(_VariantTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    partial class Variant_class : global::System.IEquatable<Variant_class>
    {
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        private readonly _VariantStorage _variant;

        private sealed class _VariantTypeProxy
        {
            public object? Value { get; }
            public _VariantTypeProxy(Variant_class v)
            {
                Value = v._variant.AsObject;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCode]
        private readonly struct _VariantStorage
        {
            private readonly int _n;
            private readonly Union _x;

            public _VariantStorage(int i)
            {
                _n = 1;
                _x = new Union(i);

                VariantOf(default!, default!, default!);
            }
            public _VariantStorage(float f)
            {
                _n = 2;
                _x = new Union(f);

                VariantOf(default!, default!, default!);
            }
            public _VariantStorage(string s)
            {
                _n = 3;
                _x = new Union(s);

                VariantOf(default!, default!, default!);
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

                public Union(int value)
                {
                    _2 = default;
                    _3 = default;
                    _1 = new Union1(value);
                }
                public Union(float value)
                {
                    _1 = default;
                    _3 = default;
                    _2 = new Union2(value);
                }
                public Union(string value)
                {
                    _1 = default;
                    _2 = default;
                    _3 = new Union3(value);
                }

                [global::System.Diagnostics.DebuggerNonUserCode]
                public readonly struct Union1
                {
                    public readonly int Value;
                    public readonly object? _dummy1;

                    public Union1(int value)
                    {
                        _dummy1 = default;
                        Value = value;
                    }
                }
                [global::System.Diagnostics.DebuggerNonUserCode]
                public readonly struct Union2
                {
                    public readonly float Value;
                    public readonly object? _dummy1;

                    public Union2(float value)
                    {
                        _dummy1 = default;
                        Value = value;
                    }
                }
                [global::System.Diagnostics.DebuggerNonUserCode]
                public readonly struct Union3
                {
                    public readonly string Value;

                    public Union3(string value)
                    {
                        Value = value;
                    }
                }
            }

            public bool IsEmpty=> _n == 0;

            public string TypeString
            {
                get
                {
                    switch (_n)
                    {
                        case 0: return "<empty>";
                        case 1: return "int";
                        case 2: return "float";
                        case 3: return "string";
                        default: throw new global::System.InvalidOperationException("Variant_class is in a corrupted state.");
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
                        case 3: return _x._3.Value.ToString() ?? "null";
                        default: throw new global::System.InvalidOperationException("Variant_class is in a corrupted state.");
                    }
                }
            }

            public object? AsObject
            {
                get
                {
                    switch (_n)
                    {
                        case 0: return null;
                        case 1: return _x._1.Value;
                        case 2: return _x._2.Value;
                        case 3: return _x._3.Value;
                        default: throw new global::System.InvalidOperationException("Variant_class is in a corrupted state.");
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
                    case 1: return global::System.Collections.Generic.EqualityComparer<int>.Default.Equals(_x._1.Value, other._x._1.Value);
                    case 2: return global::System.Collections.Generic.EqualityComparer<float>.Default.Equals(_x._2.Value, other._x._2.Value);
                    case 3: return global::System.Collections.Generic.EqualityComparer<string>.Default.Equals(_x._3.Value, other._x._3.Value);
                    default: throw new global::System.InvalidOperationException("Variant_class is in a corrupted state.");
                }
            }

            public readonly override int GetHashCode()
            {
                switch (_n)
                {
                    case 0: return 0;
                    case 1: return 1 + global::System.Collections.Generic.EqualityComparer<int>.Default.GetHashCode(_x._1.Value);
                    case 2: return 2 + global::System.Collections.Generic.EqualityComparer<float>.Default.GetHashCode(_x._2.Value);
                    case 3: return 3 + global::System.Collections.Generic.EqualityComparer<string>.Default.GetHashCode(_x._3.Value);
                    default: throw new global::System.InvalidOperationException("Variant_class is in a corrupted state.");
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
            public bool TryMatch(out string? s)
            {
                s = _n == 3 ? _x._3.Value : default;
                return _n == 3;
            }

            public void Match(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action _)
            {
                switch (_n)
                {
                    case 0: _(); break;
                    case 1: i(_x._1.Value); break;
                    case 2: f(_x._2.Value); break;
                    case 3: s(_x._3.Value); break;
                    default: throw new global::System.InvalidOperationException("Variant_class is in a corrupted state.");
                }
            }

            public void Match(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s)
            {
                switch (_n)
                {
                    case 0: throw new global::System.InvalidOperationException("Variant_class is empty.");
                    case 1: i(_x._1.Value); break;
                    case 2: f(_x._2.Value); break;
                    case 3: s(_x._3.Value); break;
                    default: throw new global::System.InvalidOperationException("Variant_class is in a corrupted state.");
                }
            }

            public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<TResult> _)
            {
                switch (_n)
                {
                    case 0: return _();
                    case 1: return i(_x._1.Value);
                    case 2: return f(_x._2.Value);
                    case 3: return s(_x._3.Value);
                    default: throw new global::System.InvalidOperationException("Variant_class is in a corrupted state.");
                }
            }

            public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s)
            {
                switch (_n)
                {
                    case 0: throw new global::System.InvalidOperationException("Variant_class is empty.");
                    case 1: return i(_x._1.Value);
                    case 2: return f(_x._2.Value);
                    case 3: return s(_x._3.Value);
                    default: throw new global::System.InvalidOperationException("Variant_class is in a corrupted state.");
                }
            }
        }

        /// <summary>
        /// Create a variant with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public Variant_class(int i) => _variant = new _VariantStorage(i);
        /// <summary>
        /// Create a variant with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        public Variant_class(float f) => _variant = new _VariantStorage(f);
        /// <summary>
        /// Create a variant with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        public Variant_class(string s) => _variant = new _VariantStorage(s);

        /// <summary>
        /// Create a variant with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public static implicit operator Variant_class(int i) => new Variant_class(i);
        /// <summary>
        /// Create a variant with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        public static implicit operator Variant_class(float f) => new Variant_class(f);
        /// <summary>
        /// Create a variant with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        public static implicit operator Variant_class(string s) => new Variant_class(s);

        /// <summary>
        /// Create a variant with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        public static Variant_class Create(int i) => new Variant_class(i);
        /// <summary>
        /// Create a variant with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        public static Variant_class Create(float f) => new Variant_class(f);
        /// <summary>
        /// Create a variant with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        public static Variant_class Create(string s) => new Variant_class(s);

        /// <summary>
        /// <see langword="true"/> if Variant_class was constructed without a value.
        /// </summary>
        public  bool IsEmpty => _variant.IsEmpty;

        public  override bool Equals(object? other) => other is Variant_class v && Equals(v);
        public  bool Equals(Variant_class? other) =>
            other != null &&
            _variant.Equals(other._variant);

        public static bool operator ==( Variant_class? lhs,  Variant_class? rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        public static bool operator !=( Variant_class? lhs,  Variant_class? rhs)
            => !(lhs == rhs);

        public  override int GetHashCode() => _variant.GetHashCode();

        public  override string ToString() => _variant.ValueString;

        /// <summary>
        /// Retrieve the value stored within Variant_class if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_class does not contain a value of type <see cref="int"/></exception>
        public  void Match(out int i)
        {
            if(!_variant.TryMatch(out i))
            {
                throw new dotVariant.TypeMismatchException(expected: "int", actual: _variant.TypeString);
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class if it is of type <see cref="float"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="f">Receives the stored value if it is of type <see cref="float"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_class does not contain a value of type <see cref="float"/></exception>
        public  void Match(out float f)
        {
            if(!_variant.TryMatch(out f))
            {
                throw new dotVariant.TypeMismatchException(expected: "float", actual: _variant.TypeString);
            }
        }
        /// <summary>
        /// Retrieve the value stored within Variant_class if it is of type <see cref="string"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="s">Receives the stored value if it is of type <see cref="string"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_class does not contain a value of type <see cref="string"/></exception>
        public  void Match(out string s)
        {
            if(!_variant.TryMatch(out s!))
            {
                throw new dotVariant.TypeMismatchException(expected: "string", actual: _variant.TypeString);
            }
        }

        /// <summary>
        /// Retrieve the value stored within Variant_class if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_class contained a value of type <see cref="int"/>.</returns>
        public  bool TryMatch(out int i)
            => _variant.TryMatch(out i);
        /// <summary>
        /// Retrieve the value stored within Variant_class if it is of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">Receives the stored value if it is of type <see cref="float"/>.</param>
        /// <returns><see langword="true"/> if Variant_class contained a value of type <see cref="float"/>.</returns>
        public  bool TryMatch(out float f)
            => _variant.TryMatch(out f);
        /// <summary>
        /// Retrieve the value stored within Variant_class if it is of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">Receives the stored value if it is of type <see cref="string"/>.</param>
        /// <returns><see langword="true"/> if Variant_class contained a value of type <see cref="string"/>.</returns>
        public  bool TryMatch(out string? s)
            => _variant.TryMatch(out s);

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_class contained a value of type <see cref="int"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public  bool TryMatch(global::System.Action<int> i)
        {
            var result = _variant.TryMatch(out int _value);
            if(result)
            {
                i(_value);
            }
            return result;
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <returns><see langword="true"/> if Variant_class contained a value of type <see cref="float"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> is rethrown.</exception>
        public  bool TryMatch(global::System.Action<float> f)
        {
            var result = _variant.TryMatch(out float _value);
            if(result)
            {
                f(_value);
            }
            return result;
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <returns><see langword="true"/> if Variant_class contained a value of type <see cref="string"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> is rethrown.</exception>
        public  bool TryMatch(global::System.Action<string> s)
        {
            var result = _variant.TryMatch(out string? _value);
            if(result)
            {
                s(_value!);
            }
            return result;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_class does not contain a value of type <see cref="int"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public  void Match(global::System.Action<int> i)
        {
            if(_variant.TryMatch(out int _value))
            {
                i(_value);
            }
            else
            {
                throw new dotVariant.TypeMismatchException(expected: "int", actual: _variant.TypeString);
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="float"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_class does not contain a value of type <see cref="float"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> is rethrown.</exception>
        public  void Match(global::System.Action<float> f)
        {
            if(_variant.TryMatch(out float _value))
            {
                f(_value);
            }
            else
            {
                throw new dotVariant.TypeMismatchException(expected: "float", actual: _variant.TypeString);
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="string"/>,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_class does not contain a value of type <see cref="string"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> is rethrown.</exception>
        public  void Match(global::System.Action<string> s)
        {
            if(_variant.TryMatch(out string? _value))
            {
                s(_value!);
            }
            else
            {
                throw new dotVariant.TypeMismatchException(expected: "string", actual: _variant.TypeString);
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="int"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="_"> is rethrown.</exception>
        public  void Match(global::System.Action<int> i, global::System.Action _)
        {
            if(_variant.TryMatch(out int _value))
            {
                i(_value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="float"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> or <paramref name="_"> is rethrown.</exception>
        public  void Match(global::System.Action<float> f, global::System.Action _)
        {
            if(_variant.TryMatch(out float _value))
            {
                f(_value);
            }
            else
            {
                _();
            }
        }
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="string"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> or <paramref name="_"> is rethrown.</exception>
        public  void Match(global::System.Action<string> s, global::System.Action _)
        {
            if(_variant.TryMatch(out string? _value))
            {
                s(_value!);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="int"/> and return the result,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>.</returns>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_class does not contain a value of type <see cref="int"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> is rethrown.</exception>
        public  TResult Match<TResult>(global::System.Func<int, TResult> i)
            => _variant.TryMatch(out int _value) ? i(_value) : throw new dotVariant.TypeMismatchException(expected: "int", actual: _variant.TypeString);
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="float"/> and return the result,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <returns>The value returned from invoking <paramref name="f"/>.</returns>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_class does not contain a value of type <see cref="float"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> is rethrown.</exception>
        public  TResult Match<TResult>(global::System.Func<float, TResult> f)
            => _variant.TryMatch(out float _value) ? f(_value) : throw new dotVariant.TypeMismatchException(expected: "float", actual: _variant.TypeString);
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="string"/> and return the result,
        /// otherwise throw <see cref="dotVariant.TypeMismatchException"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <returns>The value returned from invoking <paramref name="s"/>.</returns>
        /// <exception cref="dotVariant.TypeMismatchException">Variant_class does not contain a value of type <see cref="string"/></exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> is rethrown.</exception>
        public  TResult Match<TResult>(global::System.Func<string, TResult> s)
            => _variant.TryMatch(out string? _value) ? s(_value!) : throw new dotVariant.TypeMismatchException(expected: "string", actual: _variant.TypeString);

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="int"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="other"> is rethrown.</exception>
        public  TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
            => _variant.TryMatch(out int _value) ? i(_value) : _;
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="float"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="f"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> or <paramref name="other"> is rethrown.</exception>
        public  TResult Match<TResult>(global::System.Func<float, TResult> f, TResult _)
            => _variant.TryMatch(out float _value) ? f(_value) : _;
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="string"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="s"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> or <paramref name="other"> is rethrown.</exception>
        public  TResult Match<TResult>(global::System.Func<string, TResult> s, TResult _)
            => _variant.TryMatch(out string? _value) ? s(_value!) : _;

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="int"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"> or <paramref name="_"> is rethrown.</exception>
        public  TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<TResult> _)
            => _variant.TryMatch(out int _value) ? i(_value) : _();
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="float"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"> or <paramref name="_"> is rethrown.</exception>
        public  TResult Match<TResult>(global::System.Func<float, TResult> f, global::System.Func<TResult> _)
            => _variant.TryMatch(out float _value) ? f(_value) : _();
        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class if it is of type <see cref="string"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"> or <paramref name="_"> is rethrown.</exception>
        public  TResult Match<TResult>(global::System.Func<string, TResult> s, global::System.Func<TResult> _)
            => _variant.TryMatch(out string? _value) ? s(_value!) : _();

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_class,
        /// and throw an exception if Variant_class is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public  void Match(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s)
            => _variant.Match(i, f, s);

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_class,
        /// and invoke a special delegate if Variant_class is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_class is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public  void Match(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action _)
            => _variant.Match(i, f, s, _);

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_class and return the result,
        /// and throw an exception if Variant_class is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public  TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s)
            => _variant.Match(i, f, s);

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_class and return the result,
        /// and invoke a special delegate if Variant_class is empty and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_class is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public  TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<TResult> _)
            => _variant.Match(i, f, s, _);

    }
}
