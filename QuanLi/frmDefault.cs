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
    public partial class frmIntro : Form
    {
        string username;
        bool isAdmin;

        public frmIntro()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        public frmIntro(string user, string pass, bool admin) : this()
        {
            username = user;
            isAdmin = admin;
        }

        private void frmIntro_Load(object sender, EventArgs e)
        {

            string query = " SELECT TenAD FROM  TTAdmin WHERE AccAdmin = " + "'" + username + "'";
            txtIsWhat.Text = "Quản trị viên";
            if (!isAdmin)
            {
                query = " SELECT TenNV FROM  NhanVien , AccNV WHERE AccUser = " + "'" + username + "' AND NhanVien.MaNV = AccNV.MaNV ";
                txtIsWhat.Text = "Nhân viên";
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            txtHello.Text = "Hi " + data.Rows[0][0].ToString() + " ! Chào Mừng bạn đã quay lại !!!";
        }

        private void txtIsWhat_Click(object sender, EventArgs e)
        {

        }
    }
}
