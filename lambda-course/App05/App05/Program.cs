using System;
using System.Collections.Generic;

namespace App05
{
    class Program
    {
        //判定メソッド
        delegate bool CheckMethod(List<int> src, int checkNum);

        //判定処理の使用箇所
        private static void HasNumberInList(CheckMethod method, List<int> src, int number)
        {
            if(method(src, number))
            {
                Console.WriteLine($"{ number }は存在します。");
            }
            else
            {
                Console.WriteLine($"{ number }は存在しません。");
            }
        }

        //メイン処理関数
        static void Main(string[] args)
        {
            //チェック対象のリスト
            var list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            };

            //判定数値の入力
            Console.WriteLine("数値を入力してください。");
            var input = Convert.ToInt32(Console.ReadLine());

            //判定処理の実行
            HasNumberInList(
                delegate (List<int> src, int num)
                {
                    foreach(var item in src)
                    {
                        if(item == num)
                        {
                            //同じ数値があったら真
                            return true;
                        }
                    }
                    //同じのがなければ偽
                    return false;
                },
                list,
                input);
            Console.ReadLine();
        }
    }
}
