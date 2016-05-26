/*
作者：Jackson
日期：2016/01/14
描述：串行执行Main中的代码和Add方法
博客：http://jackson0714.cnblogs.com/
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _4._1_APM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Main function----------------------");
            //设置主线程的名字
            Thread.CurrentThread.Name = "Main Thread";
            //执行Add方法，其中有延时2s的操作（模拟耗时操作）
            int result = Add(2);
            //打印Add方法的结果
            Console.WriteLine("     Result:{0}", result);
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
