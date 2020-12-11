using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi.ClassEmployee
{
    class HandleEmployee
    {
        private static HandleEmployee instance;

        public static HandleEmployee Instance
        {
            get { if (instance == null) instance = new HandleEmployee(); return HandleEmployee.instance; }
            private set { HandleEmployee.instance = value; }
        }

        private HandleEmployee() { }

        public DataTable LoadDGV()
        {
            string query = "SELECT MaNV , TenNV , GioiTinh , NgaySinh  , SDT , Email , DiaChi FROM NhanVien";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadDGVInfo(string MaNV)
        {
            string query = "SELECT TenNV , GioiTinh , NgaySinh , SDT , Email , DiaChi FROM NhanVien  WHERE MaNV = @MaNV ";

            object[] para = new object[] { MaNV };
            return DataProvider.Instance.ExecuteQuery(query, para);
        }

        public DataTable LoadDGVSX(string nameOderBy, string typeOderBy)
        {
            string query = "SELECT MaNV , TenNV , GioiTinh , NgaySinh , SDT , Email , DiaChi FROM NhanVien ORDER BY  " + nameOderBy + "  " + typeOderBy;
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool Add(ClassEmployee.Employee employee)
        {
            string query = "INSERT INTO NhanVien VALUES ( @MaNV , @TenNV , @GioiTinh , @NgaySinh ,  @SDT , @Email ,  @DiaChi )";
            object[] para = new object[] { employee.MaNV, employee.TenNV, employee.GioiTinh, employee.NgaySinh, employee.SDT, employee.Email, employee.DiaChi };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Edit(ClassEmployee.Employee employee)
        {
            string MaNV = employee.MaNV;
            string query = "UPDATE NhanVien SET TenNV = @TenNV , GioiTinh = @GioiTinh ,  NgaySinh = @NgaySinh , SDT = @SDT , Email = @Email , DiaChi = @DiaChi WHERE MaNV = @MaNV ";
            object[] para = new object[] { employee.TenNV, employee.GioiTinh, employee.NgaySinh, employee.SDT, employee.Email, employee.DiaChi, employee.MaNV };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(string MaNV)
        {
            string query = "DELETE NhanVien WHERE MANV = @MaNV";
            object[] para = new object[] { MaNV };

            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
