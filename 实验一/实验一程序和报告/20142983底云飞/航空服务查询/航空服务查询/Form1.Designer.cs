namespace 航空服务查询
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbfw = new System.Windows.Forms.TextBox();
            this.btcx = new System.Windows.Forms.Button();
            this.bttc = new System.Windows.Forms.Button();
            this.rb_h_om = new System.Windows.Forms.RadioButton();
            this.rb_h_fom = new System.Windows.Forms.RadioButton();
            this.rb_h_gn = new System.Windows.Forms.RadioButton();
            this.rb_c_sw = new System.Windows.Forms.RadioButton();
            this.rb_c_jj = new System.Windows.Forms.RadioButton();
            this.rb_time_nei = new System.Windows.Forms.RadioButton();
            this.rb_time_wai = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_h_gn);
            this.groupBox1.Controls.Add(this.rb_h_fom);
            this.groupBox1.Controls.Add(this.rb_h_om);
            this.groupBox1.Location = new System.Drawing.Point(169, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "航线";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_c_jj);
            this.groupBox2.Controls.Add(this.rb_c_sw);
            this.groupBox2.Location = new System.Drawing.Point(169, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "舱位";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_time_nei);
            this.groupBox3.Controls.Add(this.rb_time_wai);
            this.groupBox3.Location = new System.Drawing.Point(169, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "飞行时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "航空服务";
            // 
            // tbfw
            // 
            this.tbfw.Enabled = false;
            this.tbfw.Location = new System.Drawing.Point(240, 251);
            this.tbfw.Name = "tbfw";
            this.tbfw.Size = new System.Drawing.Size(349, 21);
            this.tbfw.TabIndex = 3;
            // 
            // btcx
            // 
            this.btcx.Location = new System.Drawing.Point(185, 308);
            this.btcx.Name = "btcx";
            this.btcx.Size = new System.Drawing.Size(75, 23);
            this.btcx.TabIndex = 4;
            this.btcx.Text = "查询";
            this.btcx.UseVisualStyleBackColor = true;
            this.btcx.Click += new System.EventHandler(this.btcx_Click);
            // 
            // bttc
            // 
            this.bttc.Location = new System.Drawing.Point(459, 308);
            this.bttc.Name = "bttc";
            this.bttc.Size = new System.Drawing.Size(75, 23);
            this.bttc.TabIndex = 5;
            this.bttc.Text = "退出";
            this.bttc.UseVisualStyleBackColor = true;
            this.bttc.Click += new System.EventHandler(this.bttc_Click);
            // 
            // rb_h_om
            // 
            this.rb_h_om.AutoSize = true;
            this.rb_h_om.Location = new System.Drawing.Point(16, 20);
            this.rb_h_om.Name = "rb_h_om";
            this.rb_h_om.Size = new System.Drawing.Size(47, 16);
            this.rb_h_om.TabIndex = 0;
            this.rb_h_om.TabStop = true;
            this.rb_h_om.Text = "欧美";
            this.rb_h_om.UseVisualStyleBackColor = true;
            // 
            // rb_h_fom
            // 
            this.rb_h_fom.AutoSize = true;
            this.rb_h_fom.Location = new System.Drawing.Point(163, 20);
            this.rb_h_fom.Name = "rb_h_fom";
            this.rb_h_fom.Size = new System.Drawing.Size(83, 16);
            this.rb_h_fom.TabIndex = 1;
            this.rb_h_fom.TabStop = true;
            this.rb_h_fom.Text = "国外非欧美";
            this.rb_h_fom.UseVisualStyleBackColor = true;
            // 
            // rb_h_gn
            // 
            this.rb_h_gn.AutoSize = true;
            this.rb_h_gn.Location = new System.Drawing.Point(308, 20);
            this.rb_h_gn.Name = "rb_h_gn";
            this.rb_h_gn.Size = new System.Drawing.Size(47, 16);
            this.rb_h_gn.TabIndex = 2;
            this.rb_h_gn.TabStop = true;
            this.rb_h_gn.Text = "国内";
            this.rb_h_gn.UseVisualStyleBackColor = true;
            // 
            // rb_c_sw
            // 
            this.rb_c_sw.AutoSize = true;
            this.rb_c_sw.Location = new System.Drawing.Point(16, 20);
            this.rb_c_sw.Name = "rb_c_sw";
            this.rb_c_sw.Size = new System.Drawing.Size(59, 16);
            this.rb_c_sw.TabIndex = 3;
            this.rb_c_sw.TabStop = true;
            this.rb_c_sw.Text = "商务舱";
            this.rb_c_sw.UseVisualStyleBackColor = true;
            // 
            // rb_c_jj
            // 
            this.rb_c_jj.AutoSize = true;
            this.rb_c_jj.Location = new System.Drawing.Point(308, 20);
            this.rb_c_jj.Name = "rb_c_jj";
            this.rb_c_jj.Size = new System.Drawing.Size(59, 16);
            this.rb_c_jj.TabIndex = 4;
            this.rb_c_jj.TabStop = true;
            this.rb_c_jj.Text = "经济舱";
            this.rb_c_jj.UseVisualStyleBackColor = true;
            // 
            // rb_time_nei
            // 
            this.rb_time_nei.AutoSize = true;
            this.rb_time_nei.Location = new System.Drawing.Point(16, 20);
            this.rb_time_nei.Name = "rb_time_nei";
            this.rb_time_nei.Size = new System.Drawing.Size(83, 16);
            this.rb_time_nei.TabIndex = 5;
            this.rb_time_nei.TabStop = true;
            this.rb_time_nei.Text = "两小时以内";
            this.rb_time_nei.UseVisualStyleBackColor = true;
            // 
            // rb_time_wai
            // 
            this.rb_time_wai.AutoSize = true;
            this.rb_time_wai.Location = new System.Drawing.Point(308, 20);
            this.rb_time_wai.Name = "rb_time_wai";
            this.rb_time_wai.Size = new System.Drawing.Size(83, 16);
            this.rb_time_wai.TabIndex = 6;
            this.rb_time_wai.TabStop = true;
            this.rb_time_wai.Text = "超过两小时";
            this.rb_time_wai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 377);
            this.Controls.Add(this.bttc);
            this.Controls.Add(this.btcx);
            this.Controls.Add(this.tbfw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "航空服务查询问题";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbfw;
        private System.Windows.Forms.RadioButton rb_h_gn;
        private System.Windows.Forms.RadioButton rb_h_fom;
        private System.Windows.Forms.RadioButton rb_h_om;
        private System.Windows.Forms.RadioButton rb_c_jj;
        private System.Windows.Forms.RadioButton rb_c_sw;
        private System.Windows.Forms.RadioButton rb_time_nei;
        private System.Windows.Forms.RadioButton rb_time_wai;
        private System.Windows.Forms.Button btcx;
        private System.Windows.Forms.Button bttc;
    }
}

