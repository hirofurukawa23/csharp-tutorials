using App03.Repository;
using App03.Services;
using App03.ValueObjects;
using System;

namespace App03
{
    public class ApplicationService
    {
        private readonly IRepository _repos;
        private readonly BankService _service;
        public ApplicationService()
        {
            string path = Constants.DbPath;
            this._repos = new BankRepository(path);
            this._service = new BankService(_repos);
        }

        public BankDto Initialize()
        {
            return new BankDto()
            { 
                Balance = _service.GetBalance(),
            };
        }

        public BankDto Execute(BankDto bankDto)
        {
            try
            {
                if (bankDto.ProcessType == Process.Deposit)
                {
                    var balance = _service.AddBalance(bankDto.Input);
                    return new BankDto()
                    {
                        Balance = balance
                    };
                }
                else if (bankDto.ProcessType == Process.Withdraw)
                {
                    var balance = _service.Withdraw(bankDto.Input);
                    return new BankDto()
                    {
                        Balance = balance
                    };
                }
                else
                {
                    return new BankDto()
                    {
                        Balance = _service.GetBalance()
                    };
                }
                
            }
            catch (Exception ex)
            {
                return new BankDto()
                {
                    Balance = _service.GetBalance(),
                    Message = ex.Message,
                };
            }
        }
    }

    public enum Process
    {
        Deposit, Withdraw
    }

    public class BankDto
    {
        public Money Input { get; set; }

        public Process ProcessType { get; set; }

        public Money Balance { get; set; }

        public string Message { get; set; }
    }
}
