using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App26
{
    class Program
    {
        static void Main(string[] args)
        {
            int sampleValue = 1;
            if(true)
            {
                Console.Write("if文の中：");
                Console.WriteLine(sampleValue.ToString());
            }
            Console.Write("if文の外：");
            Console.WriteLine(sampleValue.ToString());

            Console.ReadLine();
        }
    }
}
