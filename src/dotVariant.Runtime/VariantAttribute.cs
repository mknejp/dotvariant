// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

using System;

namespace dotVariant
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
    public sealed class VariantAttribute : Attribute
    {
        public VariantAttribute() { }
    }
}
