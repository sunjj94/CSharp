using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerformanceRankSys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Int16[] nSortGrade;

        private void BYES_Click(object sender, EventArgs e)
        {
            Int16 nGrade;            
            nSortGrade = new Int16[LBSORT.Items.Count];
            Int16 fistPosition = 0;
            Int16 lastPosition = 0;
            Int16 midPosition = 0;
            Int16 findPosition = 0;
            bool bFindFlag = false;
            string strGrade;

            //将listBox控件中的项放到nSortGrade数组中            
            for (int j = 0; j < LBSORT.Items.Count; j++)
                nSortGrade[j] = Int16.Parse(LBSORT.Items[j].ToString());

            //判断输入是否是正整数
            strGrade = TBGRADE.Text;
            if (strGrade.Length == 0)
            {
                MessageBox.Show("请输入成绩！");
                return;
            }
            for (int i = 0; i < strGrade.Length; i++)
            {
                if (!char.IsNumber(strGrade[i]))
                {
                    MessageBox.Show("待处理数据中有非数字存在！");
                    return;
                }
            }
            nGrade = Int16.Parse(TBGRADE.Text);
            TBGRADE.Text = "";
            if (LBSORT.Items.Count == 0)
            {
                findPosition = 0;
            }
            else
            {
                fistPosition = 0;
                lastPosition = (Int16)(nSortGrade.Length - 1);
                bFindFlag = false;
                while (!bFindFlag && fistPosition <= lastPosition)
                {
                    midPosition = (Int16)((fistPosition + lastPosition) / 2);
                    if (nSortGrade[midPosition].Equals(nGrade))
                    {
                        findPosition = midPosition;
                        bFindFlag = true;
                    }
                    else
                    {
                        if (nGrade.CompareTo(nSortGrade[midPosition]) < 0)
                        {
                            lastPosition = (Int16)(midPosition - 1);
                        }
                        else
                        {
                            fistPosition = (Int16)(midPosition + 1);
                        }
                    }
                }
                if (!bFindFlag)
                    findPosition = fistPosition;
            }
            LBSORT.Items.Insert(findPosition, nGrade);
        }

        private void BEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
