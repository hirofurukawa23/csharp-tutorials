//App06
Console.WriteLine("仕事を依頼します。");

var task1 = Task.Run(() => DoHeavyWork("太郎"));
var task2 = Task.Run(() => DoHeavyWork("花子"));

Console.WriteLine("仕事を依頼しました。終わるまで待ちましょう。");

//すべてが完了するまで待機する
Task.WaitAll(new Task[] { task1, task2 });

Console.WriteLine("依頼した仕事が終わったようです。お疲れ様でした。");
Console.ReadLine();

//非同期処理を切り出したメソッド
static void DoHeavyWork(string name)
{
    Console.WriteLine($"{name}が重い処理を開始します。");
    Thread.Sleep(3000);
    Console.WriteLine($"{name}は仕事中です。");
    Thread.Sleep(3000);
    Console.WriteLine($"{name}が重い処理が終了しました。");
}