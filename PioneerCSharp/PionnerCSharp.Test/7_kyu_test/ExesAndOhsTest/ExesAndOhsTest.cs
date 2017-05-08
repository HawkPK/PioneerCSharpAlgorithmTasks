using Microsoft.VisualStudio.TestTools.UnitTesting;
using PioneerCSharp._7_kyu.Exes_and_Ohs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PionnerCSharp.Test._7_kyu_test.ExesAndOhsTest
{
    [TestClass]
    public class ExesAndOhsTest
    {
        [TestMethod]
        public void IsNumberOfXANDOEqual()
       { 
            Assert.AreEqual(true, ExesAndOhs.Compute("ooxx"));
            Assert.AreEqual(true, ExesAndOhs.ComputeRef("ooxx"));
        }

        [TestMethod]
        public void IsNumberOfXANDONotEqual()
        {
            Assert.AreEqual(false, ExesAndOhs.Compute("ooxxx"));
            Assert.AreEqual(false, ExesAndOhs.ComputeRef("ooxxx"));
        }

        [TestMethod]
        public void IsIgnoreCaseSensitive()
        {
            Assert.AreEqual(true, ExesAndOhs.Compute("ooXxA"));
            Assert.AreEqual(true, ExesAndOhs.ComputeRef("ooXxA"));
        }
    }
}
