namespace App18
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.Car car = new Classes.Car();
            System.Console.ReadLine();
        }
    }
}

namespace Classes
{
    public class Car
    {
        public Car()
        {
            System.Console.WriteLine("Carクラスが呼ばれました。");
        }
    }
}