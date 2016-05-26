using System;
using System.Threading;

namespace _1._2_LocalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
            Console.ReadKey();
        }

        static void Go()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("y");
            }
        }
    }
}
