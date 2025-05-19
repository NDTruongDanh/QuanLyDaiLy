using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


namespace GUI_QuanLy.AddedClasses
{
    public static class RegisterGUI
    {
        public static IServiceCollection AddGUI(this IServiceCollection services)
        {
            services.AddTransient<GUI_DaiLy>();
            services.AddTransient<GUI_DonViTinh>();
            services.AddTransient<GUI_LoaiDaiLy>();
            services.AddTransient<GUI_MatHang>();
            services.AddTransient<GUI_PhieuNhap>();
            services.AddTransient<GUI_PhieuXuat>();
            services.AddTransient<GUI_Quan>();
            services.AddTransient<GUI_ChiTietPhieuNhap>();
            services.AddTransient<GUI_ChiTietPhieuXuat>();
            services.AddTransient<GUI_BaoCaoDoanhSo>();
            services.AddTransient<GUI_BaoCaoCongNo>();
            services.AddTransient<GUI_PhieuThu>();
            //services.AddTransient<GUI_ChiTietBaoCaoDoanhSo>();
            services.AddTransient<Menu>();
            services.AddTransient<GUI_ThamSo>();
            return services;
        }
    }
}
