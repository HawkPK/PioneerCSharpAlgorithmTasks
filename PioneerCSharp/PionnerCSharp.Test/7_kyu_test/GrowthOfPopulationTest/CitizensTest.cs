using Microsoft.VisualStudio.TestTools.UnitTesting;
using PioneerCSharp._7_kyu.GrowthOfPopulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PionnerCSharp.Test._7_kyu_test.GrowthOfPopulationTest
{
    [TestClass]
    public class CitizensTestt
    {
        [TestMethod]
        public void DoesCityReach1200After2Years()
        {
            Assert.AreEqual(15, Citizens.GrowPopulation(1500, 5, 100, 5000));
            Assert.AreEqual(10, Citizens.GrowPopulation(1500000, 2.5, 10000, 2000000));
            Assert.AreEqual(94, Citizens.GrowPopulation(1500000, 0.25, 1000, 2000000));
        }
    }
}
