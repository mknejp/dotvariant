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
	}
}
