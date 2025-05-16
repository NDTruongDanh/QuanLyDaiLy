using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;

namespace BUS_QuanLy
{
    //Create interface for BUS_DonViTinh
    public interface IBUS_DonViTinh
    {
        Task<List<DTO_DonViTinh>> GetDonViTinhListAsync();
        Task<bool> AddDonViTinhAsync(DTO_DonViTinh donViTinh);
        Task<bool> UpdateDonViTinhAsync(DTO_DonViTinh donViTinh);
        Task<bool> DeleteDonViTinhAsync(int maDonViTinh);
    }

    public partial class BUS_DonViTinh : IBUS_DonViTinh
    {
        private readonly IDAL_DonViTinh _dalDonViTinh;
        private readonly ILogger<BUS_DonViTinh> _logger;

        public BUS_DonViTinh(IDAL_DonViTinh dalDonViTinh, ILogger<BUS_DonViTinh> logger)
        {
            _dalDonViTinh = dalDonViTinh;
            _logger = logger;
        }

        //Get DonViTinh List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetDonViTinhListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetDonViTinhListAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalGetDonViTinhListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<List<DTO_DonViTinh>> GetDonViTinhListAsync()
        {
            using (_logger.BeginScope("BUS_DonViTinh.GetDonViTinhListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalDonViTinh.GetDonViTinhListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetDonViTinhListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách đơn vị tính. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Add DonViTinh
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddDonViTinhFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddDonViTinhAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalAddDonViTinhFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> AddDonViTinhAsync(DTO_DonViTinh donViTinh)
        {
            using (_logger.BeginScope("BUS_DonViTinh.AddDonViTinhAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalDonViTinh.AddDonViTinhAsync(donViTinh);
                }
                catch (DalException dalEx)
                {
                    LogDalAddDonViTinhFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được đơn vị tính. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Update DonViTinh
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateDonViTinhFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateDonViTinhAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalUpdateDonViTinhFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> UpdateDonViTinhAsync(DTO_DonViTinh donViTinh)
        {
            using (_logger.BeginScope("BUS_DonViTinh.UpdateDonViTinhAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalDonViTinh.UpdateDonViTinhAsync(donViTinh);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdateDonViTinhFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không sửa được đơn vị tính. Vui lòng thử lại sau.",
                        dalEx);
                }

            }
        }


        //Delete DonViTinh
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteDonViTinhFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteDonViTinhAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalDeleteDonViTinhFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> DeleteDonViTinhAsync(int maDonViTinh)
        {
            using (_logger.BeginScope("BUS_DonViTinh.DeleteDonViTinhAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalDonViTinh.DeleteDonViTinhAsync(maDonViTinh);
                }
                catch (DalException dalEx)
                {
                    LogDalDeleteDonViTinhFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được đơn vị tính. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }
    }
}
