using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    // Create interface for DAL_MatHang
    public interface IDAL_MatHang
    {
        Task<List<DTO_MatHang>> GetMatHangListAsync();
        Task<DataTable> GetMatHangForNhapAsync();
        Task<DataTable> GetMatHangForXuatAsync();
        Task<bool> AddMatHangAsync(DTO_MatHang matHang);
        Task<bool> AddMatHangDefault(string tenMatHang, int maDonViTinh);
        Task<bool> UpdateMatHangAsync(DTO_MatHang matHang);
        Task<bool> DeleteMatHangAsync(int maMatHang);

    }


    public class DAL_MatHang : IDAL_MatHang
    {
        readonly string _connectionString = DBConnect.connString;   

        public async Task<List<DTO_MatHang>> GetMatHangListAsync()
        {
            try
            {
                var list = new List<DTO_MatHang>();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM MATHANG", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maMatHangIndex = reader.GetOrdinal("MaMatHang");
                                int tenMatHangIndex = reader.GetOrdinal("TenMatHang");
                                int maDonViTinhIndex = reader.GetOrdinal("MaDonViTinh");
                                int donGiaHienTaiIndex = reader.GetOrdinal("DonGiaHienTai");
                                int tonKhoIndex = reader.GetOrdinal("TonKho");

                                list.Add(new DTO_MatHang
                                {
                                    MaMatHang = reader.GetInt32(maMatHangIndex),
                                    TenMatHang = reader.GetString(tenMatHangIndex),
                                    MaDonViTinh = reader.GetInt32(maDonViTinhIndex),
                                    DonGiaHienTai = reader.GetDecimal(donGiaHienTaiIndex),
                                    TonKho = reader.GetInt32(tonKhoIndex)
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
                    $"DAL error fetching Mat Hang list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        //Get MatHang for Nhap 
        public async Task<DataTable> GetMatHangForNhapAsync()
        {
            try
            {
                var dataTable = new DataTable();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"SELECT MaMatHang, TenMatHang + ' (' + TenDonViTinh + ')' AS Display
                                                    FROM MATHANG mh
                                                    JOIN DONVITINH dvt ON mh.MaDonViTinh = dvt.MaDonViTinh", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
                return dataTable;
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching Mat Hang for Nhap Xuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }




        //Get MatHang for Xuat
        public async Task<DataTable> GetMatHangForXuatAsync()
        {
            try
            {
                var dataTable = new DataTable();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"SELECT 
                                                            MaMatHang, 
                                                            CONCAT(TenMatHang, ' (', TenDonViTinh, N') - Tồn kho ', TonKho) AS DISPLAY, 
                                                            DonGiaHienTai,
                                                            TonKho  
                                                        FROM 
                                                            MATHANG mh
                                                        JOIN 
                                                            DONVITINH dvt ON mh.MaDonViTinh = dvt.MaDonViTinh;
                                                        ", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
                return dataTable;
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching Mat Hang for Xuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }





        //Add MatHang
        public async Task<bool> AddMatHangAsync(DTO_MatHang matHang)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO MATHANG(TenMatHang, MaDonViTinh, DonGiaHienTai, TonKho) VALUES @TenMatHang, @MaDonViTinh, @DonGiaHienTai, @TonKho", conn))
                    {
                        cmd.Parameters.Add("@TenMatHang", SqlDbType.NVarChar).Value = matHang.TenMatHang;
                        cmd.Parameters.Add("@MaDonViTinh", SqlDbType.Int).Value = matHang.MaDonViTinh;
                        cmd.Parameters.Add("@DonGiaHienTai", SqlDbType.Decimal).Value = matHang.DonGiaHienTai;
                        cmd.Parameters.Add("@TonKho", SqlDbType.Int).Value = matHang.TonKho;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding Mat Hang: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Add MatHang Default
        public async Task<bool> AddMatHangDefault(string tenMatHang, int maDonViTinh)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO MATHANG(TenMatHang, MaDonViTinh, DonGiaHienTai, TonKho) VALUES (@TenMatHang, @MaDonViTinh, 0, 0)", conn))
                    {
                        cmd.Parameters.Add("@TenMatHang", SqlDbType.NVarChar).Value = tenMatHang;
                        cmd.Parameters.Add("@MaDonViTinh", SqlDbType.Int).Value = maDonViTinh;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding Mat Hang Default: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        // Update MatHang
        public async Task<bool> UpdateMatHangAsync(DTO_MatHang matHang)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE MATHANG SET TenMatHang = @TenMatHang, MaDonViTinh = @MaDonViTinh, DonGiaHienTai = @DonGiaHienTai, TonKho = @TonKho WHERE MaMatHang = @MaMatHang", conn))
                    {
                        cmd.Parameters.Add("@TenMatHang", SqlDbType.NVarChar).Value = matHang.TenMatHang;
                        cmd.Parameters.Add("@MaDonViTinh", SqlDbType.Int).Value = matHang.MaDonViTinh;
                        cmd.Parameters.Add("@DonGiaHienTai", SqlDbType.Decimal).Value = matHang.DonGiaHienTai;
                        cmd.Parameters.Add("@TonKho", SqlDbType.Int).Value = matHang.TonKho;
                        cmd.Parameters.Add("@MaMatHang", SqlDbType.Int).Value = matHang.MaMatHang;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating Mat Hang (by DTO): {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        // Update MatHang
        public async Task<bool> UpdateMatHangAsync(int maMatHang, string tenMatHang, int maDonViTinh)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE MATHANG SET TenMatHang = @TenMatHang, MaDonViTinh = @MaDonViTinh WHERE MaMatHang = @MaMatHang", conn))
                    {
                        cmd.Parameters.Add("@MaMatHang", SqlDbType.Int).Value = maMatHang;
                        cmd.Parameters.Add("@TenMatHang", SqlDbType.NVarChar).Value = tenMatHang;
                        cmd.Parameters.Add("@MaDonViTinh", SqlDbType.Int).Value = maDonViTinh;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating Mat Hang (by variables): {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        // Delete MatHang
        public async Task<bool> DeleteMatHangAsync(int maMatHang)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM MATHANG WHERE MaMatHang = @MaMatHang", conn))
                    {
                        cmd.Parameters.Add("@MaMatHang", SqlDbType.Int).Value = maMatHang;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting Mat Hang: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

    }
}
