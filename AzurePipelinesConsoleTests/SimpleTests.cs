using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzurePipelinesConsoleTests
{
    [TestClass]
    public class SimpleTests
    {
        [TestMethod]
        public void Success_TestMethod()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void Fail_TestMethod()
        {
            Assert.AreEqual(1, 2);
        }
    }
}
