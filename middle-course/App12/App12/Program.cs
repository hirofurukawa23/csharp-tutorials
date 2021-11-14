using System;

namespace App12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetName("Takashi");
            string name = person.GetName();

            Console.WriteLine("名前は" + name + "です。") ;

            Console.ReadLine();
        }

        public class Person
        {
            private string name;

            //名前を設定するメソッド
            public void SetName(string name)
            {
                this.name = name;
            }

            //名前を取得するメソッド
            public string GetName()
            {
                return name;
            }
        }
    }
}
