using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunshine五十音
{
    public partial class Form1 : Form
    {
        private Sneces sneces;
        private Property proForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取软件设置
            proForm = new Property();
            foreach (Control c in groupBox1.Controls)
            {
                if (c is CheckBox)
                    proForm.SetProperty((CheckBox)c);
            }
            sneces = new Sneces(new Point(30, 60), new Size(60, 25), this.Controls, proForm);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            //获取软件设置
            proForm = new Property();
            foreach (Control c in groupBox1.Controls)
            {
                if (c is CheckBox)
                    proForm.SetProperty((CheckBox)c);
            }
            sneces.Update(new Point(30, 60), new Size(60, 25), this.Controls, proForm);
        }
    }
}