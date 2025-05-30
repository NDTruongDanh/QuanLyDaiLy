using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;

namespace BUS_QuanLy
{
    //Create interface IBUS_ChiTietBaoCaoDoanhSo
    public interface IBUS_ChiTietBaoCaoDoanhSo
    {
        Task<List<DTO_ChiTietBaoCaoDoanhSo>> GetChiTietBaoCaoDoanhSoListAsync();
        Task<List<DTO_ChiTietBaoCaoDoanhSo>> GetChiTietBaoCaoDoanhSoByMaBaoCaoListAsync(int maBaoCaoDoanhSo);
        Task<DataTable> GetDataTableChiTietBaoCaoDoanhSoListByMaBaoCaoAsync(int maBaoCaoDoanhSo);
        Task<bool> AddChiTietBaoCaoDoanhSoAsync(DTO_ChiTietBaoCaoDoanhSo chiTietBaoCao);
        Task<bool> AddChiTietBaoCaoDoanhSoAuToAsync(DTO_BaoCaoDoanhSo baoCaoDoanhSo);
        Task<bool> UpdateChiTietBaoCaoDoanhSoAsync(DTO_ChiTietBaoCaoDoanhSo chiTietBaoCao);
        Task<bool> DeleteChiTietBaoCaoDoanhSoAsync(int maBaoCao, int maDaiLy);
    }

    public partial class BUS_ChiTietBaoCaoDoanhSo : IBUS_ChiTietBaoCaoDoanhSo
    {
        private readonly IDAL_ChiTietBaoCaoDoanhSo _dalChiTietBaoCaoDoanhSo;
        private readonly ILogger<BUS_ChiTietBaoCaoDoanhSo> _logger;

        public BUS_ChiTietBaoCaoDoanhSo(IDAL_ChiTietBaoCaoDoanhSo dalChiTietBaoCaoDoanhSo, ILogger<BUS_ChiTietBaoCaoDoanhSo> logger)
        {
            _dalChiTietBaoCaoDoanhSo = dalChiTietBaoCaoDoanhSo;
            _logger = logger;
        }


