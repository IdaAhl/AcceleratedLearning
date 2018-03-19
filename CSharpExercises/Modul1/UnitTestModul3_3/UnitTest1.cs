using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Modul3_3;


namespace UnitTestModul3_3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
        }

        [TestMethod]
        public void TestReverseName()
        {
            int x = 5;
            

            int result = Program.Test(x);
            Assert.AreEqual(result, x);

        }
    }
}
