using System;

namespace App06
{
    class Program
    {
        static void Main(string[] args)
        {
            //インスタンスを生成する
            Person Taro = new Person();
            Taro.Name = "Taro";

            Console.WriteLine("名前が設定されました。名前：" + Taro.Name);
            Console.ReadLine();
        }

        //人間クラス
        public class Person
        {
            //コンストラクター
            public Person()
            {
                Name = ""; //名前の初期化
                Console.WriteLine("初期化されました。名前：" + Name);
            }

            //名前
            public string Name;
        }
    }
}
