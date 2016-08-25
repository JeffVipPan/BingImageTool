using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace BingImage_Forms_Application
{
    /// <summary>
    /// 
    /// </summary>
    public static class AutoSetWall
    {
        #region 声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString
            (string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString
            (string section, string key, string defVal, StringBuilder retVal, int size, string filePath);
        #endregion

        //创建和修改ini文件
        public static void create_ini(string dir_img,string state_auto,string exe_path)
        {
            WritePrivateProfileString("BINGPHOTO", "ADDR", dir_img, Search.GetMyDocumentsURL() + "\\bingphoto.ini");
            WritePrivateProfileString("BINGPHOTO", "AUTO", state_auto, Search.GetMyDocumentsURL() + "\\bingphoto.ini");
            WritePrivateProfileString("BINGPHOTO", "EXE_PATH",exe_path, Search.GetMyDocumentsURL() + "\\bingphoto.ini");
        }
        //修改ADDR键值
        public static void updateAddr_ini(string dir_img)
        {
            WritePrivateProfileString("BINGPHOTO", "ADDR", dir_img, Search.GetMyDocumentsURL() + "\\bingphoto.ini");
        }
        //修改AUTO键值
        public static void updateAuto_ini(string state_auto)
        {
            WritePrivateProfileString("BINGPHOTO", "AUTO", state_auto, Search.GetMyDocumentsURL() + "\\bingphoto.ini");
        }
        //修改EXE_PATH键值
        public static void updateExePath_ini(string exe_path)
        {
            WritePrivateProfileString("BINGPHOTO", "EXE_PATH", exe_path, Search.GetMyDocumentsURL() + "\\bingphoto.ini");
        }
        //判断ini文件是否存在，不存在则在默认位置创建ini文件
        public static void judge_ini()
        {
            if (!System.IO.File.Exists(Search.GetMyDocumentsURL() + "\\bingphoto.ini"))
                create_ini(Search.GetMyDocumentsURL() + "\\BingPhoto", "0", getRunPath());
        }
        //读取ini文件，返回key字段
        public static string read_ini(string key)
        {
            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString("BINGPHOTO", key, "", temp, 1024, Search.GetMyDocumentsURL() + "\\bingphoto.ini");
            return temp.ToString();
        }
        //获取当前运行程序的绝对路径
        public static string getRunPath()
        {
            string str = Process.GetCurrentProcess().MainModule.FileName;
            return str;
        }
    }
}
