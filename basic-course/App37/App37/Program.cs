using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App37
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listを宣言する
            List<int> list = new List<int>();

            Console.WriteLine("Listに値を設定します・・・。");

            //Listに値を設定する
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("Listに値の設定が完了しました。");
            Console.WriteLine("続いて、Listから値を取り出します。");

            //Listから値を取り出す
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list[i].ToString());
            }

            Console.WriteLine("値の取り出しが完了しました。");
            Console.ReadLine();
        }
    }
}
