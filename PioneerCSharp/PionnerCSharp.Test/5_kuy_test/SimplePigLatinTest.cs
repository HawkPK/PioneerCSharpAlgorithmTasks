using NUnit.Framework;
using PioneerCSharp._5_kyu.SimplePigLatin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PionnerCSharp.Test._5_kuy_test
{
    [TestFixture]
    public class SimplePigLatinTest
    {
        [Test]
        public void PigItTest()
        {
            Assert.AreEqual("elloHay orldWay !", SimplePigLatin.PigIt("Hello World !"));     // elloHay orldWay !
            Assert.AreEqual("igPay atinlay siay oolcay", SimplePigLatin.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", SimplePigLatin.PigIt("This is my string"));
        }
    }
}
