using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace DAL_QuanLy
{
    public interface IDAL_ChiTietPhanQuyen
    {
        Task<DataTable> GetDataTableCTPhanQuyenAsync();
        Task<bool> AddCTPhanQuyenAsync(DTO_ChiTietPhanQuyen ctPhanQuyen);
        Task<bool> UpdateCTPhanQuyenAsync(DTO_ChiTietPhanQuyen ctPhanQuyen);
        Task<bool> DeleteCTPhanQuyenAsync(int maNhom, int maChucNang);
        
        Task<DataTable> GetAllQuyenForUserAsync(string TenNguoiDung);
        Task <DTO_ChiTietPhanQuyen> GetQuyenForUserAsync(string tenDangNhap, string tenChucNang);
    }

    public class DAL_ChiTietPhanQuyen : IDAL_ChiTietPhanQuyen
    {
        readonly string _connectionString = DBConnect.connString;

        public async Task<DataTable> GetDataTableCTPhanQuyenAsync()
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"SELECT p.MaNhom, p.MaChucNang, TenNhom, TenManHinhDuocLoad, Xem, Them, Xoa, Sua
                                                        FROM PHANQUYEN p
                                                        JOIN NHOMNGUOIDUNG n ON p.MaNhom = n.MaNhom
                                                        JOIN CHUCNANG c ON c.MaChucNang = p.MaChucNang", conn))
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
                throw new DalException($"DAL error fetching ChiTietPhanQuyen data: {sqlEx.Message}", sqlEx, sqlEx.Number);
            }
        }

        public async Task<bool> AddCTPhanQuyenAsync(DTO_ChiTietPhanQuyen ctPhanQuyen)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("INSERT INTO PHANQUYEN (MaNhom, MaChucNang, Xem, Them, Xoa, Sua) VALUES (@MaNhom, @MaChucNang, @Xem, @Them, @Xoa, @Sua)", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNhom", ctPhanQuyen.MaNhom);
                        cmd.Parameters.AddWithValue("@MaChucNang", ctPhanQuyen.MaChucNang);
                        cmd.Parameters.AddWithValue("@Xem", ctPhanQuyen.Xem);
                        cmd.Parameters.AddWithValue("@Them", ctPhanQuyen.Them);
                        cmd.Parameters.AddWithValue("@Xoa", ctPhanQuyen.Xoa);
                        cmd.Parameters.AddWithValue("@Sua", ctPhanQuyen.Sua);

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException($"DAL error adding ChiTietPhanQuyen: {sqlEx.Message}", sqlEx, sqlEx.Number);
            }
        }

        public async Task<bool> UpdateCTPhanQuyenAsync(DTO_ChiTietPhanQuyen ctPhanQuyen)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand("UPDATE PHANQUYEN SET Xem = @Xem, Them = @Them, Xoa = @Xoa, Sua = @Sua WHERE MaNhom = @MaNhom AND MaChucNang = @MaChucNang", conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNhom", ctPhanQuyen.MaNhom);
                        cmd.Parameters.AddWithValue("@MaChucNang", ctPhanQuyen.MaChucNang);
                        cmd.Parameters.AddWithValue("@Xem", ctPhanQuyen.Xem);
                        cmd.Parameters.AddWithValue("@Them", ctPhanQuyen.Them);
                        cmd.Parameters.AddWithValue("@Xoa", ctPhanQuyen.Xoa);
                        cmd.Parameters.AddWithValue("@Sua", ctPhanQuyen.Sua);

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException($"DAL error updating ChiTietPhanQuyen: {sqlEx.Message}", sqlEx, sqlEx.Number);
            }
        }


        //Delete a ChiTietPhanQuyen by MaNhom and MaChucNang
        public async Task<bool> DeleteCTPhanQuyenAsync(int maNhom, int maChucNang)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"DELETE FROM PHANQUYEN 
                                                      WHERE MaNhom = @MaNhom AND MaChucNang = @MaChucNang", conn))
                    {
                        cmd.Parameters.Add("@MaNhom", SqlDbType.Int).Value = maNhom;
                        cmd.Parameters.Add("@MaChucNang", SqlDbType.Int).Value = maChucNang;

                        return await cmd.ExecuteNonQueryAsync().ConfigureAwait(false) > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new DalException($"DAL error deleting ChiTietPhanQuyen: {sqlEx.Message}", sqlEx, sqlEx.Number);
            }
        }

        public async Task<DTO_ChiTietPhanQuyen?> GetQuyenForUserAsync(string tenDangNhap, string tenChucNang)
        {
            try
            {
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"
                SELECT p.MaNhom, p.MaChucNang, p.Xem, p.Them, p.Xoa, p.Sua
                FROM NGUOIDUNG u
                JOIN PHANQUYEN p ON u.MaNhom = p.MaNhom
                JOIN CHUCNANG c ON p.MaChucNang = c.MaChucNang
                WHERE u.TenNguoiDung = @TenNguoiDung AND c.TenManHinhDuocLoad = @TenChucNang", conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNguoiDung", tenDangNhap);
                        cmd.Parameters.AddWithValue("@TenChucNang", tenChucNang);

                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            if (await reader.ReadAsync().ConfigureAwait(false))
                            {
                                return new DTO_ChiTietPhanQuyen
                                {
                                    MaNhom = reader.GetInt32(reader.GetOrdinal("MaNhom")),
                                    MaChucNang = reader.GetInt32(reader.GetOrdinal("MaChucNang")),
                                    Xem = reader.GetBoolean(reader.GetOrdinal("Xem")),
                                    Them = reader.GetBoolean(reader.GetOrdinal("Them")),
                                    Xoa = reader.GetBoolean(reader.GetOrdinal("Xoa")),
                                    Sua = reader.GetBoolean(reader.GetOrdinal("Sua"))
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (SqlException sqlEx)
            {
                throw new DalException($"DAL error fetching user permission: {sqlEx.Message}", sqlEx, sqlEx.Number);
            }
        }

        public async Task<DataTable> GetAllQuyenForUserAsync(string TenNguoiDung)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);
                    using (var cmd = new SqlCommand(@"
                SELECT  c.TenManHinhDuocLoad, p.Xem, p.Them, p.Xoa, p.Sua
                FROM NGUOIDUNG u
                JOIN PHANQUYEN p ON u.MaNhom = p.MaNhom
                JOIN NHOMNGUOIDUNG n ON p.MaNhom = n.MaNhom
                JOIN CHUCNANG c ON p.MaChucNang = c.MaChucNang
                WHERE u.TenNguoiDung = @TenNguoiDung", conn))
                    {
                        cmd.Parameters.AddWithValue("@TenNguoiDung", TenNguoiDung);
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
                throw new DalException($"DAL error fetching all permissions for user: {sqlEx.Message}", sqlEx, sqlEx.Number);
            }

        }
    }
}
