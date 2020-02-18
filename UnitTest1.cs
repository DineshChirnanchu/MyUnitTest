using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyUnittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3-2, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(12-9, 2+1);
        }
    }
}
