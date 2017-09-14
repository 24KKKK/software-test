using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 航空服务查询
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string fwfood()
        {
            string str = "";
            str = "食物供应";
            return str;
        }
        public string fwvideo()
        {
            string str = "";
            str = "   播放电影";
            return str;
        }
        public string cxfw()
        {

            string str="";
            if(rb_h_om.Checked==true)
            {
                str += fwfood();
                str += fwvideo();
                return str;
            }
            if (rb_h_fom.Checked == true)
            {
                str += fwfood();
                if (rb_c_sw.Checked == true)
                {
                    str += fwvideo();
                }
            }
            if (rb_h_gn.Checked == true)
            {
                if (rb_c_sw.Checked == true)
                {
                    str += fwfood();
                }
                if (rb_c_jj.Checked == true)
                {
                    if (rb_time_wai.Checked == true)
                    {
                        str += fwfood();
                    }
                    if (rb_time_nei.Checked == true)
                    {
                        str += "无服务";
                    }
                }
            }
            return str;
        }
        private void btcx_Click(object sender, EventArgs e)
        {
            string str = "";
            str = cxfw();
            tbfw.Text = str;
        }

        private void bttc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
