using System;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("１つ目の数字を入力してください。");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("２つ目の数字を入力してください。");
            int input2 = Convert.ToInt32(Console.ReadLine());

            var calc = new Calculation(input1, input2);
            var output = calc.Add();

            Console.WriteLine($"計算結果は { output.ToString() } です。");
            Console.ReadLine();
        }
    }

    public class Calculation
    {
        public int Input1 { get; }
        public int Input2 { get; }

        public Calculation(int input1, int input2)
        {
            this.Input1 = input1;
            this.Input2 = input2;
        }

        public int Add()
        {
            return Input1 + Input2;
        }
    }
}
