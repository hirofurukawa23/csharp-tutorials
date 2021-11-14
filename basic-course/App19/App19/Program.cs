using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App19
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputA = Convert.ToInt32(Console.ReadLine());

            if(1 <= inputA && inputA <= 10)
            {
                Console.WriteLine("入力値は1以上、10以下の数です。");
            }

            Console.ReadLine();
        }
    }
}
