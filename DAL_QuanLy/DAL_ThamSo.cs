using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_ThamSo : DBConnect
    {
        // Lấy tất cả tham số
        public DataTable GetAllThamSo()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM THAMSO", _conn);
            DataTable dtThamSo = new DataTable();
            da.Fill(dtThamSo);
            return dtThamSo;
        }

        // Thêm tham số
        public bool ThemThamSo(DTO_ThamSo ts)
        {
            try
            {
                _conn.Open();
                string sql = string.Format("INSERT INTO THAMSO (TenThamSo, GiaTri) VALUES (N'{0}', {1})", ts.TenThamSo, ts.GiaTri);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception) { return false; }
            finally { _conn.Close(); }
        }

        // Sửa tham số
        public bool SuaThamSo(DTO_ThamSo ts)
        {
            try
            {
                _conn.Open();
                string sql = string.Format("UPDATE THAMSO SET GiaTri = {0} WHERE TenThamSo = N'{1}'", ts.GiaTri, ts.TenThamSo);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception) { return false; }
            finally { _conn.Close(); }
        }

        // Xóa tham số
        public bool XoaThamSo(string tenThamSo)
        {
            try
            {
                _conn.Open();
                string sql = string.Format("DELETE FROM THAMSO WHERE TenThamSo = N'{0}'", tenThamSo);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception) { return false; }
            finally { _conn.Close(); }
        }
    }
}
