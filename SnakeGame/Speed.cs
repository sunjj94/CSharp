﻿using System;
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
    public partial class Speed : Form
    {
        public Speed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            temp = int.Parse(textBox1.Text);
            if (temp >= 1 && temp <= 500)
            {
                PubClass.kk = 501 - temp;
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入1~500之间的数字");
            }
        }
    }
}
