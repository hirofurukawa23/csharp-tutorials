using System;

namespace App20
{
    class Program
    {
        static void Main(string[] args)
        {
            //初期入金額を入力させるためのループ
            int initAmount = 0;
            while(true)
            {
                Console.WriteLine("銀行口座を解説します。初期の入金額を入力してください。");
                string input = Console.ReadLine();
                if (!IsNumberInput(input))
                {
                    Console.WriteLine("数値を入力してください。");
                    continue;
                }
                else
                {
                    initAmount = Convert.ToInt32(input);
                    break;
                }
            }

            //銀行口座を開設する
            BankAccount bank = new BankAccount(initAmount);

            //銀行口座を操作するループ
            while(true)
            {
                Console.WriteLine("どの操作を行いますか？");
                Console.WriteLine("１：入金  ２：引き出し  ３：残高照会  ４：終了する");
                string input = Console.ReadLine();

                //メニューの入力値を判定する
                if(!IsValidMenu(input))
                {
                    Console.WriteLine("正しいメニューを選択してください。");
                    continue;
                }

                //メニューの入力値に対応する処理を実行する
                int menu = Convert.ToInt32(input);
                if (menu == 1)
                {
                    //入金が選択された場合
                    DisplayInstruction(1);
                    int inputNum = GetUserInput();
                    if(inputNum < 0)
                    {
                        Console.WriteLine("数値を入力してください。");
                        continue;
                    }
                    bank.Deposit(inputNum);
                }
                else if (menu == 2)
                {
                    //引き出しが選択された場合
                    DisplayInstruction(2);
                    int inputNum = GetUserInput();
                    if (inputNum < 0)
                    {
                        Console.WriteLine("数値を入力してください。");
                        continue;
                    }
                    bank.Withdraw(inputNum);
                }
                else if (menu == 3)
                {
                    //残高照会が選択された場合
                    int total = bank.GetAmount();
                    Console.WriteLine("合計金額は" + total + "円です。");
                }
                else if (menu == 4)
                {
                    //終了するが選択された場合
                    Console.WriteLine("アプリケーションを終了します。");
                    break;
                }
            }
        }

        /// <summary>
        /// ユーザーの入金金額を取得する
        /// ※マイナス値ならば入力エラーで返す
        /// </summary>
        /// <returns></returns>
        private static int GetUserInput()
        {
            string amount = Console.ReadLine();
            if (!IsNumberInput(amount))
            {
                return -1;
            }
            int addMoney = Convert.ToInt32(amount);
            return addMoney;
        }

        /// <summary>
        /// 数値が入力されたかを判定する
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool IsNumberInput(string input)
        {
            int num;
            if(int.TryParse(input, out num))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// メニューの入力が正しいかを判定する
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static bool IsValidMenu(string input)
        {
            //数値かどうかを判定する
            if(!IsNumberInput(input))
            {
                return false;
            }

            int menu = Convert.ToInt32(input);
            if(menu < 1 || menu > 4)
            {
                //1未満、もしくは4より大きい場合はメニュー外の入力
                return false;
            }

            return true;
        }

        /// <summary>
        /// メッセージを表示する処理
        /// </summary>
        /// <param name="input"></param>
        private static void DisplayInstruction(int input)
        {
            string menuMessage = "";
            if(input == 1)
            {
                menuMessage = "入金する";
            }
            else if(input == 2)
            {
                menuMessage = "引き出す";
            }
            Console.WriteLine(menuMessage + "金額を入力してください。");
        }
    }
}
