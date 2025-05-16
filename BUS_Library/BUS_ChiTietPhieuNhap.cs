﻿using System;
using System.Data;
using BUS_Library;
using DAL_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;
namespace BUS_QuanLy
{
    //Create interface BUS_ChiTietPhieuNhap
    public interface IBUS_ChiTietPhieuNhap
    {
        Task<List<DTO_ChiTietPhieuNhap>> GetChiTietPhieuNhapListAsync();
        Task<bool> AddChiTietPhieuNhapAsync(DTO_ChiTietPhieuNhap chiTietPhieuNhap);
        Task<bool> UpdateChiTietPhieuNhapAsync(DTO_ChiTietPhieuNhap chiTietPhieuNhap);
        Task<bool> DeleteChiTietPhieuNhapAsync(int maPhieuNhap, int maMatHang);
    }
    public partial class BUS_ChiTietPhieuNhap : IBUS_ChiTietPhieuNhap
    {
        private readonly IDAL_ChiTietPhieuNhap _dalChiTietPhieuNhap;
        private readonly ILogger<BUS_ChiTietPhieuNhap> _logger;

        public BUS_ChiTietPhieuNhap(IDAL_ChiTietPhieuNhap dalChiTietPhieuNhap, ILogger<BUS_ChiTietPhieuNhap> logger)
        {
            _dalChiTietPhieuNhap = dalChiTietPhieuNhap;
            _logger = logger;
        }

        //Get ChiTietPhieuNhap List
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.GetChiTietPhieuNhapListFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in GetChiTietPhieuNhapListAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalGetChiTietPhieuNhapListFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<List<DTO_ChiTietPhieuNhap>> GetChiTietPhieuNhapListAsync()
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuNhap.GetChiTietPhieuNhapListAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuNhap.GetChiTietPhieuNhapListAsync();
                }
                catch (DalException dalEx)
                {
                    LogDalGetChiTietPhieuNhapListFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không tải được danh sách chi tiết phiếu nhập. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Add ChiTietPhieuNhap
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.AddChiTietPhieuNhapFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in AddChiTietPhieuNhapAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalAddChiTietPhieuNhapFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);

        public async Task<bool> AddChiTietPhieuNhapAsync(DTO_ChiTietPhieuNhap chiTietPhieuNhap)
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuNhap.AddChiTietPhieuNhapAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuNhap.AddChiTietPhieuNhapAsync(chiTietPhieuNhap);
                }
                catch (DalException dalEx)
                {
                    LogDalAddChiTietPhieuNhapFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không thêm được chi tiết phiếu nhập. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Update ChiTietPhieuNhap
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.UpdateChiTietPhieuNhapFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in UpdateChiTietPhieuNhapAsync (Code={ErrorCode}): {ErrorMessage}")]
        static partial void LogDalUpdateChiTietPhieuNhapFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> UpdateChiTietPhieuNhapAsync(DTO_ChiTietPhieuNhap chiTietPhieuNhap)
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuNhap.UpdateChiTietPhieuNhapAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuNhap.UpdateChiTietPhieuNhapAsync(chiTietPhieuNhap);
                }
                catch (DalException dalEx)
                {
                    LogDalUpdateChiTietPhieuNhapFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không sửa được chi tiết phiếu nhập. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }


        //Delete ChiTietPhieuNhap
        // Source-generated high-performance log for DAL failures
        [LoggerMessage(
            EventId = MyLogEvents.DeleteChiTietPhieuNhapFailure,
            Level = LogLevel.Error,
            Message = "DAL failure in DeleteChiTietPhieuNhapAsync (Code={ErrorCode}): {ErrorMessage}")]

        static partial void LogDalDeleteChiTietPhieuNhapFailure(
            ILogger logger,
            int ErrorCode,
            string ErrorMessage,
            Exception ex);
        public async Task<bool> DeleteChiTietPhieuNhapAsync(int maPhieuNhap, int maMatHang)
        {
            using (_logger.BeginScope("BUS_ChiTietPhieuNhap.DeleteChiTietPhieuNhapAsync at {Time}", DateTime.UtcNow))
            {
                try
                {
                    return await _dalChiTietPhieuNhap.DeleteChiTietPhieuNhapAsync(maPhieuNhap, maMatHang);
                }
                catch (DalException dalEx)
                {
                    LogDalDeleteChiTietPhieuNhapFailure(
                        _logger,
                        dalEx.ErrorCode,
                        dalEx.Message,
                        dalEx);

                    // user-friendly message
                    throw new BusException(
                        "Không xóa được chi tiết phiếu nhập. Vui lòng thử lại sau.",
                        dalEx);
                }
            }
        }
    }
}
