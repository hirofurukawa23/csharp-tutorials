using System;

namespace App09
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.WriteMessage("Taro");
            //sample.GetMessage("Taro"); とはできない。

            Console.ReadLine();
        }

        //サンプルクラス
        public class Sample
        {
            //publicメソッド
            public void WriteMessage(string name)
            {
                string message = GetMessage(name);
                Console.WriteLine(message);
            }

            //privateメソッド
            private string GetMessage(string name)
            {
                return $"Hello, {name}";
            }
        }
    }
}
