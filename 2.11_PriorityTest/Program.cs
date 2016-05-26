using System;
using System.Threading;

namespace _2._11_PriorityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() => Console.ReadKey());
            if (args.Length > 0)//如果Main方法没有传入参数
            {
                //设置线程为后台线程，等待用户输入。
                //因为主线程在t.Start()执行之后就会终止，
                //所以后台线程t会在主线程退出之后，立即终止，应用程序就会结束。
                t.IsBackground = true;
            }
            t.Start();
        }
    }
}
