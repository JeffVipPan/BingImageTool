using System;
using System.Drawing;
using System.IO;
using System.Net;

namespace BingImage_Forms_Application
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        string ImageURL = null;
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_Day = new System.Windows.Forms.Label();
            this.label_Country = new System.Windows.Forms.Label();
            this.comboBox_Day = new System.Windows.Forms.ComboBox();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_Download = new System.Windows.Forms.Button();
            this.SetWallpaper = new System.Windows.Forms.Button();
            this.label_Info = new System.Windows.Forms.Label();
            this.label_About = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel_Bing = new System.Windows.Forms.LinkLabel();
            this.button_DowSet = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.label_state = new System.Windows.Forms.Label();
            this.button_downAll = new System.Windows.Forms.Button();
            this.button_viewDir = new System.Windows.Forms.Button();
            this.button_setDir = new System.Windows.Forms.Button();
            this.label_Dir = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button_otherSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Day
            // 
            this.label_Day.AutoSize = true;
            this.label_Day.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Day.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Day.Location = new System.Drawing.Point(36, 32);
            this.label_Day.Name = "label_Day";
            this.label_Day.Size = new System.Drawing.Size(52, 17);
            this.label_Day.TabIndex = 0;
            this.label_Day.Text = "日 期 ：";
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Country.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Country.Location = new System.Drawing.Point(36, 76);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(52, 17);
            this.label_Country.TabIndex = 1;
            this.label_Country.Text = "国 家 ：";
            this.label_Country.Click += new System.EventHandler(this.label_Country_Click);
            // 
            // comboBox_Day
            // 
            this.comboBox_Day.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Day.FormattingEnabled = true;
            this.comboBox_Day.Items.AddRange(new object[] {
            "明天",
            "今天",
            "昨天",
            "前天",
            "前3天",
            "前4天",
            "前5天",
            "前6天",
            "前7天",
            "前8天",
            "前9天",
            "前10天",
            "前11天",
            "前12天",
            "前13天",
            "前14天",
            "前15天"});
            this.comboBox_Day.Location = new System.Drawing.Point(95, 29);
            this.comboBox_Day.Name = "comboBox_Day";
            this.comboBox_Day.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Day.TabIndex = 2;
            this.comboBox_Day.SelectedIndexChanged += new System.EventHandler(this.comboBox_Day_SelectedIndexChanged);
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Items.AddRange(new object[] {
            "中国",
            "美国",
            "英国",
            "日本",
            "印度",
            "德国",
            "法国",
            "巴西",
            "加拿大",
            "澳大利亚"});
            this.comboBox_Country.Location = new System.Drawing.Point(95, 73);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Country.TabIndex = 3;
            this.comboBox_Country.SelectedIndexChanged += new System.EventHandler(this.comboBox_Country_SelectedIndexChanged);
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Search.Location = new System.Drawing.Point(291, 26);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "查 询";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(38, 187);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(427, 242);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_Download
            // 
            this.button_Download.Enabled = false;
            this.button_Download.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Download.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Download.Location = new System.Drawing.Point(291, 70);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(75, 23);
            this.button_Download.TabIndex = 6;
            this.button_Download.Text = "下 载";
            this.button_Download.UseVisualStyleBackColor = true;
            this.button_Download.Click += new System.EventHandler(this.button_Download_Click);
            // 
            // SetWallpaper
            // 
            this.SetWallpaper.Enabled = false;
            this.SetWallpaper.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetWallpaper.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SetWallpaper.Location = new System.Drawing.Point(372, 26);
            this.SetWallpaper.Name = "SetWallpaper";
            this.SetWallpaper.Size = new System.Drawing.Size(134, 23);
            this.SetWallpaper.TabIndex = 7;
            this.SetWallpaper.Text = "设 为 壁 纸";
            this.SetWallpaper.UseVisualStyleBackColor = true;
            this.SetWallpaper.Click += new System.EventHandler(this.SetWallpaper_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Info.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_Info.Location = new System.Drawing.Point(35, 149);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(122, 21);
            this.label_Info.TabIndex = 8;
            this.label_Info.Text = "请输入检索条件";
            this.label_Info.Click += new System.EventHandler(this.label_Info_Click);
            // 
            // label_About
            // 
            this.label_About.AutoSize = true;
            this.label_About.Location = new System.Drawing.Point(573, 420);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(119, 12);
            this.label_About.TabIndex = 9;
            this.label_About.Text = "©2016 Windroid Inc.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(33, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(512, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "还 原 壁 纸";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel_Bing
            // 
            this.linkLabel_Bing.AutoSize = true;
            this.linkLabel_Bing.Location = new System.Drawing.Point(583, 396);
            this.linkLabel_Bing.Name = "linkLabel_Bing";
            this.linkLabel_Bing.Size = new System.Drawing.Size(77, 12);
            this.linkLabel_Bing.TabIndex = 13;
            this.linkLabel_Bing.TabStop = true;
            this.linkLabel_Bing.Text = "访问Bing中国";
            this.linkLabel_Bing.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Bing_LinkClicked);
            // 
            // button_DowSet
            // 
            this.button_DowSet.Enabled = false;
            this.button_DowSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_DowSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_DowSet.Location = new System.Drawing.Point(372, 70);
            this.button_DowSet.Name = "button_DowSet";
            this.button_DowSet.Size = new System.Drawing.Size(134, 23);
            this.button_DowSet.TabIndex = 15;
            this.button_DowSet.Text = "下 载 并 设 为 壁 纸";
            this.button_DowSet.UseVisualStyleBackColor = true;
            this.button_DowSet.Click += new System.EventHandler(this.button_DowSet_Click);
            // 
            // button_About
            // 
            this.button_About.BackColor = System.Drawing.SystemColors.Control;
            this.button_About.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_About.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_About.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_About.Location = new System.Drawing.Point(585, 358);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(75, 23);
            this.button_About.TabIndex = 16;
            this.button_About.Text = "关于";
            this.button_About.UseVisualStyleBackColor = false;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_state.ForeColor = System.Drawing.Color.Red;
            this.label_state.Location = new System.Drawing.Point(508, 187);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(0, 21);
            this.label_state.TabIndex = 17;
            this.label_state.Click += new System.EventHandler(this.label_state_Click);
            // 
            // button_downAll
            // 
            this.button_downAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_downAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_downAll.Location = new System.Drawing.Point(512, 70);
            this.button_downAll.Name = "button_downAll";
            this.button_downAll.Size = new System.Drawing.Size(122, 23);
            this.button_downAll.TabIndex = 18;
            this.button_downAll.Text = "一键下载所有美图";
            this.button_downAll.UseVisualStyleBackColor = true;
            this.button_downAll.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_viewDir
            // 
            this.button_viewDir.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_viewDir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_viewDir.Location = new System.Drawing.Point(565, 114);
            this.button_viewDir.Name = "button_viewDir";
            this.button_viewDir.Size = new System.Drawing.Size(69, 23);
            this.button_viewDir.TabIndex = 19;
            this.button_viewDir.Text = "查看目录";
            this.button_viewDir.UseVisualStyleBackColor = true;
            this.button_viewDir.Click += new System.EventHandler(this.button_viewDir_Click);
            // 
            // button_setDir
            // 
            this.button_setDir.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_setDir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_setDir.Location = new System.Drawing.Point(490, 114);
            this.button_setDir.Name = "button_setDir";
            this.button_setDir.Size = new System.Drawing.Size(69, 23);
            this.button_setDir.TabIndex = 20;
            this.button_setDir.Text = "设置路径";
            this.button_setDir.UseVisualStyleBackColor = true;
            this.button_setDir.Click += new System.EventHandler(this.button_setDir_Click);
            // 
            // label_Dir
            // 
            this.label_Dir.AutoSize = true;
            this.label_Dir.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Dir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Dir.Location = new System.Drawing.Point(36, 117);
            this.label_Dir.Name = "label_Dir";
            this.label_Dir.Size = new System.Drawing.Size(68, 17);
            this.label_Dir.TabIndex = 21;
            this.label_Dir.Text = "美图位置：";
            this.label_Dir.Click += new System.EventHandler(this.label_Dir_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest_1);
            // 
            // button_otherSet
            // 
            this.button_otherSet.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_otherSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_otherSet.Location = new System.Drawing.Point(512, 159);
            this.button_otherSet.Name = "button_otherSet";
            this.button_otherSet.Size = new System.Drawing.Size(122, 23);
            this.button_otherSet.TabIndex = 22;
            this.button_otherSet.Text = "其他设置";
            this.button_otherSet.UseVisualStyleBackColor = true;
            this.button_otherSet.Click += new System.EventHandler(this.button_otherSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.button_otherSet);
            this.Controls.Add(this.label_Dir);
            this.Controls.Add(this.button_setDir);
            this.Controls.Add(this.button_viewDir);
            this.Controls.Add(this.button_downAll);
            this.Controls.Add(this.label_state);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_DowSet);
            this.Controls.Add(this.linkLabel_Bing);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_About);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.SetWallpaper);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.comboBox_Day);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.label_Day);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "必应美图小助手Beta1.36";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Day;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.ComboBox comboBox_Day;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Button SetWallpaper;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Label label_About;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel_Bing;
        private System.Windows.Forms.Button button_DowSet;
        private System.Windows.Forms.Button button_About;
        public System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Button button_downAll;
        private System.Windows.Forms.Button button_viewDir;
        private System.Windows.Forms.Button button_setDir;
        private System.Windows.Forms.Label label_Dir;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button button_otherSet;
    }
}
