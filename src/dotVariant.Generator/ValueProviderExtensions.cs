//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using Microsoft.CodeAnalysis;
using System;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace dotVariant.Generator
{
    public static class ValueProviderExtensions
    {
        public static IncrementalValuesProvider<TResult> SelectNotNull<TSource, TResult>(
                this IncrementalValuesProvider<TSource> source, Func<TSource, CancellationToken, TResult?> selector)
                where TResult : struct
        {
            return source.SelectMany((source, ct) =>
                    selector(source, ct) is { } result ? ImmutableArray.Create(result) : ImmutableArray<TResult>.Empty);
        }

        public static IncrementalValuesProvider<TSource> SelectNotNull<TSource>(this IncrementalValuesProvider<TSource?> source)
                where TSource : struct
        {
            return source.SelectMany(static (source, _) =>
                    source is { } result ? ImmutableArray.Create(result) : ImmutableArray<TSource>.Empty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T? AsNullable<T>(this T value) where T : struct => value;

        public static IncrementalValuesProvider<DiagnosedResult<TResult>> Select<TSource, TResult>(
            this IncrementalValuesProvider<DiagnosedResult<TSource>> source,
            Func<TSource, CancellationToken, TResult> selector)
        {
            return source.Select((result, ct) =>
            {
                return result.Select(s => selector(s, ct));
            });
        }

        public static IncrementalValuesProvider<DiagnosedResult<TResult>> SelectMany<TSource, TResult>(
            this IncrementalValuesProvider<DiagnosedResult<TSource>> source,
            Func<TSource, CancellationToken, ImmutableArray<TResult>> selector)
        {
            return source.SelectMany((result, ct) =>
            {
                return result.SelectMany(s => selector(s, ct));
            });
        }

        public static IncrementalValuesProvider<DiagnosedResult<(TLeft Left, TRight Right)>> Combine<TLeft, TRight>(
            this IncrementalValuesProvider<DiagnosedResult<TLeft>> left,
            IncrementalValueProvider<TRight> right)
        {
            return IncrementalValueProviderExtensions.Combine(left, right).Select((tuple, ct) =>
            {
                var (lhs, rhs) = tuple;
                return lhs.Select(v => (v, rhs));
            });
        }
    }
}
