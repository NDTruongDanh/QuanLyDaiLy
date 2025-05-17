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
    public partial class GUI_MatHang : Form
    {
        private readonly IBUS_MatHang _busMatHang;
        private readonly IBUS_DonViTinh _busDonViTinh;
        private readonly ILogger<GUI_MatHang> _logger;
        private readonly BindingSource _bindingSource = new BindingSource();

        private int _maMatHang = 0;

        public GUI_MatHang(IBUS_MatHang busMatHang, IBUS_DonViTinh busDonViTinh, ILogger<GUI_MatHang> logger)
        {
            //_busMatHang = busMatHang;
            //_busDonViTinh = busDonViTinh;
            //_logger = logger;
            //InitializeComponent();
            //dgvMatHang.DataSource = _bindingSource;
        }


        private async void GUI_MatHang_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    await LoadMatHangAsync();
            //    await LoadComboBoxDonViTinhAsync();
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogCritical(ex, "Unhandled exception in form MatHang load");

            //    MessageBox.Show(
            //        "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
            //        "Lỗi",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
        }

        private async Task LoadMatHangAsync()
        {
            //try
            //{
            //    var matHangList = await _busMatHang.GetMatHangListAsync();
            //    _bindingSource.DataSource = matHangList;
            //    dgvMatHang.DataSource = _bindingSource;
            //}
            //catch (BusException busEx)
            //{
            //    _logger.LogWarning(busEx,
            //        "Business error loading grid DaiLy: {Message}",
            //        busEx.Message);

            //    MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
            //        "Thông báo",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);
            //}
        }

        private async Task LoadComboBoxDonViTinhAsync()
        {
            //try
            //{
            //    var donViTinhList = await _busDonViTinh.GetDonViTinhListAsync();
            //    cboDonViTinh.DataSource = donViTinhList;
            //    cboDonViTinh.DisplayMember = "TenDonViTinh";
            //    cboDonViTinh.ValueMember = "MaDonViTinh";
            //}
            //catch (BusException busEx)
            //{
            //    _logger.LogWarning(busEx,
            //        "Business error loading ComboBox DonViTin in MatHang: {Message}",
            //        busEx.Message);

            //    MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
            //        "Thông báo",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);
            //}
        }

        private void ClearInputFields()
        {
        //    txtTenMatHang.Clear();
        //    cboDonViTinh.SelectedIndex = -1;
        //    txtDonGiaHienTai.Clear();
        //    txtTonKho.Clear();
        }

        private void ValidateInputFields()
        {
            //if (string.IsNullOrWhiteSpace(txtTenMatHang.Text))
            //{
            //    var valEx = new ValidationException("Tên Mặt hàng không được để trống");
            //    _logger.LogWarning(valEx,
            //        "Validation failed: {Input}",
            //        txtTenMatHang.Text);
            //    throw valEx;
            //}
            //if (cboDonViTinh.SelectedIndex < 0)
            //{
            //    var valEx = new ValidationException("Vui lòng chọn Đơn vị tính");
            //    _logger.LogWarning(valEx,
            //        "Validation failed: {Input}",
            //        cboDonViTinh.Text);
            //    throw valEx;
            //}
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ValidateInputFields();

            //    string tenMatHang = txtTenMatHang.Text;
            //    int maDonViTinh = Convert.ToInt16(cboDonViTinh.SelectedValue);
            //    if (await _busMatHang.AddMatHangDefault(tenMatHang, maDonViTinh))
            //    {
            //        MessageBox.Show("Thêm Mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        await LoadMatHangAsync();
            //        ClearInputFields();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thêm Đại lý thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (ValidationException valEx)
            //{
            //    MessageBox.Show($"Lỗi dữ liệu: {valEx.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //catch (BusException busEx)
            //{
            //    _logger.LogError(busEx,
            //        "BusException in Add button");

            //    MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogCritical(ex,
            //        "Unexpected exception in Add button");

            //    MessageBox.Show("Lỗi hệ thông! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            //if (dgvMatHang.SelectedRows.Count > 0)
            //{
            //    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa loại đại lý này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (confirm == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            ValidateInputFields();

            //            DTO_MatHang matHang = new DTO_MatHang
            //            {
            //                MaMatHang = Convert.ToInt32(dgvMatHang.SelectedRows[0].Cells["MaMatHang"].Value),
            //                TenMatHang = txtTenMatHang.Text,
            //                MaDonViTinh = Convert.ToInt16(cboDonViTinh.SelectedValue),
            //                DonGiaHienTai = Convert.ToDecimal(txtDonGiaHienTai.Text),
            //                TonKho = Convert.ToInt32(txtTonKho.Text)
            //            };

            //            if (await _busMatHang.UpdateMatHangAsync(matHang))
            //            {
            //                MessageBox.Show("Sửa Mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                await LoadMatHangAsync();
            //                ClearInputFields();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Sửa Mặt hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //        }
            //        catch (ValidationException valEx)
            //        {
            //            MessageBox.Show($"Lỗi dữ liệu: {valEx.Message}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //        catch (BusException busEx)
            //        {
            //            _logger.LogError(busEx,
            //                "BusException in Update button");

            //            MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        catch (Exception ex)
            //        {
            //            _logger.LogCritical(ex,
            //                "Unexpected exception in Update button");

            //            MessageBox.Show("Lỗi hệ thông! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn mặt hàng cần sửa.");
            //}
        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            //if (dgvMatHang.SelectedRows.Count > 0)
            //{
            //    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (confirm == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            if (await _busMatHang.DeleteMatHangAsync(_maMatHang))
            //            {
            //                MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                await LoadMatHangAsync();
            //                ClearInputFields();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            }
            //        }
            //        catch (BusException busEx)
            //        {
            //            _logger.LogError(busEx,
            //                "BusException in Delete button");

            //            MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        catch (Exception ex)
            //        {
            //            _logger.LogCritical(ex,
            //                "Unexpected exception in Delete button");

            //            MessageBox.Show("Lỗi hệ thông! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn mặt hàng cần xóa.");
            //}
        }

        private void dgvMatHang_Click(object sender, EventArgs e)
        {
            //if (dgvMatHang.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = dgvMatHang.SelectedRows[0];
            //    _maMatHang = Convert.ToInt32(row.Cells["MaMatHang"].Value);
            //    txtTenMatHang.Text = row.Cells["TenMatHang"].Value.ToString();
            //    cboDonViTinh.SelectedValue = row.Cells["MaDonViTinh"].Value;
            //    txtDonGiaHienTai.Text = row.Cells["DonGiaHienTai"].Value.ToString();
            //    txtTonKho.Text = row.Cells["TonKho"].Value.ToString();
            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void dgvMatHang_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvMatHang.SelectedRows.Count > 0)
            //{
            //    try
            //    {
            //        DataGridViewRow row = dgvMatHang.SelectedRows[0];
            //        _maMatHang = Convert.ToInt32(row.Cells["MaMatHang"].Value);
            //        txtTenMatHang.Text = row.Cells["TenMatHang"].Value.ToString();
            //        cboDonViTinh.SelectedValue = row.Cells["MaDonViTinh"].Value;
            //        txtDonGiaHienTai.Text = row.Cells["DonGiaHienTai"].Value.ToString();
            //        txtTonKho.Text = row.Cells["TonKho"].Value.ToString();
            //    }
            //    catch (Exception ex)
            //    {
            //        _logger.LogCritical(ex,
            //            "Unexpected exception in dgv change selection");

            //        MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

      
    }
}
