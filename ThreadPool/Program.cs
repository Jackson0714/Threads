using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task =  Task.Factory.StartNew(Go);
            task.Wait();
            Console.ReadKey();
        }

        static void Go()
        {
            Console.WriteLine("From the thread pool start...");
            Thread.Sleep(3000);
            Console.WriteLine("From the thread pool end");
        }
    }
}
