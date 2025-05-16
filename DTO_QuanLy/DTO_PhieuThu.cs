using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_PhieuThu
    {
        public int MaPhieuThu { get; set; }

        public int MaDaiLy { get; set; }

        public DateTime NgayThuTien { get; set; }

        public decimal SoTienThu { get; set; }

        public DTO_PhieuThu() { }
        public DTO_PhieuThu(int maPhieuThu, int maDaiLy, DateTime ngayThuTien, decimal soTienThu)
        {
            MaPhieuThu = maPhieuThu;
            MaDaiLy = maDaiLy;
            NgayThuTien = ngayThuTien;
            SoTienThu = soTienThu;
        }
    }
}

