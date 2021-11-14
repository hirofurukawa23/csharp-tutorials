using System;

namespace App08
{
    class Program
    {
        static void Main(string[] args)
        {
            //メルセデスベンツ（仮）をインスタンス化する
            Car MyMercedes = new Car();

            //アクセルを踏む
            MyMercedes.Go();

            //ブレーキを踏む
            MyMercedes.Brake();

            Console.ReadLine();
        }

        //車クラス
        public class Car
        {
            public Car() { }

            //アクセルを踏む
            public void Go()
            {
                Console.WriteLine("進みます。");
            }

            //ブレーキを踏む
            public void Brake()
            {
                Console.WriteLine("止まります。");
            }
        }
    }
}
