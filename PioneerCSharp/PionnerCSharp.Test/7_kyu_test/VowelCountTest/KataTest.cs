using Microsoft.VisualStudio.TestTools.UnitTesting;
using PioneerCSharp._7_kyu.Vowel_Count;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PionnerCSharp.Test._7_kyu_test.VowelCountTest
{
    [TestClass]
    public class KataTest
    {
        [TestMethod]
        public void IsThere5Vowels()
        {
            Assert.AreEqual(5, Kata.GetVowelNumbers("abracadabra"));
            Assert.AreEqual(5, Kata.GetVowelsNumbersFresh("abracadabra"));
        }
    }
}
