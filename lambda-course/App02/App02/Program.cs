using System;

namespace App02
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
        /// デリゲートを実行させるメソッド
        /// </summary>
        /// <param name="method">void型、引数１個（string型）のデリゲート</param>
        /// <param name="param"></param>
        private static void OutputProcessor(Output method, string param)
        {
            //デリゲートに引数を渡して実行する
            method(param);
        }

        /// <summary>
        /// メイン処理実行部分
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("ログイン名を入力してください。");
            var name = Console.ReadLine();

            //メソッドに処理とパラメーターを渡して実行させる
            OutputProcessor(WriteHello, name);

            Console.ReadLine();
        }
    }
}
