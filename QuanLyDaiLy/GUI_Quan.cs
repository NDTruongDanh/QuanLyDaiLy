using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Windows.Forms;
using BUS_Library;
using BUS_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GUI_QuanLy
{
    public partial class GUI_Quan : Form
    {
        private readonly IBUS_Quan _busQuan;

        private readonly IServiceProvider _services;

        private readonly ILogger<GUI_Quan> _logger;

        private readonly BindingSource _bindingSource = new BindingSource();

        public GUI_Quan(IBUS_Quan busQuan, IServiceProvider services, ILogger<GUI_Quan> logger)
        {
            _busQuan = busQuan;
            _services = services;
            _logger = logger;
            InitializeComponent();
            dgvQuan.DataSource = _bindingSource;
        }

        private async void GUI_Quan_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadDataGridViewAsync();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form Quan load");

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
                var data = await _busQuan.GetQuanListAsync();
                _bindingSource.DataSource = data;
                dgvQuan.AutoResizeColumns();
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid Quan: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }
        private void ClearInputFields()
        {
            txtTenQuan.Clear();

            dgvQuan.ClearSelection();
        }

        private void ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtTenQuan.Text))
            {
                throw new ValidationException("Tên quận không được để trống");
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputFields();

                DTO_Quan quan = new DTO_Quan(0, txtTenQuan.Text.Trim());
                if (await _busQuan.AddQuanAsync(quan))
                {
                    MessageBox.Show("Thêm Quận thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataGridViewAsync();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ValidationException valEx)
            {
                _logger.LogInformation(valEx,
                    "Validation failed on Add: {Input}",
                    txtTenQuan.Text);

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
            if (dgvQuan.SelectedRows.Count > 0)
            {
                try
                {
                    ValidateInputFields();

                    int maQuan = Convert.ToInt32(dgvQuan.SelectedRows[0].Cells[0].Value.ToString());
                    string tenQuan = txtTenQuan.Text.Trim();
                    DTO_Quan quan = new DTO_Quan(maQuan, tenQuan);

                    if (await _busQuan.UpdateQuanAsync(quan))
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
                    _logger.LogInformation(valEx,
                        "Validation failed on Update: {Input}",
                        txtTenQuan.Text);

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
            if (dgvQuan.SelectedRows.Count > 0)
            {
                int maQuan = Convert.ToInt32(dgvQuan.SelectedRows[0].Cells[0].Value.ToString());

                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa quận này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (await _busQuan.DeleteQuanAsync(maQuan))
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

        private void dgvQuan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQuan.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvQuan.SelectedRows[0];
                    txtTenQuan.Text = row.Cells["TenQuan"].Value?.ToString();
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
