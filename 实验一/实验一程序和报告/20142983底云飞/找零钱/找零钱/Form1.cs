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

namespace 找零钱
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected bool IsInteger(string value)
        {
            string pattern = @"^[0-9]*[1-9][0-9]*$";
            return Regex.IsMatch(value, pattern);
        }
        private void submit_Click(object sender, EventArgs e)
        {
            string m;
            int num;
            m = money.Text.Trim();
            if (m == "")
            {
                pout.Text = "零钱不能为空";
                return;
            }
            if (!IsInteger(m))
            {
                pout.Text = "零钱应为自然数";
                return;
            }
            num = Convert.ToInt32(m);
            if (num < 0 || num > 100)
            {
                pout.Text = "零钱应在0到100之间";
                return;
            }
            string str = "";
            if (num / 100 == 1)
            {
                str = "1张100元";
                return;
            }
            if (num / 50 == 1)
            {
                str += "1张50元  ";
                 num = num % 50;
                int r = num / 10;
                if ( r> 0)
                {
                    str += r+"张10元   ";
                    num = num % 10;
                    r = num / 5;
                    if (r > 0)
                    {
                        str += r+ "张5元  ";
                        num = num % 5;
                        r = num /1;
                        if (r > 0)
                        {
                            str += r + "张1元";
                        }
                    }
                    else
                    {
                        r = num / 1;
                        if (r > 0)
                        {
                            str += r + "张1元";

                        }
                    }
                }
                else
                {
                    r = num / 5;
                    if (r > 0)
                    {
                        str += r + "张5元";
                        num = num % 5;
                        r = num / 1;
                        if (r > 0)
                        {
                            str += r + "张1元";

                        }
                    }
                    else
                    {
                        r = num / 1;
                        if (r > 0)
                        {
                            str += r + "张1元";

                        }
                    }
                }
            }
            else
            {
                int r = num / 10;
                if (r > 0)
                {
                    str += r + "张10元   ";
                    num = num % 10;
                    r = num / 5;
                    if (r > 0)
                    {
                        str += r + "张5元";
                        num = num % 5;
                        r = num / 1;
                        if (r > 0)
                        {
                            str += r + "张1元";

                        }
                    }
                    else
                    {
                        r = num / 1;
                        if (r > 0)
                        {
                            str += r + "张1元";

                        }
                    }
                }
                else
                {
                    r = num / 5;
                    if (r > 0)
                    {
                        str += r + "张5元";
                        num = num % 5;
                        r = num / 1;
                        if (r > 0)
                        {
                            str += r + "张1元";

                        }
                    }
                    else
                    {
                        r = num / 1;
                        if (r > 0)
                        {
                            str += r + "张1元";

                        }
                    }
                }
            }
            pout.Text = str;
        }
    }
}
