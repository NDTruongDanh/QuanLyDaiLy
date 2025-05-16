using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public interface IDAL_LoaiDaiLy
    {
        Task<List<DTO_LoaiDaiLy>> GetLoaiDaiLyListAsync();
        Task<bool> AddLoaiDaiLyAsync(DTO_LoaiDaiLy loaiDaiLy);
        Task<bool> UpdateLoaiDaiLyAsync(DTO_LoaiDaiLy loaiDaiLy);
        Task<bool> DeleteLoaiDaiLyAsync(int maLoaiDaiLy);
        Task<bool> IsExistedLoaiDaiLy(string tenDaiLy);
    }

    public class DAL_LoaiDaiLy : IDAL_LoaiDaiLy
    {
        readonly string _connectionString = DBConnect.connString;

        public async Task<List<DTO_LoaiDaiLy>> GetLoaiDaiLyListAsync()
        {
            var list = new List<DTO_LoaiDaiLy>();
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);

                    using (var cmd = new SqlCommand("SELECT MaLoaiDaiLy, TenLoaiDaiLy, TienNoToiDa FROM LOAIDAILY", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maDaiLyIndex = reader.GetOrdinal("MaLoaiDaiLy");
                                int tenDaiLyIndex = reader.GetOrdinal("TenLoaiDaiLy");
                                int tienNoToiDaIndex = reader.GetOrdinal("TienNoToiDa");

                                list.Add(new DTO_LoaiDaiLy
                                {
                                    MaLoaiDaiLy = reader.GetInt32(maDaiLyIndex),
                                    TenLoaiDaiLy = reader.GetString(tenDaiLyIndex),
                                    TienNoToiDa = reader.GetDecimal(tienNoToiDaIndex)
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
                    $"DAL error fetching LoaiDaiLy list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        // Thêm loại đại lý
        public async Task<bool> AddLoaiDaiLyAsync(DTO_LoaiDaiLy loaiDaiLy)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString)) 
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO LOAIDAILY(TenLoaiDaiLy, TienNoToiDa) VALUES (@TenLoaiDaiLy,@TienNoToiDa)", conn))
                    {
                        cmd.Parameters.Add("@TenLoaiDaiLy", SqlDbType.NVarChar, 50).Value = loaiDaiLy.TenLoaiDaiLy;
                        cmd.Parameters.Add("@TienNoToiDa", SqlDbType.Money).Value = loaiDaiLy.TienNoToiDa;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                       
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding LoaiDaiLy: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        public async Task<bool> UpdateLoaiDaiLyAsync(DTO_LoaiDaiLy loaiDaiLy)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString)) 
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE LOAIDAILY SET TenLoaiDaiLy = @TenLoaiDaiLy, TienNoToiDa = @TienNoToiDa WHERE MaLoaiDaiLy = @MaLoaiDaiLy", conn))
                    {
                        cmd.Parameters.Add("@MaLoaiDaiLy", SqlDbType.Int).Value = loaiDaiLy.MaLoaiDaiLy;
                        cmd.Parameters.Add("@TenLoaiDaiLy", SqlDbType.NVarChar, 50).Value = loaiDaiLy.TenLoaiDaiLy;
                        cmd.Parameters.Add("@TienNoToiDa", SqlDbType.Money).Value = loaiDaiLy.TienNoToiDa;
                        
                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating LoaiDaiLy: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }

        }

        public async Task<bool> DeleteLoaiDaiLyAsync(int maLoaiDaiLy)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM LOAIDAILY WHERE MaLoaiDaiLy = @MaLoaiDaiLy", conn))
                    {
                        cmd.Parameters.Add("@MaLoaiDaiLy", SqlDbType.Int).Value = maLoaiDaiLy;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting LoaiDaiLy: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        public async Task <bool> IsExistedLoaiDaiLy(string tenDaiLy)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT TenLoaiDaiLy FROM LOAIDAILY WHERE TenLoaiDaiLy = @TenLoaiDaiLy", conn))
                    {
                        cmd.Parameters.Add("@TenLoaiDaiLy", SqlDbType.NVarChar, 50).Value = tenDaiLy;

                        var result = await cmd.ExecuteScalarAsync().ConfigureAwait(false);

                        return result != null;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error checking LoaiDaiLy: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }

        }
    }
}
