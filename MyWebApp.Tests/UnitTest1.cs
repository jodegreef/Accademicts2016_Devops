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
            IndexViewModel sut = new IndexViewModel();
            sut.BrowserRemembered = true;

            //throw new Exception("fail");
        }
    }
}
