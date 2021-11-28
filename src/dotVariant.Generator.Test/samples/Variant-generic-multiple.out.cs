//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable enable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(Variant<,,>.__DebuggerTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    partial class Variant<T1, T2, T3>
        : global::System.IEquatable<Variant<T1, T2, T3>>
        , global::System.IDisposable
    {
        private readonly global::dotVariant._G.Foo.Variant<T1, T2, T3> _variant;

        /// <summary>
        /// Create a Variant with a value of type <see cref="T1"/>.
        /// </summary>
        /// <param name="a">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant(T1 a)
            => _variant = new global::dotVariant._G.Foo.Variant<T1, T2, T3>(a);
        /// <summary>
        /// Create a Variant with a value of type <see cref="T2"/>.
        /// </summary>
        /// <param name="b">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant(T2 b)
            => _variant = new global::dotVariant._G.Foo.Variant<T1, T2, T3>(b);
        /// <summary>
        /// Create a Variant with a value of type <see cref="T3"/>.
        /// </summary>
        /// <param name="c">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant(T3 c)
            => _variant = new global::dotVariant._G.Foo.Variant<T1, T2, T3>(c);

        /// <summary>
        /// Create a Variant with a value of type <see cref="T1"/>.
        /// </summary>
        /// <param name="a">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant<T1, T2, T3>(T1 a)
            => new Variant<T1, T2, T3>(a);
        /// <summary>
        /// Create a Variant with a value of type <see cref="T2"/>.
        /// </summary>
        /// <param name="b">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant<T1, T2, T3>(T2 b)
            => new Variant<T1, T2, T3>(b);
        /// <summary>
        /// Create a Variant with a value of type <see cref="T3"/>.
        /// </summary>
        /// <param name="c">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant<T1, T2, T3>(T3 c)
            => new Variant<T1, T2, T3>(c);

        /// <summary>
        /// Create a Variant with a value of type <see cref="T1"/>.
        /// </summary>
        /// <param name="a">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant<T1, T2, T3> Create(T1 a)
            => new Variant<T1, T2, T3>(a);
        /// <summary>
        /// Create a Variant with a value of type <see cref="T2"/>.
        /// </summary>
        /// <param name="b">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant<T1, T2, T3> Create(T2 b)
            => new Variant<T1, T2, T3>(b);
        /// <summary>
        /// Create a Variant with a value of type <see cref="T3"/>.
        /// </summary>
        /// <param name="c">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant<T1, T2, T3> Create(T3 c)
            => new Variant<T1, T2, T3>(c);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Dispose()"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Dispose()
        {
            _variant.Dispose();
        }

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.IsEmpty"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool IsEmpty
            => _variant.IsEmpty;

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Index"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public byte Index
            => _variant.Index;

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object? other)
            => other is Variant<T1, T2, T3> v
            && Equals(v);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(Variant<T1, T2, T3>? other)
            => !(other is null) && _variant.Equals(other._variant);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator ==(Variant<T1, T2, T3>? lhs, Variant<T1, T2, T3>? rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator !=(Variant<T1, T2, T3>? lhs, Variant<T1, T2, T3>? rhs)
            => !(lhs == rhs);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override int GetHashCode()
            => _variant.GetHashCode();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override string ToString()
            => _variant.ToString();

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.UnsafeGet(global::dotVariant.Accessor._1)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public T1 UnsafeGet(global::dotVariant.Accessor._1 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.TryMatch(out T1?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? a)
            => _variant.TryMatch(out a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.TryMatch(global::System.Action{T1})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<T1> a)
            => _variant.TryMatch(a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match(out T1?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out T1? a)
            => _variant.Match(out a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match(global::System.Action{T1})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T1> a)
            => _variant.Match(a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match(global::System.Action{T1}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T1> a, global::System.Action _)
            => _variant.Match(a, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match{TResult}(global::System.Func{T1, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T1, TResult> a)
            => _variant.Match(a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match{TResult}(global::System.Func{T1, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T1, TResult> a, TResult _)
            => _variant.Match(a, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match{TResult}(global::System.Func{T1, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T1, TResult> a, global::System.Func<TResult> _)
            => _variant.Match(a, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.UnsafeGet(global::dotVariant.Accessor._2)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public T2 UnsafeGet(global::dotVariant.Accessor._2 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.TryMatch(out T2?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? b)
            => _variant.TryMatch(out b);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.TryMatch(global::System.Action{T2})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<T2> b)
            => _variant.TryMatch(b);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match(out T2?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out T2? b)
            => _variant.Match(out b);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match(global::System.Action{T2})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T2> b)
            => _variant.Match(b);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match(global::System.Action{T2}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T2> b, global::System.Action _)
            => _variant.Match(b, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match{TResult}(global::System.Func{T2, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T2, TResult> b)
            => _variant.Match(b);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match{TResult}(global::System.Func{T2, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T2, TResult> b, TResult _)
            => _variant.Match(b, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match{TResult}(global::System.Func{T2, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T2, TResult> b, global::System.Func<TResult> _)
            => _variant.Match(b, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.UnsafeGet(global::dotVariant.Accessor._3)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public T3 UnsafeGet(global::dotVariant.Accessor._3 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.TryMatch(out T3)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3 c)
            => _variant.TryMatch(out c);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.TryMatch(global::System.Action{T3})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<T3> c)
            => _variant.TryMatch(c);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match(out T3)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out T3 c)
            => _variant.Match(out c);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match(global::System.Action{T3})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T3> c)
            => _variant.Match(c);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match(global::System.Action{T3}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<T3> c, global::System.Action _)
            => _variant.Match(c, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match{TResult}(global::System.Func{T3, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T3, TResult> c)
            => _variant.Match(c);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match{TResult}(global::System.Func{T3, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T3, TResult> c, TResult _)
            => _variant.Match(c, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Match{TResult}(global::System.Func{T3, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<T3, TResult> c, global::System.Func<TResult> _)
            => _variant.Match(c, _);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Visit(global::System.Action{T1}, global::System.Action{T2}, global::System.Action{T3})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<T1> a, global::System.Action<T2> b, global::System.Action<T3> c)
            => _variant.Visit(a, b, c);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Visit(global::System.Action{T1}, global::System.Action{T2}, global::System.Action{T3}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<T1> a, global::System.Action<T2> b, global::System.Action<T3> c, global::System.Action _)
            => _variant.Visit(a, b, c, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Visit{TResult}(global::System.Func{T1, TResult}, global::System.Func{T2, TResult}, global::System.Func{T3, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<T1, TResult> a, global::System.Func<T2, TResult> b, global::System.Func<T3, TResult> c)
            => _variant.Visit(a, b, c);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant{T1, T2, T3}.Visit{TResult}(global::System.Func{T1, TResult}, global::System.Func{T2, TResult}, global::System.Func{T3, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<T1, TResult> a, global::System.Func<T2, TResult> b, global::System.Func<T3, TResult> c, global::System.Func<TResult> _)
            => _variant.Visit(a, b, c, _);

        private sealed class __DebuggerTypeProxy
        {
            public object? Value { get; }
            public __DebuggerTypeProxy(Variant<T1, T2, T3> v)
            {
                Value = v._variant.AsObject;
                #pragma warning disable 8604 // Possible null reference argument for parameter
                #pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type
                VariantOf(default, default, default);
                #pragma warning restore 8604, 8625
            }
        }
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    [global::System.Diagnostics.DebuggerDisplay("{AsObject}", Type = "{TypeString,nq}")]
    internal readonly struct Variant<T1, T2, T3>
        : global::System.IDisposable
        where T1 : class, global::System.IDisposable
        where T2 : notnull
        where T3 : struct
    {
        private readonly struct Union
        {
            public readonly T1 _1;
            public Union(T1 value)
            {
                _2 = default!;
                _3 = default!;
                _1 = value;
            }
            public readonly T2 _2;
            public Union(T2 value)
            {
                _1 = default!;
                _3 = default!;
                _2 = value;
            }
            public readonly T3 _3;
            public Union(T3 value)
            {
                _1 = default!;
                _2 = default!;
                _3 = value;
            }
        }

        private readonly Union _x;

        /// <summary>
        /// The 1-based index of the currently stored type,
        /// counted left-ro-right from the <see cref="global::Foo.Variant{T1, T2, T3}.VariantOf()"/> parameter list.
        /// <c>0</c> if the variant is empty.
        /// </summary>
        public readonly byte Index;

        public Variant(T1 a)
        {
            Index = 1;
            _x = new Union(a);
        }
        public Variant(T2 b)
        {
            Index = 2;
            _x = new Union(b);
        }
        public Variant(T3 c)
        {
            Index = 3;
            _x = new Union(c);
        }

        /// <summary>
        /// If the stored value implements <see cref="global::System.IDisposable"/>,
        /// call its <see cref="global::System.IDisposable.Dispose()"/> method.
        /// </summary>
        public void Dispose()
        {
            switch (this.Index)
            {
                case 0:
                    break;
                case 1:
                    _x._1.Dispose();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T1, T2, T3>");
                    break;
            }
        }

        /// <summary>
        /// <see langword="true"/> if Variant was constructed without a value.
        /// </summary>
        public bool IsEmpty => this.Index == 0;

        /// <summary>
        /// The string representation of the stored value's type.
        /// </summary>
        public string TypeString
        {
            get
            {
                switch (this.Index)
                {
                    case 0:
                        return "<empty>";
                    case 1:
                        return "T1";
                    case 2:
                        return "T2";
                    case 3:
                        return "T3";
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant<T1, T2, T3>");
                }
            }
        }

        /// <summary>
        /// The stored value's <see cref="object.ToString()"/> result, or <c>""</c> if empty.
        /// </summary>
        public override string ToString()
        {
            switch (this.Index)
            {
                case 0:
                    return "";
                case 1:
                    return _x._1.ToString() ?? "null";
                case 2:
                    return _x._2.ToString() ?? "null";
                case 3:
                    return _x._3.ToString() ?? "null";
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant<T1, T2, T3>");
            }
        }

        /// <summary>
        /// The stored value cast to type <see cref="object"/>.
        /// </summary>
        public object? AsObject
        {
            get
            {
                switch (this.Index)
                {
                    case 0:
                        return null;
                    case 1:
                        return _x._1;
                    case 2:
                        return _x._2;
                    case 3:
                        return _x._3;
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<object?>("Foo.Variant<T1, T2, T3>");
                }
            }
        }

        public bool Equals(in Variant<T1, T2, T3> other)
        {
            if (this.Index != other.Index)
            {
                return false;
            }
            switch (Index)
            {
                case 0:
                    return true;
                case 1:
                    return global::System.Collections.Generic.EqualityComparer<T1>.Default.Equals(_x._1, other._x._1);
                case 2:
                    return global::System.Collections.Generic.EqualityComparer<T2>.Default.Equals(_x._2, other._x._2);
                case 3:
                    return global::System.Collections.Generic.EqualityComparer<T3>.Default.Equals(_x._3, other._x._3);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<bool>("Foo.Variant<T1, T2, T3>");
            }
        }

        public override int GetHashCode()
        {
            switch (this.Index)
            {
                case 0:
                    return 0;
                case 1:
                    return global::System.HashCode.Combine(_x._1);
                case 2:
                    return global::System.HashCode.Combine(_x._2);
                case 3:
                    return global::System.HashCode.Combine(_x._3);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<int>("Foo.Variant<T1, T2, T3>");
            }
        }

        /// <summary>
        /// Retrieve the stored value assuming it is of type <see cref="T1"/>.
        ///
        /// <b>Only call this if you have ensured that <c>Index == 1</c>,
        /// otherwise the correctness of the returned value is not guaranteed,
        /// nor that any value is returned at all.</b>
        /// </summary>
        public T1 UnsafeGet(global::dotVariant.Accessor._1 _)
            => _x._1;

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T1"/>.
        /// </summary>
        /// <param name="a">Receives the stored value if it is of type <see cref="T1"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T1"/>.</returns>
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T1? a)
        {
            a = this.Index == 1 ? _x._1 : default;
            return this.Index == 1;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/>.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T1"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<T1> a)
        {
            if (this.Index == 1)
            {
                a(_x._1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T1"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="a">Receives the stored value if it is of type <see cref="T1"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T1"/>.</exception>
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out T1? a)
        {
            if (this.Index == 1)
            {
                a = _x._1;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant<T1, T2, T3>", "T1", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T1"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"/> is rethrown.</exception>
        public void Match(global::System.Action<T1> a)
        {
            if (this.Index == 1)
            {
                a(_x._1);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant<T1, T2, T3>", "T1", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<T1> a, global::System.Action _)
        {
            if (this.Index == 1)
            {
                a(_x._1);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <returns>The value returned from invoking <paramref name="a"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T1"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T1, TResult> a)
        {
            if (this.Index == 1)
            {
                return a(_x._1);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant<T1, T2, T3>", "T1", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="a"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T1, TResult> a, TResult _)
        {
            return this.Index == 1 ? a(_x._1) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T1"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="T1"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T1, TResult> a, global::System.Func<TResult> _)
        {
            return this.Index == 1 ? a(_x._1) : _();
        }
        /// <summary>
        /// Retrieve the stored value assuming it is of type <see cref="T2"/>.
        ///
        /// <b>Only call this if you have ensured that <c>Index == 2</c>,
        /// otherwise the correctness of the returned value is not guaranteed,
        /// nor that any value is returned at all.</b>
        /// </summary>
        public T2 UnsafeGet(global::dotVariant.Accessor._2 _)
            => _x._2;

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T2"/>.
        /// </summary>
        /// <param name="b">Receives the stored value if it is of type <see cref="T2"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T2"/>.</returns>
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T2? b)
        {
            b = this.Index == 2 ? _x._2 : default;
            return this.Index == 2;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/>.
        /// </summary>
        /// <param name="b">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T2"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="b"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<T2> b)
        {
            if (this.Index == 2)
            {
                b(_x._2);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T2"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="b">Receives the stored value if it is of type <see cref="T2"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T2"/>.</exception>
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out T2? b)
        {
            if (this.Index == 2)
            {
                b = _x._2;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant<T1, T2, T3>", "T2", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="b">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T2"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="b"/> is rethrown.</exception>
        public void Match(global::System.Action<T2> b)
        {
            if (this.Index == 2)
            {
                b(_x._2);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant<T1, T2, T3>", "T2", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="b">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="b"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<T2> b, global::System.Action _)
        {
            if (this.Index == 2)
            {
                b(_x._2);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="b">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <returns>The value returned from invoking <paramref name="b"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T2"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="b"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T2, TResult> b)
        {
            if (this.Index == 2)
            {
                return b(_x._2);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant<T1, T2, T3>", "T2", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="b">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="b"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="b"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T2, TResult> b, TResult _)
        {
            return this.Index == 2 ? b(_x._2) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T2"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="b">The delegate to invoke with the stored value if it is of type <see cref="T2"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="b"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T2, TResult> b, global::System.Func<TResult> _)
        {
            return this.Index == 2 ? b(_x._2) : _();
        }
        /// <summary>
        /// Retrieve the stored value assuming it is of type <see cref="T3"/>.
        ///
        /// <b>Only call this if you have ensured that <c>Index == 3</c>,
        /// otherwise the correctness of the returned value is not guaranteed,
        /// nor that any value is returned at all.</b>
        /// </summary>
        public T3 UnsafeGet(global::dotVariant.Accessor._3 _)
            => _x._3;

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T3"/>.
        /// </summary>
        /// <param name="c">Receives the stored value if it is of type <see cref="T3"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T3"/>.</returns>
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T3 c)
        {
            c = this.Index == 3 ? _x._3 : default;
            return this.Index == 3;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T3"/>.
        /// </summary>
        /// <param name="c">The delegate to invoke with the stored value if it is of type <see cref="T3"/>.</param>
        /// <returns><see langword="true"/> if Variant contained a value of type <see cref="T3"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="c"> is rethrown.</exception>
        public bool TryMatch(global::System.Action<T3> c)
        {
            if (this.Index == 3)
            {
                c(_x._3);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant if it is of type <see cref="T3"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="c">Receives the stored value if it is of type <see cref="T3"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T3"/>.</exception>
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out T3 c)
        {
            if (this.Index == 3)
            {
                c = _x._3;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant<T1, T2, T3>", "T3", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T3"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="c">The delegate to invoke with the stored value if it is of type <see cref="T3"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T3"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="c"/> is rethrown.</exception>
        public void Match(global::System.Action<T3> c)
        {
            if (this.Index == 3)
            {
                c(_x._3);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant<T1, T2, T3>", "T3", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T3"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="c">The delegate to invoke with the stored value if it is of type <see cref="T3"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="c"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<T3> c, global::System.Action _)
        {
            if (this.Index == 3)
            {
                c(_x._3);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T3"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="c">The delegate to invoke with the stored value if it is of type <see cref="T3"/>.</param>
        /// <returns>The value returned from invoking <paramref name="c"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant does not contain a value of type <see cref="T3"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="c"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T3, TResult> c)
        {
            if (this.Index == 3)
            {
                return c(_x._3);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant<T1, T2, T3>", "T3", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T3"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="c">The delegate to invoke with the stored value if it is of type <see cref="T3"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="c"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="c"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T3, TResult> c, TResult _)
        {
            return this.Index == 3 ? c(_x._3) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant if it is of type <see cref="T3"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="c">The delegate to invoke with the stored value if it is of type <see cref="T3"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="c"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<T3, TResult> c, global::System.Func<TResult> _)
        {
            return this.Index == 3 ? c(_x._3) : _();
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant,
        /// and invoke a special delegate if Variant is empty.
        /// </summary>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="T1"/>.</param>
        /// <param name="b">The delegate to invoke if the stored value is of type <see cref="T2"/>.</param>
        /// <param name="c">The delegate to invoke if the stored value is of type <see cref="T3"/>.</param>
        /// <param name="_">The delegate to invoke if Variant is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<T1> a, global::System.Action<T2> b, global::System.Action<T3> c, global::System.Action _)
        {
            switch (this.Index)
            {
                case 0:
                    _();
                    break;
                case 1:
                    a(_x._1);
                    break;
                case 2:
                    b(_x._2);
                    break;
                case 3:
                    c(_x._3);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T1, T2, T3>");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant,
        /// and throw an exception if Variant is empty.
        /// </summary>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="T1"/>.</param>
        /// <param name="b">The delegate to invoke if the stored value is of type <see cref="T2"/>.</param>
        /// <param name="c">The delegate to invoke if the stored value is of type <see cref="T3"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<T1> a, global::System.Action<T2> b, global::System.Action<T3> c)
        {
            switch (this.Index)
            {
                case 0:
                    global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant<T1, T2, T3>");
                    break;
                case 1:
                    a(_x._1);
                    break;
                case 2:
                    b(_x._2);
                    break;
                case 3:
                    c(_x._3);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T1, T2, T3>");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant and return the result,
        /// and invoke a special delegate if Variant is empty and return its result.
        /// </summary>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="T1"/>.</param>
        /// <param name="b">The delegate to invoke if the stored value is of type <see cref="T2"/>.</param>
        /// <param name="c">The delegate to invoke if the stored value is of type <see cref="T3"/>.</param>
        /// <param name="_">The delegate to invoke if Variant is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<T1, TResult> a, global::System.Func<T2, TResult> b, global::System.Func<T3, TResult> c, global::System.Func<TResult> _)
        {
            switch (this.Index)
            {
                case 0:
                    return _();
                case 1:
                    return a(_x._1);
                case 2:
                    return b(_x._2);
                case 3:
                    return c(_x._3);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T1, T2, T3>");
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant and return the result,
        /// and throw an exception if Variant is empty.
        /// </summary>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="T1"/>.</param>
        /// <param name="b">The delegate to invoke if the stored value is of type <see cref="T2"/>.</param>
        /// <param name="c">The delegate to invoke if the stored value is of type <see cref="T3"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<T1, TResult> a, global::System.Func<T2, TResult> b, global::System.Func<T3, TResult> c)
        {
            switch (this.Index)
            {
                case 0:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant<T1, T2, T3>");
                case 1:
                    return a(_x._1);
                case 2:
                    return b(_x._2);
                case 3:
                    return c(_x._3);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T1, T2, T3>");
            }
        }
    }
}


namespace Foo
{
    public static partial class VariantEx
    {
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T1"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T1, TResult> a)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            foreach (var variant in source)
            {
                if (variant.Index == 1)
                {
                    yield return a(variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
            }
        }
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T2"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="b">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T2, TResult> b)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            foreach (var variant in source)
            {
                if (variant.Index == 2)
                {
                    yield return b(variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
            }
        }
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T3"/> and dropping all others.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="c">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T3, TResult> c)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            foreach (var variant in source)
            {
                if (variant.Index == 3)
                {
                    yield return c(variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T1"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T1, TResult> a,
                TResult _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            foreach (var variant in source)
            {
                if (variant.Index == 1)
                {
                    yield return a(variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T2"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="b">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T2, TResult> b,
                TResult _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            foreach (var variant in source)
            {
                if (variant.Index == 2)
                {
                    yield return b(variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T3"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="c">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T3, TResult> c,
                TResult _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            foreach (var variant in source)
            {
                if (variant.Index == 3)
                {
                    yield return c(variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                }
                else
                {
                    yield return _;
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T1"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T1, TResult> a,
                global::System.Func<TResult> _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            foreach (var variant in source)
            {
                if (variant.Index == 1)
                {
                    yield return a(variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T2"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="b">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T2, TResult> b,
                global::System.Func<TResult> _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            foreach (var variant in source)
            {
                if (variant.Index == 2)
                {
                    yield return b(variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="T3"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="c">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T3, TResult> c,
                global::System.Func<TResult> _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            foreach (var variant in source)
            {
                if (variant.Index == 3)
                {
                    yield return c(variant.UnsafeGet(new global::dotVariant.Accessor._3()));
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
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="T1"/>.</param>
        /// <param name="b">The delegate to invoke if the element's value is of type <see cref="T2"/>.</param>
        /// <param name="c">The delegate to invoke if the element's value is of type <see cref="T3"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult, T1, T2, T3>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T1, TResult> a, global::System.Func<T2, TResult> b, global::System.Func<T3, TResult> c)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            foreach (var variant in source)
            {
                switch (variant.Index)
                {
                    case 0:
                        global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant<T1, T2, T3>");
                        yield break;
                    case 1:
                        yield return a(variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    case 2:
                        yield return b(variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                        break;
                    case 3:
                        yield return c(variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T1, T2, T3>");
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="source">An enumerable sequence whose elements to match on.</param>
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="T1"/>.</param>
        /// <param name="b">The delegate to invoke if the element's value is of type <see cref="T2"/>.</param>
        /// <param name="c">The delegate to invoke if the element's value is of type <see cref="T3"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult, T1, T2, T3>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T1, TResult> a, global::System.Func<T2, TResult> b, global::System.Func<T3, TResult> c,
                global::System.Func<TResult> _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            foreach (var variant in source)
            {
                switch (variant.Index)
                {
                    case 0:
                        yield return _();
                        break;
                    case 1:
                        yield return a(variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    case 2:
                        yield return b(variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                        break;
                    case 3:
                        yield return c(variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant<T1, T2, T3>");
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    public static partial class VariantEx
    {
        /// <summary>
        /// Projects each <see cref="T1"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T1, TResult> a)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => _variant.Index == 1),
                _variant => a(_variant.UnsafeGet(new global::dotVariant.Accessor._1())));
        }
        /// <summary>
        /// Projects each <see cref="T2"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="b">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T2, TResult> b)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => _variant.Index == 2),
                _variant => b(_variant.UnsafeGet(new global::dotVariant.Accessor._2())));
        }
        /// <summary>
        /// Projects each <see cref="T3"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="c">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T3, TResult> c)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(source, _variant => _variant.Index == 3),
                _variant => c(_variant.UnsafeGet(new global::dotVariant.Accessor._3())));
        }

        /// <summary>
        /// Projects each <see cref="T1"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T1, TResult> a,
                TResult _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (_variant.Index == 1)
                {
                    return a(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    return _;
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="T2"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="b">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T2, TResult> b,
                TResult _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (_variant.Index == 2)
                {
                    return b(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
                else
                {
                    return _;
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="T3"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="c">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T3, TResult> c,
                TResult _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (_variant.Index == 3)
                {
                    return c(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                }
                else
                {
                    return _;
                }
            });
        }

        /// <summary>
        /// Projects each <see cref="T1"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T1, TResult> a,
                global::System.Func<TResult> _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (_variant.Index == 1)
                {
                    return a(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    return _();
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="T2"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="b">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T2, TResult> b,
                global::System.Func<TResult> _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (_variant.Index == 2)
                {
                    return b(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
                else
                {
                    return _();
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="T3"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to match on.</param>
        /// <param name="c">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T3, TResult> c,
                global::System.Func<TResult> _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                if (_variant.Index == 3)
                {
                    return c(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
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
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="T1"/>.</param>
        /// <param name="b">The delegate to invoke if the element's value is of type <see cref="T2"/>.</param>
        /// <param name="c">The delegate to invoke if the element's value is of type <see cref="T3"/>.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T1, TResult> a, global::System.Func<T2, TResult> b, global::System.Func<T3, TResult> c)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (_variant.Index)
                {
                    case 0:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant<T1, T2, T3>");
                    case 1:
                        return a(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                    case 2:
                        return b(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                    case 3:
                        return c(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T1, T2, T3>");
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="source">An observable sequence whose elements to visit.</param>
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="T1"/>.</param>
        /// <param name="b">The delegate to invoke if the element's value is of type <see cref="T2"/>.</param>
        /// <param name="c">The delegate to invoke if the element's value is of type <see cref="T3"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<T1, TResult> a, global::System.Func<T2, TResult> b, global::System.Func<T3, TResult> c,
                global::System.Func<TResult> _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Select(source, _variant =>
            {
                switch (_variant.Index)
                {
                    case 0:
                        return _();
                    case 1:
                        return a(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                    case 2:
                        return b(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                    case 3:
                        return c(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant<T1, T2, T3>");
                }
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant elements into one independent sub-sequences per value type,
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
        /// <param name="a">Transform an observable sequence of <see cref="T1"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="b">Transform an observable sequence of <see cref="T2"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="c">Transform an observable sequence of <see cref="T3"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<global::System.IObservable<T1>, global::System.IObservable<TResult>> a, global::System.Func<global::System.IObservable<T2>, global::System.IObservable<TResult>> b, global::System.Func<global::System.IObservable<T3>, global::System.IObservable<TResult>> c)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return VisitMany(source, (_1, _2, _3) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(a(_1), b(_2), c(_3));
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
        /// <param name="a">Transform an observable sequence of <see cref="T1"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="b">Transform an observable sequence of <see cref="T2"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="c">Transform an observable sequence of <see cref="T3"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="_">Transform a sequence of <see cref="global::System.Reactive.Unit"/> values (each representing an empty variant) into a sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<global::System.IObservable<T1>, global::System.IObservable<TResult>> a, global::System.Func<global::System.IObservable<T2>, global::System.IObservable<TResult>> b, global::System.Func<global::System.IObservable<T3>, global::System.IObservable<TResult>> c,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return VisitMany(source, (_1, _2, _3, _0) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(a(_1), b(_2), c(_3), _(_0));
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
            VisitMany<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<global::System.IObservable<T1>, global::System.IObservable<T2>, global::System.IObservable<T3>, global::System.IObservable<TResult>> selector)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver<T1, T2, T3>(false);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject2, _mo.Subject3).Subscribe(_o),
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
            VisitMany<TResult, T1, T2, T3>(
                this global::System.IObservable<global::Foo.Variant<T1, T2, T3>> source,
                global::System.Func<global::System.IObservable<T1>, global::System.IObservable<T2>, global::System.IObservable<T3>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> selector)
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver<T1, T2, T3>(true);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    selector(_mo.Subject1, _mo.Subject2, _mo.Subject3, _mo.Subject0).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(source, _mo),
                    _mo);
            });
        }

        private sealed class VisitManyObserver<T1, T2, T3>
            : global::System.IObserver<global::Foo.Variant<T1, T2, T3>>, global::System.IDisposable
            where T1 : class, global::System.IDisposable
            where T2 : notnull
            where T3 : struct
        {
            public readonly global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit> Subject0 = new global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit>();
            public readonly global::System.Reactive.Subjects.Subject<T1> Subject1 = new global::System.Reactive.Subjects.Subject<T1>();
            public readonly global::System.Reactive.Subjects.Subject<T2> Subject2 = new global::System.Reactive.Subjects.Subject<T2>();
            public readonly global::System.Reactive.Subjects.Subject<T3> Subject3 = new global::System.Reactive.Subjects.Subject<T3>();
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

            public void OnNext(global::Foo.Variant<T1, T2, T3> _variant)
            {
                switch (_variant.Index)
                {
                    case 0:
                        if (_accept0)
                        {
                            Subject0.OnNext(global::System.Reactive.Unit.Default);
                        }
                        else
                        {
                            OnError(global::dotVariant.GeneratorSupport.Errors.MakeEmptyError("Foo.Variant<T1, T2, T3>"));
                        }
                        break;
                    case 1:
                        Subject1.OnNext(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    case 2:
                        Subject2.OnNext(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                        break;
                    case 3:
                        Subject3.OnNext(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                        break;
                    default:
                        OnError(global::dotVariant.GeneratorSupport.Errors.MakeInternalError("Foo.Variant<T1, T2, T3>"));
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
