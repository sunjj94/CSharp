using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace AddressBook
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private int ID;
        private string strConn = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
        private string txtFilePath = "";
        private byte[] picData = null;

        private string strUserName = "";
        private int groupCount = 0;
        private int contentCount = 0;

        public frmEdit(int id)
        {
            InitializeComponent();
            ID = id;
        }

        protected void LoadGroup()
        {
            try
            {
                cmbGroup.Items.Clear();
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select distinct 组别 from 联系人";
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

        private void frmEdit_Load(object sender, EventArgs e)
        {
            //获取用户名
            strUserName = ((frmMain)(this.Owner)).tsslUserName.Text;

            LoadGroup();
            //获取配置信息
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from 联系人 where 编号=" + ID.ToString();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                txtName.Text = ds.Tables[0].Rows[0]["姓名"].ToString();
                cmbGroup.Text = ds.Tables[0].Rows[0]["组别"].ToString();
                txtPhone.Text = ds.Tables[0].Rows[0]["联系电话"].ToString();
                txtCompany.Text = ds.Tables[0].Rows[0]["工作单位"].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0]["电子邮箱"].ToString();
                if (ds.Tables[0].Rows[0]["照片"] == DBNull.Value)
                {
                    pic.Image = AddressBook.Properties.Resources.User;
                }
                else
                {
                    byte[] b = (byte[])(ds.Tables[0].Rows[0]["照片"]);
                    pic.Image = Image.FromStream(new MemoryStream(b));
                    picData = b;
                }
            }

            cmd.CommandText = "select * from 用户 where 用户名='" + strUserName + "'";
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                groupCount = Convert.ToInt32(sdr["组别数量最大值"]);
                contentCount = Convert.ToInt32(sdr["联系人数量最大值"]);
            }
            sdr.Close();
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
            else
            {
                b = picData;
            }
            #endregion 获取信息

            #region 更新数据
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                //insert
                SqlCommand cmd_update = new SqlCommand();
                cmd_update.Connection = conn;
                cmd_update.CommandText = "update 联系人 set 组别=@组别,姓名=@姓名,工作单位=@工作单位,联系电话=@联系电话,电子邮箱=@电子邮箱,照片=@照片 ";
                cmd_update.CommandText += " where 编号=@编号";
                cmd_update.Parameters.Add("@编号", SqlDbType.Int);
                cmd_update.Parameters.Add("@组别", SqlDbType.VarChar, 50);
                cmd_update.Parameters.Add("@姓名", SqlDbType.VarChar, 50);
                cmd_update.Parameters.Add("@工作单位", SqlDbType.VarChar, 500);
                cmd_update.Parameters.Add("@联系电话", SqlDbType.VarChar, 200);
                cmd_update.Parameters.Add("@电子邮箱", SqlDbType.VarChar, 200);
                cmd_update.Parameters.Add("@照片", SqlDbType.Image);

                cmd_update.Parameters["@编号"].Value = ID;
                cmd_update.Parameters["@组别"].Value = group;
                cmd_update.Parameters["@姓名"].Value = name;
                cmd_update.Parameters["@工作单位"].Value = company;
                cmd_update.Parameters["@联系电话"].Value = phone;
                cmd_update.Parameters["@电子邮箱"].Value = email;
                if (txtFilePath == "" && picData == null)
                {
                    cmd_update.Parameters["@照片"].Value = DBNull.Value;
                }
                else
                {
                    cmd_update.Parameters["@照片"].Value = b;
                }
                cmd_update.ExecuteNonQuery();
                conn.Close();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion 更新数据
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
