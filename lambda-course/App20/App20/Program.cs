using System;
using System.Linq;

namespace App20
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Enumerable.Range(1, 10);

            //先頭から2つの要素を飛ばして残りを取得する
            var skipList = list.Skip(2);
            foreach(var item in skipList)
            {
                Console.WriteLine($"Skip()：{ item.ToString() }");
            }

            Console.WriteLine();

            //先頭から4つの要素を取得する
            var takeList = list.Take(4);
            foreach (var item in takeList)
            {
                Console.WriteLine($"Take()：{ item.ToString() }");
            }

            Console.ReadLine();
        }
    }
}
