using Microsoft.VisualStudio.TestTools.UnitTesting;
using PioneerCSharp._7_kyu.ShortestWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PionnerCSharp.Test._7_kyu_test.ShortestWordTask
{
    [TestClass]
    public class ShortestWordTest
    {
        [TestMethod]
        public void DoesShowTheShortestWord()
        {
            Assert.AreEqual(5, ShortestWord.Compute("Stomil Legia"));
        }
    }
}
