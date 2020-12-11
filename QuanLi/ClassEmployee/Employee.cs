using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi.ClassEmployee
{
    class Employee
    {
        private string maNV;

        public string MaNV { get => maNV; set => maNV = value; }

        private string tenNV;

        public string TenNV { get => tenNV; set => tenNV = value; }

        private string gioiTinh;

        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        private DateTime ngaySinh;

        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        private string diaChi;

        public string DiaChi { get => diaChi; set => diaChi = value; }

        private string email;

        private string sdt;

        public string SDT { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
    }
}
