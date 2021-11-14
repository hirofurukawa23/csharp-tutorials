using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App21
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    /// <summary>
    /// 車クラス
    /// </summary>
    class Car
    {
        /// <summary>
        /// 車を走らせる処理を行います。
        /// </summary>
        /// <param name="speed">速度</param>
        public void Drive(int speed)
        {
            Console.WriteLine(speed.ToString() + "キロで走行中。");
        }
    }
}
