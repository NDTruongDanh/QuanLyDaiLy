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
        Task<float> GetTiLeDonGiaXuatAsync();
        Task<int> GetDaiLyToiDaMoiQuanAsync();
        Task<bool> ApDungQDKiemTraTienThuAsync();
        Task<bool> UpdateThamSoAsync(DTO_ThamSo thamSo);
    }



    public class BUS_ThamSo : IBUS_ThamSo
    {
        private readonly IDAL_ThamSo _dalThamSo;
        private readonly ILogger<BUS_ThamSo> _logger;

        public BUS_ThamSo(IDAL_ThamSo dalThamSo, ILogger<BUS_ThamSo> logger)
        {
            _dalThamSo = dalThamSo;
            _logger = logger;
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










    }
    {
        DAL_ThamSo dalThamSo = new DAL_ThamSo();

        // Lấy tất cả tham số
        public DataTable GetThamSo()
        {
            return dalThamSo.GetAllThamSo();
        }

        // Thêm tham số
        public bool ThemThamSo(DTO_ThamSo thamSo)
        {
            return dalThamSo.ThemThamSo(thamSo);
        }

        // Sửa tham số
        public bool SuaThamSo(DTO_ThamSo thamSo)
        {
            return dalThamSo.SuaThamSo(thamSo);
        }

        // Xóa tham số
        public bool XoaThamSo(string tenThamSo)
        {
            return dalThamSo.XoaThamSo(tenThamSo);
        }
    }
}
