using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public interface IDAL_NguoiDung
    {
        Task<List<DTO_NguoiDung>> GetNguoiDungListAsync();
        Task<DataTable> GetDataTableNguoiDungListAsync();
        Task<DTO_NguoiDung> GetNguoiDungAsync(string tenNguoiDung, string matKhau);
        Task<DataTable> GetDataTableNguoiDungAsync(string tenNguoiDung, string matKhau);
        Task<bool> AddNguoiDungAsync(DTO_NguoiDung nhomNguoiDung);
        Task<bool> UpdateNguoiDungAsync(DTO_NguoiDung nhomNguoiDung);
        Task<bool> DeleteNguoiDungAsync(string tenNguoiDung);
    }
    public class DAL_NguoiDung : IDAL_NguoiDung
    {
        readonly string _connectionString = DBConnect.connString;

        public async Task<List<DTO_NguoiDung>> GetNguoiDungListAsync()
        {
            try
            {
                var list = new List<DTO_NguoiDung>();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM NGUOIDUNG", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int tenNguoiDungIndex = reader.GetOrdinal("TenNguoiDung");
                                int matKhauIndex = reader.GetOrdinal("MatKhau");
                                int maNhomIndex = reader.GetOrdinal("MaNhom");

                                list.Add(new DTO_NguoiDung
                                {
                                    TenNguoiDung = reader.GetString(tenNguoiDungIndex),
                                    MatKhau = reader.GetString(matKhauIndex),
                                    MaNhom = reader.GetInt32(maNhomIndex)
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
                    $"DAL error fetching NguoiDung list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        //Get DataTable of NguoiDung
        public async Task<DataTable> GetDataTableNguoiDungListAsync()
        {
            try
            {
                var dataTable = new DataTable();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"SELECT TenNguoiDung, MatKhau, nguoi.MaNhom, TenNhom
                                                        FROM NHOMNGUOIDUNG nhom
                                                        JOIN NGUOIDUNG nguoi ON nhom.MaNhom = nguoi.MaNhom", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
                return dataTable;
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching NguoiDung DataTable: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        // Get DataTable of NguoiDung with specific username and password
        public async Task<DataTable> GetDataTableNguoiDungAsync(string tenNguoiDung, string matKhau)
        {
            try
            {
                var dataTable = new DataTable();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"SELECT TenNguoiDung, MatKhau, nguoi.MaNhom, TenNhom
                                                        FROM NHOMNGUOIDUNG nhom
                                                        JOIN NGUOIDUNG nguoi ON nhom.MaNhom = nguoi.MaNhom
                                                        WHERE TenNguoiDung = @TenNguoiDung AND MatKhau = @MatKhau", conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNguoiDung", tenNguoiDung);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
                return dataTable;
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching NguoiDung DataTable with credentials: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        // Get NguoiDung by username and password

        public async Task<DTO_NguoiDung> GetNguoiDungAsync(string tenNguoiDung, string matKhau)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM NGUOIDUNG WHERE TenNguoiDung = @TenNguoiDung AND MatKhau = @MatKhau", conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNguoiDung", tenNguoiDung);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            if (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                return new DTO_NguoiDung
                                {
                                    TenNguoiDung = reader.GetString(reader.GetOrdinal("TenNguoiDung")),
                                    MatKhau = reader.GetString(reader.GetOrdinal("MatKhau")),
                                    MaNhom = reader.GetInt32(reader.GetOrdinal("MaNhom"))
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching NguoiDung: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        // Add a new NguoiDung
        public async Task<bool> AddNguoiDungAsync(DTO_NguoiDung nhomNguoiDung)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO NGUOIDUNG (TenNguoiDung, MatKhau, MaNhom) VALUES (@TenNguoiDung, @MatKhau, @MaNhom)", conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNguoiDung", nhomNguoiDung.TenNguoiDung);
                        cmd.Parameters.AddWithValue("@MatKhau", nhomNguoiDung.MatKhau);
                        cmd.Parameters.AddWithValue("@MaNhom", nhomNguoiDung.MaNhom);

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding NguoiDung: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        // Update an existing NguoiDung
        public async Task<bool> UpdateNguoiDungAsync(DTO_NguoiDung nhomNguoiDung)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE NGUOIDUNG SET MatKhau = @MatKhau, MaNhom = @MaNhom WHERE TenNguoiDung = @TenNguoiDung", conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNguoiDung", nhomNguoiDung.TenNguoiDung);
                        cmd.Parameters.AddWithValue("@MatKhau", nhomNguoiDung.MatKhau);
                        cmd.Parameters.AddWithValue("@MaNhom", nhomNguoiDung.MaNhom);

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating NguoiDung: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        // Delete a NguoiDung by username
        public async Task<bool> DeleteNguoiDungAsync(string tenNguoiDung)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM NGUOIDUNG WHERE TenNguoiDung = @TenNguoiDung", conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNguoiDung", tenNguoiDung);

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting NguoiDung: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

    }
}
