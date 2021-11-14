using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App27
{
    class Program
    {
        static void Main(string[] args)
        {
            int sampleValue = 1;

            for(int i = 1; i <= 10; i++)
            {
                Console.Write("for文の中：");
                Console.Write(i.ToString() + "回目：");
                Console.WriteLine(sampleValue.ToString());
            }

            Console.Write("for文の外");
            Console.WriteLine(sampleValue.ToString());

            Console.ReadLine();
        }
    }
}
