//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace dotVariant.Generator;

public static class DebugInfoCollector
{
    private static readonly object _lock = new();
    private static List<RenderInfo>? _renderInfos;

    [Conditional("DEBUG")]
    public static void AddRenderInfo(RenderInfo info)
    {
        lock (_lock)
        {
            var renderInfos = _renderInfos ??= new List<RenderInfo>();
            renderInfos.Add(info);
        }
    }

    public static List<RenderInfo> TakeRenderInfoList()
    {
        lock (_lock)
        {
            var list = Interlocked.Exchange(ref _renderInfos, null);
            return list ?? new List<RenderInfo>();
        }
    }
}
