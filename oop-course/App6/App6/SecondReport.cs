namespace App6
{
    /// <summary>
    /// 帳票Bのクラス
    /// </summary>
    public class SecondReport : ReportBase
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        public SecondReport(int id) : base(id)
        {　}

        /// <summary>
        /// コンテンツ部分を取得する
        /// </summary>
        /// <returns></returns>
        public override string GetContent()
        {
            return $"合計金額：{ TotalAmount() }円";
        }

        /// <summary>
        /// ヘッダー部分を取得する
        /// </summary>
        /// <returns></returns>
        public override string GetHeader()
        {
            return $"帳票B（帳票ID：{ Id }）";
        }

        /// <summary>
        /// 合計金額を算出する
        /// </summary>
        /// <returns></returns>
        private int TotalAmount()
        {
            return 18000;
        }
    }
}
