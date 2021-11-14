using System;

namespace App07
{
    class Program
    {
        //デリゲートの宣言
        delegate bool CheckMethod(int num);

        //デリゲートの実行部分
        static void WriteMessage(CheckMethod method, int num)
        {
            if(method(num))
            {
                Console.WriteLine("10以上の数です。");
            }
            else
            {
                Console.WriteLine("10未満の数です。");
            }
        }

        //メイン処理
        static void Main(string[] args)
        {
            //※数値以外を入力すると例外になるので注意！！
            Console.WriteLine("数値を入力してください。");
            int input = Convert.ToInt32(Console.ReadLine());

            //デリゲートの呼び出し部分
            WriteMessage((n) => n >= 10, input);
            Console.ReadLine();
        }
    }
}
