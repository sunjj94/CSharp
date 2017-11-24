using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSales
{
    public partial class Form1 : Form
    {
        public double commonPrice = 45.00;
        public Form1()
        {
            InitializeComponent();
        }

        private void BEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            TBPRICE.Text = string.Format("{0:f2}", commonPrice * 90 / 100);
            TBRECIVE.Text = "";
            TBBALANCE.Text = "";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            TBPRICE.Text = string.Format("{0:f2}", commonPrice * 80 / 100);
            TBRECIVE.Text = "";
            TBBALANCE.Text = "";
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            TBPRICE.Text = string.Format("{0:f2}", commonPrice * 65 / 100);
            TBRECIVE.Text = "";
            TBBALANCE.Text = "";
        }

        private void CBTICKET_SelectedValueChanged(object sender, EventArgs e)
        {
            //开启购票数量和购票款输入功能
            TBBUYNUM.ReadOnly = false;
            TBPAY.ReadOnly = false;

            //清空应收款和找零的内容
            TBRECIVE.Text = "";
            TBBALANCE.Text = "";

            //设置折扣不可用
            groupBox1.Enabled = false;

            //判断当前选择的票的类型
            switch (CBTICKET.SelectedIndex)
            {
                case 0:
                    TBPRICE.Text = string.Format("{0:f2}", commonPrice);
                    break;
                case 1:
                    TBPRICE.Text = string.Format("{0:f2}", commonPrice * 50 / 100);
                    break;
                case 2:
                    groupBox1.Enabled = true;
                    radioButton1.Checked = true;
                    TBPRICE.Text = string.Format("{0:f2}", commonPrice * 90 / 100);
                    break;
            }
        }

        private void BBUY_Click(object sender, EventArgs e)
        {
            double pay;
            double recieve;
            double balance;
            double price;
            int ticketnum;

            try
            {
                ticketnum = Int32.Parse(TBBUYNUM.Text);
                pay = double.Parse(TBPAY.Text);
                price = double.Parse(TBPRICE.Text);

                recieve = ticketnum * price;
                TBRECIVE.Text = string.Format("{0:f2}", recieve);
                balance = pay - recieve;
                TBBALANCE.Text = string.Format("{0:f2}", balance);
            }
            catch
            {
                MessageBox.Show("输入有错！请检查购票类型、折扣、数量与应付款");
                return;
            }
        }
    }
}
