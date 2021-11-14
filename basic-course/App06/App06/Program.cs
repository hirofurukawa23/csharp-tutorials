using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App06
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = 20;
            int numberB = 3;
            
            int add = numberA + numberB;
            Console.WriteLine(add.ToString());
            
            int sub = numberA - numberB;
            Console.WriteLine(sub.ToString());
            
            int mul = numberA * numberB;
            Console.WriteLine(mul.ToString());
            
            int dev = numberA / numberB; 
            Console.WriteLine(dev.ToString());
            
            int mod = numberA % numberB;
            Console.WriteLine(mod.ToString());
            
            Console.ReadLine();
        }
    }
}
