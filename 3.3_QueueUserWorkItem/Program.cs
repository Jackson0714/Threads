using System;
using System.Threading;

namespace _3._3_QueueUserWorkItem
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Go);
            ThreadPool.QueueUserWorkItem(Go, 123);
            Console.ReadKey();
        }

        static void Go(object data)
        {
            Console.WriteLine("A from thread pool! " + data);
        }
    }
}
