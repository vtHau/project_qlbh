using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLi.ClassBill
{
    class Bill
    {
        private string maHD;
        private DateTime ngayLap;
        private string maNV;
        private string maKH;

        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
    }
}
