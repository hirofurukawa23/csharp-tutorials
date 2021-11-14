using System;

namespace App02
{
    class Program
    {
        static void Main(string[] args)
        {
            //引数を指定して実行する
            WriteMessage("Mr.Monday");

            //引数なしで実行する
            WriteMessage();

            Console.ReadLine();
        }

        //引数に初期値「hoge」を持つメソッドを定義する
        static private void WriteMessage(string name = "hoge")
        {
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
