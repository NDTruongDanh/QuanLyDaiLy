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
using GUI_QuanLy.AddedClasses;
using Microsoft.Extensions.DependencyInjection;

namespace GUI_QuanLy
{
    public partial class GUI_MatHang : Form
    {
        private readonly IBUS_MatHang _busMatHang;
        private readonly IBUS_DonViTinh _busDonViTinh;
        private readonly ILogger<GUI_MatHang> _logger;
        private readonly BindingSource _bindingSource = new BindingSource();
        private readonly IServiceProvider _services;
        private int _maMatHang = 0;
        private DTO_ChiTietPhanQuyen? permission;
        public GUI_MatHang(IBUS_MatHang busMatHang, IBUS_DonViTinh busDonViTinh, ILogger<GUI_MatHang> logger, IServiceProvider services)
        {
            _busMatHang = busMatHang;
            _busDonViTinh = busDonViTinh;
            _logger = logger;
            InitializeComponent();
            dgvMatHang.DataSource = _bindingSource;
            _services = services;
        }


        private async void GUI_MatHang_Load(object sender, EventArgs e)
        {
            try
            {
                await permissionLoadAsync();
                await LoadComboBoxDonViTinhAsync();
                await LoadMatHangAsync();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form MatHang load");

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
                var permissionService = _services.GetRequiredService<PermissionService>();


                permission = await permissionService.GetPermissionCurrentUserAsync("MatHang");

                if (permission == null || permission.Xem == false)
                {
                    _logger.LogWarning("No permission found for MatHang.");
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }


                btnAdd.Visible = permission.Them;
                btnRefresh.Visible = permission.Sua;
                btnDelete.Visible = permission.Xoa;


            }
            catch
            {
                _logger.LogError("Failed to load permissions for MatHang.");
                MessageBox.Show("Lỗi khi tải quyền truy cập. Vui lòng thử lại sau.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private async Task LoadMatHangAsync()
        {
            try
            {
                var dataTable = await _busMatHang.GetDataTableMatHangAsync();
                _bindingSource.DataSource = dataTable;

                ModifyDataGridViewColumns();
                ClearInputFields();
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid DaiLy: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ModifyDataGridViewColumns()
        {
            dgvMatHang.Columns["MaMatHang"].Visible = false;
            dgvMatHang.Columns["MaDonViTinh"].Visible = false;
            dgvMatHang.Columns["DonGiaHienTai"].DefaultCellStyle.Format = "N0";
            dgvMatHang.Columns["TonKho"].DefaultCellStyle.Format = "N0";

            dgvMatHang.Columns["TenMatHang"].HeaderText = "Tên Mặt hàng";
            dgvMatHang.Columns["DonGiaHienTai"].HeaderText = "Đơn giá hiện tại";
            dgvMatHang.Columns["TonKho"].HeaderText = "Tồn kho";
            dgvMatHang.Columns["TenDonViTinh"].HeaderText = "Đơn vị tính";
        }
        private async Task LoadComboBoxDonViTinhAsync()
        {
            try
            {
                var donViTinhList = await _busDonViTinh.GetDonViTinhListAsync();
                cmbDonViTinh.DataSource = donViTinhList;
                cmbDonViTinh.DisplayMember = "TenDonViTinh";
                cmbDonViTinh.ValueMember = "MaDonViTinh";
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading ComboBox DonViTin in MatHang: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ClearInputFields()
        {
            txtTenMatHang.Clear();
            cmbDonViTinh.SelectedIndex = -1;

            dgvMatHang.ClearSelection();
        }

        private void ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtTenMatHang.Text))
            {
                var valEx = new ValidationException("Tên Mặt hàng không được để trống");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtTenMatHang.Text);
                throw valEx;
            }
            if (cmbDonViTinh.SelectedIndex < 0)
            {
                var valEx = new ValidationException("Vui lòng chọn Đơn vị tính");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    cmbDonViTinh.Text);
                throw valEx;
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputFields();

                string tenMatHang = txtTenMatHang.Text;
                int maDonViTinh = Convert.ToInt16(cmbDonViTinh.SelectedValue);
                if (await _busMatHang.AddMatHangDefault(tenMatHang, maDonViTinh))
                {
                    MessageBox.Show("Thêm Mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadMatHangAsync();
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
            if (dgvMatHang.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa loại đại lý này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        ValidateInputFields();

                        DTO_MatHang matHang = new DTO_MatHang
                        {
                            MaMatHang = Convert.ToInt32(dgvMatHang.SelectedRows[0].Cells["MaMatHang"].Value),
                            TenMatHang = txtTenMatHang.Text,
                            MaDonViTinh = Convert.ToInt16(cmbDonViTinh.SelectedValue),
                            DonGiaHienTai = Convert.ToDecimal(dgvMatHang.SelectedRows[0].Cells["DonGiaHienTai"].Value),
                            TonKho = Convert.ToInt32(dgvMatHang.SelectedRows[0].Cells["TonKho"].Value)
                        };

                        if (await _busMatHang.UpdateMatHangAsync(matHang))
                        {
                            MessageBox.Show("Sửa Mặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadMatHangAsync();
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Sửa Mặt hàng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Vui lòng chọn mặt hàng cần sửa.");
            }
        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMatHang.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (await _busMatHang.DeleteMatHangAsync(_maMatHang))
                        {
                            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadMatHangAsync();
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
                MessageBox.Show("Vui lòng chọn mặt hàng cần xóa.");
            }
        }


        private void dgvMatHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMatHang.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvMatHang.SelectedRows[0];
                    _maMatHang = Convert.ToInt32(row.Cells["MaMatHang"].Value);
                    txtTenMatHang.Text = row.Cells["TenMatHang"].Value.ToString();
                    cmbDonViTinh.SelectedValue = row.Cells["MaDonViTinh"].Value;
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex,
                        "Unexpected exception in dgv change selection");

                    MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
