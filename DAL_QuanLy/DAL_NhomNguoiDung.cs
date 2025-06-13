using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    // Create interface for data access layer of user groups
    public interface IDAL_NhomNguoiDung
    {
        Task<List<DTO_NhomNguoiDung>> GetNhomNguoiDungListAsync();
        Task<bool> AddNhomNguoiDungAsync(DTO_NhomNguoiDung nhomNguoiDung);
        Task<bool> UpdateNhomNguoiDungAsync(DTO_NhomNguoiDung nhomNguoiDung);
        Task<bool> DeleteNhomNguoiDungAsync(int maNhom);
    }

    public class DAL_NhomNguoiDung : IDAL_NhomNguoiDung
    {
        readonly string _connectionString = DBConnect.connString;

        public async Task<List<DTO_NhomNguoiDung>> GetNhomNguoiDungListAsync()
        {
            try
            {
                var list = new List<DTO_NhomNguoiDung>();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM NHOMNGUOIDUNG", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maNhomIndex = reader.GetOrdinal("MaNhom");
                                int tenNhomIndex = reader.GetOrdinal("TenNhom");

                                list.Add(new DTO_NhomNguoiDung
                                {
                                    MaNhom = reader.GetInt32(maNhomIndex),
                                    TenNhom = reader.GetString(tenNhomIndex)
                                });
                            }
                        }
                    }
                }
                return list;
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching NhomNguoiDung list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        public async Task<bool> AddNhomNguoiDungAsync(DTO_NhomNguoiDung nhomNguoiDung)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO NHOMNGUOIDUNG (TenNhom) VALUES (@TenNhom)", conn))
                    {
                        cmd.Parameters.Add(@"TenNhom", SqlDbType.NVarChar).Value = nhomNguoiDung.TenNhom;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding NhomNguoiDung: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        public async Task<bool> UpdateNhomNguoiDungAsync(DTO_NhomNguoiDung nhomNguoiDung)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"UPDATE NHOMNGUOIDUNG
                                                    SET TenNhom = @TenNhom
                                                    WHERE MaNhom = @MaNhom", conn))
                    {
                        cmd.Parameters.Add(@"TenNhom", SqlDbType.NVarChar).Value = nhomNguoiDung.TenNhom;
                        cmd.Parameters.Add(@"MaNhom", SqlDbType.Int).Value = nhomNguoiDung.MaNhom;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating NhomNguoiDung: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        public async Task<bool> DeleteNhomNguoiDungAsync(int maNhom)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM NHOMNGUOIDUNG WHERE MaNhom = @MaNhom", conn))
                    {
                        cmd.Parameters.Add(@"MaNhom", SqlDbType.Int).Value = maNhom;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting NhomNguoiDung: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
    }
}
