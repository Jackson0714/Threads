using System.Threading.Tasks;

namespace _3._2_GenericTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string> task = Task.Factory.StartNew<string>(
                () => DownloadString("http://www.baidu.com"));
            //调用其他方法
            //

            //可以用task的Result的属性来获得task返回值。
            //如果这个任务还在运行，当前的主线程将会被阻塞，直到这个任务完成。
            string result = task.Result;
        }

        static string DownloadString(string uri)
        { 
            using(var wc = new System.Net.WebClient())
            {
                return wc.DownloadString(uri);
            }
        }
    }
}
