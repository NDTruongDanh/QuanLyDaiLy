using System;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    //Create interface DAL_ChiTietBaoCaoDoanhSo
    public interface IDAL_ChiTietBaoCaoDoanhSo
    {
        Task<List<DTO_ChiTietBaoCaoDoanhSo>> GetChiTietBaoCaoDoanhSoListAsync();
        Task<List<DTO_ChiTietBaoCaoDoanhSo>> GetChiTietBaoCaoDoanhSoByMaBaoCaoListAsync(int maBaoCaoDoanhSo);
        Task<DataTable> GetDataTableChiTietBaoCaoDoanhSoListByMaBaoCaoAsync(int maBaoCaoDoanhSo);
        Task<bool> AddChiTietBaoCaoDoanhSoAsync(DTO_ChiTietBaoCaoDoanhSo chiTietBaoCao);
        Task<bool> AddChiTietBaoCaoDoanhSoAuToAsync(DTO_BaoCaoDoanhSo baoCaoDoanhSo);
        Task<bool> UpdateChiTietBaoCaoDoanhSoAsync(DTO_ChiTietBaoCaoDoanhSo chiTietBaoCao);
        Task<bool> DeleteChiTietBaoCaoDoanhSoAsync(int maBaoCaoDoanhSo, int maDaiLy);
        Task<bool> IsExistedChiTietBaoCaoDoanhSoAsync(DTO_BaoCaoDoanhSo baoCaoDoanhSo);
    }


    public class DAL_ChiTietBaoCaoDoanhSo : IDAL_ChiTietBaoCaoDoanhSo
    {
        readonly string _connectionString = DBConnect.connString;

        //Get ChiTietBaoCaoDoanhSo List
        public async Task<List<DTO_ChiTietBaoCaoDoanhSo>> GetChiTietBaoCaoDoanhSoListAsync()
        {
            try
            {
                var list = new List<DTO_ChiTietBaoCaoDoanhSo>();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM CHITIET_BAOCAODOANHSO", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maBaoCaoIndex = reader.GetOrdinal("MaBaoCaoDoanhSo");
                                int maDaiLyIndex = reader.GetOrdinal("MaDaiLy");
                                int soLuongPhieuXuatIndex = reader.GetOrdinal("SoLuongPhieuXuat");
                                int tongTriGiaIndex = reader.GetOrdinal("TongTriGia");
                                int tiLeIndex = reader.GetOrdinal("TiLe");

                                list.Add(new DTO_ChiTietBaoCaoDoanhSo
                                {
                                    MaBaoCao = reader.GetInt32(maBaoCaoIndex),
                                    MaDaiLy = reader.GetInt32(maDaiLyIndex),
                                    SoLuongPhieuXuat = reader.GetInt32(soLuongPhieuXuatIndex),
                                    TongTriGia = reader.GetDecimal(tongTriGiaIndex),
                                    TyLe = reader.GetDouble(tiLeIndex)
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
                    $"DAL error fetching ChiTietBaoCaoDoanhSo list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Get ChiTietBaoCaoDoanhSo By MaBaoCao List
        public async Task<List<DTO_ChiTietBaoCaoDoanhSo>> GetChiTietBaoCaoDoanhSoByMaBaoCaoListAsync(int maBaoCaoDoanhSo)
        {
            try
            {
                var list = new List<DTO_ChiTietBaoCaoDoanhSo>();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT * FROM CHITIET_BAOCAODOANHSO WHERE MaBaoCaoDoanhSo = @MaBaoCaoDoanhSo", conn))
                    {
                        cmd.Parameters.Add("@MaBaoCaoDoanhSo", SqlDbType.Int).Value = maBaoCaoDoanhSo;
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                int maDaiLyIndex = reader.GetOrdinal("MaDaiLy");
                                int soLuongPhieuXuatIndex = reader.GetOrdinal("SoLuongPhieuXuat");
                                int tongTriGiaIndex = reader.GetOrdinal("TongTriGia");
                                int tiLeIndex = reader.GetOrdinal("TiLe");

                                list.Add(new DTO_ChiTietBaoCaoDoanhSo
                                {
                                    MaDaiLy = reader.GetInt32(maDaiLyIndex),
                                    SoLuongPhieuXuat = reader.GetInt32(soLuongPhieuXuatIndex),
                                    TongTriGia = reader.GetDecimal(tongTriGiaIndex),
                                    TyLe = (float)reader.GetDecimal(tiLeIndex)
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
                    $"DAL error fetching ChiTietBaoCaoDoanhSo by Ma Bao Cao list: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Get DataTable ChiTietBaoCaoDoanhSo By MaBaoCao
        public async Task<DataTable> GetDataTableChiTietBaoCaoDoanhSoListByMaBaoCaoAsync(int maBaoCaoDoanhSo)
        {
            try
            {
                var dataTable = new DataTable();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"SELECT MaBaoCaoDoanhSo, ct.MaDaiLy, TenDaiLy, SoLuongPhieuXuat, TongTriGia, TiLe
                                                    FROM CHITIET_BAOCAODOANHSO ct
                                                    JOIN DAILY dl ON ct.MaDaiLy = dl.MaDaiLy
                                                    WHERE MaBaoCaoDoanhSo = @MaBaoCaoDoanhSo", conn))
                    {
                        cmd.Parameters.Add("@MaBaoCaoDoanhSo", SqlDbType.Int).Value = maBaoCaoDoanhSo;

                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false)) { 
                            dataTable.Load(reader);
                        }
                    }
                }
                return dataTable;
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching DataTable ChiTietBaoCaoDoanhSo by Ma Bao Cao: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        //Add ChiTietBaoCaoDoanhSo
        public async Task<bool> AddChiTietBaoCaoDoanhSoAsync(DTO_ChiTietBaoCaoDoanhSo chiTietBaoCao)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO CHITIET_BAOCAODOANHSO (MaBaoCaoDoanhSo, MaDaiLy, SoLuongPhieuXuat, TongTriGia, TiLe) " +
                                                            "VALUES @MaBaoCaoDoanhSo, @MaDaiLy, @SoLuongPhieuXuat, @TongTriGia, @TiLe",conn))
                    {
                        cmd.Parameters.Add("@MaBaoCaoDoanhSo", SqlDbType.Int).Value = chiTietBaoCao.MaBaoCao;
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = chiTietBaoCao.MaDaiLy;
                        cmd.Parameters.Add("@SoLuongPhieuXuat", SqlDbType.Int).Value = chiTietBaoCao.SoLuongPhieuXuat;
                        cmd.Parameters.Add("@TongTriGia", SqlDbType.Decimal).Value = chiTietBaoCao.TongTriGia;
                        cmd.Parameters.Add("@TiLe", SqlDbType.Decimal).Value = chiTietBaoCao.TyLe;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;

                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding ChiTietBaoCaoDoanhSo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Add ChiTietBaoCaoDoanhSo Auto
        public async Task<bool> AddChiTietBaoCaoDoanhSoAuToAsync(DTO_BaoCaoDoanhSo baoCaoDoanhSo)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand($@"INSERT INTO CHITIET_BAOCAODOANHSO (MaBaoCaoDoanhSo, MaDaiLy, SoLuongPhieuXuat, TongTriGia, TiLe)
                                                SELECT
                                                    @MaBaoCaoDoanhSo,
                                                    MaDaiLy,
                                                    COUNT(MaPhieuXuat) AS SoPhieuXuat,
                                                    SUM(TongTien) AS TongTriGia,
                                                    SUM(TongTien) / @TongDoanhThu AS TiLe
                                                FROM PHIEUXUAT 
                                                WHERE MONTH(NgayLapPhieu) = @Thang AND YEAR(NgayLapPhieu) = @Nam
                                                GROUP BY MaDaiLy;", conn))
                    {
                        cmd.Parameters.Add("@MaBaoCaoDoanhSo", SqlDbType.Int).Value = baoCaoDoanhSo.MaBaoCaoDoanhSo;
                        cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = baoCaoDoanhSo.Thang;
                        cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = baoCaoDoanhSo.Nam;
                        cmd.Parameters.Add("@TongDoanhThu", SqlDbType.Decimal).Value = baoCaoDoanhSo.TongDoanhSo;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error adding auto ChiTietBaoCaoDoanhSo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Update ChiTietBaoCaoDoanhSo
        public async Task<bool> UpdateChiTietBaoCaoDoanhSoAsync(DTO_ChiTietBaoCaoDoanhSo chiTietBaoCao)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE CHITIET_BAOCAODOANHSO SET SoLuongPhieuXuat = @SoLuongPhieuXuat, TongTriGia = @TongTriGia, TiLe = @TiLe WHERE MaBaoCaoDoanhSo = @MaBaoCaoDoanhSo AND MaDaiLy = @MaDaiLy", conn))
                    {
                        cmd.Parameters.Add("@MaBaoCaoDoanhSo", SqlDbType.Int).Value = chiTietBaoCao.MaBaoCao;
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = chiTietBaoCao.MaDaiLy;
                        cmd.Parameters.Add("@SoLuongPhieuXuat", SqlDbType.Int).Value = chiTietBaoCao.SoLuongPhieuXuat;
                        cmd.Parameters.Add("@TongTriGia", SqlDbType.Decimal).Value = chiTietBaoCao.TongTriGia;
                        cmd.Parameters.Add("@TiLe", SqlDbType.Decimal).Value = chiTietBaoCao.TyLe;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error updating ChiTietBaoCaoDoanhSo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        //Delete ChiTietBaoCaoDoanhSo
        public async Task<bool> DeleteChiTietBaoCaoDoanhSoAsync(int maBaoCaoDoanhSo, int maDaiLy)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("DELETE FROM CHITIET_BAOCAODOANHSO WHERE MaBaoCaoDoanhSo = @MaBaoCaoDoanhSo AND MaDaiLy = @MaDaiLy", conn))
                    {
                        cmd.Parameters.Add("@MaBaoCaoDoanhSo", SqlDbType.Int).Value = maBaoCaoDoanhSo;
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = maDaiLy;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error deleting ChiTietBaoCaoDoanhSo: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }


        public async Task<bool> IsExistedChiTietBaoCaoDoanhSoAsync(DTO_BaoCaoDoanhSo baoCaoDoanhSo)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"SELECT CASE WHEN EXISTS(
                                                        SELECT 1 FROM CHITIET_BAOCAODOANHSO 
                                                        WHERE MaBaoCaoDoanhSo = @MaBaoCaoDoanhSo
                                                    ) THEN 1 ELSE 0 END;", conn))
                    {
                        cmd.Parameters.Add("@MaBaoCaoDoanhSo", SqlDbType.Int).Value = baoCaoDoanhSo.MaBaoCaoDoanhSo;

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
                    $"DAL error checking ChiTietBaoCaoDoanhSo existence: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

    }
}
