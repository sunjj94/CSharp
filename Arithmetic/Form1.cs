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
            buttonMR.Enabled = false;
            buttonMM.Enabled = false;
        }

        protected double iNum;
        protected char cOpration;
        protected bool bFisrtNum;
        protected bool bPoint;
        protected short bPointNum;
        protected double Memry;

        private void InitMember()
        {
            iNum = 0;
            cOpration = '=';
            bFisrtNum = true;
            bPoint = false;
            bPointNum = 0;
        }

        private void NumberClick(Double i)
        {
            if (textBox1.Text == "Error")
            {
                textBox1.Text = "0";
            }

            try
            {
                double iCurrent = double.Parse(textBox1.Text);

                if (bFisrtNum && (bPoint == false))
                {
                    iCurrent = i;
                    bFisrtNum = false;
                }
                else if ((bFisrtNum == false) && (bPoint == false))
                {
                    checked { iCurrent = (iCurrent * 10) + i; }
                }
                else if (bFisrtNum && (bPoint == true))
                {
                    iCurrent = i;
                    checked { iCurrent = (iCurrent / 10.0); }
                    bFisrtNum = false;
                    bPointNum++;
                }
                else
                {
                    for (short k = 0; k <= bPointNum; k++)
                        checked { i = (i / 10.0); }
                    checked { iCurrent = i + iCurrent; }
                    bPointNum++;
                }
                textBox1.Text = iCurrent.ToString();
            }
            catch
            {
                return;
            }
        }

        private void OperatorsClick(char op)
        {
            double iCurrent;
            try
            {
                iCurrent = double.Parse(textBox1.Text);
            }
            catch
            {
                textBox1.Text = "Error";
                InitMember();
                return;
            }

            double iResult;
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
                    case 'C':
                        iResult = 0;
                        iCurrent = 0;
                        InitMember();
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
            bPoint = false;
            bPointNum = 0;
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
            OperatorsClick('+');
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            OperatorsClick('-');
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            OperatorsClick('*');
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            OperatorsClick('/');
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            OperatorsClick('=');
        }

        //添加清楚功能
        private void buttonClear_Click(object sender, EventArgs e)
        {
            cOpration = 'C';
            OperatorsClick('=');
            textBox1.Text = "0";
        }

        //添加小数点
        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (bPoint)
            {
                textBox1.Text = "Error";
            }
            bPoint = true;
            
            if (bFisrtNum)
            {
                textBox1.Text = "0.";
            }
            else
            {
                string sCurrent = textBox1.Text;
                sCurrent = sCurrent + '.';
                textBox1.Text = sCurrent;
            }
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
                    OperatorsClick('+');
                    break;
                case Keys.Subtract:
                    OperatorsClick('-');
                    break;
                case Keys.Multiply:
                    OperatorsClick('*');
                    break;
                case Keys.Divide:
                    OperatorsClick('/');
                    break;
                case Keys.Oemplus:
                case Keys.Enter:
                    OperatorsClick('=');
                    break;
            }
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            lableM.Visible = false;
            Memry = 0;
            buttonMR.Enabled = false;
            buttonMM.Enabled = false;
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBox1.Text = Memry.ToString();
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            lableM.Visible = true;
            double iResult = double.Parse(textBox1.Text);
            Memry = iResult;
            buttonMM.Enabled = true;
            buttonMR.Enabled = true;
        }

        private void buttonMM_Click(object sender, EventArgs e)
        {
            double iReuslt = double.Parse(textBox1.Text);
            if (lableM.Visible)
            {
                Memry += iReuslt;
                textBox1.Text = Memry.ToString();
            }
        }
    }
}
