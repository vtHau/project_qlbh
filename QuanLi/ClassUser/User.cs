using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi.ClassUser
{
    class User
    {
        private string maKH;

        public string MaKH { get => maKH; set => maKH = value; }

        private string tenKH;

        public string TenKH { get => tenKH; set => tenKH = value; }

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
