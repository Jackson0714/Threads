using System;
using System.Threading;

namespace _2._13_ExceptionHandling_Remedy
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Console.ReadKey();
        }

        static void Go()
        {
            try
            {
                throw null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
