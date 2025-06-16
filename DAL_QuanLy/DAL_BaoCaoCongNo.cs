using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    //Create Interface DAL_BaoCaoCongNo
    public interface IDAL_BaoCaoCongNo
    {
        Task<List<DTO_BaoCaoCongNo>> GetAllBaoCaoCongNoAsync();
        Task<DTO_BaoCaoCongNo> GetBaoCaoCongNoByThangAsync(int thang, int nam);
        Task<DataTable> GetDataTableBaoCaoCongNoAsync(int thang, int nam);
        Task<bool> AddBaoCaoCongNoAsync(DTO_BaoCaoCongNo baoCaoCongNo);
        Task<bool> AddBaoCaoCongNoByTimeAsync(int thang, int nam);
        Task<bool> UpdateBaoCaoCongNoAsync(DTO_BaoCaoCongNo baoCaoCongNo);
        Task<bool> DeleteBaoCaoCongNoAsync(int thang, int nam);
        Task<bool> IsExistedBaoCaoAsync(int thang, int nam);

    }
    public class DAL_BaoCaoCongNo : IDAL_BaoCaoCongNo
    {
        readonly string _connectionString = DBConnect.connString;

        //Get all BaoCaoCongNo
        public async Task<List<DTO_BaoCaoCongNo>> GetAllBaoCaoCongNoAsync()
        {
            try
            {
                var list = new List<DTO_BaoCaoCongNo>();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM BAOCAO_CONGNO", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int thangIndex = reader.GetOrdinal("Thang");
                                int namIndex = reader.GetOrdinal("Nam");
                                int maDaiLyIndex = reader.GetOrdinal("MaDaiLy");
                                int noDauIndex = reader.GetOrdinal("NoDau");
                                int phatSinhIndex = reader.GetOrdinal("PhatSinh");
                                int noCuoiIndex = reader.GetOrdinal("NoCuoi");

                                list.Add(new DTO_BaoCaoCongNo
                                {
                                    Thang = reader.GetInt32(thangIndex),
                                    Nam = reader.GetInt32(namIndex),
                                    MaDaiLy = reader.GetInt32(maDaiLyIndex),
                                    NoDau = reader.GetDecimal(noDauIndex),
                                    PhatSinh = reader.GetDecimal(phatSinhIndex),
                                    NoCuoi = reader.GetDecimal(noCuoiIndex)
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
                    $"DAL error fetching BaoCaoCongNo list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Get BaoCaoCongNo by Thang and Nam
        public async Task<DTO_BaoCaoCongNo> GetBaoCaoCongNoByThangAsync(int thang, int nam)
        {
            try
            {
                DTO_BaoCaoCongNo baocao = new DTO_BaoCaoCongNo();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand($"SELECT * FROM BAOCAO_CONGNO WHERE Thang = @Thang AND Nam = @Nam", conn))
                    {
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int thangIndex = reader.GetOrdinal("Thang");
                                int namIndex = reader.GetOrdinal("Nam");
                                int maDaiLyIndex = reader.GetOrdinal("MaDaiLy");
                                int noDauIndex = reader.GetOrdinal("NoDau");
                                int phatSinhIndex = reader.GetOrdinal("PhatSinh");
                                int noCuoiIndex = reader.GetOrdinal("NoCuoi");

                                baocao = new DTO_BaoCaoCongNo
                                {
                                    Thang = reader.GetInt32(thangIndex),
                                    Nam = reader.GetInt32(namIndex),
                                    MaDaiLy = reader.GetInt32(maDaiLyIndex),
                                    NoDau = reader.GetDecimal(noDauIndex),
                                    PhatSinh = reader.GetDecimal(phatSinhIndex),
                                    NoCuoi = reader.GetDecimal(noCuoiIndex)
                                };
                            }
                        }
                    }
                }
                return baocao;
            }

            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching BaoCaoCongNo by Thang and Nam: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Get DataTable BaoCaoCongNo by Thang and Nam
        public async Task<DataTable> GetDataTableBaoCaoCongNoAsync(int thang, int nam)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"SELECT dl.MaDaiLy, dl.TenDaiLy, NoDau, PhatSinh, NoCuoi 
                                                    FROM BAOCAO_CONGNO bc 
                                                    JOIN DAILY dl ON bc.MaDaiLy = dl.MaDaiLy 
                                                    WHERE Thang = @Thang AND Nam = @Nam
                                                    ORDER BY NoCuoi DESC", conn))
                    {
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            var dataTable = new DataTable();
                            dataTable.Load(reader);
                            return dataTable;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching DataTable BaoCaoCongNo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        //Add BaoCaoCongNo
        public async Task<bool> AddBaoCaoCongNoAsync(DTO_BaoCaoCongNo baoCaoCongNo)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO BAOCAO_CONGNO (Thang, Nam, MaDaiLy, NoDau, PhatSinh, NoCuoi) " +
                                                            "VALUES @Thang, @Nam, @MaDaiLy, @NoDau, @PhatSinh, @NoCuoi"))
                    {
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = baoCaoCongNo.Thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = baoCaoCongNo.Nam;
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = baoCaoCongNo.MaDaiLy;
                        cmd.Parameters.Add("@NoDau", SqlDbType.Decimal).Value = baoCaoCongNo.NoDau;
                        cmd.Parameters.Add("@PhatSinh", SqlDbType.Decimal).Value = baoCaoCongNo.PhatSinh;
                        cmd.Parameters.Add("@NoCuoi", SqlDbType.Decimal).Value = baoCaoCongNo.NoCuoi;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding BaoCaoCongNo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Add BaoCaoCongNo by Time
        public async Task<bool> AddBaoCaoCongNoByTimeAsync(int thang, int nam)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"INSERT INTO BAOCAO_CONGNO (Thang, Nam, MaDaiLy, NoDau, PhatSinh, NoCuoi)
                                                    SELECT 
                                                        @Thang,
                                                        @Nam,
                                                        d.MaDaiLy,
                                                        d.TongNo + ISNULL(pt.TongThu, 0) - ISNULL(px.TongPhatSinh, 0) AS NoDau,
                                                        ISNULL(px.TongPhatSinh, 0) AS PhatSinh,
                                                        d.TongNo AS NoCuoi
                                                    FROM DAILY d
                                                    LEFT JOIN (
                                                        SELECT 
                                                            MaDaiLy, 
                                                            SUM(SoTienThu) AS TongThu 
                                                        FROM PHIEUTHU 
                                                        WHERE MONTH(NgayThuTien) = @Thang AND YEAR(NgayThuTien) = @Nam
                                                        GROUP BY MaDaiLy
                                                    ) pt ON d.MaDaiLy = pt.MaDaiLy
                                                    LEFT JOIN (
                                                        SELECT 
                                                            MaDaiLy, 
                                                            SUM(ConLai) AS TongPhatSinh 
                                                        FROM PHIEUXUAT 
                                                        WHERE MONTH(NgayLapPhieu) = @Thang AND YEAR(NgayLapPhieu) = @Nam
                                                        GROUP BY MaDaiLy
                                                    ) px ON d.MaDaiLy = px.MaDaiLy;", conn))
                    {
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;

                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding BaoCaoCongNo by Time: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Update BaoCaoCongNo
        public async Task<bool> UpdateBaoCaoCongNoAsync(DTO_BaoCaoCongNo baoCaoCongNo)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE BAOCAO_CONGNO SET NoDau = @NoDau, PhatSinh = @PhatSinh, NoCuoi = @NoCuoi WHERE Thang = @Thang AND Nam = @Nam AND MaDaiLy = @MaDaiLy", conn))
                    {
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = baoCaoCongNo.Thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = baoCaoCongNo.Nam;
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = baoCaoCongNo.MaDaiLy;
                        cmd.Parameters.Add("@NoDau", SqlDbType.Decimal).Value = baoCaoCongNo.NoDau;
                        cmd.Parameters.Add("@PhatSinh", SqlDbType.Decimal).Value = baoCaoCongNo.PhatSinh;
                        cmd.Parameters.Add("@NoCuoi", SqlDbType.Decimal).Value = baoCaoCongNo.NoCuoi;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating BaoCaoCongNo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Delete BaoCaoCongNo
        public async Task<bool> DeleteBaoCaoCongNoAsync(int thang, int nam)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM BAOCAO_CONGNO WHERE Thang = @Thang AND Nam = @Nam", conn))
                    {
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;
                        //cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = maDaiLy;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting BaoCaoCongNo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Check if BaoCaoCongNo exists
        public async Task<bool> IsExistedBaoCaoAsync(int thang, int nam)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT TOP 1 * FROM BAOCAO_CONGNO WHERE Thang = @Thang AND Nam = @Nam", conn))
                    {
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

                        object ? result = await cmd.ExecuteScalarAsync().ConfigureAwait(false);

                        return result != null && result != DBNull.Value;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error checking BaoCaoCongNo existence: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
    }
}
