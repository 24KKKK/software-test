using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 判断星期
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected bool IsInteger(string value)
        {
            string pattern = @"^[0-9]\d*$";
            return Regex.IsMatch(value, pattern);
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String y, m, d,ymd,xq;
            int nian, yue, ri;
            y= year.Text.Trim();
            m = month.Text.Trim();
            d = day.Text.Trim();
            //xingqi.ForeColor = System.Drawing.Color.Red;
            if (y == "")
            {
                xingqi.Text = "年不能为空";
                return;
            }
            if (m == "")
            {
                xingqi.Text = "月不能为空";
                return;
            }
            if (d == "")
            {
                xingqi.Text = "日不能为空";
                return;
            }
            if (!IsInteger(y))
            {
                xingqi.Text = "年应为自然数";
                return;
            }
            if (!IsInteger(m))
            {
                xingqi.Text = "月应为自然数";
                return;
            }
            if (!IsInteger(d))
            {
                xingqi.Text = "日应为自然数";
                return;
            }
            nian = Convert.ToInt32(y);
            yue = Convert.ToInt32(m);
            ri = Convert.ToInt32(d);
            if (nian > 9999)
            {
                xingqi.Text = "年应小于等于9999";
                return;
            }
            //月份
            if (yue > 12)
            {
                xingqi.Text = "月份应小于等于12";
                return;
            }
            //日期
            if (ri > 31)
            {
                xingqi.Text = "日期应小于等于31";
                return;
            }
            //是否为闰年
            if (nian % 4 == 0)
            {
                 if (yue == 2)
                {
                    if (ri > 29)
                    {
                        xingqi.Text = "闰年2月只有29天";
                        return;
                    }
                }
                else if (yue == 1 || yue == 3 || yue == 5 || yue == 7 || yue == 8 || yue == 10 || yue == 12)
                {
                    if (ri > 31)
                    {
                        xingqi.Text = "超过31天";
                        return;
                    }
                }
                else
                {
                    if (ri > 30)
                    {
                        xingqi.Text = "超过30天";
                        return;
                    }
                }
            }
            else
            {
                if (yue == 2)
                {
                    if (ri > 28)
                    {
                        xingqi.Text = "平年2月只有28天";
                        return;
                    }
                }
                
            }
            ymd = y + "-" + m + "-" + d;
            //MessageBox.Show(ymd);
            DateTime date = Convert.ToDateTime(ymd);
            xq = date.DayOfWeek.ToString();
            //xingqi.ForeColor =System.Drawing.Color.Green ;
            xingqi.Text=xq;
        }
    }
}
