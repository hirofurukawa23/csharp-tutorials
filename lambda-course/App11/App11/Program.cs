using System;
using System.Collections.Generic;

namespace App11
{
    class Program
    {
        static void Main(string[] args)
        {
            //処理で使用する値を取得する
            Console.WriteLine("数値を入力してください。");
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> storage = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            };

            //メソッドを実行する
            WriteNumbers((src, num) =>
                {
                    foreach(var item in src)
                    {
                        if(item.Equals(num))
                        {
                            Console.WriteLine("入力値は存在します。");
                            return;
                        }
                    }
                    Console.WriteLine("入力値は存在しません。");
                },
                storage,
                input);
            Console.ReadLine();
        }

        //Actionを起動させるメソッド
        private static void WriteNumbers(Action<List<int>, int> action,
                                         List<int> storage,
                                         int input)
        {
            //第一引数と第二引数を渡して処理を実行する
            action(storage, input);
        }
    }
}
