using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using DAL_QuanLy;

namespace BUS_Library
{
    public interface IBUS_ChucNang
    {
        Task<List<DTO_ChucNang>> GetChucNangListAsync();

    }
    public partial class BUS_ChucNang : IBUS_ChucNang
    {
        private readonly IDAL_ChucNang _dalChucNang;
        private readonly ILogger<BUS_ChucNang> _logger;

        public BUS_ChucNang(IDAL_ChucNang dalChucNang, ILogger<BUS_ChucNang> logger)
        {
            _dalChucNang = dalChucNang;
            _logger = logger;
        }


        //Get danh sách chức năng
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
           EventId = MyLogEvents.GetChucNangListFailure,
           Level = LogLevel.Error,
           Message = "DAL failure in GetNguoiDungListAsync (Code={ErrorCode}): {ErrorMessage}")]
        private static partial void LogGetChucNangListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<List<DTO_ChucNang>> GetChucNangListAsync()
        {
            using (_logger.BeginScope("BUS_ChucNang.GetChucNangListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChucNang.GetChucNangListAsync().ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogGetChucNangListFailure(
                            _logger,
                            dalEx.ErrorCode,
                            dalEx.Message,
                            dalEx);

                    throw new BusException(
                            "Không lấy được danh sách chức năng. Vui lòng thử lại sau.",
                            dalEx);
                }
            }
        }
    }
}
