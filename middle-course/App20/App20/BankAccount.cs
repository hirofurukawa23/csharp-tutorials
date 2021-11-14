namespace App20
{
    /// <summary>
    /// 銀行口座クラス
    /// </summary>
    public class BankAccount
    {
        //残高
        private int _totalAmount = 0;
        
        /// <summary>
        /// 銀行口座クラスのコンストラクタ
        /// </summary>
        /// <param name="init"></param>
        public BankAccount(int init)
        {
            _totalAmount = init;
        }

        /// <summary>
        /// 残高照会をするためのメソッド
        /// </summary>
        /// <returns></returns>
        public int GetAmount()
        {
            return _totalAmount;
        }

        /// <summary>
        /// 預金するためのメソッド
        /// </summary>
        /// <param name="depositAmount"></param>
        public void Deposit(int depositAmount)
        {
            _totalAmount += depositAmount;
        }

        /// <summary>
        /// 引き出しするためのメソッド
        /// </summary>
        /// <param name="withdrawAmount"></param>
        public void Withdraw(int withdrawAmount)
        {
            _totalAmount -= withdrawAmount;
        }
    }
}
