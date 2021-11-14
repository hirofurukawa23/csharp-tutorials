using System;

namespace App01
{
    class Program
    {
        /// <summary>
        /// デリゲートの宣言部分
        /// </summary>
        /// <param name="name"></param>
        delegate void Output(string name);

        /// <summary>
        /// デリゲートの実処理部分
        /// </summary>
        /// <param name="name"></param>
        private static void WriteHello(string name)
        {
            Console.WriteLine($"Hello, { name }!");
        }

        /// <summary>
        /// メイン処理実行部分
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("ログイン名を入力してください。");
            var name = Console.ReadLine();

            //Output型の変数として「WriteHello」の処理内容を設定する
            Output process = WriteHello;
            //デリゲートを実行する
            process(name);

            Console.ReadLine();
        }
    }
}
