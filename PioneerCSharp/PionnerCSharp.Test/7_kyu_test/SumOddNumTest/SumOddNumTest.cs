using NUnit.Framework;
using PioneerCSharp._7_kyu.SumOddNum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PionnerCSharp.Test._7_kyu_test.SumOddNumTest
{
    [TestFixture]
    public class SumOddNumTest
    {
        [Test]
        //[Ignore("Ignore a fixture")]
        public void ShouldThirdIndexReturn13()
        {
            Assert.AreEqual(64, Kata.rowSumOddNumber(4));
            //Assert.AreEqual(125, Kata.rowSumOddNumber(5));
        }

        [Test]
        //[Ignore("Ignore a fixture")]
        public void ShouldThirdIndexReturn1()
        {
            Assert.AreEqual(1, Kata.rowSumOddNumber(1));

        }

        [Test]
        public void ShouldThirdIndexReturn3Basis()
        {
           Assert.AreEqual(8, Kata.rowSumOddNumberBasis(2));
            Assert.AreEqual(8, Kata.rowSumOddNumberBasisRef(2));
            Assert.AreEqual(27, Kata.rowSumOddNumberBasisRef(3));
            Assert.AreEqual(64, Kata.rowSumOddNumberBasisRef(4));
            Assert.AreEqual(125, Kata.rowSumOddNumberBasisRef(5));
            Assert.AreEqual(74088, Kata.rowSumOddNumberBasisRef(42));
        }
    }
}
