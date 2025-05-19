using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Data;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_Library;
using BUS_QuanLy;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
namespace GUI_QuanLy
{
    public partial class GUI_ChiTietPhieuXuat : Form
    {
        private readonly IBUS_PhieuXuat _busPhieuXuat;

        private readonly IBUS_ChiTietPhieuXuat _busCTPX;

        private readonly IBUS_MatHang _busMatHang;

        private readonly ILogger<GUI_ChiTietPhieuXuat> _logger;

        private readonly IServiceProvider _services;

        private readonly BindingSource _bindingSource = new BindingSource();

        private DTO_PhieuXuat _phieuXuat = new DTO_PhieuXuat();
        private List<decimal> _listDonGiaXuat = new List<decimal>();
        private List<int> _ListTonKho = new List<int>();

        private decimal _thanhTien = 0;

        public GUI_ChiTietPhieuXuat(IBUS_PhieuXuat busPhieuXuat, IBUS_ChiTietPhieuXuat busCTPX, IBUS_MatHang busMatHang, ILogger<GUI_ChiTietPhieuXuat> logger, IServiceProvider service)
        {
            _busPhieuXuat = busPhieuXuat;
            _busCTPX = busCTPX;
            _busMatHang = busMatHang;
            _logger = logger;
            _services = service;
            InitializeComponent();
            dgvChiTietPhieuXuat.DataSource = _bindingSource;
        }


        public void SetPhieuXuat(DTO_PhieuXuat phieuXuat)
        {
            _phieuXuat = phieuXuat;
        }

        public DTO_PhieuXuat GetPhieuXuat()
        {
            return _phieuXuat;
        }




        private async void GUI_ChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadComboBoxesMatHangAsync();
                await LoadChiTietPhieuXuatAsync();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form ChiTietPhieuXuat load");

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
                var dataTable = await _busMatHang.GetMatHangForXuatAsync();

                foreach (DataRow row in dataTable.Rows)
                {
                    _listDonGiaXuat.Add(Convert.ToDecimal(row["DonGiaHienTai"]));
                    _ListTonKho.Add(Convert.ToInt32(row["TonKho"]));
                }

