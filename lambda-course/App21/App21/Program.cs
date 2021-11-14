using System;
using System.Collections.Generic;
using System.Linq;

namespace App21
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 10, 15, 22, };

            //すべての要素が10以上であるか
            var allOne = list.All(x => x >= 10);
            Console.WriteLine($"All(x => x >= 10)：{ allOne }");
            //すべての要素が10未満であるか
            var allTwo = list.All(x => x < 10);
            Console.WriteLine($"All(x => x < 10)：{ allTwo }");


            var listTwo = new List<int>() { 5, 10, 99, };

            //10未満の要素が存在するか
            var anyOne = listTwo.Any(x => x < 10);
            Console.WriteLine($"Any(x => x < 10)：{ anyOne }");


            //100以上の要素が存在するか
            var anyTwo = listTwo.Any(x => x >= 100);
            Console.WriteLine($"Any(x => x >= 100)：{ anyTwo }");


            var listThree = new List<int>() { 10, 11, 12 };

            //要素に11を持っているか
            var containsOne = listThree.Contains(11);
            Console.WriteLine($"Contains(11)：{ containsOne }");

            //要素に100を持っているか
            var containsTwo = listThree.Contains(100);
            Console.WriteLine($"Contains(100)：{ containsTwo }");

            Console.ReadLine();
        }
    }
}
