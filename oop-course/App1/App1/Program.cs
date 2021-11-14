using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("５桁以下の数値を入力してください。「=」の入力で合計が表示されます。 ");

            var calc = new Calculation();
            while(true)
            {
                var input = Console.ReadLine();

                //数値チェック
                if (!calc.IsNumber(input))
                {
                    if (input == "=") { break; } //処理終了
                    Console.WriteLine("数値を入力してください。");
                    continue;
                }

                //桁数チェック
                if (!calc.LessThanMaxLength(input))
                {
                    Console.WriteLine("1～5桁以下で入力してください。");
                    continue;
                }
                calc.Add(Convert.ToInt32(input));
            }
            Console.WriteLine($"合計値：{ calc.GetTotal()}");
            Console.ReadLine();
        }
    }
}
