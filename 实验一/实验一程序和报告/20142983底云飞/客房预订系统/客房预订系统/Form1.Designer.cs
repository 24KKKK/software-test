namespace 客房预订系统
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
            this.rbqk = new System.Windows.Forms.RadioButton();
            this.rbdj = new System.Windows.Forms.RadioButton();
            this.btndr = new System.Windows.Forms.Button();
            this.btnsr = new System.Windows.Forms.Button();
            this.btnhh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbqk
            // 
            this.rbqk.AutoSize = true;
            this.rbqk.Location = new System.Drawing.Point(278, 144);
            this.rbqk.Name = "rbqk";
            this.rbqk.Size = new System.Drawing.Size(71, 16);
            this.rbqk.TabIndex = 0;
            this.rbqk.TabStop = true;
            this.rbqk.Text = "支付全款";
            this.rbqk.UseVisualStyleBackColor = true;
            // 
            // rbdj
            // 
            this.rbdj.AutoSize = true;
            this.rbdj.Location = new System.Drawing.Point(446, 144);
            this.rbdj.Name = "rbdj";
            this.rbdj.Size = new System.Drawing.Size(71, 16);
            this.rbdj.TabIndex = 1;
            this.rbdj.TabStop = true;
            this.rbdj.Text = "支付定金";
            this.rbdj.UseVisualStyleBackColor = true;
            // 
            // btndr
            // 
            this.btndr.Location = new System.Drawing.Point(165, 293);
            this.btndr.Name = "btndr";
            this.btndr.Size = new System.Drawing.Size(75, 23);
            this.btndr.TabIndex = 2;
            this.btndr.Text = "单人间";
            this.btndr.UseVisualStyleBackColor = true;
            this.btndr.Click += new System.EventHandler(this.btndr_Click);
            // 
            // btnsr
            // 
            this.btnsr.Location = new System.Drawing.Point(327, 293);
            this.btnsr.Name = "btnsr";
            this.btnsr.Size = new System.Drawing.Size(75, 23);
            this.btnsr.TabIndex = 3;
            this.btnsr.Text = "双人间";
            this.btnsr.UseVisualStyleBackColor = true;
            this.btnsr.Click += new System.EventHandler(this.btnsr_Click);
            // 
            // btnhh
            // 
            this.btnhh.Location = new System.Drawing.Point(513, 293);
            this.btnhh.Name = "btnhh";
            this.btnhh.Size = new System.Drawing.Size(75, 23);
            this.btnhh.TabIndex = 4;
            this.btnhh.Text = "豪华间";
            this.btnhh.UseVisualStyleBackColor = true;
            this.btnhh.Click += new System.EventHandler(this.btnhh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "房款支付";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "房间类型";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhh);
            this.Controls.Add(this.btnsr);
            this.Controls.Add(this.btndr);
            this.Controls.Add(this.rbdj);
            this.Controls.Add(this.rbqk);
            this.Name = "Form1";
            this.Text = "客房预订系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbqk;
        private System.Windows.Forms.RadioButton rbdj;
        private System.Windows.Forms.Button btndr;
        private System.Windows.Forms.Button btnsr;
        private System.Windows.Forms.Button btnhh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

