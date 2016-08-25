using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Diagnostics;

namespace TEST_AutoRun
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine(a.RunPath());
            Console.ReadLine();
        }
        //获取程序运行的绝对路径
        string RunPath()
        {
            string str = Process.GetCurrentProcess().MainModule.FileName;
            return str;
        }
    }
}
