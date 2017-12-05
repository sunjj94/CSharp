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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                //检测文本框内容(消除前后多余空格)
                if (txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("用户名和密码不能为空!", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //验证用户
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "server=.;database=PhoneBook;uid=sa;pwd=123456;";
                conn.Open();
                StringBuilder sql = new StringBuilder();
                sql.AppendFormat("select count(*) from 用户 where 用户名 = '{0}' and 密码 = '{1}'", txtUserName.Text.Trim(), txtPassword.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql.ToString(), conn);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                if (result == 1)
                {
                    //登录成功
                    frmMain f = new frmMain();
                    f.tsslUserName.Text = txtUserName.Text.Trim();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名和密码错误!", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("发生错误/r/n" + ee.Message, "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
