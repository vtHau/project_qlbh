using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi.ClassDetailBill
{
    class HandleDetailBill
    {
        private static HandleDetailBill instance;

        public static HandleDetailBill Instance
        {
            get { if (instance == null) instance = new HandleDetailBill(); return HandleDetailBill.instance; }
            private set { HandleDetailBill.instance = value; }
        }

        private HandleDetailBill() { }

        public DataTable LoadDGV(string MaHD)
        {
            string query = "SELECT  SP.MaSP , SP.TenSP , CT.SoLuong , SP.Gia , CT.SoLuong * SP.Gia FROM CTHoaDon CT , SanPham SP WHERE CT.MaSP = SP.MaSP AND CT.MaHD = @MaHD ";
            object[] para = new object[] { MaHD };
            return DataProvider.Instance.ExecuteQuery(query, para);
        }

        public DataTable LoadDGVSX(string MaHD, string nameOderBy, string typeOderBy)
        {
            string query = "SELECT  SP.MaSP , SP.TenSP , CT.SoLuong , SP.Gia , CT.SoLuong * SP.Gia FROM CTHoaDon CT , SanPham SP WHERE CT.MaSP = SP.MaSP AND CT.MaHD = @MaHD  ORDER BY  " + nameOderBy + "  " + typeOderBy;
            object[] para = new object[] { MaHD };
            return DataProvider.Instance.ExecuteQuery(query, para);
        }

        public bool Add(ClassDetailBill.DetailBill detailBill)
        {
            string query = "INSERT INTO CTHoaDon VALUES ( @MaHD , @MaSP , @SoLuong  )";
            object[] para = new object[] { detailBill.MaHD, detailBill.MaSP, detailBill.SoLuong };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(ClassDetailBill.DetailBill detailBill)
        {
            string MaHD = detailBill.MaHD;
            string MaSP = detailBill.MaSP;
            string query = "UPDATE CTHoaDon SET SoLuong = @SoLuong WHERE MaHD = @MaHD AND MaSP = @MaSP ";

            object[] para = new object[] { detailBill.SoLuong, detailBill.MaHD, detailBill.MaSP };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string MaHD, string MaSP)
        {

            string query = "DELETE CTHoaDon WHERE MaHD = @MaHD AND MaSP = @MaSP";

            object[] para = new object[] { MaHD, MaSP };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
