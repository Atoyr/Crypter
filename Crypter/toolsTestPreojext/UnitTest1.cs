using System;
using tools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace toolsTestPreojext
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AesCrypto a = new AesCrypto();
            a.KeySize = 129;
        }
    }
}
