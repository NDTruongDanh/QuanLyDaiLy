using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;   
namespace DAL_QuanLy
{
    public class DAL_PhanQuyen : DBConnect
    {
        public DataTable getChucNang(string userID)
        {
            SqlDataAdapter da = new SqlDataAdapter($@"SELECT c.TenManHinhDuocLoad
                                                        FROM CHUCNANG c 
                                                        JOIN PHANQUYEN p ON c.MaChucNang = p.MaChucNang
                                                        JOIN NGUOIDUNG n ON n.MaNhom = p.MaNhom
                                                        WHERE n.TenDangNhap = '{userID}'", _conn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool insertChucNang(string userID, string tenManHinhDuocLoad)
        {
            try
            {
                _conn.Open();
                string sql = string.Format($@"INSERT INTO PHANQUYEN (TenDangNhap, {tenManHinhDuocLoad}) 
                                                VALUES ({userID}, 1)");
                SqlCommand cmd = new SqlCommand(sql, _conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception) { return false; }
            finally { _conn.Close(); }
        }

        public bool updateChucNang(string userID, string tenManHinhDuocLoad)
        {
            try
            {
                _conn.Open();
                string sql = string.Format($@"UPDATE PHANQUYEN SET {tenManHinhDuocLoad} = 1
                                                WHERE TenDangNhap = {userID}");
                SqlCommand cmd = new SqlCommand(sql, _conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception) { return false; }
            finally { _conn.Close(); }
        }

        public bool deleteChucNang(string userID, string tenManHinhDuocLoad)
        {
            try
            {
                _conn.Open();
                string sql = string.Format($@"UPDATE PHANQUYEN SET {tenManHinhDuocLoad} = 0
                                                WHERE TenDangNhap = {userID}");
                SqlCommand cmd = new SqlCommand(sql, _conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception) { return false; }
            finally { _conn.Close(); }
        }

        
      
    }
}
