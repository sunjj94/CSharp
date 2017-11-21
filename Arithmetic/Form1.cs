using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitMember();
        }

        protected long iNum;
        protected char cOpration;
        protected bool bFisrtNum;
       
        private void InitMember()
        {
            iNum = 0;
            cOpration = '=';
            bFisrtNum = true;
        }

        private void NumberClick(long i)
        {
            if (textBox1.Text == "Error")
            {
                textBox1.Text = "0";
            }

            try
            {
                long iCurrent = long.Parse(textBox1.Text);

                if (bFisrtNum)
                {
                    iCurrent = i;
                    bFisrtNum = false;
                }
                else
                {
                    checked { iCurrent = (iCurrent * 10) + i; }
                }

                textBox1.Text = iCurrent.ToString();
            }
            catch
            {

            }
        }

        private void OperationClick(char op)
        {
            long iCurrent;
            try
            {
                iCurrent = long.Parse(textBox1.Text);
            }
            catch
            {
                textBox1.Text = "Error";
                InitMember();
                return;
            }

            long iResult;
            try
            {
                switch (cOpration)
                {
                    case '+':
                        checked { iResult = iNum + iCurrent; }
                        break;
                    case '-':
                        checked { iResult = iNum - iCurrent; }
                        break;
                    case '*':
                        checked { iResult = iNum * iCurrent; }
                        break;
                    case '/':
                        checked { iResult = iNum / iCurrent; }
                        break;
                    default:
                        iResult = iCurrent;
                        break;
                }
            }
            catch
            {
                textBox1.Text = "Error";
                InitMember();
                return;
            }

            textBox1.Text = iResult.ToString();
            iNum = iResult;
            bFisrtNum = true;
            cOpration = op;
        }


        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberClick(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberClick(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NumberClick(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumberClick(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NumberClick(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NumberClick(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NumberClick(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NumberClick(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NumberClick(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            NumberClick(0);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OperationClick('+');
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            OperationClick('-');
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            OperationClick('*');
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            OperationClick('/');
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            OperationClick('=');
        }

        //添加文本框的KeyDown事件响应函数
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.NumPad1:
                    NumberClick(1);
                    break;
                case Keys.NumPad2:
                    NumberClick(2);
                    break;
                case Keys.NumPad3:
                    NumberClick(3);
                    break;
                case Keys.NumPad4:
                    NumberClick(4);
                    break;
                case Keys.NumPad5:
                    NumberClick(5);
                    break;
                case Keys.NumPad6:
                    NumberClick(6);
                    break;
                case Keys.NumPad7:
                    NumberClick(7);
                    break;
                case Keys.NumPad8:
                    NumberClick(8);
                    break;
                case Keys.NumPad9:
                    NumberClick(9);
                    break;
                case Keys.NumPad0:
                    NumberClick(0);
                    break;
                case Keys.Add:
                    OperationClick('+');
                    break;
                case Keys.Subtract:
                    OperationClick('-');
                    break;
                case Keys.Multiply:
                    OperationClick('*');
                    break;
                case Keys.Divide:
                    OperationClick('/');
                    break;
                case Keys.Oemplus:
                case Keys.Enter:
                    OperationClick('=');
                    break;
            }
        }
    }
}
