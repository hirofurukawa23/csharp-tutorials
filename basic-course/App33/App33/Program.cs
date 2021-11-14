using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App33
{
    class Program
    {
        static void Main(string[] args)
        {
            //格納数3の配列を宣言する
            string[] array = new string[3];

            //配列に値を設定する
            array[0] = "Tom";
            array[1] = "John";
            array[2] = "Bob";

            //配列から取り出して表示する
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);

            Console.ReadLine();
        }
    }
}
