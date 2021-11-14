using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App18
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA = 10;
            int numB = 15;

            Console.WriteLine("関係演算子のサンプルです。");
            Console.Write("numA = ");
            Console.WriteLine(numA.ToString());
            Console.Write("numB = ");
            Console.WriteLine(numB.ToString());

            Console.WriteLine();

            Console.WriteLine("== のサンプル");
            if(numA == numB)
            {
                Console.WriteLine("numAとnumBは同じ値です。");
            }
            else
            {
                Console.WriteLine("numAとnumBは違う値です。");
            }
            Console.WriteLine();

            Console.WriteLine("!= のサンプル");
            if (numA != numB)
            {

                Console.WriteLine("numAとnumBは違う値です。");
            }
            else
            {
                Console.WriteLine("numAとnumBは同じ値です。");
            }
            Console.WriteLine();

            Console.WriteLine("< のサンプル");
            if (numA < numB)
            {
                Console.WriteLine("numAはnumBよりも小さい値です。");
            }
            else
            {
                Console.WriteLine("numAはnumB以上の値です。");
            }
            Console.WriteLine();

            Console.WriteLine("> のサンプル");
            if (numA > numB)
            {
                Console.WriteLine("numAはnumBよりも大きい値です。");
            }
            else
            {
                Console.WriteLine("numAはnumB以下の値です。");
            }
            Console.WriteLine();

            Console.WriteLine("<= のサンプル");
            if (numA <= numB)
            {
                Console.WriteLine("numAはnumB以下の値です。");
            }
            else
            {
                Console.WriteLine("numAはnumBより大きい値です。");
            }
            Console.WriteLine();

            Console.WriteLine(">= のサンプル");
            if (numA >= numB)
            {
                Console.WriteLine("numAはnumB以上の値です。");
            }
            else
            {
                Console.WriteLine("numAはnumBより小さい値です。");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
