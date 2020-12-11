using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi.ClassAdmin
{
    class HandleAdmin
    {
        private static HandleAdmin instance;

        public static HandleAdmin Instance
        {
            get { if (instance == null) instance = new HandleAdmin(); return HandleAdmin.instance; }
            private set { HandleAdmin.instance = value; }
        }

        private HandleAdmin() { }

        public DataTable LoadDGV(string AccAdmin)
        {
            string query = "SELECT TenAD , GioiTinh , NgaySinh , SDT , Email , DiaChi FROM TTAdmin  WHERE AccAdmin = @AccAdmin ";

            object[] para = new object[] { AccAdmin };
            return DataProvider.Instance.ExecuteQuery(query, para);
        }

        public bool Add(ClassAdmin.Admin admin)
        {
            string query = "INSERT INTO TTAdmin VALUES ( @AccAdmin , @TenAD , @GioiTinh , @NgaySinh ,  @SDT , @Email , @DiaChi )";
            object[] para = new object[] { admin.AccAdmin, admin.TenAD, admin.GioiTinh, admin.NgaySinh, admin.SDT, admin.Email, admin.DiaChi };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(ClassAdmin.Admin admin)
        {
            string AccAdmin = admin.AccAdmin;
            string query = "UPDATE TTAdmin SET TenAD = @TenAD , GioiTinh = @GioiTinh ,  NgaySinh = @NgaySinh , SDT = @SDT , Email = @eEmail , DiaChi = @DiaChi WHERE AccAdmin = @AccAdmin ";
            object[] para = new object[] { admin.TenAD, admin.GioiTinh, admin.NgaySinh, admin.SDT, admin.Email, admin.DiaChi, admin.AccAdmin };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string AccAdmin)
        {
            string query = "DELETE TTAdmin WHERE AccAdmin = @AccAdmin";
            object[] para = new object[] { AccAdmin };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
