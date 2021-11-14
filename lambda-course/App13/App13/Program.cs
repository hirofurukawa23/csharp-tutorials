using System;

namespace App13
{
    class Program
    {
        static void Main(string[] args)
        {
            //匿名クラスを作成する
            var list = new[]
            {
                new { Name = "犬" },
                new { Name = "猫" },
                new { Name = "亀" },
            };

            //要素を抽出して表示する
            foreach(var item in list)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }
}
