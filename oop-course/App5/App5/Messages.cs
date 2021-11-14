namespace App5
{
    /// <summary>
    /// 朝のメッセージクラス
    /// </summary>
    public class Morning : IMessage
    {
        public string GetMessage()
        {
            return "おはよう。";
        }
    }

    /// <summary>
    /// 昼のメッセージクラス
    /// </summary>
    public class Daytime : IMessage
    {
        public string GetMessage()
        {
            return "こんにちは。";
        }
    }

    /// <summary>
    /// 夜のメッセージクラス
    /// </summary>
    public class Night : IMessage
    {
        public string GetMessage()
        {
            return "こんばんは。";
        }
    }
}
