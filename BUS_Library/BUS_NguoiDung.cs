using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;
namespace BUS_Library
{
    public interface IBUS_NguoiDung
    {
        Task<List<DTO_NguoiDung>> GetNguoiDungListAsync();
        Task<DataTable> GetDataTableNguoiDungListAsync();
        Task<DTO_NguoiDung> GetNguoiDungAsync(string tenNguoiDung, string matKhau);
        Task<DataTable> GetDataTableNguoiDungAsync(string tenNguoiDung, string matKhau);
        Task<bool> AddNguoiDungAsync(DTO_NguoiDung nhomNguoiDung);
        Task<bool> UpdateNguoiDungAsync(DTO_NguoiDung nhomNguoiDung);
        Task<bool> DeleteNguoiDungAsync(string tenNguoiDung);
    }
    public partial class BUS_NguoiDung : IBUS_NguoiDung
    {
        private readonly IDAL_NguoiDung _dalNguoiDung;
        private readonly ILogger<BUS_NguoiDung> _logger;

        public BUS_NguoiDung(IDAL_NguoiDung dalNguoiDung, ILogger<BUS_NguoiDung> logger)
        {
            _dalNguoiDung = dalNguoiDung;
            _logger = logger;
        }


        //Get Nguoi Dung List
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetNguoiDungListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetNguoiDungListAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetNguoiDungListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<List<DTO_NguoiDung>> GetNguoiDungListAsync()
        {
            using (_logger.BeginScope("BUS_NguoiDung.GetNguoiDungListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalNguoiDung.GetNguoiDungListAsync().ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDalGetNguoiDungListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Lỗi khi lấy danh sách người dùng. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", dalEx);
                }
            }
        }



        //Get DataTable Nguoi Dung
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetDataTableNguoiDungListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetDataTableNguoiDungListAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetDataTableNguoiDungFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DataTable> GetDataTableNguoiDungListAsync()
        {
            using (_logger.BeginScope("BUS_NguoiDung.GetDataTableNguoiDungAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalNguoiDung.GetDataTableNguoiDungListAsync().ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDalGetDataTableNguoiDungFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Lỗi khi lấy bảng dữ liệu người dùng. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", dalEx);
                }
            }
        }



        //Get Nguoi Dung
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetNguoiDungFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetNguoiDungAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetNguoiDungFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DTO_NguoiDung> GetNguoiDungAsync(string tenNguoiDung, string matKhau)
        {
            using (_logger.BeginScope("BUS_NguoiDung.GetNguoiDungAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalNguoiDung.GetNguoiDungAsync(tenNguoiDung, matKhau).ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDalGetNguoiDungFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Lỗi khi lấy thông tin người dùng. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", dalEx);
                }
            }
        }



        //Get DataTable Nguoi Dung by Ten Nguoi Dung and Mat Khau
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetDataTableNguoiDungByTenMatKhauFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetDataTableNguoiDungAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalGetDataTableNguoiDungByTenMatKhauFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<DataTable> GetDataTableNguoiDungAsync(string tenNguoiDung, string matKhau)
        {
            using (_logger.BeginScope("BUS_NguoiDung.GetDataTableNguoiDungAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalNguoiDung.GetDataTableNguoiDungAsync(tenNguoiDung, matKhau).ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDalGetDataTableNguoiDungByTenMatKhauFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Lỗi khi lấy bảng dữ liệu người dùng theo tên và mật khẩu. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", dalEx);
                }
            }
        }





        //Add Nguoi Dung
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddNguoiDungFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddNguoiDungAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddNguoiDungFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddNguoiDungAsync(DTO_NguoiDung nhomNguoiDung)
        {
            using (_logger.BeginScope("BUS_NguoiDung.AddNguoiDungAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalNguoiDung.AddNguoiDungAsync(nhomNguoiDung).ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDalAddNguoiDungFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Lỗi khi thêm người dùng. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", dalEx);
                }
            }
        }

        //Update Nguoi Dung
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateNguoiDungFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateNguoiDungAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalUpdateNguoiDungFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> UpdateNguoiDungAsync(DTO_NguoiDung nhomNguoiDung)
        {
            using (_logger.BeginScope("BUS_NguoiDung.UpdateNguoiDungAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalNguoiDung.UpdateNguoiDungAsync(nhomNguoiDung).ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdateNguoiDungFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Lỗi khi cập nhật người dùng. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", dalEx);
                }
            }
        }

        //Delete Nguoi Dung
        //Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteNguoiDungFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteNguoiDungAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalDeleteNguoiDungFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> DeleteNguoiDungAsync(string tenNguoiDung)
        {
            using (_logger.BeginScope("BUS_NguoiDung.DeleteNguoiDungAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalNguoiDung.DeleteNguoiDungAsync(tenNguoiDung).ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDalDeleteNguoiDungFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Lỗi khi xóa người dùng. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", dalEx);
                }
            }
        }
    }
}
