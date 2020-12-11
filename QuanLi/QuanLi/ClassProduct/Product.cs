using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi.ClassProduct
{
    class Product
    {
        private string maSP;
        private string tenSP;
        private int gia;
        private DateTime ngayNhap;
        private string danhMuc;
        private int soLuong;

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int Gia
        {
            get { return gia; }
            set
            {
                if (value > 0)
                {
                    gia = value;
                }

            }
        }

        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string DanhMuc { get => danhMuc; set => danhMuc = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
