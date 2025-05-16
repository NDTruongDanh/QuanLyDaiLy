using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_DonViTinh
    {
        public int MaDonViTinh { get; set; }
        public string TenDonViTinh { get; set; }

        public DTO_DonViTinh() { }

        public DTO_DonViTinh(int maDonViTinh, string tenDonViTinh)
        {
            MaDonViTinh = maDonViTinh;
            TenDonViTinh = tenDonViTinh;
        }
    }
}

