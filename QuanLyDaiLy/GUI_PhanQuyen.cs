using BUS_Library;
using DTO_QuanLy;
using GUI_QuanLy.AddedClasses;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI_QuanLy
{
    public partial class GUI_PhanQuyen : UserControl
    {
        private readonly IBUS_NhomNguoiDung _busNhomNguoiDung;
        private readonly IBUS_NguoiDung _busNguoiDung;
        private readonly IBUS_ChucNang _busChucNang;
        private readonly IBUS_ChiTietPhanQuyen _busCTPhanQuyen;
        private readonly ILogger<GUI_PhanQuyen> _logger;
        private readonly IServiceProvider _services;
        private readonly BindingSource _bindingSourceNhomNguoiDung = new BindingSource();
        private readonly BindingSource _bindingSourceNguoiDung = new BindingSource();
        private readonly BindingSource _bindingSourceChucNang = new BindingSource();
        private readonly BindingSource _bindingSourceCTPhanQuyen = new BindingSource();

        private DTO_ChiTietPhanQuyen? permission;
        public GUI_PhanQuyen(IBUS_NhomNguoiDung busNhomNguoiDung, IBUS_NguoiDung busNguoiDung, IBUS_ChucNang busChucNang, IBUS_ChiTietPhanQuyen busCTPhanQuyen, ILogger<GUI_PhanQuyen> logger,IServiceProvider service)
        {
            _busNhomNguoiDung = busNhomNguoiDung;
            _busNguoiDung = busNguoiDung;
            _busChucNang = busChucNang;
            _busCTPhanQuyen = busCTPhanQuyen;
            _logger = logger;
            _services = service;
            InitializeComponent();
            dgvNhomNguoiDung.DataSource = _bindingSourceNhomNguoiDung;
            dgvNguoiDung.DataSource = _bindingSourceNguoiDung;
            dgvPhanQuyen.DataSource = _bindingSourceCTPhanQuyen;
        }

        private async void GUI_PhanQuyen_Load(object sender, EventArgs e)
        {
            try
            {
                await permissionLoadAsync();
                await LoadNhomNguoiDungListAsync();

                await LoadComboBoxNhomNguoiDungAsync();
                await LoadComboBoxChucNangAsync();

                await LoadNguoiDungListAsync();

                await LoadCTPhanQuyenListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form PhanQuyen load");

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


                permission = await permissionService.GetPermissionCurrentUserAsync("PhanQuyen");

                if (permission == null || permission.Xem == false)
                {
                    _logger.LogWarning("No permission found for Phan Quyen.");
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    
                    return;
                }

                // Kiểm tra quyền truy cập và ẩn các nút nếu không có quyền
                btnAddNhomNguoiDung.Visible = permission.Them;
                btnEditNhomNguoiDung.Visible = permission.Sua;
                btnXoaNhomNguoiDung.Visible = permission.Xoa;
                btnAddNguoiDung.Visible = permission.Them;
                btnEditNguoiDung.Visible = permission.Sua;
                btnXoaNguoiDung.Visible = permission.Xoa;
                btnAddPhanQuyen.Visible = permission.Them;
                btnEditPhanQuyen.Visible = permission.Sua;
                btnXoaPhanQuyen.Visible = permission.Xoa;







            }
            catch
            {
                _logger.LogError("Failed to load permissions for Phan Quyen.");
                MessageBox.Show("Lỗi khi tải quyền truy cập. Vui lòng thử lại sau.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        // Logic Nhom Nguoi dung
        private async Task LoadNhomNguoiDungListAsync()
        {
            try
            {
                var nhomNguoiDungList = await _busNhomNguoiDung.GetNhomNguoiDungListAsync();
                _bindingSourceNhomNguoiDung.DataSource = nhomNguoiDungList;

                ModifyDataGridViewColumnsNhomNguoiDung();
                ClearNhomNguoiDungInputFields();
            }

            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid Nhom Nguoi Dung: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ModifyDataGridViewColumnsNhomNguoiDung()
        {
            dgvNhomNguoiDung.Columns["MaNhom"].Visible = false;
            dgvNhomNguoiDung.Columns["TenNhom"].HeaderText = "Tên Nhóm";

            foreach (DataGridViewColumn dataColumn in dgvNhomNguoiDung.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ClearNhomNguoiDungInputFields()
        {
            txtTenNhomNguoiDung.Clear();
            dgvNhomNguoiDung.ClearSelection();
        }

        private async void btnAddNhomNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateNhomNguoiDungInputFields();

                var nhomNguoiDung = new DTO_NhomNguoiDung
                {
                    TenNhom = txtTenNhomNguoiDung.Text.Trim()
                };

                if (await _busNhomNguoiDung.AddNhomNguoiDungAsync(nhomNguoiDung))
                {
                    MessageBox.Show("Thêm Nhóm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadNhomNguoiDungListAsync();
                    ClearNhomNguoiDungInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm Nhóm người dùng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void ValidateNhomNguoiDungInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtTenNhomNguoiDung.Text))
            {
                var valEx = new ValidationException("Tên Nhóm người dùng không được để trống");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtTenNhomNguoiDung.Text);
                throw valEx;
            }
        }

        private async void btnEditNhomNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateNhomNguoiDungInputFields();

                int maNhom = Convert.ToInt32(dgvNhomNguoiDung.SelectedRows[0].Cells["MaNhom"].Value);
                var nhomNguoiDung = new DTO_NhomNguoiDung
                {
                    MaNhom = maNhom,
                    TenNhom = txtTenNhomNguoiDung.Text.Trim()
                };

                if (await _busNhomNguoiDung.UpdateNhomNguoiDungAsync(nhomNguoiDung))
                {
                    MessageBox.Show("Cập nhật Nhóm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadNhomNguoiDungListAsync();
                    ClearNhomNguoiDungInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật Nhóm người dùng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private async void btnDeleteNhomNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNhomNguoiDung.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn Nhóm người dùng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maNhom = Convert.ToInt32(dgvNhomNguoiDung.SelectedRows[0].Cells["MaNhom"].Value);

                if (await _busNhomNguoiDung.DeleteNhomNguoiDungAsync(maNhom))
                {
                    MessageBox.Show("Xóa Nhóm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadNhomNguoiDungListAsync();
                    ClearNhomNguoiDungInputFields();
                }
                else
                {
                    MessageBox.Show("Xóa Nhóm người dùng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgvNhomNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhomNguoiDung.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvNhomNguoiDung.SelectedRows[0];
                    txtTenNhomNguoiDung.Text = row.Cells["TenNhom"].Value.ToString();
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex,
                        "Unexpected exception in dgv change selection");

                    MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }








        // Logic Nguoi Dung
        private async Task LoadNguoiDungListAsync()
        {
            try
            {
                var dataTable = await _busNguoiDung.GetDataTableNguoiDungListAsync();
                _bindingSourceNguoiDung.DataSource = dataTable;

                ModifyDataGridViewColumnsNguoiDung();
                ClearNguoiDungInputFields();
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid Nguoi Dung: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ModifyDataGridViewColumnsNguoiDung()
        {
            dgvNguoiDung.Columns["TenNguoiDung"].HeaderText = "Tên đăng nhập";
            dgvNguoiDung.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dgvNguoiDung.Columns["MaNhom"].Visible = false;
            dgvNguoiDung.Columns["TenNhom"].HeaderText = "Tên Nhóm";

            foreach (DataGridViewColumn dataColumn in dgvNguoiDung.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ClearNguoiDungInputFields()
        {
            txtTenTaiKhoan.Clear();
            txtMatKhau.Clear();
            cbxNhomNguoiDung.SelectedIndex = -1;
            dgvNguoiDung.ClearSelection();
        }

        private async Task LoadComboBoxNhomNguoiDungAsync()
        {
            try
            {
                cbxNhomNguoiDung.DataSource = await _busNhomNguoiDung.GetNhomNguoiDungListAsync();
                cbxNhomNguoiDung.DisplayMember = nameof(DTO_NhomNguoiDung.TenNhom);
                cbxNhomNguoiDung.ValueMember = nameof(DTO_NhomNguoiDung.MaNhom);

                cbxNhomNguoiDungPhanQuyen.DataSource = await _busNhomNguoiDung.GetNhomNguoiDungListAsync();
                cbxNhomNguoiDungPhanQuyen.DisplayMember = nameof(DTO_NhomNguoiDung.TenNhom);
                cbxNhomNguoiDungPhanQuyen.ValueMember = nameof(DTO_NhomNguoiDung.MaNhom);
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading ComboBox Nhom Nguoi Dung: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async void btnAddNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateNguoiDungInputFields();

                var nguoiDung = new DTO_NguoiDung
                {
                    TenNguoiDung = txtTenTaiKhoan.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    MaNhom = Convert.ToInt32(cbxNhomNguoiDung.SelectedValue)
                };

                if (await _busNguoiDung.AddNguoiDungAsync(nguoiDung))
                {
                    MessageBox.Show("Thêm Người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadNguoiDungListAsync();
                    ClearNguoiDungInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm Người dùng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void ValidateNguoiDungInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtTenTaiKhoan.Text))
            {
                var valEx = new ValidationException("Tên đăng nhập không được để trống");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtTenTaiKhoan.Text);
                throw valEx;
            }

            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                var valEx = new ValidationException("Mật khẩu không được để trống");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtMatKhau.Text);
                throw valEx;
            }

            if (cbxNhomNguoiDung.SelectedIndex == -1)
            {
                var valEx = new ValidationException("Vui lòng chọn Nhóm người dùng");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    cbxNhomNguoiDung.SelectedValue);
                throw valEx;
            }
        }

        private async void btnEditNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateNguoiDungInputFields();

                var nguoiDung = new DTO_NguoiDung
                {
                    TenNguoiDung = txtTenTaiKhoan.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    MaNhom = Convert.ToInt32(cbxNhomNguoiDung.SelectedValue)
                };

                if (await _busNguoiDung.UpdateNguoiDungAsync(nguoiDung))
                {
                    MessageBox.Show("Cập nhật Người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadNguoiDungListAsync();
                    ClearNguoiDungInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật Người dùng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private async void btnDeleteNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNguoiDung.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn Người dùng để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tenNguoiDung = dgvNguoiDung.SelectedRows[0].Cells["TenNguoiDung"].Value.ToString();

                if (await _busNguoiDung.DeleteNguoiDungAsync(tenNguoiDung))
                {
                    MessageBox.Show("Xóa Người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadNguoiDungListAsync();
                    ClearNguoiDungInputFields();
                }
                else
                {
                    MessageBox.Show("Xóa Người dùng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgvNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNguoiDung.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvNguoiDung.SelectedRows[0];
                    txtTenTaiKhoan.Text = row.Cells["TenNguoiDung"].Value.ToString();
                    txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                    cbxNhomNguoiDung.SelectedValue = row.Cells["MaNhom"].Value;
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex,
                        "Unexpected exception in dgv change selection");

                    MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        //Chi Tiet phan quyen
        private async Task LoadCTPhanQuyenListAsync()
        {
            try
            {
                var dataTable = await _busCTPhanQuyen.GetDataTableCTPhanQuyenAsync();
                _bindingSourceCTPhanQuyen.DataSource = dataTable;

                ModifyDataGridViewColumnsCTPhanQuyen();
                ClearCTPhanQuyenInputFields();
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid Chi Tiet Phan Quyen: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ModifyDataGridViewColumnsCTPhanQuyen()
        {
            dgvPhanQuyen.Columns["MaNhom"].Visible = false;
            dgvPhanQuyen.Columns["TenNhom"].HeaderText = "Tên Nhóm";
            dgvPhanQuyen.Columns["MaChucNang"].Visible = false;
            dgvPhanQuyen.Columns["TenManHinhDuocLoad"].HeaderText = "Tên Màn hình được load";
            dgvPhanQuyen.Columns["Xem"].HeaderText = "Xem";
            dgvPhanQuyen.Columns["Them"].HeaderText = "Thêm";
            dgvPhanQuyen.Columns["Xoa"].HeaderText = "Xoá";
            dgvPhanQuyen.Columns["Sua"].HeaderText = "Sửa";


            foreach (DataGridViewColumn dataColumn in dgvPhanQuyen.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ClearCTPhanQuyenInputFields()
        {
            cbxNhomNguoiDungPhanQuyen.SelectedIndex = -1;
            cbxChucNang.SelectedIndex = -1;
            chkXem.Checked = false;
            chkThem.Checked = false;
            chkXoa.Checked = false;
            chkSua.Checked = false;
            dgvPhanQuyen.ClearSelection();
        }


        private async Task LoadComboBoxChucNangAsync()
        {
            try
            {
                var data = await _busChucNang.GetChucNangListAsync();
                cbxChucNang.DataSource = data;
                cbxChucNang.DisplayMember = nameof(DTO_ChucNang.TenManHinhDuocLoad);
                cbxChucNang.ValueMember = nameof(DTO_ChucNang.MaChucNang);
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading ComboBox Chuc Nang: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }



        private async void btnAddPhanQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateCTPhanQuyenInputFields();

                var ctPhanQuyen = new DTO_ChiTietPhanQuyen
                {
                    MaNhom = Convert.ToInt32(cbxNhomNguoiDungPhanQuyen.SelectedValue),
                    MaChucNang = Convert.ToInt32(cbxChucNang.SelectedValue),
                    Xem = chkXem.Checked,
                    Them = chkThem.Checked,
                    Xoa = chkXoa.Checked,
                    Sua = chkSua.Checked
                };

                if (await _busCTPhanQuyen.AddCTPhanQuyenAsync(ctPhanQuyen))
                {
                    MessageBox.Show("Thêm Chi tiết phân quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadCTPhanQuyenListAsync();
                    ClearCTPhanQuyenInputFields();
                }
                else
                {
                    MessageBox.Show("Thêm Chi tiết phân quyền thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void ValidateCTPhanQuyenInputFields()
        {
            if (cbxNhomNguoiDungPhanQuyen.SelectedIndex == -1)
            {
                var valEx = new ValidationException("Vui lòng chọn Nhóm người dùng");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    cbxNhomNguoiDungPhanQuyen.SelectedValue);
                throw valEx;
            }

            if (cbxChucNang.SelectedIndex == -1)
            {
                var valEx = new ValidationException("Vui lòng chọn Chức năng");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    cbxChucNang.SelectedValue);
                throw valEx;
            }
        }


        private async void btnEditPhanQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateCTPhanQuyenInputFields();

                if (dgvPhanQuyen.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn Chi tiết phân quyền để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ctPhanQuyen = new DTO_ChiTietPhanQuyen
                {
                    MaNhom = Convert.ToInt32(cbxNhomNguoiDungPhanQuyen.SelectedValue),
                    MaChucNang = Convert.ToInt32(cbxChucNang.SelectedValue),
                    Xem = chkXem.Checked,
                    Them = chkThem.Checked,
                    Xoa = chkXoa.Checked,
                    Sua = chkSua.Checked
                };

                if (await _busCTPhanQuyen.UpdateCTPhanQuyenAsync(ctPhanQuyen))
                {
                    MessageBox.Show("Cập nhật Chi tiết phân quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadCTPhanQuyenListAsync();
                    ClearCTPhanQuyenInputFields();
                }
                else
                {
                    MessageBox.Show("Cập nhật Chi tiết phân quyền thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private async void btnXoaPhanQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhanQuyen.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn Chi tiết phân quyền để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maNhom = Convert.ToInt32(cbxNhomNguoiDungPhanQuyen.SelectedValue);
                int maChucNang = Convert.ToInt32(cbxChucNang.SelectedValue);

                if (await _busCTPhanQuyen.DeleteCTPhanQuyenAsync(maNhom, maChucNang))
                {
                    MessageBox.Show("Xóa Chi tiết phân quyền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadCTPhanQuyenListAsync();
                    ClearCTPhanQuyenInputFields();
                }
                else
                {
                    MessageBox.Show("Xóa Chi tiết phân quyền thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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



        private void dgvPhanQuyen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhanQuyen.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvPhanQuyen.SelectedRows[0];
                    cbxNhomNguoiDungPhanQuyen.SelectedValue = row.Cells["MaNhom"].Value;
                    cbxChucNang.SelectedValue = row.Cells["MaChucNang"].Value;
                    chkXem.Checked = Convert.ToBoolean(row.Cells["Xem"].Value);
                    chkThem.Checked = Convert.ToBoolean(row.Cells["Them"].Value);
                    chkXoa.Checked = Convert.ToBoolean(row.Cells["Xoa"].Value);
                    chkSua.Checked = Convert.ToBoolean(row.Cells["Sua"].Value);
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
