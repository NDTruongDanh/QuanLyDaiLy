using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_PhieuXuat
    {
        public int MaPhieuXuat { get; set; }
        public int MaDaiLy { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public decimal TongTien { get; set; }
        public decimal TienTra { get; set; }
        public decimal ConLai { get; set; } 

        public DTO_PhieuXuat() { }

        public DTO_PhieuXuat(int maPhieuXuat, int maDaiLy, DateTime ngayLapPhieu, decimal tongTien, decimal tienTra, decimal conLai)
        {
            MaPhieuXuat = maPhieuXuat;
            MaDaiLy = maDaiLy;
            NgayLapPhieu = ngayLapPhieu;
            TongTien = tongTien;
            TienTra = tienTra;
            ConLai = conLai;
        }
    }
}

