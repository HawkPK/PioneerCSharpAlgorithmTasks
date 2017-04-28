using Microsoft.VisualStudio.TestTools.UnitTesting;
using PioneerCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PionnerCSharp.Test._7_kyu_test.SortArrayTest
{
    [TestClass]
    public class SortByValueAndIndexTest
    {
        [TestMethod]
        public void DoesSortCorrectlyExampleArray()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, SortByValueAndIndex.SortElement(new int[] { 1, 2, 3, 4, 5 }));
            CollectionAssert.AreEqual(new int[] { 2, 3, 4, 23, 5 }, SortByValueAndIndex.SortElement(new int[] { 23, 2, 3, 4, 5 }));
        }
    }
}
