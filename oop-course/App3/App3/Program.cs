using System;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            //完全コンストラクタパターンでオブジェクトを生成
            var yamada = new Person("Yamada", 25);
            Console.WriteLine($"{ yamada.Name }さんの残りHPは{ yamada.HP }です。");

            //ファクトリメソッドでオブジェクトを生成
            var hoshino = Person.Create("Hoshino", 20);
            Console.WriteLine($"{ hoshino.Name }さんの残りHPは{ hoshino.HP }です。");
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; }
        public int HP { get; }

        public Person(string name, int hp)
        {
            Name = name;
            HP = hp;
        }

        public static Person Create(string name, int hp)
        {
            return new Person(name, hp);
        }
    }
}
