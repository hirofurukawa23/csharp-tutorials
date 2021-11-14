using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("何か入力してください。");

            string input = Console.ReadLine();

            Console.WriteLine();

            Console.Write("入力値は「");
            Console.Write(input);
            Console.Write("」でした。");

            Console.ReadLine();
        }
    }
}
