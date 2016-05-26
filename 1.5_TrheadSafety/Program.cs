using System;
using System.Threading;

namespace _1._5_Lock
{
    class Program
    {
        static bool done = false;
        static readonly object locker = new object();
        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
            Console.ReadKey();
        }

        static void Go()
        {
            lock (locker)
            {
                if (!done)
                {
                    Console.WriteLine("Done");
                    done = true;
                }
            }
        }
    }
}
