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

            while (true) // Bắt đầu vòng lặp quản lý ứng dụng
            {
                // Hiển thị form Login. ShowDialog() sẽ block cho đến khi form Login được đóng.
                DialogResult loginResult = loginForm.ShowDialog();

                if (loginResult == DialogResult.OK && loginForm.LoggedInUser != null)
                {
                    // Đăng nhập thành công, tạo và hiển thị form Menu
                    // Sử dụng using để đảm bảo form Menu được giải phóng bộ nhớ sau khi đóng
                    using (var menuForm = ActivatorUtilities.CreateInstance<Menu>(serviceProvider, loginForm.LoggedInUser))
                    {
                        // Ẩn form Login đi thay vì đóng nó
                        loginForm.Hide();

                        // Hiển thị form Menu. Dòng này cũng sẽ block cho đến khi Menu đóng.
                        menuForm.ShowDialog();

                        // >>> SAU KHI MENU ĐÓNG, CODE SẼ TIẾP TỤC TỪ ĐÂY <<<
                    }

                    // Sau khi form Menu đóng, chúng ta không làm gì cả, 
                    // vòng lặp while sẽ quay lại từ đầu và hiển thị lại form Login.
                }
                else
                {
                    // Nếu đăng nhập thất bại hoặc người dùng đóng form Login,
                    // thoát khỏi vòng lặp để kết thúc ứng dụng.
                    break;
                }
            }
        }
    }
}
