using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listを宣言する
            List<int> list = new List<int>();

            //Listに値を設定する
            list.Add(5);
            list.Add(15);
            list.Add(25);

            //Listの要素数を取得
            int count = list.Count;
            Console.WriteLine("Listの要素は" + count.ToString() + "個です。");

            //Listの中身を出力する
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Listの中身：" + i.ToString());
            }
            Console.ReadLine();
        }
    }
}
