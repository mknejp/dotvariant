//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable disable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(Variant_disposable.__DebuggerTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    partial class Variant_disposable
        : global::System.IEquatable<Variant_disposable>
        , global::System.IDisposable
    {
        private readonly global::dotVariant._G.Foo.Variant_disposable _variant;

        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_disposable(int i)
            => _variant = new global::dotVariant._G.Foo.Variant_disposable(i);
        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_disposable(global::System.IO.Stream stream)
            => _variant = new global::dotVariant._G.Foo.Variant_disposable(stream);

        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_disposable(int i)
            => new Variant_disposable(i);
        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_disposable(global::System.IO.Stream stream)
            => new Variant_disposable(stream);

        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_disposable Create(int i)
            => new Variant_disposable(i);
        /// <summary>
        /// Create a Variant_disposable with a value of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_disposable Create(global::System.IO.Stream stream)
            => new Variant_disposable(stream);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Dispose()"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Dispose()
        {
            _variant.Dispose();
        }

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.IsEmpty"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool IsEmpty
            => _variant.IsEmpty;

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Index"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public byte Index
            => _variant.Index;

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object other)
            => other is Variant_disposable v
            && Equals(v);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(Variant_disposable other)
            => !(other is null) && _variant.Equals(other._variant);

        /// <summary>Compare two Variant_disposable objects for equality.</summary>
        /// <param name="lhs">The first <see cref="Variant_disposable" /> to compare.</param>
        /// <param name="rhs">The second <see cref="Variant_disposable" /> to compare.</param>
        /// <returns><see langword="true" /> if <paramref name="lhs"/> and <paramref name="rhs"/> are considered equal; otherwise, <see langword="false" />.</returns>
        /// <seealso cref="Equals(Variant_disposable)" />
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator ==(Variant_disposable lhs, Variant_disposable rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        /// <summary>Compare two Variant_disposable objects for inequality.</summary>
        /// <param name="lhs">The first <see cref="Variant_disposable" /> to compare.</param>
        /// <param name="rhs">The second <see cref="Variant_disposable" /> to compare.</param>
        /// <returns><see langword="true" /> if <paramref name="lhs"/> and <paramref name="rhs"/> are not considered equal; otherwise, <see langword="false" />.</returns>
        /// <seealso cref="Equals(Variant_disposable)" />
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator !=(Variant_disposable lhs, Variant_disposable rhs)
            => !(lhs == rhs);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override int GetHashCode()
            => _variant.GetHashCode();

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override string ToString()
            => _variant.ToString();

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.UnsafeGet(global::dotVariant.Accessor._1)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public int UnsafeGet(global::dotVariant.Accessor._1 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.TryMatch(out int)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(out int i)
            => _variant.TryMatch(out i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.TryMatch(global::System.Action{int})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<int> i)
            => _variant.TryMatch(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(out int)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(out int i)
            => _variant.Match(out i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(global::System.Action{int})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<int> i)
            => _variant.Match(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(global::System.Action{int}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<int> i, global::System.Action _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{int, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i)
            => _variant.Match(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{int, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{int, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<TResult> _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.UnsafeGet(global::dotVariant.Accessor._2)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::System.IO.Stream UnsafeGet(global::dotVariant.Accessor._2 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.TryMatch(out global::System.IO.Stream)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(out global::System.IO.Stream stream)
            => _variant.TryMatch(out stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.TryMatch(global::System.Action{global::System.IO.Stream})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<global::System.IO.Stream> stream)
            => _variant.TryMatch(stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(out global::System.IO.Stream)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(out global::System.IO.Stream stream)
            => _variant.Match(out stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(global::System.Action{global::System.IO.Stream})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<global::System.IO.Stream> stream)
            => _variant.Match(stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match(global::System.Action{global::System.IO.Stream}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<global::System.IO.Stream> stream, global::System.Action _)
            => _variant.Match(stream, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{global::System.IO.Stream, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream)
            => _variant.Match(stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{global::System.IO.Stream, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream, TResult _)
            => _variant.Match(stream, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Match{TResult}(global::System.Func{global::System.IO.Stream, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream, global::System.Func<TResult> _)
            => _variant.Match(stream, _);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Visit(global::System.Action{int}, global::System.Action{global::System.IO.Stream})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<int> i, global::System.Action<global::System.IO.Stream> stream)
            => _variant.Visit(i, stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Visit(global::System.Action{int}, global::System.Action{global::System.IO.Stream}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<int> i, global::System.Action<global::System.IO.Stream> stream, global::System.Action _)
            => _variant.Visit(i, stream, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Visit{TResult}(global::System.Func{int, TResult}, global::System.Func{global::System.IO.Stream, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream)
            => _variant.Visit(i, stream);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_disposable.Visit{TResult}(global::System.Func{int, TResult}, global::System.Func{global::System.IO.Stream, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream, global::System.Func<TResult> _)
            => _variant.Visit(i, stream, _);

        private sealed class __DebuggerTypeProxy
        {
            public object Value { get; }
            public __DebuggerTypeProxy(Variant_disposable v)
            {
                Value = v._variant.AsObject;
                #pragma warning disable 8604 // Possible null reference argument for parameter
                #pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type
                VariantOf(default, default);
                #pragma warning restore 8604, 8625
            }
        }
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    [global::System.Diagnostics.DebuggerDisplay("{AsObject}", Type = "{TypeString,nq}")]
    internal readonly struct Variant_disposable
        : global::System.IDisposable
    {
        private readonly struct Union
        {
            public readonly int _1;
            public Union(int value)
            {
                _2 = default;
                _1 = value;
            }
            public readonly global::System.IO.Stream _2;
            public Union(global::System.IO.Stream value)
            {
                _1 = default;
                _2 = value;
            }
        }

        private readonly Union _x;

        /// <summary>
        /// The 1-based index of the currently stored type,
        /// counted left-ro-right from the <see cref="global::Foo.Variant_disposable.VariantOf"/> parameter list.
        /// <c>0</c> if the variant is empty.
        /// </summary>
        public readonly byte Index;

        public Variant_disposable(int i)
        {
            Index = 1;
            _x = new Union(i);
        }
        public Variant_disposable(global::System.IO.Stream stream)
        {
            Index = 2;
            _x = new Union(stream);
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
                    break;
                case 2:
                    _x._2?.Dispose();
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_disposable");
                    break;
            }
        }

        /// <summary>
        /// <see langword="true"/> if Variant_disposable was constructed without a value.
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
                        return "int";
                    case 2:
                        return "System.IO.Stream";
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant_disposable");
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
                    return _x._1.ToString();
                case 2:
                    return _x._2?.ToString() ?? "null";
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant_disposable");
            }
        }

        /// <summary>
        /// The stored value cast to type <see cref="object"/>.
        /// </summary>
        public object AsObject
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
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<object>("Foo.Variant_disposable");
                }
            }
        }

        public bool Equals(in Variant_disposable other)
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
                    return global::System.Collections.Generic.EqualityComparer<int>.Default.Equals(_x._1, other._x._1);
                case 2:
                    return global::System.Collections.Generic.EqualityComparer<global::System.IO.Stream>.Default.Equals(_x._2, other._x._2);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<bool>("Foo.Variant_disposable");
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
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<int>("Foo.Variant_disposable");
            }
        }

        /// <summary>
        /// Retrieve the stored value assuming it is of type <see cref="int"/>.
        ///
        /// <b>Only call this if you have ensured that <c>Index == 1</c>,
        /// otherwise the correctness of the returned value is not guaranteed,
        /// nor that any value is returned at all.</b>
        /// </summary>
        public int UnsafeGet(global::dotVariant.Accessor._1 _)
            => _x._1;

        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="int"/>.</returns>
        public bool TryMatch(out int i)
        {
            i = this.Index == 1 ? _x._1 : default;
            return this.Index == 1;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="int"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> is rethrown.</exception>
        public bool TryMatch(global::System.Action<int> i)
        {
            if (this.Index == 1)
            {
                i(_x._1);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="int"/>.</exception>
        public void Match(out int i)
        {
            if (this.Index == 1)
            {
                i = _x._1;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_disposable", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="int"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> is rethrown.</exception>
        public void Match(global::System.Action<int> i)
        {
            if (this.Index == 1)
            {
                i(_x._1);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_disposable", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<int> i, global::System.Action _)
        {
            if (this.Index == 1)
            {
                i(_x._1);
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
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="int"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i)
        {
            if (this.Index == 1)
            {
                return i(_x._1);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_disposable", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>, or <paramref name="_"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
        {
            return this.Index == 1 ? i(_x._1) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="int"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<TResult> _)
        {
            return this.Index == 1 ? i(_x._1) : _();
        }
        /// <summary>
        /// Retrieve the stored value assuming it is of type <see cref="global::System.IO.Stream"/>.
        ///
        /// <b>Only call this if you have ensured that <c>Index == 2</c>,
        /// otherwise the correctness of the returned value is not guaranteed,
        /// nor that any value is returned at all.</b>
        /// </summary>
        public global::System.IO.Stream UnsafeGet(global::dotVariant.Accessor._2 _)
            => _x._2;

        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">Receives the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="global::System.IO.Stream"/>.</returns>
        public bool TryMatch(out global::System.IO.Stream stream)
        {
            stream = this.Index == 2 ? _x._2 : default;
            return this.Index == 2;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns><see langword="true"/> if Variant_disposable contained a value of type <see cref="global::System.IO.Stream"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"/> is rethrown.</exception>
        public bool TryMatch(global::System.Action<global::System.IO.Stream> stream)
        {
            if (this.Index == 2)
            {
                stream(_x._2);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="stream">Receives the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="global::System.IO.Stream"/>.</exception>
        public void Match(out global::System.IO.Stream stream)
        {
            if (this.Index == 2)
            {
                stream = _x._2;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_disposable", "System.IO.Stream", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="global::System.IO.Stream"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"/> is rethrown.</exception>
        public void Match(global::System.Action<global::System.IO.Stream> stream)
        {
            if (this.Index == 2)
            {
                stream(_x._2);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_disposable", "System.IO.Stream", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<global::System.IO.Stream> stream, global::System.Action _)
        {
            if (this.Index == 2)
            {
                stream(_x._2);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns>The value returned from invoking <paramref name="stream"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_disposable does not contain a value of type <see cref="global::System.IO.Stream"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            if (this.Index == 2)
            {
                return stream(_x._2);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_disposable", "System.IO.Stream", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="stream"/>, or <paramref name="_"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream, TResult _)
        {
            return this.Index == 2 ? stream(_x._2) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_disposable if it is of type <see cref="global::System.IO.Stream"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="stream">The delegate to invoke with the stored value if it is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="stream"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.IO.Stream, TResult> stream, global::System.Func<TResult> _)
        {
            return this.Index == 2 ? stream(_x._2) : _();
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
            switch (this.Index)
            {
                case 0:
                    _();
                    break;
                case 1:
                    i(_x._1);
                    break;
                case 2:
                    stream(_x._2);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_disposable");
                    break;
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
            switch (this.Index)
            {
                case 0:
                    global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant_disposable");
                    break;
                case 1:
                    i(_x._1);
                    break;
                case 2:
                    stream(_x._2);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_disposable");
                    break;
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
            switch (this.Index)
            {
                case 0:
                    return _();
                case 1:
                    return i(_x._1);
                case 2:
                    return stream(_x._2);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_disposable");
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
            switch (this.Index)
            {
                case 0:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant_disposable");
                case 1:
                    return i(_x._1);
                case 2:
                    return stream(_x._2);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_disposable");
            }
        }
    }
}


namespace Foo
{
    /// <summary>
    /// Extensions which allow for easy and powerful integration into `System.Linq`-like queries
    /// on <see cref="global::System.Collections.Generic.IEnumerable{T}" /> sequences, that let you manipulate a stream of variants based on the contained type.
    /// </summary>
    public static partial class Variant_disposableEx
    {
        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int"/> and dropping all others.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> _source,
                global::System.Func<int, TResult> i)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 1)
                {
                    yield return i(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
            }
        }
        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="global::System.IO.Stream"/> and dropping all others.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> _source,
                global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 2)
                {
                    yield return stream(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
            }
        }

        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> _source,
                global::System.Func<int, TResult> i,
                TResult _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 1)
                {
                    yield return i(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
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
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> _source,
                global::System.Func<global::System.IO.Stream, TResult> stream,
                TResult _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 2)
                {
                    yield return stream(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
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
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> _source,
                global::System.Func<int, TResult> i,
                global::System.Func<TResult> _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 1)
                {
                    yield return i(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
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
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> _source,
                global::System.Func<global::System.IO.Stream, TResult> stream,
                global::System.Func<TResult> _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 2)
                {
                    yield return stream(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException"/>
        /// if an element is empty.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the element's value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant_disposable.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> _source,
                global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            foreach (var _variant in _source)
            {
                switch (_variant.Index)
                {
                    case 0:
                        global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant_disposable");
                        yield break;
                    case 1:
                        yield return i(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    case 2:
                        yield return stream(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_disposable");
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_disposable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the element's value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_disposable> _source,
                global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream,
                global::System.Func<TResult> _)
        {
            foreach (var _variant in _source)
            {
                switch (_variant.Index)
                {
                    case 0:
                        yield return _();
                        break;
                    case 1:
                        yield return i(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    case 2:
                        yield return stream(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_disposable");
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    /// <summary>
    /// Extensions which allow for easy and powerful integration into `System.Reactive.Linq`-like queries
    /// on <see cref="global::System.IObservable{T}" /> sequences, that let you manipulate an asynchronous stream of variants based on the contained type.
    /// </summary>
    public static partial class Variant_disposableEx
    {
        /// <summary>
        /// Projects each <see cref="int"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<int, TResult> i)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(_source, _variant => _variant.Index == 1),
                _variant => i(_variant.UnsafeGet(new global::dotVariant.Accessor._1())));
        }
        /// <summary>
        /// Projects each <see cref="global::System.IO.Stream"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(_source, _variant => _variant.Index == 2),
                _variant => stream(_variant.UnsafeGet(new global::dotVariant.Accessor._2())));
        }

        /// <summary>
        /// Projects each <see cref="int"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<int, TResult> i,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 1)
                {
                    return i(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    return _;
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="global::System.IO.Stream"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<global::System.IO.Stream, TResult> stream,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 2)
                {
                    return stream(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
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
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<int, TResult> i,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 1)
                {
                    return i(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                }
                else
                {
                    return _();
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="global::System.IO.Stream"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="stream">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<global::System.IO.Stream, TResult> stream,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 2)
                {
                    return stream(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
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
        /// <param name="_source">An observable sequence whose elements to visit.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the element's value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                switch (_variant.Index)
                {
                    case 0:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant_disposable");
                    case 1:
                        return i(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                    case 2:
                        return stream(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_disposable");
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to visit.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="stream">The delegate to invoke if the element's value is of type <see cref="global::System.IO.Stream"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<int, TResult> i, global::System.Func<global::System.IO.Stream, TResult> stream,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                switch (_variant.Index)
                {
                    case 0:
                        return _();
                    case 1:
                        return i(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                    case 2:
                        return stream(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_disposable");
                }
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_disposable elements into one independent sub-sequences per value type,
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
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="i">Transform an observable sequence of <see cref="int"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="stream">Transform an observable sequence of <see cref="global::System.IO.Stream"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<TResult>> i, global::System.Func<global::System.IObservable<global::System.IO.Stream>, global::System.IObservable<TResult>> stream)
        {
            return VisitMany(_source, (_1, _2) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(i(_1), stream(_2));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_disposable elements into one independent sub-sequences per value type,
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
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="i">Transform an observable sequence of <see cref="int"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="stream">Transform an observable sequence of <see cref="global::System.IO.Stream"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="_">Transform a sequence of <see cref="global::System.Reactive.Unit"/> values (each representing an empty variant) into a sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<TResult>> i, global::System.Func<global::System.IObservable<global::System.IO.Stream>, global::System.IObservable<TResult>> stream,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
        {
            return VisitMany(_source, (_1, _2, _0) =>
            {
                return global::System.Reactive.Linq.Observable.Merge(i(_1), stream(_2), _(_0));
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_disposable elements into one independent sub-sequences per value type,
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
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="_selector">Combine the individual sub-sequences into one resulting sequence.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<global::System.IO.Stream>, global::System.IObservable<TResult>> _selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(false);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    _selector(_mo.Subject1, _mo.Subject2).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(_source, _mo),
                    _mo);
            });
        }

        /// <summary>
        /// Splits the observable sequence of Variant_disposable elements into one independent sub-sequences per value type,
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
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="_selector">Combine the individual sub-sequences into one resulting sequence.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_disposable> _source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<global::System.IO.Stream>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(true);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    _selector(_mo.Subject1, _mo.Subject2, _mo.Subject0).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(_source, _mo),
                    _mo);
            });
        }

        private sealed class VisitManyObserver
            : global::System.IObserver<global::Foo.Variant_disposable>, global::System.IDisposable
        {
            public readonly global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit> Subject0 = new global::System.Reactive.Subjects.Subject<global::System.Reactive.Unit>();
            public readonly global::System.Reactive.Subjects.Subject<int> Subject1 = new global::System.Reactive.Subjects.Subject<int>();
            public readonly global::System.Reactive.Subjects.Subject<global::System.IO.Stream> Subject2 = new global::System.Reactive.Subjects.Subject<global::System.IO.Stream>();
            private readonly bool _accept0;

            public VisitManyObserver(bool _accept0)
            {
                this._accept0 = _accept0;
            }

            public void Dispose()
            {
                Subject1.Dispose();
                Subject2.Dispose();
                Subject0.Dispose();
            }

            public void OnNext(global::Foo.Variant_disposable _variant)
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
                            OnError(global::dotVariant.GeneratorSupport.Errors.MakeEmptyError("Foo.Variant_disposable"));
                        }
                        break;
                    case 1:
                        Subject1.OnNext(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    case 2:
                        Subject2.OnNext(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                        break;
                    default:
                        OnError(global::dotVariant.GeneratorSupport.Errors.MakeInternalError("Foo.Variant_disposable"));
                        break;
                }
            }

            public void OnError(global::System.Exception _ex)
            {
                Subject1.OnError(_ex);
                Subject2.OnError(_ex);
                if (_accept0)
                {
                    Subject0.OnError(_ex);
                }
            }

            public void OnCompleted()
            {
                Subject1.OnCompleted();
                Subject2.OnCompleted();
                if (_accept0)
                {
                    Subject0.OnCompleted();
                }
            }
        }

    }
}
