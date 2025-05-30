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
        Task<List<DTO_DaiLy>> GetDTODaiLyListAsync();
        Task<DataTable> GetDataTableDaiLyListAsync();
        Task<DTO_DaiLy> GetDaiLyByMaAsync(int maDaiLy);
        Task<DataTable> GetDataTableDaiLyByMaAsync(int maDaiLy);
        Task<bool> AddDaiLyAsync(DTO_DaiLy daiLy);
        Task<bool> UpdateDaiLyAsync(DTO_DaiLy daiLy);
        Task<bool> UpdateTongNoSauKhiXuatHangAsync(int maDaiLy, decimal conLai);
        Task<bool> DeleteDailyAsync(int maDaiLy);
        Task<DataTable> FindDaiLyAsync(DTO_DaiLy daiLy);
    }

    public class DAL_DaiLy : IDAL_DaiLy
    {
        readonly string _connectionString = DBConnect.connString;
        public async Task<List<DTO_DaiLy>> GetDTODaiLyListAsync()
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
                    $"DAL error fetching DaiLy list (DTO): {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }

        }



        //Get Danh sách đại lý (DataTable)
        public async Task<DataTable> GetDataTableDaiLyListAsync()
        {
            try
            {
                var dataTable = new DataTable();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using(var cmd = new SqlCommand(@"SELECT d.MaDaiLy, TenDaiLy, TenLoaiDaiLy, SDT, Email, DiaChi, TenQuan, NgayTiepNhan, TongNo 
                                                        FROM DAILY d 
                                                        JOIN LOAIDAILY l ON d.MaLoaiDaiLy = l.MaLoaiDaiLy
                                                        JOIN QUAN q ON q.MaQuan = d.MaQuan", conn)){
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            dataTable.Load(reader);
                        }
                        return dataTable;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching DaiLy list (DataTable): {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }



        //Lấy Đại lý (DTO) theo mã
        public async Task<DTO_DaiLy> GetDaiLyByMaAsync(int maDaiLy)
        {
            try
            {
                DTO_DaiLy daiLy = new DTO_DaiLy();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT MaDaiLy, TenDaiLy, MaLoaiDaiLy, SDT, Email, DiaChi, MaQuan, NgayTiepNhan, TongNo FROM DAILY WHERE MaDaiLy = @MaDaiLy", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = maDaiLy;
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            if (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                // Lấy chỉ số của các cột
                                int maDaiLyIndex = reader.GetOrdinal("MaDaiLy");
                                int tenDaiLyIndex = reader.GetOrdinal("TenDaiLy");
                                int maLoaiDaiLyIndex = reader.GetOrdinal("MaLoaiDaiLy");
                                int sdtIndex = reader.GetOrdinal("SDT");
                                int emailIndex = reader.GetOrdinal("Email");
                                int diaChiIndex = reader.GetOrdinal("DiaChi");
                                int maQuanIndex = reader.GetOrdinal("MaQuan");
                                int ngayTiepNhanIndex = reader.GetOrdinal("NgayTiepNhan");
                                int tongNoIndex = reader.GetOrdinal("TongNo");

                                // Tạo đối tượng DTO_DaiLy từ dữ liệu trong reader
                                daiLy = new DTO_DaiLy
                                {
                                    MaDaiLy = reader.GetInt32(maQuanIndex),
                                    TenDaiLy = reader.GetString(tenDaiLyIndex),
                                    MaLoaiDaiLy = reader.GetInt32(maQuanIndex),
                                    Sdt = reader.GetString(sdtIndex),
                                    Email = reader.GetString(emailIndex),
                                    DiaChi = reader.GetString(diaChiIndex),
                                    MaQuan = reader.GetInt32(maQuanIndex),
                                    NgayTiepNhan = reader.GetDateTime(ngayTiepNhanIndex),
                                    TongNo = reader.GetDecimal(tongNoIndex)
                                };
                            }
                        }
                    }
                }
                return daiLy;
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching DaiLy by ID: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }

        // Lấy Đại lý (DataTable) theo mã
        public async Task<DataTable> GetDataTableDaiLyByMaAsync(int maDaiLy)
        {
            try
            {
                var dataTable = new DataTable();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("SELECT MaDaiLy, TenDaiLy, MaLoaiDaiLy, SDT, Email, DiaChi, MaQuan, NgayTiepNhan, TongNo FROM DAILY WHERE MaDaiLy = @MaDaiLy", conn))
                    {
                        cmd.Parameters.Add("@MaDaiLy", SqlDbType.Int).Value = maDaiLy;

                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            dataTable.Load(reader);
                        }
                        return dataTable;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error fetching DaiLy by ID (DataTable): {sqlEx.Message}",
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


        // Tìm đại lý
        public async Task<DataTable> FindDaiLyAsync(DTO_DaiLy daiLy)
        {
            try
            {
                var dataTable = new DataTable();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    string sqlString = @"SELECT d.MaDaiLy, TenDaiLy, TenLoaiDaiLy, SDT, Email, DiaChi, TenQuan, NgayTiepNhan, TongNo 
                                                        FROM DAILY d 
                                                        JOIN LOAIDAILY l ON d.MaLoaiDaiLy = l.MaLoaiDaiLy
                                                        JOIN QUAN q ON q.MaQuan = d.MaQuan
                                                        WHERE 1=1 ";

                    var parameter = new Dictionary<string, object>();

                    if (!string.IsNullOrEmpty(daiLy.TenDaiLy))
                    {
                        sqlString += " AND d.TenDaiLy LIKE @TenDaiLy";
                        parameter.Add("@TenDaiLy", "%" + daiLy.TenDaiLy + "%");
                    }
                    if (!string.IsNullOrEmpty(daiLy.Sdt))
                    {
                        sqlString += " AND d.SDT LIKE @SDT";
                        parameter.Add("@SDT", "%" + daiLy.Sdt + "%");
                    }
                    if (!string.IsNullOrEmpty(daiLy.Email))
                    {
                        sqlString += " AND d.Email LIKE @Email";
                        parameter.Add("@Email", "%" + daiLy.Email + "%");
                    }
                    if (!string.IsNullOrEmpty(daiLy.DiaChi))
                    {
                        sqlString += " AND d.DiaChi LIKE @DiaChi";
                        parameter.Add("@DiaChi", "%" + daiLy.DiaChi + "%");
                    }
                    if (daiLy.MaQuan != 0)
                    {
                        sqlString += " AND d.MaQuan = @MaQuan";
                        parameter.Add("@MaQuan", daiLy.MaQuan);
                    }
                    if (daiLy.MaLoaiDaiLy != 0)
                    {
                        sqlString += " AND d.MaLoaiDaiLy = @MaLoaiDaiLy";
                        parameter.Add("@MaLoaiDaiLy", daiLy.MaLoaiDaiLy);
                    }
                    if (daiLy.NgayTiepNhan != DateTime.MinValue)
                    {
                        sqlString += " AND d.NgayTiepNhan = @NgayTiepNhan";
                        parameter.Add("@NgayTiepNhan", daiLy.NgayTiepNhan);
                    }
                    if (daiLy.TongNo != 0)
                    {
                        sqlString += " AND d.TongNo = @TongNo";
                        parameter.Add("@TongNo", daiLy.TongNo);
                    }

                    using (var cmd = new SqlCommand(sqlString, conn))
                    {
                        foreach (var param in parameter)
                        {
                            if (param.Value is int)
                                cmd.Parameters.Add(param.Key, SqlDbType.Int).Value = param.Value;
                            else if (param.Value is decimal)
                                cmd.Parameters.Add(param.Key, SqlDbType.Decimal).Value = param.Value;
                            else if (param.Value is DateTime)
                                cmd.Parameters.Add(param.Key, SqlDbType.DateTime).Value = param.Value;
                            else
                                cmd.Parameters.Add(param.Key, SqlDbType.NVarChar).Value = param.Value;
                        }
                        using (var adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException(
                    $"DAL error finding DaiLy: {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
    }
}
