using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Sunshine五十音
{
    public class Sneces
    {
        public Sneces()
        {

        }

        public Sneces(Point p, Size s, Control.ControlCollection con, Property pro)
        {
            CreateNLine(p, s, con, pro);
        }
        //创建一行
        private void CreateLine(Point p, Size s, Control.ControlCollection con, Property pro)
        {
            String[] str = new String[5];
            GetSqlContent(pro, str);
            List<CtrLabel> cLabel = new List<CtrLabel>(6);
            Point pLabel = p;
            for (int i = 0; i < 5; i++)
            {
                cLabel.Insert(i, new CtrLabel());
                cLabel[i].CtrLocation = pLabel;
                cLabel[i].CtrSize = s;
                cLabel[i].CtrString = str[i];
                cLabel[i].DrawCtrLabel(con);
                pLabel.Offset(s.Width + 28, 0);
            }
            List<CtrTextBox> cTextBox = new List<CtrTextBox>(6);
            Point pTextBox = p;
            pTextBox.Offset(-10, 28);
            for (int i = 0; i < 5; i++)
            {
                cTextBox.Insert(i, new CtrTextBox());
                cTextBox[i].CtrLocation = pTextBox;
                cTextBox[i].CtrSize = s;
                cTextBox[i].DrawCtrTextBox(con);
                pTextBox.Offset(s.Width + 28, 0);
            }
        }

        //创建N行
        private void CreateNLine(Point p, Size s, Control.ControlCollection con, Property pro)
        {
            for (int i = 0; i < 5; i++)
            {
                CreateLine(p, s, con, pro);
                p.Offset(0, 60);
            }
        }

        //选取数据库
        private void SelectSqlTableName(Property p)
        {
            int i = 0;            
            if (p.ProSrud == true)
                p.ProTable[i++] = "清音拨音";
            if (p.ProDullness == true)
                p.ProTable[i++] = "浊音半浊音";
            if (p.ProOverSound == true)
                p.ProTable[i++] = "拗音";

            if (p.ProHiragana == true)
                p.ProType = "平假名";
            if (p.ProKatakana == true)
            {
                if (p.ProType == "平假名")
                    p.ProType = "混合";
                else
                    p.ProType = "片假名";
            }            
        }

        //获取数据库内容
        public void GetSqlContent(Property p, String[] s)
        {
            SelectSqlTableName(p);
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "server=.;database=五十音;uid=sa;pwd=123456;";
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from ";
                Random ranTable = new Random();
                int iTable;
                do
                {                    
                    iTable = ranTable.Next(0, 3);
                    cmd.CommandText = string.Concat(cmd.CommandText, p.ProTable[iTable]);
                } while (p.ProTable[iTable] == null);
                

                for (int i = 0; i < 5; i++)
                {
                    SqlDataReader sdr = cmd.ExecuteReader();
                    Random ranData = new Random();
                    int iData = 0;
                    if (p.ProTable[iTable] == "清音拨音")
                        iData = ranData.Next(0, 46);
                    else if (p.ProTable[iTable] == "浊音半浊音")
                        iData = ranData.Next(0, 25);
                    else if (p.ProTable[iTable] == "拗音")
                        iData = ranData.Next(0, 33);
                    System.Threading.Thread.Sleep(20);             
                    for (int n = 0; n < iData; n++)
                    {
                        sdr.Read();
                    }
                    Random ranType = new Random();
                    int iType;
                    if (sdr.Read())
                    {
                        switch (p.ProType)
                        {
                            case "混合":
                            default:
                                iType = ranType.Next(1, 3);
                                s[i] = sdr[iType].ToString();
                                break;
                            case "平假名":
                                s[i] = sdr[1].ToString();
                                break;
                            case "片假名":
                                s[i] = sdr[2].ToString();
                                break;
                        }                        
                    }
                    sdr.Close();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "数据库操作失败", MessageBoxButtons.OK);
            }
            finally
            {

            }
        }

        //更新场景
        public void Update(Point p, Size s, Control.ControlCollection con, Property pro)
        {
            //最少操作六次，否则会导致销毁不全面
            //因为删除操作会导致索引前移而漏掉部分控件
            for (int i = 0; i < 6; i++)
            {
                foreach (Control c in con)
                {
                    if (c is Label || c is TextBox)
                    {
                        c.Dispose();
                    }
                }
            }            
            CreateNLine(p, s, con, pro);
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
