using System;
using System.Threading;

namespace _1._4_ThreadSafety
{
    class Program
    {
        static bool done = false;
        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
            Console.ReadKey();
        }

        static void Go()
        {
            if (!done)
            {
                Console.WriteLine("Done");
                done = true;
            }
        }
    }
}
