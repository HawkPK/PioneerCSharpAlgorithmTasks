using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using PioneerCSharp._7_kyu;
using System.Text;
using System.Threading.Tasks;


namespace PionnerCSharp.Test._7_kyu_test
{
    [TestClass]
    public class RemoveMinimumTest
    {
        [TestMethod]
        public void Test1()
        {
            NUnit.Framework.CollectionAssert.AreEqual(new List<int> { 2, 3, 4, 5 }, RemoveMinimum.RemoveSmallestNumRefactor(new List<int> { 1,2,3,4,5}));
        }
    }
}
