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

/// <summary>A result type carrying <see cref="Diagnostic"/> values and a <typeparamref name="TValue"/> if and only if no errors are diagnosed.</summary>
/// <typeparam name="TValue">The type of the value</typeparam>
/// <remarks>Diagnosed result ignores diagnostics during equality comparison to improve caching consistency.</remarks>
public readonly struct DiagnosedResult<TValue>
{
    private readonly bool _noErrors;

    public DiagnosedResult(ImmutableArray<Diagnostic> diagnostics, TValue value)
    {
        _noErrors = !diagnostics.HasErrors();
        Diagnostics = diagnostics;
        ValueOrDefault = HasErrors ? default : value;
    }

    public DiagnosedResult(TValue value)
    {
        _noErrors = true;
        Diagnostics = ImmutableArray<Diagnostic>.Empty;
        ValueOrDefault = value;
    }

    private DiagnosedResult(ImmutableArray<Diagnostic> diagnostics, bool hasErrors, TValue? valueOrDefault)
    {
        _noErrors = !hasErrors;
        Diagnostics = diagnostics;
        ValueOrDefault = valueOrDefault;
    }

    public readonly ImmutableArray<Diagnostic> Diagnostics;
    public readonly TValue? ValueOrDefault;

    public bool HasErrors => !_noErrors;

    public bool TryGetValue(out TValue value)
    {
        value = ValueOrDefault!;
        return _noErrors;
    }

    public DiagnosedResult<TResult> Select<TResult>(Func<TValue, TResult> selector)
    {
        var result = HasErrors ? default : selector(ValueOrDefault!);
        return new(Diagnostics, HasErrors, result);
    }

    public DiagnosedResult<TValue> WithDiagnostics(ImmutableArray<Diagnostic> diagnostics)
    {
        if (Diagnostics.IsDefaultOrEmpty && diagnostics.IsDefaultOrEmpty)
        {
            return new(ImmutableArray<Diagnostic>.Empty, HasErrors, ValueOrDefault);
        }

        diagnostics = Diagnostics.IsDefaultOrEmpty ? diagnostics : Diagnostics.AddRange(diagnostics);
        return new(diagnostics, ValueOrDefault!);
    }

    public ImmutableArray<DiagnosedResult<TResult>> SelectMany<TResult>(Func<TValue, ImmutableArray<TResult>> selector)
    {
        var diagnostics = Diagnostics;
        if (HasErrors)
        {
            // preserve diagnostics
            return ImmutableArray.Create(new DiagnosedResult<TResult>(diagnostics, true, default!));
        }

        var results = selector(ValueOrDefault!);
        return results.Select(r => new DiagnosedResult<TResult>(diagnostics, false, r)).ToImmutableArray();
    }

    public bool Equals(DiagnosedResult<TValue> other)
    {
        return HasErrors == other.HasErrors && EqualityComparer<TValue?>.Default.Equals(ValueOrDefault, other.ValueOrDefault);
    }

    public override bool Equals(object? obj)
    {
        return obj is DiagnosedResult<TValue> other && Equals(other);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            return HasErrors ? 1337 : EqualityComparer<TValue?>.Default.GetHashCode(ValueOrDefault);
        }
    }
}

public static class DiagnosedResultExtensions
{
    public static DiagnosedResult<TValue> AsDiagnosedResult<TValue>(this TValue value)
    {
        return new(value);
    }

    public static bool HasErrors(this ImmutableArray<Diagnostic> diagnostics)
    {
        return diagnostics.Any(static d => d.Severity >= DiagnosticSeverity.Error);
    }
}
