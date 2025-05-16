using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChiTietPhieuNhap
    {
        public int MaPhieuNhap { get; set; }
        public int MaMatHang { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal ThanhTien { get; set; }

        public DTO_ChiTietPhieuNhap() { }

        public DTO_ChiTietPhieuNhap(int maPhieuNhap, int maMatHang, int soLuongNhap, decimal donGiaNhap, decimal thanhTien)
        {
            MaPhieuNhap = maPhieuNhap;
            MaMatHang = maMatHang;
            SoLuongNhap = soLuongNhap;
            DonGiaNhap = donGiaNhap;
            ThanhTien = thanhTien;
        }
    }
}

