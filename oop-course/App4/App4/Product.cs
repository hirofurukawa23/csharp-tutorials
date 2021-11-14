using System;

namespace App4
{
    /// <summary>
    /// 製品クラス
    /// </summary>
    public class Product
    {
        #region プロパティ
        /// <summary> 製品ID </summary>
        public int Id { get; }

        /// <summary> 価格 </summary>
        public int Price { get; }
        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id"></param>
        /// <param name="price"></param>
        public Product(int id, int price)
        {
            Id = id;
            Price = price;
        }

        /// <summary>
        /// 製品の税込価格を取得する
        /// </summary>
        /// <returns></returns>
        public int PriceIncludeTax()
            => Convert.ToInt32(Price * 1.1);
    }
}
