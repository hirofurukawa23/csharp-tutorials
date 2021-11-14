namespace App6
{
    /// <summary>
    /// 帳票Aのクラス
    /// </summary>
    public class FirstReport : ReportBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        public FirstReport(int id) : base(id)
        { }

        /// <summary>
        /// コンテンツ部分を取得する
        /// </summary>
        /// <returns></returns>
        public override string GetContent()
        {
            return $"合計金額：{ GetAmount() }円";
        }

        /// <summary>
        /// ヘッダー部分を取得する
        /// </summary>
        /// <returns></returns>
        public override string GetHeader()
        {
            return $"帳票A（帳票ID：{ Id }）";
        }

        /// <summary>
        /// 合計金額を算出する
        /// </summary>
        /// <returns></returns>
        private int GetAmount()
        {
            return 11000;
        }
    }
}
