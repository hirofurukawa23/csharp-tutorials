using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    class Program
    {
        static void Main(string[] args)
        {
            //入力値を受け取ってint型に変換する
            int inputValue = Convert.ToInt32(Console.ReadLine());

            if(inputValue < 0)
            {
                //変換後の数値が負の数の場合
                Console.WriteLine("負の数です。");
            }
            else if(inputValue < 10)
            {
                //変換後の数値が10より小さい場合
                Console.WriteLine("1桁の数値でした。");
            }
            else
            {
                //変換後の数値が10以上の場合
                Console.WriteLine("10以上の値です。");
            }

            Console.ReadLine();
        }
    }
}
