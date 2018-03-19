using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modul3_3;

namespace UnitTestModul3_3
{
    [TestClass]
    public class UnitTestModul3_3
    {
        [TestMethod]
        public void TestMethod1()
        {
            var actual = ReverseName("Ida");

            Assert.AreEqual("adI", actual);
        }
    }
}
