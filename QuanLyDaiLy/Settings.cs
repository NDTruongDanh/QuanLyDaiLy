using BUS_Library;
using BUS_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GUI_QuanLy
{
    public partial class Settings : UserControl
    {
        private readonly IBUS_ThamSo _busThamSo;
        private readonly IBUS_LoaiDaiLy _busLoaiDaiLy;
        private readonly IBUS_DonViTinh _busDonViTinh;
        private readonly IBUS_Quan _busQuan;
        private readonly ILogger<Settings> _logger;
        private readonly BindingSource _bindingSourceLDL = new BindingSource();
        private readonly BindingSource _bindingSourceDVT = new BindingSource();
        private readonly BindingSource _bindingSourceQuan = new BindingSource();




        private DTO_ThamSo _thamSo;
        public Settings(IBUS_ThamSo busThamSo, IBUS_LoaiDaiLy busLoaiDaiLy, IBUS_DonViTinh busDonViTinh, IBUS_Quan busQuan, ILogger<Settings> logger)
        {
            _busThamSo = busThamSo;
            _busLoaiDaiLy = busLoaiDaiLy;
            _busDonViTinh = busDonViTinh;
            _busQuan = busQuan;
            _logger = logger;
            InitializeComponent();
            dgvLoaiDaiLy.DataSource = _bindingSourceLDL;
            dgvDVT.DataSource = _bindingSourceDVT;
            dgvQuan.DataSource = _bindingSourceQuan;
        }

        private async void Settings_Load(object sender, EventArgs e)
        {
            try
            {
                this.Dock = DockStyle.Top;

                await LoadThamSoAsync();
                await LoadLoaiDaiLyAsync();
                await LoadDonViTinhAsync();
                await LoadQuanAsync();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form ThamSo load");

                MessageBox.Show(
                    "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private async Task LoadThamSoAsync()
        {
            try
            {
                _thamSo = await _busThamSo.GetThamSoAsync();
                LoadControlsContent();
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


        private void LoadControlsContent()
        {
            txtSoQLToiDa.Text = _thamSo.DaiLyToiDa.ToString();
            txtTiLeDGXuat.Text = _thamSo.TiLeTinhDonGiaXuat.ToString();
            if (_thamSo.ApDungQDKiemTraTienThu)
            {
                cbApDungKTQD.Checked = true;
            }
            else
            {
                cbApDungKTQD.Checked = false;
            }
        }



        private async Task LoadLoaiDaiLyAsync()
        {
            try
            {
                var data = await _busLoaiDaiLy.GetLoaiDaiLyListAsync();
                _bindingSourceLDL.DataSource = data;

                ModifyDataGridViewColumnsLDL();
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


        private void ModifyDataGridViewColumnsLDL()
        {
            dgvLoaiDaiLy.Columns["MaLoaiDaiLy"].Visible = false;
            dgvLoaiDaiLy.Columns["TenLoaiDaiLy"].HeaderText = "Tên Loại Đại Lý";
            dgvLoaiDaiLy.Columns["TienNoToiDa"].HeaderText = "Tiền nợ tối đa";

            foreach (DataGridViewColumn dataColumn in dgvLoaiDaiLy.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private async Task LoadDonViTinhAsync()
        {
            try
            {
                var data = await _busDonViTinh.GetDonViTinhListAsync();
                _bindingSourceDVT.DataSource = data;

                ModifyDataGridViewColumnsDVT();
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid DonViTinh: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private void ModifyDataGridViewColumnsDVT()
        {
            dgvDVT.Columns["MaDonViTinh"].Visible = false;
            dgvDVT.Columns["TenDonViTinh"].HeaderText = "Tên Đơn Vị Tính";

            foreach (DataGridViewColumn dataColumn in dgvDVT.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private async Task LoadQuanAsync()
        {
            try
            {
                var data = await _busQuan.GetQuanListAsync();
                _bindingSourceQuan.DataSource = data;

                ModifyDataGridViewColumnsQuan();
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



        private void ModifyDataGridViewColumnsQuan()
        {
            dgvQuan.Columns["MaQuan"].Visible = false;
            dgvQuan.Columns["TenQuan"].HeaderText = "Tên Quận";

            foreach (DataGridViewColumn dataColumn in dgvQuan.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private async void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateThamSoInputFields();

                var thamSo = new DTO_ThamSo
                {
                    DaiLyToiDa = int.Parse(txtSoQLToiDa.Text),
                    TiLeTinhDonGiaXuat = float.Parse(txtTiLeDGXuat.Text),
                    ApDungQDKiemTraTienThu = cbApDungKTQD.Checked
                };

                if (await _busThamSo.UpdateThamSoAsync(thamSo))
                {
                    MessageBox.Show("Cập nhật Tham số thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadThamSoAsync();
                }
                else
                {
                    MessageBox.Show("Cập nhật Tham số thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ValidationException valEx)
            {
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    valEx.Message);

                MessageBox.Show(valEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error updating Tham So: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form ThamSo edit");

                MessageBox.Show(
                    "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ValidateThamSoInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtSoQLToiDa.Text))
            {
                throw new ValidationException("Số quận không được để trống");
            }
            if (string.IsNullOrWhiteSpace(txtTiLeDGXuat.Text))
            {
                throw new ValidationException("Tỉ lệ không được để trống");
            }
        }


        private void txtSoQLToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtTiLeDGXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }


        private async void btnThamSo_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateThamSoInputFields();

                var thamSo = new DTO_ThamSo
                {
                    DaiLyToiDa = int.Parse(txtSoQLToiDa.Text),
                    TiLeTinhDonGiaXuat = float.Parse(txtTiLeDGXuat.Text),
                    ApDungQDKiemTraTienThu = cbApDungKTQD.Checked
                };

                if (await _busThamSo.UpdateThamSoAsync(thamSo))
                {
                    MessageBox.Show("Cập nhật Chi Tiet Phieu Nhap thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadThamSoAsync();
                }
                else
                {
                    MessageBox.Show("Cập nhật Chi Tiet Phieu Nhap thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ValidationException valEx)
            {
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    valEx.Message);

                MessageBox.Show(valEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error updating ChiTietPhieuXuat: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form ThamSo edit");

                MessageBox.Show(
                    "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnAddLoaiDaiLy_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateLoaiDaiLyInputFields();

                string tenDaiLy = txtTenLoaiDaiLy.Text.Trim();
                decimal tienNoToiDa = Convert.ToDecimal(txtTienNoToiDa.Text);
                var loaiDaiLy = new DTO_LoaiDaiLy(0, tenDaiLy, tienNoToiDa);

                if (await _busLoaiDaiLy.AddLoaiDaiLyAsync(loaiDaiLy))
                {
                    MessageBox.Show("Thêm Loại Đại lý thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadLoaiDaiLyAsync();
                    ClearLoaiDaiLyInputFields();
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


        private void ValidateLoaiDaiLyInputFields()
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

        private void ClearLoaiDaiLyInputFields()
        {
            txtTenLoaiDaiLy.Clear();
            txtTienNoToiDa.Clear();

            dgvLoaiDaiLy.ClearSelection();
        }


        private async void btnEditLoaiDaiLy_Click(object sender, EventArgs e)
        {
            if (dgvLoaiDaiLy.SelectedRows.Count > 0)
            {
                try
                {
                    ValidateLoaiDaiLyInputFields();

                    int maLoaiDaiLy = Convert.ToInt32(dgvLoaiDaiLy.SelectedRows[0].Cells["MaLoaiDaiLy"].Value);
                    string tenLoaiDaiLy = txtTenLoaiDaiLy.Text;
                    decimal tienNoToiDa = Convert.ToDecimal(txtTienNoToiDa.Text);

                    var loaiDaiLy = new DTO_LoaiDaiLy(maLoaiDaiLy, tenLoaiDaiLy, tienNoToiDa);

                    if (await _busLoaiDaiLy.UpdateLoaiDaiLyAsync(loaiDaiLy))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadLoaiDaiLyAsync();
                        ClearLoaiDaiLyInputFields();
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

        private async void btnXoaLoaiDaiLy_Click(object sender, EventArgs e)
        {
            if (dgvLoaiDaiLy.SelectedRows.Count > 0)
            {
                int maLoaiDaiLy = Convert.ToInt32(dgvLoaiDaiLy.SelectedRows[0].Cells["MaLoaiDaiLy"].Value);

                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa loại đại lý này không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (await _busLoaiDaiLy.DeleteLoaiDaiLyAsync(maLoaiDaiLy))
                        {
                            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadLoaiDaiLyAsync();
                            ClearLoaiDaiLyInputFields();
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

        private async void btnAddDonViTinh_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateDVTInputField();

                DTO_DonViTinh donViTinh = new DTO_DonViTinh(0, txtDonViTinh.Text);
                if (await _busDonViTinh.AddDonViTinhAsync(donViTinh))
                {
                    MessageBox.Show("Thêm Đơn vị tính thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDonViTinhAsync();
                    ClearDVTInputFields();
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


        private void ValidateDVTInputField()
        {
            if (string.IsNullOrWhiteSpace(txtDonViTinh.Text))
            {
                var valEx = new ValidationException("Tên Đơn vị tính không được để trống");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtDonViTinh.Text);
                throw valEx;
            }
        }

        private void ClearDVTInputFields()
        {
            txtDonViTinh.Clear();
        }

        private async void btnEditDonViTinh_Click(object sender, EventArgs e)
        {
            if (dgvDVT.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa Đơn vị tính này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        ValidateDVTInputField();

                        int maDVT = Convert.ToInt32(dgvDVT.SelectedRows[0].Cells["MaDonViTinh"].Value.ToString());
                        if (await _busDonViTinh.UpdateDonViTinhAsync(new DTO_DonViTinh(maDVT, txtDonViTinh.Text)))
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadDonViTinhAsync();
                            ClearDVTInputFields();
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
                MessageBox.Show("Vui lòng chọn đơn vị tính để sửa.");
            }
        }

        private async void btnXoaDonViTinh_Click(object sender, EventArgs e)
        {
            if (dgvDVT.SelectedRows.Count > 0)
            {
                try
                {
                    int maDVT = Convert.ToInt32(dgvDVT.SelectedRows[0].Cells["MaDonViTinh"].Value);
                    if (await _busDonViTinh.DeleteDonViTinhAsync(maDVT))
                    {
                        MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadDonViTinhAsync();
                        ClearDVTInputFields();
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
            else
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính để xóa.");
            }
        }

        private async void btnAddQuan_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateQuanInputFields();

                DTO_Quan quan = new DTO_Quan(0, txtQuan.Text.Trim());
                if (await _busQuan.AddQuanAsync(quan))
                {
                    MessageBox.Show("Thêm Quận thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadQuanAsync();
                    ClearQuanInputFields();
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
                    txtQuan.Text);

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

        private void ClearQuanInputFields()
        {
            txtQuan.Clear();
        }

        private void ValidateQuanInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtQuan.Text))
            {
                throw new ValidationException("Tên quận không được để trống");
            }
        }

        private async void btnEditQuan_Click(object sender, EventArgs e)
        {
            if (dgvQuan.SelectedRows.Count > 0)
            {
                try
                {
                    ValidateQuanInputFields();

                    int maQuan = Convert.ToInt32(dgvQuan.SelectedRows[0].Cells["MaQuan"].Value.ToString());
                    string tenQuan = txtQuan.Text.Trim();
                    DTO_Quan quan = new DTO_Quan(maQuan, tenQuan);

                    if (await _busQuan.UpdateQuanAsync(quan))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadQuanAsync();
                        ClearQuanInputFields();
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
                        txtQuan.Text);

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

        private async void btnXoaQuan_Click(object sender, EventArgs e)
        {
            if (dgvQuan.SelectedRows.Count > 0)
            {
                int maQuan = Convert.ToInt32(dgvQuan.SelectedRows[0].Cells["MaQuan"].Value.ToString());

                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa quận này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (await _busQuan.DeleteQuanAsync(maQuan))
                        {
                            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadQuanAsync();
                            ClearQuanInputFields();
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

        private void txtTienNoToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
