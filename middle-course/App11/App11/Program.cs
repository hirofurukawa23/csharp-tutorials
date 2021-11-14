using System;

namespace App11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Taroさんをインスタンス化する
            Person Taro = new Person();
            Taro.Name = "Taro";
            Taro.WriteName();

            //Hanakoさんをインスタンス化する
            Person Hanako = new Person();
            Hanako.WriteName();
            //再設定する
            Hanako.Name = "Hanako";
            Hanako.WriteName();

            Console.ReadLine();
        }

        //人間クラス
        public class Person
        {
            //コンストラクター
            public Person()
            {
                _name = "";
            }

            //プロパティ
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            //フィールド
            private string _name;

            //メソッド
            public void WriteName()
            {
                if(_name == "")
                {
                    Console.WriteLine("名前を設定してください。");
                }
                else
                {
                    Console.WriteLine("I'm " + _name);
                }
            }
        }
    }
}
