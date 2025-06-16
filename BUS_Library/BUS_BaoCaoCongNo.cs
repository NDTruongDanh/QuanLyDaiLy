using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;

namespace BUS_QuanLy
{
    //Create interface for BaoCaoCongNo
    public interface IBUS_BaoCaoCongNo
    {
        Task<List<DTO_BaoCaoCongNo>> GetAllBaoCaoCongNoAsync();
        Task<DTO_BaoCaoCongNo> GetBaoCaoCongNoByThangAsync(int thang, int nam);
        Task<DataTable> GetDataTableBaoCaoCongNoAsync(int thang, int nam);
        Task<bool> AddBaoCaoCongNoAsync(DTO_BaoCaoCongNo baoCaoCongNo);
        Task<bool> AddBaoCaoCongNoByTimeAsync(int thang, int nam);
        Task<bool> UpdateBaoCaoCongNoAsync(DTO_BaoCaoCongNo baoCaoCongNo);
        Task<bool> DeleteBaoCaoCongNoAsync(int thang, int nam);
        Task<bool> IsExistedBaoCaoAsync(int thang, int nam);

    }
    public partial class BUS_BaoCaoCongNo : IBUS_BaoCaoCongNo
    {
        private readonly IDAL_BaoCaoCongNo _dalBaoCaoCongNo;
        private readonly ILogger<BUS_BaoCaoCongNo> _logger;

        public BUS_BaoCaoCongNo(IDAL_BaoCaoCongNo dalBaoCaoCongNo, ILogger<BUS_BaoCaoCongNo> logger)
        {
            _dalBaoCaoCongNo = dalBaoCaoCongNo;
            _logger = logger;
        }


        //Get all BaoCaoCongNo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetAllBaoCaoCongNoListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetBaoCaoCongNoListAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetAllBaoCaoCongNoListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<List<DTO_BaoCaoCongNo>> GetAllBaoCaoCongNoAsync()
        {
            using (_logger.BeginScope("BUS_BaoCaoCongNo.GetAllBaoCaoCongNoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoCongNo.GetAllBaoCaoCongNoAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetAllBaoCaoCongNoListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách tất cả Báo cáo Công nợ! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Get BaoCaoCongNo by Time
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetBaoCaoCongNoListByThangFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetBaoCaoCongNoByThangAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetBaoCaoCongNoListByThangFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DTO_BaoCaoCongNo> GetBaoCaoCongNoByThangAsync(int thang, int nam)
        {
            using (_logger.BeginScope("BUS_BaoCaoCongNo.GetBaoCaoCongNoByThangAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoCongNo.GetBaoCaoCongNoByThangAsync(thang, nam);
                }
                catch (DalException dalEx)
                {
                    LogDalGetBaoCaoCongNoListByThangFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách Báo cáo Công nợ theo tháng! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }



        //Get BaoCaoCongNo by Time
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetBaoCaoCongNoDataTableByThangFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetBaoCaoCongNoDataTableByThangAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetBaoCaoCongNoDataTableByThangFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DataTable> GetDataTableBaoCaoCongNoAsync(int thang, int nam)
        {
            using (_logger.BeginScope("BUS_BaoCaoCongNo.GetDataTableBaoCaoCongNoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoCongNo.GetDataTableBaoCaoCongNoAsync(thang, nam);
                }
                catch (DalException dalEx)
                {
                    LogDalGetBaoCaoCongNoDataTableByThangFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được bảng Báo cáo Công nợ theo tháng! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }




        //Add BaoCaoCongNo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddBaoCaoCongNoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddBaoCaoCongNoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddBaoCaoCongNoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddBaoCaoCongNoAsync(DTO_BaoCaoCongNo baoCaoCongNo)
        {
            using (_logger.BeginScope("BUS_BaoCaoCongNo.AddBaoCaoCongNoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoCongNo.AddBaoCaoCongNoAsync(baoCaoCongNo);
                }
                catch (DalException dalEx)
                {
                    LogDalAddBaoCaoCongNoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được Báo cáo Công nợ! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

        //Add BaoCaoCongNo by Time
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddBaoCaoCongNoByTimeFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddBaoCaoCongNoByTimeAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddBaoCaoCongNoByTimeFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> AddBaoCaoCongNoByTimeAsync(int thang, int nam)
        {
            using (_logger.BeginScope("BUS_BaoCaoCongNo.AddBaoCaoCongNoByTimeAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoCongNo.AddBaoCaoCongNoByTimeAsync(thang, nam);
                }
                catch (DalException dalEx)
                {
                    LogDalAddBaoCaoCongNoByTimeFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        $"Không tự động thêm Báo cáo Công nợ cho {thang}/{nam}! Vui lòng thử lại hoặc liên hệ để được hỗ trợ!",
                        dalEx);
                }
            }
        }


        //Update BaoCaoCongNo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateBaoCaoCongNoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateBaoCaoCongNoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalUpdateBaoCaoCongNoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> UpdateBaoCaoCongNoAsync(DTO_BaoCaoCongNo baoCaoCongNo)
        {
            using (_logger.BeginScope("BUS_BaoCaoCongNo.UpdateBaoCaoCongNoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoCongNo.UpdateBaoCaoCongNoAsync(baoCaoCongNo);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdateBaoCaoCongNoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không cập nhật được Báo cáo Công nợ! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Delete BaoCaoCongNo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteBaoCaoCongNoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteBaoCaoCongNoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalDeleteBaoCaoCongNoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> DeleteBaoCaoCongNoAsync(int thang, int nam)
        {
            using (_logger.BeginScope("BUS_BaoCaoCongNo.DeleteBaoCaoCongNoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoCongNo.DeleteBaoCaoCongNoAsync(thang, nam);
                }
                catch (DalException dalEx)
                {
                    LogDalDeleteBaoCaoCongNoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được Báo cáo Công nợ! Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

        //Check if BaoCaoCongNo is existed
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.IsExistedBaoCaoCongNoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in IsExistedBaoCaoCongNoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalIsExistedBaoCaoCongNoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> IsExistedBaoCaoAsync(int thang, int nam)
        {
            using (_logger.BeginScope("BUS_BaoCaoCongNo.IsExistedBaoCaoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoCongNo.IsExistedBaoCaoAsync(thang, nam);
                }
                catch (DalException dalEx)
                {
                    LogDalIsExistedBaoCaoCongNoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không kiểm tra được Báo cáo Công nợ! Vui lòng thử lại sau.",
                        dalEx);
                }
            }

        }
    }
}
