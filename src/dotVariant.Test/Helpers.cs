//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using System;

namespace dotVariant.Test
{
    internal abstract class Helper { }

    internal sealed class AlwaysEqual : Helper
    {
        public override bool Equals(object? obj) => obj is AlwaysEqual;
        public override int GetHashCode() => throw new NotImplementedException();
    }

    internal sealed class NeverEqual : Helper
    {
        public override bool Equals(object? obj) => false;
        public override int GetHashCode() => throw new NotImplementedException();
    }
}
