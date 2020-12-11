using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi.ClassProduct
{
    class HanldeProduct
    {
        private static HanldeProduct instance;

        public static HanldeProduct Instance
        {
            get { if (instance == null) instance = new HanldeProduct(); return HanldeProduct.instance; }
            private set { HanldeProduct.instance = value; }
        }

        private HanldeProduct() { }

        public DataTable LoadDGV()
        {
            string query = "SELECT MaSP , TenSP , Gia , DanhMuc , SoLuong , NgayNhap FROM SanPham";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadDGVSX(string title, string name, string value)
        {
            string query = "SELECT MaSP , TenSP , Gia , DanhMuc , SoLuong , NgayNhap FROM SanPham " + " " + title + " " + name + "  " + value;
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool Add(ClassProduct.Product product)
        {
            string query = "INSERT INTO SanPham VALUES ( @MaSP , @TenSP , @Gia , @DanhMuc , @SoLuong , @NgayNhap )";
            object[] para = new object[] { product.MaSP, product.TenSP, product.Gia, product.DanhMuc, product.SoLuong, product.NgayNhap };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(ClassProduct.Product product)
        {
            string MaSP = product.MaSP;
            string query = "UPDATE SanPham SET TenSP = @TenSP , Gia = @Gia , DanhMuc = @DanhMuc , SoLuong = @SoLuong , NgayNhap = @NgayNhap  WHERE MaSP = @MaSP ";
            object[] para = new object[] { product.TenSP, product.Gia, product.DanhMuc, product.SoLuong, product.NgayNhap, product.MaSP };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string MaSP)
        {
            string query = "DELETE SanPham WHERE MaSP = @MaSP";
            object[] para = new object[] { MaSP };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
