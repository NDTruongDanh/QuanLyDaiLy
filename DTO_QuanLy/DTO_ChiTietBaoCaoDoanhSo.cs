using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChiTietBaoCaoDoanhSo
    {
        public int MaBaoCao { get; set; }
        public int MaDaiLy { get; set; }
        public int SoLuongPhieuXuat { get; set; }
        public decimal TongTriGia { get; set; }
        public decimal TyLe { get; set; }

        public DTO_ChiTietBaoCaoDoanhSo() { }

        public DTO_ChiTietBaoCaoDoanhSo(int maBaoCao, int maDaiLy, int soLuongPhieuXuat, decimal tongTriGia, decimal tyLe)
        {
            MaBaoCao = maBaoCao;
            MaDaiLy = maDaiLy;
            SoLuongPhieuXuat = soLuongPhieuXuat;
            TongTriGia = tongTriGia;
            TyLe = tyLe;
        }
    }
}
