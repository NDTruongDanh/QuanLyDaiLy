using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using BUS_QuanLy;
using DTO_QuanLy;
using BUS_Library;
using System.ComponentModel.DataAnnotations;

namespace GUI_QuanLy
{
    public partial class GUI_ChiTietPhieuNhap : Form
    {
        private readonly IBUS_ChiTietPhieuNhap _busCTPN;
        private readonly IBUS_PhieuNhap _busPhieuNhap;
        private readonly IBUS_MatHang _busMatHang;
        private readonly ILogger<GUI_ChiTietPhieuNhap> _logger;
        private readonly BindingSource _bindingSource = new BindingSource();

        private DTO_PhieuNhap _phieuNhap;
        private decimal _thanhTien = 0;
        private int _maMatHang = 0;

        public GUI_ChiTietPhieuNhap(IBUS_ChiTietPhieuNhap busCTPN, IBUS_PhieuNhap busPhieuNhap, IBUS_MatHang busMatHang, ILogger<GUI_ChiTietPhieuNhap> logger)
        {
            _busCTPN = busCTPN;
            _busPhieuNhap = busPhieuNhap;
            _busMatHang = busMatHang;
            _logger = logger;
            InitializeComponent();
            dgvChiTietPhieuNhap.DataSource = _bindingSource;
        }

        public void SetPhieuNhap(DTO_PhieuNhap phieuNhap)
        {
            _phieuNhap = phieuNhap;
        }

        public decimal GetTongTien()
        {
            return _phieuNhap.TongTien;
        }


        private async void GUI_ChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadComboBoxesMatHangAsync();
                await LoadGridChiTietPhieuNhapAsync();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form ChiTietPhieuNhap load");

