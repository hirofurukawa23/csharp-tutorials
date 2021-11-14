using System;

namespace App24
{
    class Program
    {
        static void Main(string[] args)
        {
            //（型 引数名, 型 引数名）で定義
            (int sum, int count) second = (100, 10);

            //値を取り出す方法
            Console.WriteLine("sum:" + second.sum.ToString());
            Console.WriteLine("count:" + second.count.ToString());

            Console.ReadLine();
        }
    }
}
