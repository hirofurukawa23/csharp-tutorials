using System;
using System.Collections.Generic;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            //オブジェクト群をインスタンス化する
            var book1 = new Book(1, 800, "素敵な本");
            var book2 = new Book(2, 900, "素晴らしい本");
            var book3 = new Book(3, 1000, "かっこいい本");

            //本棚に格納する
            var bookShelf = new List<Book>();
            bookShelf.Add(book1);
            bookShelf.Add(book2);
            bookShelf.Add(book3);

            //本棚を走査して内容を出力する
            foreach (var book in bookShelf)
            {
                Console.WriteLine($"商品ID：{ book.Id }");
                Console.WriteLine($"タイトル：{ book.Title}");
                Console.WriteLine($"税抜価格：{ book.Price }");
                Console.WriteLine($"税込価格：{ book.PriceIncludeTax() }");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
