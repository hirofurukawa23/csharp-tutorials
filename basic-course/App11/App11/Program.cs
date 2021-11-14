using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力してください。");

            int inputNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("入力値：");
            Console.WriteLine(inputNum.ToString());

            Console.ReadLine();
        }
    }
}
