using System;
using System.Data;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

using BUS_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.DependencyInjection;
using GUI_QuanLy.CommonClass;
using BUS_Library;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Net.NetworkInformation;

namespace GUI_QuanLy
{
    public partial class GUI_DaiLy : Form
    {
        private readonly IBUS_DaiLy _busDaiLy;

        private readonly IBUS_LoaiDaiLy _busLoai;

        private readonly IBUS_Quan _busQuan;

        private readonly IBUS_PhieuThu _busPhieuThu;

        private readonly IBUS_PhieuXuat _busPhieuXuat;

        private readonly IServiceProvider _services;

        private readonly ILogger<GUI_DaiLy> _logger;

        private readonly BindingSource _bindingSource = new BindingSource();

        private int _maDaiLy = 0;

        public GUI_DaiLy(IBUS_LoaiDaiLy busLoai, IBUS_Quan busQuan, IBUS_DaiLy busDaiLy, IBUS_PhieuThu busPhieuThu, IServiceProvider services, ILogger<GUI_DaiLy> logger)
        {
            _busLoai = busLoai;
            _busQuan = busQuan;
            _busDaiLy = busDaiLy;
            _busPhieuThu = busPhieuThu;
            _services = services;
            _logger = logger;
            InitializeComponent();
            dgvDaiLy.DataSource = _bindingSource;
        }

        private async void GUI_DaiLy_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadDaiLyAsync();
                await LoadComboBoxsLoaiDaiLyAsync();
                await LoadComboBoxsQuanAsync();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form DaiLy load");

