using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private string strUserName = "";
        private string strConn = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];

        public frmSearch(string user)
        {
            InitializeComponent();
            strUserName = user;
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            this.Height = 82;
            try
            {
                SqlConnection conn = new SqlConnection(strConn);
                SqlCommand cmd = new SqlCommand("select 姓名,联系电话 from 联系人 where 用户名='" + strUserName + "'", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    txtName.AutoCompleteCustomSource.Add(dr["姓名"].ToString());
                    txtPhone.AutoCompleteCustomSource.Add(dr["联系电话"].ToString());
                }
            }
            catch
            {

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" && txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("姓名和电话至少要填写一项!", "查找失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #region 构造Select语句进行查询
            StringBuilder strWhere = new StringBuilder(" where ");
            if (txtName.Text.Trim() != "")
            {
                strWhere.AppendFormat(" 姓名 like '%{0}%'", txtName.Text.Trim());
            }
            if (txtPhone.Text.Trim() != "")
            {
                if (strWhere.ToString() != " where ")
                {
                    strWhere.Append(" and ");
                }
                strWhere.AppendFormat(" 联系电话 like '%{0}%'", txtPhone.Text.Trim());
            }

            string sql = "select 姓名,组别,工作单位,联系电话,电子邮箱 from 联系人 " + strWhere.ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            #endregion 构造Select语句进行查询
            /*
            #region 使用存储过程
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("查找联系人", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@phone", SqlDbType.VarChar, 200);
            cmd.Parameters.Add("@user", SqlDbType.VarChar, 50);
            cmd.Parameters["@name"].Value = txtName.Text.Trim();
            cmd.Parameters["@phone"].Value = txtPhone.Text.Trim();
            cmd.Parameters["@user"].Value = strUserName;
            #endregion 使用存储过程
            */
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dgvResult.DataSource = ds.Tables[0];
            this.Height = 250;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
