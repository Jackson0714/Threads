/*
作者：Jackson
日期：2016/01/14
描述：串行执行Main中的代码和Add方法
博客：http://jackson0714.cnblogs.com/
*/
using System;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace APM_SimpleDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(TimeSpan.FromSeconds(10));


            Func<int,int> addDelegate = Add;

            Console.WriteLine("Starting Main function----------------------");
            //设置主线程的名字
            Thread.CurrentThread.Name = "Main Thread";
            string message = "I'm here!";
            //异步执行Add方法
            addDelegate.BeginInvoke(2, AddCallback, message);
            //主线程执行3s的操作（模拟耗时操作）
            for (int i = 1; i < 4; i++)
            {
                //延时1s
                Thread.Sleep(TimeSpan.FromSeconds(1));
                //打印出当前线程的名称和在这个循环中执行的时间
                Console.WriteLine("     {0} started {1} second(s)", Thread.CurrentThread.Name, i);
            }
            //主线程挂起，以免程序退出，看不到结果
            Console.WriteLine("Read key-------------------");
            Console.ReadKey();
        }

        /// <summary>
        /// 回调方法
        /// </summary>
        /// <param name="ar">异步操作的状态</param>
        private static void AddCallback(IAsyncResult ar)
        {
            //ar.AsyncState获取用户定义的对象，它限定或包含关于异步操作的信息，这里就是Main方法里面传递message= "I'm here!";
            string message = (string)ar.AsyncState;
            //必须先将IAsyncResult转换为AsyncResult，才能获取到引用的委托,因为它没有包含在IAsyncResult接口的定义中。
            AsyncResult result = (AsyncResult)ar;
            Func<int, int> myDelegate = (Func < int, int>) result.AsyncDelegate;
            //调用EndInvoke方法，获取执行Add方法的返回值
            int sum = myDelegate.EndInvoke(ar);
            //调用sum的结果
            Console.WriteLine("AddCallback-----Thread.CurrentThread.Name:{0}-----Add方法执行的结果:{1}", Thread.CurrentThread.Name, sum);
            Console.WriteLine("         {0} ", Thread.CurrentThread.Name);
        }
        /// <summary>
        /// Add方法
        /// </summary>
        /// <param name="num">for循环执行的次数</param>
        /// <returns>sum</returns>
        private static int Add(int num)
        {
            //判断当前线程是不是线程池线程
            if (Thread.CurrentThread.IsThreadPoolThread)
            {
                //设置当前线程的名字为Pool Thread
                Thread.CurrentThread.Name = "Pool Thread";
            }
            Console.WriteLine("     Starting Add function------");
            int sum = 0;
            for (int i = 1; i < num+1; i++)
            {
                sum += i;
                //延时1s
                Thread.Sleep(TimeSpan.FromSeconds(1));
                //打印出当前线程的名称和在这个循环中执行的时间
                Console.WriteLine("         {0} started {1} second(s)", Thread.CurrentThread.Name, i);
            }
            Console.WriteLine("     End Add function-------");
            return sum;
        }

    }
}
