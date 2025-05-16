using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    //Create interface IDAL_ChiTietPhieuXuat
    public interface IDAL_ChiTietPhieuXuat
    {
        Task<List<DTO_ChiTietPhieuXuat>> GetAllChiTietPhieuXuatListAsync();
        Task<List<DTO_ChiTietPhieuXuat>> GetChiTietPhieuXuatListByMPXAsync(int maPhieuXuat);

        Task<bool> AddChiTietPhieuXuatAsync(DTO_ChiTietPhieuXuat chitietPhieuXuat);
        Task<bool> UpdateChiTietPhieuXuatAsync(DTO_ChiTietPhieuXuat chitietPhieuXuat);
        Task<bool> DeleteChiTietPhieuXuatAsync(int maPhieuXuat, int maMatHang);
    }
    public class DAL_ChiTietPhieuXuat : IDAL_ChiTietPhieuXuat
    {
        readonly string _connectionString = "Data Source=ADMIN-PC;Initial Catalog=QUANLYDAILY;Integrated Security=True;TrustServerCertificate=True;";

        //Get All ChiTietPhieuXuat List
        public async Task<List<DTO_ChiTietPhieuXuat>> GetAllChiTietPhieuXuatListAsync()
        {
            try
            {
                var list = new List<DTO_ChiTietPhieuXuat>();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM CHITIET_PHIEUXUAT", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maPhieuXuatIndex = reader.GetOrdinal("MaPhieuXuat");
                                int maMatHangIndex = reader.GetOrdinal("MaMatHang");
                                int soLuongXuatIndex = reader.GetOrdinal("SoLuongXuat");
                                int donGiaXuatIndex = reader.GetOrdinal("DonGiaXuat");
                                int thanhTienIndex = reader.GetOrdinal("ThanhTien");

                                list.Add(new DTO_ChiTietPhieuXuat
                                {
                                    MaPhieuXuat = reader.GetInt32(maPhieuXuatIndex),
                                    MaMatHang = reader.GetInt32(maMatHangIndex),
                                    SoLuongXuat = reader.GetInt32(soLuongXuatIndex),
                                    DonGiaXuat = reader.GetDecimal(donGiaXuatIndex),
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
                    $"DAL error fetching ChiTietPhieuXuat list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }

        }

        //Get ChiTietPhieuXuat List by MaPhieuXuat
        public async Task<List<DTO_ChiTietPhieuXuat>> GetChiTietPhieuXuatListByMPXAsync(int maPhieuXuat)
        {
            try
            {
                var list = new List<DTO_ChiTietPhieuXuat>();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT MaMatHang,SoLuongXuat,DonGiaXuat,ThanhTien FROM CHITIET_PHIEUXUAT WHERE MaPhieuXuat = @MaPhieuXuat", conn))
                    {
                        cmd.Parameters.Add("@MaPhieuXuat", SqlDbType.Int).Value = maPhieuXuat;
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maMatHangIndex = reader.GetOrdinal("MaMatHang");
                                int soLuongXuatIndex = reader.GetOrdinal("SoLuongXuat");
                                int donGiaXuatIndex = reader.GetOrdinal("DonGiaXuat");
                                int thanhTienIndex = reader.GetOrdinal("ThanhTien");

                                list.Add(new DTO_ChiTietPhieuXuat
                                {
                                    MaPhieuXuat = maPhieuXuat,
                                    MaMatHang = reader.GetInt32(maMatHangIndex),
                                    SoLuongXuat = reader.GetInt32(soLuongXuatIndex),
                                    DonGiaXuat = reader.GetDecimal(donGiaXuatIndex),
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
                    $"DAL error fetching ChiTietPhieuXuat list by MaPhieuXuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Add ChiTietPhieuXuat
        public async Task<bool> AddChiTietPhieuXuatAsync(DTO_ChiTietPhieuXuat chitietPhieuXuat)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO CHITIET_PHIEUXUAT(MaPhieuXuat, MaMatHang, SoLuongXuat, DonGiaXuat, ThanhTien) " +
                                                            "VALUES @MaPhieuXuat, @MaMatHang, @SoLuongXuat, @DonGiaXuat, @ThanhTien", conn))
                    {
                        cmd.Parameters.Add("@MaPhieuXuat", SqlDbType.Int).Value = chitietPhieuXuat.MaPhieuXuat;
                        cmd.Parameters.Add("@MaMatHang", SqlDbType.Int).Value = chitietPhieuXuat.MaMatHang;
                        cmd.Parameters.Add("@SoLuongXuat", SqlDbType.Int).Value = chitietPhieuXuat.SoLuongXuat;
                        cmd.Parameters.Add("@DonGiaXuat", SqlDbType.Decimal).Value = chitietPhieuXuat.DonGiaXuat;
                        cmd.Parameters.Add("@ThanhTien", SqlDbType.Decimal).Value = chitietPhieuXuat.ThanhTien;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding ChiTietPhieuXuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Update ChiTietPhieuXuat
        public async Task<bool> UpdateChiTietPhieuXuatAsync(DTO_ChiTietPhieuXuat chitietPhieuXuat)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE CHITIET_PHIEUXUAT SET SoLuongXuat = @SoLuongXuat, DonGiaXuat = @DonGiaXuat, ThanhTien = @ThanhTien WHERE MaPhieuXuat = @MaPhieuXuat AND MaMatHang = @MaMatHang", conn))
                    {
                        cmd.Parameters.Add("@MaPhieuXuat", SqlDbType.Int).Value = chitietPhieuXuat.MaPhieuXuat;
                        cmd.Parameters.Add("@MaMatHang", SqlDbType.Int).Value = chitietPhieuXuat.MaMatHang;
                        cmd.Parameters.Add("@SoLuongXuat", SqlDbType.Int).Value = chitietPhieuXuat.SoLuongXuat;
                        cmd.Parameters.Add("@DonGiaXuat", SqlDbType.Decimal).Value = chitietPhieuXuat.DonGiaXuat;
                        cmd.Parameters.Add("@ThanhTien", SqlDbType.Decimal).Value = chitietPhieuXuat.ThanhTien;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating ChiTietPhieuXuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Delete ChiTietPhieuXuat
        public async Task<bool> DeleteChiTietPhieuXuatAsync(int maPhieuXuat, int maMatHang)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM CHITIET_PHIEUXUAT WHERE MaPhieuXuat = @MaPhieuXuat AND MaMatHang = @MaMatHang", conn))
                    {
                        cmd.Parameters.Add("@MaPhieuXuat", SqlDbType.Int).Value = maPhieuXuat;
                        cmd.Parameters.Add("@MaMatHang", SqlDbType.Int).Value = maMatHang;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting ChiTietPhieuXuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
       
    }
}
