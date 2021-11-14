using System;
using System.Collections.Generic;

namespace App6
{
    class Program
    {
        static void Main(string[] args)
        {
            //レポート生成処理を準備する
            var builder = new ReportBuilder();

            //帳票Aを生成して画面に表示する
            var firstReport = new FirstReport(1234);
            WriteReport(builder.Build(firstReport));

            //帳票Bを生成して画面に表示する
            var secondReport = new SecondReport(4567);
            WriteReport(builder.Build(secondReport));

            Console.ReadLine();
        }

        /// <summary>
        /// レポートを画面に表示する
        /// </summary>
        /// <param name="report"></param>
        private static void WriteReport(List<string> report)
        {
            foreach(var line in report)
            {
                //一行ごとにコンソールに出力する
                Console.WriteLine(line);
            }
            Console.WriteLine();    //最終行は改行を行う
        }
    }
}
