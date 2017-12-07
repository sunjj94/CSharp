using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AddressBook
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private string strConn = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadGroup();
            if (trvGroup.Nodes.Count > 0)
            {
                trvGroup.SelectedNode = trvGroup.Nodes[0];
                LoadList();
            }
            else
            {
                lvContact.Clear();
            }
        }

        private void LoadGroup()
        {
            try
            {
                trvGroup.Nodes.Clear();//trvGroup为控件ID
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select distinct 组别 from 联系人 where 用户名='" + tsslUserName.Text + "'";
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    trvGroup.Nodes.Add(sdr[0].ToString());
                }
                sdr.Close();
                conn.Close();
            }
            catch
            { }
        }

        private void LoadList()
        {
            if (trvGroup.Nodes.Count == 0)
            {
                lvContact.Clear();
                return;
            }
            if (trvGroup.SelectedNode.Index >= 0)
            {
                string strGroup = trvGroup.SelectedNode.Text;
                try
                {
                    lvContact.Clear();
                    lvContact.Columns.Add("姓名", 100);
                    lvContact.Columns.Add("工作单位", 150);
                    lvContact.Columns.Add("联系电话", 100);
                    lvContact.Columns.Add("电子邮箱", 150);
                    SqlConnection conn = new SqlConnection(strConn);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select 编号,姓名,工作单位,联系电话,电子邮箱 from 联系人 where 组别='" + strGroup + "' and 用户名='" + tsslUserName.Text + "'";
                    conn.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    int count = 0;
                    while (sdr.Read())
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = sdr["姓名"].ToString();
                        lvi.SubItems.Add(sdr["工作单位"].ToString());
                        lvi.SubItems.Add(sdr["联系电话"].ToString());
                        lvi.SubItems.Add(sdr["电子邮箱"].ToString());
                        lvi.Tag = sdr["编号"];
                        lvi.ImageIndex = 0;

                        lvContact.Items.Add(lvi);
                        count++;
                    }
                    tsslCount.Text = "共计" + count.ToString() + "个联系人";
                    sdr.Close();
                    conn.Close();
                }
                catch
                { }
            }
        }
               
        //在窗体属性中添加
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void trvGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadList();
        }

        private void 详细信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lvContact.View = View.Details;
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvContact.View = View.Details;
        }

        private void 图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvContact.View = View.LargeIcon;
        }

        private void 图标toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            lvContact.View = View.LargeIcon;
        }

        private void Add()
        {
            frmAdd f = new frmAdd();
            if (f.ShowDialog(this) == DialogResult.OK)
            {
                LoadGroup();
                if (trvGroup.Nodes.Count > 0)
                {
                    trvGroup.SelectedNode = trvGroup.Nodes[0];
                    LoadList();
                }
                else
                {
                    lvContact.Clear();
                }
            }
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Edit()
        {
            if (lvContact.SelectedItems.Count == 1)
            {
                int id = Convert.ToInt32(lvContact.SelectedItems[0].Tag);
                frmEdit f = new frmEdit(id);
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    LoadGroup();
                    if (trvGroup.Nodes.Count > 0)
                    {
                        trvGroup.SelectedNode = trvGroup.Nodes[0];
                        LoadList();
                    }
                    else
                    {
                        lvContact.Clear();
                    }
                }
            }
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void 修改MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        //在lvContact控件中双击响应事件
        private void lvContact_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Edit();
        }

        private void Delete()
        {
            if (lvContact.SelectedItems.Count < 1)
            {
                return;
            }
            if (MessageBox.Show("是否要删除选中的联系人?", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strWhere = " where 编号 in (";
                foreach (ListViewItem lvi in lvContact.SelectedItems)
                {
                    strWhere += lvi.Tag.ToString() + ",";
                }
                strWhere = strWhere.Substring(0, strWhere.Length - 1);
                strWhere += ")";
                try
                {
                    SqlConnection conn = new SqlConnection(strConn);
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from 联系人 " + strWhere;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadGroup();
                    if (trvGroup.Nodes.Count > 0)
                    {
                        trvGroup.SelectedNode = trvGroup.Nodes[0];
                        LoadList();
                    }
                    else
                    {
                        lvContact.Clear();
                    }
                }
                catch { }
            }
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void lvContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Delete();
            }
        }
    }
}
