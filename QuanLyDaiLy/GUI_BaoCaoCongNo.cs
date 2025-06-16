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
using System.Diagnostics;
using DTO_QuanLy;
using GUI_QuanLy.AddedClasses;
using Microsoft.Extensions.DependencyInjection;


namespace GUI_QuanLy
{
    public partial class GUI_BaoCaoCongNo : Form
    {
        private readonly IBUS_DaiLy _busDaiLy;
        private readonly IBUS_BaoCaoCongNo _busBaoCaoCongNo;
        private readonly ILogger _logger;
        private readonly BindingSource _bindingSource = new BindingSource();
        private readonly IServiceProvider _service;
        private int _prevMonth = 0;
        private int _prevYear = 0;
        private DTO_ChiTietPhanQuyen? permission;
        private Dictionary<string, decimal> _congNoDictionary = [];
        public GUI_BaoCaoCongNo(IBUS_DaiLy busDaiLy, IBUS_BaoCaoCongNo busBaoCaoCongNo, ILogger<GUI_BaoCaoCongNo> logger,IServiceProvider service)
        {
            _busDaiLy = busDaiLy;
            _busBaoCaoCongNo = busBaoCaoCongNo;
            _logger = logger;
            _service = service;
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
                await permissionLoadAsync();
                await LoadBaoCaoCongNoAsync(_prevMonth, _prevYear);
                LoadContent(_prevMonth, _prevYear);
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
        private async Task permissionLoadAsync()
        {
            try
            {
                var permissionService = _service.GetRequiredService<PermissionService>();


                permission = await permissionService.GetPermissionCurrentUserAsync("BaoCaoCongNo");

                if (permission == null || permission.Xem == false)
                {
                    _logger.LogWarning("No permission found for BaoCaoCongNo.");
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }





            }
            catch
            {
                _logger.LogError("Failed to load permissions for BaoCaoCongNo.");
                MessageBox.Show("Lỗi khi tải quyền truy cập. Vui lòng thử lại sau.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private async Task LoadBaoCaoCongNoAsync(int thang, int nam)
        {
            try
            {
                if (!await CheckBaoCaoAsync(thang, nam))
                {
                    await TuDongTaoBaoCaoAsync(thang, nam);
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

        private async Task TuDongTaoBaoCaoAsync(int thang, int nam)
        {
            try
            {
                if (await _busBaoCaoCongNo.AddBaoCaoCongNoByTimeAsync(thang, nam))
                {
                    MessageBox.Show($"Tự động thêm Báo cáo Công nợ cho {thang}/{nam} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Tự động thêm Báo cáo Công nợ cho {thang}/{nam} thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private async Task<bool> CheckBaoCaoAsync(int thanng, int nam)
        {
            try
            {
                return await _busBaoCaoCongNo.IsExistedBaoCaoAsync(thanng, nam);
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


        private void LoadContent(int thang, int nam)
        {
            cmbThang.SelectedIndex = thang - 1; // Tháng 1 là index 0
            txtNam.Text = nam.ToString();

            decimal totalNoDau = 0;
            decimal totalPhatSinh = 0;
            decimal totalNoCuoi = 0;

            for (int i = 0; i < dgvBaoCaoCongNo.Rows.Count; i++)
            {
                var dgvrow = dgvBaoCaoCongNo.Rows[i];

                // Parse tổng trị giá (loại bỏ ký tự tiền tệ và dấu chấm)
                string? valueStr = dgvrow.Cells["NoDau"].Value?.ToString()?.Replace("₫", "").Trim();
                if (decimal.TryParse(valueStr, out decimal value))
                    totalNoDau += value;

                valueStr = dgvrow.Cells["PhatSinh"].Value?.ToString()?.Replace("₫", "").Trim();
                if (decimal.TryParse(valueStr, out value))
                    totalPhatSinh += value;

                valueStr = dgvrow.Cells["NoCuoi"].Value?.ToString()?.Replace("₫", "").Trim();
                if (decimal.TryParse(valueStr, out value))
                    totalNoCuoi += value;

                lblTongNoCuoiKy_num.Text = totalNoCuoi.ToString("N0") + " ₫";
                lblTongNoDauKy_num.Text = totalNoDau.ToString("N0") + " ₫";
                lblTongPhatSinh_num.Text = totalPhatSinh.ToString("N0") + " ₫";
            }

        }


        private async void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = cmbThang.SelectedIndex + 1; // Tháng 1 là index 0
                int nam = int.Parse(txtNam.Text);


                DateTime userInputDate = new DateTime(nam, thang, 1);
                DateTime currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                if (userInputDate > currentDate)
                {
                    MessageBox.Show("Bạn không thể xem báo cáo công nợ trong tương lai.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (userInputDate == currentDate)
                {
                    MessageBox.Show("Bạn không thể xem báo cáo công nợ vì hiện tại chưa hết tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await LoadBaoCaoCongNoAsync(thang, nam);
                LoadContent(thang, nam);
            }
            catch (Exception ex)
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
            // Kiểm tra nguồn dữ liệu  
            if (_bindingSource.DataSource == null || !(_bindingSource.DataSource is DataTable dataTable))
            {
                pcThongKeCongNo.Series.Clear();
                pcThongKeCongNo.Titles.Clear();
                pcThongKeCongNo.ChartAreas.Clear();
                pcThongKeCongNo.Legends.Clear();
                pcThongKeCongNo.Invalidate();
                return;
            }


            // --- Xóa sạch và Cấu hình biểu đồ cơ bản ---  
            pcThongKeCongNo.Series.Clear();
            pcThongKeCongNo.Titles.Clear();
            pcThongKeCongNo.ChartAreas.Clear();
            pcThongKeCongNo.Legends.Clear();
            pcThongKeCongNo.Titles.Add("Top 10 Giá Trị Nợ Cuối Kỳ Cao Nhất");
            var chartArea = new ChartArea("MainChartArea");
            chartArea.AxisX.Title = "Tên Đại Lý";
            chartArea.AxisY.Title = "Công nợ cuối kỳ (VND)";
            chartArea.AxisX.Interval = 1;

            pcThongKeCongNo.ChartAreas.Add(chartArea);
            //chartArea.AxisX.StripLines.Clear();

            // --- Lấy và xử lý dữ liệu công nợ từ DataTable ---  
            var congNoDataList = new List<KeyValuePair<string, decimal>>();
            int daiLyIndex = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                if (dataTable.Columns.Contains("TenDaiLy") && dataTable.Columns.Contains("NoCuoi"))
                {
                    string tenDaiLyValue = row["TenDaiLy"]?.ToString();
                    if (string.IsNullOrWhiteSpace(tenDaiLyValue))
                        tenDaiLyValue = $"Đại lý {daiLyIndex}";
                    else
                        tenDaiLyValue = $"{tenDaiLyValue} ({daiLyIndex})";
                    daiLyIndex++;

                    string noCuoiStringValue = row["NoCuoi"]?.ToString();

                    if (decimal.TryParse(noCuoiStringValue, out decimal noCuoiNumValue) && noCuoiNumValue > 0)
                    {
                        congNoDataList.Add(new KeyValuePair<string, decimal>(tenDaiLyValue, noCuoiNumValue));
                    }
                }
            }


            var topDaiLyDataForColumns = congNoDataList.OrderBy(x => x.Value).Take(10).Reverse().ToList();
            // MessageBox.Show($"{topDaiLyDataForColumns}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (!topDaiLyDataForColumns.Any())
            {
                Title emptyDataTitle = new Title("Không có dữ liệu công nợ để hiển thị", Docking.Top, new Font("Arial", 12), Color.Gray);
                pcThongKeCongNo.Titles.Add(emptyDataTitle);
                pcThongKeCongNo.Invalidate();
                return;
            }

            // --- Vẽ các cột dữ liệu (Series) cho Top 10 Đại Lý ---  
            var seriesDaiLy = new Series("CongNoCuaDaiLy")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                LabelFormat = "N0",
                ChartArea = "MainChartArea",
                IsVisibleInLegend = false,
                XValueType = ChartValueType.String, // Ensure categorical X axis
                YValueType = ChartValueType.Auto,
                IsXValueIndexed = false,

            };



            foreach (var dataPoint in topDaiLyDataForColumns)
            {

                int pointIdx = seriesDaiLy.Points.AddXY(topDaiLyDataForColumns.IndexOf(dataPoint), dataPoint.Value);
                seriesDaiLy.Points[pointIdx].Color = Color.FromArgb(150, 220, 220, 220); // Màu xám rất nhạt, hơi trong suốt  
                seriesDaiLy.Points[pointIdx].BorderColor = Color.DimGray; // Viền đậm hơn cho cột  
                seriesDaiLy.Points[pointIdx].BorderWidth = 1;
                seriesDaiLy.Points[pointIdx].AxisLabel = dataPoint.Key;
            }

            if (seriesDaiLy.Points.Count > 0)
            {

                pcThongKeCongNo.Series.Add(seriesDaiLy);
            }

            // --- Cấu hình trục của biểu đồ ---  
            chartArea.AxisX.Title = "Tên Đại Lý";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Angle = 0;
            chartArea.AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chartArea.AxisY.Title = "Công nợ cuối kỳ (VND)";
            chartArea.AxisY.LabelStyle.Format = "N0";
            chartArea.AxisX.IsLabelAutoFit = false;
            chartArea.AxisX.LabelStyle.IsStaggered = false;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Angle = -45; // Optional: rotate for readability
            chartArea.AxisX.IsMarginVisible = true;
            chartArea.AxisX.MajorTickMark.Enabled = true;
            chartArea.AxisX.MinorTickMark.Enabled = false;
            chartArea.AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Auto;
            chartArea.AxisX.LabelStyle.Interval = 1;

            chartArea.AxisY.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea.AxisY.MajorGrid.LineColor = Color.Gainsboro;

            pcThongKeCongNo.PerformLayout();
            pcThongKeCongNo.Update();
            pcThongKeCongNo.Invalidate();
        }

        // Hàm SetupCustomLegend giữ nguyên như trước, nhưng điều chỉnh lại ngưỡng cho phù hợp
        private void SetupCustomLegend(Chart chart)
        {
            Legend customLegend = new Legend("CustomLegend")
            {
                Title = "Mức độ công nợ",
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center
            };
            chart.Legends.Clear(); // Đảm bảo xóa legend cũ trước khi thêm
            chart.Legends.Add(customLegend);

            // Điều chỉnh các ngưỡng trong chú giải cho khớp với logic tô màu
            var legendItemCao = new LegendItem { Name = "Cao (>= 15 Tr)", Color = Color.FromArgb(217, 83, 79) };
            var legendItemTrungBinh = new LegendItem { Name = "TB (>= 5 Tr)", Color = Color.FromArgb(240, 173, 78) };
            var legendItemThap = new LegendItem { Name = "Thấp (< 5 Tr)", Color = Color.FromArgb(92, 184, 92) };

            customLegend.CustomItems.Clear(); // Xóa item cũ trước khi thêm
            customLegend.CustomItems.Add(legendItemCao);
            customLegend.CustomItems.Add(legendItemTrungBinh);
            customLegend.CustomItems.Add(legendItemThap);
        }

        private void pnHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



