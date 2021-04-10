//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using System;

namespace dotVariant.Test
{
    internal class Helper { }

    internal class ClassWithToString : Helper
    {
        public ClassWithToString(string s)
        {
            _s = s;
        }
        private readonly string _s;
        public override string ToString() => _s;
    }

    internal sealed class AlwaysEqual : Helper
    {
#if NULLABLE_ENABLED
        public override bool Equals(object? obj) => obj is AlwaysEqual;
#else
        public override bool Equals(object obj) => obj is AlwaysEqual;
#endif
        public override int GetHashCode() => throw new NotImplementedException();
    }

    internal sealed class NeverEqual : Helper
    {
#if NULLABLE_ENABLED
        public override bool Equals(object? obj) => false;
#else
        public override bool Equals(object obj) => false;
#endif
        public override int GetHashCode() => throw new NotImplementedException();
    }
}
