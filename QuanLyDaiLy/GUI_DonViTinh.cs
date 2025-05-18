using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using DTO_QuanLy;
using BUS_QuanLy;
using System.ComponentModel.DataAnnotations;
using BUS_Library;

namespace GUI_QuanLy
{
    public partial class GUI_DonViTinh : Form
    {
        private readonly IBUS_DonViTinh _busDVT;
        private readonly ILogger<GUI_DonViTinh> _logger;
        private readonly BindingSource _bindingSource = new BindingSource();
        private int _maDVT = 0;

        public GUI_DonViTinh(IBUS_DonViTinh busDVT, ILogger<GUI_DonViTinh> logger)
        {
            //_busDVT = busDVT;
            //_logger = logger;
            //InitializeComponent();
            //dgvDVT.DataSource = _bindingSource;
        }


        private async void GUI_DonViTinh_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    await LoadDonViTinhAsync();
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogCritical(ex, "Unhandled exception in form DonViTinh load");

            //    MessageBox.Show(
            //        "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
            //        "Lỗi",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}
        }

        private async Task LoadDonViTinhAsync()
        {
            //try
            //{
            //    var donViTinhList = await _busDVT.GetDonViTinhListAsync();
            //    _bindingSource.DataSource = donViTinhList;
            //    dgvDVT.DataSource = _bindingSource;
            //}
            //catch (BusException busEx)
            //{
            //    _logger.LogWarning(busEx,
            //        "Business error loading ComboBoxo LoaiDaiLy: {Message}",
            //        busEx.Message);

            //    MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
            //        "Thông báo",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning);
            //}
        }

        private void ValidateInputField()
        {
            //if (string.IsNullOrWhiteSpace(txtTenDonViTinh.Text))
            //{
            //    var valEx = new ValidationException("Tên Đơn vị tính không được để trống");
            //    _logger.LogWarning(valEx,
            //        "Validation failed: {Input}",
            //        txtTenDonViTinh.Text);
            //    throw valEx;
            //}
        }

        private void ClearInputFields()
        {
            // txtTenDonViTinh.Clear();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ValidateInputField();

            //    DTO_DonViTinh donViTinh = new DTO_DonViTinh(0, txtTenDonViTinh.Text);
            //    if (await _busDVT.AddDonViTinhAsync(donViTinh))
            //    {
            //        MessageBox.Show("Thêm Đơn vị tính thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        await LoadDonViTinhAsync();
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
            //if (dgvDVT.SelectedRows.Count > 0)
            //{
            //    DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa Đơn vị tính này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (confirm == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            ValidateInputField();

            //            int maDVT = Convert.ToInt32(dgvDVT.SelectedRows[0].Cells[0].Value.ToString());
            //            if (await _busDVT.UpdateDonViTinhAsync(new DTO_DonViTinh(maDVT, txtTenDonViTinh.Text)))
            //            {
            //                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                await LoadDonViTinhAsync();
            //                ClearInputFields();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            //    MessageBox.Show("Vui lòng chọn đơn vị tính để sửa.");
            //}
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            //    if (dgvDVT.SelectedRows.Count > 0)
            //    {
            //        try
            //        {
            //            if (await _busDVT.DeleteDonViTinhAsync(_maDVT))
            //            {
            //                MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                await LoadDonViTinhAsync();
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
            //    else
            //    {
            //        MessageBox.Show("Vui lòng chọn đơn vị tính để xóa.");
            //    }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //  this.Close();
        }

        private void dgvDVT_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvDVT.SelectedRows.Count > 0)
            //{
            //    try
            //    {
            //        DataGridViewRow row = dgvDVT.SelectedRows[0];
            //        _maDVT = Convert.ToInt32(row.Cells["MaDonViTinh"].Value.ToString());
            //        txtTenDonViTinh.Text = row.Cells["TenDonViTinh"].Value.ToString();
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
