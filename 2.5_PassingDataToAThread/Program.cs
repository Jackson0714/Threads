using System;
using System.Threading;

namespace _2._5_PassingDataToAThread
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Thread(() =>
            //    {
            //        Console.WriteLine("a");
            //        Console.WriteLine("b");
            //    }).Start();

            new Thread(delegate()
            {
                Console.WriteLine("a");
                Console.WriteLine("b");
            }).Start();
            Console.ReadKey();
        }
    }
}
