using System;

namespace App28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数字を入力してください。");
            int input = Convert.ToInt32(Console.ReadLine());
            
            //5を足すメソッドを呼び出す
            int answer1 = Calculation.AlwaysAddFive(input);
            Console.WriteLine("5を足した結果：" + answer1.ToString());

            int answer2 = Calculation.AlwaysMultiFice(input);
            Console.WriteLine("5を掛け算結果：" + answer2.ToString());

            Console.ReadLine();
        }
    }
}
