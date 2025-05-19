using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;

namespace BUS_QuanLy
{
    //Create interface BUS_ChiTietPhieuXuat
    public interface IBUS_ChiTietPhieuXuat
    {
        Task<List<DTO_ChiTietPhieuXuat>> GetAllChiTietPhieuXuatListAsync();
        Task<List<DTO_ChiTietPhieuXuat>> GetChiTietPhieuXuatListByMPXAsync(int maPhieuXuat);
        Task<DataTable> GetDataTableChiTietPhieuXuatAllAsync();
        Task<DataTable> GetDataTableChiTietPhieuXuatByMPXAsync(int maPhieuXuat);
        Task<bool> AddChiTietPhieuXuatAsync(DTO_ChiTietPhieuXuat chitietPhieuXuat);
        Task<bool> UpdateChiTietPhieuXuatAsync(DTO_ChiTietPhieuXuat chitietPhieuXuat);
        Task<bool> DeleteChiTietPhieuXuatAsync(int maPhieuXuat, int maMatHang);
        Task<bool> DeleteChiTietPhieuXuatByMPX(int maPhieuXuat);
    }

    public partial class BUS_ChiTietPhieuXuat : IBUS_ChiTietPhieuXuat
    {
        private readonly IDAL_ChiTietPhieuXuat _dalChiTietPhieuXuat;
        private readonly ILogger<BUS_ChiTietPhieuXuat> _logger;

        public BUS_ChiTietPhieuXuat(IDAL_ChiTietPhieuXuat dalChiTietPhieuXuat, ILogger<BUS_ChiTietPhieuXuat> logger)
        {
            _dalChiTietPhieuXuat = dalChiTietPhieuXuat;
            _logger = logger;
        }



        //Get ChiTietPhieuXuat List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetChiTietPhieuXuatListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetChiTietPhieuXuatListAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalGetChiTietPhieuXuatListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<List<DTO_ChiTietPhieuXuat>> GetAllChiTietPhieuXuatListAsync()
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuXuat.GetChiTietPhieuXuatListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuXuat.GetAllChiTietPhieuXuatListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetChiTietPhieuXuatListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách chi tiết phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }



        //Get ChiTietPhieuXuat List By MaPhieuXuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetChiTietPhieuXuatListByMPXFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetChiTietPhieuXuatListByMPXAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetChiTietPhieuXuatListByMPXFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<List<DTO_ChiTietPhieuXuat>> GetChiTietPhieuXuatListByMPXAsync(int maPhieuXuat)
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuXuat.GetChiTietPhieuXuatListByMPXAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuXuat.GetChiTietPhieuXuatListByMPXAsync(maPhieuXuat);
                }
                catch (DalException dalEx)
                {
                    LogDalGetChiTietPhieuXuatListByMPXFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách chi tiết phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }



        //Get ChiTietPhieuXuat DataTable
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetChiTietPhieuXuatDataTableFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetDataTableChiTietPhieuXuatAllAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetChiTietPhieuXuatDataTableFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DataTable> GetDataTableChiTietPhieuXuatAllAsync()
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuXuat.GetDataTableChiTietPhieuXuatAllAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuXuat.GetDataTableChiTietPhieuXuatAllAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetChiTietPhieuXuatDataTableFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách chi tiết phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }



        //Get ChiTietPhieuXuat DataTable By MaPhieuXuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetChiTietPhieuXuatDataTableByMPXFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetDataTableChiTietPhieuXuatByMPXAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetChiTietPhieuXuatDataTableByMPXFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DataTable> GetDataTableChiTietPhieuXuatByMPXAsync(int maPhieuXuat)
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuXuat.GetDataTableChiTietPhieuXuatByMPXAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuXuat.GetDataTableChiTietPhieuXuatByMPXAsync(maPhieuXuat);
                }
                catch (DalException dalEx)
                {
                    LogDalGetChiTietPhieuXuatDataTableByMPXFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách chi tiết phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }




        //Add ChiTietPhieuXuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddChiTietPhieuXuatFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddChiTietPhieuXuatAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddChiTietPhieuXuatFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddChiTietPhieuXuatAsync(DTO_ChiTietPhieuXuat chitietPhieuXuat)
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuXuat.AddChiTietPhieuXuatAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuXuat.AddChiTietPhieuXuatAsync(chitietPhieuXuat);
                }
                catch (DalException dalEx)
                {
                    LogDalAddChiTietPhieuXuatFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được chi tiết phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }



        //Update ChiTietPhieuXuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateChiTietPhieuXuatFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateChiTietPhieuXuatAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalUpdateChiTietPhieuXuatFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> UpdateChiTietPhieuXuatAsync(DTO_ChiTietPhieuXuat chitietPhieuXuat)
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuXuat.UpdateChiTietPhieuXuatAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuXuat.UpdateChiTietPhieuXuatAsync(chitietPhieuXuat);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdateChiTietPhieuXuatFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không cập nhật được chi tiết phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

        //Delete ChiTietPhieuXuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteChiTietPhieuXuatFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteChiTietPhieuXuatAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalDeleteChiTietPhieuXuatFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> DeleteChiTietPhieuXuatAsync(int maPhieuXuat, int maMatHang)
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuXuat.DeleteChiTietPhieuXuatAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuXuat.DeleteChiTietPhieuXuatAsync(maPhieuXuat, maMatHang);
                }
                catch (DalException dalEx)
                {
                    LogDalDeleteChiTietPhieuXuatFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được chi tiết phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }



        //Delete ChiTietPhieuXuat By MaPhieuXuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteChiTietPhieuXuatByMPXFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteChiTietPhieuXuatByMPX (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalDeleteChiTietPhieuXuatByMPXFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> DeleteChiTietPhieuXuatByMPX(int maPhieuXuat)
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuXuat.DeleteChiTietPhieuXuatByMPX at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuXuat.DeleteChiTietPhieuXuatByMPX(maPhieuXuat);
                }
                catch (DalException dalEx)
                {
                    LogDalDeleteChiTietPhieuXuatByMPXFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được chi tiết phiếu xuất. Vui lòng thử lại sau.",
                        dalEx);
                }
            }

        }
}
