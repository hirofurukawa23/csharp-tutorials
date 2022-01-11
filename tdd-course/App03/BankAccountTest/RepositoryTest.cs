using App03.Repository;
using App03.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace BankAccountTest
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void ReadTest_OK()
        {
            string path = @"C:\temp\balance.txt";
            string text = ((int)10000).ToString();
            File.WriteAllText(path, text);

            IRepository repos = new BankRepository(path);
            var money = repos.Read();
            Assert.AreEqual(money.Value, 10000);
        }

        [TestMethod]
        public void ReadTest_NG()
        {
            string path = @"C:\temp\balance.txt";
            string text = "テスト";
            File.WriteAllText(path, text);

            IRepository repos = new BankRepository(path);
            var money = repos.Read();
            Assert.AreEqual(money.Value, 0);
        }

        [TestMethod]
        public void WriteTest_OK()
        {
            string path = @"C:\temp\balance.txt";
            IRepository repos = new BankRepository(path);
            var money = new Money(1000);
            repos.Write(money);

            var balance = repos.Read();
            Assert.AreEqual(money.Value, balance.Value);
        }
    }
}
