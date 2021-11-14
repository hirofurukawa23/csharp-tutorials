using System;

namespace App31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名前を入力してください。");
            string name = Console.ReadLine();

            //デリゲートで受け取るメソッドを呼び出す
            Output(WriteHello, name);
        }

        //デリゲートの型
        private delegate void WriteString(string s);

        //デリゲートを使用するクラス
        static void Output(WriteString method, string s)
        {
            method(s);
        }

        //デリゲートで起動したい処理
        static void WriteHello(string s)
        {
            Console.WriteLine("Hello, " + s);
        }
    }
}
