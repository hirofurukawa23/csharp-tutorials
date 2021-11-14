using System;

namespace App13
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();

            //基底クラスの処理
            bus.Forward();
            bus.Forward();
            bus.Stop();
            Console.ReadLine();
        }

        // 車クラス
        public class Car
        {
            //走るメソッド
            public void Forward()
            {
                Console.WriteLine("前に進む。");
            }

            //止まるメソッド
            public void Stop()
            {
                Console.WriteLine("止まる。");
            }
        }

        //バスクラス
        public class Bus : Car
        {
        }
    }
}
