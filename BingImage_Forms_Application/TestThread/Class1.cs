using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThread
{
    public class Thread_class
    {
        private string name;
        private int age;
        public Thread_class(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Thread_4()
        {
            Console.WriteLine("This is Thread4   ");
            Console.WriteLine(name);
            Console.WriteLine(age);
        }     
    }
    class Class1
    {
        public static void Thread_1()
        {
            Console.WriteLine("This is Thread1");
        }
        public static void Thread_2()
        {
            Console.WriteLine("This is Thread2");
        }
        public static void Thread_3(object str)
        {
            String putstr = (String)str;
            Console.WriteLine("This is Thread3   "+putstr);
        }
        public static void Thread_5(object str)
        {
            string[] message = (string[])str;
            Console.WriteLine("This is Thread5   ");
            for (int i = 0;i < 3;i++)
                Console.WriteLine(message[i]);
        }
        static void Main(string[] args)
        {
            Thread test1 = new Thread(Thread_1);
            Thread test2 = new Thread(Thread_2);
            
            string str = "Construction method with parameter";
            Thread test3 = new Thread(Thread_3);
            
            Thread_class threadclass = new Thread_class("Windroid",21);//创建线程类
            Thread test4 = new Thread(threadclass.Thread_4);//创建线程实例

            string[] message = new string[] { "I", "Love", "Microsoft" };
            Thread test5 = new Thread(Thread_5);

            test1.Start();
            test2.Start();
            test3.Start(str);
            test4.Start();
            test5.Start(message);
            Console.ReadKey();
        }
    }
}
