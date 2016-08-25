using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TEST_Service
{
    class Program_TEST_Service
    {
        static void Main(string[] args)
        {
            //如果传递了"s"参数就启动服务
            if (args.Length > 0 && args[0] == "s")
            {
                //启动以服务方式执行程序
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                    new Service1(),
                };
                ServiceBase.Run(ServicesToRun);
            }
            //启动以常规方式执行程序
            else
            {
                Console.WriteLine("当前以常规方式启动程序");
                Console.WriteLine("请选择， [1]安装服务 [2]卸载服务 [3]退出");
                var rs = int.Parse(Console.ReadLine());
                switch (rs)
                {
                    case 1:
                        //取当前可执行文件路径，加上"s"参数，证明是从windows服务启动该程序
                        var path = Process.GetCurrentProcess().MainModule.FileName + " s";
                        Process.Start("sc", "create myserver binpath= \"" + path + "\" displayName= 我的服务 start= auto");
                        Console.WriteLine("安装成功");
                        StartService("myserver");
                        Console.Read();
                        break;
                    case 2:
                        Process.Start("sc", "delete myserver");
                        Console.WriteLine("卸载成功");
                        Console.Read();
                        break;
                    case 3: break;
                }
            }
        }
        //启动服务
        public static void StartService(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
            {
                if (service.ServiceName == serviceName)
                {
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0, 0, 30));
                }
            }
        }
        //停止服务
        public static void StopService(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
            {
                if (service.ServiceName == serviceName)
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Running, new TimeSpan(0, 0, 30));
                }
            }
        }

    }
}
