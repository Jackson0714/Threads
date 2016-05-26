using System;
using System.Threading;

namespace _1._6_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Go);
            t.Start();
            t.Join();
            Console.WriteLine("Thread t has ended!");
            Console.ReadKey();

        }
        static void Go()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("y");
            }
        }
    }
}
