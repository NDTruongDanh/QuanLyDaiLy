using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BUS_QuanLy
{
    //Create interface IBUS_BaoCaoDoanhSo
    public interface IBUS_BaoCaoDoanhSo
    {
        Task<List<DTO_BaoCaoDoanhSo>> GetBaoCaoDoanhSoListAsync();
        Task<DTO_BaoCaoDoanhSo> GetBaoCaoDoanhSoByTimeAsync(int thang, int nam);
        Task<bool> AddBaoCaoDoanhSoAsync(DTO_BaoCaoDoanhSo baoCao);
        Task<bool> AddBaoCaoDoanhSoByTimeAsync(int thang, int nam);
        Task<bool> AddBaoCaoDoanhSoAutoAsync(int thang, int nam);
        Task<bool> UpdateBaoCaoDoanhSoAsync(DTO_BaoCaoDoanhSo baoCao);
        Task<bool> DeleteBaoCaoDoanhSoAsync(int maBaoCaoDoanhSo);
    }
    public partial class BUS_BaoCaoDoanhSo : IBUS_BaoCaoDoanhSo
    {
        private readonly IDAL_BaoCaoDoanhSo _dalBaoCaoDoanhSo;
        private readonly ILogger<BUS_BaoCaoDoanhSo> _logger;
        public BUS_BaoCaoDoanhSo(IDAL_BaoCaoDoanhSo dalBaoCaoDoanhSo, ILogger<BUS_BaoCaoDoanhSo> logger)
        {
            _dalBaoCaoDoanhSo = dalBaoCaoDoanhSo;
            _logger = logger;
        }

        //Get BaoCaoDoanhSo List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetAllBaoCaoDoanhSoListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetBaoCaoDoanhSoListAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetBaoCaoDoanhSoListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<List<DTO_BaoCaoDoanhSo>> GetBaoCaoDoanhSoListAsync()
        {
            using (_logger.BeginScope("BUS_BaoCaoDoanhSo.GetBaoCaoDoanhSoListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoDoanhSo.GetBaoCaoDoanhSoListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetBaoCaoDoanhSoListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách báo cáo doanh số. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Get BaoCaoDoanhSo By Time
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetBaoCaoDoanhSoListByTimeFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetBaoCaoDoanhSoByTimeAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetBaoCaoDoanhSoByTimeFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DTO_BaoCaoDoanhSo> GetBaoCaoDoanhSoByTimeAsync(int thang, int nam)
        {
            using (_logger.BeginScope("BUS_BaoCaoDoanhSo.GetBaoCaoDoanhSoByTimeAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoDoanhSo.GetBaoCaoDoanhSoByTimeAsync(thang, nam);
                }
                catch (DalException dalEx)
                {
                    LogDalGetBaoCaoDoanhSoByTimeFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách báo cáo doanh số theo thời gian. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Add BaoCaoDoanhSo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddBaoCaoDoanhSoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddBaoCaoDoanhSoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddBaoCaoDoanhSoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddBaoCaoDoanhSoAsync(DTO_BaoCaoDoanhSo baoCao)
        {
            using (_logger.BeginScope("BUS_BaoCaoDoanhSo.AddBaoCaoDoanhSoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoDoanhSo.AddBaoCaoDoanhSoAsync(baoCao);
                }
                catch (DalException dalEx)
                {
                    LogDalAddBaoCaoDoanhSoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được báo cáo doanh số. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Add BaoCaoDoanhSo by Time
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddBaoCaoDoanhSoByTimeFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddBaoCaoDoanhSoByTimeAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddBaoCaoDoanhSoByTimeFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);


        public async Task<bool> AddBaoCaoDoanhSoByTimeAsync(int thang, int nam)
        {
            using (_logger.BeginScope("BUS_BaoCaoDoanhSo.AddBaoCaoDoanhSoByTimeAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    if (await _dalBaoCaoDoanhSo.IsExistedBaoCaoAsync(thang, nam))
                        throw new BusException("Báo cáo đã tồn tại!");

                    return await _dalBaoCaoDoanhSo.AddBaoCaoDoanhSoByTimeAsync(thang, nam);
                }
                catch (DalException dalEx)
                {
                    LogDalAddBaoCaoDoanhSoByTimeFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được báo cáo doanh số theo thời gian. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Add BaoCaoDoanhSo Auto
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddBaoCaoDoanhSoAutoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddBaoCaoDoanhSoAutoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddBaoCaoDoanhSoAutoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddBaoCaoDoanhSoAutoAsync(int thang, int nam)
        {
            using (_logger.BeginScope("BUS_BaoCaoDoanhSo.AddAddBaoCaoDoanhSoAutoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    if (await _dalBaoCaoDoanhSo.IsExistedBaoCaoAsync(thang, nam))
                        return false;
                    return await _dalBaoCaoDoanhSo.AddBaoCaoDoanhSoByTimeAsync(thang, nam);
                }
                catch (DalException dalEx)
                {
                    LogDalAddBaoCaoDoanhSoAutoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được báo cáo doanh số tự động. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Update BaoCaoDoanhSo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateBaoCaoDoanhSoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateBaoCaoDoanhSoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalUpdateBaoCaoDoanhSoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> UpdateBaoCaoDoanhSoAsync(DTO_BaoCaoDoanhSo baoCao)
        {
            using (_logger.BeginScope("BUS_BaoCaoDoanhSo.UpdateBaoCaoDoanhSoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoDoanhSo.UpdateBaoCaoDoanhSoAsync(baoCao);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdateBaoCaoDoanhSoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không cập nhật được báo cáo doanh số. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Delete BaoCaoDoanhSo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteBaoCaoDoanhSoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteBaoCaoDoanhSoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalDeleteBaoCaoDoanhSoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> DeleteBaoCaoDoanhSoAsync(int maBaoCaoDoanhSo)
        {
            using (_logger.BeginScope("BUS_BaoCaoDoanhSo.DeleteBaoCaoDoanhSoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalBaoCaoDoanhSo.DeleteBaoCaoDoanhSoAsync(maBaoCaoDoanhSo);
                }
                catch (DalException dalEx)
                {
                    LogDalDeleteBaoCaoDoanhSoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được báo cáo doanh số. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }
    }
}
