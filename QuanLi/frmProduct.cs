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
    public partial class frmProduct : Form
    {
        private bool isSave = true;


        public frmProduct()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadDGV();

            gbxInfo.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = false;

            dtpNgaySinh.Value = Convert.ToDateTime("01-01-1995");
        }

        private void LoadDGV()
        {
            dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGV();
            dgvProduct.Columns[0].HeaderText = "Mã sản phẩm";
            dgvProduct.Columns[1].HeaderText = "Tên sản phẩm";
            dgvProduct.Columns[2].HeaderText = "Giá";
            dgvProduct.Columns[3].HeaderText = "Danh mục";
            dgvProduct.Columns[4].HeaderText = "Số lượng";
            dgvProduct.Columns[5].HeaderText = "Ngày nhập";
            dgvProduct.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.BackgroundColor = Color.White;
        }

        private void ResetValue()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGia.Text = "";
            dtpNgaySinh.Value = Convert.ToDateTime("01-01-1995");
            cbxDM.Text = "";
        }

        //feature

        private void dgvProduct_Click(object sender, EventArgs e)
        {
            if (dgvProduct.Rows.Count != 0)
            {
                gbxInfo.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnHuy.Enabled = true;

                txtMaSP.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                txtGia.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
                txtSoLuong.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
                dtpNgaySinh.Value = (DateTime)dgvProduct.CurrentRow.Cells[5].Value;

                switch (dgvProduct.CurrentRow.Cells[3].Value.ToString())
                {
                    case "Điện Thoại":
                        cbxDM.SelectedIndex = 0;
                        break;

                    case "Phụ Kiện Điện Thoại":
                        cbxDM.SelectedIndex = 1;
                        break;

                    case "Laptop":
                        cbxDM.SelectedIndex = 2;
                        break;

                    case "Phụ Kiện Laptop":
                        cbxDM.SelectedIndex = 3;
                        break;
                }
            }

            errMaSP.Clear();
            errTenSP.Clear();
            errGia.Clear();
            errNS.Clear();
            errDM.Clear();
            errSoLuong.Clear();
            errDM.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;

            DialogResult isCancel = MessageBox.Show("Bạn có muốn hủy thao tác đang làm ?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isCancel == DialogResult.Yes)
            {
                isSave = true;
                frmProduct_Load(sender, e);
                ResetValue();
                errMaSP.Clear();
                errTenSP.Clear();
                errGia.Clear();
                errNS.Clear();
                errDM.Clear();
                errSoLuong.Clear();
                errDM.Clear();
                txtMaSP.ReadOnly = false;
            }
            else
            {
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaSP = txtMaSP.Text.ToString();
            string query = " SELECT COUNT(*) FROM CTHoaDon  WHERE MaSP ='" + MaSP + "'";

            DataTable checkProduct = DataProvider.Instance.ExecuteQuery(query);

            if (int.Parse(checkProduct.Rows[0][0].ToString()) == 0)
            {
                if (MaSP != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa sản phẩm này không ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (ClassProduct.HanldeProduct.Instance.Delete(MaSP))
                        {
                            ResetValue();
                            LoadDGV();
                            frmProduct_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Xóa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmProduct_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không thể xóa sản phẩm này vì đã có liên kết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            gbxInfo.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            txtMaSP.ReadOnly = true;

            isSave = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gbxInfo.Enabled = true;
            txtMaSP.ReadOnly = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;
            isSave = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string maSP = txtMaSP.Text.Trim();
                string tenSP = txtTenSP.Text.Trim();
                int gia = int.Parse(txtGia.Text.Trim());
                DateTime ngayNhap = dtpNgaySinh.Value;
                int soLuong = int.Parse(txtSoLuong.Text.Trim());
                string danhMuc = "";

                switch (cbxDM.SelectedIndex)
                {
                    case 0:
                        danhMuc = "Điện Thoại";
                        break;

                    case 1:
                        danhMuc = "Phụ Kiện Điện Thoại";
                        break;

                    case 2:
                        danhMuc = "Laptop";
                        break;

                    case 3:
                        danhMuc = "Phụ Kiện Laptop";
                        break;
                }

                ClassProduct.Product product = new ClassProduct.Product() { MaSP = maSP, TenSP = tenSP, Gia = gia, DanhMuc = danhMuc, SoLuong = soLuong, NgayNhap = ngayNhap };

                if (isSave)
                {
                    if (ClassProduct.HanldeProduct.Instance.Add(product))
                    {
                        ResetValue();
                        LoadDGV();
                        frmProduct_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (ClassProduct.HanldeProduct.Instance.Edit(product))
                    {
                        ResetValue();
                        LoadDGV();
                        frmProduct_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Thao tác thất bại, Vui lòng xem lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //validate

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaSP_Validating(object sender, CancelEventArgs e)
        {
            if (isSave)
            {
                string MaSP = txtMaSP.Text.Trim();
                string query = " SELECT COUNT(*) FROM SanPham  WHERE MaSP ='" + MaSP + "'";

                DataTable checkProduct = DataProvider.Instance.ExecuteQuery(query);

                if (int.Parse(checkProduct.Rows[0][0].ToString()) != 0)
                {
                    e.Cancel = true;
                    errMaSP.SetError(txtMaSP, "Mã sản phẩm đã tồn tại");
                }
                else if (string.IsNullOrEmpty(MaSP))
                {
                    e.Cancel = true;
                    errMaSP.SetError(txtMaSP, "Mã sản phẩm không được để trống");
                }
                else if (MaSP.Length < 5 || MaSP.Length > 10)
                {
                    e.Cancel = true;
                    errMaSP.SetError(txtMaSP, "Mã sản phẩm phải có 5 ký tự trở lên và dưới 10 ký tự");
                }
                else
                {
                    e.Cancel = false;
                    errMaSP.Clear();
                }
            }
        }

        private void txtTenSP_Validating(object sender, CancelEventArgs e)
        {
            string TenSP = txtTenSP.Text.Trim();

            if (string.IsNullOrEmpty(TenSP))
            {
                e.Cancel = true;
                errTenSP.SetError(txtTenSP, "Tên sản phẩm không được để trống");
            }
            else if (TenSP.Length < 2)
            {
                e.Cancel = true;
                errTenSP.SetError(txtTenSP, "Tên sản phẩm quá ngắn");
            }
            else if (TenSP.Length > 30)
            {
                e.Cancel = true;
                errTenSP.SetError(txtTenSP, "Tên sản phẩm dài");
            }
            else
            {
                e.Cancel = false;
                errTenSP.Clear();
            }
        }

        private void txtGia_Validating(object sender, CancelEventArgs e)
        {
            string Gia = txtGia.Text.Trim();

            if (string.IsNullOrEmpty(Gia))
            {
                e.Cancel = true;
                errGia.SetError(txtGia, "Giá sản phẩm không được để trống");
            }
            else if (Gia.Length > 9)
            {
                e.Cancel = true;
                errGia.SetError(txtGia, "Giá sản phẩm không hợp lệ");
            }
            else if (Int32.Parse(Gia) == 0 || Int32.Parse(Gia) < 1000)
            {
                e.Cancel = true;
                errGia.SetError(txtGia, "Giá sản phẩm không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                errGia.Clear();
            }
        }

        private void cbxSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choose = cbxSapXep.SelectedIndex.ToString();
            switch (choose)
            {
                case "0":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("ORDER BY", "MaSP", "ASC");
                    break;

                case "1":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("ORDER BY", "MaSP", "DESC");
                    break;

                case "2":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("ORDER BY", "TenSP", "ASC");
                    break;

                case "3":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("ORDER BY", "TenSP", "DESC");
                    break;

                case "4":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("ORDER BY", "Gia", "ASC");
                    break;

                case "5":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("ORDER BY", "Gia", "DESC");
                    break;

                case "6":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("ORDER BY", "NgayNhap", "DESC");
                    break;

                case "7":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("ORDER BY", "NgayNhap", "ASC");
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
                errNS.SetError(dtpNgaySinh, "Ngày nhập không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                errNS.Clear();
            }
        }

        private void txtSoLuong_Validating(object sender, CancelEventArgs e)
        {
            string soLuong = txtSoLuong.Text.Trim();

            if (string.IsNullOrEmpty(soLuong))
            {
                e.Cancel = true;
                errSoLuong.SetError(txtSoLuong, "Số lượng sản phẩm không được để trống");
            }
            else if (soLuong.Length > 9)
            {
                e.Cancel = true;
                errSoLuong.SetError(txtSoLuong, "Số lượng sản phẩm không hợp lệ");
            }
            else if (Int32.Parse(soLuong) == 0)
            {
                e.Cancel = true;
                errSoLuong.SetError(txtSoLuong, "Không thể để số lượng là 0, vui lòng nhập lại số khác");
            }

            else
            {
                e.Cancel = false;
                errSoLuong.Clear();
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbxDM_Validating(object sender, CancelEventArgs e)
        {
            if (cbxDM.Text == "")
            {
                e.Cancel = true;
                errDM.SetError(cbxDM, "Vui lòng chọn danh mục");
            }
            else
            {
                e.Cancel = false;
                errDM.Clear();
            }
        }

        private void cbxSortDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choose = cbxSortDM.SelectedIndex.ToString();

            switch (choose)
            {
                case "1":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("WHERE", "DanhMuc = ", "N'Điện Thoại'");
                    break;

                case "2":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("WHERE", "DanhMuc = ", "N'Phụ Kiện Điện Thoại'");
                    break;

                case "3":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("WHERE", "DanhMuc = ", "N'Laptop'");
                    break;

                case "4":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("WHERE", "DanhMuc = ", "N'Phụ Kiện Laptop'");
                    break;
                case "0":
                    dgvProduct.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGVSX("", "", "");
                    break;
            }
        }
    }
}

