using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PioneerCSharp._7_kyu;

namespace PionnerCSharp.Test
{
    [TestClass]
    public class TwoToOneTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("abc", TwoToOne.sortLetter("abc","abc"));
        }

        [TestMethod]
        public void IsDistinct()
        {
            Assert.AreEqual("abcdx", TwoToOne.sortLetter("bbac","xxcdd"));
        }
    }
}
