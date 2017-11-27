using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;

namespace SnakeGame
{
    public class Snake
    {
        //数组列表 用来保存蛇的所有块
        private ArrayList blockList;
        //蛇头的编号 也是蛇的长度
        private int headNumber;
        //蛇头的位置 用于判断蛇是否吃了豆或是撞墙了
        private Point headPoint;
        //当前运动方向 0为上 1为右 2为下 3为左
        private int direction = 1;

        //蛇长属性
        public int HeadNumber
        {
            get { return headNumber; }
            set { headNumber = value; }
        }

        //方向属性
        public int Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        //蛇头位置属性
        public Point getHeadPoint
        {
            get { return headPoint; }
        }

        //蛇是否撞到自己身上
        public bool getHitSelf
        {
            get
            {
                IEnumerator myEnumerator = blockList.GetEnumerator();
                try
                {
                    while (myEnumerator.MoveNext())
                    {
                        Block b = (Block)myEnumerator.Current;
                        //判断当前块不是蛇头且与蛇头位置相同
                        if (b.Number != headNumber &&
                            b.Origin.Equals(headPoint))
                        {
                            return true;
                        }
                    }
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.ToString());
                }
                return false;
            }
        }

        //构造函数
        public Snake()
        {
        }

        //参数vertex是起点，开始时蛇出现的位置 count表示开始时蛇的长度
        public Snake(Point vertex, int count)
        {
            Block bb;
            Point p = new Point(vertex.X + 25, vertex.Y + 25);
            blockList = new ArrayList(count);

            for (int i = 0; i < count; i++)
            {
                p.X = p.X + 5;
                bb = new Block();
                bb.Origin = p;
                bb.Number = i + 1;
                blockList.Add(bb);

                //如果是蛇头就把位置（顶点）赋给headPoint
                if (i == count -1)
                {
                    headPoint = bb.Origin;
                }
            }
            headNumber = count;
        }

        //蛇的转向方法，参数为蛇要改变的方向
        public void TurnDirection(int pDirection)
        {
            switch (direction)
            {
                case 0:
                    if (pDirection == 3)
                        direction = 3;
                    else if (pDirection == 1)
                        direction = 1;
                    break;
                case 1:
                    if (pDirection == 0)
                        direction = 0;
                    else if (pDirection == 2)
                        direction = 2;
                    break;
                case 2:
                    if (pDirection == 1)
                        direction = 1;
                    else if (pDirection == 3)
                        direction = 3;
                    break;
                case 3:
                    if (pDirection == 0)
                        direction = 0;
                    else if (pDirection == 2)
                        direction = 2;
                    break;
            }
        }

        //蛇增长方法
        public void Growth()
        {
            Block bb = new Block();
            IEnumerator myEnumerator = blockList.GetEnumerator();

            try
            {
                while (myEnumerator.MoveNext())
                {
                    Block b = (Block)myEnumerator.Current;
                    if (b.Number == headNumber)
                    {
                        int x = b.Origin.X;
                        int y = b.Origin.Y;
                        switch(direction)
                        {
                            case 0:
                                y = y - 5;
                                break;
                            case 1:
                                x = x + 5;
                                break;
                            case 2:
                                y = y + 5;
                                break;
                            case 3:
                                x = x - 5;
                                break;
                        }
                        Point headP = new Point(x, y);
                        bb.Origin = headP;
                        bb.Number = b.Number + 1;
                        blockList.Add(bb);
                        headNumber++;
                        headPoint = headP;
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
        }

        //显示蛇
        public void Display(Graphics g)
        {
            try
            {
                Block b = new Block();
                b = (Block)blockList[0];
                b.UnDisplay(g);
                blockList.RemoveAt(0);
                Block bb = new Block();
                IEnumerator myEnumerator = blockList.GetEnumerator();

                while (myEnumerator.MoveNext())
                {
                    b = (Block)myEnumerator.Current;
                    b.Number--;
                    if (b.Number == (headNumber - 1))
                    {
                        int x = b.Origin.X;
                        int y = b.Origin.Y;
                        switch (direction)
                        {
                            case 0:
                                y = y - 5;
                                break;
                            case 1:
                                x = x + 5;
                                break;
                            case 2:
                                y = y + 5;
                                break;
                            case 3:
                                x = x - 5;
                                break;
                        }
                        Point headP = new Point(x, y);
                        bb.Origin = headP;
                        bb.Number = headNumber;
                        bb.Display(g);
                        headPoint = bb.Origin;
                    }
                    b.Display(g);
                }
                blockList.Add(b);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
        }

        //消失蛇
        public void UnDisplay(Graphics g)
        {
            try
            {
                Block bb = new Block();
                IEnumerator myEnumerator = blockList.GetEnumerator();
                while (myEnumerator.MoveNext())
                {
                    Block b = (Block)myEnumerator.Current;
                    b.UnDisplay(g);
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
        }

        //重新开始游戏
        public void Reset(Point dian, int count)
        {
            Block bb;
            Point p = new Point(dian.X + 25, dian.Y + 25);
            blockList = new ArrayList(count);
            for (int i = 0; i < count; i++)
            {
                p.X = p.X + 5;
                bb = new Block();
                bb.Number = i + 1;
                bb.Origin = p;
                blockList.Add(bb);
                if (i == count - 1)
                {
                    headPoint = bb.Origin;
                }
                headNumber = count;
                direction = 1;
            }
        }
    }
}
