using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    //Create Interface IDAL_PhieuNhap
    public interface IDAL_PhieuNhap
    {
        Task<List<DTO_PhieuNhap>> GetPhieuNhapListAsync();
        Task<bool> AddPhieuNhapAsync(DTO_PhieuNhap phieuNhap);
        Task<bool> UpdatePhieuNhapAsync(DTO_PhieuNhap phieuNhap);
        Task<bool> DeletePhieuNhapAsync(int maPhieuNhap);

    }
    public class DAL_PhieuNhap : IDAL_PhieuNhap
    {
        // Get PhieuNhap List
        readonly string _connectionString = DBConnect.connString;

        public async Task<List<DTO_PhieuNhap>> GetPhieuNhapListAsync()
        {
            try
            {
                var list = new List<DTO_PhieuNhap>();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM PHIEUNHAP", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maPhieuNhapIndex = reader.GetOrdinal("MaPhieuNhap");
                                int ngayLapPhieuIndex = reader.GetOrdinal("NgayLapPhieu");
                                int tongTienIndex = reader.GetOrdinal("TongTien");

                                list.Add(new DTO_PhieuNhap
                                {
                                    MaPhieuNhap = reader.GetInt32(maPhieuNhapIndex),
                                    NgayLapPhieu = reader.GetDateTime(ngayLapPhieuIndex),
                                    TongTien = reader.GetDecimal(tongTienIndex)
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
                    $"DAL error fetching PhieuNhap list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Add PhieuNhap
        public async Task<bool> AddPhieuNhapAsync(DTO_PhieuNhap phieuNhap)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO PHIEUNHAP(NgayLapPhieu, TongTien) VALUES @NgayLapPhieu, @TongTien", conn))
                    {
                        cmd.Parameters.Add("@NgayLapPhieu", SqlDbType.DateTime).Value = phieuNhap.NgayLapPhieu;
                        cmd.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = phieuNhap.TongTien;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding PhieuNhap: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Update PhieuNhap
        public async Task<bool> UpdatePhieuNhapAsync(DTO_PhieuNhap phieuNhap)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE PHIEUNHAP SET NgayLapPhieu = @NgayLapPhieu, TongTien = @TongTien WHERE MaPhieuNhap = @MaPhieuNhap", conn))
                    {
                        cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = phieuNhap.MaPhieuNhap;
                        cmd.Parameters.Add("@NgayLapPhieu", SqlDbType.DateTime).Value = phieuNhap.NgayLapPhieu;
                        cmd.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = phieuNhap.TongTien;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating PhieuNhap: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Delete PhieuNhap
        public async Task<bool> DeletePhieuNhapAsync(int maPhieuNhap)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM PHIEUNHAP WHERE MaPhieuNhap = @MaPhieuNhap", conn))
                    {
                        cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = maPhieuNhap;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting PhieuNhap: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
    }
}
