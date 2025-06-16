using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Library;
using BUS_QuanLy;
using DTO_QuanLy;
using GUI_QuanLy.AddedClasses;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GUI_QuanLy
{
    public partial class GUI_PhieuThu : Form
    {
        private readonly IBUS_PhieuThu _busPhieuThu;
        private readonly IBUS_DaiLy _busDaiLy;

        private readonly IServiceProvider _service;

        private readonly ILogger<GUI_PhieuThu> _logger;

        private readonly BindingSource _bindingSource = new BindingSource();

        private DTO_DaiLy _daiLy = new DTO_DaiLy();
        private int _maPhieuThu = 0;
        private DTO_ChiTietPhanQuyen? permission;
        public GUI_PhieuThu(IBUS_PhieuThu busPhieuThu, IBUS_DaiLy busDaiLy, IServiceProvider service, ILogger<GUI_PhieuThu> logger)
        {
            _busPhieuThu = busPhieuThu;
            _busDaiLy = busDaiLy;
            _service = service;
            _logger = logger;
            InitializeComponent();
            dgvPhieuThu.DataSource = _bindingSource;
        }

        public void SetDaiLy(DTO_DaiLy daiLy)
        {
            _daiLy = daiLy;
        }

        public DTO_DaiLy GetDaiLy()
        {
            return _daiLy;
        }

        private async void GUI_PhieuThu_Load(object sender, EventArgs e)
        {
            try
            {
                await permissionLoadAsync();
                await LoadComboBoxDaiLyAsync();
                await LoadPhieuThuListByDaiLyAsync();
                

            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form PhieuThu load");

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
              

                permission = await permissionService.GetPermissionCurrentUserAsync("PhieuThu");

                if (permission == null || permission.Xem == false)
                {
                    _logger.LogWarning("No permission found for PhieuThu.");
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }


                btnAdd.Visible = permission.Them;
                btnEdit.Visible = permission.Sua;
                btnDelete.Visible = permission.Xoa;


            }
            catch
            {
                _logger.LogError("Failed to load permissions for PhieuXuat.");
                MessageBox.Show("Lỗi khi tải quyền truy cập. Vui lòng thử lại sau.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async Task LoadPhieuThuListByDaiLyAsync()
        {
            try
            {
                if (_daiLy.MaDaiLy == 0)
                {
                    var data = await _busPhieuThu.GetDataTablePhieuThuListAsync();
                    _bindingSource.DataSource = data;

                }
                else
                {
                    var data = await _busPhieuThu.GetDaTaTablePhieuThuByMaDLAsync(_daiLy.MaDaiLy);
                    _bindingSource.DataSource = data;
                }
                
                ModifyDataGridViewColumns();
                ClearInputFields();
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid PhieuThu by DaiLy: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private void ModifyDataGridViewColumns()
        {
            dgvPhieuThu.Columns["MaPhieuThu"].HeaderText = "Mã phiếu thu";
            dgvPhieuThu.Columns["NgayThuTien"].HeaderText = "Ngày thu tiền";
            dgvPhieuThu.Columns["SoTienThu"].HeaderText = "Số tiền thu";
            dgvPhieuThu.Columns["SoTienThu"].DefaultCellStyle.Format = "N0";
            dgvPhieuThu.Columns["TenDaiLy"].HeaderText = "Tên Đại Lý";
            dgvPhieuThu.Columns["MaDaiLy"].Visible = false;

            if (_daiLy.MaDaiLy != 0)
            {
                dgvPhieuThu.Columns["TenDaiLy"].Visible = false;
            }

            foreach (DataGridViewColumn dataColumn in dgvPhieuThu.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private async Task LoadComboBoxDaiLyAsync()
        {
            if (_daiLy.MaDaiLy == 0)
            {
                await LoadDaiLyListAsync();
            }
            else
                await LoadDaiLyAsync(_daiLy.MaDaiLy);
        }


        private async Task LoadDaiLyAsync(int maDaiLy)
        {
            try
            {
                var data = await _busDaiLy.GetDataTableDaiLyByMaAsync(_daiLy.MaDaiLy);
                cmbDaiLy.DataSource = data;
                cmbDaiLy.DisplayMember = "TenDaiLy";
                cmbDaiLy.ValueMember = "MaDaiLy";
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading DaiLy: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private async Task LoadDaiLyListAsync()
        {
            try
            {
                var data = await _busDaiLy.GetDTODaiLyListAsync();
                cmbDaiLy.DataSource = data;
                cmbDaiLy.DisplayMember = "TenDaiLy";
                cmbDaiLy.ValueMember = "MaDaiLy";
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading DaiLy list: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputFields();

                decimal soTienThu = Convert.ToDecimal(txtSoTienThu.Text);
                int maDaiLy = Convert.ToInt32(cmbDaiLy.SelectedValue);
                DTO_PhieuThu phieuThu = new DTO_PhieuThu(0, maDaiLy, dtpNgayThuTien.Value, soTienThu);

                if (await _busPhieuThu.AddPhieuThuAsync(phieuThu))
                {
                    MessageBox.Show("Thêm Phiếu thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadPhieuThuListByDaiLyAsync();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm Phiếu thu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (dgvPhieuThu.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa phiếu thu này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        ValidateInputFields();

                        int maDaiLy = Convert.ToInt32(cmbDaiLy.SelectedValue);
                        decimal soTienThu = Convert.ToDecimal(txtSoTienThu.Text);
                        DateTime ngayThu = dtpNgayThuTien.Value;
                        DTO_PhieuThu phieuThu = new DTO_PhieuThu(_maPhieuThu, maDaiLy, ngayThu, soTienThu);

                        if (await _busPhieuThu.UpdatePhieuThuAsync(phieuThu))
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadPhieuThuListByDaiLyAsync();
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
                    MessageBox.Show("Vui lòng chọn phiếu thu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtSoTienThu.Text) || txtSoTienThu.Text == ".")
            {
                var valEx = new ValidationException("Vui lòng nhập Số tiền thu!");
                _logger.LogWarning(valEx,
                                    "Validation failed: {Input}",
                                    txtSoTienThu.Text);
                throw valEx;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhieuThu.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa Phiếu thu này không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (await _busPhieuThu.DeletePhieuThuAsync(_maPhieuThu))
                        {
                            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadPhieuThuListByDaiLyAsync();
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
                MessageBox.Show("Vui lòng chọn phiếu thu cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ClearInputFields()
        {
            if (_daiLy.MaDaiLy == 0)
            {
                cmbDaiLy.SelectedValue = -1;
            }
            txtSoTienThu.Clear();
            dtpNgayThuTien.Value = DateTime.Now;

            dgvPhieuThu.ClearSelection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhieuThu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuThu.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvPhieuThu.SelectedRows[0];
                    _maPhieuThu = Convert.ToInt32(row.Cells["MaPhieuThu"].Value);
                    cmbDaiLy.SelectedValue = row.Cells["MaDaiLy"].Value;
                    dtpNgayThuTien.Value = Convert.ToDateTime(row.Cells["NgayThuTien"].Value);
                    txtSoTienThu.Text = row.Cells["SoTienThu"].Value.ToString();
                }

                catch (Exception ex)
                {
                    _logger.LogCritical(ex,
                        "Unexpected exception in dgv change selection");

                    MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSoTienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số và dấu chấm
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu chấm
            if (e.KeyChar == '.' && txtSoTienThu.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}

