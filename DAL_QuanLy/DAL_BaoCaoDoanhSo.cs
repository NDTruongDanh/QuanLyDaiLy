using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;
using System.Threading;

namespace DAL_QuanLy
{
    //Create interface IDAL_BaoCaoDoanhSo
    public interface IDAL_BaoCaoDoanhSo
    {
        Task<List<DTO_BaoCaoDoanhSo>> GetBaoCaoDoanhSoListAsync();
        Task<List<DTO_BaoCaoDoanhSo>> GetBaoCaoDoanhSoByTimeAsync(int thang, int nam);
        Task<bool> AddBaoCaoDoanhSoAsync(DTO_BaoCaoDoanhSo baoCao);
        Task<bool> AddBaoCaoDoanhSoByTimeAsync(int thang, int nam);
        Task<bool> UpdateBaoCaoDoanhSoAsync(DTO_BaoCaoDoanhSo baoCao);
        Task<bool> DeleteBaoCaoDoanhSoAsync(int maBaoCaoDoanhSo);
        Task<bool> IsExistedBaoCaoAsync(int thang, int nam);

    }


    public class DAL_BaoCaoDoanhSo : IDAL_BaoCaoDoanhSo
    {
        readonly string _connectionString = "Data Source=ADMIN-PC;Initial Catalog=QUANLYDAILY;Integrated Security=True;TrustServerCertificate=True;";

        //Get BaoCaoDoanhSo List
        public async Task<List<DTO_BaoCaoDoanhSo>> GetBaoCaoDoanhSoListAsync()
        {
            try
            {
                var list = new List<DTO_BaoCaoDoanhSo>();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM BAOCAO_DOANHSO", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maBaoCaoIndex = reader.GetOrdinal("MaBaoCaoDoanhSo");
                                int thangIndex = reader.GetOrdinal("Thang");
                                int namIndex = reader.GetOrdinal("Nam");
                                int tongDoanhSoIndex = reader.GetOrdinal("TongDoanhSo");

                                list.Add(new DTO_BaoCaoDoanhSo
                                {
                                    MaBaoCaoDoanhSo = reader.GetInt32(maBaoCaoIndex),
                                    Thang = reader.GetByte(thangIndex),
                                    Nam = reader.GetInt32(namIndex),
                                    TongDoanhSo = reader.GetDecimal(tongDoanhSoIndex)
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
                    $"DAL error fetching BaoCaoDoanhSo list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }

        }

        //Get BaoCaoDoanhSo By Time
        public async Task<List<DTO_BaoCaoDoanhSo>> GetBaoCaoDoanhSoByTimeAsync(int thang, int nam)
        {
            try
            {
                var list = new List<DTO_BaoCaoDoanhSo>();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand($"SELECT * FROM BAOCAO_DOANHSO WHERE Thang = @Thang AND Nam = @Nam", conn))
                    {
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maBaoCaoIndex = reader.GetOrdinal("MaBaoCaoDoanhSo");
                                int thangIndex = reader.GetOrdinal("Thang");
                                int namIndex = reader.GetOrdinal("Nam");
                                int tongDoanhSoIndex = reader.GetOrdinal("TongDoanhSo");

                                list.Add(new DTO_BaoCaoDoanhSo
                                {
                                    MaBaoCaoDoanhSo = reader.GetInt32(maBaoCaoIndex),
                                    Thang = reader.GetInt32(thangIndex),
                                    Nam = reader.GetInt32(namIndex),
                                    TongDoanhSo = reader.GetDecimal(tongDoanhSoIndex)
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
                    $"DAL error fetching BaoCaoDoanhSo by time: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Add BaoCaoDoanhSo
        public async Task<bool> AddBaoCaoDoanhSoAsync(DTO_BaoCaoDoanhSo baoCao)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"INSERT INTO BAOCAO_DOANHSO(Thang, Nam, TongDoanhSo)
                                                     VALUES (@Thang, @Nam, @TongDoanhSo)", conn))
                    {
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = baoCao.Thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = baoCao.Nam;
                        cmd.Parameters.Add("@TongDoanhSo", SqlDbType.Decimal).Value = baoCao.TongDoanhSo;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding BaoCaoDoanhSo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Add BaoCaoDoanhSo By Time
        public async Task<bool> AddBaoCaoDoanhSoByTimeAsync(int thang, int nam)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"INSERT INTO BAOCAO_DOANHSO(Thang, Nam, TongDoanhSo)
                                                      SELECT @Thang,
                                                             @Nam,
                                                             ISNULL(SUM(TongTien),0)
                                                      FROM PHIEUXUAT  
                                                      WHERE MONTH(NgayLapPhieu) = @Thang 
                                                            AND YEAR(NgayLapPhieu) = @Nam", conn))
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
                    $"DAL error adding BaoCaoDoanhSo by time: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        //Update BaoCaoDoanhSo
        public async Task<bool> UpdateBaoCaoDoanhSoAsync(DTO_BaoCaoDoanhSo baoCao)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE BAOCAO_DOANHSO SET Thang = @Thang, Nam = @Nam, TongDoanhSo = @TongDoanhSo WHERE MaBaoCaoDoanhSo = @MaBaoCaoDoanhSo", conn))
                    {
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = baoCao.Thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = baoCao.Nam;
                        cmd.Parameters.Add("@TongDoanhSo", SqlDbType.Decimal).Value = baoCao.TongDoanhSo;
                        cmd.Parameters.Add("@MaBaoCaoDoanhSo", SqlDbType.Int).Value = baoCao.MaBaoCaoDoanhSo;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating BaoCaoDoanhSo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        // Delete BaoCaoDoanhSo
        public async Task<bool> DeleteBaoCaoDoanhSoAsync(int maBaoCaoDoanhSo)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM BAOCAO_DOANHSO WHERE MaBaoCaoDoanhSo = @MaBaoCaoDoanhSo", conn))
                    {
                        cmd.Parameters.Add("@MaBaoCaoDoanhSo", SqlDbType.Int).Value = maBaoCaoDoanhSo;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting BaoCaoDoanhSo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Check if BaoCaoDoanhSo exists
        public async Task<bool> IsExistedBaoCaoAsync(int thang, int nam)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"SELECT CASE WHEN EXISTS(
                                                        SELECT 1 FROM BAOCAO_DOANHSO 
                                                        WHERE Thang = @Thang AND Nam = @Nam
                                                    ) THEN 1 ELSE 0 END;", conn))
                    {
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

                        object? result = await cmd.ExecuteScalarAsync().ConfigureAwait(false);
                        if (result == null || result == DBNull.Value)
                            return false;
                        int count = Convert.ToInt32(result);
                        return count > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error checking BaoCaoDoanhSo existence: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
    }
}
