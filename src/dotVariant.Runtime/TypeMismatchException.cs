//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using System;

namespace dotVariant
{
    /// <summary>
    /// An attempt was made to access a value of a variant that it did not hold.
    /// </summary>
    public sealed class TypeMismatchException : ArgumentException
    {
        public TypeMismatchException(string expected, string actual) : base($"Failed to match variant (expected '{expected}', actual '{actual}').")
        {
        }
    }
}
