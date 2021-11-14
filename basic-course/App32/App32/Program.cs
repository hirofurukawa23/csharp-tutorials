using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App32
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while(true)
            {
                Console.WriteLine("This is an apple.");
                counter++;

                if (counter == 5)
                {
                    Console.Write("breakの直前：");
                    Console.WriteLine(counter.ToString() + "回目");
                    break;
                }
            }

            Console.WriteLine("ループから抜けました。");
            Console.ReadLine();
        }
    }
}
