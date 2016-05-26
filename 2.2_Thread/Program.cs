using System;
using System.Threading;

namespace _2._2_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Go);
            t.Start();
            Go();
            Console.ReadKey();
        }

        static void Go()
        {
            Console.WriteLine("Go");
        }
    }
}
