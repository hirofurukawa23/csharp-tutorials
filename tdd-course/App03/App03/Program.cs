using App03.ValueObjects;
using System;

namespace App03
{
    class Program
    {
        static ApplicationService _service;
        static void Main(string[] args)
        {
            _service = new ApplicationService();

            while(true)
            {
                Console.WriteLine();
                var selectedMenu = GetSelectedMenu();
                if (selectedMenu == Menu.Incorrect)
                {
                    Console.WriteLine("正しいメニュー番号を選択してください。");
                    continue;
                }

                if (selectedMenu == Menu.Done)
                {
                    ShowClose();
                    Console.ReadLine();
                    break;
                }

                if (!ProcessSelectedMenu(selectedMenu))
                {
                    Console.WriteLine();
                    continue;
                }
            }
        }

        enum Menu { Incorrect = 0, Deposit = 1, Withdraw = 2, Done = 3 }
        static Menu GetSelectedMenu()
        {
            ShowMenu();
            var input = Console.ReadLine();
            if (int.TryParse(input, out var num))
            {
                switch(num)
                {
                    case 1:
                        return Menu.Deposit;
                    case 2:
                        return Menu.Withdraw;
                    case 3:
                        return Menu.Done;
                    default: 
                        return Menu.Incorrect;
                }
            }
            return Menu.Incorrect;
        }

        static bool ProcessSelectedMenu(Menu menu)
        {
            ShowInstruction();
            var txt = Console.ReadLine();
            if (!CanConvert(txt)) { return false; }
            var inputMoney = ConvertMoney(txt);

            BankDto result = null;
            if (menu == Menu.Deposit)
            {
                result = _service.Execute(
                new BankDto()
                {
                    ProcessType = Process.Deposit,
                    Input = inputMoney
                });
            }
            else if (menu == Menu.Withdraw)
            {
                result = _service.Execute(
                    new BankDto()
                    {
                        ProcessType = Process.Withdraw,
                        Input = inputMoney,
                    });
            }
            if (result != null && string.IsNullOrEmpty(result.Message))
            {
                ShowBalance(result.Balance);
                return true;
            }
            else
            {
                Console.WriteLine(result.Message);
                return false;
            }
        }

        static bool CanConvert(string txt)
        {
            if (int.TryParse(txt, out var num))
            {
                return num >= 0;
            }
            return false;
        }

        static Money ConvertMoney(string txt)
        {
            return new Money(int.Parse(txt));
        }

        static void ShowMenu()
        {
            Console.WriteLine("行いたい操作のメニュー番号を入力してください。");
            Console.WriteLine("１：入金     2：出金     ３：終了");
        }

        static void ShowInstruction()
        {
            Console.WriteLine("金額を入力してください。");
        }

        static void ShowBalance(Money money)
        {
            Console.WriteLine($"残高：{ money.Value }円");
        }

        static void ShowClose()
        {
            Console.WriteLine("終了します。");
        }
    }
}
