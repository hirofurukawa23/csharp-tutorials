using System;

namespace App07
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Taro = new Person();
            Taro.Name = "Taro desu.";
            //Taro.age = 18; ⇒ エラーとなる

            Console.WriteLine(Taro.Name);
            //Console.WriteLine(Taro.age.ToString()); ⇒ エラーとなる

            Console.ReadLine();
        }

        //人間クラス
        public class Person
        {
            public string Name; //名前
            private int age;    //年齢
        }
    }
}
