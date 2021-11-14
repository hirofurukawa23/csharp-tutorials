using System;
using System.Collections.Generic;
using System.Linq;

namespace App15
{
    class Program
    {
        public class Menu
        {
            public int Price { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            var menuList = new List<Menu>()
            {
                new Menu(){ Price = 1500, Name = "ハンバーグ定食" },
                new Menu(){ Price = 900, Name = "唐揚げ定食" },
                new Menu(){ Price = 2000, Name = "ステーキセット" },
            };

            //1000円以上のメニューだけ表示する
            foreach(var menu in menuList.Where(x => x.Price >= 1000))
            {
                Console.WriteLine($"{ menu.Name }：{ menu.Price }円");
            }
            Console.ReadLine(); 
        }
    }
}
