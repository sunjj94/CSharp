using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00CSCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dCorpus;
            int iYears;
            double dInterest;
            string str;
            double dIncome;
            double dInterestIncom;

            try
            {
                dCorpus = double.Parse(textBoxCorpus.Text);
                iYears = Int32.Parse(textBoxYears.Text);
                dInterest = double.Parse(textBoxInterest.Text) / 100;
            }
            catch
            {
                MessageBox.Show("输入非数字");
                return;
            }

            dIncome = dCorpus * Math.Pow((1 + dInterest), iYears);
            dInterestIncom = dIncome - dCorpus;

            str = string.Format("{0, 3:d} {1, 15:c} {2, 16:c} {3, 18:c}", iYears, dCorpus, dInterestIncom, dIncome);
            listBox1.Items.Add(str);
        }
    }
}
