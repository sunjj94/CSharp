namespace TicketSales
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
            this.CBTICKET = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBBUYNUM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBPAY = new System.Windows.Forms.TextBox();
            this.TBRECIVE = new System.Windows.Forms.TextBox();
            this.TBBALANCE = new System.Windows.Forms.TextBox();
            this.TBPRICE = new System.Windows.Forms.TextBox();
            this.BBUY = new System.Windows.Forms.Button();
            this.BEXIT = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "购票类型";
            // 
            // CBTICKET
            // 
            this.CBTICKET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTICKET.FormattingEnabled = true;
            this.CBTICKET.Items.AddRange(new object[] {
            "成人票",
            "儿童票",
            "折扣票"});
            this.CBTICKET.Location = new System.Drawing.Point(83, 19);
            this.CBTICKET.Name = "CBTICKET";
            this.CBTICKET.Size = new System.Drawing.Size(73, 20);
            this.CBTICKET.TabIndex = 1;
            this.CBTICKET.SelectedValueChanged += new System.EventHandler(this.CBTICKET_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(26, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "折扣方式";
            // 
            // TBBUYNUM
            // 
            this.TBBUYNUM.Location = new System.Drawing.Point(270, 19);
            this.TBBUYNUM.Name = "TBBUYNUM";
            this.TBBUYNUM.Size = new System.Drawing.Size(100, 21);
            this.TBBUYNUM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "购票数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "实付款";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "应付款";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "找零";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "购票票价";
            // 
            // TBPAY
            // 
            this.TBPAY.Location = new System.Drawing.Point(270, 52);
            this.TBPAY.Name = "TBPAY";
            this.TBPAY.Size = new System.Drawing.Size(100, 21);
            this.TBPAY.TabIndex = 9;
            // 
            // TBRECIVE
            // 
            this.TBRECIVE.Location = new System.Drawing.Point(270, 85);
            this.TBRECIVE.Name = "TBRECIVE";
            this.TBRECIVE.ReadOnly = true;
            this.TBRECIVE.Size = new System.Drawing.Size(100, 21);
            this.TBRECIVE.TabIndex = 10;
            // 
            // TBBALANCE
            // 
            this.TBBALANCE.Location = new System.Drawing.Point(270, 118);
            this.TBBALANCE.Name = "TBBALANCE";
            this.TBBALANCE.ReadOnly = true;
            this.TBBALANCE.Size = new System.Drawing.Size(100, 21);
            this.TBBALANCE.TabIndex = 11;
            // 
            // TBPRICE
            // 
            this.TBPRICE.Location = new System.Drawing.Point(270, 151);
            this.TBPRICE.Name = "TBPRICE";
            this.TBPRICE.ReadOnly = true;
            this.TBPRICE.Size = new System.Drawing.Size(100, 21);
            this.TBPRICE.TabIndex = 12;
            // 
            // BBUY
            // 
            this.BBUY.Location = new System.Drawing.Point(193, 198);
            this.BBUY.Name = "BBUY";
            this.BBUY.Size = new System.Drawing.Size(75, 23);
            this.BBUY.TabIndex = 13;
            this.BBUY.Text = "购买";
            this.BBUY.UseVisualStyleBackColor = true;
            this.BBUY.Click += new System.EventHandler(this.BBUY_Click);
            // 
            // BEXIT
            // 
            this.BEXIT.Location = new System.Drawing.Point(295, 198);
            this.BEXIT.Name = "BEXIT";
            this.BEXIT.Size = new System.Drawing.Size(75, 23);
            this.BEXIT.TabIndex = 14;
            this.BEXIT.Text = "退出";
            this.BEXIT.UseVisualStyleBackColor = true;
            this.BEXIT.Click += new System.EventHandler(this.BEXIT_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "九折";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 76);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "八折";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 119);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "六五折";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.BEXIT);
            this.Controls.Add(this.BBUY);
            this.Controls.Add(this.TBPRICE);
            this.Controls.Add(this.TBBALANCE);
            this.Controls.Add(this.TBRECIVE);
            this.Controls.Add(this.TBPAY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBBUYNUM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CBTICKET);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "门票销售";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBTICKET;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox TBBUYNUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBPAY;
        private System.Windows.Forms.TextBox TBRECIVE;
        private System.Windows.Forms.TextBox TBBALANCE;
        private System.Windows.Forms.TextBox TBPRICE;
        private System.Windows.Forms.Button BBUY;
        private System.Windows.Forms.Button BEXIT;
    }
}

