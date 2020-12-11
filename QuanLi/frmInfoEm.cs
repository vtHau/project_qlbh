using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class frmInfoEm : Form
    {
        public bool isEdit = false;
        public string username;
        public string password;
        public bool isAdmin;
        public string MaNV;

        public frmInfoEm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        public frmInfoEm(string user, string pass, bool admin) : this()
        {
            username = user;
            password = pass;
            isAdmin = admin;
            LoadInfoEmpl();
        }

        private void LoadInfoEmpl()
        {

            string query = " SELECT NhanVien.MaNV FROM AccNV , NhanVien  WHERE NhanVien.MaNV = AccNV.MaNV AND AccNV.AccUser =  " + "'" + username + "'";

            DataTable empl = DataProvider.Instance.ExecuteQuery(query);

            MaNV = empl.Rows[0][0].ToString();

            DataTable data = ClassEmployee.HandleEmployee.Instance.LoadDGVInfo(MaNV);

            txtTenAD.Text = data.Rows[0][0].ToString();
            txtSDT.Text = data.Rows[0][3].ToString();
            txtEmail.Text = data.Rows[0][4].ToString();
            txtDiaChi.Text = data.Rows[0][5].ToString();

            if (data.Rows[0][1].ToString() == "Nam")
            {
                cbxGioiTinh.SelectedIndex = 0;
            }
            else
            {
                cbxGioiTinh.SelectedIndex = 1;
            }

            dtpNgaySinh.Value = (DateTime)data.Rows[0][2];

            txtTenAD.ReadOnly = true;
            txtSDT.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            dtpNgaySinh.Enabled = false;
            cbxGioiTinh.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                // MessageBox.Show("hiii");
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    string tenAD = txtTenAD.Text.Trim();
                    string gioiTinh = cbxGioiTinh.SelectedIndex == 1 ? gioiTinh = "Nữ" : gioiTinh = "Nam";
                    DateTime ngaySinh = dtpNgaySinh.Value;
                    string sdt = txtSDT.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim();

                    ClassEmployee.Employee empl = new ClassEmployee.Employee() { TenNV = tenAD, GioiTinh = gioiTinh, NgaySinh = ngaySinh, SDT = sdt, Email = email, DiaChi = diaChi, MaNV = MaNV };
                    if (ClassEmployee.HandleEmployee.Instance.Edit(empl))
                    {
                        MessageBox.Show("Cập nhập thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInfoEmpl();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhập thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    isEdit = !isEdit;
                    btnEdit.Text = "Chỉnh sửa";
                }
                else
                {
                    MessageBox.Show("Thao tác thất bại, Vui lòng xem lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                isEdit = !isEdit;
                btnEdit.Text = "Cập Nhật";

                txtTenAD.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                dtpNgaySinh.Enabled = true;
                cbxGioiTinh.Enabled = true;
            }
        }

        private void txtTenAD_Validating(object sender, CancelEventArgs e)
        {
            string tenAD = txtTenAD.Text.Trim();

            if (string.IsNullOrEmpty(tenAD))
            {
                e.Cancel = true;
                errTenAD.SetError(txtTenAD, "Tên nhân viên không được để trống");
            }
            else if (tenAD.Length < 2 || tenAD.Length > 20)
            {
                e.Cancel = true;
                errTenAD.SetError(txtTenAD, "Tên nhân viên không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                errTenAD.Clear();
            }
        }

        private void txtSDT_Validating(object sender, CancelEventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            bool sdtCheck = false;

            if (sdt.Length == 10)
            {
                if (sdt[1] == '3' || sdt[1] == '5' || sdt[1] == '7' || sdt[1] == '8' || sdt[1] == '9')
                {
                    sdtCheck = true;
                }
            }

            if (string.IsNullOrEmpty(sdt))
            {
                e.Cancel = true;
                errSDT.SetError(txtSDT, "Số điện thoại không được để trống");
            }
            else if (sdt[0] != '0' || sdt.Length != 10)
            {
                e.Cancel = true;
                errSDT.SetError(txtSDT, "Số điện thoại không đúng");
            }
            else if (!sdtCheck)
            {
                e.Cancel = true;
                errSDT.SetError(txtSDT, "Số điện thoại không đúng");
            }
            else
            {
                e.Cancel = false;
                errSDT.Clear();
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text.Trim();
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (string.IsNullOrEmpty(email))
            {
                e.Cancel = true;
                errEmail.SetError(txtEmail, "Email không được để trống");
            }
            else if (!isEmail)
            {
                e.Cancel = true;
                errEmail.SetError(txtEmail, "Email không hợp lệ");
            }
            else if (email.Length > 30)
            {
                e.Cancel = true;
                errEmail.SetError(txtEmail, "Email quá dài");
            }
            else
            {
                e.Cancel = false;
                errEmail.Clear();
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain main = new frmMain(username, password, isAdmin);
            main.ShowDialog();
            this.Close();
        }

        private void dtpNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            int yearCurrent = DateTime.Now.Year;
            int yearBorn = dtpNgaySinh.Value.Year;

            if (yearBorn > yearCurrent)
            {
                e.Cancel = true;
                errNS.SetError(dtpNgaySinh, "Ngày sinh không hợp lệ");
            }
            else if (yearCurrent - yearBorn < 18)
            {
                e.Cancel = true;
                errNS.SetError(dtpNgaySinh, "Chưa đủ tuổi lao động(18)");
            }
            else
            {
                e.Cancel = false;
                errNS.Clear();
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiaChi.Text.Trim().Length > 50)
            {
                e.Cancel = true;
                errDC.SetError(txtDiaChi, "Địa chỉ không quá 50 ký tự");
            }
            else
            {
                e.Cancel = false;
                errDC.Clear();
            }
        }
    }
}
