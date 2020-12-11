using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace QuanLi
{
    public partial class frmBill : Form
    {
        private bool isSave = true;
        private bool isSave2 = true;
        private int sl = 0;

        public frmBill()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            LoadCBX();
            LoadDGV();
            gbxInfo.Enabled = false;
            gbxDetailBill.Enabled = false;
            gbxList.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = false;

            btnLuu2.Enabled = false;
            btnThem2.Enabled = false;
            btnXoa2.Enabled = false;
            btnHuyBo2.Enabled = false;
        }

        private void LoadCBX()
        {
            cbxKH.DataSource = ClassUser.HandleUser.Instance.LoadDGV();
            cbxKH.DisplayMember = "TenKH";
            cbxKH.ValueMember = "MaKH";

            if (cbxKH.Items.Count != 0)
            {
                cbxKH.SelectedIndex = 0;
            }

            cbxNV.DataSource = ClassEmployee.HandleEmployee.Instance.LoadDGV();
            cbxNV.DisplayMember = "TenNV";
            cbxNV.ValueMember = "MaNV";

            if (cbxNV.Items.Count != 0)
            {
                cbxNV.SelectedIndex = 0;
            }
        }

        private void ResetValue()
        {
            txtMaHD.Text = "";
            dtpNgayLap.Text = DateTime.Now.Date.ToShortDateString();
            LoadCBX();
            cbxKH.Text = "";
            cbxNV.Text = "";
        }

        private void LoadDGV()
        {
            dgvBill.DataSource = ClassBill.HandleBill.Instance.LoadDGV();

            dgvBill.Columns[0].HeaderText = "Mã hoá đơn";
            dgvBill.Columns[1].HeaderText = "Ngày Lập";
            dgvBill.Columns[2].HeaderText = "Người Lập";
            dgvBill.Columns[3].HeaderText = "Khách Hàng";
            dgvBill.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvBill.RowHeadersVisible = false;
            dgvBill.BackgroundColor = Color.White;
        }

        private void LoadDGVTHD(string MaHD)
        {
            dgvCTHD.DataSource = ClassDetailBill.HandleDetailBill.Instance.LoadDGV(MaHD);

            dgvCTHD.Columns[0].HeaderText = "Mã sản phẩm";
            dgvCTHD.Columns[1].HeaderText = "Tên sản phẩm";
            dgvCTHD.Columns[2].HeaderText = "Số lượng";
            dgvCTHD.Columns[3].HeaderText = "Giá";
            dgvCTHD.Columns[4].HeaderText = "Tổng tiền";
            dgvCTHD.Columns[2].Width = 80;
            dgvCTHD.Columns[4].Width = 80;
            dgvCTHD.RowHeadersVisible = false;
            dgvCTHD.BackgroundColor = Color.White;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;
            DialogResult isCancel = MessageBox.Show("Bạn có muốn hủy thao tác đang làm ?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isCancel == DialogResult.Yes)
            {
                isSave = true;
                frmBill_Load(sender, e);
                ResetValue();
                errMaHD.Clear();
                errNL.Clear();
                txtMaHD.ReadOnly = false;
            }
            else
            {
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string maHD = txtMaHD.Text.Trim();
                DateTime ngayLap = dtpNgayLap.Value;
                string maKH = cbxKH.SelectedValue.ToString();
                string maNV = cbxNV.SelectedValue.ToString();

                ClassBill.Bill bill = new ClassBill.Bill() { MaHD = maHD, NgayLap = ngayLap, MaKH = maKH, MaNV = maNV };

                if (isSave)
                {
                    if (ClassBill.HandleBill.Instance.Add(bill))
                    {
                        ResetValue();
                        frmBill_Load(sender, e);
                        LoadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (ClassBill.HandleBill.Instance.Edit(bill))
                    {
                        ResetValue();
                        frmBill_Load(sender, e);
                        LoadDGV();
                    }
                    else
                    {
                        MessageBox.Show("Sửa hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtMaHD.ReadOnly = false;
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
            txtMaHD.ReadOnly = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnHuy.Enabled = true;

            isSave = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaHD = txtMaHD.Text.ToString();
            string query = " SELECT COUNT(*) FROM CTHoaDon  WHERE MaHD ='" + MaHD + "'";

            DataTable checkBill = DataProvider.Instance.ExecuteQuery(query);

            if (int.Parse(checkBill.Rows[0][0].ToString()) == 0)
            {
                if (MaHD != "")
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa hóa đơn này không ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (ClassBill.HandleBill.Instance.Delete(MaHD))
                        {
                            ResetValue();
                            frmBill_Load(sender, e);
                            LoadDGV();
                        }
                        else
                        {
                            MessageBox.Show("Xóa hóa đơn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa hóa đơn này vì đã có liên kế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBill_Click(object sender, EventArgs e)
        {
            if (dgvBill.Rows.Count != 0)
            {
                gbxInfo.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnHuy.Enabled = true;

                txtMaHD.Text = dgvBill.CurrentRow.Cells[0].Value.ToString();
                dtpNgayLap.Value = (DateTime)dgvBill.CurrentRow.Cells[1].Value;

                cbxKH.DataBindings.Clear();
                cbxKH.DataBindings.Add("Text", dgvBill.DataSource, "TenKH");
                cbxNV.DataBindings.Clear();
                cbxNV.DataBindings.Add("Text", dgvBill.DataSource, "TenNV");

                LoadDetailBill(sender, e);
                showMoney();
            }
            errMaHD.Clear();
            errNL.Clear();
            errProduct.Clear();
            errSoLuong.Clear();
        }

        private void txtMaHD_Validating(object sender, CancelEventArgs e)
        {
            if (isSave)
            {
                string MaHD = txtMaHD.Text.Trim();
                string query = " SELECT COUNT(*) FROM HoaDon  WHERE MaHD ='" + MaHD + "'";

                DataTable checkBill = DataProvider.Instance.ExecuteQuery(query);

                if (int.Parse(checkBill.Rows[0][0].ToString()) != 0)
                {
                    e.Cancel = true;
                    errMaHD.SetError(txtMaHD, "Mã hóa đơn đã tồn tại");
                }
                else if (string.IsNullOrEmpty(MaHD))
                {
                    e.Cancel = true;
                    errMaHD.SetError(txtMaHD, "Mã hóa đơn không được để trống");
                }
                else if (MaHD.Length < 5 || MaHD.Length > 10)
                {
                    e.Cancel = true;
                    errMaHD.SetError(txtMaHD, "Mã hóa đơn phải có 5 ký tự trở lên và dưới 10 ký tự");
                }
                else
                {
                    e.Cancel = false;
                    errMaHD.Clear();
                }
            }
            else
            {
                errMaHD.Clear();
            }
        }

        //chi tiet hoa don

        private void LoadDetailBill(object sender, EventArgs e)
        {
            gbxDetailBill.Enabled = false;
            gbxList.Enabled = true;
            txtMaHD2.ReadOnly = true;
            btnLuu2.Enabled = false;
            btnThem2.Enabled = true;
            btnXoa2.Enabled = false;
            btnHuyBo2.Enabled = false;
            btnSua2.Enabled = false;

            isSave2 = true;


            LoadDGVTHD(dgvBill.CurrentRow.Cells[0].Value.ToString().Trim());
            LoadCbxSP();
            showMoney();
        }

        private void LoadCbxSP()
        {
            cbxSP.DataSource = ClassProduct.HanldeProduct.Instance.LoadDGV();
            cbxSP.DisplayMember = "TenSP";
            cbxSP.ValueMember = "MaSP";

            if (cbxSP.Items.Count != 0)
            {
                cbxSP.SelectedIndex = 0;
            }
            txtGia.ReadOnly = true;
        }

        private void cbxSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = int.Parse(cbxSP.SelectedIndex.ToString());
            DataTable tb = ClassProduct.HanldeProduct.Instance.LoadDGV();
            txtGia.Text = tb.Rows[index][2].ToString();
            txtMaHD2.Text = tb.Rows[index][4].ToString();
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {
            isSave = false;
            errMaHD.Clear();
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string maHD = dgvBill.CurrentRow.Cells[0].Value.ToString().Trim();
                string maSP = cbxSP.SelectedValue.ToString();
                int soLuong = int.Parse(txtSoLuong.Text.Trim());

                ClassDetailBill.DetailBill detailBill = new ClassDetailBill.DetailBill() { MaHD = maHD, MaSP = maSP, SoLuong = soLuong };
                string query = "  UPDATE SanPham SET SoLuong = SoLuong - " + soLuong + " WHERE MaSP = '" + maSP + "'";

                if (isSave2)
                {
                    if (ClassDetailBill.HandleDetailBill.Instance.Add(detailBill) && DataProvider.Instance.ExecuteNonQuery(query) != 0)
                    {
                        LoadDetailBill(sender, e);
                        txtSoLuong.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (soLuong > sl)
                    {
                        query = "  UPDATE SanPham SET SoLuong = SoLuong - " + (soLuong - sl) + " WHERE MaSP = '" + maSP + "'";
                    }
                    else if (soLuong < sl)
                    {
                        query = "  UPDATE SanPham SET SoLuong = SoLuong + " + (sl - soLuong) + " WHERE MaSP = '" + maSP + "'";
                    }
                    else if (sl == soLuong)
                    {
                        soLuong = 0;
                    }

                    if (ClassDetailBill.HandleDetailBill.Instance.Edit(detailBill) && DataProvider.Instance.ExecuteNonQuery(query) != 0)
                    {
                        LoadDetailBill(sender, e);
                        txtSoLuong.Text = "";
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

        private void btnXoa2_Click(object sender, EventArgs e)
        {
            string MaHD = dgvBill.CurrentRow.Cells[0].Value.ToString().Trim();
            string MaSP = dgvCTHD.CurrentRow.Cells[0].Value.ToString().Trim();
            string soLuong = dgvCTHD.CurrentRow.Cells[2].Value.ToString().Trim();

            if (MaHD != "" && MaSP != "")
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa sản phẩm này không ?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string query = "  UPDATE SanPham SET SoLuong = SoLuong + " + soLuong + " WHERE MaSP = '" + MaSP + "'";

                    if (ClassDetailBill.HandleDetailBill.Instance.Delete(MaHD, MaSP) && DataProvider.Instance.ExecuteNonQuery(query) != 0)
                    {
                        LoadDetailBill(sender, e);
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
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_Validating(object sender, CancelEventArgs e)
        {
            int soLuong = int.Parse(txtSoLuong.Text.ToString());
            int soLuongConLai = int.Parse(txtMaHD2.Text.ToString());

            if (txtSoLuong.Text.Trim().Length > 9)
            {
                e.Cancel = true;
                errSoLuong.SetError(txtSoLuong, "Số lượng phẩm không hợp lệ");
            }
            else if ((soLuong > sl) && (soLuong - sl > soLuongConLai))
            {
                e.Cancel = true;
                errSoLuong.SetError(txtSoLuong, "Số lượng sản phẩm trong kho không đủ, vui lòng nhập lại số lượng");
            }
            else if (soLuong > soLuongConLai && isSave2)
            {
                e.Cancel = true;
                errSoLuong.SetError(txtSoLuong, "Số lượng sản phẩm trong kho không đủ, vui lòng nhập lại số lượng");
            }
            else if (string.IsNullOrEmpty(txtSoLuong.Text))
            {
                e.Cancel = true;
                errSoLuong.SetError(txtSoLuong, "Số lượng sản phẩm không được để trống");
            }
            else if (soLuong == 0)
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

        private void dgvCTHD_Click(object sender, EventArgs e)
        {
            if (dgvCTHD.Rows.Count != 0)
            {
                gbxDetailBill.Enabled = false;
                btnLuu2.Enabled = false;
                btnThem2.Enabled = false;
                btnXoa2.Enabled = true;
                btnHuyBo2.Enabled = true;
                btnSua2.Enabled = true;


                cbxSP.SelectedValue = dgvCTHD.CurrentRow.Cells[0].Value.ToString().Trim();
                txtGia.Text = dgvCTHD.CurrentRow.Cells[3].Value.ToString().Trim();
                txtSoLuong.Text = dgvCTHD.CurrentRow.Cells[2].Value.ToString().Trim();
                sl = int.Parse(dgvCTHD.CurrentRow.Cells[2].Value.ToString());
            }

            isSave = false;
            errMaHD.Clear();
            errSoLuong.Clear();
            errProduct.Clear();
        }

        private void btnHuyBo2_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;

            DialogResult isCancel = MessageBox.Show("Bạn có muốn hủy thao tác đang làm ?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isCancel == DialogResult.Yes)
            {
                LoadDetailBill(sender, e);
                errSoLuong.Clear();
                errProduct.Clear();
                txtSoLuong.Text = "";
            }
            else
            {
                return;
            }
        }

        private void btnSua2_Click(object sender, EventArgs e)
        {
            gbxDetailBill.Enabled = true;
            btnLuu2.Enabled = true;
            btnThem2.Enabled = false;
            btnXoa2.Enabled = true;
            btnHuyBo2.Enabled = true;
            btnSua2.Enabled = false;
            cbxSP.Enabled = false;
            isSave = false;
            isSave2 = false;
        }

        private void btnThem2_Click(object sender, EventArgs e)
        {
            gbxDetailBill.Enabled = true;
            btnLuu2.Enabled = true;
            btnThem2.Enabled = false;
            btnXoa2.Enabled = false;
            btnHuyBo2.Enabled = true;
            btnSua2.Enabled = false;
            cbxSP.Enabled = true;

            isSave = false;
            isSave2 = true;
            errMaHD.Clear();
        }

        private void showMoney()
        {
            txtTotalMoney.Text = getMoney().ToString() + " VNĐ";
        }

        private int getMoney()
        {
            int totalMoney = 0;
            int count = dgvCTHD.Rows.Count;

            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    totalMoney += (int)dgvCTHD.Rows[i].Cells[4].Value;
                }
            }
            return totalMoney;
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            int count = dgvCTHD.Rows.Count;

            if (count != 0)
            {
                string person = dgvBill.CurrentRow.Cells[2].Value.ToString(); //nguoi lap
                string user = dgvBill.CurrentRow.Cells[3].Value.ToString();
                string MaHD = dgvBill.CurrentRow.Cells[0].Value.ToString();
                int money = getMoney();

                string query = " SELECT TenKH , SDT , DiaChi  FROM HoaDon , KhachHang WHERE KhachHang.MaKH = HoaDon.KhachHang AND MaHD = '" + MaHD + "'";
                DataTable DTKH = DataProvider.Instance.ExecuteQuery(query);

                frmExportFIle export = new frmExportFIle(MaHD, person, user, count, money, dgvCTHD, DTKH);
                export.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để in hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            CausesValidation = false;
            this.Close();
        }

        private void cbxSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choose = cbxSapXep.SelectedIndex.ToString();

            switch (choose)
            {
                case "0":
                    dgvBill.DataSource = ClassBill.HandleBill.Instance.LoadDGVSX("MaHD", "ASC");
                    break;

                case "1":
                    dgvBill.DataSource = ClassBill.HandleBill.Instance.LoadDGVSX("MaHD", "DESC");
                    break;

                case "2":
                    dgvBill.DataSource = ClassBill.HandleBill.Instance.LoadDGVSX("NgayLap", "ASC");
                    break;

                case "3":
                    dgvBill.DataSource = ClassBill.HandleBill.Instance.LoadDGVSX("NgayLap", "DESC");
                    break;

                case "4":
                    dgvBill.DataSource = ClassBill.HandleBill.Instance.LoadDGVSX("NV.TenNV", "ASC");
                    break;

                case "5":
                    dgvBill.DataSource = ClassBill.HandleBill.Instance.LoadDGVSX("NV.TenNV", "DESC");
                    break;

                case "6":
                    dgvBill.DataSource = ClassBill.HandleBill.Instance.LoadDGVSX("KH.TenKH", "ASC");
                    break;

                case "7":
                    dgvBill.DataSource = ClassBill.HandleBill.Instance.LoadDGVSX("KH.TenKH", "DESC");
                    break;
            }
        }

        private void cbxSapXep2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choose = cbxSapXep2.SelectedIndex.ToString();
            string MaHD = dgvBill.CurrentRow.Cells[0].Value.ToString().Trim();

            switch (choose)
            {
                case "0":
                    dgvCTHD.DataSource = ClassDetailBill.HandleDetailBill.Instance.LoadDGVSX(MaHD, "SP.MaSP", "ASC");
                    break;

                case "1":
                    dgvCTHD.DataSource = ClassDetailBill.HandleDetailBill.Instance.LoadDGVSX(MaHD, "SP.MaSP", "DESC");
                    break;

                case "2":
                    dgvCTHD.DataSource = ClassDetailBill.HandleDetailBill.Instance.LoadDGVSX(MaHD, "SP.TenSP", "ASC");
                    break;

                case "3":
                    dgvCTHD.DataSource = ClassDetailBill.HandleDetailBill.Instance.LoadDGVSX(MaHD, "SP.TenSP", "DESC");
                    break;

                case "4":
                    dgvCTHD.DataSource = ClassDetailBill.HandleDetailBill.Instance.LoadDGVSX(MaHD, "CT.SoLuong", "ASC");
                    break;

                case "5":
                    dgvCTHD.DataSource = ClassDetailBill.HandleDetailBill.Instance.LoadDGVSX(MaHD, "CT.SoLuong", "DESC");
                    break;

                case "6":
                    dgvCTHD.DataSource = ClassDetailBill.HandleDetailBill.Instance.LoadDGVSX(MaHD, "SP.Gia", "ASC");
                    break;

                case "7":
                    dgvCTHD.DataSource = ClassDetailBill.HandleDetailBill.Instance.LoadDGVSX(MaHD, "SP.Gia", "DESC");
                    break;
            }
        }

        private void cbxSP_Validating(object sender, CancelEventArgs e)
        {
            string maSP = cbxSP.SelectedValue.ToString();
            string maHD = txtMaHD.Text.Trim();

            string query = " SELECT COUNT(*) FROM CTHoaDon  WHERE MaSP ='" + maSP + "' AND MaHD ='" + maHD + "'";

            DataTable checkCTHD = DataProvider.Instance.ExecuteQuery(query);

            if (int.Parse(checkCTHD.Rows[0][0].ToString()) != 0)
            {
                e.Cancel = true;
                errProduct.SetError(cbxSP, "Sản phẩm đã tồn tại");
            }
            else
            {
                e.Cancel = false;
                errProduct.Clear();
            }
        }

        private void dtpNgayLap_Validating(object sender, CancelEventArgs e)
        {
            int yearCurrent = DateTime.Now.Year;
            int yearBorn = dtpNgayLap.Value.Year;

            if (yearBorn > yearCurrent)
            {
                e.Cancel = true;
                errNL.SetError(dtpNgayLap, "Ngày lập không hợp lệ");
            }
            else
            {
                e.Cancel = false;
                errNL.Clear();
            }
        }


    }
}
