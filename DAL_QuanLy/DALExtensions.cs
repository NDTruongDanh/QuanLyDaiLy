using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QuanLy
{
    public static class DALExtensions
    {
        public static IServiceCollection AddDALDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDAL_LoaiDaiLy, DAL_LoaiDaiLy>();
            services.AddScoped<IDAL_Quan, DAL_Quan>();
            services.AddScoped<IDAL_DaiLy, DAL_DaiLy>();
            services.AddScoped<IDAL_DonViTinh, DAL_DonViTinh>();
            services.AddScoped<IDAL_MatHang, DAL_MatHang>();
            services.AddScoped<IDAL_PhieuXuat, DAL_PhieuXuat>();
            services.AddScoped<IDAL_ChiTietPhieuXuat, DAL_ChiTietPhieuXuat>();
            services.AddScoped<IDAL_PhieuNhap, DAL_PhieuNhap>();
            services.AddScoped<IDAL_ChiTietPhieuNhap, DAL_ChiTietPhieuNhap>();
            services.AddScoped<IDAL_PhieuThu, DAL_PhieuThu>();
            services.AddScoped<IDAL_BaoCaoDoanhSo, DAL_BaoCaoDoanhSo>();
            services.AddScoped<IDAL_ChiTietBaoCaoDoanhSo, DAL_ChiTietBaoCaoDoanhSo>();
            services.AddScoped<IDAL_BaoCaoCongNo, DAL_BaoCaoCongNo>();
            services.AddScoped<IDAL_ThamSo, DAL_ThamSo>();

            return services;
        }
    }
}
