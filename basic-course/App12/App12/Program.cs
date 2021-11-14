using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("あなたが好きな果物はappleですか？それともbananaですか？");
            string input = Console.ReadLine();

            if(input == "apple")
            {
                Console.WriteLine("リンゴは健康にいいですね。");
            }
            Console.WriteLine("処理を終了します。");
            Console.ReadLine();
        }
    }
}
