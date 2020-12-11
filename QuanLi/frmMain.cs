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
    public partial class frmMain : Form
    {
        string username;
        string password;
        bool isAdmin;

        public frmMain()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        public frmMain(string user, string pass, bool admin) : this()
        {
            username = user;
            password = pass;
            isAdmin = admin;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmIntro intro = new frmIntro(username, password, isAdmin);
            intro.TopLevel = false;
            pnlMain.Controls.Add(intro);
            intro.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlMain.Dock = DockStyle.Fill;
            intro.Show();
            menuStrip1.Items[0].Visible = false;

            if (isAdmin)
            {
                menuStrip1.Items[0].Visible = true;
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmUser user = new frmUser();
            user.TopLevel = false;
            pnlMain.Controls.Add(user);
            user.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlMain.Dock = DockStyle.Fill;
            user.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmProduct product = new frmProduct();
            product.TopLevel = false;
            pnlMain.Controls.Add(product);
            product.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlMain.Dock = DockStyle.Fill;
            product.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa đăng xuất không ?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                noti.ShowBalloonTip(2500);
                login.ShowDialog();
                this.Close();
            }
        }

        private void giơiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmIntro intro = new frmIntro(username, password, isAdmin);
            intro.TopLevel = false;
            pnlMain.Controls.Add(intro);
            intro.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlMain.Dock = DockStyle.Fill;
            intro.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBill bill = new frmBill();
            bill.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                this.Hide();
                frmAdmin admin = new frmAdmin(username, password, isAdmin);
                admin.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                frmInfoEm infoEm = new frmInfoEm(username, password, isAdmin);
                infoEm.ShowDialog();
                this.Close();
            }
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangePass changePass = new frmChangePass(username, password, isAdmin);
            changePass.ShowDialog();
            this.Close();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmEmployee employee = new frmEmployee();
            employee.TopLevel = false;
            pnlMain.Controls.Add(employee);
            employee.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlMain.Dock = DockStyle.Fill;
            employee.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmTotalAll total = new frmTotalAll();
            total.TopLevel = false;
            pnlMain.Controls.Add(total);
            total.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pnlMain.Dock = DockStyle.Fill;
            total.Show();
        }

        private void khởiTạoMậtKhẩuNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangePassEmpl changePass = new frmChangePassEmpl(username, password, isAdmin);
            changePass.ShowDialog();
            this.Close();
        }
    }
}
