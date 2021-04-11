//
// Copyright Miro Knejp 2021.
// Distributed under the Boost Software License, Version 1.0.
// (See accompanying file LICENSE.txt or copy at https://www.boost.org/LICENSE_1_0.txt)
//

using dotVariant.Test.Variants;
using NUnit.Framework;

namespace dotVariant.Test
{
    public static partial class Variant_Test
    {
        public static class Dispose
        {
            [Test]
            public static void If_active_member_is_disposable_its_Dispose_is_called()
            {
                var a = new DisposableVariant(new Disposable(() => Assert.Pass()));
                a.Dispose();
                Assert.Fail("Dispose() not called");
            }
        }
    }
}
