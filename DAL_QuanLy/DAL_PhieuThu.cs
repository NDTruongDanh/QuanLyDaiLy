using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public interface IDAL_PhieuThu
    {
        Task<List<DTO_PhieuThu>> GetAllPhieuThuListAsync();
        Task<List<DTO_PhieuThu>> GetAllPhieuThuCuaDaiLyListAsync(int maDaiLy);
        Task<bool> AddPhieuThuAsync(DTO_PhieuThu phieuThu);
        Task<bool> UpdatePhieuThuAsync(DTO_PhieuThu phieuThu);
        Task<bool> DeletePhieuThuAsync(int maPhieuThu);
    }

    public class DAL_PhieuThu : IDAL_PhieuThu
    {
        private readonly string _connectionString = "Data Source=ADMIN-PC;Initial Catalog=QUANLYDAILY;Integrated Security=True;TrustServerCertificate=True;";

        public async Task<List<DTO_PhieuThu>> GetAllPhieuThuCuaDaiLyListAsync(int maDaiLy)
        {
            try
            {
                var list = new List<DTO_PhieuThu>();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT MaPhieuThu, NgayThuTien, SoTienThu FROM PHIEUTHU WHERE MaDaiLy = @MaDaiLy", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = maDaiLy;

                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            int maPhieuThuIndex = reader.GetOrdinal("MaPhieuThu");
                            int ngayThuTienIndex = reader.GetOrdinal("NgayThuTien");
                            int soTienThuIndex = reader.GetOrdinal("SoTienThu");

                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(new DTO_PhieuThu
                                {
                                    MaDaiLy = maDaiLy,
                                    MaPhieuThu = reader.GetInt32(maPhieuThuIndex),
                                    NgayThuTien = reader.GetDateTime(ngayThuTienIndex),
                                    SoTienThu = reader.GetDecimal(soTienThuIndex)
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
                    $"DAL error fetching PhieuThu DaiLy list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }

        }
        public async Task<List<DTO_PhieuThu>> GetAllPhieuThuListAsync()
        {
            try
            {
                var list = new List<DTO_PhieuThu>();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT MaPhieuThu, MaDaiLy, NgayThuTien, SoTienThu FROM PHIEUTHU", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            int maPhieuThuIndex = reader.GetOrdinal("MaPhieuThu");
                            int maDaiLyIndex = reader.GetOrdinal("MaDaiLy");
                            int ngayThuTienIndex = reader.GetOrdinal("NgayThuTien");
                            int soTienThuIndex = reader.GetOrdinal("SoTienThu");

                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                list.Add(new DTO_PhieuThu
                                {
                                    MaPhieuThu = reader.GetInt32(maPhieuThuIndex),
                                    MaDaiLy = reader.GetInt32(maDaiLyIndex),
                                    NgayThuTien = reader.GetDateTime(ngayThuTienIndex),
                                    SoTienThu = reader.GetDecimal(soTienThuIndex)
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
                    $"DAL error fetching PhieuThu list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }

        }

        // Thêm phiếu thu
        public async Task<bool> AddPhieuThuAsync(DTO_PhieuThu phieuThu)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO PHIEUTHU (MaDaiLy, NgayThuTien, SoTienThu) VALUES (@MaDaiLy, @NgayThuTien, @SoTienThu)", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = phieuThu.MaDaiLy;
                        cmd.Parameters.Add("@NgayThuTien", SqlDbType.DateTime).Value = phieuThu.NgayThuTien;
                        cmd.Parameters.Add("@SoTienThu", SqlDbType.Decimal).Value = phieuThu.SoTienThu;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;    
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding PhieuThu: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        // Sửa phiếu thu
        public async Task<bool> UpdatePhieuThuAsync(DTO_PhieuThu phieuThu)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"UPDATE PHIEUTHU SET MaDaiLy = @MaDaiLy, NgayThuTien = @NgayThuTien, SoTienThu = @SoTienThu 
                                                     WHERE MaPhieuThu = @MaPhieuThu", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = phieuThu.MaDaiLy;
                        cmd.Parameters.Add("@NgayThuTien", SqlDbType.DateTime).Value = phieuThu.NgayThuTien;
                        cmd.Parameters.Add("@SoTienThu", SqlDbType.Decimal).Value = phieuThu.SoTienThu;
                        cmd.Parameters.Add("@MaPhieuThu", SqlDbType.Int).Value = phieuThu.MaPhieuThu;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating PhieuThu: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        // Xóa phiếu thu
        public async Task<bool> DeletePhieuThuAsync(int maPhieuThu)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM PHIEUTHU WHERE MaPhieuThu = @MaPhieuThu", conn))
                    {
                        cmd.Parameters.Add("@MaPhieuThu", SqlDbType.Int).Value = maPhieuThu;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }

            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting PhieuThu: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
    }
}
