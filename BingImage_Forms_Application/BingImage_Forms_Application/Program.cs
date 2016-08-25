using System;
using System.IO;
using System.Windows.Forms;

namespace BingImage_Forms_Application
{
    public static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>   
        public static string old_wallpaper = BackWall.GetOldWallpaper_path();
        public static string fileUrl = null;
        public static string mkt;
        public static string Dir_Image = null;
        [STAThread]
        static void Main(string[] args)
        {
            //正常执行
            if (args != null)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //BackWall.GetOldWallpaper_path();
                Application.Run(new Form1());
                //MessageBox.Show(args);
            }
            //自动执行，自动设置壁纸
            else
            {
                //Search.DownLoadImage(ImageURL, Dir_Image);
                string content = Search.GetBingdata("0", "ZH-CN");
                Program.fileUrl = Search.GetBingImageUrl(content);
                int res=Search.DownLoadImage(Program.fileUrl,AutoSetWall.read_ini("ADDR"));
                Search.SetWallpaper(AutoSetWall.read_ini("ADDR") + "/" + Path.GetFileName(Program.fileUrl));
            }

        }
    }
}
