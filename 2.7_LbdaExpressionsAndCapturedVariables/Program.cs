using System;
using System.Threading;

namespace _2._7_LambdaExpressionsAndCapturedVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =0;i<10;i++)
            {
                new Thread(() => Console.Write(i)).Start();
            }
            Console.ReadKey();
        }
    }
}
