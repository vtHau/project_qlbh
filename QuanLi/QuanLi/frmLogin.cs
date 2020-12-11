using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string queryAdmin = " SELECT COUNT(*) FROM Account  WHERE AccUser ='" + txtUser.Text.Trim() + "' AND AccPass ='" + txtPass.Text.Trim() + "'";
                string queryEmpl = " SELECT COUNT(*) FROM AccNV  WHERE AccUser ='" + txtUser.Text.Trim() + "' AND AccPass ='" + txtPass.Text.Trim() + "'";

                DataTable loginAdmin = DataProvider.Instance.ExecuteQuery(queryAdmin);
                DataTable loginEmpl = DataProvider.Instance.ExecuteQuery(queryEmpl);

                if (loginAdmin.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    frmMain main = new frmMain(txtUser.Text.Trim(), txtPass.Text.Trim(), true);
                    noti.ShowBalloonTip(2500);
                    main.ShowDialog();
                    this.Close();
                }
                else if (loginEmpl.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    frmMain main = new frmMain(txtUser.Text.Trim(), txtPass.Text.Trim(), false);
                    noti.ShowBalloonTip(2500);
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUser;
        }

        private void txtUser_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUser, "Tên đăng nhập không được để trống.");
            }
            else if (txtUser.Text.Length < 5)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUser, "Tên phải có 5 ký tự trở lên.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void txtPass_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                e.Cancel = true;
                errorProvider2.SetError(txtPass, "Mật khẩu không được để trống.");
            }
            else if (txtPass.Text.Length < 8)
            {
                e.Cancel = true;
                errorProvider2.SetError(txtPass, "Mật khẩu phải có 8 ký tự trở lên.");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.Clear();
            }
        }
    }
}
