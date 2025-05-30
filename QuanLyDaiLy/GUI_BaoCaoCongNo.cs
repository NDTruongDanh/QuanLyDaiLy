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
using System.Windows.Forms.DataVisualization.Charting;


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

                LoadBarChartFromDataGridView();
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

        private void LoadBarChartFromDataGridView()
        {
            // Lấy DataTable từ BindingSource, đây là nguồn dữ liệu đáng tin cậy.
            if (_bindingSource.DataSource is not DataTable dataTable)
            {
                // Nếu không có dữ liệu hoặc kiểu dữ liệu không đúng thì không làm gì cả.
                return;
            }

            // --- Cấu hình biểu đồ ---
            pcThongKeCongNo.Series.Clear();
            pcThongKeCongNo.Titles.Clear();
            pcThongKeCongNo.Titles.Add("Thống Kê Công Nợ Cuối Kỳ");

            var series = new Series("CongNoCuoi")
            {
                ChartType = SeriesChartType.Column, // Biểu đồ cột
                IsValueShownAsLabel = true,         // Hiển thị giá trị trên cột
                LabelFormat = "N0"                  // Định dạng số hàng nghìn
            };

            // --- Lấy dữ liệu và chỉ hiển thị Top 10 (Tùy chọn, nhưng được khuyến khích) ---
            var congNoData = new List<KeyValuePair<string, decimal>>();

            foreach (DataRow row in dataTable.Rows)
            {
                // Dùng TryParse để chuyển đổi an toàn
                if (decimal.TryParse(row["NoCuoi"]?.ToString(), out decimal noCuoi))
                {
                    string tenDaiLy = row["TenDaiLy"]?.ToString() ?? "Không tên";
                    congNoData.Add(new KeyValuePair<string, decimal>(tenDaiLy, noCuoi));
                }
            }

            // Sắp xếp và chỉ lấy 10 đại lý có nợ cuối cao nhất
            var top10Data = congNoData.OrderByDescending(kvp => kvp.Value).Take(10).ToList();

            // Thêm các điểm dữ liệu vào series
            foreach (var dataPoint in top10Data)
            {
                series.Points.AddXY(dataPoint.Key, dataPoint.Value);
            }

            // Thêm series vào biểu đồ
            pcThongKeCongNo.Series.Add(series);

            // Xoay nhãn trục X nếu cần để tránh chồng chéo
            pcThongKeCongNo.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            pcThongKeCongNo.ChartAreas[0].AxisX.Interval = 1;

            pcThongKeCongNo.ChartAreas[0].AxisY.Title = "Công nợ (VND)";
            pcThongKeCongNo.Legends.Clear();
        }

    }
}



