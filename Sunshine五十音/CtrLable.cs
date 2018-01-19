using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sunshine五十音
{
    public class CtrLable
    {
        //CtrLable的位置
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
        public void DrawCtrLable(Point p, String s)
        {
            TextBox textLable = new TextBox();
            textLable.Location = p;
            textLable.Text = s;
        }
    }
}
