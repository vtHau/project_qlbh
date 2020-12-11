using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi.ClassAdmin
{
    class Admin
    {
        private string accAdmin;

        public string AccAdmin { get => accAdmin; set => accAdmin = value; }

        private string tenAD;

        public string TenAD { get => tenAD; set => tenAD = value; }

        private string gioiTinh;
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        private DateTime ngaySinh;

        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        private string diaChi;

        public string DiaChi { get => diaChi; set => diaChi = value; }

        private string sdt;

        public string SDT { get => sdt; set => sdt = value; }

        private string email;

        public string Email { get => email; set => email = value; }
        
    }
}
