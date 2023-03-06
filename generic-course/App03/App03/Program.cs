//App03
var c1 = new SampleClass<int>();
var ret1 = c1.Max(1, 10);
Console.WriteLine(ret1.ToString());

var c2 = new SampleClass<double>();
var ret2 = c2.Max(0.8, 0.9);
Console.WriteLine(ret2.ToString());

var c3 = new SampleClass<float>();
var ret3 = c3.Max(3, 2);
Console.WriteLine(ret3.ToString());

Console.ReadLine();

public class SampleClass<T> where T : IComparable
{
    public T Max(T a, T b)
    {
        return a.CompareTo(b) >= 0 ? a : b;
    }
}