                cbbMatHang.DataSource = dataTable;
                cbbMatHang.DisplayMember = "DISPLAY";
                cbbMatHang.ValueMember = "MaMatHang";
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading ComboBoxo MatHang: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private async Task LoadChiTietPhieuXuatAsync()
        {
            try
            {
                var dataTable = await _busCTPX.GetDataTableChiTietPhieuXuatByMPXAsync(_phieuXuat.MaPhieuXuat);
                _bindingSource.DataSource = dataTable;
                ModifyDataGridViewColumns();


            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading ChiTietPhieuXuat: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }



        private void ModifyDataGridViewColumns()
        {
            dgvChiTietPhieuXuat.Columns["MaPhieuXuat"].HeaderText = "Mã Phiếu Xuất";
            dgvChiTietPhieuXuat.Columns["Display"].HeaderText = "Mặt Hàng";
            dgvChiTietPhieuXuat.Columns["SoLuongXuat"].HeaderText = "Số Lượng";
            dgvChiTietPhieuXuat.Columns["DonGiaXuat"].HeaderText = "Đơn Giá";
            dgvChiTietPhieuXuat.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvChiTietPhieuXuat.Columns["MaMatHang"].Visible = false;

            foreach (DataGridViewColumn dataColumn in dgvChiTietPhieuXuat.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private void ClearInputFields()
        {
            txtSoTienTra.Text = "0";
            txtSoLuong.Text = "0";
            cbbMatHang.SelectedIndex = -1;

            dgvChiTietPhieuXuat.ClearSelection();
        }


        private void ValidateInputFields()
        {
            if (!int.TryParse(txtSoLuong.Text, out int soLuongNhap) || soLuongNhap <= 0)
            {
                var valEx = new ValidationException("Số lượng phải > 0");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtSoLuong.Text);
                throw valEx;
            }
            if (cbbMatHang.SelectedIndex < 0)
            {
                var valEx = new ValidationException("Vui lòng chọn Mặt hàng");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    cbbMatHang.Text);
                throw valEx;
            }
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputFields();

                var maMatHang = Convert.ToInt32(cbbMatHang.SelectedValue);
                var soLuongXuat = Convert.ToInt32(txtSoLuong.Text);
                var donGiaXuat = _listDonGiaXuat[cbbMatHang.SelectedIndex];
                var thanhTien = soLuongXuat * donGiaXuat;

                if (soLuongXuat > _ListTonKho[cbbMatHang.SelectedIndex])
                {
                    MessageBox.Show("Số lượng xuất không được lớn hơn tồn kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var chiTietPhieuXuat = new DTO_ChiTietPhieuXuat(_phieuXuat.MaPhieuXuat, maMatHang, soLuongXuat, donGiaXuat, thanhTien);

                if (await _busCTPX.AddChiTietPhieuXuatAsync(chiTietPhieuXuat))
                {
                    MessageBox.Show("Thêm Chi Tiet Phieu Nhap thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _phieuXuat.TongTien += thanhTien;
                    txtTongTien.Text = _phieuXuat.TongTien.ToString("N0");
                    await LoadChiTietPhieuXuatAsync();
                    await LoadComboBoxesMatHangAsync();
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
            if (dgvChiTietPhieuXuat.SelectedRows.Count > 0)
            {
                try
                {
                    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa Chi tiết phiếu xuất này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        ValidateInputFields();

                        var maMatHang = Convert.ToInt32(cbbMatHang.SelectedValue);
                        var soLuongXuat = Convert.ToInt32(txtSoLuong.Text);
                        var donGiaXuat = _listDonGiaXuat[cbbMatHang.SelectedIndex];
                        var thanhTien = soLuongXuat * donGiaXuat;

                        var soLuongXuatCu = Convert.ToInt32(dgvChiTietPhieuXuat.SelectedRows[0].Cells["SoLuongXuat"].Value);
                        var thanhTienCu = Convert.ToDecimal(dgvChiTietPhieuXuat.SelectedRows[0].Cells["ThanhTien"].Value);


                        if (soLuongXuat > _ListTonKho[cbbMatHang.SelectedIndex] + soLuongXuatCu)
                        {
                            MessageBox.Show("Số lượng xuất không được lớn hơn tồn kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var chiTietPhieuXuat = new DTO_ChiTietPhieuXuat(_phieuXuat.MaPhieuXuat, maMatHang, soLuongXuat, donGiaXuat, thanhTien);

                        if (await _busCTPX.UpdateChiTietPhieuXuatAsync(chiTietPhieuXuat))
                        {
                            MessageBox.Show("Cập nhật Chi Tiet Phieu Nhap thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _phieuXuat.TongTien += thanhTien;
                            _phieuXuat.TongTien -= thanhTienCu;
                            txtTongTien.Text = _phieuXuat.TongTien.ToString("N0");
                            await LoadChiTietPhieuXuatAsync();
                            await LoadComboBoxesMatHangAsync();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Chi Tiet Phieu Nhap thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (ValidationException valEx)
                {
                    MessageBox.Show($"Lỗi dữ liệu: {valEx.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                catch (BusException busEx)
                {
                    _logger.LogError(busEx,
                        "BusException in Edit button");

                    MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex,
                        "Unexpected exception in Edit button");

                    MessageBox.Show("Lỗi hệ thông! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuXuat.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa Chi tiết phiếu nhập này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int maMatHang = Convert.ToInt32(dgvChiTietPhieuXuat.SelectedRows[0].Cells["MaMatHang"].Value);
                        if (await _busCTPX.DeleteChiTietPhieuXuatAsync(_phieuXuat.MaPhieuXuat, maMatHang))
                        {
                            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _phieuXuat.TongTien -= _thanhTien;
                            txtTongTien.Text = _phieuXuat.TongTien.ToString("N0");
                            await LoadChiTietPhieuXuatAsync();
                            await LoadComboBoxesMatHangAsync();
                            ClearInputFields();
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
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                }
            }

        }

        private void dgvChiTietPhieuXuat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuXuat.SelectedRows.Count > 0)
            {
                try
                {
                    var selectedRow = dgvChiTietPhieuXuat.SelectedRows[0];
                    cbbMatHang.SelectedValue = selectedRow.Cells["MaMatHang"].Value;
                    txtSoLuong.Text = selectedRow.Cells["SoLuongXuat"].Value.ToString();
                    txtSoTienTra.Text = _phieuXuat.TienTra.ToString("N0");
                    _thanhTien = Convert.ToDecimal(selectedRow.Cells["ThanhTien"].Value);
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex,
                        "Unexpected exception in dgv change selection");

                    MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}

