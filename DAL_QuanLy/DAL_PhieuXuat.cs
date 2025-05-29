using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    //Create Interface IDAL_PhieuXuat
    public interface IDAL_PhieuXuat
    {
        Task<List<DTO_PhieuXuat>> GetPhieuXuatListAsync();
        Task<List<DTO_PhieuXuatDaiLy>> GetPhieuXuatCuaDaiLyListAsync(int maDaiLy);
        Task<DataTable> GetDataTablePhieuXuatAsync();
        Task<DataTable> GetDataTablePhieuXuatCuaDaiLyAsync(int maDaiLy);
        Task<int> GetMaPhieuXuatDefaultAsync(DTO_PhieuXuat phieuXuat);
        Task<bool> AddPhieuXuatAsync(DTO_PhieuXuat phieuXuat);
        Task<bool> AddPhieuXuatDefaultAsync(int maDaiLy, DateTime ngayLapPhieu);
        Task<bool> UpdatePhieuXuatAsync(DTO_PhieuXuat phieuXuat);
        Task<bool> DeletePhieuXuatAsync(int maPhieuXuat);
    }

    public class DAL_PhieuXuat : IDAL_PhieuXuat
    {
        // Get PhieuXuat List
        readonly string _connectionString = DBConnect.connString;

        public async Task<List<DTO_PhieuXuat>> GetPhieuXuatListAsync()
        {
            try
            {
                var list = new List<DTO_PhieuXuat>();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM PHIEUXUAT", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maPhieuXuatIndex = reader.GetOrdinal("MaPhieuXuat");
                                int maDaiLyIndex = reader.GetOrdinal("MaDaiLy");
                                int ngayLapPhieuIndex = reader.GetOrdinal("NgayLapPhieu");
                                int tongTienIndex = reader.GetOrdinal("TongTien");
                                int tienTraIndex = reader.GetOrdinal("TienTra");
                                int conLaiIndex = reader.GetOrdinal("ConLai");

                                list.Add(new DTO_PhieuXuat
                                {
                                    MaPhieuXuat = reader.GetInt32(maPhieuXuatIndex),
                                    MaDaiLy = reader.GetInt32(maDaiLyIndex),
                                    NgayLapPhieu = reader.GetDateTime(ngayLapPhieuIndex),
                                    TongTien = reader.GetDecimal(tongTienIndex),
                                    TienTra = reader.GetDecimal(tienTraIndex),
                                    ConLai = reader.GetDecimal(conLaiIndex)
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
                    $"DAL error fetching PhieuXuat list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Get PhieuXuat DaiLy List
        public async Task<List<DTO_PhieuXuatDaiLy>> GetPhieuXuatCuaDaiLyListAsync(int maDaiLy)
        {
            try
            {
                var list = new List<DTO_PhieuXuatDaiLy>();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand($"SELECT MaPhieuXuat, NgayLapPhieu, TongTien, TienTra, ConLai FROM PHIEUXUAT WHERE MaDaiLy = @MaDaiLy", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = maDaiLy;

                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maPhieuXuatIndex = reader.GetOrdinal("MaPhieuXuat");
                                int ngayLapPhieuIndex = reader.GetOrdinal("NgayLapPhieu");
                                int tongTienIndex = reader.GetOrdinal("TongTien");
                                int tienTraIndex = reader.GetOrdinal("TienTra");
                                int conLaiIndex = reader.GetOrdinal("ConLai");

                                list.Add(new DTO_PhieuXuatDaiLy
                                {
                                    MaPhieuXuat = reader.GetInt32(maPhieuXuatIndex),
                                    NgayLapPhieu = reader.GetDateTime(ngayLapPhieuIndex),
                                    TongTien = reader.GetDecimal(tongTienIndex),
                                    TienTra = reader.GetDecimal(tienTraIndex),
                                    ConLai = reader.GetDecimal(conLaiIndex)
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
                    $"DAL error fetching PhieuXuat DaiLy list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }




        //Get DataTable PhieuXuat
        public async Task<DataTable> GetDataTablePhieuXuatAsync()
        {
            try
            {
                var dataTable = new DataTable();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"SELECT MaPhieuXuat, px.MaDaiLy, dl.TenDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai
                                                    FROM PHIEUXUAT px JOIN DAILY dl ON px.MaDaiLy = dl.MaDaiLy", conn))
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
                    $"DAL error fetching DataTable PhieuXuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }




        //Get DataTable PhieuXuat DaiLy
        public async Task<DataTable> GetDataTablePhieuXuatCuaDaiLyAsync(int maDaiLy)
        {
            try
            {
                var dataTable = new DataTable();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"SELECT MaPhieuXuat, px.MaDaiLy, dl.TenDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai
                                                    FROM PHIEUXUAT px JOIN DAILY dl ON px.MaDaiLy = dl.MaDaiLy WHERE px.MaDaiLy = @MaDaiLy", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = maDaiLy;

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
                    $"DAL error fetching DataTable PhieuXuat DaiLy: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        //Get MaPhieuXuat Default
        public async Task<int> GetMaPhieuXuatDefaultAsync(DTO_PhieuXuat phieuXuat)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"DECLARE @TempOutput TABLE (ID INT)
                                                    INSERT INTO PHIEUXUAT(MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai)
                                                    OUTPUT inserted.MaPhieuXuat INTO @TempOutput
                                                    VALUES (@MaDaiLy, @NgayLapPhieu, @TongTien, @TienTra, @ConLai)
                                                    SELECT ID FROM @TempOutput;", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = phieuXuat.MaDaiLy;
                        cmd.Parameters.Add("@NgayLapPhieu", SqlDbType.DateTime).Value = phieuXuat.NgayLapPhieu;
                        cmd.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = phieuXuat.TongTien;
                        cmd.Parameters.Add("@TienTra", SqlDbType.Decimal).Value = phieuXuat.TienTra;
                        cmd.Parameters.Add("@ConLai", SqlDbType.Decimal).Value = phieuXuat.ConLai;

                        object ? result = await cmd.ExecuteScalarAsync().ConfigureAwait(false);
                        if (result == null || result == DBNull.Value)
                            throw new DalException("Insert failed: no ID returned", null, 0);

                        return Convert.ToInt32(result);
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching default MaPhieuXuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        //Add PhieuXuat
        public async Task<bool> AddPhieuXuatAsync(DTO_PhieuXuat phieuXuat)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO PHIEUXUAT(MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai) VALUES (@MaDaiLy, @NgayLapPhieu, @TongTien, @TienTra, @ConLai)", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = phieuXuat.MaDaiLy;
                        cmd.Parameters.Add("@NgayLapPhieu", SqlDbType.DateTime).Value = phieuXuat.NgayLapPhieu;
                        cmd.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = phieuXuat.TongTien;
                        cmd.Parameters.Add("@TienTra", SqlDbType.Decimal).Value = phieuXuat.TienTra;
                        cmd.Parameters.Add("@ConLai", SqlDbType.Decimal).Value = phieuXuat.ConLai;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding PhieuXuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Add PhieuXuat with default values
        public async Task<bool> AddPhieuXuatDefaultAsync(int maDaiLy, DateTime ngayLapPhieu)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO PHIEUXUAT(MaDaiLy, NgayLapPhieu, TongTien, TienTra, ConLai)" +
                                                    " VALUES (@MaDaiLy, @NgayLapPhieu, 0, 0, 0)", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = maDaiLy;
                        cmd.Parameters.Add("@NgayLapPhieu", SqlDbType.DateTime).Value = ngayLapPhieu;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding default PhieuXuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        // Update PhieuXuat
        public async Task<bool> UpdatePhieuXuatAsync(DTO_PhieuXuat phieuXuat)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE PHIEUXUAT SET MaDaiLy = @MaDaiLy, NgayLapPhieu = @NgayLapPhieu, TongTien = @TongTien, TienTra = @TienTra, ConLai = @ConLai WHERE MaPhieuXuat = @MaPhieuXuat", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = phieuXuat.MaDaiLy;
                        cmd.Parameters.Add("@NgayLapPhieu", SqlDbType.DateTime).Value = phieuXuat.NgayLapPhieu;
                        cmd.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = phieuXuat.TongTien;
                        cmd.Parameters.Add("@TienTra", SqlDbType.Decimal).Value = phieuXuat.TienTra;
                        cmd.Parameters.Add("@ConLai", SqlDbType.Decimal).Value = phieuXuat.ConLai;
                        cmd.Parameters.Add("@MaPhieuXuat", SqlDbType.Int).Value = phieuXuat.MaPhieuXuat;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating PhieuXuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        // Delete PhieuXuat
        public async Task<bool> DeletePhieuXuatAsync(int maPhieuXuat)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM PHIEUXUAT WHERE MaPhieuXuat = @MaPhieuXuat", conn))
                    {
                        cmd.Parameters.Add("@MaPhieuXuat", SqlDbType.Int).Value = maPhieuXuat;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting PhieuXuat: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
 
    }
}
