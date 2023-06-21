// 
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace dotVariant.Generator;

/// <summary>A result type carrying <see cref="Diagnostic"/> values and a <typeparamref name="TValue"/> if any only if no errors are diagnosed.</summary>
/// <typeparam name="TValue">The type of the value</typeparam>
public readonly struct DiagnosedResult<TValue> : IEquatable<DiagnosedResult<TValue>>
{
    public DiagnosedResult(ImmutableArray<Diagnostic> diagnostics, Func<TValue> valueFactory)
    {
        HasErrors = diagnostics.Any(static d => d.Severity >= DiagnosticSeverity.Error);
        Diagnostics = diagnostics;
        ValueOrDefault = HasErrors ? default : valueFactory();
    }

    private DiagnosedResult(ImmutableArray<Diagnostic> diagnostics, bool hasErrors, TValue? valueOrDefault)
    {
        HasErrors = hasErrors;
        Diagnostics = diagnostics;
        ValueOrDefault = valueOrDefault;
    }

    public readonly ImmutableArray<Diagnostic> Diagnostics;
    public readonly TValue? ValueOrDefault;
    public readonly bool HasErrors;

    public bool TryGetValue(out TValue value)
    {
        value = ValueOrDefault!;
        return !HasErrors;
    }

    public DiagnosedResult<TResult> Select<TResult>(Func<TValue, TResult> selector)
    {
        var result = HasErrors ? default : selector(ValueOrDefault!);
        return new DiagnosedResult<TResult>(Diagnostics, HasErrors, result);
    }

    public bool Equals(DiagnosedResult<TValue> other)
    {
        return EqualityComparer<TValue?>.Default.Equals(ValueOrDefault, other.ValueOrDefault) && HasErrors == other.HasErrors;
    }

    public override bool Equals(object? obj)
    {
        return obj is DiagnosedResult<TValue> other && Equals(other);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            return (EqualityComparer<TValue?>.Default.GetHashCode(ValueOrDefault) * 397) ^ HasErrors.GetHashCode();
        }
    }
}
