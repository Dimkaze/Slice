using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using HelloWorldCore;
namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";
        [TestMethod]
        public void TestMethod1()
        {
            Point a = new Point(4,5);
            HelloWorldCore.Program.Main();
            Assert.AreEqual(a.X, 4);
        }
    }
}