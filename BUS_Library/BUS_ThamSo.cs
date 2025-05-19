using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;

namespace BUS_QuanLy
{
    public interface IBUS_ThamSo
    {
        Task<DTO_ThamSo> GetThamSoAsync();
        Task<float> GetTiLeDonGiaXuatAsync();
        Task<int> GetDaiLyToiDaMoiQuanAsync();
        Task<bool> ApDungQDKiemTraTienThuAsync();
        Task<bool> UpdateThamSoAsync(DTO_ThamSo thamSo);
    }



    public partial class BUS_ThamSo : IBUS_ThamSo
    {
        private readonly IDAL_ThamSo _dalThamSo;
        private readonly ILogger<BUS_ThamSo> _logger;

        public BUS_ThamSo(IDAL_ThamSo dalThamSo, ILogger<BUS_ThamSo> logger)
        {
            _dalThamSo = dalThamSo;
            _logger = logger;
        }


        //Get ThamSo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetThamSoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetThamSoAsync (Code={ErrorCode}): {ErrorMessage}")]
        private static partial void LogGetThamSoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<DTO_ThamSo> GetThamSoAsync()
        {
            try
            {
                return await _dalThamSo.GetThamSoAsyn().ConfigureAwait(false);
            }
            catch (DalException dalEx)
            {
                LogGetThamSoFailure(_logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                throw new BusException(
                        "Không lấy được các Tham số. Vui lòng thử lại sau.",
                        dalEx);
            }
        }



        //Get TiLeDonGiaXuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetTiLeXuatFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetTiLeDonGiaXuatAsync (Code={ErrorCode}): {ErrorMessage}")]
        private static partial void LogGetTiLeXuatFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<float> GetTiLeDonGiaXuatAsync()
        {
            try
            {
                return await _dalThamSo.GetTiLeDonGiaXuatAsync().ConfigureAwait(false);
            }
            catch (DalException dalEx)
            {
                LogGetTiLeXuatFailure(_logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                throw new BusException(
                        "Không lấy được Tỷ lệ đơn giá xuất. Vui lòng thử lại sau.",
                        dalEx);
            }
        }



        //Get DaiLyToiDa
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetDaiLyToiDaFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetDaiLyToiDaAsync (Code={ErrorCode}): {ErrorMessage}")]
        private static partial void LogGetDaiLyToiDaFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<int> GetDaiLyToiDaMoiQuanAsync()
        {
            try
            {
                return await _dalThamSo.GetDaiLyToiDaMoiQuanAsync().ConfigureAwait(false);
            }
            catch (DalException dalEx)
            {
                LogGetDaiLyToiDaFailure(_logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                throw new BusException(
                        "Không lấy được Đại lý tối đa mỗi quận. Vui lòng thử lại sau.",
                        dalEx);
            }
        }


        //Get ApDungQDKiemTraTienThu
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetApDungQDKiemTraTienThuFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetApDungQDKiemTraTienThuAsync (Code={ErrorCode}): {ErrorMessage}")]
        private static partial void LogGetApDungQDKiemTraTienThuFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> ApDungQDKiemTraTienThuAsync()
        {
            try
            {
                return await _dalThamSo.ApDungQDKiemTraTienThuAsync().ConfigureAwait(false);
            }
            catch (DalException dalEx)
            {
                LogGetApDungQDKiemTraTienThuFailure(_logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                throw new BusException(
                        "Không kiểm tra tiền thu. Vui lòng thử lại sau.",
                        dalEx);
            }
        }


        //Update ThamSo
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateThamSoFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateThamSoAsync (Code={ErrorCode}): {ErrorMessage}")]
        private static partial void LogUpdateThamSoFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> UpdateThamSoAsync(DTO_ThamSo thamSo)
        {
            try
            {
                return await _dalThamSo.UpdateThamSoAsync(thamSo).ConfigureAwait(false);
            }
            catch (DalException dalEx)
            {
                LogUpdateThamSoFailure(_logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                throw new BusException(
                        "Không cập nhật được Tham số. Vui lòng thử lại sau.",
                        dalEx);
            }
        }

    }
}
