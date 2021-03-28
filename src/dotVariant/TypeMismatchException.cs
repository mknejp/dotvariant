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
