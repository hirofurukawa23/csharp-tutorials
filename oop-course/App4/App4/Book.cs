namespace App4
{
    /// <summary>
    /// 本クラス
    /// </summary>
    public class Book : Product
    {
        #region プロパティ
        /// <summary> タイトル </summary>
        public string Title { get; }
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        /// <param name="price"></param>
        /// <param name="title"></param>
        public Book(int id, int price, string title) : base(id, price)
        {
            this.Title = title;
        }
    }
}
