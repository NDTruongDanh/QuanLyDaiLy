using DAL_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace BUS_Library
{
    public interface IBUS_ChiTietPhanQuyen
    {
        Task<DataTable> GetDataTableCTPhanQuyenAsync();
        Task<bool> AddCTPhanQuyenAsync(DTO_ChiTietPhanQuyen ctPhanQuyen);
        Task<bool> UpdateCTPhanQuyenAsync(DTO_ChiTietPhanQuyen ctPhanQuyen);
        Task<bool> DeleteCTPhanQuyenAsync(int maNhom, int maChucNang);
    }

    public partial class BUS_ChiTietPhanQuyen : IBUS_ChiTietPhanQuyen
    {
        private readonly IDAL_ChiTietPhanQuyen _dalCTPhanQuyen;
        private readonly ILogger<BUS_ChiTietPhanQuyen> _logger;

        public BUS_ChiTietPhanQuyen(IDAL_ChiTietPhanQuyen dalCTPhanQuyen, ILogger<BUS_ChiTietPhanQuyen> logger)
        {
            _dalCTPhanQuyen = dalCTPhanQuyen;
            _logger = logger;
        }


        // Lấy DataTable chi tiết phân quyền
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetDataTableCTPhanQuyenFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetDataTableCTPhanQuyenAsync (Code={ErrorCode}): {ErrorMessage}")]
        private static partial void LogGetDataTableCTPhanQuyenFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DataTable> GetDataTableCTPhanQuyenAsync()
        {
            using (_logger.BeginScope("BUS_ChiTietPhanQuyen.GetDataTableCTPhanQuyenAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalCTPhanQuyen.GetDataTableCTPhanQuyenAsync().ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogGetDataTableCTPhanQuyenFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    throw new BusException(
                        "Không lấy được dữ liệu chi tiết phân quyền. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        // Thêm chi tiết phân quyền
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddCTPhanQuyenFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddCTPhanQuyenAsync (Code={ErrorCode}): {ErrorMessage}")]
        private static partial void LogAddCTPhanQuyenFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddCTPhanQuyenAsync(DTO_ChiTietPhanQuyen ctPhanQuyen)
        {
            using (_logger.BeginScope("BUS_ChiTietPhanQuyen.AddCTPhanQuyenAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalCTPhanQuyen.AddCTPhanQuyenAsync(ctPhanQuyen).ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogAddCTPhanQuyenFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    throw new BusException(
                        "Không thể thêm chi tiết phân quyền. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }



        // Cập nhật chi tiết phân quyền
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateCTPhanQuyenFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateCTPhanQuyenAsync (Code={ErrorCode}): {ErrorMessage}")]
        private static partial void LogUpdateCTPhanQuyenFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> UpdateCTPhanQuyenAsync(DTO_ChiTietPhanQuyen ctPhanQuyen)
        {
            using (_logger.BeginScope("BUS_ChiTietPhanQuyen.UpdateCTPhanQuyenAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalCTPhanQuyen.UpdateCTPhanQuyenAsync(ctPhanQuyen).ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogUpdateCTPhanQuyenFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    throw new BusException(
                        "Không thể cập nhật chi tiết phân quyền. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        // Xóa chi tiết phân quyền
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteCTPhanQuyenFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteCTPhanQuyenAsync (Code={ErrorCode}): {ErrorMessage}")]
        private static partial void LogDeleteCTPhanQuyenFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> DeleteCTPhanQuyenAsync(int maNhom, int maChucNang)
        {
            using (_logger.BeginScope("BUS_ChiTietPhanQuyen.DeleteCTPhanQuyenAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalCTPhanQuyen.DeleteCTPhanQuyenAsync(maNhom, maChucNang).ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDeleteCTPhanQuyenFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    throw new BusException(
                        "Không thể xóa chi tiết phân quyền. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }

    }
}
