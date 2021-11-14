using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("apple, banana, peachのどれかを入力してください。"); 
            string input = Console.ReadLine(); 
            
            if (input == "apple")
            {
                Console.WriteLine("リンゴは赤い果物です。"); 
            }
            else
            {
                if (input == "banana")
                {
                    Console.WriteLine("バナナは黄色い果物です。");
                }
                else
                {
                    Console.WriteLine("リンゴとバナナ以外の果物です。");
                }
            }

            Console.WriteLine("処理を終了します。"); 
            Console.ReadLine();
        }
    }
}
