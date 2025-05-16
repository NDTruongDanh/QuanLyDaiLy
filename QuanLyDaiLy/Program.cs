using BUS_Library;
using BUS_QuanLy;
using DAL_QuanLy;
using GUI_QuanLy;
using GUI_QuanLy.AddedClasses;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;

namespace QuanLyDaiLy
{
    internal static class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();


        [STAThread]
        static void Main()
        {
            AllocConsole(); // Mở console
            ApplicationConfiguration.Initialize();

            var host = Host.CreateDefaultBuilder()
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();                              // Console sink
                    logging.SetMinimumLevel(LogLevel.Debug);      // Default level
                })
                .ConfigureServices((_, services) =>
                {
                    services.AddDALDependencies()           //registers IDAL => DAL
                            .AddBUSDependencies()           //registers IBUS => BUS
                            .AddGUI();                      //register Forms
                })
                .Build();

            using var scope = host.Services.CreateScope();
            var form = scope.ServiceProvider.GetRequiredService<GUI_Admin>();
            Application.Run(form);
        }
    }
}