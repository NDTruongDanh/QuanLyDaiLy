using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_PhieuNhap
    {
        public int MaPhieuNhap { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public decimal TongTien { get; set; }

        public DTO_PhieuNhap() { }

        public DTO_PhieuNhap(int maPhieuNhap, DateTime ngayLap, decimal tongTien)
        {
            MaPhieuNhap = maPhieuNhap;
            NgayLapPhieu = ngayLap;
            TongTien = tongTien;
        }

    }
}

