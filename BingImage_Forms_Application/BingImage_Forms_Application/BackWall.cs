using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingImage_Forms_Application
{
    //BackWall类定义了“还原壁纸”的方法
    class BackWall
    {
        #region 获取windows桌面背景
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, StringBuilder lpvParam, int fuWinIni);
        private const int SPI_GETDESKWALLPAPER = 0x0073;
        #endregion
        //获取当前壁纸，并暂时保存
        public static string GetOldWallpaper_path()
        {
            //定义存储缓冲区大小
            StringBuilder s = new StringBuilder(300);
            //获取Window 桌面背景图片地址，使用缓冲区
            SystemParametersInfo(SPI_GETDESKWALLPAPER, 300, s, 0);
            //缓冲区中字符进行转换
            string OldWallpaper_path = s.ToString(); //系统桌面背景图片路径
            return OldWallpaper_path;
        }
        //撤销操作，还原原有壁纸【未使用该方法！！！！】
        public static void RestoreWallpaper()
        {
            Search.SetWallpaper(Search.GetMyDocumentsURL() + "\\temp.jpg");//设置旧壁纸
            MessageBox.Show("壁纸已还原！");
            //删除临时壁纸
        }
    }
}
