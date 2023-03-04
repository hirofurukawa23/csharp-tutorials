//App01
Console.WriteLine("Taskでワーカースレッドに投げる前");
Task.Run(() =>
{
    //ワーカースレッド内の処理
    Console.WriteLine("重い処理を開始しました。");
    Thread.Sleep(10000);
    Console.WriteLine("重い処理を終了しました。");
});
Console.WriteLine("Taskでワーカースレッドに投げた後");
Console.ReadLine();