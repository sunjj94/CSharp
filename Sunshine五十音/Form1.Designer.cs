namespace Sunshine五十音
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
            this.checkBoxSurd = new System.Windows.Forms.CheckBox();
            this.checkBoxDullness = new System.Windows.Forms.CheckBox();
            this.checkBoxOverSound = new System.Windows.Forms.CheckBox();
            this.checkBoxHira = new System.Windows.Forms.CheckBox();
            this.checkBoxkana = new System.Windows.Forms.CheckBox();
            this.checkBoxReview = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxSurd
            // 
            this.checkBoxSurd.AutoSize = true;
            this.checkBoxSurd.Checked = true;
            this.checkBoxSurd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSurd.Location = new System.Drawing.Point(6, 20);
            this.checkBoxSurd.Name = "checkBoxSurd";
            this.checkBoxSurd.Size = new System.Drawing.Size(48, 16);
            this.checkBoxSurd.TabIndex = 0;
            this.checkBoxSurd.Text = "清音";
            this.checkBoxSurd.UseVisualStyleBackColor = true;
            // 
            // checkBoxDullness
            // 
            this.checkBoxDullness.AutoSize = true;
            this.checkBoxDullness.Checked = true;
            this.checkBoxDullness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDullness.Location = new System.Drawing.Point(62, 20);
            this.checkBoxDullness.Name = "checkBoxDullness";
            this.checkBoxDullness.Size = new System.Drawing.Size(48, 16);
            this.checkBoxDullness.TabIndex = 1;
            this.checkBoxDullness.Text = "浊音";
            this.checkBoxDullness.UseVisualStyleBackColor = true;
            // 
            // checkBoxOverSound
            // 
            this.checkBoxOverSound.AutoSize = true;
            this.checkBoxOverSound.Checked = true;
            this.checkBoxOverSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOverSound.Location = new System.Drawing.Point(118, 20);
            this.checkBoxOverSound.Name = "checkBoxOverSound";
            this.checkBoxOverSound.Size = new System.Drawing.Size(48, 16);
            this.checkBoxOverSound.TabIndex = 2;
            this.checkBoxOverSound.Text = "拗音";
            this.checkBoxOverSound.UseVisualStyleBackColor = true;
            // 
            // checkBoxHira
            // 
            this.checkBoxHira.AutoSize = true;
            this.checkBoxHira.Checked = true;
            this.checkBoxHira.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHira.Location = new System.Drawing.Point(174, 20);
            this.checkBoxHira.Name = "checkBoxHira";
            this.checkBoxHira.Size = new System.Drawing.Size(60, 16);
            this.checkBoxHira.TabIndex = 3;
            this.checkBoxHira.Text = "平假名";
            this.checkBoxHira.UseVisualStyleBackColor = true;
            // 
            // checkBoxkana
            // 
            this.checkBoxkana.AutoSize = true;
            this.checkBoxkana.Checked = true;
            this.checkBoxkana.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxkana.Location = new System.Drawing.Point(242, 20);
            this.checkBoxkana.Name = "checkBoxkana";
            this.checkBoxkana.Size = new System.Drawing.Size(60, 16);
            this.checkBoxkana.TabIndex = 4;
            this.checkBoxkana.Text = "片假名";
            this.checkBoxkana.UseVisualStyleBackColor = true;
            // 
            // checkBoxReview
            // 
            this.checkBoxReview.AutoSize = true;
            this.checkBoxReview.Location = new System.Drawing.Point(310, 20);
            this.checkBoxReview.Name = "checkBoxReview";
            this.checkBoxReview.Size = new System.Drawing.Size(72, 16);
            this.checkBoxReview.TabIndex = 5;
            this.checkBoxReview.Text = "复习巩固";
            this.checkBoxReview.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.ButtonOK);
            this.groupBox1.Controls.Add(this.checkBoxOverSound);
            this.groupBox1.Controls.Add(this.checkBoxReview);
            this.groupBox1.Controls.Add(this.checkBoxSurd);
            this.groupBox1.Controls.Add(this.checkBoxkana);
            this.groupBox1.Controls.Add(this.checkBoxDullness);
            this.groupBox1.Controls.Add(this.checkBoxHira);
            this.groupBox1.Location = new System.Drawing.Point(0, -7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(399, 14);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(48, 26);
            this.ButtonOK.TabIndex = 6;
            this.ButtonOK.Text = "刷新";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(469, 383);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(485, 422);
            this.MinimumSize = new System.Drawing.Size(485, 422);
            this.Name = "Form1";
            this.Text = "Sunshine五十音";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSurd;
        private System.Windows.Forms.CheckBox checkBoxDullness;
        private System.Windows.Forms.CheckBox checkBoxOverSound;
        private System.Windows.Forms.CheckBox checkBoxHira;
        private System.Windows.Forms.CheckBox checkBoxkana;
        private System.Windows.Forms.CheckBox checkBoxReview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonOK;
    }
}

