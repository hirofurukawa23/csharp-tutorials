using System;
using static App5.MessageFactory;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessage morning = MessageFactory.Create(MessageType.Morning);
            Console.WriteLine(morning.GetMessage());

            IMessage day = MessageFactory.Create(MessageType.Daytime);
            Console.WriteLine(day.GetMessage());

            IMessage nignt = MessageFactory.Create(MessageType.Night);
            Console.WriteLine(nignt.GetMessage());

            Console.ReadLine();
        }
    }
}
