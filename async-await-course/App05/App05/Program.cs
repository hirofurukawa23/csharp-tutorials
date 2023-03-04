//App05
//タスクを分けて実行する
Task.Run(() => DoHeavyWork("太郎"));
Task.Run(() => DoHeavyWork("花子"));

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