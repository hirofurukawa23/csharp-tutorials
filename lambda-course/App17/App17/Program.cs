using System;
using System.Collections.Generic;
using System.Linq;

namespace App17
{
    class Program
    {
        public class Menu
        {
            public List<int> Prices { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            var menues = new List<Menu>()
            {
                new Menu(){ Name="唐揚げ", Prices=new List<int>(){ 250, 300, 450 }, },
                new Menu(){ Name="たこ焼き", Prices=new List<int>(){ 320, 380, 400 }, },
                new Menu(){ Name="イカ焼き", Prices=new List<int>(){ 280, 320, 480 }, },
            };

            //シーケンスからPricesプロパティだけ取得して平坦化する
            var newList = menues.SelectMany(x => x.Prices);
            foreach(var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
