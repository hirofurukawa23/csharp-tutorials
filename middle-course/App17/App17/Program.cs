using System;
using Classes;

namespace App17
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.ReadLine();
        }
    }
}

namespace Classes
{
    public class Car
    {
        public Car()
        {
            Console.WriteLine("Carクラスが呼ばれました。");
        }
    }
}
