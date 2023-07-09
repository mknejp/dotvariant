// SPDX-FileCopyrightText: 2021 The dotVariant Authors (see AUTHORS.txt)
//
// SPDX-License-Identifier: BSL-1.0

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

    internal sealed class Disposable : Helper, IDisposable
    {
        public Disposable(Action f)
        {
            _f = f;
        }
        private readonly Action _f;

        public void Dispose()
        {
            _f();
        }
    }
}
