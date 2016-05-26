using System;
using System.Threading;

namespace _2._10_NamingThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main Thread";
            Thread t = new Thread(Go);
            t.Name = "Worker Thread";
            t.Start();
            Go();
            Console.ReadKey();
        }

        static void Go()
        {
            Console.WriteLine("Go! The current thread is {0}", Thread.CurrentThread.Name);
        }
    }
}
