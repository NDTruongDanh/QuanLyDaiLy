using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using DAL_QuanLy;
namespace BUS_Library
{
    public interface IBUS_NhomNguoiDung
    {
        Task<List<DTO_NhomNguoiDung>> GetNhomNguoiDungListAsync();
        Task<bool> AddNhomNguoiDungAsync(DTO_NhomNguoiDung nhomNguoiDung);
        Task<bool> UpdateNhomNguoiDungAsync(DTO_NhomNguoiDung nhomNguoiDung);
        Task<bool> DeleteNhomNguoiDungAsync(int maNhom);
    }

    public partial class BUS_NhomNguoiDung : IBUS_NhomNguoiDung
    {
        private readonly IDAL_NhomNguoiDung _dalNhomNguoiDung;
        private readonly ILogger<BUS_NhomNguoiDung> _logger;

        public BUS_NhomNguoiDung(IDAL_NhomNguoiDung dalNhomNguoiDung, ILogger<BUS_NhomNguoiDung> logger)
        {
            _dalNhomNguoiDung = dalNhomNguoiDung;
            _logger = logger;
        }


        //Get Nhom Nguoi Dung List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetNhomNguoiDungListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetNhomNguoiDungListAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalGetNhomNguoiDungListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<List<DTO_NhomNguoiDung>> GetNhomNguoiDungListAsync()
        {
            using (_logger.BeginScope("BUS_NhomNguoiDung.GetNhomNguoiDungListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalNhomNguoiDung.GetNhomNguoiDungListAsync().ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDalGetNhomNguoiDungListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách Nhóm người dùng! Vui lòng thử lại sau!",
                        dalEx);
                }
            }
        }


        //Add Nhom Nguoi Dung
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddNhomNguoiDungFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddNhomNguoiDungAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalAddNhomNguoiDungFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> AddNhomNguoiDungAsync(DTO_NhomNguoiDung nhomNguoiDung)
        {
            using (_logger.BeginScope("BUS_NhomNguoiDung.AddNhomNguoiDungAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalNhomNguoiDung.AddNhomNguoiDungAsync(nhomNguoiDung).ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDalAddNhomNguoiDungFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không thể thêm Nhóm người dùng! Vui lòng thử lại sau!",
                        dalEx);
                }
            }
        }


        //Update Nhom Nguoi Dung
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateNhomNguoiDungFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateNhomNguoiDungAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalUpdateNhomNguoiDungFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> UpdateNhomNguoiDungAsync(DTO_NhomNguoiDung nhomNguoiDung)
        {
            using (_logger.BeginScope("BUS_NhomNguoiDung.UpdateNhomNguoiDungAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalNhomNguoiDung.UpdateNhomNguoiDungAsync(nhomNguoiDung).ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdateNhomNguoiDungFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không thể cập nhật Nhóm người dùng! Vui lòng thử lại sau!",
                        dalEx);
                }
            }
        }



        //Delete Nhom Nguoi Dung
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteNhomNguoiDungFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteNhomNguoiDungAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalDeleteNhomNguoiDungFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> DeleteNhomNguoiDungAsync(int maNhom)
        {
            using (_logger.BeginScope("BUS_NhomNguoiDung.DeleteNhomNguoiDungAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalNhomNguoiDung.DeleteNhomNguoiDungAsync(maNhom).ConfigureAwait(false);
                }
                catch (DalException dalEx)
                {
                    LogDalDeleteNhomNguoiDungFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);
                    // user-friendly message
                    throw new BusException(
                        "Không thể xóa Nhóm người dùng! Vui lòng thử lại sau!",
                        dalEx);
                }
            }
        }



    }
}
