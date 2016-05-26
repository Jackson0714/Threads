using System;
using System.Threading;

namespace _2._8_LambdaExpressionsAndCapturedVariables_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int temp = i;
                new Thread(() => Console.Write(temp)).Start();
            }
            Console.ReadKey();
        }
    }
}
