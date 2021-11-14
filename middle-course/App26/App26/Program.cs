using System;

namespace App26
{
    class Program
    {
        static void Main(string[] args)
        {
            //タプルを作成する
            (int sum, int count) val = GetValue();

            //値を取り出して表示する
            Console.WriteLine(val.sum.ToString());
            Console.WriteLine(val.count.ToString());

            Console.ReadLine();
        }

        //タプルを戻り値とするメソッド
        private static (int sum, int count) GetValue()
        {
            return (100, 5);
        }
    }
}
