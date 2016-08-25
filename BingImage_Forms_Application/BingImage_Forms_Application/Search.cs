using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BingImage_Forms_Application
{
    //Search类定义了“查询图片”，“下载图片”，“设为壁纸”的方法
    class Search
    {
        //获取我的文档路径
        public static string GetMyDocumentsURL()
        {
            string MyDocumentsURL = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return MyDocumentsURL;
        }
        //GetBingdata方法获取用户输入的参数并将其传给GetHttpData方法
        public static string GetBingdata(string day, string mkt)
        {
            string url = "http://test.dou.ms/bing/day/" + day + "/mkt/" + mkt;
            Console.Write(url);
            return GetHttpData(url);
        }
        //GetHttpData方法读取URL页面内文本并返回
        public static string GetHttpData(string uri)
        {
            string result = null;
            Uri url = new Uri(uri);//初始化uri
            Stream stream = null;
            StreamReader reader = null;
            try
            {
                HttpWebRequest request = (System.Net.HttpWebRequest)WebRequest.Create(url);//初始化请求
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();//得到响应
                stream = response.GetResponseStream();//获取响应的主体
                reader = new StreamReader(stream);//初始化读取器
                result = reader.ReadToEnd();//读取，存储结果
                reader.Close();
                stream.Close();
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("请求数据超时！", "粗错辣", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        //GetBingImageUrl方法分割查询结果并获取图片地址
        public static string GetBingImageUrl(string str)
        {
            string[] strArray = str.Split(new string[] { "地址：" },
                StringSplitOptions.RemoveEmptyEntries);//RemoveEmptyEntries表示返回值不包括空元素
            return strArray[1];
        }
        //GetBingImageInfo方法分割查询结果并获取图片介绍
        public static string GetBingImageInfo(string str)
        {
            string[] strArray = str.Split(new string[] { "(" }, StringSplitOptions.RemoveEmptyEntries);
            return strArray[0];
        }

        /// <summary>
        /// DownLoadImage方法下载图片
        /// </summary>
        /// <param name="fileUrl">壁纸的路径</param>
        /// <param name="Dir_Image">壁纸存放目录</param>
        /// <returns>成功设置壁纸后返回1</returns>
        public static int DownLoadImage(string fileUrl, string Dir_Image)
        {
            if (!Directory.Exists(GetMyDocumentsURL() + "\\BingPhoto"))
            {
                Directory.CreateDirectory(GetMyDocumentsURL() + "\\BingPhoto");
                /*
                MessageBox.Show("美图保存目录不存在，并已创建！\n" + GetMyDocumentsURL() + "\\BingPhoto\\",
                "必应美图小助手", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                */
            }
            WebClient WebClient = new WebClient();
            WebClient.DownloadFile(fileUrl, Dir_Image + "/" + Path.GetFileName(fileUrl));
            Console.Write(Dir_Image + Path.GetFileName(fileUrl));
            return 1;
        }
        //SetWallpaper方法用以设置壁纸，设置成功返回1，否则返回0
        /*
        调用Windows API来实现，对应的方法SystemParametersInfo
        在"C:\Windows\System32\user32.dll"文件中，
        在C#中调用Windows API需要从DLL中导出函数（使用DllImport特性，
        需要引入System.Runtime.InteropServices命名空间）
        */
        [DllImport("user32.dll")]
        static extern bool SystemParametersInfo(int uAction, int uParam,
            string IpvParam, int fuWinIni);
        internal static void SetWallpaper(string Path)
        {
            SystemParametersInfo(20, 0, Path, 0x01 | 0x02);
        }
        //其他方法写在这！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！！
    }
}
