using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLi.ClassUser
{
    class HandleUser
    {
        private static HandleUser instance;

        public static HandleUser Instance
        {
            get { if (instance == null) instance = new HandleUser(); return HandleUser.instance; }
            private set { HandleUser.instance = value; }
        }

        private HandleUser() { }

        public DataTable LoadDGV()
        {
            string query = "SELECT MaKH , TenKH , GioiTinh , NgaySinh , SDT , Email , DiaChi FROM KhachHang";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadDGVSX(string nameOderBy, string typeOderBy)
        {
            string query = "SELECT MaKH , TenKH , GioiTinh , NgaySinh , SDT , Email , DiaChi FROM KhachHang ORDER BY  " + nameOderBy + "  " + typeOderBy;
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool Add(ClassUser.User user)
        {
            string query = "INSERT INTO KHACHHANG VALUES ( @MaKH , @TenKH , @GioiTinh , @NgaySinh ,  @SDT , @Email , @DiaChi )";
            object[] para = new object[] { user.MaKH, user.TenKH, user.GioiTinh, user.NgaySinh, user.SDT, user.Email, user.DiaChi };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(ClassUser.User user)
        {
            string MaKH = user.MaKH;
            string query = "UPDATE KHACHHANG SET TenKH = @TenKH , GioiTinh = @GioiTinh ,  NgaySinh = @NgaySinh , SDT = @SDT , Email = @eEmail , DiaChi = @DiaChi WHERE MaKH = @MaKH ";
            object[] para = new object[] { user.TenKH, user.GioiTinh, user.NgaySinh, user.SDT, user.Email, user.DiaChi, user.MaKH };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string MaKH)
        {
            string query = "DELETE KHACHHANG WHERE MAKH = @MaKH";
            object[] para = new object[] { MaKH };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
