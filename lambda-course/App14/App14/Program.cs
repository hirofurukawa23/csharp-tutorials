using System;
using System.Linq;

namespace App14
{
    class Program
    {
        static void Main(string[] args)
        {
            //1から10までのコレクションを作成する
            var numbers = Enumerable.Range(1, 10);
            foreach(var item in numbers.Where(x => x % 2 == 0))
            {
                //偶数だけを出力する
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
