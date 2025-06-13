using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChiTietPhanQuyen
    {
        public int MaNhom { get; set; }
        public int MaChucNang { get; set; }
        public bool Xem { get; set; }
        public bool Them { get; set; }
        public bool Xoa { get; set; }
        public bool Sua { get; set; }

        public DTO_ChiTietPhanQuyen() { }
        public DTO_ChiTietPhanQuyen(int maNhom, int maChucNang, bool xem, bool them, bool xoa, bool sua)
        {
            MaNhom = maNhom;
            MaChucNang = maChucNang;
            Xem = xem;
            Them = them;
            Xoa = xoa;
            Sua = sua;
        }
    }
}
