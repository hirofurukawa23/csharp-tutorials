using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("何か入力してください。");
            string input = Console.ReadLine();

            int convert;
            bool isSuccess = int.TryParse(input, out convert);

            if(isSuccess == true)
            {
                Console.WriteLine("数値に変換できます。");
            }
            else
            {
                Console.WriteLine("数値に変換できません。");
            }

            Console.ReadLine();
        }
    }
}
