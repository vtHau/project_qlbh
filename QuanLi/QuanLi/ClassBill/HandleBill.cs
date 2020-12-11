using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi.ClassBill
{
    class HandleBill
    {
        private static HandleBill instance;

        public static HandleBill Instance
        {
            get { if (instance == null) instance = new HandleBill(); return HandleBill.instance; }
            private set { HandleBill.instance = value; }
        }

        private HandleBill() { }

        public DataTable LoadDGV()
        {
            string query = "SELECT MaHD , NgayLap , NV.TenNV , KH.TenKH  FROM HoaDon HD ,  NhanVien NV , KhachHang KH WHERE HD.KhachHang = KH.MaKH AND HD.NguoiLap = NV.MaNV ";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadDGVSX(string nameOderBy, string typeOderBy)
        {
            string query = "SELECT MaHD , NgayLap , NV.TenNV , KH.TenKH  FROM HoaDon HD ,  NhanVien NV , KhachHang KH WHERE HD.KhachHang = KH.MaKH AND HD.NguoiLap = NV.MaNV  ORDER BY  " + nameOderBy + "  " + typeOderBy;
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool Add(ClassBill.Bill bill)
        {
            string query = "INSERT INTO HoaDon VALUES ( @MaHD , @NgayLap , @NguoiLap , @KhachHang )";
            object[] para = new object[] { bill.MaHD, bill.NgayLap, bill.MaNV, bill.MaKH };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(ClassBill.Bill bill)
        {
            string MaHD = bill.MaHD;
            string query = "UPDATE HoaDon SET NgayLap = @NgayLap , NguoiLap = @MaNV ,  KhachHang = @MaKH  WHERE MaHD = @MaHD ";
            object[] para = new object[] { bill.NgayLap, bill.MaNV, bill.MaKH, bill.MaHD };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string MaHD)
        {
            string query = "DELETE HoaDon WHERE MaHD = @MaHD";
            object[] para = new object[] { MaHD };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
