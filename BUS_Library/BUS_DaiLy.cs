using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BUS_QuanLy
{
    public interface IBUS_DaiLy
    {
        Task<List<DTO_DaiLy>> GetDaiLyListAsync();
        Task<bool> AddDaiLyAsync(DTO_DaiLy daiLy);
        Task<bool> UpdateDaiLyAsync(DTO_DaiLy daiLy);
        Task<bool> UpdateTongNoSauKhiXuatHangAsync(int maDaiLy, decimal conLai);
        Task<bool> DeleteDaiLyAsync(int maDaiLy);
   
    }

    public partial class BUS_DaiLy : IBUS_DaiLy
    {
        private readonly IDAL_DaiLy _dalDaiLy;
        private readonly ILogger<BUS_DaiLy> _logger;

        public BUS_DaiLy(IDAL_DaiLy dalDaiLy, ILogger<BUS_DaiLy> logger)
        {
            _dalDaiLy = dalDaiLy;
            _logger = logger;
        }


        //Get DaiLy List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetDaiLyListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetDaiLyListAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalGetDaiLyListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<List<DTO_DaiLy>> GetDaiLyListAsync()
        {
            using (_logger.BeginScope("BUS_DaiLy.GetDaiLyListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalDaiLy.GetDaiLyListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetDaiLyListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách đại lý. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

        // Add DaiLy
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddDaiLyFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddDaiLyAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalAddDaiLyFailure(
            ILogger logger, int ErrorCode, string ErrorMessage, Exception ex);

        public async Task<bool> AddDaiLyAsync(DTO_DaiLy daiLy)
        {
            using (_logger.BeginScope("BUS_DaiLy.AddDaiLyAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalDaiLy.AddDaiLyAsync(daiLy);
                }
                catch (DalException dalEx)
                {
                    LogDalAddDaiLyFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                            "Không thêm được Đại lý. Vui lòng kiểm tra và thử lại",
                            dalEx);
                }
            }              
        }

        // Update DaiLy
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateDaiLyFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateDaiLyAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalUpdateDaiLyFailure(
            ILogger logger, int ErrorCode, string ErrorMessage, Exception ex);

        public async Task<bool> UpdateDaiLyAsync(DTO_DaiLy daiLy)
        {
            using (_logger.BeginScope("BUS_DaiLy.UpdateDaiLyAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalDaiLy.UpdateDaiLyAsync(daiLy);

                }
                catch (DalException dalEx)
                {
                    LogDalUpdateDaiLyFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                            "Không sửa được Đại lý. Vui lòng kiểm tra và thử lại",
                            dalEx);

                }
            }    
        }


        // Update TongNo sau khi xuất hàng
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateDaiLySauXuatHangFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateTongNoSauKhiXuatHangAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalUpdateTongNoSauXuatHangFailure(
            ILogger logger, int ErrorCode, string ErrorMessage, Exception ex);

        public async Task<bool> UpdateTongNoSauKhiXuatHangAsync(int maDaiLy, decimal conLai)
        {
            using (_logger.BeginScope("BUS_DaiLy.UpdateTongNoSauKhiXuatHangAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalDaiLy.UpdateTongNoSauKhiXuatHangAsync(maDaiLy, conLai);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdateTongNoSauXuatHangFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    //Uer friendly message
                    throw new BusException(
                        "Không cập nhật được tổng nợ của đại lý sau khi xuất hàng. Vui lòng kiểm tra và thử lại",
                        dalEx);
                }
            }     
        }

        //Delete DaiLy
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteDaiLyFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteDaiLyAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalDeleteDaiLyFailure(
            ILogger logger, int ErrorCode, string ErrorMessage, Exception ex);

        public async Task<bool> DeleteDaiLyAsync(int maDaiLy)
        {
            using (_logger.BeginScope("BUS_DaiLy.DeleteDaiLyAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalDaiLy.DeleteDailyAsync(maDaiLy);

                }
                catch (DalException dalEx)
                {
                    LogDalDeleteDaiLyFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được đại lý. Vui lòng kiểm tra và thử lại",
                        dalEx);
                }
            }          
        }
    }
}
