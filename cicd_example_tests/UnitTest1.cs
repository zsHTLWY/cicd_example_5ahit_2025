using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using cicd_example_lib;

namespace cicd_example_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Example e = new Example();

            Assert.IsTrue(e.getInfo() == "Hello CI/CD!");
        }
    }
}
