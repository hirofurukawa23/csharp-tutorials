using System;

namespace App29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("商品の価格を入力してください。（小数点を含んだ値で返します）");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //税込み価格の算出
            double priceIncludesTax = CalcIncludeTax(price);

            Console.WriteLine("税込み価格：" + priceIncludesTax + "円");
            Console.ReadLine();
        }

        //定数：税率（注：仮に8%としている）
        const double TaxRate = 0.08;

        //税込み価格を計算するメソッド
        static double CalcIncludeTax(int price)
        {
            //価格を変換して税込み価格を計算する
            return Convert.ToDouble(price) * (1 + TaxRate);
        }
    }
}
