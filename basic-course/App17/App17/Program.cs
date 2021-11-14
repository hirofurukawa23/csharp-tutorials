using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力してください。");
            string input = Console.ReadLine();

            int convertedVal;
            bool isConverted = int.TryParse(input, out convertedVal);
            if(isConverted == true)
            {
                Console.Write("入力値：");
                Console.WriteLine(convertedVal.ToString());
            }
            else
            {
                Console.WriteLine("数値以外が入力されました。");
            }

            Console.ReadLine();
        }
    }
}