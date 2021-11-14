using System;
using System.Collections.Generic;
using System.Linq;

namespace App22
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 5, 1, 4, 3, 2, };

            //キーを指定して並び替える
            var orderBy = list.OrderBy(x => x);
            foreach(var item in orderBy)
            {
                Console.WriteLine($"OrderBy ：{ item.ToString() }");
            }

            Console.WriteLine();

            //キーを指定して逆順に並び替える
            var orderByDecend = list.OrderByDescending(x => x);
            foreach (var item in orderByDecend)
            {
                Console.WriteLine($"OrderByDescending ：{ item.ToString() }");
            }

            Console.WriteLine();

            //コレクションを逆転させる
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine($"Reverse ：{ item.ToString() }");
            }
            Console.ReadLine();
        }
    }
}
