using App03.Repository;
using App03.ValueObjects;
using System;

namespace App03.Services
{
    public class BankService
    {
        readonly IRepository _repos;
        public BankService(IRepository repos)
        {
            _repos = repos;
        }

        public Money GetBalance()
        {
            return _repos.Read();
        }

        public Money AddBalance(Money add)
        {
            var balance = _repos.Read();
            var newBalance = balance.Add(add);
            _repos.Write(newBalance);
            return newBalance;
        }

        public Money Withdraw(Money withdraw)
        {
            var balance = _repos.Read();       
            if (!(CanWithdraw(balance, withdraw)))
            {
                throw new Exception("残高以上の引き出しはできません。");
            }

            var newBalance = balance.Subtract(withdraw);
            _repos.Write(newBalance);
            return newBalance;
        }

        public bool CanWithdraw(Money balance, Money ins)
        {
            return balance.Subtract(ins).Value >= 0;
        }
    }
}
