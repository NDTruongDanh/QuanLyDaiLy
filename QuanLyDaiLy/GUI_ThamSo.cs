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
using BUS_Library;
using BUS_QuanLy;
using DTO_QuanLy;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GUI_QuanLy
{
    public partial class GUI_ThamSo : Form
    {
        private readonly IBUS_ThamSo _busThamSo;
        private readonly ILogger<GUI_ThamSo> _logger;

        private DTO_ThamSo _thamSo;
        public GUI_ThamSo(IBUS_ThamSo busThamSo, ILogger<GUI_ThamSo> logger)
        {
            _busThamSo = busThamSo;
            _logger = logger;
            InitializeComponent();
        }

        private async void GUI_ThamSo_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadThamSoAsync();
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

    }
}
