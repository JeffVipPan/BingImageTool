using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThread
{
    class Program
    {
        public static void Thread_1()
        {
            Console.WriteLine("This is Thread1");
        }
        public static void Thread_2(object a)
        {
            Console.WriteLine("This is Thread2");
        }
        static void Main1(string[] args)
        {
            //ThreadStart childref = new ThreadStart(CallToChildThread);
            Thread childThread1 = new Thread(new ThreadStart(Thread_1));
            //Thread childThread2 = new Thread(new ParameterizedThreadStart(ChildThread2));
            Console.WriteLine("This is main Thread");
            //childThread2.Start("a");
            Console.WriteLine("********************************************");
            Thread[] threads = new Thread[17];//公共变量数组
            for (int i = 0 ; i < 17 ; i++)
            {
                threads[i] = new Thread(new ThreadStart(Thread_1));
            }
            for (int i = 0; i < 17; i++)
            {
                threads[i].Start();
            }
            Console.ReadKey();
        }
    }
}
