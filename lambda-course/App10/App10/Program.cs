using System;
using System.Collections.Generic;

namespace App10
{
    class Program
    {
        static void Main(string[] args)
        {
            //リストを作成する
            var list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            };

            //メソッドに処理を渡して実行する
            WriteNumbers(x => 
                Console.WriteLine($"数値は{ x }です。"),
                list);

            Console.ReadLine();
        }

        private static void WriteNumbers(Action<int> action,
            List<int> storage)
        {
            foreach(int item in storage)
            {
                //渡されたactionを実行する
                action(item);
            }
        }
    }
}
