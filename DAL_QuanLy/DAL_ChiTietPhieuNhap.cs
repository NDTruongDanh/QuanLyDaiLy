using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    //Create Interface ChiTietPhieuNhap
    public interface IDAL_ChiTietPhieuNhap
    {
        Task<List<DTO_ChiTietPhieuNhap>> GetChiTietPhieuNhapListAsync();
        Task<bool> AddChiTietPhieuNhapAsync(DTO_ChiTietPhieuNhap chiTietPhieuNhap);
        Task<bool> UpdateChiTietPhieuNhapAsync(DTO_ChiTietPhieuNhap chiTietPhieuNhap);
        Task<bool> DeleteChiTietPhieuNhapAsync(int maPhieuNhap, int maMatHang);

    }


    public class DAL_ChiTietPhieuNhap : IDAL_ChiTietPhieuNhap
    {
        readonly string _connectionString = "Data Source=ADMIN-PC;Initial Catalog=QUANLYDAILY;Integrated Security=True;TrustServerCertificate=True;";

        //Get ChiTietPhieuNhap List
        public async Task<List<DTO_ChiTietPhieuNhap>> GetChiTietPhieuNhapListAsync()
        {
            var list = new List<DTO_ChiTietPhieuNhap>();
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM CHITIET_PHIEUNHAP", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maPhieuNhapIndex = reader.GetOrdinal("MaPhieuNhap");
                                int maMatHangIndex = reader.GetOrdinal("MaMatHang");
                                int soLuongNhapIndex = reader.GetOrdinal("SoLuongNhap");
                                int donGiaNhapIndex = reader.GetOrdinal("DonGiaNhap");
                                int thanhTienIndex = reader.GetOrdinal("ThanhTien");

                                list.Add(new DTO_ChiTietPhieuNhap
                                {
                                    MaPhieuNhap = reader.GetInt32(maPhieuNhapIndex),
                                    MaMatHang = reader.GetInt32(maMatHangIndex),
                                    SoLuongNhap = reader.GetInt32(soLuongNhapIndex),
                                    DonGiaNhap = reader.GetDecimal(donGiaNhapIndex),
                                    ThanhTien = reader.GetDecimal(thanhTienIndex)
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
                    $"DAL error fetching ChiTietPhieuNhap list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Add ChiTietPhieuNhap
        public async Task<bool> AddChiTietPhieuNhapAsync(DTO_ChiTietPhieuNhap chiTietPhieuNhap)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO CHITIET_PHIEUNHAP(MaPhieuNhap, MaMatHang, SoLuongNhap, DonGiaNhap, ThanhTien " +
                                                        "VALUES @MaPhieuNhap, @MaMatHang, @SoLuongNhap, @DonGiaNhap, @ThanhTien", conn))
                    {
                        cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = chiTietPhieuNhap.MaPhieuNhap;
                        cmd.Parameters.Add("@MaMatHang", SqlDbType.Int).Value = chiTietPhieuNhap.MaMatHang;
                        cmd.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = chiTietPhieuNhap.SoLuongNhap;
                        cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Decimal).Value = chiTietPhieuNhap.DonGiaNhap;
                        cmd.Parameters.Add("@ThanhTien", SqlDbType.Decimal).Value = chiTietPhieuNhap.ThanhTien;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }          
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding ChiTietPhieuNhap: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Update ChiTietPhieuNhap
        public async Task<bool> UpdateChiTietPhieuNhapAsync(DTO_ChiTietPhieuNhap chiTietPhieuNhap)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE CHITIET_PHIEUNHAP SET SoLuongNhap = @SoLuongNhap, DonGiaNhap = @DonGiaNhap, ThanhTien = @ThanhTien " +
                                                        "WHERE MaPhieuNhap = @MaPhieuNhap AND MaMatHang = @MaMatHang", conn))
                    {
                        cmd.Parameters.Add("@SoLuongNhap", SqlDbType.Int).Value = chiTietPhieuNhap.SoLuongNhap;
                        cmd.Parameters.Add("@DonGiaNhap", SqlDbType.Decimal).Value = chiTietPhieuNhap.DonGiaNhap;
                        cmd.Parameters.Add("@ThanhTien", SqlDbType.Decimal).Value = chiTietPhieuNhap.ThanhTien;
                        cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = chiTietPhieuNhap.MaPhieuNhap;
                        cmd.Parameters.Add("@MaMatHang", SqlDbType.Int).Value = chiTietPhieuNhap.MaMatHang;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating ChiTietPhieuNhap: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Delete ChiTietPhieuNhap
        public async Task<bool> DeleteChiTietPhieuNhapAsync(int maPhieuNhap, int maMatHang)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM CHITIET_PHIEUNHAP WHERE MaPhieuNhap = @MaPhieuNhap AND MaMatHang = @MaMatHang", conn))
                    {
                        cmd.Parameters.Add("@MaPhieuNhap", SqlDbType.Int).Value = maPhieuNhap;
                        cmd.Parameters.Add("@MaMatHang", SqlDbType.Int).Value = maMatHang;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting ChiTietPhieuNhap: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
    }
}
