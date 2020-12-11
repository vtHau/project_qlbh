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
            txtKH.Text = KHDT.Rows[0][0].ToString() + " Khách hàng";

            string NV = " SELECT COUNT(MaNV) FROM  NhanVien";
            DataTable NVDT = DataProvider.Instance.ExecuteQuery(NV);
            txtNV.Text = NVDT.Rows[0][0].ToString() + " Nhiên viên";

            string HD = " SELECT COUNT(MaHD) FROM  HoaDon";
            DataTable HDDT = DataProvider.Instance.ExecuteQuery(HD);
            txtHD.Text = HDDT.Rows[0][0].ToString() + " Hóa đơn";

            string SP = " SELECT SUM(SanPham.SoLuong) FROM  SanPham";
            DataTable SPDT = DataProvider.Instance.ExecuteQuery(SP);
            txtSP.Text = SPDT.Rows[0][0].ToString() + " Sản phẩm";
        }
    }
}
