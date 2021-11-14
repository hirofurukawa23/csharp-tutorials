using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("繰り返し処理開始！");

            for(int i = 1; i <= 20; i++)
            {
                if(i == 13)
                {
                    //13が見つかったら繰り返しから抜ける
                    Console.WriteLine("13が見つかりました。");
                    break;
                }

                Console.WriteLine(i.ToString() + "回目の処理");
            }

            Console.WriteLine("繰り返し処理終了！");
            Console.ReadLine();
        }
    }
}
