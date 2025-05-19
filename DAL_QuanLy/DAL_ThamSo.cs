using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public interface IDAL_ThamSo
    {
        Task<DTO_ThamSo> GetThamSoAsyn();
        Task<float> GetTiLeDonGiaXuatAsync();
        Task<int> GetDaiLyToiDaMoiQuanAsync();
        Task<bool> ApDungQDKiemTraTienThuAsync();
        Task<bool> UpdateThamSoAsync(DTO_ThamSo thamSo);

    }
    public class DAL_ThamSo : IDAL_ThamSo
    {
        readonly string _connectionString = DBConnect.connString;


        //Get ThamSo
        public async Task<DTO_ThamSo> GetThamSoAsyn()
        {
            try
            {
                var thamSo = new DTO_ThamSo();
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT Max_DaiLyMoiQuan, ApDungQDKiemTraTienThu, TiLeTinhDonGiaXuat FROM THAMSO", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            if (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                thamSo = new DTO_ThamSo
                                {
                                    DaiLyToiDa = reader.GetInt32(reader.GetOrdinal("Max_DaiLyMoiQuan")),
                                    ApDungQDKiemTraTienThu = reader.GetBoolean(reader.GetOrdinal("ApDungQDKiemTraTienThu")),
                                    TiLeTinhDonGiaXuat = reader.GetFloat(reader.GetOrdinal("TiLeTinhDonGiaXuat"))
                                };
                            }
                        }
                    }
                }
                return thamSo;
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching ThamSo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }




        //Get TiLeDonGiaXuat
        public async Task<float> GetTiLeDonGiaXuatAsync()
        {
            try
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
            catch (SqlException sqlEx) 
            {
                throw new DalException(
                    $"DAL error fetching TiLeTinhDonGiaXuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }




        //Get DaiLyToiDa
        public async Task<int> GetDaiLyToiDaMoiQuanAsync()
        {
            try
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
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching Max_DaiLyMoiQuan: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Get ApDungQDKiemTraTienThu
        public async Task<bool> ApDungQDKiemTraTienThuAsync()
        {
            try
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
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching ApDungQDKiemTraTienThu: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        // Cập nhật tham số
        public async Task<bool> UpdateThamSoAsync(DTO_ThamSo thamSo)
        {
            try
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
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating ThamSo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

    }
}
