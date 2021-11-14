using System;

namespace App06
{
    class Program
    {
        //デリゲートの宣言
        delegate void Output(string str);

        //デリゲートの処理部分
        static private void Write(string input)
        {
            Console.WriteLine(input);
        }

        //デリゲートを使用する箇所
        static private void WriteLogin(Output process, string input)
        {
            process(input);
        }

        //メイン処理
        static void Main(string[] args)
        {
            Console.WriteLine("ログイン名を入力してください。");
            var input = Console.ReadLine();

            //デリゲート
            WriteLogin(Write, input);

            //匿名メソッド
            WriteLogin(delegate (string s)
            {
                Console.WriteLine(s);
            },
            input);

            //ラムダ式
            WriteLogin(
                (s) => Console.WriteLine(s),
                input);

            Console.ReadLine();
        }
    }
}
