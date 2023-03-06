//App02
int ret1 = Max<int>(10, 100);
Console.WriteLine(ret1.ToString());

double a = 0.1, b = 0.15;
double ret2 = Max(a, b);
Console.WriteLine(ret2.ToString());

float a1 = 10, b1 = 15;
var ret3 = Max<float>(a1, b1);
Console.WriteLine(ret3.ToString());

Console.ReadLine();

//ジェネリックメソッド
static T Max<T>(T a, T b) where T : IComparable
{
    return a.CompareTo(b) >= 0 ? a : b;
}