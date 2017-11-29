using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeGame
{
    public class Floor
    {
        private static int unit = 5;//单位长度
        public int score;
        private int length = 80 * unit;
        private int width = 50 * unit;
        private Point dot; //顶点
        private Snake s;
        private Bean bean1;

        public Snake S
        {
            get { return s; }
        }

        public int Score
        {
            get { return score; }
            set { value = score; }
        }

        public Floor()
        {       
        }

        public Floor(Point d)
        {
            dot = d;
            s = new Snake(d, 10);
            bean1 = new Bean();
            bean1.Origin = new Point(d.X + 30, d.Y + 30);
        }

        //显示整个场景
        public void Dispaly(Graphics g)
        {            
            Pen pen = new Pen(Color.Red);
            g.DrawRectangle(pen, dot.X, dot.Y, length, width);
            s.Display(g);
            CheckBean(g);
            bean1.Display(g);
        }

        //检查蛇是否吃了豆
        public void CheckBean(Graphics g)
        {
            if (bean1.Origin.Equals(s.getHeadPoint))
            {
                score += 10;
                this.displaybean(g);
                s.Growth();
            }
        }

        //检查蛇是否撞墙或自身
        public bool CheckSnake()
        {
            if ((dot.X < s.getHeadPoint.X && s.getHeadPoint.X < (dot.X + length) - 5) &&
                (dot.Y < s.getHeadPoint.Y && s.getHeadPoint.Y < (dot.Y + width) - 5) && !s.getHitSelf)
            {
                return false;
            }
            else
            {
                return true;                 
            }
        }

        //随机产生一个豆
        private Bean RandomBean()
        {
            Random random = new Random();
            int x = random.Next(length / unit - 2) + 1;
            int y = random.Next(width / unit - 2) + 1;
            Point d = new Point(dot.X + x * 5, dot.Y + y * 5);
            Bean bb = new Bean();
            bb.Origin = d;
            return bb;
        }

        //显示豆
        public void displaybean(Graphics g)
        {
            bean1.UnDisplay(g);
            bean1 = RandomBean();
            bean1.Display(g);
        }

        //重新开始
        public void ReSet(Graphics g)
        {
            s.UnDisplay(g);
            s.Reset(dot, 10);
        }
    }
}
