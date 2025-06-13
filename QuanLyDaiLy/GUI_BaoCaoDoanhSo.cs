using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS_QuanLy;
using DTO_QuanLy;
using BUS_Library;
using Microsoft.Extensions.Logging;

namespace GUI_QuanLy
{
    public partial class GUI_BaoCaoDoanhSo : Form
    {
        private readonly IBUS_BaoCaoDoanhSo _busBaoCaoDoanhSo;
        private readonly IBUS_ChiTietBaoCaoDoanhSo _busChiTietBaoCaoDoanhSo;
        private readonly ILogger<GUI_BaoCaoDoanhSo> _logger;
        private readonly IServiceProvider _service;
        private readonly BindingSource _bindingSource = new BindingSource();

        private DTO_BaoCaoDoanhSo _baoCaoDoanhSo = new DTO_BaoCaoDoanhSo();
        private Dictionary<string, decimal> _dictionary = new Dictionary<string, decimal>();

        private int _maBaoCaoDoanhSo = 0;
        private int _prevMonth = 0;
        private int _prevYear = 0;

        public GUI_BaoCaoDoanhSo(IBUS_BaoCaoDoanhSo busBaoCaoDoanhSo, IBUS_ChiTietBaoCaoDoanhSo busChiTietBaoCaoDoanhSo, ILogger<GUI_BaoCaoDoanhSo> logger, IServiceProvider service)
        {
            _busBaoCaoDoanhSo = busBaoCaoDoanhSo;
            _busChiTietBaoCaoDoanhSo = busChiTietBaoCaoDoanhSo;
            _logger = logger;
            _service = service;
            InitializeComponent();
            dgvChiTietBaoCaoDoanhSo.DataSource = _bindingSource;

            var now = DateTime.Now;
            var prev = new DateTime(now.Year, now.Month, 1).AddMonths(-1);
            _prevMonth = prev.Month;
            _prevYear = prev.Year;
        }

