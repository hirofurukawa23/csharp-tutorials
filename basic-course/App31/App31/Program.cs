using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("繰り返し処理開始！！");

            for(int i = 1; i <= 20; i++)
            {
                if(i < 10)
                {
                    //10未満である場合は次のループ
                    Console.WriteLine("10未満の数です。");
                    continue;
                }

                Console.WriteLine(i.ToString() + "回目の処理");
            }

            Console.WriteLine("繰り返し処理終了！！");
            Console.ReadLine();
        }
    }
}
