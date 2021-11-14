using System;

namespace App04
{
    class Program
    {
        //デリゲートの宣言
        delegate void Output(string param);

        //デリゲートの実行部分
        static void WriteLoginName(Output method, string param)
        {
            method(param);
        }

        //メイン処理
        static void Main(string[] args)
        {
            //ログイン名を受け取る
            Console.WriteLine("ログイン名を入力してください。");
            var name = Console.ReadLine();

            //デリゲートを実行する
            WriteLoginName(
                delegate(string output)
                {
                    Console.WriteLine($"Hello, { output }!");
                },
                name);
            Console.ReadLine();
        }
    }
}
