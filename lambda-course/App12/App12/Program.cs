using System;

namespace App12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力してください。");
            int input = Convert.ToInt32(Console.ReadLine());

            //Funcを起動するメソッドを呼び出す
            GetMessage(x => x > 9 ? "10以上の数です" : "10未満の数です", input);
            Console.ReadLine();
        }

        //Funcを起動するメソッド
        private static void GetMessage(Func<int, string> func, int input)
        {
            //funcを起動してメッセージを受け取り出力する
            string message = func(input);
            Console.WriteLine(message);
        }
    }
}
