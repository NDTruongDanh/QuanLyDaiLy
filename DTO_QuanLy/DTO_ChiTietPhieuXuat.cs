using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChiTietPhieuXuat
    {
        public int MaPhieuXuat { get; set; }
        public int MaMatHang { get; set; }
        public int SoLuongXuat { get; set; }
        public decimal DonGiaXuat { get; set; }
        public decimal ThanhTien { get; set; }

        public DTO_ChiTietPhieuXuat() { }

        public DTO_ChiTietPhieuXuat(int maPhieuXuat, int maMatHang, int soLuongXuat, decimal donGiaXuat, decimal thanhTien)
        {
            MaPhieuXuat = maPhieuXuat;
            MaMatHang = maMatHang;
            SoLuongXuat = soLuongXuat;
            DonGiaXuat = donGiaXuat;
            ThanhTien = thanhTien;
        }
    }
}

