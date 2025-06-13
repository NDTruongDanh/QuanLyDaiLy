using BUS_Library;
using BUS_QuanLy;
using DAL_QuanLy;
using GUI_QuanLy;
using GUI_QuanLy.AddedClasses;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;
using DTO_QuanLy;

namespace QuanLyDaiLy
{
    internal static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main()
        {
            AllocConsole();
            ApplicationConfiguration.Initialize();

            var host = Host.CreateDefaultBuilder()
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                    logging.SetMinimumLevel(LogLevel.Debug);
                })
                .ConfigureServices((_, services) =>
                {
                    services.AddDALDependencies()
                            .AddBUSDependencies()
                            .AddGUI();
                })
                .Build();

            using var scope = host.Services.CreateScope();
            var serviceProvider = scope.ServiceProvider;

            // Lấy Login form từ DI
            var loginForm = serviceProvider.GetRequiredService<Login>();
            if (loginForm.ShowDialog() == DialogResult.OK && loginForm.LoggedInUser != null)
            {
                // Đăng nhập thành công, truyền user vào Menu
                var menuForm = ActivatorUtilities.CreateInstance<Menu>(serviceProvider, loginForm.LoggedInUser);
                Application.Run((Form)menuForm);
            }
            else
            {
                // Đăng nhập thất bại hoặc bị đóng
                Application.Exit();
            }
        }
    }
}
