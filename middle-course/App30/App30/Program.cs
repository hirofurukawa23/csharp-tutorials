using System;

namespace App30
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

        //税込み価格を計算するメソッド
        static double CalcIncludeTax(int price)
        {
            //価格を変換して税込み価格を計算する
            return Convert.ToDouble(price) * (1 + Constants.TaxRate);
        }
    }
}
