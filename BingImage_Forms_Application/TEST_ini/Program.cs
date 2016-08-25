using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TEST_ini
{
    class Program
    {
        #region 声明读写INI文件的API函数
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString
            (string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString
            (string section, string key, string defVal, StringBuilder retVal, int size, string filePath);
        #endregion

        static void Main(string[] args)
        {
            create_ini();
            string strSec = System.IO.Path.GetFileNameWithoutExtension("D:\\test.ini");
            Console.WriteLine(strSec);
            Console.WriteLine(ContentValue("TEST", "ID"));
            Console.WriteLine(ContentValue("TEST", "NAME"));
            Console.WriteLine(ContentValue("TEST2", "AGE"));
            Console.WriteLine(ContentValue("TEST2", "ADDR"));
            Console.ReadLine();
        }
    
        //创建ini文件
        public static void create_ini()
        {
            WritePrivateProfileString("TEST", "ID", "233", "D:\\abc\\test.ini");
            WritePrivateProfileString("TEST", "NAME", "xxy", "D:\\abc\\test.ini");
            WritePrivateProfileString("TEST", "AGE", "21", "D:\\abc\\test.ini");
            WritePrivateProfileString("TEST", "ADDR", "hefei", "D:\\abc\\test.ini");
            Console.Write("ini文件已创建");
        }
        //自定义读入ini文件
        public static string ContentValue(string Section, string key)
        {

            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString(Section, key, "", temp, 1024, "D:\\abc\\test.ini");
            return temp.ToString();
        }
    }
}
