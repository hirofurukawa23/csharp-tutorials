using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App20
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputB = Console.ReadLine();

            if (inputB == "apple" || inputB == "banana")
            {
                Console.WriteLine("入力値はapple、もしくはbananaでした。");
            }

            Console.ReadLine();
        }
    }
}
