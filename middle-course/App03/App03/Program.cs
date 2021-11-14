using System;

namespace App03
{
    class Program
    {
        static void Main(string[] args)
        {
            //第二引数を記述しない場合
            int result1 = CalcNum(10);
            Console.WriteLine("最初の結果：" + result1.ToString());

            //第二引数を記述する場合
            int result2 = CalcNum(10, true);
            Console.WriteLine("2つ目の結果：" + result2.ToString());

            Console.ReadLine();
        }

        //引数によって処理を変えるメソッド
        static private int CalcNum(int value, bool IsSquared = false)
        {
            if(IsSquared == false)
            {
                //通常なら2倍する
                return value * 2; 
            }
            else
            {
                //第二引数がtrueなら2乗する
                return value * value;
            }
        }
    }
}
