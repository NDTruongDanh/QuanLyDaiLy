using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public interface IDAL_DonViTinh
    {
        Task<List<DTO_DonViTinh>> GetDonViTinhListAsync();
        Task<bool> AddDonViTinhAsync(DTO_DonViTinh donViTinh);
        Task<bool> UpdateDonViTinhAsync(DTO_DonViTinh donViTinh);
        Task<bool> DeleteDonViTinhAsync(int maDonViTinh);

    }
    public class DAL_DonViTinh : IDAL_DonViTinh
    {
        readonly string _connectionString = "Data Source=ADMIN-PC;Initial Catalog=QUANLYDAILY;Integrated Security=True;TrustServerCertificate=True;";

        public async Task<List<DTO_DonViTinh>> GetDonViTinhListAsync()
        {
            try
            {
                var list = new List<DTO_DonViTinh>();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT MaDonViTinh, TenDonViTinh FROM DONVITINH", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maDonViTinhIndex = reader.GetOrdinal("MaDonViTinh");
                                int tenDonViTinhIndex = reader.GetOrdinal("TenDonViTinh");

                                list.Add(new DTO_DonViTinh
                                {
                                    MaDonViTinh = reader.GetInt32(maDonViTinhIndex),
                                    TenDonViTinh = reader.GetString(tenDonViTinhIndex)
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
                    $"DAL error fetching DonViTinh list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Add DonViTinh
        public async Task<bool> AddDonViTinhAsync(DTO_DonViTinh donViTinh)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO DONVITINH(TenDonViTinh) VALUES (@TenDonViTinh)", conn))
                    {
                        cmd.Parameters.Add("@TenDonViTinh", SqlDbType.NVarChar, 50).Value = donViTinh.TenDonViTinh;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding DonViTinh: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        // Update DonViTinh
        public async Task<bool> UpdateDonViTinhAsync(DTO_DonViTinh donViTinh)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE DONVITINH SET TenDonViTinh = @TenDonViTinh WHERE MaDonViTinh = @MaDonViTinh", conn))
                    {
                        cmd.Parameters.Add("@TenDonViTinh", SqlDbType.NVarChar, 50).Value = donViTinh.TenDonViTinh;
                        cmd.Parameters.Add("@MaDonViTinh", SqlDbType.Int).Value = donViTinh.MaDonViTinh;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating DonViTinh: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Delete DonViTinh
        public async Task<bool> DeleteDonViTinhAsync(int maDonViTinh)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM DONVITINH WHERE MaDonViTinh = @MaDonViTinh", conn))
                    {
                        cmd.Parameters.Add("@MaDonViTinh", SqlDbType.Int).Value = maDonViTinh;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting DonViTinh: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

    }
}
