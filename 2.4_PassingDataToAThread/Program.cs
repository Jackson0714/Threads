using System;
using System.Threading;

namespace _2._4_PassingDataToAThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() => Print("A"));
            t.Start();
            Console.ReadKey();
        }

        static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
