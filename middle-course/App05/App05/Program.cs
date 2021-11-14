using System;

namespace App05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taroさんをインスタンス化する
            Person Taro = new Person();
            Taro.Name = "Taro";

            Console.WriteLine(Taro.Name);
            Console.ReadLine();
        }

        //人間クラス
        public class Person
        {
            //コンストラクター
            public Person()
            {
                Console.WriteLine("コンストラクター");
            }

            //名前のプロパティ
            public string Name;
        }
    }
}
