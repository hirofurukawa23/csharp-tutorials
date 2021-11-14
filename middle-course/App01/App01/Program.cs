using System;

namespace App01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名前を入力してください。");
            string name = Console.ReadLine();
            
            //メッセージを取得するメソッド
            string message = GetMessage(name);
            //メッセージを表示するメソッド
            WriteMessage(message);

            Console.ReadLine();
        }

        //メッセージを取得するメソッド
        static private string GetMessage(string name)
        {
            return "Hello, " + name + "!";
        }

        //メッセージを表示するメソッド
        static private void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
