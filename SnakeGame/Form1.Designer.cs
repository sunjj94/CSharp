namespace SnakeGame
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPause = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGrade = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOne = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTwo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemThree = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFour = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFive = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMenu,
            this.ToolStripMenuItemGrade,
            this.ToolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemMenu
            // 
            this.ToolStripMenuItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOperation,
            this.ToolStripMenuItemStart,
            this.ToolStripMenuItemPause,
            this.ToolStripMenuItemExit});
            this.ToolStripMenuItemMenu.Name = "ToolStripMenuItemMenu";
            this.ToolStripMenuItemMenu.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItemMenu.Text = "菜单";
            // 
            // ToolStripMenuItemOperation
            // 
            this.ToolStripMenuItemOperation.Name = "ToolStripMenuItemOperation";
            this.ToolStripMenuItemOperation.Size = new System.Drawing.Size(153, 22);
            this.ToolStripMenuItemOperation.Text = "操作";
            // 
            // ToolStripMenuItemStart
            // 
            this.ToolStripMenuItemStart.Name = "ToolStripMenuItemStart";
            this.ToolStripMenuItemStart.Size = new System.Drawing.Size(153, 22);
            this.ToolStripMenuItemStart.Text = "开始/重新开始";
            // 
            // ToolStripMenuItemPause
            // 
            this.ToolStripMenuItemPause.Name = "ToolStripMenuItemPause";
            this.ToolStripMenuItemPause.Size = new System.Drawing.Size(153, 22);
            this.ToolStripMenuItemPause.Text = "暂停/继续";
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(153, 22);
            this.ToolStripMenuItemExit.Text = "退出";
            // 
            // ToolStripMenuItemGrade
            // 
            this.ToolStripMenuItemGrade.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOne,
            this.ToolStripMenuItemTwo,
            this.ToolStripMenuItemThree,
            this.ToolStripMenuItemFour,
            this.ToolStripMenuItemFive,
            this.ToolStripMenuItemCustom});
            this.ToolStripMenuItemGrade.Name = "ToolStripMenuItemGrade";
            this.ToolStripMenuItemGrade.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItemGrade.Text = "级别";
            // 
            // ToolStripMenuItemOne
            // 
            this.ToolStripMenuItemOne.Name = "ToolStripMenuItemOne";
            this.ToolStripMenuItemOne.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemOne.Text = "第一关";
            // 
            // ToolStripMenuItemTwo
            // 
            this.ToolStripMenuItemTwo.Name = "ToolStripMenuItemTwo";
            this.ToolStripMenuItemTwo.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemTwo.Text = "第二关";
            // 
            // ToolStripMenuItemThree
            // 
            this.ToolStripMenuItemThree.Name = "ToolStripMenuItemThree";
            this.ToolStripMenuItemThree.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemThree.Text = "第三关";
            // 
            // ToolStripMenuItemFour
            // 
            this.ToolStripMenuItemFour.Name = "ToolStripMenuItemFour";
            this.ToolStripMenuItemFour.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemFour.Text = "第四关";
            // 
            // ToolStripMenuItemFive
            // 
            this.ToolStripMenuItemFive.Name = "ToolStripMenuItemFive";
            this.ToolStripMenuItemFive.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemFive.Text = "第五关";
            // 
            // ToolStripMenuItemCustom
            // 
            this.ToolStripMenuItemCustom.Name = "ToolStripMenuItemCustom";
            this.ToolStripMenuItemCustom.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemCustom.Text = "自定义速度";
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(44, 21);
            this.ToolStripMenuItemHelp.Text = "帮助";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "分数";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(373, 25);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(41, 12);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "等级";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(468, 25);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(41, 12);
            this.labelGrade.TabIndex = 4;
            this.labelGrade.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 345);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "贪吃蛇";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOperation;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStart;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPause;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGrade;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOne;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTwo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemThree;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFour;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFive;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCustom;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelGrade;
    }
}

