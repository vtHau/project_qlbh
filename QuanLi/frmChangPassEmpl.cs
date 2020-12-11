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
    public partial class frmChangePassEmpl : Form
    {
        string username;
        string password;
        bool isAdmin;


        public frmChangePassEmpl()
        {
            InitializeComponent();
        }

        private void frmChangePassEmpl_Load(object sender, EventArgs e)
        {
            LoadCBX();
        }
        public frmChangePassEmpl(string user, string pass, bool admin) : this()
        {
            username = user;
            password = pass;
            isAdmin = admin;
        }

        private void LoadCBX()
        {
            cbxNV.DataSource = ClassEmployee.HandleEmployee.Instance.LoadDGV();
            cbxNV.DisplayMember = "TenNV";
            cbxNV.ValueMember = "MaNV";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MaNV = cbxNV.SelectedValue.ToString();

            string query = "UPDATE AccNV SET AccPass = '12345678'  WHERE MaNV = '" + MaNV + "'";

            if (DataProvider.Instance.ExecuteNonQuery(query) > 0)
            {
                MessageBox.Show("Thay đổi mật khẩu thành công, Mật khẩu là 12345678", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Thay đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain(username, password, isAdmin);
            main.ShowDialog();
            this.Close();

        }

        private void cbxNV_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMaNV.Text = cbxNV.SelectedValue.ToString();
        }
    }
}
