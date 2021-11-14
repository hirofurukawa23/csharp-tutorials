using System;
using System.Linq;

namespace App18
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Enumerable.Range(1, 20);
            
            //要素の一番最初を取得する
            var first = list.First();
            Console.WriteLine($"First()：{ first }");
            
            //要素の一番最初を取得する（存在がなければnullが返却）
            var firstOrDefault = list.FirstOrDefault();
            Console.WriteLine($"FirstOrDefault()：{ firstOrDefault }");

            //要素の一番最後を取得する
            var last = list.Last();
            Console.WriteLine($"Last()：{ last }");

            //要素の一番最後を取得する（存在がなければnullが返却）
            var lastOrDefault = list.LastOrDefault();
            Console.WriteLine($"LastOrDefault()：{ lastOrDefault }");

            Console.ReadLine();
        }
    }
}
