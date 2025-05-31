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
                ValidateInputFields();

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

        private void ValidateInputFields()
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

        private void btnThemLoaiDaiLy_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvQuan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnThamSo_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputFields();

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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddQuan_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTenDaiLy_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dgvDVT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvQuan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