        //Get ChiTietBaoCaoDoanhSo List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetChiTietBaoCaoDoanhSoListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetChiTietBaoCaoDoanhSoListAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetChiTietBaoCaoDoanhSoListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<List<DTO_ChiTietBaoCaoDoanhSo>> GetChiTietBaoCaoDoanhSoListAsync()
        {
            using (_logger.BeginScope("BUS_ChiTietBaoCaoDoanhSo.GetChiTietBaoCaoDoanhSoListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietBaoCaoDoanhSo.GetChiTietBaoCaoDoanhSoListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetChiTietBaoCaoDoanhSoListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách chi tiết báo cáo doanh số. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Get ChiTietBaoCaoDoanhSo By MaBaoCao List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetChiTietBaoCaoDoanhSoByMaBaoCaoListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetChiTietBaoCaoDoanhSoByMaBaoCaoListAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetChiTietBaoCaoDoanhSoByMaBaoCaoListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<List<DTO_ChiTietBaoCaoDoanhSo>> GetChiTietBaoCaoDoanhSoByMaBaoCaoListAsync(int maBaoCaoDoanhSo)
        {
            using (_logger.BeginScope("BUS_ChiTietBaoCaoDoanhSo.GetChiTietBaoCaoDoanhSoByMaBaoCaoListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietBaoCaoDoanhSo.GetChiTietBaoCaoDoanhSoByMaBaoCaoListAsync(maBaoCaoDoanhSo);
                }
                catch (DalException dalEx)
                {
                    LogDalGetChiTietBaoCaoDoanhSoByMaBaoCaoListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách chi tiết báo cáo doanh số theo mã báo cáo. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

        //Get DataTable ChiTietBaoCaoDoanhSo By MaBaoCao
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetDataTableChiTietBaoCaoDoanhSoByMaBaoCaoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetDataTableChiTietBaoCaoDoanhSoListByMaBaoCaoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetDataTableChiTietBaoCaoDoanhSoByMaBaoCaoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DataTable> GetDataTableChiTietBaoCaoDoanhSoListByMaBaoCaoAsync(int maBaoCaoDoanhSo)
        {
            using (_logger.BeginScope("BUS_ChiTietBaoCaoDoanhSo.GetDataTableChiTietBaoCaoDoanhSoListByMaBaoCaoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietBaoCaoDoanhSo.GetDataTableChiTietBaoCaoDoanhSoListByMaBaoCaoAsync(maBaoCaoDoanhSo);
                }
                catch (DalException dalEx)
                {
                    LogDalGetDataTableChiTietBaoCaoDoanhSoByMaBaoCaoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được bảng chi tiết báo cáo doanh số theo mã báo cáo. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }




        //Add ChiTietBaoCaoDoanhSo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddChiTietBaoCaoDoanhSoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddChiTietBaoCaoDoanhSoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddChiTietBaoCaoDoanhSoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddChiTietBaoCaoDoanhSoAsync(DTO_ChiTietBaoCaoDoanhSo chiTietBaoCao)
        {
            using (_logger.BeginScope("BUS_ChiTietBaoCaoDoanhSo.AddChiTietBaoCaoDoanhSoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietBaoCaoDoanhSo.AddChiTietBaoCaoDoanhSoAsync(chiTietBaoCao);
                }
                catch (DalException dalEx)
                {
                    LogDalAddChiTietBaoCaoDoanhSoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được chi tiết báo cáo doanh số. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Add ChiTietBaoCaoDoanhSo Auto
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddChiTietBaoCaoDoanhSoAutoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddChiTietBaoCaoDoanhSoAutoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddChiTietBaoCaoDoanhSoAutoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddChiTietBaoCaoDoanhSoAuToAsync(DTO_BaoCaoDoanhSo baoCaoDoanhSo)
        {
            using (_logger.BeginScope("BUS_ChiTietBaoCaoDoanhSo.AddChiTietBaoCaoDoanhSoAuToAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    if (await _dalChiTietBaoCaoDoanhSo.IsExistedChiTietBaoCaoDoanhSoAsync(baoCaoDoanhSo))
                    {
                        return false;
                    }
                    return await _dalChiTietBaoCaoDoanhSo.AddChiTietBaoCaoDoanhSoAuToAsync(baoCaoDoanhSo);
                }
                catch (DalException dalEx)
                {
                    LogDalAddChiTietBaoCaoDoanhSoAutoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được chi tiết báo cáo doanh số tự động. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Update ChiTietBaoCaoDoanhSo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateChiTietBaoCaoDoanhSoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateChiTietBaoCaoDoanhSoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalUpdateChiTietBaoCaoDoanhSoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> UpdateChiTietBaoCaoDoanhSoAsync(DTO_ChiTietBaoCaoDoanhSo chiTietBaoCao)
        {
            using (_logger.BeginScope("BUS_ChiTietBaoCaoDoanhSo.UpdateChiTietBaoCaoDoanhSoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietBaoCaoDoanhSo.UpdateChiTietBaoCaoDoanhSoAsync(chiTietBaoCao);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdateChiTietBaoCaoDoanhSoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không cập nhật được chi tiết báo cáo doanh số. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Delete ChiTietBaoCaoDoanhSo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteChiTietBaoCaoDoanhSoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteChiTietBaoCaoDoanhSoAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalDeleteChiTietBaoCaoDoanhSoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> DeleteChiTietBaoCaoDoanhSoAsync(int maBaoCaoDoanhSo, int maDaiLy)
        {
            using (_logger.BeginScope("BUS_ChiTietBaoCaoDoanhSo.DeleteChiTietBaoCaoDoanhSoAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietBaoCaoDoanhSo.DeleteChiTietBaoCaoDoanhSoAsync(maBaoCaoDoanhSo, maDaiLy);
                }
                catch (DalException dalEx)
                {
                    LogDalDeleteChiTietBaoCaoDoanhSoFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được chi tiết báo cáo doanh số. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }
    }
}
