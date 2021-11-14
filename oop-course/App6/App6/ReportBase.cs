namespace App6
{
    /// <summary>
    /// 帳票の基底クラス
    /// </summary>
    public abstract class ReportBase
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        public ReportBase(int id)
        {
            Id = id;
        }

        /// <summary>
        /// ヘッダー部分を取得する
        /// </summary>
        /// <returns></returns>
        public abstract string GetHeader();

        /// <summary>
        /// コンテンツ部分を取得する
        /// </summary>
        /// <returns></returns>
        public abstract string GetContent();
    }
}