                MessageBox.Show(
                    "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private async Task LoadDaiLyAsync()
        {
            try
            {
                DataTable dataTable = await _busDaiLy.GetDataTableDaiLyListAsync();
                _bindingSource.DataSource = dataTable;

                ModifyDataGridViewColumns();
               
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
            dgvDaiLy.Columns["MaDaiLy"].HeaderText = "Mã Đại lý";
            dgvDaiLy.Columns["TenDaiLy"].HeaderText = "Tên Đại lý";
            dgvDaiLy.Columns["TenLoaiDaiLy"].HeaderText = "Loại Đại lý";
            dgvDaiLy.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvDaiLy.Columns["Email"].HeaderText = "Email";
            dgvDaiLy.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvDaiLy.Columns["TenQuan"].HeaderText = "Quận";
            dgvDaiLy.Columns["NgayTiepNhan"].HeaderText = "Ngày tiếp nhận";
            dgvDaiLy.Columns["TongNo"].HeaderText = "Tổng nợ";
            dgvDaiLy.Columns["MaDaiLy"].Visible = false;

            foreach (DataGridViewColumn dataColumn in dgvDaiLy.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private async Task LoadComboBoxsLoaiDaiLyAsync()
        {
            try
            {
                cboLoaiDaiLy.DataSource = await _busLoai.GetLoaiDaiLyListAsync();
                cboLoaiDaiLy.DisplayMember = nameof(DTO_LoaiDaiLy.TenLoaiDaiLy);
                cboLoaiDaiLy.ValueMember = nameof(DTO_LoaiDaiLy.MaLoaiDaiLy);
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading ComboBoxo LoaiDaiLy in DaiLy: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async Task LoadComboBoxsQuanAsync()
        {
            try
            {
                cboQuan.DataSource = await _busQuan.GetQuanListAsync();
                cboQuan.DisplayMember = nameof(DTO_Quan.TenQuan);
                cboQuan.ValueMember = nameof(DTO_Quan.MaQuan);
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading ComboBox Quan: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private void ClearInputFields()
        {
            txtTenDaiLy.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            //txtTongNo.Clear();  
            cboLoaiDaiLy.SelectedIndex = -1;
            cboQuan.SelectedIndex = -1;
            dtpNgayTiepNhan.Value = DateTime.Now; // Set to current date instead of attempting to clear  
            dgvDaiLy.ClearSelection(); // Clear selection in DataGridView
        }

        private void ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtTenDaiLy.Text))
            {
                var valEx = new ValidationException("Tên đại lý không được để trống");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtTenDaiLy.Text);
                throw valEx;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                var valEx = new ValidationException("Địa chỉ không được để trống");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtDiaChi.Text);
                throw valEx;
            }
            if (cboLoaiDaiLy.SelectedIndex == -1)
            {
                var valEx = new ValidationException("Vui lòng chọn Loại Đại lý");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    cboLoaiDaiLy.Text);
                throw valEx;
            }
            if (cboQuan.SelectedIndex == -1)
            {
                var valEx = new ValidationException("Vui lòng chọn Quận");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    cboQuan.Text);
                throw valEx;
            }
            if (!CommonChecks.IsValidPhoneNumber(txtSDT.Text))
            {
                var valEx = new ValidationException("Số điện thoại không hợp lệ");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtSDT.Text);
                throw valEx;
            }
            if (!CommonChecks.IsValidEmail(txtEmail.Text))
            {
                var valEx = new ValidationException("Email không hợp lệ");
                _logger.LogWarning(valEx,
                    "Validation failed: {Input}",
                    txtEmail.Text);
                throw valEx;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputFields();

                string tenDaiLy = txtTenDaiLy.Text.Trim();
                string sdt = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                string diaChi = txtDiaChi.Text.Trim();
                int maLoaiDaiLy = Convert.ToInt32(cboLoaiDaiLy.SelectedValue);
                int maQuan = Convert.ToInt32(cboQuan.SelectedValue);
                DateTime ngayTiepNhan = dtpNgayTiepNhan.Value;

                DTO_DaiLy daiLy = new DTO_DaiLy(0, tenDaiLy, maLoaiDaiLy, sdt, email, diaChi, maQuan, ngayTiepNhan, 0);
                if (await _busDaiLy.AddDaiLyAsync(daiLy))
                {
                    MessageBox.Show("Thêm Đại lý thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDaiLyAsync();
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
            if (dgvDaiLy.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa loại đại lý này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        ValidateInputFields();

                        string tenDaiLy = txtTenDaiLy.Text.Trim();
                        string sdt = txtSDT.Text.Trim();
                        string email = txtEmail.Text.Trim();
                        string diaChi = txtDiaChi.Text.Trim();
                        int maLoaiDaiLy = Convert.ToInt32(cboLoaiDaiLy.SelectedValue);
                        int maQuan = Convert.ToInt32(cboQuan.SelectedValue);
                        DateTime ngayTiepNhan = dtpNgayTiepNhan.Value;
                        decimal tongNo = Convert.ToDecimal(dgvDaiLy.SelectedRows[0].Cells["TongNo"].Value);

                        DTO_DaiLy daiLy = new DTO_DaiLy(_maDaiLy, tenDaiLy, maLoaiDaiLy, sdt, email, diaChi, maQuan, ngayTiepNhan, tongNo);
                        if (await _busDaiLy.UpdateDaiLyAsync(daiLy))
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadDaiLyAsync();
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
                MessageBox.Show("Vui lòng chọn dòng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDaiLy.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa loại đại lý này không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int maDL = Convert.ToInt32(dgvDaiLy.SelectedRows[0].Cells[0].Value);

                        if (await _busDaiLy.DeleteDailyAsync(maDL))
                        {
                            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadDaiLyAsync();
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

        private void dgvDaiLy_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvDaiLy.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvDaiLy.ClearSelection();
                    dgvDaiLy.Rows[hitTestInfo.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dgvDaiLy, e.Location);
                }
            }
        }

        private void dgvDaiLy_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvDaiLy.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvDaiLy.SelectedRows[0];
                    _maDaiLy = Convert.ToInt32(row.Cells["MaDaiLy"]?.Value);
                    txtTenDaiLy.Text = row.Cells["TenDaiLy"].Value?.ToString();
                    txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                    txtEmail.Text = row.Cells["Email"].Value?.ToString();
                    txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                    cboLoaiDaiLy.Text = row.Cells["TenLoaiDaiLy"]?.Value.ToString();
                    cboQuan.Text = row.Cells["TenQuan"]?.Value.ToString();

                    if (DateTime.TryParse(row.Cells["NgayTiepNhan"]?.Value?.ToString(), out DateTime ngayTiepNhan))
                    {
                        dtpNgayTiepNhan.Value = ngayTiepNhan;
                    }

                    //txtTongNo.Text = row.Cells["TongNo"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex,
                        "Unexpected exception in dgv change selection");

                    MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ClearInputFields();
            }
        }

        private async void mnPhieuThu_Click(object sender, EventArgs e)
        {
            try
            {
                // Resolve từ container, truyền _maDaiLy qua phương thức
                var phieuThu = _services.GetRequiredService<GUI_PhieuThu>();
                DTO_DaiLy curDaiLy = await _busDaiLy.GetDaiLyByMaAsync(_maDaiLy);
                phieuThu.SetDaiLy(curDaiLy);

                this.Enabled = false;
                phieuThu.ShowDialog();
                this.Enabled = true;
                await LoadDaiLyAsync();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex,
                    "Unexpected exception in PhieuThu (From DaiLy) button");

                MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void mnPhieuXuatHang_Click(object sender, EventArgs e)
        {
            try
            {
                // Resolve từ container, truyền _maDaiLy qua phương thức
                var phieuXuat = _services.GetRequiredService<GUI_PhieuXuat>();
                phieuXuat.SetMaDaiLy(_maDaiLy);

                this.Enabled = false;
                phieuXuat.ShowDialog();
                this.Enabled = true;
                await LoadDaiLyAsync();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex,
                    "Unexpected exception in PhieuXuat (From DaiLy) button");

                MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            var filters = new List<string>();

            string tenDaiLy = txtTenDaiLy.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(tenDaiLy))
                filters.Add($"TenDaiLy LIKE '%{tenDaiLy}%'");

            string sdt = txtSDT.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(sdt))
                filters.Add($"SDT LIKE '%{sdt}%'");

            string email = txtEmail.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(email))
                filters.Add($"Email LIKE '%{email}%'");

            string diaChi = txtDiaChi.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(diaChi))
                filters.Add($"DiaChi LIKE '%{diaChi}%'");

            string tenLoaiDaiLy = cboLoaiDaiLy.Text.Replace("'", "''");
            if (!string.IsNullOrEmpty(tenLoaiDaiLy))
                filters.Add($"TenLoaiDaiLy LIKE '%{tenLoaiDaiLy}%'");

            string tenQuan = cboQuan.Text.Replace("'", "''");
            if (!string.IsNullOrEmpty(tenQuan))
                filters.Add($"TenQuan LIKE '%{tenQuan}%'");

            //string ngayTiepNhan = dtpNgayTiepNhan.Value.ToString("yyyy-MM-dd");
            //if (!string.IsNullOrEmpty(ngayTiepNhan))
            //    filters.Add($"NgayTiepNhan. = '{ngayTiepNhan}'");


            //Combine and apply
            string? filterExpression = filters.Count > 0
                ? string.Join(" AND ", filters)
                : null;
            _bindingSource.Filter = filterExpression;
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
