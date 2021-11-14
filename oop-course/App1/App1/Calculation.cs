namespace App1
{
    /// <summary>
    /// 計算クラス
    /// </summary>
    public class Calculation
    {
        private int total;

        /// <summary>
        /// 足し算を行います。
        /// </summary>
        /// <param name="input"></param>
        public void Add(int input)
        {
            total += input;
        }

        /// <summary>
        /// これまでの合計を返却します。
        /// </summary>
        /// <returns></returns>
        public int GetTotal()
        {
            return total;
        }

        /// <summary>
        /// 数値かどうかを判定します。
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsNumber(string input)
        {
            return int.TryParse(input, out var num);
        }

        /// <summary>
        /// 入力値の桁数が適性範囲かを判定します。
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool LessThanMaxLength(string input)
        {
            return input.Length > 0 && input.Length <= 5;  
        }
    }
}
