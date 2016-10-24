using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWebApp.Models;

namespace MyWebApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dummy sut = new Dummy();
            Assert.IsTrue(sut.SomeDummyMethodThatShouldReturnTrue());
        }
    }
}
