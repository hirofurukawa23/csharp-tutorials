using System;
using System.Collections.Generic;

namespace App03
{
    class Program
    {
        /// <summary>
        /// デリゲートの定義
        /// </summary>
        /// <param name="src"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        delegate bool CheckMethod(List<int> src, int number);

        /// <summary>
        /// デリゲートの処理詳細部分
        /// </summary>
        /// <param name="src"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        private static bool HasNumberInList(List<int> src, int number)
        {
            if(src is null || src.Count <= 0)
            {
                //データソースが値を持たない場合
                return false;
            }

            foreach(var item in src)
            {
                if(item.Equals(number))
                {
                    //引数の数字と同一だったらTrueにする
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// デリゲートの実行箇所
        /// </summary>
        /// <param name="method"></param>
        /// <param name="src"></param>
        /// <param name="number"></param>
        private static void Executer(CheckMethod method, List<int> src, int number)
        {
            string message;
            if(method(src, number))
            {
                message = "入力された数値が存在します。";
            }
            else
            {
                message = "入力された数値は存在しません。";
            }
            Console.WriteLine(message);
        }

        /// <summary>
        /// メインの実行部分
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var list = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            };

            //数字以外を入力したら例外になりますが、今回は割愛します
            Console.WriteLine("数値を入力してください。");
            int input = Convert.ToInt32(Console.ReadLine());

            //実行処理
            Executer(HasNumberInList, list, input);
            Console.ReadLine();
        }
    }
}