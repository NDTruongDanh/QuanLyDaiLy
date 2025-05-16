using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

using DTO_QuanLy;

namespace DAL_QuanLy
{
    public interface IDAL_DaiLy
    {
        Task<List<DTO_DaiLy>> GetDaiLyListAsync();
        Task<bool> AddDaiLyAsync(DTO_DaiLy daiLy);
        Task<bool> UpdateDaiLyAsync(DTO_DaiLy daiLy);
        Task<bool> UpdateTongNoSauKhiXuatHangAsync(int maDaiLy, decimal conLai);
        Task<bool> DeleteDailyAsync(int maDaiLy);

    }

    public class DAL_DaiLy : IDAL_DaiLy
    {
        readonly string _connectionString = "Data Source=ADMIN-PC;Initial Catalog=QUANLYDAILY;Integrated Security=True;TrustServerCertificate=True;";
        public async Task<List<DTO_DaiLy>> GetDaiLyListAsync()
        {
            try
            {
                var list = new List<DTO_DaiLy>();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT MaDaiLy, TenDaiLy, MaLoaiDaiLy, SDT, Email, DiaChi, MaQuan, NgayTiepNhan, TongNo FROM DAILY", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maDaiLyIndex = reader.GetOrdinal("MaDaiLy");
                                int tenDaiLyIndex = reader.GetOrdinal("TenDaiLy");
                                int maLoaiDaiLyIndex = reader.GetOrdinal("MaLoaiDaiLy");
                                int sdtIndex = reader.GetOrdinal("SDT");
                                int emailIndex = reader.GetOrdinal("Email");
                                int diaChiIndex = reader.GetOrdinal("DiaChi");
                                int maQuanIndex = reader.GetOrdinal("MaQuan");
                                int ngayTiepNhanIndex = reader.GetOrdinal("NgayTiepNhan");
                                int tongNoIndex = reader.GetOrdinal("TongNo");


                                list.Add(new DTO_DaiLy
                                {
                                    MaDaiLy = reader.GetInt32(maDaiLyIndex),
                                    TenDaiLy = reader.GetString(tenDaiLyIndex),
                                    MaLoaiDaiLy = reader.GetInt32(maLoaiDaiLyIndex),
                                    Sdt = reader.GetString(sdtIndex),
                                    Email = reader.GetString(emailIndex),
                                    DiaChi = reader.GetString(diaChiIndex),
                                    MaQuan = reader.GetInt32(maQuanIndex),
                                    NgayTiepNhan = reader.GetDateTime(ngayTiepNhanIndex),
                                    TongNo = reader.GetDecimal(tongNoIndex)
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
                    $"DAL error fetching DaiLy list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }

        }

        // Thêm đại lý
        public async Task<bool> AddDaiLyAsync(DTO_DaiLy daiLy)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"INSERT INTO DAILY(TenDaiLy, MaLoaiDaiLy, SDT, Email, DiaChi, MaQuan, NgayTiepNhan, TongNo) 
                                                      VALUES (@TenDaiLy, @MaLoaiDaiLy, @SDT, @Email, @DiaChi, @MaQuan, @NgayTiepNhan, @TongNo)", conn))
                    {
                        cmd.Parameters.Add("@TenDaiLy", SqlDbType.NVarChar, 50).Value = daiLy.TenDaiLy;
                        cmd.Parameters.Add("@MaLoaiDaiLy", SqlDbType.Int).Value = daiLy.MaLoaiDaiLy;
                        cmd.Parameters.Add("@SDT", SqlDbType.NVarChar, 15).Value = daiLy.Sdt;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = daiLy.Email;
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100).Value = daiLy.DiaChi;
                        cmd.Parameters.Add("@MaQuan", SqlDbType.Int).Value = daiLy.MaQuan;
                        cmd.Parameters.Add("@NgayTiepNhan", SqlDbType.DateTime).Value = daiLy.NgayTiepNhan;
                        cmd.Parameters.Add("@TongNo", SqlDbType.Decimal).Value = daiLy.TongNo;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
           
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding DaiLy: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        // Sửa đại lý
        public async Task<bool> UpdateDaiLyAsync(DTO_DaiLy daiLy)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"UPDATE DAILY SET TenDaiLy = @TenDaiLy, MaLoaiDaiLy = @MaLoaiDaiLy, SDT = @SDT,
                                                                       Email = @Email, DiaChi = @DiaChi, MaQuan = @MaQuan
                                                      WHERE MaDaiLy = @MaDaiLy", conn))
                    {
                        cmd.Parameters.Add("@TenDaiLy", SqlDbType.NVarChar, 50).Value = daiLy.TenDaiLy;
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = daiLy.MaDaiLy;
                        cmd.Parameters.Add("@MaLoaiDaiLy", SqlDbType.Int).Value = daiLy.MaLoaiDaiLy;
                        cmd.Parameters.Add("@SDT", SqlDbType.NVarChar, 15).Value = daiLy.Sdt;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = daiLy.Email;
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100).Value = daiLy.DiaChi;
                        cmd.Parameters.Add("@MaQuan", SqlDbType.Int).Value = daiLy.MaQuan;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }

            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating DaiLy: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        public async Task<bool> UpdateTongNoSauKhiXuatHangAsync(int maDaiLy, decimal conLai)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE DAILY SET TongNo = TongNo + @ConLai WHERE MaDaiLy = @MaDaiLy", conn))
                    {
                        cmd.Parameters.Add("@ConLai", SqlDbType.Decimal).Value = conLai;
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = maDaiLy;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating TongNo DaiLy: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        // Xóa đại lý
        public async Task<bool> DeleteDailyAsync(int maDaiLy)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM DAILY WHERE MaDaiLy = @MaDaiLy", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = maDaiLy;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting DaiLy: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
    }
}
