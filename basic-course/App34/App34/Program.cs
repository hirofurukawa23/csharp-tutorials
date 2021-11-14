using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 1; i <= 10; i++)
            {
                //配列に値を格納する
                array[i - 1] = i;
                Console.WriteLine("配列に値を格納：" + i.ToString());
            }

            Console.WriteLine("配列への値格納を完了！！");
            Console.WriteLine();

            //配列から値を取り出して表示する
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("配列の値を取得：" + array[i].ToString());
            }

            Console.WriteLine("配列からの値取得を完了！！");
            Console.ReadLine();
        }
    }
}
