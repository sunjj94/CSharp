using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeGame
{
    public class Bean
    {
        //豆的显示位置
        private Point origin;

        //位置属性
        public Point Origin
        {
            get
            {
                return origin;
            }
            set
            {
                origin = value;
            }
        }

        //绘制豆
        public void Display(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, origin.X, origin.Y, 5, 5);//画实心矩形
        }

        //消除豆
        public void UnDisplay(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Silver);//定义背景色画刷
            g.FillRectangle(brush, origin.X, origin.Y, 5, 5);
        }
    }
}
