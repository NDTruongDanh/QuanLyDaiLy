using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_NhomNguoiDung
    {
        public int MaNhom { get; set; }
        public string TenNhom { get; set; }

        public DTO_NhomNguoiDung() { }

        public DTO_NhomNguoiDung(int maNhom, string tenNhom)
        {
            MaNhom = maNhom;
            TenNhom = tenNhom;
        }
    }
}
