using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sample = new App01.Sample();
            Assert.IsFalse(sample.ReturnTrue());
        }
    }
}
