using NUnit.Framework;
using PioneerCSharp._7_kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PionnerCSharp.Test._7_kyu_test
{
    [TestFixture]
    public class CreditMaskTest
    {
        [Test]
        public void ShouldReturnOne()
        {
            Assert.AreEqual("1", CreditMask.Maskify("1"));
        }

        [Test]
        public void ShouldReturnFours()
        {
            Assert.AreEqual("############5616", CreditMask.Maskify("4556364607935616"));
        }
    }
}
