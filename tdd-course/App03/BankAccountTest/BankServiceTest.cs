using App03.Repository;
using App03.Services;
using App03.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace BankAccountTest
{
    [TestClass]
    public class BankServiceTest
    {
        [TestMethod]
        public void CheckOnBalance_OK()
        {
            string writePath = @"C:\temp\balance.txt";
            string text = ((int)100).ToString();
            File.WriteAllText(writePath, text);

            string path = @"C:\temp\balance.txt";
            var repository = new BankRepository(path);

            var service = new BankService(repository);
            var balance = service.GetBalance();

            Assert.IsTrue(balance.Equals(new Money(100)));
        }

        [TestMethod]
        public void AddBalance_OK()
        {
            //初期金額
            string writePath = @"C:\temp\balance.txt";
            string text = ((int)100).ToString();
            File.WriteAllText(writePath, text);

            string path = @"C:\temp\balance.txt";
            var repository = new BankRepository(path);
            var service = new BankService(repository);

            //入金金額
            service.AddBalance(new Money(100));

            //残高照会
            var balance = service.GetBalance();
            Assert.IsTrue(balance.Equals(new Money(200)));
        }

        [TestMethod]
        public void Withdraw_OK()
        {
            //初期金額
            string writePath = @"C:\temp\balance.txt";
            string text = ((int)100).ToString();
            File.WriteAllText(writePath, text);

            string path = @"C:\temp\balance.txt";
            var repository = new BankRepository(path);

            //引出指示
            var service = new BankService(repository);
            service.Withdraw(new Money(40));

            //残高確認
            var balance = service.GetBalance();
            Assert.IsTrue(balance.Equals(new Money(60)));
        }

        [TestMethod]
        public void Withdraw_NG()
        {
            //初期金額
            string writePath = @"C:\temp\balance.txt";
            string text = ((int)100).ToString();
            File.WriteAllText(writePath, text);

            string path = @"C:\temp\balance.txt";
            var repository = new BankRepository(path);

            //引出指示
            try
            {
                var service = new BankService(repository);
                service.Withdraw(new Money(101));
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "残高以上の引き出しはできません。");
            }
        }

        [TestMethod]
        public void CanWithdraw_OK1()
        {
            string path = @"C:\temp\balance.txt";
            var repository = new BankRepository(path);
            var service = new BankService(repository);

            var balance = new Money(100);
            var ins = new Money(100);

            var canWithdraw = service.CanWithdraw(balance, ins);
            Assert.IsTrue(canWithdraw);
        }

        [TestMethod]
        public void CanWithdraw_OK2()
        {
            string path = @"C:\temp\balance.txt";
            var repository = new BankRepository(path);
            var service = new BankService(repository);

            var balance = new Money(100);
            var ins = new Money(99);

            var canWithdraw = service.CanWithdraw(balance, ins);
            Assert.IsTrue(canWithdraw);
        }

        [TestMethod]
        public void CanWithdraw_NG()
        {
            string path = @"C:\temp\balance.txt";
            var repository = new BankRepository(path);
            var service = new BankService(repository);

            var balance = new Money(100);
            var ins = new Money(101);

            var canWithdraw = service.CanWithdraw(balance, ins);
            Assert.IsFalse(canWithdraw);
        }
    }
}
