using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sunshine五十音
{
    public class CtrTextBox
    {
        //CtrTextBox的位置
        private Point ctrLocation;
        private String ctrString;
        private Size ctrSize;
                
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

        public Size CtrSize
        {
            get
            {
                return ctrSize;
            }
            set
            {
                ctrSize = value;
            }
        }

        //生成方法
        public void DrawCtrTextBox(Point p, Size s, Control.ControlCollection con)
        {
            TextBox textBox = new TextBox();
            textBox.Location = p;
            textBox.Size = s;
            textBox.Font = new Font("宋体", 14, FontStyle.Regular);
            textBox.TextAlign = HorizontalAlignment.Center;
            con.Add(textBox);
        }

        public void DrawCtrTextBox(Control.ControlCollection con)
        {
            TextBox textBox = new TextBox();
            textBox.Location = ctrLocation;
            textBox.Size = ctrSize + new Size(20, 20);
            textBox.Font = new Font("宋体", 14, FontStyle.Regular);
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.ImeMode = ImeMode.Hiragana;
            con.Add(textBox);
        }
                
        private void EnterKey(TextBox tbox, KeyEventArgs e)
        {
            if (tbox.Focused)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ctrString = tbox.Text;
                    SendKeys.Send("{tab}");
                }
            }
        }
    }
}
