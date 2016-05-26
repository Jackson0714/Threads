using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4_AsynchoronousDelegateInvocation
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> t = Go;
            IAsyncResult result = t.BeginInvoke("test", null, null);
            //
            // ... 这里可以执行其他并行的任务
            //

            int length = t.EndInvoke(result);
            Console.WriteLine("String lenth is： " + length);
            Console.ReadKey();
        }

        static int Go(string messsage)
        {
            return messsage.Length;
        }
    }
}
