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
            ChartArea chartArea = pcThongKeCongNo.ChartAreas.Add("MainChartArea");
            chartArea.AxisX.StripLines.Clear();

            // --- Lấy và xử lý dữ liệu công nợ từ DataTable ---
            var congNoDataList = new List<KeyValuePair<string, decimal>>();
            foreach (DataRow row in dataTable.Rows)
            {
                if (dataTable.Columns.Contains("TenDaiLy") && dataTable.Columns.Contains("NoCuoi"))
                {
                    string tenDaiLyValue = row["TenDaiLy"]?.ToString() ?? "Không tên";
                    string noCuoiStringValue = row["NoCuoi"]?.ToString();

                    if (decimal.TryParse(noCuoiStringValue, out decimal noCuoiNumValue) && noCuoiNumValue > 0)
                    {
                        congNoDataList.Add(new KeyValuePair<string, decimal>(tenDaiLyValue, noCuoiNumValue));
                    }
                }
            }

            var topDaiLyDataForColumns = congNoDataList.OrderByDescending(kvp => kvp.Value)
                                                     .Take(10)
                                                     .Reverse()
                                                     .ToList();

            var topDistinctNoCuoiValues = congNoDataList.Select(kvp => kvp.Value)
                                                     .Where(value => value > 0)
                                                     .Distinct()
                                                     .OrderByDescending(value => value)
                                                     .Take(10)
                                                     .OrderBy(value => value)
                                                     .ToList();

            if (!topDaiLyDataForColumns.Any() && !topDistinctNoCuoiValues.Any())
            {
                Title emptyDataTitle = new Title("Không có dữ liệu công nợ để hiển thị", Docking.Top, new Font("Arial", 12), Color.Gray);
                pcThongKeCongNo.Titles.Add(emptyDataTitle);
                pcThongKeCongNo.Invalidate();
                return;
            }

            // --- Chuẩn bị danh sách màu sắc tương phản cao cho StripLine ---
            // Sử dụng màu đặc (Alpha = 255) hoặc Alpha cao để rõ nét.
            // Chọn các màu cơ bản dễ phân biệt.
            List<Color> stripLineColorPalette = new List<Color>
    {
        Color.FromArgb(220, Color.Red),       // Đỏ (hơi giảm độ chói nếu cần)
        Color.FromArgb(220, Color.Blue),      // Xanh dương
        Color.FromArgb(220, Color.Green),     // Xanh lá
        Color.FromArgb(255, 235, 59),         // Vàng (Material Yellow 500)
        Color.FromArgb(220, Color.Orange),    // Cam
        Color.FromArgb(220, Color.Purple),    // Tím
        Color.FromArgb(220, Color.Cyan),      // Xanh lơ
        Color.FromArgb(220, Color.Magenta),   // Hồng cánh sen
        Color.FromArgb(220, Color.LimeGreen), // Xanh lá mạ
        Color.FromArgb(220, Color.Brown)      // Nâu
        // Bạn có thể thay thế bằng các mã màu RGB cụ thể hơn nếu muốn
        // Ví dụ một bộ màu Material Design (Alpha=255 để màu đặc):
        // Color.FromArgb(244, 67, 54),   // Material Red
        // Color.FromArgb(33, 150, 243),  // Material Blue
        // Color.FromArgb(76, 175, 80),   // Material Green
        // Color.FromArgb(255, 193, 7),   // Material Amber/Yellow
        // Color.FromArgb(255, 87, 34),   // Material Deep Orange
        // Color.FromArgb(156, 39, 176),  // Material Purple
        // Color.FromArgb(0, 188, 212),   // Material Cyan
        // Color.FromArgb(233, 30, 99),   // Material Pink
        // Color.FromArgb(139, 195, 74),  // Material Lime
        // Color.FromArgb(0, 150, 136)    // Material Teal
    };


            // --- TÍNH TOÁN defaultStripWidth MỘT CÁCH LINH ĐỘNG ---
            double defaultStripWidth = 50000;

            if (topDistinctNoCuoiValues.Count > 0)
            {
                if (topDistinctNoCuoiValues.Count == 1)
                {
                    defaultStripWidth = (double)(topDistinctNoCuoiValues.First() * 0.10m);
                }
                else
                {
                    double minDistance = double.MaxValue;
                    for (int i = 0; i < topDistinctNoCuoiValues.Count - 1; i++)
                    {
                        double distance = (double)(topDistinctNoCuoiValues[i + 1] - topDistinctNoCuoiValues[i]);
                        if (distance < minDistance && distance > 0)
                        {
                            minDistance = distance;
                        }
                    }

                    if (minDistance != double.MaxValue && minDistance > 0)
                    {
                        defaultStripWidth = minDistance * 0.5;
                    }
                    else
                    {
                        decimal avgTopNoCuoi = topDistinctNoCuoiValues.Average();
                        defaultStripWidth = (double)(avgTopNoCuoi * 0.05m);
                    }
                }

                decimal maxNoCuoiOverall = 0;
                if (congNoDataList.Any()) maxNoCuoiOverall = congNoDataList.Max(kvp => kvp.Value);

                double minPracticalWidth = 10000;
                double maxPracticalWidth = maxNoCuoiOverall > 0 ? (double)(maxNoCuoiOverall * 0.2m) : 2000000;

                if (defaultStripWidth < minPracticalWidth) defaultStripWidth = minPracticalWidth;
                if (defaultStripWidth > maxPracticalWidth) defaultStripWidth = maxPracticalWidth;
            }

            // --- Tạo và thêm StripLines vào ChartArea ---
            int stripLineColorIdx = 0;
            foreach (decimal noCuoiValue in topDistinctNoCuoiValues)
            {
                double stripStartOffset = (double)noCuoiValue - (defaultStripWidth / 2);
                if (stripStartOffset < 0) stripStartOffset = 0;

                StripLine strip = new StripLine
                {
                    Interval = 0,
                    IntervalOffset = stripStartOffset,
                    StripWidth = defaultStripWidth,
                    // Sử dụng màu đặc hoặc Alpha cao (ví dụ 220-255) để rõ nét
                    BackColor = stripLineColorPalette[stripLineColorIdx % stripLineColorPalette.Count],
                    BorderColor = Color.Transparent, // Hoặc một màu viền nhẹ nếu màu dải quá sáng
                                                     // BorderColor = Color.FromArgb(50, Color.Black), // Viền đen mờ nhẹ
                                                     // ToolTip = $"Vùng nợ quanh {noCuoiValue:N0}", 
                };
                chartArea.AxisX.StripLines.Add(strip);
                stripLineColorIdx++;
            }

            // --- Vẽ các cột dữ liệu (Series) cho Top 10 Đại Lý ---
            var seriesDaiLy = new Series("CongNoCuaDaiLy")
            {
                ChartType = SeriesChartType.Bar,
                IsValueShownAsLabel = true,
                LabelFormat = "N0",
                ChartArea = "MainChartArea",
                IsVisibleInLegend = false,
                ["PointWidth"] = "0.6"
            };

            foreach (var dataPoint in topDaiLyDataForColumns)
            {
                int pointIdx = seriesDaiLy.Points.AddXY(dataPoint.Key, dataPoint.Value);
                // Màu cho cột dữ liệu. Nên là màu trung tính hoặc có độ tương phản với StripLine.
                // Nếu StripLine đặc màu, cột có thể cần màu nhạt hơn hoặc có viền rõ.
                seriesDaiLy.Points[pointIdx].Color = Color.FromArgb(150, 220, 220, 220); // Màu xám rất nhạt, hơi trong suốt
                seriesDaiLy.Points[pointIdx].BorderColor = Color.DimGray; // Viền đậm hơn cho cột
                seriesDaiLy.Points[pointIdx].BorderWidth = 1;
                // seriesDaiLy.Points[pointIdx].ToolTip = $"Đại lý: {dataPoint.Key}\nNợ cuối: {dataPoint.Value:N0}";
            }
            if (seriesDaiLy.Points.Count > 0)
            {
                pcThongKeCongNo.Series.Add(seriesDaiLy);
            }

            // --- Cấu hình trục của biểu đồ ---
            chartArea.AxisX.Title = "Công nợ cuối kỳ (VND)";
            chartArea.AxisX.LabelStyle.Format = "N0";
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea.AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chartArea.AxisY.Title = "Tên Đại Lý";
            chartArea.AxisY.Interval = 1;
            chartArea.AxisY.LabelStyle.Angle = 0;
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
    }
}



