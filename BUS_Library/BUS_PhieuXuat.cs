using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;

namespace BUS_QuanLy
{
    //Create interface BUS_PhieuXuat
    public interface IBUS_PhieuXuat
    {
        Task<List<DTO_PhieuXuat>> GetPhieuXuatListAsync();
        Task<List<DTO_PhieuXuatDaiLy>> GetPhieuXuatCuaDaiLyListAsync(int maDaiLy);
        Task<bool> AddPhieuXuatAsync(DTO_PhieuXuat phieuXuat);
        Task<bool> AddPhieuXuatDefaultAsync(int maDaiLy, DateTime ngayLapPhieu);
        Task<bool> UpdatePhieuXuatAsync(DTO_PhieuXuat phieuXuat);
        Task<bool> DeletePhieuXuatAsync(int maPhieuXuat);
    }
    public partial class BUS_PhieuXuat : IBUS_PhieuXuat
    {
        private readonly IDAL_PhieuXuat _dalPhieuXuat;
        private readonly ILogger<BUS_PhieuXuat> _logger;

        public BUS_PhieuXuat(IDAL_PhieuXuat dalPhieuXuat, ILogger<BUS_PhieuXuat> logger)
        {
            _dalPhieuXuat = dalPhieuXuat;
            _logger = logger;
        }

        //Get PhieuXuat List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetPhieuXuatListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetPhieuXuatListAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalGetPhieuXuatListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<List<DTO_PhieuXuat>> GetPhieuXuatListAsync()
        {
            using (_logger.BeginScope("BUS_PhieuXuat.GetPhieuXuatListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuXuat.GetPhieuXuatListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetPhieuXuatListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Get PhieuXuat Cua DaiLy List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetPhieuXuatListByDaiLyFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetPhieuXuatCuaDaiLyListAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalGetPhieuXuatListByDaiLyFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<List<DTO_PhieuXuatDaiLy>> GetPhieuXuatCuaDaiLyListAsync(int maDaiLy)
        {
            using (_logger.BeginScope("BUS_PhieuXuat.GetPhieuXuatCuaDaiLyListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuXuat.GetPhieuXuatCuaDaiLyListAsync(maDaiLy);
                }
                catch (DalException dalEx)
                {
                    LogDalGetPhieuXuatListByDaiLyFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách phiếu xuất của đại lý. Vui lòng thử lại sau.",
                        dalEx);
                }
            }

        }


        //Add PhieuXuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddPhieuXuatFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddPhieuXuatAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalAddPhieuXuatFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> AddPhieuXuatAsync(DTO_PhieuXuat phieuXuat)
        {
            using (_logger.BeginScope("BUS_PhieuXuat.AddPhieuXuatAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuXuat.AddPhieuXuatAsync(phieuXuat);
                }
                catch (DalException dalEx)
                {
                    LogDalAddPhieuXuatFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

        //Add PhieuXuat Default
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddPhieuXuatDefaultFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddPhieuXuatDefaultAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddPhieuXuatDefaultFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddPhieuXuatDefaultAsync(int maDaiLy, DateTime ngayLapPhieu)
        {
            using (_logger.BeginScope("BUS_PhieuXuat.AddPhieuXuatDefaultAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuXuat.AddPhieuXuatDefaultAsync(maDaiLy, ngayLapPhieu);
                }
                catch (DalException dalEx)
                {
                    LogDalAddPhieuXuatDefaultFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }



        //Update PhieuXuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdatePhieuXuatFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdatePhieuXuatAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalUpdatePhieuXuatFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> UpdatePhieuXuatAsync(DTO_PhieuXuat phieuXuat)
        {
            using (_logger.BeginScope("BUS_PhieuXuat.UpdatePhieuXuatAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuXuat.UpdatePhieuXuatAsync(phieuXuat);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdatePhieuXuatFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không cập nhật được phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Delete PhieuXuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeletePhieuXuatFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeletePhieuXuatAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalDeletePhieuXuatFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> DeletePhieuXuatAsync(int maPhieuXuat)
        {
            using (_logger.BeginScope("BUS_PhieuXuat.DeletePhieuXuatAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuXuat.DeletePhieuXuatAsync(maPhieuXuat);
                }
                catch (DalException dalEx)
                {
                    LogDalDeletePhieuXuatFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

    }
}
