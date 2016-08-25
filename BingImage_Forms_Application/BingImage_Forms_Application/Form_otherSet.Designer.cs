namespace BingImage_Forms_Application
{
    partial class Form_otherSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_Autochange = new System.Windows.Forms.CheckBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_Tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_Autochange
            // 
            this.checkBox_Autochange.AutoSize = true;
            this.checkBox_Autochange.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Autochange.Location = new System.Drawing.Point(42, 47);
            this.checkBox_Autochange.Name = "checkBox_Autochange";
            this.checkBox_Autochange.Size = new System.Drawing.Size(267, 21);
            this.checkBox_Autochange.TabIndex = 0;
            this.checkBox_Autochange.Text = "壁纸自动换：将当日必应美图自动设置为壁纸\r\n";
            this.checkBox_Autochange.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ok.Location = new System.Drawing.Point(140, 145);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "确定";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_Tip
            // 
            this.label_Tip.AutoSize = true;
            this.label_Tip.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Tip.ForeColor = System.Drawing.Color.Red;
            this.label_Tip.Location = new System.Drawing.Point(67, 71);
            this.label_Tip.Name = "label_Tip";
            this.label_Tip.Size = new System.Drawing.Size(203, 17);
            this.label_Tip.TabIndex = 3;
            this.label_Tip.Text = "↑此选项与服务器时间同步O(∩_∩)O↑";
            // 
            // Form_otherSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 180);
            this.Controls.Add(this.label_Tip);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.checkBox_Autochange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_otherSet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "其他设置";
            this.Load += new System.EventHandler(this.Form_otherSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Autochange;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label_Tip;
    }
}