using System;
using System.Threading;

namespace _2._3_LambaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(()=>Console.WriteLine("Go"));
            t.Start();
            Console.ReadKey();
        }
    }
}
