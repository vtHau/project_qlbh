using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi
{
    public partial class frmUser : Form
    {
        private bool isSave = true;

        public frmUser()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void frmUser_Load(object sender, EventArgs e)
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
            dgvUser.DataSource = ClassUser.HandleUser.Instance.LoadDGV();
            dgvUser.Columns[0].HeaderText = "Mã khách hàng";
            dgvUser.Columns[1].HeaderText = "Tên khách hàng";
            dgvUser.Columns[2].HeaderText = "Giới tính";
            dgvUser.Columns[3].HeaderText = "Năm sinh";
            dgvUser.Columns[4].HeaderText = "Số điện thoại";
            dgvUser.Columns[5].HeaderText = "Email";
            dgvUser.Columns[6].HeaderText = "Địa chỉ";
            dgvUser.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvUser.RowHeadersVisible = false;
            dgvUser.BackgroundColor = Color.White;
        }

        private void dgvUser_Click(object sender, EventArgs e)
        {
            if (dgvUser.Rows.Count != 0)
            {
                gbxInfo.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnHuy.Enabled = true;

                txtMaKH.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
                txtTenKH.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();

                if (dgvUser.CurrentRow.Cells[2].Value.ToString() == "Nam")
                {
                    cbxGioiTinh.SelectedIndex = 0;
                }
                else
                {
                    cbxGioiTinh.SelectedIndex = 1;
                }

                dtpNgaySinh.Value = (DateTime)dgvUser.CurrentRow.Cells[3].Value;
                txtSDT.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
                txtEmail.Text = dgvUser.CurrentRow.Cells[5].Value.ToString();
                txtDiaChi.Text = dgvUser.CurrentRow.Cells[6].Value.ToString();
            }

            errMaKH.Clear();
            errTenKH.Clear();
            errSDT.Clear();
            errEmail.Clear();
            errNS.Clear();
            errDC.Clear();
        }

        private void ResetValue()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cbxGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = Convert.ToDateTime("01-01-1995");
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
        }

        //feature

        private void btnThem_Click(object sender, EventArgs e)
        {
            isSave = true;
            txtMaKH.ReadOnly = false;

            gbxInfo.Enabled = true;
            txtMaKH.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string maKH = txtMaKH.Text.Trim();
                string tenKH = txtTenKH.Text.Trim();
                string gioiTinh = cbxGioiTinh.SelectedIndex == 1 ? gioiTinh = "Nữ" : gioiTinh = "Nam";
                DateTime ngaySinh = dtpNgaySinh.Value;
                string sdt = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();

                ClassUser.User user = new ClassUser.User() { MaKH = maKH, TenKH = tenKH, GioiTinh = gioiTinh, NgaySinh = ngaySinh, SDT = sdt, Email = email, DiaChi = diaChi };

                if (isSave)
                {
                    if (ClassUser.HandleUser.Instance.Add(user))
                    {
                        frmUser_Load(sender, e);
                        ResetValue();
                        LoadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (ClassUser.HandleUser.Instance.Edit(user))
                    {
                        frmUser_Load(sender, e);
                        ResetValue();
                        LoadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Sửa khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Thao tác thất bại, Vui lòng xem lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text.ToString();
            string query = " SELECT COUNT(*) FROM HoaDon  WHERE KhachHang ='" + MaKH + "'";
            DataTable checkUSer = DataProvider.Instance.ExecuteQuery(query);

            if (int.Parse(checkUSer.Rows[0][0].ToString()) == 0)
            {
                if (MaKH != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa khách hàng này không ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (ClassUser.HandleUser.Instance.Delete(MaKH))
                        {
                            frmUser_Load(sender, e);
                            ResetValue();
                            LoadDGV();
                        }
                        else
                        {
                            MessageBox.Show("Xóa khách hàng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                frmUser_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không thể xóa khách hàng này vì đã có liên kết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isSave = false;
            gbxInfo.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;

            txtMaKH.ReadOnly = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;

            DialogResult isCancel = MessageBox.Show("Bạn có muốn hủy thao tác đang làm ?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isCancel == DialogResult.Yes)
            {
                isSave = true;
                frmUser_Load(sender, e);
                ResetValue();
                errMaKH.Clear();
                errTenKH.Clear();
                errSDT.Clear();
                errEmail.Clear();
                errNS.Clear();
                errDC.Clear();
            }
            else
            {
                return;
            }
        }

        //validate form

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaKH_Validating(object sender, CancelEventArgs e)
        {
            if (isSave)
            {
                string MaKH = txtMaKH.Text.Trim();
                string query = " SELECT COUNT(*) FROM HoaDon  WHERE KhachHang ='" + MaKH + "'";
                DataTable checkUSer = DataProvider.Instance.ExecuteQuery(query);

                if (int.Parse(checkUSer.Rows[0][0].ToString()) != 0)
                {
                    e.Cancel = true;
                    errMaKH.SetError(txtMaKH, "Mã khách hàng đã tồn tại");
                }
                else if (string.IsNullOrEmpty(MaKH))
                {
                    e.Cancel = true;
                    errMaKH.SetError(txtMaKH, "Mã khách hàng không được để trống");
                }
                else if (MaKH.Length < 5 || MaKH.Length > 10)
                {
                    e.Cancel = true;
                    errMaKH.SetError(txtMaKH, "Mã khách hàng phải có 5 ký tự trở lên và dưới 10 ký tự");
                }
                else
                {
                    e.Cancel = false;
                    errMaKH.Clear();
                }
            }
        }

        private void txtTenKH_Validating(object sender, CancelEventArgs e)
        {
            string TenKH = txtTenKH.Text.Trim();

            if (string.IsNullOrEmpty(TenKH))
            {
                e.Cancel = true;
                errTenKH.SetError(txtTenKH, "Tên khách hàng không được để trống");
            }
            else if (TenKH.Length < 2 || TenKH.Length > 20)
            {
                e.Cancel = true;
                errTenKH.SetError(txtTenKH, "Tên khách hàng không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                errTenKH.Clear();
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
                    dgvUser.DataSource = ClassUser.HandleUser.Instance.LoadDGVSX("MaKH", "ASC");
                    break;

                case "1":
                    dgvUser.DataSource = ClassUser.HandleUser.Instance.LoadDGVSX("MaKH", "DESC");
                    break;

                case "2":
                    dgvUser.DataSource = ClassUser.HandleUser.Instance.LoadDGVSX("TenKH", "ASC");
                    break;

                case "3":
                    dgvUser.DataSource = ClassUser.HandleUser.Instance.LoadDGVSX("TenKH", "DESC");
                    break;

                case "4":
                    dgvUser.DataSource = ClassUser.HandleUser.Instance.LoadDGVSX("GioiTinh", "ASC");
                    break;

                case "5":
                    dgvUser.DataSource = ClassUser.HandleUser.Instance.LoadDGVSX("GioiTinh", "DESC");
                    break;

                case "6":
                    dgvUser.DataSource = ClassUser.HandleUser.Instance.LoadDGVSX("NgaySinh", "ASC");
                    break;

                case "7":
                    dgvUser.DataSource = ClassUser.HandleUser.Instance.LoadDGVSX("NgaySinh", "DESC");
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
            else if (yearCurrent - yearBorn < 5)
            {
                e.Cancel = true;
                errNS.SetError(dtpNgaySinh, "Quá nhỏ để mua hàng");
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

