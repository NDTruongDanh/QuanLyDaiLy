using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_MatHang
    {
        public int MaMatHang { get; set; }
        public string TenMatHang { get; set; }
        public int MaDonViTinh { get; set; }
        public decimal DonGiaHienTai { get; set; }
        public int TonKho { get; set; }

        public DTO_MatHang() { }

        public DTO_MatHang(int maMatHang, string tenMatHang, int maDonViTinh, decimal donGiaHienTai, int tonKho)
        {
            MaMatHang = maMatHang;
            TenMatHang = tenMatHang;
            MaDonViTinh = maDonViTinh;
            DonGiaHienTai = donGiaHienTai;
            TonKho = tonKho;
        }
    }
}

