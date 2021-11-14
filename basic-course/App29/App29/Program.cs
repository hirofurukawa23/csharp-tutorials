using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App29
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            do
            {
                Console.Write("if文の中：");
                Console.WriteLine(index.ToString());

                Console.WriteLine();
                index++;
            }
            while (index <= 10);

            Console.Write("処理終了：");
            Console.WriteLine("i = " + index.ToString());
            Console.ReadLine();
        }
    }
}
