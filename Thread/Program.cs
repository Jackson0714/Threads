using System;
using System.Threading;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteY);//创建一个线程
            thread.Start();//开始一个线程

            for (int i = 0; i < 1000; i++)//主线程执行循环
            {
                Console.Write("x");
            }

            Console.ReadLine();
        }
        static void WriteY()
        {
            for (int i = 0; i < 1000; i++)
            { 
                Console.Write("y"); 
            }
        }
    }
}
