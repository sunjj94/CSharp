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

namespace AddressBook
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private string strUserName = "";
        private int groupCount = 0;
        private int contentCount = 0;
        private string txtFilePath = "";
        private string strConn = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        protected void LoadGroup()
        {
            try
            {
                cmbGroup.Items.Clear();
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select distinct 组别 from 联系人 where 用户名='" + strUserName + "'";
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    cmbGroup.Items.Add(sdr[0].ToString());
                }
                sdr.Close();
                conn.Close();

                if (groupCount > 0 && cmbGroup.Items.Count == groupCount)
                {
                    cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    cmbGroup.DropDownStyle = ComboBoxStyle.DropDown;
                }
            }
            catch
            { }
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            //获取用户名
            //应注意在frmMain窗体中tsslUserName控件的Modifiers属性应为public
            strUserName = ((frmMain)(this.Owner)).tsslUserName.Text;

            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                //获取配置信息
                cmd.CommandText = "select * from 用户 where 用户名='" + strUserName + "'";
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    groupCount = Convert.ToInt32(sdr["组别数量最大值"]);
                    contentCount = Convert.ToInt32(sdr["联系人数量最大值"]);
                }
                sdr.Close();

                //获取联系人数
                cmd.CommandText = "select count(*) from 联系人 where 用户名='" + strUserName + "'";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count >= contentCount)
                {
                    MessageBox.Show("联系人的个数已经达到上限!\r\n如需继续添加联系人，请联系管理员。","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    btnOK.Enabled = false;
                }
                conn.Close();
            }
            catch
            { }

            //加载默认照片
            //首先在Resouces中添加图片 然后打开Properties -> Resources.resx 选择图像 并添加资源
            pic.Image = AddressBook.Properties.Resources.User;

            //加载组别
            LoadGroup();
        }

        private void pic_Click(object sender, EventArgs e)
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(dlg.FileName);
                txtFilePath = dlg.FileName;
            }
        }
    }
}
