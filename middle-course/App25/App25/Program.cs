using System;

namespace App25
{
    class Program
    {
        static void Main(string[] args)
        {
            //（型 引数名, 型 引数名）のタプル
            (string name, int number) tuple = ("First", 1);

            //変更前
            Console.WriteLine("name:" + tuple.name);
            Console.WriteLine("number:" + tuple.number.ToString());
            Console.WriteLine();

            //値を変更する
            tuple.name = "changed";
            tuple.number = 1000;

            //変更後
            Console.WriteLine("name:" + tuple.name);
            Console.WriteLine("number:" + tuple.number.ToString());
            Console.ReadLine();
        }
    }
}
