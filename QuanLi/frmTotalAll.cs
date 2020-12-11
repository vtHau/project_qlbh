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
    public partial class frmTotalAll : Form
    {
        public frmTotalAll()
        {
            InitializeComponent();
        }

        private void frmTotalAll_Load(object sender, EventArgs e)
        {
            string KH = " SELECT COUNT(MaKH) FROM  KhachHang";
            DataTable KHDT = DataProvider.Instance.ExecuteQuery(KH);
            txtKH.Text = "   Khách hàng: " + KHDT.Rows[0][0].ToString();

            string NV = " SELECT COUNT(MaNV) FROM  NhanVien";
            DataTable NVDT = DataProvider.Instance.ExecuteQuery(NV);
            txtNV.Text = "   Nhân viên:    " + NVDT.Rows[0][0].ToString();

            string HD = " SELECT COUNT(MaHD) FROM  HoaDon";
            DataTable HDDT = DataProvider.Instance.ExecuteQuery(HD);
            txtHD.Text = "   Hóa đơn:       " + HDDT.Rows[0][0].ToString();

            string SP = " SELECT SUM(SanPham.SoLuong) FROM  SanPham";
            DataTable SPDT = DataProvider.Instance.ExecuteQuery(SP);
            txtSP.Text = "   Sản phẩm:     " + SPDT.Rows[0][0].ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtHD_Click(object sender, EventArgs e)
        {

        }

        private void txtNV_Click(object sender, EventArgs e)
        {

        }
    }
}
