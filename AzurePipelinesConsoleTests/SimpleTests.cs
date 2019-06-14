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
    }
}
