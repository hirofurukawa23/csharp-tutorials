using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App28
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while (index <= 10)
            {
                Console.Write("if文の中：");
                Console.WriteLine(index.ToString());

                Console.WriteLine();
                index++;
            }

            Console.Write("処理終了：");
            Console.WriteLine("i = " + index.ToString());
            Console.ReadLine();
        }
    }
}
