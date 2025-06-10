using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace DAL_QuanLy
{
    public interface IDAL_ChucNang
    {
        Task<List<DTO_ChucNang>> GetChucNangListAsync();
    }
    public class DAL_ChucNang : IDAL_ChucNang
    {
        private readonly string _connectionString = DBConnect.connString;

        public async Task<List<DTO_ChucNang>> GetChucNangListAsync()
        {
            try
            {
                var list = new List<DTO_ChucNang>();

                using (var conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync().ConfigureAwait(false);

                    using (var cmd = new SqlCommand("SELECT * FROM CHUCNANG", conn))
                    {
                        using (var reader = await cmd.ExecuteReaderAsync().ConfigureAwait(false))
                        {
                            while (await reader.ReadAsync())
                            {
                                int maChucNangIndex = reader.GetOrdinal("MaChucNang");
                                int tenManHinhDuocLoadIndex = reader.GetOrdinal("TenManHinhDuocLoad");

                                list.Add(new DTO_ChucNang
                                {
                                    MaChucNang = reader.GetInt32(maChucNangIndex),
                                    TenManHinhDuocLoad = reader.GetString(tenManHinhDuocLoadIndex)
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
                    $"DAL error fetching ChucNang list (DTO): {sqlEx.Message}",
                    sqlEx,
                    sqlEx.Number);
            }
        }
    }
}
