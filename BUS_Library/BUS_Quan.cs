using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;

namespace BUS_QuanLy
{
    public interface IBUS_Quan
    {
        Task<List<DTO_Quan>> GetQuanListAsync();
        Task<bool> AddQuanAsync(DTO_Quan quan);
        Task<bool> UpdateQuanAsync(DTO_Quan quan);
        Task<bool> DeleteQuanAsync(int maQuan);
    }


    public partial class BUS_Quan : IBUS_Quan
    {
        private readonly IDAL_Quan _dalQuan;
        private readonly ILogger<BUS_Quan> _logger;
        public BUS_Quan(IDAL_Quan dalQuan, ILogger<BUS_Quan> logger)
        {
            _dalQuan = dalQuan;
            _logger = logger;
        }

        //Get Quan List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetQuanListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetQuanListAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalGetQuanListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<List<DTO_Quan>> GetQuanListAsync()
        {
            using (_logger.BeginScope("BUS_Quan.GetQuanListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalQuan.GetQuanListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetQuanListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách quận. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
            
        }

        // Add Quan
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddQuanFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddQuanAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddQuanFailure(
            ILogger logger, int ErrorCode, string ErrorMessage, Exception ex);

        public async Task<bool> AddQuanAsync(DTO_Quan quan)
        {
            using (_logger.BeginScope("BUS_Quan.AddQuanAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalQuan.AddQuanAsync(quan);
                }
                catch (DalException dalEx)
                {
                    LogDalAddQuanFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được quận. Vui lòng kiểm tra và thử lại",
                        dalEx);
                }
            }
                
        }

        // Update Quan
        [LoggerMessage(
            EventId = MyLogEvents.UpdateQuanFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateQuanAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalUpdateQuanFailure(
             ILogger logger,
             int ErrorCode,
             string ErrorMessage,
             Exception ex);
            
        public async Task<bool> UpdateQuanAsync(DTO_Quan quan)
        {
            using (_logger.BeginScope("BUS_Quan.UpdateQuanAsync at time {Time}", DateTime.UtcNow))
                try
                {
                    return await _dalQuan.UpdateQuanAsync(quan);

                }
                catch (DalException dalEx)
                {
                    LogDalUpdateQuanFailure(
                            _logger,
                            dalEx.ErrorCode,
                            dalEx.Message,
                            dalEx);
                    // user-friendly message

                    throw new BusException(
                        "Không sửa được quận. Vui lòng kiểm tra và thử lại",
                        dalEx);
                }
        }

        // Delete Quan
        [LoggerMessage(
            EventId = MyLogEvents.DeleteQuanFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteQuanAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalDeleteQuanFailure(
             ILogger logger,
             int ErrorCode,
             string ErrorMessage,
             Exception ex);

        public async Task<bool> DeleteQuanAsync(int maQuan)
        {
            using (_logger.BeginScope("BUS_Quan.DeleteQuanAsync at time {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalQuan.DeleteQuanAsync(maQuan);
                }
                catch (DalException dalEx)
                {
                    LogDalDeleteQuanFailure(
                            _logger,
                            dalEx.ErrorCode,
                            dalEx.Message,
                            dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được quận. Vui lòng kiểm tra và thử lại",
                        dalEx);
                }
            }
        }
    }
}
