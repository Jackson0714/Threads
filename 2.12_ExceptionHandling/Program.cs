using System;
using System.Threading;

namespace _2._12_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new Thread(Go).Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception");
            }
            Console.ReadKey();
        }

        static void Go()
        {
            throw null;
        }
    }
}
