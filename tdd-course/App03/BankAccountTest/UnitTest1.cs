using App03.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankAccountTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateMoneyTest()
        {
            var money = new Money(100);
            Assert.AreEqual(money.Value, 100);
        }

        [TestMethod]
        public void AddMoneyTest_OK()
        {
            var money = new Money(100);
            var newMoney = money.Add(new Money(60)).Add(new Money(50));
            Assert.AreEqual(newMoney.Value, 210);
        }

        [TestMethod]
        public void AddMoneyTest_NG()
        {
            var money = new Money(100);
            var newMoney = money.Add(new Money(60));
            Assert.AreNotEqual(newMoney.Value, 150);
        }

        [TestMethod]
        public void SubtractMoneyTest_OK()
        {
            var money = new Money(100);
            var newMoney = money.Subtract(new Money(50)).Subtract(new Money(10));
            Assert.AreEqual(newMoney.Value, 40);
        }

        [TestMethod]
        public void SubtractMoneyTest_NG()
        {
            var money = new Money(100);
            var newMoney = money.Subtract(new Money(50));
            Assert.AreNotEqual(newMoney.Value, 60);
        }

        [TestMethod]
        public void MoneyEquals_OK()
        {
            var money = new Money(100);
            var otherMoney = new Money(100);
            Assert.IsTrue(money.Equals(otherMoney));
        }

        [TestMethod]
        public void MoneyEquals_NG()
        {
            var money = new Money(100);
            var otherMoney = new Money(110);
            Assert.IsFalse(money.Equals(otherMoney));
        }
    }
}
