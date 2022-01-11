using App03;
using App03.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace BankAccountTest
{
    [TestClass]
    public class ApplicationServiceTest
    {
        [TestMethod]
        public void InitializeTest()
        {
            string writePath = @"C:\temp\balance.txt";
            string text = ((int)100).ToString();
            File.WriteAllText(writePath, text);

            var app = new ApplicationService();
            var args = app.Initialize();

            //初期残高の確認
            Assert.IsTrue(args.Balance.Equals(new Money(100)));
        }

        [TestMethod]
        public void DepositTest_OK()
        {
            //初期残高
            string writePath = @"C:\temp\balance.txt";
            string text = ((int)0).ToString();
            File.WriteAllText(writePath, text);
            
            //入金処理
            var app = new ApplicationService();
            var arg = app.Execute(
                new BankDto()
                {
                    ProcessType = Process.Deposit,
                    Input = new Money(100),
                });

            //預金の確認
            Assert.IsTrue(arg.Balance.Equals(new Money(100)));
        }

        [TestMethod]
        public void WithdrawTest_OK()
        {
            //初期残高
            string writePath = @"C:\temp\balance.txt";
            string text = ((int)100).ToString();
            File.WriteAllText(writePath, text);

            //入金処理
            var app = new ApplicationService();
            var arg = app.Execute(
                new BankDto()
                {
                    ProcessType = Process.Withdraw,
                    Input = new Money(10),
                });

            //残高の確認
            Assert.IsTrue(arg.Balance.Equals(new Money(90)));
        }

        [TestMethod]
        public void WithdrawTest_NG()
        {
            //初期残高
            string writePath = @"C:\temp\balance.txt";
            string text = ((int)100).ToString();
            File.WriteAllText(writePath, text);

            //入金処理
            var app = new ApplicationService();
            var arg = app.Execute(
                new BankDto()
                {
                    ProcessType = Process.Withdraw,
                    Input = new Money(101),
                });

            //メッセージと残高の確認
            Assert.AreEqual(arg.Message, "残高以上の引き出しはできません。");
            Assert.IsTrue(arg.Balance.Equals(new Money(100)));
        }
    }
}
