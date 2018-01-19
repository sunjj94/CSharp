using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sunshine五十音
{
    class CtrTextBox
    {
        //CtrTextBox的位置
        private Point ctrLocation;
        private String ctrString;

        //位置属性
        public Point CtrLocation
        {
            get
            {
                return ctrLocation;
            }
            set
            {
                ctrLocation = value;
            }
        }

        //字符属性
        public String CtrString
        {
            get
            {
                return ctrString;
            }
            set
            {
                ctrString = value;
            }
        }

        //生成方法
        public void DrawCtrTextBox(Point p)
        {
            TextBox textBox = new TextBox();
            textBox.Location = p;
        }
    }
}
