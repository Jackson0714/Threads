using System;
using System.Threading;

namespace _2._6_PassingDataToAThread_ThreadStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Print);
            t.Start("A");
            Console.ReadKey();
        }
        static void Print(object messageObj)
        {
            string message = (string)messageObj;//必须进行转换
            Console.WriteLine(message);
        }
    }
}
