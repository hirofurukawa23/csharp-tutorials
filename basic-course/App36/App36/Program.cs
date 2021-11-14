using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App36
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listを宣言する
            List<string> list = new List<string>();

            Console.WriteLine("Listに値を設定します。");

            //Listに値を設定する
            list.Add("John");
            list.Add("Smith");
            list.Add("Mark");

            Console.WriteLine("Listに値の設定が完了しました。");
            Console.WriteLine("・・・・・");
            Console.WriteLine("Listから値を取り出します。");

            //Listの値を表示する
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);

            Console.ReadLine();
        }
    }
}
