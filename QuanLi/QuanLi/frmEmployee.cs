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
    public partial class frmEmployee : Form
    {
        private bool isSave = true;

        public frmEmployee()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadDGV();

            gbxInfo.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void LoadDGV()
        {
            dgvEmployee.DataSource = ClassEmployee.HandleEmployee.Instance.LoadDGV();
            dgvEmployee.Columns[0].HeaderText = "Mã nhân viên";
            dgvEmployee.Columns[1].HeaderText = "Tên nhân viên";
            dgvEmployee.Columns[2].HeaderText = "Giới tính";
            dgvEmployee.Columns[3].HeaderText = "Năm sinh";
            dgvEmployee.Columns[4].HeaderText = "Số điện thoại";
            dgvEmployee.Columns[5].HeaderText = "Email";
            dgvEmployee.Columns[6].HeaderText = "Địa chỉ";
            dgvEmployee.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvEmployee.RowHeadersVisible = false;
            dgvEmployee.BackgroundColor = Color.White;
        }

        private void ResetValue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cbxGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = Convert.ToDateTime("01-01-1995");
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        //feature

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.Rows.Count != 0)
            {
                gbxInfo.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnHuy.Enabled = true;

                txtMaNV.Text = dgvEmployee.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text = dgvEmployee.CurrentRow.Cells[1].Value.ToString();
                if (dgvEmployee.CurrentRow.Cells[2].Value.ToString() == "Nam")
                {
                    cbxGioiTinh.SelectedIndex = 0;
                }
                else
                {
                    cbxGioiTinh.SelectedIndex = 1;
                }
                dtpNgaySinh.Value = (DateTime)dgvEmployee.CurrentRow.Cells[3].Value;
                txtSDT.Text = dgvEmployee.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvEmployee.CurrentRow.Cells[5].Value.ToString();
                txtDiaChi.Text = dgvEmployee.CurrentRow.Cells[6].Value.ToString();
            }

            errMaNV.Clear();
            errTenNV.Clear();
            errSDT.Clear();
            errNS.Clear();
            errEmail.Clear();
            errDC.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string maNV = txtMaNV.Text.Trim();
                string tenNV = txtTenNV.Text.Trim();
                string gioiTinh = cbxGioiTinh.SelectedIndex == 1 ? gioiTinh = "Nữ" : gioiTinh = "Nam";
                DateTime ngaySinh = dtpNgaySinh.Value;
                string sdt = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();

                ClassEmployee.Employee employee = new ClassEmployee.Employee() { MaNV = maNV, TenNV = tenNV, GioiTinh = gioiTinh, NgaySinh = ngaySinh, SDT = sdt, Email = email, DiaChi = diaChi };

                if (isSave)
                {
                    if (ClassEmployee.HandleEmployee.Instance.Add(employee))
                    {
                        ResetValue();
                        frmEmployee_Load(sender, e);
                        LoadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (ClassEmployee.HandleEmployee.Instance.Edit(employee))
                    {
                        ResetValue();
                        frmEmployee_Load(sender, e);
                        LoadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Thao tác thất bại, Vui lòng xem lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gbxInfo.Enabled = true;
            txtMaNV.ReadOnly = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;

            isSave = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            gbxInfo.Enabled = true;
            txtMaNV.ReadOnly = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;

            isSave = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text.ToString();
            string query = " SELECT COUNT(*) FROM HoaDon  WHERE NguoiLap ='" + MaNV + "'";

            DataTable checkEmployee = DataProvider.Instance.ExecuteQuery(query);

            if (int.Parse(checkEmployee.Rows[0][0].ToString()) == 0)
            {
                if (MaNV != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa nhân viên này không ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (ClassEmployee.HandleEmployee.Instance.Delete(MaNV))
                        {
                            ResetValue();
                            frmEmployee_Load(sender, e);
                            LoadDGV();
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã liên kết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;

            DialogResult isCancel = MessageBox.Show("Bạn có muốn hủy thao tác đang làm ?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isCancel == DialogResult.Yes)
            {
                isSave = true;
                txtMaNV.ReadOnly = false;
                frmEmployee_Load(sender, e);
                ResetValue();
                errMaNV.Clear();
                errTenNV.Clear();
                errSDT.Clear();
                errNS.Clear();
                errDC.Clear();
            }
            else
            {
                return;
            }
        }

        //validate

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaNV_Validating(object sender, CancelEventArgs e)
        {
            if (isSave)
            {
                string MaNV = txtMaNV.Text.Trim();

                string query = " SELECT COUNT(*) FROM NhanVien  WHERE MaNV ='" + MaNV + "'";
                DataTable checkEmployee = DataProvider.Instance.ExecuteQuery(query);
                if (int.Parse(checkEmployee.Rows[0][0].ToString()) != 0)
                {
                    e.Cancel = true;
                    errMaNV.SetError(txtMaNV, "Mã nhân viên đã tồn tại");
                }
                else if (string.IsNullOrEmpty(MaNV))
                {
                    e.Cancel = true;
                    errMaNV.SetError(txtMaNV, "Mã nhân viên không được để trống");
                }
                else if (MaNV.Length < 5 || MaNV.Length > 10)
                {
                    e.Cancel = true;
                    errMaNV.SetError(txtMaNV, "Mã nhân viên phải có 5 ký tự trở lên và dưới 10 ký tự");
                }
                else
                {
                    e.Cancel = false;
                    errMaNV.Clear();
                }
            }
        }

        private void txtTenNV_Validating(object sender, CancelEventArgs e)
        {
            string TenNV = txtTenNV.Text.Trim();

            if (string.IsNullOrEmpty(TenNV))
            {
                e.Cancel = true;
                errTenNV.SetError(txtTenNV, "Tên nhân viên không được để trống");
            }
            else if (TenNV.Length < 2 || TenNV.Length > 20)
            {
                e.Cancel = true;
                errTenNV.SetError(txtTenNV, "Tên nhân viên không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                errTenNV.Clear();
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

        private void cbxSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choose = cbxSapXep.SelectedIndex.ToString();
            switch (choose)
            {
                case "0":
                    dgvEmployee.DataSource = ClassEmployee.HandleEmployee.Instance.LoadDGVSX("MaNV", "ASC");
                    break;

                case "1":
                    dgvEmployee.DataSource = ClassEmployee.HandleEmployee.Instance.LoadDGVSX("MaNV", "DESC");
                    break;

                case "2":
                    dgvEmployee.DataSource = ClassEmployee.HandleEmployee.Instance.LoadDGVSX("TenNV", "ASC");
                    break;

                case "3":
                    dgvEmployee.DataSource = ClassEmployee.HandleEmployee.Instance.LoadDGVSX("TenNV", "DESC");
                    break;

                case "4":
                    dgvEmployee.DataSource = ClassEmployee.HandleEmployee.Instance.LoadDGVSX("GioiTinh", "ASC");
                    break;

                case "5":
                    dgvEmployee.DataSource = ClassEmployee.HandleEmployee.Instance.LoadDGVSX("GioiTinh", "DESC");
                    break;

                case "6":
                    dgvEmployee.DataSource = ClassEmployee.HandleEmployee.Instance.LoadDGVSX("NgaySinh", "ASC");
                    break;

                case "7":
                    dgvEmployee.DataSource = ClassEmployee.HandleEmployee.Instance.LoadDGVSX("NgaySinh", "DESC");
                    break;


            }
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
                errNS.SetError(dtpNgaySinh, "Dưới độ tuổi lao động(18)");
            }
            else
            {
                e.Cancel = false;
                errNS.Clear();
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
