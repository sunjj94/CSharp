using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sunshine五十音
{
    public class CtrLabel
    {
        //CtrLabel的位置
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
        public void DrawCtrLabel(Point p, String str, Size s, Control.ControlCollection con)
        {
            Label textLabel = new Label();
            textLabel.Location = p;
            textLabel.Text = str;
            textLabel.Size = s;
            textLabel.Font = new Font("宋体", 18, FontStyle.Bold);
            con.Add(textLabel);
        }

        public void DrawCtrLabel(Control.ControlCollection con)
        {
            Label textLabel = new Label();
            textLabel.Location = ctrLocation;
            textLabel.Text = ctrString;
            textLabel.Size = ctrSize;
            textLabel.Font = new Font("宋体", 18, FontStyle.Bold);
            con.Add(textLabel);
        }
    }
}
