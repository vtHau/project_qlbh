using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class frmChangePass : Form
    {
        string username;
        string password;
        bool isAdmin;

        public frmChangePass()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public frmChangePass(string user, string pass, bool admin) : this()
        {
            username = user;
            password = pass;
            isAdmin = admin;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain(username, password, isAdmin);
            main.ShowDialog();
            this.Close();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            string currPass = txtCurrPass.Text.Trim();
            string newPass = txtNewPass.Text.Trim();
            string newPassPre = txtNewPassPre.Text.Trim();

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string query = "UPDATE Account SET AccPass = @newPassPre  WHERE AccUser = @username ";

                if (!isAdmin)
                {
                    query = "UPDATE AccNV SET AccPass = @newPassPre  WHERE AccUser = @username ";
                }
                object[] para = new object[] { newPassPre, username };

                if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCurrPass.Text = "";
                    txtNewPass.Text = "";
                    txtNewPassPre.Text = "";
                }
                else
                {
                    MessageBox.Show("Thay đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCurrPass_Validating(object sender, CancelEventArgs e)
        {
            string pass = txtCurrPass.Text.Trim();

            if (string.IsNullOrEmpty(pass))
            {
                e.Cancel = true;
                errCurrPass.SetError(txtCurrPass, "Mật khẩu không được để trống");
            }
            else if (pass != password)
            {
                e.Cancel = true;
                errCurrPass.SetError(txtCurrPass, "Mật khẩu hiện tại không đúng");
            }
            else
            {
                e.Cancel = false;
                errCurrPass.Clear();
            }
        }

        private void txtNewPass_Validating(object sender, CancelEventArgs e)
        {
            string newPass = txtNewPass.Text.Trim();

            if (string.IsNullOrEmpty(newPass))
            {
                e.Cancel = true;
                errNewPass.SetError(txtNewPass, "Mật khẩu không được để trống");
            }
            else if (newPass.Length < 8)
            {
                e.Cancel = true;
                errNewPass.SetError(txtNewPass, "Mật khẩu phải có 8 ký tự trở lên");
            }
            else if (newPass.Length > 20)
            {
                e.Cancel = true;
                errNewPass.SetError(txtNewPass, "Mật khẩu quá dài");
            }
            else
            {
                e.Cancel = false;
                errNewPass.Clear();
            }
        }

        private void txtNewPassPre_Validating(object sender, CancelEventArgs e)
        {
            string newPass = txtNewPass.Text.Trim();
            string newPassPre = txtNewPassPre.Text.Trim();

            if (string.IsNullOrEmpty(newPassPre))
            {
                e.Cancel = true;
                errNewPassPre.SetError(txtNewPassPre, "Mật khẩu không được để trống");
            }
            else if (newPass.Length < 8)
            {
                e.Cancel = true;
                errNewPassPre.SetError(txtNewPassPre, "Mật khẩu phải có 8 ký tự trở lên");
            }
            else if (newPass.Length > 20)
            {
                e.Cancel = true;
                errNewPassPre.SetError(txtNewPassPre, "Mật khẩu quá dài");
            }
            else if (newPass != newPassPre)
            {
                e.Cancel = true;
                errNewPassPre.SetError(txtNewPassPre, "2 Mật khẩu không khớp, vui lòng nhập lại");
            }
            else
            {
                e.Cancel = false;
                errNewPassPre.Clear();
            }
        }

    }
}
