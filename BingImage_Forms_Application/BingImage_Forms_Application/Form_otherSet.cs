using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BingImage_Forms_Application
{
    public partial class Form_otherSet : Form
    {
        public Form_otherSet()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (checkBox_Autochange.Checked == true)
                AutoSetWall.updateAuto_ini("1");
            else AutoSetWall.updateAuto_ini("0");
            this.Close();
        }

        private void button_Createini_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_otherSet_Load(object sender, EventArgs e)
        {
            if (AutoSetWall.read_ini("AUTO") == "1")
                checkBox_Autochange.Checked = true;
        }
    }
}
