//App02
Console.WriteLine("処理を開始します。");
var task = Task.Run(() =>
{
    Console.WriteLine("重い処理を開始します。");
    Thread.Sleep(10000);
    Console.WriteLine("重い処理が完了しました。");
    return 1;
});
Console.WriteLine($"{task.Result}が戻り値でした。");
Console.ReadLine();