//App07
Console.WriteLine($"作業を依頼します。");
DoAsync(new List<string>() { "花子", "太郎" });
Console.WriteLine($"作業の依頼が完了しました。");
Console.ReadLine();

static async void DoAsync(List<string> names)
{
    foreach(var name in names)
    {
        var res = await Task.Run(() =>
        {
            Console.WriteLine($"{name}さんが大変な作業を開始します。");
            Thread.Sleep(3000);
            Console.WriteLine($"{name}さんが大変な作業をしています。");
            Thread.Sleep(3000);
            Console.WriteLine($"{name}さんの作業が完了しました。");
            return true;
        });
    }
    Console.WriteLine($"{names.Count}人の処理が完了しました。");
}