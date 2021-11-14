using System;

namespace App14
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();

            //バスの一連の流れを表している
            bus.Forward();      //動き出す
            bus.Stop();         //信号で止まる
            bus.Forward();      //動き出す
            bus.Announce();     //停車する車内放送をする
            bus.Stop();         //停留所で止まる
            bus.Change();       //お釣りを払う
            bus.Announce();     //発射する車内放送をする
            bus.Forward();      //動き出す

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
            //車内放送メソッド
            public void Announce()
            {
                Console.WriteLine("車内放送をする。");
            }

            //お釣りの払い出しメソッド
            public void Change()
            {
                Console.WriteLine("お釣りを払いだす。");
            }
        }
    }
}
