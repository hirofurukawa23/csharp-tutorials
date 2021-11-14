using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App35
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = new string[3];

            nameArray[0] = "John";
            Console.WriteLine(nameArray[0] + "を格納しました");

            nameArray[1] = "Queen";
            Console.WriteLine(nameArray[1] + "を格納しました");

            nameArray[2] = "King";
            Console.WriteLine(nameArray[2] + "を格納しました");

            Console.WriteLine();

            //配列の長さを取得する
            int length = nameArray.Length;
            Console.WriteLine("配列の長さ：" + length.ToString());

            //名前を表示する
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(nameArray[i]);
            }
            Console.ReadLine();
        }
    }
}
