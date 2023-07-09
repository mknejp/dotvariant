// SPDX-FileCopyrightText: 2021 The dotVariant Authors.
//
// SPDX-License-Identifier: BSL-1.0

using System;

namespace dotVariant
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class NoImplicitConversionAttribute : Attribute
    {
        public NoImplicitConversionAttribute() { }
    }
}
