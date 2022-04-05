﻿//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

#nullable enable
namespace Foo
{
    [global::System.Diagnostics.DebuggerTypeProxy(typeof(Variant_class_nullable_enable.__DebuggerTypeProxy))]
    [global::System.Diagnostics.DebuggerDisplay("{_variant.AsObject}", Type = "{_variant.TypeString,nq}")]
    partial class Variant_class_nullable_enable
        : global::System.IEquatable<Variant_class_nullable_enable>
    {
        private readonly global::dotVariant._G.Foo.Variant_class_nullable_enable _variant;

        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_class_nullable_enable(int i)
            => _variant = new global::dotVariant._G.Foo.Variant_class_nullable_enable(i);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_class_nullable_enable(float f)
            => _variant = new global::dotVariant._G.Foo.Variant_class_nullable_enable(f);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_class_nullable_enable(string s)
            => _variant = new global::dotVariant._G.Foo.Variant_class_nullable_enable(s);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="global::System.Array?"/>.
        /// </summary>
        /// <param name="a">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public Variant_class_nullable_enable(global::System.Array? a)
            => _variant = new global::dotVariant._G.Foo.Variant_class_nullable_enable(a);

        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_class_nullable_enable(int i)
            => new Variant_class_nullable_enable(i);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_class_nullable_enable(float f)
            => new Variant_class_nullable_enable(f);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_class_nullable_enable(string s)
            => new Variant_class_nullable_enable(s);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="global::System.Array?"/>.
        /// </summary>
        /// <param name="a">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static implicit operator Variant_class_nullable_enable(global::System.Array? a)
            => new Variant_class_nullable_enable(a);

        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_class_nullable_enable Create(int i)
            => new Variant_class_nullable_enable(i);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_class_nullable_enable Create(float f)
            => new Variant_class_nullable_enable(f);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_class_nullable_enable Create(string s)
            => new Variant_class_nullable_enable(s);
        /// <summary>
        /// Create a Variant_class_nullable_enable with a value of type <see cref="global::System.Array?"/>.
        /// </summary>
        /// <param name="a">The value to initlaize the variant with.</param>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public static Variant_class_nullable_enable Create(global::System.Array? a)
            => new Variant_class_nullable_enable(a);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.IsEmpty"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool IsEmpty
            => _variant.IsEmpty;

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Index"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public byte Index
            => _variant.Index;

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public override bool Equals(object? other)
            => other is Variant_class_nullable_enable v
            && Equals(v);

        /// <inheritdoc/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool Equals(Variant_class_nullable_enable? other)
            => !(other is null) && _variant.Equals(other._variant);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator ==(Variant_class_nullable_enable? lhs, Variant_class_nullable_enable? rhs)
            => lhs?.Equals(rhs) ?? (rhs is null);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public static bool operator !=(Variant_class_nullable_enable? lhs, Variant_class_nullable_enable? rhs)
            => !(lhs == rhs);

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override int GetHashCode()
            => _variant.GetHashCode();

        [global::System.Diagnostics.DebuggerNonUserCode]
        public override string ToString()
            => _variant.ToString();

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.UnsafeGet(global::dotVariant.Accessor._1)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public int UnsafeGet(global::dotVariant.Accessor._1 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.TryMatch(out int)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out int i)
            => _variant.TryMatch(out i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.TryMatch(global::System.Action{int})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<int> i)
            => _variant.TryMatch(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(out int)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out int i)
            => _variant.Match(out i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(global::System.Action{int})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<int> i)
            => _variant.Match(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(global::System.Action{int}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<int> i, global::System.Action _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{int, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i)
            => _variant.Match(i);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{int, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{int, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<int, TResult> i, global::System.Func<TResult> _)
            => _variant.Match(i, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.UnsafeGet(global::dotVariant.Accessor._2)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public float UnsafeGet(global::dotVariant.Accessor._2 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.TryMatch(out float)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out float f)
            => _variant.TryMatch(out f);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.TryMatch(global::System.Action{float})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<float> f)
            => _variant.TryMatch(f);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(out float)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out float f)
            => _variant.Match(out f);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(global::System.Action{float})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<float> f)
            => _variant.Match(f);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(global::System.Action{float}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<float> f, global::System.Action _)
            => _variant.Match(f, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{float, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<float, TResult> f)
            => _variant.Match(f);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{float, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<float, TResult> f, TResult _)
            => _variant.Match(f, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{float, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<float, TResult> f, global::System.Func<TResult> _)
            => _variant.Match(f, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.UnsafeGet(global::dotVariant.Accessor._3)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public string UnsafeGet(global::dotVariant.Accessor._3 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.TryMatch(out string?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string? s)
            => _variant.TryMatch(out s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.TryMatch(global::System.Action{string})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<string> s)
            => _variant.TryMatch(s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(out string?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out string? s)
            => _variant.Match(out s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(global::System.Action{string})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<string> s)
            => _variant.Match(s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(global::System.Action{string}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<string> s, global::System.Action _)
            => _variant.Match(s, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{string, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<string, TResult> s)
            => _variant.Match(s);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{string, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<string, TResult> s, TResult _)
            => _variant.Match(s, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{string, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<string, TResult> s, global::System.Func<TResult> _)
            => _variant.Match(s, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.UnsafeGet(global::dotVariant.Accessor._4)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public global::System.Array? UnsafeGet(global::dotVariant.Accessor._4 accessor)
            => _variant.UnsafeGet(accessor);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.TryMatch(out global::System.Array?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(out global::System.Array? a)
            => _variant.TryMatch(out a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.TryMatch(global::System.Action{global::System.Array?})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public bool TryMatch(global::System.Action<global::System.Array?> a)
            => _variant.TryMatch(a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(out global::System.Array?)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(out global::System.Array? a)
            => _variant.Match(out a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(global::System.Action{global::System.Array?})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<global::System.Array?> a)
            => _variant.Match(a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match(global::System.Action{global::System.Array?}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Match(global::System.Action<global::System.Array?> a, global::System.Action _)
            => _variant.Match(a, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{global::System.Array?, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<global::System.Array?, TResult> a)
            => _variant.Match(a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{global::System.Array?, TResult}, TResult)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<global::System.Array?, TResult> a, TResult _)
            => _variant.Match(a, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Match{TResult}(global::System.Func{global::System.Array?, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Match<TResult>(global::System.Func<global::System.Array?, TResult> a, global::System.Func<TResult> _)
            => _variant.Match(a, _);


        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Visit(global::System.Action{int}, global::System.Action{float}, global::System.Action{string}, global::System.Action{global::System.Array?})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action<global::System.Array?> a)
            => _variant.Visit(i, f, s, a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Visit(global::System.Action{int}, global::System.Action{float}, global::System.Action{string}, global::System.Action{global::System.Array?}, global::System.Action)"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action<global::System.Array?> a, global::System.Action _)
            => _variant.Visit(i, f, s, a, _);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Visit{TResult}(global::System.Func{int, TResult}, global::System.Func{float, TResult}, global::System.Func{string, TResult}, global::System.Func{global::System.Array?, TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a)
            => _variant.Visit(i, f, s, a);

        /// <inheritdoc cref="global::dotVariant._G.Foo.Variant_class_nullable_enable.Visit{TResult}(global::System.Func{int, TResult}, global::System.Func{float, TResult}, global::System.Func{string, TResult}, global::System.Func{global::System.Array?, TResult}, global::System.Func{TResult})"/>
        [global::System.Diagnostics.DebuggerNonUserCode]
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a, global::System.Func<TResult> _)
            => _variant.Visit(i, f, s, a, _);

        private sealed class __DebuggerTypeProxy
        {
            public object? Value { get; }
            public __DebuggerTypeProxy(Variant_class_nullable_enable v)
            {
                Value = v._variant.AsObject;
                #pragma warning disable 8604 // Possible null reference argument for parameter
                #pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type
                VariantOf(default, default, default, default);
                #pragma warning restore 8604, 8625
            }
        }
    }
}

namespace dotVariant._G.Foo
{
    [global::System.Diagnostics.DebuggerNonUserCode]
    [global::System.Diagnostics.DebuggerDisplay("{AsObject}", Type = "{TypeString,nq}")]
    internal readonly struct Variant_class_nullable_enable
    {
        private readonly struct Union
        {
            public readonly int _1;
            public Union(int value)
            {
                _2 = default!;
                _3 = default!;
                _4 = default!;
                _1 = value;
            }
            public readonly float _2;
            public Union(float value)
            {
                _1 = default!;
                _3 = default!;
                _4 = default!;
                _2 = value;
            }
            public readonly string _3;
            public Union(string value)
            {
                _1 = default!;
                _2 = default!;
                _4 = default!;
                _3 = value;
            }
            public readonly global::System.Array? _4;
            public Union(global::System.Array? value)
            {
                _1 = default!;
                _2 = default!;
                _3 = default!;
                _4 = value;
            }
        }

        private readonly Union _x;

        /// <summary>
        /// The 1-based index of the currently stored type,
        /// counted left-ro-right from the <see cref="global::Foo.Variant_class_nullable_enable.VariantOf()"/> parameter list.
        /// <c>0</c> if the variant is empty.
        /// </summary>
        public readonly byte Index;

        public Variant_class_nullable_enable(int i)
        {
            Index = 1;
            _x = new Union(i);
        }
        public Variant_class_nullable_enable(float f)
        {
            Index = 2;
            _x = new Union(f);
        }
        public Variant_class_nullable_enable(string s)
        {
            Index = 3;
            _x = new Union(s);
        }
        public Variant_class_nullable_enable(global::System.Array? a)
        {
            Index = 4;
            _x = new Union(a);
        }


        /// <summary>
        /// <see langword="true"/> if Variant_class_nullable_enable was constructed without a value.
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
                        return "float";
                    case 3:
                        return "string";
                    case 4:
                        return "System.Array?";
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant_class_nullable_enable");
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
                    return _x._2.ToString();
                case 3:
                    return _x._3.ToString();
                case 4:
                    return _x._4?.ToString() ?? "null";
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<string>("Foo.Variant_class_nullable_enable");
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
                    case 4:
                        return _x._4;
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<object?>("Foo.Variant_class_nullable_enable");
                }
            }
        }

        public bool Equals(in Variant_class_nullable_enable other)
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
                    return global::System.Collections.Generic.EqualityComparer<float>.Default.Equals(_x._2, other._x._2);
                case 3:
                    return global::System.Collections.Generic.EqualityComparer<string>.Default.Equals(_x._3, other._x._3);
                case 4:
                    return global::System.Collections.Generic.EqualityComparer<global::System.Array?>.Default.Equals(_x._4, other._x._4);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<bool>("Foo.Variant_class_nullable_enable");
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
                case 4:
                    return global::System.HashCode.Combine(_x._4);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<int>("Foo.Variant_class_nullable_enable");
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
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="int"/>.</returns>
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out int i)
        {
            i = this.Index == 1 ? _x._1 : default;
            return this.Index == 1;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="int"/>.</returns>
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
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">Receives the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="int"/>.</exception>
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out int i)
        {
            if (this.Index == 1)
            {
                i = _x._1;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_class_nullable_enable", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="int"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> is rethrown.</exception>
        public void Match(global::System.Action<int> i)
        {
            if (this.Index == 1)
            {
                i(_x._1);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_class_nullable_enable", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/>,
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
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="int"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i)
        {
            if (this.Index == 1)
            {
                return i(_x._1);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_class_nullable_enable", "int", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="i">The delegate to invoke with the stored value if it is of type <see cref="int"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="i"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="i"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<int, TResult> i, TResult _)
        {
            return this.Index == 1 ? i(_x._1) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="int"/> and return the result,
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
        /// Retrieve the stored value assuming it is of type <see cref="float"/>.
        ///
        /// <b>Only call this if you have ensured that <c>Index == 2</c>,
        /// otherwise the correctness of the returned value is not guaranteed,
        /// nor that any value is returned at all.</b>
        /// </summary>
        public float UnsafeGet(global::dotVariant.Accessor._2 _)
            => _x._2;

        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">Receives the stored value if it is of type <see cref="float"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="float"/>.</returns>
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out float f)
        {
            f = this.Index == 2 ? _x._2 : default;
            return this.Index == 2;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="float"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"/> is rethrown.</exception>
        public bool TryMatch(global::System.Action<float> f)
        {
            if (this.Index == 2)
            {
                f(_x._2);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="f">Receives the stored value if it is of type <see cref="float"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="float"/>.</exception>
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out float f)
        {
            if (this.Index == 2)
            {
                f = _x._2;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_class_nullable_enable", "float", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="float"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"/> is rethrown.</exception>
        public void Match(global::System.Action<float> f)
        {
            if (this.Index == 2)
            {
                f(_x._2);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_class_nullable_enable", "float", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<float> f, global::System.Action _)
        {
            if (this.Index == 2)
            {
                f(_x._2);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <returns>The value returned from invoking <paramref name="f"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="float"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<float, TResult> f)
        {
            if (this.Index == 2)
            {
                return f(_x._2);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_class_nullable_enable", "float", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="f"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<float, TResult> f, TResult _)
        {
            return this.Index == 2 ? f(_x._2) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="float"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="f">The delegate to invoke with the stored value if it is of type <see cref="float"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="f"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<float, TResult> f, global::System.Func<TResult> _)
        {
            return this.Index == 2 ? f(_x._2) : _();
        }
        /// <summary>
        /// Retrieve the stored value assuming it is of type <see cref="string"/>.
        ///
        /// <b>Only call this if you have ensured that <c>Index == 3</c>,
        /// otherwise the correctness of the returned value is not guaranteed,
        /// nor that any value is returned at all.</b>
        /// </summary>
        public string UnsafeGet(global::dotVariant.Accessor._3 _)
            => _x._3;

        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">Receives the stored value if it is of type <see cref="string"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="string"/>.</returns>
        public bool TryMatch([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string? s)
        {
            s = this.Index == 3 ? _x._3 : default;
            return this.Index == 3;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="string"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"/> is rethrown.</exception>
        public bool TryMatch(global::System.Action<string> s)
        {
            if (this.Index == 3)
            {
                s(_x._3);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">Receives the stored value if it is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="string"/>.</exception>
        public void Match([global::System.Diagnostics.CodeAnalysis.NotNull] out string? s)
        {
            if (this.Index == 3)
            {
                s = _x._3;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_class_nullable_enable", "string", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="string"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"/> is rethrown.</exception>
        public void Match(global::System.Action<string> s)
        {
            if (this.Index == 3)
            {
                s(_x._3);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_class_nullable_enable", "string", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<string> s, global::System.Action _)
        {
            if (this.Index == 3)
            {
                s(_x._3);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <returns>The value returned from invoking <paramref name="s"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="string"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s)
        {
            if (this.Index == 3)
            {
                return s(_x._3);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_class_nullable_enable", "string", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="s"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s, TResult _)
        {
            return this.Index == 3 ? s(_x._3) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="string"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="s">The delegate to invoke with the stored value if it is of type <see cref="string"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="s"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<string, TResult> s, global::System.Func<TResult> _)
        {
            return this.Index == 3 ? s(_x._3) : _();
        }
        /// <summary>
        /// Retrieve the stored value assuming it is of type <see cref="global::System.Array?"/>.
        ///
        /// <b>Only call this if you have ensured that <c>Index == 4</c>,
        /// otherwise the correctness of the returned value is not guaranteed,
        /// nor that any value is returned at all.</b>
        /// </summary>
        public global::System.Array? UnsafeGet(global::dotVariant.Accessor._4 _)
            => _x._4;

        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array?"/>.
        /// </summary>
        /// <param name="a">Receives the stored value if it is of type <see cref="global::System.Array?"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="global::System.Array?"/>.</returns>
        public bool TryMatch(out global::System.Array? a)
        {
            a = this.Index == 4 ? _x._4 : default;
            return this.Index == 4;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array?"/>.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array?"/>.</param>
        /// <returns><see langword="true"/> if Variant_class_nullable_enable contained a value of type <see cref="global::System.Array?"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"/> is rethrown.</exception>
        public bool TryMatch(global::System.Action<global::System.Array?> a)
        {
            if (this.Index == 4)
            {
                a(_x._4);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retrieve the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array?"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="a">Receives the stored value if it is of type <see cref="global::System.Array?"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="global::System.Array?"/>.</exception>
        public void Match(out global::System.Array? a)
        {
            if (this.Index == 4)
            {
                a = _x._4;
                return;
            }
            throw global::dotVariant.GeneratorSupport.Errors.MakeMismatchError("Foo.Variant_class_nullable_enable", "System.Array?", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array?"/>,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array?"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="global::System.Array?"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"/> is rethrown.</exception>
        public void Match(global::System.Action<global::System.Array?> a)
        {
            if (this.Index == 4)
            {
                a(_x._4);
                return;
            }
            global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError("Foo.Variant_class_nullable_enable", "System.Array?", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array?"/>,
        /// otherwise invoke an alternative delegate.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array?"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"/> or <paramref name="_"/> is rethrown.</exception>
        public void Match(global::System.Action<global::System.Array?> a, global::System.Action _)
        {
            if (this.Index == 4)
            {
                a(_x._4);
            }
            else
            {
                _();
            }
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array?"/> and return the result,
        /// otherwise throw <see cref="global::System.InvalidOperationException"/>.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array?"/>.</param>
        /// <returns>The value returned from invoking <paramref name="a"/>.</returns>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable does not contain a value of type <see cref="global::System.Array?"/>.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.Array?, TResult> a)
        {
            if (this.Index == 4)
            {
                return a(_x._4);
            }
            return global::dotVariant.GeneratorSupport.Errors.ThrowMismatchError<TResult>("Foo.Variant_class_nullable_enable", "System.Array?", TypeString);
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array?"/> and return the result,
        /// otherwise return a provided value.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array?"/>.</param>
        /// <param name="_">The value to return if the stored value is of a different type.</param>
        /// <returns>The value returned from invoking <paramref name="a"/>, or <paramref name="default"/>.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.Array?, TResult> a, TResult _)
        {
            return this.Index == 4 ? a(_x._4) : _;
        }

        /// <summary>
        /// Invoke a delegate with the value stored within Variant_class_nullable_enable if it is of type <see cref="global::System.Array?"/> and return the result,
        /// otherwise invoke an alternative delegate and return its result.
        /// </summary>
        /// <param name="a">The delegate to invoke with the stored value if it is of type <see cref="global::System.Array?"/>.</param>
        /// <param name="_">The delegate to invoke if the stored value is of a different type.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from <paramref name="a"/> or <paramref name="_"/> is rethrown.</exception>
        public TResult Match<TResult>(global::System.Func<global::System.Array?, TResult> a, global::System.Func<TResult> _)
        {
            return this.Index == 4 ? a(_x._4) : _();
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_class_nullable_enable,
        /// and invoke a special delegate if Variant_class_nullable_enable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="global::System.Array?"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_class_nullable_enable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action<global::System.Array?> a, global::System.Action _)
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
                    f(_x._2);
                    break;
                case 3:
                    s(_x._3);
                    break;
                case 4:
                    a(_x._4);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_class_nullable_enable");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_class_nullable_enable,
        /// and throw an exception if Variant_class_nullable_enable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="global::System.Array?"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        public void Visit(global::System.Action<int> i, global::System.Action<float> f, global::System.Action<string> s, global::System.Action<global::System.Array?> a)
        {
            switch (this.Index)
            {
                case 0:
                    global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant_class_nullable_enable");
                    break;
                case 1:
                    i(_x._1);
                    break;
                case 2:
                    f(_x._2);
                    break;
                case 3:
                    s(_x._3);
                    break;
                case 4:
                    a(_x._4);
                    break;
                default:
                    global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_class_nullable_enable");
                    break;
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of type of the value stored within Variant_class_nullable_enable and return the result,
        /// and invoke a special delegate if Variant_class_nullable_enable is empty and return its result.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="global::System.Array?"/>.</param>
        /// <param name="_">The delegate to invoke if Variant_class_nullable_enable is empty.</param>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a, global::System.Func<TResult> _)
        {
            switch (this.Index)
            {
                case 0:
                    return _();
                case 1:
                    return i(_x._1);
                case 2:
                    return f(_x._2);
                case 3:
                    return s(_x._3);
                case 4:
                    return a(_x._4);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_class_nullable_enable");
            }
        }

        /// <summary>
        /// Invoke the delegate whose parameter type matches that of the value stored within Variant_class_nullable_enable and return the result,
        /// and throw an exception if Variant_class_nullable_enable is empty.
        /// </summary>
        /// <param name="i">The delegate to invoke if the stored value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the stored value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the stored value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the stored value is of type <see cref="global::System.Array?"/>.</param>
        /// <exception cref="global::System.InvalidOperationException">Variant_class_nullable_enable is empty.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The return type of all delegates, and by extension the return type of this function.</typeparam>
        public TResult Visit<TResult>(global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a)
        {
            switch (this.Index)
            {
                case 0:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant_class_nullable_enable");
                case 1:
                    return i(_x._1);
                case 2:
                    return f(_x._2);
                case 3:
                    return s(_x._3);
                case 4:
                    return a(_x._4);
                default:
                    return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_class_nullable_enable");
            }
        }
    }
}


namespace Foo
{
    public static partial class Variant_class_nullable_enableEx
    {
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="int"/> and dropping all others.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
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
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="float"/> and dropping all others.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<float, TResult> f)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 2)
                {
                    yield return f(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="string"/> and dropping all others.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<string, TResult> s)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 3)
                {
                    yield return s(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="global::System.Array?"/> and dropping all others.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<global::System.Array?, TResult> a)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 4)
                {
                    yield return a(_variant.UnsafeGet(new global::dotVariant.Accessor._4()));
                }
            }
        }

        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
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
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
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
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="float"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<float, TResult> f,
                TResult _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 2)
                {
                    yield return f(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
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
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<string, TResult> s,
                TResult _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 3)
                {
                    yield return s(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                }
                else
                {
                    yield return _;
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="global::System.Array?"/> and replacing all others by a fallback value.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<global::System.Array?, TResult> a,
                TResult _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 4)
                {
                    yield return a(_variant.UnsafeGet(new global::dotVariant.Accessor._4()));
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
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
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
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="float"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<float, TResult> f,
                global::System.Func<TResult> _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 2)
                {
                    yield return f(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
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
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<string, TResult> s,
                global::System.Func<TResult> _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 3)
                {
                    yield return s(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                }
                else
                {
                    yield return _();
                }
            }
        }
        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to those elements
        /// containing a value of type <see cref="global::System.Array?"/> and replacing all others with the result of a fallback selector.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Match<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<global::System.Array?, TResult> a,
                global::System.Func<TResult> _)
        {
            foreach (var _variant in _source)
            {
                if (_variant.Index == 4)
                {
                    yield return a(_variant.UnsafeGet(new global::dotVariant.Accessor._4()));
                }
                else
                {
                    yield return _();
                }
            }
        }

        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and throwing <see cref="global::System.InvalidOperationException"/>
        /// if an element is empty.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the element's value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="global::System.Array?"/>.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.InvalidOperationException">The sequence encountered an empty Variant_class_nullable_enable.</exception>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a)
        {
            foreach (var _variant in _source)
            {
                switch (_variant.Index)
                {
                    case 0:
                        global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError("Foo.Variant_class_nullable_enable");
                        yield break;
                    case 1:
                        yield return i(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                        break;
                    case 2:
                        yield return f(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                        break;
                    case 3:
                        yield return s(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                        break;
                    case 4:
                        yield return a(_variant.UnsafeGet(new global::dotVariant.Accessor._4()));
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_class_nullable_enable");
                        yield break;
                }
            }
        }

        /// <summary>
        /// Transform a Variant_class_nullable_enable-based enumerable sequence by applying a selector function to each element
        /// wich matches the type stored within the value, and replacing empty elements with the result of a fallback selector.
        /// </summary>
        /// <param name="_source">An enumerable sequence whose elements to match on.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the element's value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="global::System.Array?"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An enumerable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <exception cref="global::System.Exception">Any exception thrown from a delegate is rethrown.</exception>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.Collections.Generic.IEnumerable<TResult>
            Visit<TResult>(
                this global::System.Collections.Generic.IEnumerable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a,
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
                        yield return f(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                        break;
                    case 3:
                        yield return s(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                        break;
                    case 4:
                        yield return a(_variant.UnsafeGet(new global::dotVariant.Accessor._4()));
                        break;
                    default:
                        global::dotVariant.GeneratorSupport.Errors.ThrowInternalError("Foo.Variant_class_nullable_enable");
                        yield break;
                }
            }
        }
    }
}
namespace Foo
{
    public static partial class Variant_class_nullable_enableEx
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
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<int, TResult> i)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(_source, _variant => _variant.Index == 1),
                _variant => i(_variant.UnsafeGet(new global::dotVariant.Accessor._1())));
        }
        /// <summary>
        /// Projects each <see cref="float"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<float, TResult> f)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(_source, _variant => _variant.Index == 2),
                _variant => f(_variant.UnsafeGet(new global::dotVariant.Accessor._2())));
        }
        /// <summary>
        /// Projects each <see cref="string"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<string, TResult> s)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(_source, _variant => _variant.Index == 3),
                _variant => s(_variant.UnsafeGet(new global::dotVariant.Accessor._3())));
        }
        /// <summary>
        /// Projects each <see cref="global::System.Array?"/> element of an observable sequence
        /// into a new form and drops all other elements.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<global::System.Array?, TResult> a)
        {
            return global::System.Reactive.Linq.Observable.Select(
                global::System.Reactive.Linq.Observable.Where(_source, _variant => _variant.Index == 4),
                _variant => a(_variant.UnsafeGet(new global::dotVariant.Accessor._4())));
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
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
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
        /// Projects each <see cref="float"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<float, TResult> f,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 2)
                {
                    return f(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
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
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<string, TResult> s,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 3)
                {
                    return s(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                }
                else
                {
                    return _;
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="global::System.Array?"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback value.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<global::System.Array?, TResult> a,
                TResult _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 4)
                {
                    return a(_variant.UnsafeGet(new global::dotVariant.Accessor._4()));
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
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
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
        /// Projects each <see cref="float"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="f">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<float, TResult> f,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 2)
                {
                    return f(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
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
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="s">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<string, TResult> s,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 3)
                {
                    return s(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                }
                else
                {
                    return _();
                }
            });
        }
        /// <summary>
        /// Projects each <see cref="global::System.Array?"/> element of an observable sequence
        /// into a new form and replaces all other elements by a fallback selector result.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to match on.</param>
        /// <param name="a">Function applied to matching elements and whose value to surface from the resulting sequence.</param>
        /// <param name="_">Value to produce for elements which do not match the desired type.</param>
        /// <returns>An observable sequence that contains the matched and transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Match<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<global::System.Array?, TResult> a,
                global::System.Func<TResult> _)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                if (_variant.Index == 4)
                {
                    return a(_variant.UnsafeGet(new global::dotVariant.Accessor._4()));
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
        /// <param name="f">The delegate to invoke if the element's value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="global::System.Array?"/>.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a)
        {
            return global::System.Reactive.Linq.Observable.Select(_source, _variant =>
            {
                switch (_variant.Index)
                {
                    case 0:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowEmptyError<TResult>("Foo.Variant_class_nullable_enable");
                    case 1:
                        return i(_variant.UnsafeGet(new global::dotVariant.Accessor._1()));
                    case 2:
                        return f(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                    case 3:
                        return s(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                    case 4:
                        return a(_variant.UnsafeGet(new global::dotVariant.Accessor._4()));
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_class_nullable_enable");
                }
            });
        }

        /// <summary>
        /// Projects each element of an observable sequence into a new form depending on its contained value type,
        /// failing with <see cref="global::System.InvalidOperationException"/> if an element is empty.
        /// </summary>
        /// <param name="_source">An observable sequence whose elements to visit.</param>
        /// <param name="i">The delegate to invoke if the element's value is of type <see cref="int"/>.</param>
        /// <param name="f">The delegate to invoke if the element's value is of type <see cref="float"/>.</param>
        /// <param name="s">The delegate to invoke if the element's value is of type <see cref="string"/>.</param>
        /// <param name="a">The delegate to invoke if the element's value is of type <see cref="global::System.Array?"/>.</param>
        /// <param name="_">The delegate to invoke if an element is empty.</param>
        /// <returns>An observable sequence that contains the transformed elements of the input sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            Visit<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<int, TResult> i, global::System.Func<float, TResult> f, global::System.Func<string, TResult> s, global::System.Func<global::System.Array?, TResult> a,
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
                        return f(_variant.UnsafeGet(new global::dotVariant.Accessor._2()));
                    case 3:
                        return s(_variant.UnsafeGet(new global::dotVariant.Accessor._3()));
                    case 4:
                        return a(_variant.UnsafeGet(new global::dotVariant.Accessor._4()));
                    default:
                        return global::dotVariant.GeneratorSupport.Errors.ThrowInternalError<TResult>("Foo.Variant_class_nullable_enable");
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
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="i">Transform an observable sequence of <see cref="int"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="f">Transform an observable sequence of <see cref="float"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="s">Transform an observable sequence of <see cref="string"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="a">Transform an observable sequence of <see cref="global::System.Array?"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<TResult>> i, global::System.Func<global::System.IObservable<float>, global::System.IObservable<TResult>> f, global::System.Func<global::System.IObservable<string>, global::System.IObservable<TResult>> s, global::System.Func<global::System.IObservable<global::System.Array?>, global::System.IObservable<TResult>> a)
        {
            return VisitMany(_source, (_1, _2, _3, _4) =>
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
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="i">Transform an observable sequence of <see cref="int"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="f">Transform an observable sequence of <see cref="float"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="s">Transform an observable sequence of <see cref="string"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="a">Transform an observable sequence of <see cref="global::System.Array?"/> values into an observable sequence of <typeparamref name="TResult"/> values.</param>
        /// <param name="_">Transform a sequence of <see cref="global::System.Reactive.Unit"/> values (each representing an empty variant) into a sequence of <typeparamref name="TResult"/> values.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<TResult>> i, global::System.Func<global::System.IObservable<float>, global::System.IObservable<TResult>> f, global::System.Func<global::System.IObservable<string>, global::System.IObservable<TResult>> s, global::System.Func<global::System.IObservable<global::System.Array?>, global::System.IObservable<TResult>> a,
                global::System.Func<global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _)
        {
            return VisitMany(_source, (_1, _2, _3, _4, _0) =>
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
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="_selector">Combine the individual sub-sequences into one resulting sequence.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<float>, global::System.IObservable<string>, global::System.IObservable<global::System.Array?>, global::System.IObservable<TResult>> _selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(false);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    _selector(_mo.Subject1, _mo.Subject2, _mo.Subject3, _mo.Subject4).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(_source, _mo),
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
        /// <param name="_source">An observable sequence whose elements to split into sub-sequences.</param>
        /// <param name="_selector">Combine the individual sub-sequences into one resulting sequence.</param>
        /// <returns>An observable sequence that contains the elements of all sub-sequence.</returns>
        /// <typeparam name="TResult">The resulting sequence's element type.</typeparam>
        public static global::System.IObservable<TResult>
            VisitMany<TResult>(
                this global::System.IObservable<global::Foo.Variant_class_nullable_enable> _source,
                global::System.Func<global::System.IObservable<int>, global::System.IObservable<float>, global::System.IObservable<string>, global::System.IObservable<global::System.Array?>, global::System.IObservable<global::System.Reactive.Unit>, global::System.IObservable<TResult>> _selector)
        {
            return global::System.Reactive.Linq.Observable.Create<TResult>(_o =>
            {
                var _mo = new VisitManyObserver(true);
                return global::System.Reactive.Disposables.StableCompositeDisposable.Create(
                    _selector(_mo.Subject1, _mo.Subject2, _mo.Subject3, _mo.Subject4, _mo.Subject0).Subscribe(_o),
                    global::System.ObservableExtensions.SubscribeSafe(_source, _mo),
                    _mo);
            });
        }

        private sealed class VisitManyObserver
            : global::System.IObserver<global::Foo.Variant_class_nullable_enable>, global::System.IDisposable
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
                switch (_variant.Index)
                {
                    case 0:
                        if (_accept0)
                        {
                            Subject0.OnNext(global::System.Reactive.Unit.Default);
                        }
                        else
                        {
                            OnError(global::dotVariant.GeneratorSupport.Errors.MakeEmptyError("Foo.Variant_class_nullable_enable"));
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
                    case 4:
                        Subject4.OnNext(_variant.UnsafeGet(new global::dotVariant.Accessor._4()));
                        break;
                    default:
                        OnError(global::dotVariant.GeneratorSupport.Errors.MakeInternalError("Foo.Variant_class_nullable_enable"));
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
