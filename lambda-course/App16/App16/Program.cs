using System;
using System.Linq;

namespace App16
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Enumerable.Range(1, 10);

            //Selectメソッドを使用する
            var newList = numList.Select(x => x * x);

            foreach(var item in newList)
            {
                //コンソール画面に出力する
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
