using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;

namespace BUS_QuanLy
{
    public interface IBUS_PhieuThu
    {
        Task<List<DTO_PhieuThu>> GetPhieuThuListAsync();
        Task<DataTable> GetDataTablePhieuThuListAsync();
        Task<DataTable> GetDaTaTablePhieuThuByMaDLAsync(int maDaiLy);
        Task<List<DTO_PhieuThu>> GetPhieuThuCuaDaiLyListAsync(int maDaiLy);
        Task<bool> AddPhieuThuAsync(DTO_PhieuThu phieuThu);
        Task<bool> UpdatePhieuThuAsync(DTO_PhieuThu phieuThu);
        Task<bool> DeletePhieuThuAsync(int maPhieuThu);
    }
    public partial class BUS_PhieuThu : IBUS_PhieuThu
    {
        private readonly IDAL_PhieuThu _dalPhieuThu;
        private readonly ILogger<BUS_PhieuThu> _logger;
        public BUS_PhieuThu(IDAL_PhieuThu dalPhieuThu, ILogger<BUS_PhieuThu> logger) 
        {
            _dalPhieuThu = dalPhieuThu;
            _logger = logger;
        }


        //Get PhieuThu List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetPhieuThuListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetPhieuThuListAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetPhieuThuListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<List<DTO_PhieuThu>> GetPhieuThuListAsync()
        {
            using (_logger.BeginScope("BUS_PhieuThu.GetPhieuThuListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuThu.GetAllPhieuThuListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetPhieuThuListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách phiếu thu! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

        //Get DataTable PhieuThu List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetDataTablePhieuThuListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetDataTablePhieuThuListAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetDataTablePhieuThuListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DataTable> GetDataTablePhieuThuListAsync()
        {
            using (_logger.BeginScope("BUS_PhieuThu.GetDataTablePhieuThuListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuThu.GetDataTablePhieuThuListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetDataTablePhieuThuListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách phiếu thu! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Get DataTable PhieuThu by MaDaiLy
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetDataTablePhieuThuByMaDLFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetDaTaTablePhieuThuByMaDLAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetDataTablePhieuThuByMaDLFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DataTable> GetDaTaTablePhieuThuByMaDLAsync(int maDaiLy)
        {
            using (_logger.BeginScope("BUS_PhieuThu.GetDaTaTablePhieuThuByMaDLAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuThu.GetDaTaTablePhieuThuByMaDLAsync(maDaiLy);
                }
                catch (DalException dalEx)
                {
                    LogDalGetDataTablePhieuThuByMaDLFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách phiếu thu của đại lý! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }



        //Get PhieuThu DaiLy List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetPhieuThuCuaDaiLyListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetPhieuThuCuaDaiLyListAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetPhieuThuCuaDaiLyListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<List<DTO_PhieuThu>> GetPhieuThuCuaDaiLyListAsync(int maDaiLy)
        {
            using (_logger.BeginScope("BUS_PhieuThu.GetPhieuThuCuaDaiLyListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuThu.GetAllPhieuThuCuaDaiLyListAsync(maDaiLy);
                }
                catch (DalException dalEx)
                {
                    LogDalGetPhieuThuCuaDaiLyListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách phiếu thu của đại lý! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Add PhieuThu
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddPhieuThuFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddPhieuThuAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddPhieuThuFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddPhieuThuAsync(DTO_PhieuThu phieuThu)
        {
            using (_logger.BeginScope("BUS_PhieuThu.AddPhieuThuAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuThu.AddPhieuThuAsync(phieuThu);
                }
                catch (DalException dalEx)
                {
                    LogDalAddPhieuThuFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không thêm được phiếu thu! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

        //Update PhieuThu
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdatePhieuThuFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdatePhieuThuAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalUpdatePhieuThuFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> UpdatePhieuThuAsync(DTO_PhieuThu phieuThu)
        {
            using (_logger.BeginScope("BUS_PhieuThu.UpdatePhieuThuAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuThu.UpdatePhieuThuAsync(phieuThu);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdatePhieuThuFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không sửa được phiếu thu! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Delete PhieuThu
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeletePhieuThuFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeletePhieuThuAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalDeletePhieuThuFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> DeletePhieuThuAsync(int maPhieuThu)
        {
            using (_logger.BeginScope("BUS_PhieuThu.DeletePhieuThuAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuThu.DeletePhieuThuAsync(maPhieuThu);
                }
                catch (DalException dalEx)
                {
                    LogDalDeletePhieuThuFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không xóa được phiếu thu! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }
    }
}
