using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeGame
{
    public class Block
    {
        //编号
        private int number;
        //（左上角）位置
        private Point origin;

        //编号属性
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        //位置属性
        public Point Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        //绘制块
        public void Display(Graphics g)
        {
            Pen pen = new Pen(Color.Red);
            g.DrawRectangle(pen, origin.X, origin.Y, 5, 5);
        }

        //消除块
        public void UnDisplay(Graphics g)
        {
            Pen pen = new Pen(Color.Silver);
            g.DrawRectangle(pen, origin.X, origin.Y, 5, 5);
        }
    }
}
