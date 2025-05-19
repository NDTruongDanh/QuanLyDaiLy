using BUS_QuanLy;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Library
{
    public static class BUSExtensions
    {
        public static IServiceCollection AddBUSDependencies(this IServiceCollection services)
        {
            services.AddLogging();

            services.AddScoped<IBUS_LoaiDaiLy, BUS_LoaiDaiLy>();
            services.AddScoped<IBUS_Quan, BUS_Quan>();
            services.AddScoped<IBUS_DaiLy, BUS_DaiLy>();
            services.AddScoped<IBUS_DonViTinh, BUS_DonViTinh>();
            services.AddScoped<IBUS_MatHang, BUS_MatHang>();
            services.AddScoped<IBUS_PhieuXuat, BUS_PhieuXuat>();
            services.AddScoped<IBUS_ChiTietPhieuXuat, BUS_ChiTietPhieuXuat>();
            services.AddScoped<IBUS_PhieuNhap, BUS_PhieuNhap>();
            services.AddScoped<IBUS_ChiTietPhieuNhap, BUS_ChiTietPhieuNhap>();
            services.AddScoped<IBUS_BaoCaoDoanhSo, BUS_BaoCaoDoanhSo>();
            services.AddScoped<IBUS_ChiTietBaoCaoDoanhSo, BUS_ChiTietBaoCaoDoanhSo>();
            services.AddScoped<IBUS_BaoCaoCongNo, BUS_BaoCaoCongNo>();
            services.AddScoped<IBUS_PhieuThu, BUS_PhieuThu>();
            services.AddScoped<IBUS_ThamSo, BUS_ThamSo>();

            return services;
        }
    }
}
