using System;
using System.Threading;

namespace _1._3_ShareData
{
    class Program
    {
        bool done = false;
        static void Main(string[] args)
        {
            Program p= new Program();
            new Thread(p.Go).Start();
            p.Go();
            Console.ReadKey();
        }

        void Go()
        {
            if (!done)
            {
                done = true;
                Console.WriteLine("Done");
            }
        }
    }
}
