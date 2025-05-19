using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public interface IDAL_ThamSo
    {
        Task<float> GetTiLeDonGiaXuatAsync();
        Task<int> GetDaiLyToiDaMoiQuanAsync();
        Task<bool> ApDungQDKiemTraTienThuAsync();
        Task<bool> UpdateThamSoAsync(DTO_ThamSo thamSo);

    }
    public class DAL_ThamSo : IDAL_ThamSo
    {
        readonly string _connectionString = DBConnect.connString;

        //Get TiLeDonGiaXuat
        public async Task<float> GetTiLeDonGiaXuatAsync()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync().ConfigureAwait(false);
                using (var cmd = new SqlCommand("SELECT TiLeTinhDonGiaXuat FROM THAMSO", conn))
                {
                    object? result = await cmd.ExecuteScalarAsync().ConfigureAwait(false);
                    if (result == null || result == DBNull.Value)
                        throw new DalException("Get TiLeTinhDonGiaXuat failed", null, 0);

                    return (float)Convert.ToDecimal(result);
                }
            }
        }




        //Get DaiLyToiDa
        public async Task<int> GetDaiLyToiDaMoiQuanAsync()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync().ConfigureAwait(false);
                using (var cmd = new SqlCommand("SELECT Max_DaiLyMoiQuan FROM THAMSO", conn))
                {
                    object? result = await cmd.ExecuteScalarAsync().ConfigureAwait(false);
                    if (result == null || result == DBNull.Value)
                        throw new DalException("Get Max_DaiLyMoiQuan failed", null, 0);

                    return Convert.ToInt32(result);
                }
            }
        }


        //Get ApDungQDKiemTraTienThu
        public async Task<bool> ApDungQDKiemTraTienThuAsync()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync().ConfigureAwait(false);
                using (var cmd = new SqlCommand("SELECT ApDungQDKiemTraTienThu FROM THAMSO", conn))
                {
                    object? result = await cmd.ExecuteScalarAsync().ConfigureAwait(false);
                    if (result == null || result == DBNull.Value)
                        throw new DalException("Get ApDungQDKiemTraTienThu failed", null, 0);

                    return Convert.ToByte(result) == 1;
                }
            }
        }



        // Cập nhật tham số
        public async Task<bool> UpdateThamSoAsync(DTO_ThamSo thamSo)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync().ConfigureAwait(false);
                using (var cmd = new SqlCommand("UPDATE THAMSO SET Max_DaiLyMoiQuan = @MaxDaiLy, ApDungQDKTSoTienThu = @ApDungQDKiemTra, TiLeTinhDonGiaXuat = @TiLeTinhDonGiaXuat", conn))
                {
                    cmd.Parameters.AddWithValue("@MaxDaiLy", thamSo.DaiLyToiDa);
                    cmd.Parameters.AddWithValue("@ApDungQDKiemTra", thamSo.ApDungQDKiemTraTienThu);
                    cmd.Parameters.AddWithValue("@TiLeTinhDonGiaXuat", thamSo.TiLeTinhDonGiaXuat);

                    return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                }
            }
        }

    }
}
