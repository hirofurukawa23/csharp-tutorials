using System;

namespace App04
{
    class Program
    {
        static void Main(string[] args)
        {
            //太朗酸を生成する
            Person Taro = new Person();
            Taro.Name = "太朗";

            //太朗さんの名前を出力する
            Console.WriteLine(Taro.Name);
            Console.ReadLine();
        }

        //人間を定義するクラス
        public class Person
        {
            //名前
            public string Name;
        }
    }
}
