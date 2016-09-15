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

        [TestMethod]
        public void TestMethod2()
        {
            string str = "fuck you";
            byte[] salt = { };
            byte[] key = { };
            CryptoUtil.GetRandomNumber(8, str,out salt,out key);

            Console.WriteLine(str);
        }
    }
}
