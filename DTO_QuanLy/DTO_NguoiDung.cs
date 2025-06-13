using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_NguoiDung
    {
        public string TenNguoiDung { get; set; }
        public string MatKhau { get; set; }
        public int MaNhom { get; set; }

        public DTO_NguoiDung() { }

        public DTO_NguoiDung(string tenNguoiDung, string matKhau, int maNhom)
        {
            TenNguoiDung = tenNguoiDung;
            MatKhau = matKhau;
            MaNhom = maNhom;
        }

    }
}
