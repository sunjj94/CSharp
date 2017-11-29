using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private Floor floor;
        private int grade;
        private int series;

        public Form1()
        {
            InitializeComponent();
            floor = new Floor(new Point(80, 50));
        }

        //退出
        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //开始重新开始
        private void ToolStripMenuItemStart_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            if (this.ToolStripMenuItemStart.Text == "开始")
            {
                this.ToolStripMenuItemStart.Text = "重新开始";
            }
            else
            {
                floor.ReSet(this.CreateGraphics());
                floor.score = 0;
            }
            ToolStripMenuItemPause.Enabled = true;
        }

        //暂停继续
        private void ToolStripMenuItemPause_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuItemPause.Text == "暂停")
            {
                ToolStripMenuItemPause.Text = "继续";
                this.timer1.Enabled = false;
            }
            else
            {
                ToolStripMenuItemPause.Text = "暂停";
                this.timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            floor.Dispaly(this.CreateGraphics());
            this.labelScore.Text = floor.score.ToString();
            grade = floor.score / 50 + 1;
            if (grade != series && PubClass.kk == 0)
            {
                this.timer1.Interval = 560 - grade * 50;
                series = grade;
                labelGrade.Text = grade.ToString();
            }
            if (floor.score > 550)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("恭喜你通关了");
            }
            if (floor.CheckSnake())
            {
                timer1.Enabled = false;
            }
        }

        //第一关到第五关
        private void ToolStripMenuItemOne_Click(object sender, EventArgs e)
        {
            floor.score = 0;
            timer1.Interval = 500;
            labelScore.Text = floor.score.ToString();
            labelGrade.Text = "1";
        }

        private void ToolStripMenuItemTwo_Click(object sender, EventArgs e)
        {
            floor.score = 100;
            timer1.Interval = 400;
            labelScore.Text = floor.score.ToString();
            labelGrade.Text = "3";
        }

        private void ToolStripMenuItemThree_Click(object sender, EventArgs e)
        {
            floor.score = 200;
            timer1.Interval = 300;
            labelScore.Text = floor.score.ToString();
            labelGrade.Text = "5";
        }

        private void ToolStripMenuItemFour_Click(object sender, EventArgs e)
        {
            floor.score = 300;
            timer1.Interval = 200;
            labelScore.Text = floor.score.ToString();
            labelGrade.Text = "7";
        }

        private void ToolStripMenuItemFive_Click(object sender, EventArgs e)
        {
            floor.score = 400;
            timer1.Interval = 100;
            labelScore.Text = floor.score.ToString();
            labelGrade.Text = "9";
        }

        //自定义速度
        private void ToolStripMenuItemCustom_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            Speed fw = new Speed();
            fw.ShowDialog();
            this.timer1.Interval = PubClass.kk;
            this.timer1.Enabled = true;
        }

        //帮助
        private void ToolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            MessageBox.Show("F1 开始/重新开始" + "\n" + "F2 暂停/继续" + "\n" + "上下左右键为控制蛇的方向键");
            this.timer1.Enabled = true;
        }

        //Form控件按键消息响应
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int k, d = 0;
            k = e.KeyValue;
            if (k == 37)                                                          //左
                d = 3;
            else if (k == 40)                                                     //下
                d = 2;
            else if (k == 38)                                                     //上
                d = 0;
            else if (k == 39)                                                     //右
                d = 1;
            floor.S.TurnDirection(d);
        }
    }
}
