using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // AreEqualの判定サンプル
            int num1 = 10;
            int num2 = 10;
            Assert.AreEqual(num1, num2);

            string hello1 = "おはよう";
            string hello2 = "おはよう";
            Assert.AreEqual(hello1, hello2);

            // IsTrueの判定サンプル
            bool flg = true;
            Assert.IsTrue(flg);

            int num3 = 5;
            Assert.IsTrue(num3 * 2 == 10);

            // IsFalseの判定サンプル
            bool flg2 = false;
            Assert.IsFalse(flg2);

            int num4 = 4;
            Assert.IsFalse(num4 * 3 == 13);

            // IsNullの判定サンプル
            int? num5 = null;
            Assert.IsNull(num5);

            // IsNotNullの判定サンプル
            int? num6 = 5;
            Assert.IsNotNull(num6);
        }
    }
}
