using System;
using System.Collections.Generic;
using System.Linq;

namespace App19
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            int[] listToArray = list.ToArray();//List→配列
            foreach(var item in listToArray)
            {
                Console.WriteLine("ToArray()：" + item.ToString());
            }

            var array = new int[5] { 1, 2, 3, 4, 5 };
            List<int> arrayToList = array.ToList();//配列→List
            foreach (var item in arrayToList)
            {
                Console.WriteLine("ToList()：" + item.ToString());
            }
            Console.ReadLine();
        }
    }
}