        private async void GUI_BaoCaoDoanhSo_Load(object sender, EventArgs e)
        {
            try
            {
                await AutoCreateBaoCaoAsync();
                await LoadChiTietBaoCaoDoanhSoAsync(_prevMonth, _prevYear);
                ShowCharBaoCao();
                LoadContent();

                cbbThang.SelectedIndex = _prevMonth - 1; // Tháng 1 là index 0
                txtNam.Text = _prevYear.ToString();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form BaoCaoDoanhSo load");

                MessageBox.Show(
                    "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private async Task AutoCreateBaoCaoAsync()
        {
            try
            {
                if (await _busBaoCaoDoanhSo.AddBaoCaoDoanhSoAutoAsync(_prevMonth, _prevYear))
                {
                    _baoCaoDoanhSo = await _busBaoCaoDoanhSo.GetBaoCaoDoanhSoByTimeAsync(_prevMonth, _prevYear);
                    if (await AutoCreateChiTietBaoCaoDoanhSoAsync(_baoCaoDoanhSo))
                    {
                        MessageBox.Show($"Báo cáo Doanh số tháng {_prevMonth} năm {_prevYear} đã được tạo tự động thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (BusException busEx)
            {
                _logger.LogError(busEx,
                    "BusException in AutoCreateBaoCaoAsync");

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex,
                    "Unexpected exception in AutoCreateBaoCaoAsync");

                MessageBox.Show("Lỗi hệ thông khi tự động khởi tạo Báo cáo Doanh số! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> AutoCreateChiTietBaoCaoDoanhSoAsync(DTO_BaoCaoDoanhSo baoCaoDoanhSo)
        {
            try
            {
                return await _busChiTietBaoCaoDoanhSo.AddChiTietBaoCaoDoanhSoAuToAsync(baoCaoDoanhSo);
            }
            catch (BusException busEx)
            {
                _logger.LogError(busEx,
                    "BusException in AutoCreateBaoCaoAsync");

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex,
                    "Unexpected exception in AutoCreateChiTietBaoCaoDoanhSoAsync");

                MessageBox.Show("Lỗi hệ thông khi tự động khởi tạo Chi tiết Báo cáo Doanh số! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async Task LoadChiTietBaoCaoDoanhSoAsync(int thang, int nam)
        {
            try
            {
                _baoCaoDoanhSo = await _busBaoCaoDoanhSo.GetBaoCaoDoanhSoByTimeAsync(thang, nam);
                var data = await _busChiTietBaoCaoDoanhSo.GetDataTableChiTietBaoCaoDoanhSoListByMaBaoCaoAsync(_baoCaoDoanhSo.MaBaoCaoDoanhSo);
                _bindingSource.DataSource = data;
                SaveTenDaiLyAndTriGia();

                ModifyDataGridViewColumns();
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid ChiTietBaoCaoDoanhSo by MaBaoCao: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ModifyDataGridViewColumns()
        {
            dgvChiTietBaoCaoDoanhSo.Columns["MaDaiLy"].HeaderText = "Mã Đại lý";
            dgvChiTietBaoCaoDoanhSo.Columns["TenDaiLy"].HeaderText = "Tên Đại lý";
            dgvChiTietBaoCaoDoanhSo.Columns["SoLuongPhieuXuat"].HeaderText = "Số lượng Phiếu xuất";
            dgvChiTietBaoCaoDoanhSo.Columns["TongTriGia"].HeaderText = "Tổng trị giá";
            dgvChiTietBaoCaoDoanhSo.Columns["TiLe"].HeaderText = "Tỷ lệ";

            dgvChiTietBaoCaoDoanhSo.Columns["MaBaoCaoDoanhSo"].Visible = false;

            foreach (DataGridViewColumn dataColumn in dgvChiTietBaoCaoDoanhSo.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadContent()
        {
            // Dòng tổng
            int totalDaiLy = dgvChiTietBaoCaoDoanhSo.Rows.Count;
            int totalPhieu = 0;
            decimal totalDoanhThu = 0;

            // Loop tất cả các dòng trừ dòng cuối cùng (nếu đang có dòng tổng)
            for (int i = 0; i < totalDaiLy; i++)
            {
                var dgvrow = dgvChiTietBaoCaoDoanhSo.Rows[i];

                // Parse số phiếu
                if (int.TryParse(dgvrow.Cells["SoLuongPhieuXuat"].Value?.ToString(), out int invoices))
                    totalPhieu += invoices;

                // Parse tổng trị giá (loại bỏ ký tự tiền tệ và dấu chấm)
                string? valueStr = dgvrow.Cells["TongTriGia"].Value?.ToString()?.Replace("₫", "").Trim();
                if (decimal.TryParse(valueStr, out decimal value))
                    totalDoanhThu += value;
            }

            lblTongDoanhSo_Num.Text = totalDoanhThu.ToString("N0") + " ₫";
            lblTongSoDaiLy_Num.Text = totalDaiLy.ToString();
            lblTongSoPhieuXuat_Num.Text = totalPhieu.ToString();
        }

        private void SaveTenDaiLyAndTriGia()
        {
            _dictionary.Clear();
            foreach (DataGridViewRow row in dgvChiTietBaoCaoDoanhSo.Rows)
            {
                if (row.IsNewRow) continue; // Bỏ qua dòng mới

                string? tenDaiLy = row.Cells["TenDaiLy"].Value?.ToString();
                decimal triGia = 0;

                // Chuyển đổi trị giá sang decimal
                string? triGiaStr = row.Cells["TongTriGia"].Value?.ToString()?.Replace(".", "").Replace("₫", "").Trim();
                if (decimal.TryParse(triGiaStr, out decimal value))
                {
                    triGia = value;
                }

                if (!string.IsNullOrEmpty(tenDaiLy))
                {
                    _dictionary[tenDaiLy] = triGia;
                }
            }
        }


        private void ShowCharBaoCao()
        {
            var series = pcThongKeDoanhSo.Series["Series1"];
            series.Points.Clear();
            series.IsValueShownAsLabel = false;

            foreach (var kvp in _dictionary)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            // Cấu hình legend text xuống dòng nếu tên quá dài
            foreach (var point in series.Points)
            {
                point.Label = " "; // Không hiển thị label trong chart

                // Nếu tên dài, chia từ và gán LegendText xuống dòng
                string[] words = point.AxisLabel.Split(' ');
                point.LegendText = string.Join("\n", words);
            }
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private async void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = cbbThang.SelectedIndex + 1;
                int nam = int.Parse(txtNam.Text);
                await LoadChiTietBaoCaoDoanhSoAsync(thang, nam);
                ShowCharBaoCao();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form BaoCaoDoanhSo load");

                MessageBox.Show(
                    "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pcThongKeDoanhSo_Click(object sender, EventArgs e)
        {

        }
    }
}

