using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sunshine五十音
{
    public class Sneces
    {
        private CtrLabel cLabel;
        private CtrTextBox cTextBox;

        public Sneces()
        {

        }

        public Sneces(Point p, Size s, Control.ControlCollection con)
        {
            CreateLine(p, s, con);
        }
        //创建一行
        private void CreateLine(Point p, Size s, Control.ControlCollection con)
        {
            cLabel = new CtrLabel();
            cLabel.CtrString = "きゃ";
            cLabel.DrawCtrLabel(p, cLabel.CtrString, s, con);
            cTextBox = new CtrTextBox();
            p.Offset(0, 28);
            cTextBox.DrawCtrTextBox(p, s, con);
        }

        //创建N行
        private void CreateNLine(Point p, Size s)
        {

        }

        //对比方法
        public void Compare()
        {

        }

        //捕捉Enter键
        public void Complete()
        {

        }
    }
}
