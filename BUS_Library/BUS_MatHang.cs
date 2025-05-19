using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;

namespace BUS_QuanLy
{
    public interface IBUS_MatHang
    {
        Task<List<DTO_MatHang>> GetMatHangListAsync();
        Task<DataTable> GetMatHangForNhapAsync();
        Task<DataTable> GetMatHangForXuatAsync();
        Task<bool> AddMatHangAsync(DTO_MatHang matHang);
        Task<bool> AddMatHangDefault(string tenMatHang, int maDonViTinh);
        Task<bool> UpdateMatHangAsync(DTO_MatHang matHang);
        Task<bool> DeleteMatHangAsync(int maMatHang);

    }
    public partial class BUS_MatHang : IBUS_MatHang
    {
        private readonly IDAL_MatHang _dalMatHang;
        private readonly ILogger<BUS_MatHang> _logger;

        public BUS_MatHang(IDAL_MatHang dalMatHang, ILogger<BUS_MatHang> logger)
        {
            _dalMatHang = dalMatHang;
            _logger = logger;
        }


        //Get MatHang List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetMatHangListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetMatHangListAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalGetMatHangListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<List<DTO_MatHang>> GetMatHangListAsync()
        {
            using (_logger.BeginScope("BUS_MatHang.GetMatHangListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalMatHang.GetMatHangListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetMatHangListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách mặt hàng. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }



        //Get MatHang For NhapXuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetMatHangForNhapFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetMatHangForNhapXuatAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetMatHangForNhapXuatFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DataTable> GetMatHangForNhapAsync()
        {
            using (_logger.BeginScope("BUS_MatHang.GetMatHangForNhapXuatAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalMatHang.GetMatHangForNhapAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetMatHangForNhapXuatFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách mặt hàng. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }





        //Get MatHang For Xuat
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetMatHangForXuatFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetMatHangForXuatAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetMatHangForXuatFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DataTable> GetMatHangForXuatAsync()
        {
            using (_logger.BeginScope("BUS_MatHang.GetMatHangForXuatAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalMatHang.GetMatHangForXuatAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetMatHangForXuatFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách mặt hàng. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }





        //Add MatHang
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddMatHangFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddMatHangAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalAddMatHangFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> AddMatHangAsync(DTO_MatHang matHang)
        {
            using (_logger.BeginScope("BUS_MatHang.AddMatHangAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalMatHang.AddMatHangAsync(matHang);
                }
                catch (DalException dalEx)
                {
                    LogDalAddMatHangFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được mặt hàng. Vui lòng thử lại sau.",
                        dalEx);
                }

            }

        }


        //Add MatHang Default
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddMatHangDefaultFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddMatHangDefaultAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddMatHangDefaultFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddMatHangDefault(string tenMatHang, int maDonViTinh)
        {
            using (_logger.BeginScope("BUS_MatHang.AddMatHangDefault at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalMatHang.AddMatHangDefault(tenMatHang, maDonViTinh);
                }
                catch (DalException dalEx)
                {
                    LogDalAddMatHangDefaultFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được mặt hàng. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Update MatHang
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateMatHangFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateMatHangAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalUpdateMatHangFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> UpdateMatHangAsync(DTO_MatHang matHang)
        {
            using (_logger.BeginScope("BUS_MatHang.AddMatHangAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalMatHang.UpdateMatHangAsync(matHang);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdateMatHangFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không cập nhật được mặt hàng. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

        //Delete MatHang
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteMatHangFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteMatHangAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void DeleteMatHangFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> DeleteMatHangAsync(int maMatHang)
        {
            using (_logger.BeginScope("BUS_MatHang.DeleteMatHangAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalMatHang.DeleteMatHangAsync(maMatHang);
                }
                catch (DalException dalEx)
                {
                    DeleteMatHangFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được mặt hàng. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }
    }
}
