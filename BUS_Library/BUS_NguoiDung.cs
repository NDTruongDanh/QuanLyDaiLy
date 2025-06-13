using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
namespace BUS_Library
{
    public class BUS_NguoiDung
    {
        public DAL_NguoiDung dalNguoiDung = new DAL_NguoiDung();
        public bool KiemTra(string tenDangNhap, string matKhau)
        {
            DataTable da = dalNguoiDung.GetNguoiDung(tenDangNhap, matKhau);
            return (da != null && da.Rows.Count > 0);
        }
    }
}
