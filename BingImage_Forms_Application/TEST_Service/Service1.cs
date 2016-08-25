using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TEST_Service
{
    partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: 在此处添加代码以启动服务。
            //服务执行代码
            Console.WriteLine("测试服务已启动！");
            System.IO.File.AppendAllText("D:\\log.txt", "服务已启动……\n" + DateTime.Now.ToString());
            Console.Read();
        }

        protected override void OnStop()
        {
            // TODO: 在此处添加代码以执行停止服务所需的关闭操作。
            Console.WriteLine("测试服务已停止！");
            System.IO.File.AppendAllText("D:\\log.txt", "服务已停止……\n" + DateTime.Now.ToString());
            Console.Read();
        }
    }
}
