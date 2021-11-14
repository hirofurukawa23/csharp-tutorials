using System;

namespace App09
{
    class Program
    {
        //メインの処理
        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力してください。");
            int input = Convert.ToInt32(Console.ReadLine());

            //predicateの実行して、メッセージを取得して表示する
            string message = CheckNumber((x) => x >= 10, input);
            Console.WriteLine(message);
            Console.ReadLine();
        }

        ///数字をチェックする
        private static string CheckNumber(Predicate<int> method, int input)
        {
            if(method(input))
            {
                return "10以上の数です。";
            }
            else
            {
                return "10未満の数です。";
            }
        }
    }
}
