namespace App5
{
    /// <summary>
    /// メッセージファクトリ
    /// </summary>
    public static class MessageFactory
    {
        /// <summary>
        /// メッセージ種類
        /// </summary>
        public enum MessageType
        {
            /// <summary> 朝 </summary>
            Morning,
            /// <summary> 昼 </summary>
            Daytime,
            /// <summary> 夜 </summary>
            Night,
        }

        /// <summary>
        /// オブジェクトを生成する
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IMessage Create(MessageType type)
        {
            if (type == MessageType.Morning)
            {
                //朝のオブジェクトを返却する
                return new Morning();
            }
            if (type == MessageType.Daytime)
            {
                //昼のオブジェクトを返却する
                return new Daytime();
            }
            if (type == MessageType.Night)
            {
                //夜のオブジェクトを返却する
                return new Night();
            }
            return null;
        }
    }
}
