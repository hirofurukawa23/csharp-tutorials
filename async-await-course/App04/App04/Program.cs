//App04
Console.WriteLine("処理を開始します。");
var task = Task.Run(() =>
{
    Console.WriteLine("重い処理を開始します。");
    Thread.Sleep(10000);
    Console.WriteLine("重い処理を終了します。");
});
Console.WriteLine($"処理を待機させます。");

task.Wait();
Console.WriteLine($"重い処理が完了したので処理を再開します。");
Console.ReadLine();