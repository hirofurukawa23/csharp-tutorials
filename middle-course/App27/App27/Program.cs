using System;
using System.Collections.Generic;

namespace App27
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            //データを設定する
            students.Add(1, "Smith");
            students.Add(2, "John");
            students.Add(3, "Maria");

            //2番を取り出す
            string name = students[2];
            Console.WriteLine("取り出した値：" + name);
            Console.WriteLine();

            //前から取り出す
            foreach(KeyValuePair<int, string> student in students)
            {
                Console.Write("キー：" + student.Key.ToString() + " ");
                Console.WriteLine("バリュー：" + student.Value.ToString());
            }
            Console.ReadLine();
        }
    }
}
