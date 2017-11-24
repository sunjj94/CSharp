namespace PerformanceRankSys
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBGRADE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BYES = new System.Windows.Forms.Button();
            this.BEXIT = new System.Windows.Forms.Button();
            this.LBSORT = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生成绩";
            // 
            // TBGRADE
            // 
            this.TBGRADE.Location = new System.Drawing.Point(94, 33);
            this.TBGRADE.Name = "TBGRADE";
            this.TBGRADE.Size = new System.Drawing.Size(100, 21);
            this.TBGRADE.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "排序结果";
            // 
            // BYES
            // 
            this.BYES.Location = new System.Drawing.Point(51, 218);
            this.BYES.Name = "BYES";
            this.BYES.Size = new System.Drawing.Size(75, 23);
            this.BYES.TabIndex = 4;
            this.BYES.Text = "确定(&E)";
            this.BYES.UseVisualStyleBackColor = true;
            this.BYES.Click += new System.EventHandler(this.BYES_Click);
            // 
            // BEXIT
            // 
            this.BEXIT.Location = new System.Drawing.Point(155, 218);
            this.BEXIT.Name = "BEXIT";
            this.BEXIT.Size = new System.Drawing.Size(75, 23);
            this.BEXIT.TabIndex = 5;
            this.BEXIT.Text = "退出";
            this.BEXIT.UseVisualStyleBackColor = true;
            this.BEXIT.Click += new System.EventHandler(this.BEXIT_Click);
            // 
            // LBSORT
            // 
            this.LBSORT.FormattingEnabled = true;
            this.LBSORT.ItemHeight = 12;
            this.LBSORT.Location = new System.Drawing.Point(94, 76);
            this.LBSORT.Name = "LBSORT";
            this.LBSORT.Size = new System.Drawing.Size(100, 124);
            this.LBSORT.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 261);
            this.Controls.Add(this.LBSORT);
            this.Controls.Add(this.BEXIT);
            this.Controls.Add(this.BYES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBGRADE);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "成绩排序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBGRADE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BYES;
        private System.Windows.Forms.Button BEXIT;
        private System.Windows.Forms.ListBox LBSORT;
    }
}