                MessageBox.Show(
                    "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private async Task LoadComboBoxesMatHangAsync()
        {
            try
            {
                cbbMatHang.DataSource = await _busMatHang.GetMatHangForNhapXuatAsync();
                cbbMatHang.DisplayMember = "Display";
                cbbMatHang.ValueMember = "MaMatHang";
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading ComboBoxo MatHang in CTPN: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async Task LoadGridChiTietPhieuNhapAsync()
        {
            try
            {
                var data = await _busCTPN.GetDataTableChiTietPhieuNhapsByMPNAsync(_phieuNhap.MaPhieuNhap);
                _bindingSource.DataSource = data;
                ModifyDataGridViewColumns();

                txtTongTien.Text = _phieuNhap.TongTien.ToString("N0");
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid CTPN: {Message}",
                    busEx.Message);
                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private void ModifyDataGridViewColumns()
        {
            dgvChiTietPhieuNhap.Columns["MaPhieuNhap"].HeaderText = "Mã Phiếu Nhập";
            dgvChiTietPhieuNhap.Columns["Display"].HeaderText = "Mặt Hàng";
            dgvChiTietPhieuNhap.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvChiTietPhieuNhap.Columns["DonGia"].HeaderText = "Đơn Giá";
            dgvChiTietPhieuNhap.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvChiTietPhieuNhap.Columns["MaMatHang"].Visible = false;

            foreach (DataGridViewColumn dataColumn in dgvChiTietPhieuNhap.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void ValidateInputFields()
        {
            if (cbbMatHang.SelectedIndex < 0)
            {
                var valEx = new ValidationException("Vui lòng chọn Mặt hàng");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    cbbMatHang.Text);
                throw valEx;
            }
            if (!decimal.TryParse(txtDonGiaNhap.Text, out decimal donGia) || donGia <= 0)
            {
                var valEx = new ValidationException("Đơn giá nhập phải là số dương");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtDonGiaNhap.Text);
                throw valEx;
            }
            if (!int.TryParse(txtDonGiaNhap.Text, out int soLuongNhap) || soLuongNhap <= 0)
            {
                var valEx = new ValidationException("Số lượng nhập đa phải là số dương");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtSoLuong.Text);
                throw valEx;
            }
        }


        private void ClearInputFields()
        {
            cbbMatHang.SelectedIndex = -1;
            txtSoLuong.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtThanhTien.Text = "0";
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputFields();

                int soLuongNhap = Convert.ToInt32(txtSoLuong.Text);
                decimal donGiaNhap = Convert.ToDecimal(txtDonGiaNhap.Text);

                DTO_ChiTietPhieuNhap ctpn = new DTO_ChiTietPhieuNhap
                {
                    MaPhieuNhap = _phieuNhap.MaPhieuNhap,
                    MaMatHang = (int)cbbMatHang.SelectedValue,
                    SoLuongNhap = soLuongNhap,
                    DonGiaNhap = donGiaNhap,
                    ThanhTien = soLuongNhap * donGiaNhap
                };

                if (await _busCTPN.AddChiTietPhieuNhapAsync(ctpn))
                {
                    MessageBox.Show("Thêm Chi Tiet Phieu Nhap thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _phieuNhap.TongTien += ctpn.ThanhTien;
                    await LoadGridChiTietPhieuNhapAsync();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm Đại lý thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ValidationException valEx)
            {
                MessageBox.Show($"Lỗi dữ liệu: {valEx.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (BusException busEx)
            {
                _logger.LogError(busEx,
                    "BusException in Add button");

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex,
                    "Unexpected exception in Add button");

                MessageBox.Show("Lỗi hệ thông! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuNhap.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa Chi tiết phiếu nhập này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        ValidateInputFields();

                        int soLuongNhap = Convert.ToInt32(txtSoLuong.Text);
                        decimal donGiaNhap = Convert.ToDecimal(txtDonGiaNhap.Text);

                        DTO_ChiTietPhieuNhap ctpn = new DTO_ChiTietPhieuNhap
                        {
                            MaPhieuNhap = _phieuNhap.MaPhieuNhap,
                            MaMatHang = (int)cbbMatHang.SelectedValue,
                            SoLuongNhap = soLuongNhap,
                            DonGiaNhap = donGiaNhap,
                            ThanhTien = soLuongNhap * donGiaNhap
                        };

                        if (await _busCTPN.UpdateChiTietPhieuNhapAsync(ctpn))
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _phieuNhap.TongTien -= _thanhTien;
                            _phieuNhap.TongTien += ctpn.ThanhTien;
                            await LoadGridChiTietPhieuNhapAsync();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (ValidationException valEx)
                    {
                        MessageBox.Show($"Lỗi dữ liệu: {valEx.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (BusException busEx)
                    {
                        _logger.LogError(busEx,
                            "BusException in Update button");

                        MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogCritical(ex,
                            "Unexpected exception in Update button");

                        MessageBox.Show("Lỗi hệ thông! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuNhap.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa Chi tiết phiếu nhập này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int maMatHang = (int)dgvChiTietPhieuNhap.SelectedRows[0].Cells["MaMatHang"].Value;
                        if (await _busCTPN.DeleteChiTietPhieuNhapAsync(_phieuNhap.MaPhieuNhap, maMatHang))
                        {
                            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _phieuNhap.TongTien -= _thanhTien;
                            await LoadGridChiTietPhieuNhapAsync();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (BusException busEx)
                    {
                        _logger.LogError(busEx,
                            "BusException in Delete button");

                        MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogCritical(ex,
                            "Unexpected exception in Delete button");

                        MessageBox.Show("Lỗi hệ thông! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }



        private void dgvChiTietPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuNhap.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvChiTietPhieuNhap.SelectedRows[0];
                    // Cập nhật dữ liệu lên các điều khiển (nếu cần)
                    cbbMatHang.SelectedValue = row.Cells["MaMatHang"].Value;
                    txtSoLuong.Text = row.Cells["SoLuongNhap"].Value.ToString();
                    txtDonGiaNhap.Text = row.Cells["DonGiaNhap"].Value.ToString();
                    txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
                    _thanhTien = Convert.ToInt32(dgvChiTietPhieuNhap.SelectedRows[0].Cells["ThanhTien"].Value);

                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex,
                        "Unexpected exception in dgv change selection");

                    MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
