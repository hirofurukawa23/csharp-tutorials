using System;

namespace App23
{
    class Program
    {
        static void Main(string[] args)
        {
            //（型, 型）で定義
            (int, int) first = (100, 10);

            //要素の取り出し方
            Console.WriteLine("Item1:" + first.Item1.ToString());
            Console.WriteLine("Item2:" + first.Item2.ToString());

            Console.ReadLine();
        }
    }
}