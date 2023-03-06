//App01
int a1 = 5, b1 = 6;
var ret1 = IntMax(a1, b1);
Console.WriteLine(ret1.ToString());

double a2 = 10, b2 = 13;
var ret2 = DoubleMax(a2, b2);
Console.WriteLine(ret2.ToString());

Console.ReadLine();

static int IntMax(int a, int b)
{
    return a >= b ? a : b;
}

static double DoubleMax(double a, double b)
{
    return a >= b ? a : b;
}