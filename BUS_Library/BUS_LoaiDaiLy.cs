using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Data;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;
using System.ComponentModel.DataAnnotations;
using BUS_Library;
using Microsoft.IdentityModel.Protocols.Configuration;

namespace BUS_QuanLy
{
    public interface IBUS_LoaiDaiLy
    {
        Task<List<DTO_LoaiDaiLy>> GetLoaiDaiLyListAsync();
        Task<bool> AddLoaiDaiLyAsync(DTO_LoaiDaiLy loaiDaiLy);
        Task<bool> UpdateLoaiDaiLyAsync(DTO_LoaiDaiLy loaiDaiLy);
        Task<bool> DeleteLoaiDaiLyAsync(int maLoaiDaiLy);
    }

    public partial class BUS_LoaiDaiLy : IBUS_LoaiDaiLy
    {
        private readonly IDAL_LoaiDaiLy _dalLoaiDaiLy;
        private readonly ILogger<BUS_LoaiDaiLy> _logger;

        public BUS_LoaiDaiLy(IDAL_LoaiDaiLy dal, ILogger<BUS_LoaiDaiLy> logger)
        {
            _dalLoaiDaiLy = dal;
            _logger = logger;
        }

        //Get LoaiDaiLy List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetLoaiDaiLyListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetLoaiDaiLyListAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalGetLoaiDaiLyListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<List<DTO_LoaiDaiLy>> GetLoaiDaiLyListAsync()
        {
            using (_logger.BeginScope("BUS_LoaiDaiLy.GetLoaiDaiLyListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalLoaiDaiLy.GetLoaiDaiLyListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetLoaiDaiLyListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách Loại đại lý. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

        // Add LoaiDaiLy
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddLoaiDaiLyFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddLoaiDaiLyAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddLoaiDaiLyFailure(
            ILogger logger, int ErrorCode, string ErrorMessage, Exception ex);

        public async Task<bool> AddLoaiDaiLyAsync(DTO_LoaiDaiLy loaiDaiLy)
        {
            using (_logger.BeginScope("BUS_LoaiDaiLy.AddLoaiDaiLyAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalLoaiDaiLy.AddLoaiDaiLyAsync(loaiDaiLy);
                }
                catch (DalException dalEx)
                {
                    LogDalAddLoaiDaiLyFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được Loại đại lý. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        // Update LoaiDaiLy
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateLoaiDaiLyFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateLoaiDaiLyAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalUpdateLoaiDaiLyFailure(
            ILogger logger, int ErrorCode, string ErrorMessage, Exception ex);

        public async Task<bool> UpdateLoaiDaiLyAsync(DTO_LoaiDaiLy loaiDaiLy)
        {
            using (_logger.BeginScope("BUS_LoaiDaiLy.UpdateLoaiDaiLyAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalLoaiDaiLy.UpdateLoaiDaiLyAsync(loaiDaiLy);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdateLoaiDaiLyFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không sửa được Loại đại lý. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }
        // Delete LoaiDaiLy
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteLoaiDaiLyFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteLoaiDaiLyAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalDeleteLoaiDaiLyFailure(
            ILogger logger, int ErrorCode, string ErrorMessage, Exception ex);

        public async Task<bool> DeleteLoaiDaiLyAsync(int maLoaiDaiLy)
        {
            using (_logger.BeginScope("BUS_LoaiDaiLy.DeleteLoaiDaiLyAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalLoaiDaiLy.DeleteLoaiDaiLyAsync(maLoaiDaiLy);
                }
                catch (DalException dalEx)
                {
                    LogDalDeleteLoaiDaiLyFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được Loại đại lý. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }
    }
}
