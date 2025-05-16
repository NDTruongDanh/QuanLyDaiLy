using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_PhanQuyen
    {
        private Dictionary<string, bool> _chucNang = new Dictionary<string, bool>
           {
            {"GUI_DaiLy", false },
            {"GUI_Quan", false },
            {"GUI_LoaiDaiLy", false },
            {"GUI_DonViTinh", false },
            {"GUI_MatHang", false },
            {"GUI_PhieuXuat", false },
            {"GUI_ChiTietPhieuXuat", false },
            {"GUI_PhieuThu", false },
            {"GUI_PhieuNhap", false },
            {"GUI_ChiTietPhieuNhap", false },
            {"GUI_BaoCaoCongNo", false },
            {"GUI_BaoCaoDoanSo", false },
            {"GUI_ChiTietBaoCaoDoanSo", false},
            {"GUI_ThamSo", false },
            {"GUI_PhanQuyen", false },
        };
    

        public Dictionary<string, bool> ChucNang
        {
            get { return _chucNang; }
            set { _chucNang = value; }
        }
    }
}
