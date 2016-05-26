using System;
using System.Threading;

namespace _2._9_PassingData_TemporaryVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "A";
            Thread a = new Thread(() => Console.WriteLine(text));

            text = "B";
            Thread b = new Thread(() => Console.WriteLine(text));

            a.Start();
            b.Start();

            Console.ReadKey();
        }
    }
}
