using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 客房预订系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string kf()
        {
            String k = "客房开启。";
            return k;
        }
        public string money()
        {
            String k = "房款不足。";
            return k;
        }
        public void pan(string k)
        {
            string str = "";
            str += k;
            if (rbdj.Checked == true)
            {
                str += kf();
                str += money();
            }
            if (rbqk.Checked == true)
            {
                str += kf();
                
            }
            MessageBox.Show(str);
        }
        private void btndr_Click(object sender, EventArgs e)
        {
            pan("单人间");
        }

        private void btnsr_Click(object sender, EventArgs e)
        {
            pan("双人间");
        }

        private void btnhh_Click(object sender, EventArgs e)
        {
            pan("豪华间");
        }
    }
}
