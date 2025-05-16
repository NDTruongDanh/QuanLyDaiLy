using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;
using BUS_Library;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Logging;

namespace GUI_QuanLy
{
    public partial class GUI_LoaiDaiLy : Form
    {
        private readonly IBUS_LoaiDaiLy _busLoaiDaiLy;

        private readonly ILogger<GUI_LoaiDaiLy> _logger;

        //  [] = new BindingSource();
        private readonly BindingSource _bindingSource = [];

        public GUI_LoaiDaiLy(IBUS_LoaiDaiLy busLoaiDaiLy, ILogger<GUI_LoaiDaiLy> logger)
        {
            _busLoaiDaiLy = busLoaiDaiLy;
            _logger = logger;
            InitializeComponent();
            dgvLoaiDaiLy.DataSource = _bindingSource;
        }

        private async void GUI_LoaiDaiLy_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadDataGridViewAsync();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form LoaiDaiLy load");

                MessageBox.Show(
                    "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private async Task LoadDataGridViewAsync()
        {
            try
            {
                var data = await _busLoaiDaiLy.GetLoaiDaiLyListAsync();
                _bindingSource.DataSource = data;
                dgvLoaiDaiLy.AutoResizeColumns();
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid LoaiDaiLy: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ClearInputFields()
        {
            txtTenLoaiDaiLy.Clear();
            txtTienNoToiDa.Clear();
        }

        private void ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtTenLoaiDaiLy.Text))
            {
                var valEx = new ValidationException("Tên loại đại lý không được để trống");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtTenLoaiDaiLy.Text);
                throw valEx;
            }
            if (string.IsNullOrWhiteSpace(txtTienNoToiDa.Text))
            {
                var valEx = new ValidationException("Tiền nợ tối đa không được để trống");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtTienNoToiDa.Text);
                throw valEx;
            }
            if (!decimal.TryParse(txtTienNoToiDa.Text, out decimal tienNoToiDa) || tienNoToiDa <= 0)
            {
                var valEx = new ValidationException("Tiền nợ tối đa phải là số dương");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtTienNoToiDa.Text);
                throw valEx;
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputFields();

                string tenDaiLy = txtTenLoaiDaiLy.Text.Trim();
                decimal tienNoToiDa = Convert.ToDecimal(txtTienNoToiDa.Text);
                var loaiDaiLy = new DTO_LoaiDaiLy(0, tenDaiLy, tienNoToiDa);

                if (await _busLoaiDaiLy.AddLoaiDaiLyAsync(loaiDaiLy))
                {
                    MessageBox.Show("Thêm Loại Đại lý thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataGridViewAsync();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm Loại Đại lý thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (dgvLoaiDaiLy.SelectedRows.Count > 0)
            {
                try
                {
                    ValidateInputFields();

                    int maLoaiDaiLy = Convert.ToInt32(dgvLoaiDaiLy.SelectedRows[0].Cells[0].Value);
                    string tenLoaiDaiLy = txtTenLoaiDaiLy.Text;
                    decimal tienNoToiDa = Convert.ToDecimal(txtTienNoToiDa.Text);

                    var loaiDaiLy = new DTO_LoaiDaiLy(maLoaiDaiLy, tenLoaiDaiLy, tienNoToiDa);

                    if (await _busLoaiDaiLy.UpdateLoaiDaiLyAsync(loaiDaiLy))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadDataGridViewAsync();
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
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLoaiDaiLy.SelectedRows.Count > 0)
            {
                int maLoaiDaiLy = Convert.ToInt32(dgvLoaiDaiLy.SelectedRows[0].Cells[0].Value);

                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa loại đại lý này không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (await _busLoaiDaiLy.DeleteLoaiDaiLyAsync(maLoaiDaiLy))
                        {
                            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadDataGridViewAsync();
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
                MessageBox.Show("Vui lòng chọn dòng cần xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLoaiDaiLy_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoaiDaiLy.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvLoaiDaiLy.SelectedRows[0];
                    txtTenLoaiDaiLy.Text = row.Cells["TenLoaiDaiLy"].Value?.ToString();
                    txtTienNoToiDa.Text = row.Cells["TienNoToiDa"].Value?.ToString();
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

