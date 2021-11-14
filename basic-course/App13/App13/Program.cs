using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("あなたはappleとそれ以外の果物でどちらを知りたいですか？");
            string input = Console.ReadLine();

            if(input == "apple")
            {
                Console.WriteLine("リンゴは赤い果物です。");
            }
            else
            {
                Console.WriteLine("リンゴ以外の果物です。");
            }

            Console.WriteLine("処理を終了します。");
            Console.ReadLine();
        }
    }
}
