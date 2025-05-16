using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public interface IDAL_Quan
    {
        Task<List<DTO_Quan>> GetQuanListAsync();
        Task<bool> AddQuanAsync(DTO_Quan quan);
        Task<bool> UpdateQuanAsync(DTO_Quan quan);
        Task<bool> DeleteQuanAsync(int maQuan);
    }

    public class DAL_Quan : IDAL_Quan
    {
        readonly string _connectionString = DBConnect.connString;

        public async Task<List<DTO_Quan>> GetQuanListAsync()
        {
            try
            {
                var list = new List<DTO_Quan>();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT MaQuan, TenQuan FROM QUAN", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maQuanIndex = reader.GetOrdinal("MaQuan");
                                int tenQuanIndex = reader.GetOrdinal("TenQuan");

                                list.Add(new DTO_Quan
                                {
                                    MaQuan = reader.GetInt32(maQuanIndex),
                                    TenQuan = reader.GetString(tenQuanIndex)
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
                    $"DAL error fetching Quan list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
            
        }

        // Thêm quận
        public async Task<bool> AddQuanAsync(DTO_Quan quan)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO QUAN(TenQuan) VALUES (@TenQuan)", conn))
                    {
                        cmd.Parameters.Add("@TenQuan", SqlDbType.NVarChar, 50).Value = quan.TenQuan;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx) 
            {
                throw new DalException(
                    $"DAL error adding Quan: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }

        }

        // Sửa quận
        public async Task<bool> UpdateQuanAsync(DTO_Quan quan)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE QUAN SET TenQuan = @TenQuan WHERE MaQuan = @MaQuan", conn))
                    {
                        cmd.Parameters.Add("TenQuan", SqlDbType.NVarChar, 50).Value = quan.TenQuan;
                        cmd.Parameters.Add("MaQuan", SqlDbType.Int).Value = quan.MaQuan;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx) 
            {
                throw new DalException(
                    $"DAL error updating Quan: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        // Xóa quận
        public async Task<bool> DeleteQuanAsync(int maQuan)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM QUAN WHERE MaQuan = @MaQuan", conn))
                    {
                        cmd.Parameters.Add("@MaQuan", SqlDbType.Int).Value = maQuan;
                        
                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }

            }
            catch (SqlException sqlEx) 
            {
                throw new DalException(
                    $"DAL error deleting Quan: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
    }
}
