using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Library;
using BUS_QuanLy;
using Microsoft.Extensions.Logging;

namespace GUI_QuanLy
{
    public partial class GUI_BaoCaoCongNo : Form
    {
        private readonly IBUS_DaiLy _busDaiLy;
        private readonly IBUS_BaoCaoCongNo _busBaoCaoCongNo;
        private readonly ILogger _logger;
        private readonly BindingSource _bindingSource = new BindingSource();

        private int _prevMonth = 0;
        private int _prevYear = 0;

        private Dictionary<string, decimal> _congNoDictionary = [];
        public GUI_BaoCaoCongNo(IBUS_DaiLy busDaiLy, IBUS_BaoCaoCongNo busBaoCaoCongNo, ILogger<GUI_BaoCaoCongNo> logger)
        {
            _busDaiLy = busDaiLy;
            _busBaoCaoCongNo = busBaoCaoCongNo;
            _logger = logger;
            InitializeComponent();
            dgvBaoCaoCongNo.DataSource = _bindingSource;

            var now = DateTime.Now;
            var prev = new DateTime(now.Year, now.Month, 1).AddMonths(-1);

            _prevMonth = prev.Month;
            _prevYear = prev.Year;
        }


        private async void GUI_BaoCaoCongNo_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadBaoCaoCongNoAsync(_prevMonth, _prevYear);

                cmbThang.SelectedIndex = _prevMonth - 1; // Tháng 1 là index 0
                txtNam.Text = _prevYear.ToString();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form BaoCaoCongNo load");

                MessageBox.Show(
                    "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async Task LoadBaoCaoCongNoAsync(int thang, int nam)
        {
            try
            {
                if (!await CheckBaoCaoAsync())
                {
                    await TuDongTaoBaoCaoAsync();
                }

                var dataTable = await _busBaoCaoCongNo.GetDataTableBaoCaoCongNoAsync(thang, nam);
                _bindingSource.DataSource = dataTable;
                ModifyDataGridViewColumns();
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid BaoCaoCongNo: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async Task TuDongTaoBaoCaoAsync()
        {
            try
            {
                if (await _busBaoCaoCongNo.AddBaoCaoCongNoByTimeAsync(_prevMonth, _prevYear))
                {
                    MessageBox.Show($"Tự động thêm Báo cáo Công nợ cho {_prevMonth}/{_prevYear} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Tự động thêm Báo cáo Công nợ cho {_prevMonth}/{_prevYear} thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error creating BaoCaoCongNo: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async Task<bool> CheckBaoCaoAsync()
        {
            try
            {
                return await _busBaoCaoCongNo.IsExistedBaoCaoAsync(_prevMonth, _prevYear);
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error checking BaoCaoCongNo: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
        }


        private void ModifyDataGridViewColumns()
        {
            dgvBaoCaoCongNo.Columns["MaDaiLy"].HeaderText = "Mã Đại Lý";
            dgvBaoCaoCongNo.Columns["TenDaiLy"].HeaderText = "Tên Đại Lý";
            dgvBaoCaoCongNo.Columns["NoDau"].HeaderText = "Nợ Đầu";
            dgvBaoCaoCongNo.Columns["PhatSinh"].HeaderText = "Phát sinh";
            dgvBaoCaoCongNo.Columns["NoCuoi"].HeaderText = "Nợ cuối";
        }


        private void LoadDataColChart()
        {
            var series = pcThongKeCongNo.Series["Series2"];
            series.Points.Clear();



            // Màu custom (giống ảnh)
            Color[] colors = { Color.DodgerBlue };
            int i = 0;
            foreach (var item in _congNoDictionary)
            {
                int pointIdx = series.Points.AddXY(item.Key, item.Value);
                series.Points[pointIdx].Color = colors[i % colors.Length];
                i++;
            }
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = cmbThang.SelectedIndex + 1; // Tháng 1 là index 0
                int nam = int.Parse(txtNam.Text);

                await LoadBaoCaoCongNoAsync(thang, nam);
            }
            catch(Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in button Find");

                MessageBox.Show(
                    "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}



