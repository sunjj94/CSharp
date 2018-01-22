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
        private TextBox ttextBox;
        public Form1()
        {
            InitializeComponent();
            //ttextBox = new TextBox();
            //ttextBox.Location = new Point(100, 100);
            //ttextBox.Size = new Size(80, 80);
            this.Controls.Add(ttextBox);
            sneces = new Sneces(new Point(30, 60), new Size(60, 25), this.Controls);
        }
    }
}