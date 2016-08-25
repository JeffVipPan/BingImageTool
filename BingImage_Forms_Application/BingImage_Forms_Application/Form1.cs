using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Threading;

namespace BingImage_Forms_Application
{
    public partial class Form1 : Form
    {
        //string old_wallpaper = BackWall.GetOldWallpaper_path();
        //string fileUrl = null;
        //string mkt;
        //string Dir_Image= null;

        public Form1()
        {
            InitializeComponent();
            comboBox_Day.Text = "今天";
            comboBox_Country.Text = "中国";
            Program.mkt = comboBox_Country.Text;//获得国家
            AutoSetWall.judge_ini();//判断ini文件是否存在，不存在则在默认位置创建ini文件
            Program.Dir_Image = AutoSetWall.read_ini("ADDR");
            label_Dir.Text = "美图位置：" + Program.Dir_Image;
            AutoSetWall.updateExePath_ini(AutoSetWall.getRunPath());
            //string aaaa = AutoSetWall.read_ini("ADDR");
            //string bbbb = AutoSetWall.read_ini("AUTO");
            //Console.WriteLine(aaaa);
            //Console.WriteLine(bbbb);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_Country_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //点击“查询”按钮，从fileUrl方法获得图片的URL，并创建预览
        private void button_Search_Click(object sender, EventArgs e)
        {
            label_state.Text = "正在查询......";
            string ChangeDay=null, ChangeMmkt=null;
            string day = comboBox_Day.Text;//获得日期
            //string mkt = comboBox_Country.Text;//获得国家
            //将显示名称转换为变量名
            switch (day)
            {
                case "明天":
                    ChangeDay = "-1";break;
                case "今天":
                    ChangeDay = "0"; break;
                case "昨天":
                    ChangeDay = "1"; break;
                case "前天":
                    ChangeDay = "2"; break;
                case "前3天":
                    ChangeDay = "3"; break;
                case "前4天":
                    ChangeDay = "4"; break;
                case "前5天":
                    ChangeDay = "5"; break;
                case "前6天":
                    ChangeDay = "6"; break;
                case "前7天":
                    ChangeDay = "7"; break;
                case "前8天":
                    ChangeDay = "8"; break;
                case "前9天":
                    ChangeDay = "9"; break;
                case "前10天":
                    ChangeDay = "10"; break;
                case "前11天":
                    ChangeDay = "11"; break;
                case "前12天":
                    ChangeDay = "12"; break;
                case "前13天":
                    ChangeDay = "13"; break;
                case "前14天":
                    ChangeDay = "14"; break;
                case "前15天":
                    ChangeDay = "15"; break;
            }
            switch (Program.mkt)
            {
                case "日本":
                    ChangeMmkt = "JA-JP";break;
                case "中国":
                    ChangeMmkt = "ZH-CN"; break;
                case "印度":
                    ChangeMmkt = "EN-IN"; break;
                case "德国":
                    ChangeMmkt = "DE-DE"; break;
                case "法国":
                    ChangeMmkt = "FR-FR"; break;
                case "英国":
                    ChangeMmkt = "EN-GB"; break;
                case "巴西":
                    ChangeMmkt = "PT-BR"; break;
                case "加拿大":
                    ChangeMmkt = "EN-CA"; break;
                case "美国":
                    ChangeMmkt = "EN-US"; break;
                case "澳大利亚":
                    ChangeMmkt = "EN-AU"; break;
            }
            try
            {
                label_state.Text = "正在查询……";
                string content = Search.GetBingdata(ChangeDay, ChangeMmkt);
                Program.fileUrl = Search.GetBingImageUrl(content);
                //Console.WriteLine(fileUrl);
                string FileInfo = Search.GetBingImageInfo(content);
                ImageURL = Program.fileUrl;                                  
                Image Bing_Image = Image.FromStream(WebRequest.Create(Program.fileUrl).GetResponse().GetResponseStream());
                pictureBox.Image = Bing_Image;
                button_Download.Enabled = true;//激活下载按钮
                button_DowSet.Enabled = true;//激活下载并设为壁纸按钮
                label_Info.Text = FileInfo;
                label_state.Text = "查询成功！";
            }
            catch (System.Net.WebException)
            {
                label_state.Text = "查询失败，服务器未响应";
            }

        }

        private void button_Download_Click(object sender, EventArgs e)
        {
            label_state.Text = "正在下载......";
            try
            {
                Search.DownLoadImage(ImageURL, Program.Dir_Image);
                button_Download.Enabled = false;
                SetWallpaper.Enabled = true;
                label_state.Text = "下载成功！";
            }
            catch (System.Net.WebException)
            {
                label_state.Text = "下载失败！";
            }
        }

        private void comboBox_Day_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetWallpaper.Enabled = false;
            button_DowSet.Enabled = false;
        }

