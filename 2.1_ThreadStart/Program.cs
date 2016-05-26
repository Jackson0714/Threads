using System;
using System.Threading;

namespace _2._1_ThreadStart
{
    class ThreadTest
    {
        static void Main()
        {
            Thread t = new Thread(new ThreadStart(Go));
            t.Start(); 
            Go();
            Console.ReadKey();
        }

        static void Go()
        {
            Console.WriteLine("hello!");
        }
    }
}
