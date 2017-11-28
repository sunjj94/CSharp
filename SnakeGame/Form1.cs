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
        private int count;

        public Form1()
        {
            InitializeComponent();
            floor = new Floor(new Point(30, 30));
        }
    }
}
