using System;

namespace App18
{
    class Program
    {
        static void Main(string[] args)
        {
            Classes.Car car = new Classes.Car();
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