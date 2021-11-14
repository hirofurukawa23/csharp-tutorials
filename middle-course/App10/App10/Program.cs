using System;

namespace App10
{
    class Program
    {
        static void Main(string[] args)
        {
            //インスタンス化して名前を設定する
            Person person = new Person();
            person.Name = "Taro";

            //名前を表示する
            person.WriteName();

            string name = person.Name;
            Console.WriteLine("プロパティから取得：" + name);
            Console.ReadLine();
        }

        //人間クラス
        public class Person
        {
            //名前のプロパティ
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            //名前のフィールド（メンバ変数）
            private string _name;

            //publicメソッド
            public void WriteName()
            {
                string msg = GetMessage();
                Console.WriteLine(msg);
            }

            //privateメソッド
            private string GetMessage()
            {
                return "Hello, " + _name;
            }
        }
    }
}
