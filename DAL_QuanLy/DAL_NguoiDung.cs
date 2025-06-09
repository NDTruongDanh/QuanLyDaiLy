using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public class DAL_NguoiDung : DBConnect
    {
        public DataTable GetNguoiDung(string tenNguoiDung, string matKhau)
        {
            SqlDataAdapter da = new SqlDataAdapter($@"SELECT * FROM NGUOIDUNG WHERE TenDangNhap = '{tenNguoiDung}' AND MatKhau = '{matKhau}'", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
