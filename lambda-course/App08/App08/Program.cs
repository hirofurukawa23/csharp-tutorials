using System;

namespace App08
{
    class Program
    {
        //デリゲートの宣言部分
        delegate double DiscountMethod(double input);

        //実行メソッド
        static private void Execute(DiscountMethod method, double input)
        {
            double resultNum = method(input);
            Console.WriteLine($"入力された値は{　resultNum　}になりました。");
        }

        //メイン処理
        static void Main(string[] args)
        {
            //数値以外を入力するとエラーになるので注意！！
            Console.WriteLine("数値を入力してください。");
            double input = Convert.ToDouble(Console.ReadLine());

            Execute((n) =>
            {
                if(n >= 10000)
                {
                    //nが10,000以上だったら5%割引する
                    return n * 0.95;
                }
                else
                {
                    return n;
                }
            },
            input);
            Console.ReadLine();
        }
    }
}
