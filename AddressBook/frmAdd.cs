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
using System.IO;

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

        private void btnOK_Click(object sender, EventArgs e)
        {

            #region 获取信息
            //用户名
            strUserName = ((frmMain)(this.Owner)).tsslUserName.Text;
            //姓名
            string name;
            if (txtName.Text == "")
            {
                MessageBox.Show("联系人姓名不能为空!", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                name = txtName.Text;
            }
            //组别
            string group;
            if (cmbGroup.Text.Trim() == "")
            {
                group = "未分组";
            }
            else
            {
                group = cmbGroup.Text.Trim();
            }
            //电话
            string phone = txtPhone.Text.Trim();
            //工作单位
            string company = txtCompany.Text.Trim();
            //email
            string email = txtEmail.Text.Trim();
            //照片
            byte[] b = null;
            if (txtFilePath != "")
            {
                try
                {
                    FileStream fs = new FileStream(txtFilePath, FileMode.Open, FileAccess.Read);
                    int len = Convert.ToInt32(fs.Length);
                    b = new byte[len];
                    fs.Read(b, 0, len);
                    fs.Close();
                }
                catch
                {
                    b = null;
                }
            }
            #endregion 获取信息

            #region 添加数据
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd_maxid = new SqlCommand();
                cmd_maxid.Connection = conn;

                //获取最大编号
                cmd_maxid.CommandText = "select isnull(max(编号),0)+1 from 联系人";
                conn.Open();
                int maxid;
                try
                {
                    maxid = Convert.ToInt32(cmd_maxid.ExecuteScalar());
                }
                catch
                {
                    maxid = 1;
                }
                //insert
                SqlCommand cmd_insert = new SqlCommand();
                cmd_insert.Connection = conn;
                cmd_insert.CommandText = "insert into 联系人(编号,用户名,组别,姓名,工作单位,联系电话,电子邮箱,照片) ";
                cmd_insert.CommandText += " values(@编号,@用户名,@组别,@姓名,@工作单位,@联系电话,@电子邮箱,@照片)";
                cmd_insert.Parameters.Add("@编号", SqlDbType.Int);
                cmd_insert.Parameters.Add("@用户名", SqlDbType.VarChar, 50);
                cmd_insert.Parameters.Add("@组别", SqlDbType.VarChar, 50);
                cmd_insert.Parameters.Add("@姓名", SqlDbType.VarChar, 50);
                cmd_insert.Parameters.Add("@工作单位", SqlDbType.VarChar, 500);
                cmd_insert.Parameters.Add("@联系电话", SqlDbType.VarChar, 200);
                cmd_insert.Parameters.Add("@电子邮箱", SqlDbType.VarChar, 200);
                cmd_insert.Parameters.Add("@照片", SqlDbType.Image);

                cmd_insert.Parameters["@编号"].Value = maxid;
                cmd_insert.Parameters["@用户名"].Value = strUserName;
                cmd_insert.Parameters["@组别"].Value = group;
                cmd_insert.Parameters["@姓名"].Value = name;
                cmd_insert.Parameters["@工作单位"].Value = company;
                cmd_insert.Parameters["@联系电话"].Value = phone;
                cmd_insert.Parameters["@电子邮箱"].Value = email;
                if (txtFilePath == "")
                {
                    cmd_insert.Parameters["@照片"].Value = DBNull.Value;
                }
                else
                {
                    cmd_insert.Parameters["@照片"].Value = b;
                }
                cmd_insert.ExecuteNonQuery();
                conn.Close();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion 添加数据
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
