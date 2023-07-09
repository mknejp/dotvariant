// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

using System;

namespace dotVariant.GeneratorSupport
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public static class Errors
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        [System.Diagnostics.CodeAnalysis.DoesNotReturn]
        public static void ThrowEmptyError(string name)
        {
            throw MakeEmptyError(name);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        [System.Diagnostics.CodeAnalysis.DoesNotReturn]
        public static T ThrowEmptyError<T>(string name)
        {
            throw MakeEmptyError(name);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        [System.Diagnostics.CodeAnalysis.DoesNotReturn]
        public static void ThrowInternalError(string name)
        {
            throw MakeInternalError(name);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        [System.Diagnostics.CodeAnalysis.DoesNotReturn]
        public static T ThrowInternalError<T>(string name)
        {
            throw MakeInternalError(name);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        [System.Diagnostics.CodeAnalysis.DoesNotReturn]
        public static void ThrowMismatchError(string name, string expected, string actual)
        {
            throw MakeMismatchError(name, expected, actual);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
        [System.Diagnostics.CodeAnalysis.DoesNotReturn]
        public static T ThrowMismatchError<T>(string name, string expected, string actual)
        {
            throw MakeMismatchError(name, expected, actual);
        }

        public static Exception MakeEmptyError(string name)
        {
            return new InvalidOperationException(name + " is empty.");
        }

        public static Exception MakeInternalError(string name)
        {
            return new InvalidOperationException(name + " has encountered an internal error. Please file an issue at https://github.com/mknejp/dotvariant");
        }

        public static Exception MakeMismatchError(string name, string expected, string actual)
        {
            return new InvalidOperationException($"Failed to match on {name} (expected: {expected}, actual: {actual}).");
        }
    }
}
