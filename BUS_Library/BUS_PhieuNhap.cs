using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;

namespace BUS_QuanLy
{
    //Create inteface IBUS_PhieuNhap
    public interface IBUS_PhieuNhap
    {
        Task<List<DTO_PhieuNhap>> GetPhieuNhapListAsync();
        Task<bool> AddPhieuNhapAsync(DTO_PhieuNhap phieuNhap);
        Task<bool> UpdatePhieuNhapAsync(DTO_PhieuNhap phieuNhap);
        Task<bool> DeletePhieuNhapAsync(int maPhieuNhap);
    }
    public partial class BUS_PhieuNhap : IBUS_PhieuNhap
    {
        private readonly IDAL_PhieuNhap _dalPhieuNhap;
        private readonly ILogger<BUS_PhieuNhap> _logger;

        public BUS_PhieuNhap(IDAL_PhieuNhap dalPhieuNhap, ILogger<BUS_PhieuNhap> logger)
        {
            _dalPhieuNhap = dalPhieuNhap;
            _logger = logger;
        }


        //Get PhieuNhap List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetPhieuNhapListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetPhieuNhapListAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalGetPhieuNhapListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<List<DTO_PhieuNhap>> GetPhieuNhapListAsync()
        {
            using (_logger.BeginScope("BUS_PhieuNhap.GetPhieuNhapListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuNhap.GetPhieuNhapListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetPhieuNhapListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách phiếu nhập. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Add PhieuNhap
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddPhieuNhapFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddPhieuNhapAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddPhieuNhapFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> AddPhieuNhapAsync(DTO_PhieuNhap phieuNhap)
        {
            using (_logger.BeginScope("BUS_PhieuNhap.AddPhieuNhapAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuNhap.AddPhieuNhapAsync(phieuNhap);
                }
                catch (DalException dalEx)
                {
                    LogDalAddPhieuNhapFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được phiếu nhập. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }



        //Update PhieuNhap
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdatePhieuNhapFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdatePhieuNhapAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalUpdatePhieuNhapFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> UpdatePhieuNhapAsync(DTO_PhieuNhap phieuNhap)
        {
            using (_logger.BeginScope("BUS_PhieuNhap.UpdatePhieuNhapAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuNhap.UpdatePhieuNhapAsync(phieuNhap);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdatePhieuNhapFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không cập nhật được phiếu nhập. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Delete PhieuNhap
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeletePhieuNhapFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeletePhieuNhapAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalDeletePhieuNhapFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> DeletePhieuNhapAsync(int maPhieuNhap)
        {
            using (_logger.BeginScope("BUS_PhieuNhap.DeletePhieuNhapAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalPhieuNhap.DeletePhieuNhapAsync(maPhieuNhap);
                }
                catch (DalException dalEx)
                {
                    LogDalDeletePhieuNhapFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được phiếu nhập. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }
    }
}