        private void SetWallpaper_Click(object sender, EventArgs e)
        {
            Search.SetWallpaper(Program.Dir_Image + "/" + Path.GetFileName(Program.fileUrl));
            //MessageBox.Show("壁纸设置成功！" ,
            //"必应美图小助手", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            label_state.Text = "壁纸设置成功！";
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            Search.SetWallpaper(Program.old_wallpaper);
            //MessageBox.Show("壁纸已还原！",
            //"必应美图小助手", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            label_state.Text = "壁纸已还原！";
        }

        private void comboBox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_Bing_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://cn.bing.com");
        }

        private void button_DowSet_Click(object sender, EventArgs e)
        {
            try
            {
                Search.DownLoadImage(ImageURL, Program.Dir_Image);
            }
            catch (System.Net.WebException)
            {
                label_state.Text = "下载失败！";
            }
            button_Download.Enabled = false;
            SetWallpaper.Enabled = true;
            Search.SetWallpaper(Program.Dir_Image + "/" + Path.GetFileName(Program.fileUrl));
            //MessageBox.Show("壁纸设置成功！",
            //"必应美图小助手", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            label_state.Text = "壁纸设置成功！";
            button2.Enabled = true;

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button_About_Click(object sender, EventArgs e)
        {
            Form_About Form_About = new Form_About();
            Form_About.ShowDialog();
        }

        private void label_state_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //启动多个线程同时下载壁纸
            string[] day = new string[17]{"-1","0","1","2","3","4","5",
                "6","7","8","9","10","11","12","13","14","15"};
            //创建线程
            Thread[] threads = new Thread[17];//创建线程组
            string[] spa = new string[2];
            string ChangeMmkt=null;
            switch (Program.mkt)
            {
                case "日本":
                    ChangeMmkt = "JA-JP"; break;
                case "中国":
                    ChangeMmkt = "ZH-CN"; break;
                case "印度":
                    ChangeMmkt = "EN-IN"; break;
                case "德国":
                    ChangeMmkt = "DE-DE"; break;
                case "法国":
                    ChangeMmkt = "FR-FR"; break;
                case "英国":
                    ChangeMmkt = "EN-GB"; break;
                case "巴西":
                    ChangeMmkt = "PT-BR"; break;
                case "加拿大":
                    ChangeMmkt = "EN-CA"; break;
                case "美国":
                    ChangeMmkt = "EN-US"; break;
                case "澳大利亚":
                    ChangeMmkt = "EN-AU"; break;
            }
            for (int i = 0; i < 17; i++)//初始化线程组，准备参数
            {
                threads[i] = new Thread(new ParameterizedThreadStart(DownLoadThread));
                spa = new string[] { day[i], ChangeMmkt };
                threads[i].Start(spa);
            }
            for(int j = 0; j < 17; j++)
            {
                if (!threads[j].IsAlive)
                {
                    j = 0;
                    label_state.Text = "正在下载……";
                }
            }
            label_state.Text = "下载完成！";
        }
        //线程执行代码
        public void DownLoadThread(object DateAndCountry)
        {
            string[] strData = (string[])DateAndCountry;
            //string strcountry = country as string;
            int res = Search.DownLoadImage(
                Search.GetBingImageUrl(
                        Search.GetBingdata(strData[0], strData[1])), Program.Dir_Image);
        }

        private void button_viewDir_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Search.GetMyDocumentsURL() + "\\BingPhoto"))
            {
                Directory.CreateDirectory(Search.GetMyDocumentsURL() + "\\BingPhoto");
                MessageBox.Show("美图保存目录不存在，并已创建！\n" + Search.GetMyDocumentsURL() + "\\BingPhoto\\",
                "必应美图小助手", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            System.Diagnostics.Process.Start("explorer.exe", Program.Dir_Image);
        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {

        }

        private void button_setDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                label_Dir.Text = "美图位置："+folderBrowserDialog.SelectedPath;
                Program.Dir_Image = folderBrowserDialog.SelectedPath;
                AutoSetWall.updateAddr_ini(Program.Dir_Image);
            }
        }

        private void label_Info_Click(object sender, EventArgs e)
        {

        }

        private void button_otherSet_Click(object sender, EventArgs e)
        {
            Form_otherSet Form_otherSet = new Form_otherSet();
            Form_otherSet.ShowDialog();
        }

        private void label_Dir_Click(object sender, EventArgs e)
        {

        }
    }
}

