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
using Microsoft.Extensions.DependencyInjection;
using System.Transactions;
using System.Security.Cryptography;

namespace GUI_QuanLy
{
    public partial class GUI_PhieuXuat : Form
    {
        private readonly IBUS_DaiLy _busDaiLy;

        private readonly IBUS_PhieuXuat _busPhieuXuat;

        private readonly IBUS_ChiTietPhieuXuat _busCTPX;

        private readonly ILogger<GUI_PhieuXuat> _logger;

        private readonly IServiceProvider _services;


        //  [] = new BindingSource();
        private readonly BindingSource _bindingSource = [];


        private int _maDaiLy = 0;
        private int _maPhieuXuat = 0;

        private decimal _tongTien = 0;
        private decimal _traTruoc = 0;
        private decimal _conLai = 0;

        public GUI_PhieuXuat(IBUS_DaiLy busDaiLy, IBUS_PhieuXuat busPhieuXuat, IBUS_ChiTietPhieuXuat busCTPX, ILogger<GUI_PhieuXuat> logger, IServiceProvider service)
        {
            _busDaiLy = busDaiLy;
            _busPhieuXuat = busPhieuXuat;
            _busCTPX = busCTPX;
            _logger = logger;
            _services = service;
            InitializeComponent();
            dgvPhieuXuat.DataSource = _bindingSource;
        }


        private async void GUI_PhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadDataGridViewAsync();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form PhieuXuat load");

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
                var data = await _busPhieuXuat.GetPhieuXuatListAsync();
                _bindingSource.DataSource = data;
                dgvPhieuXuat.AutoResizeColumns();
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid PhieuXuat: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        public void SetMaDaiLy(int maDaiLy)
        {
            _maDaiLy = maDaiLy;
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (await _busPhieuXuat.AddPhieuXuatDefaultAsync(_maDaiLy, DateTime.Now))
                {
                    MessageBox.Show("Thêm Đại lý thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataGridViewAsync();
                }
                else
                {
                    MessageBox.Show("Thêm Đại lý thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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

        //private async void btnEdit_Click(object sender, EventArgs e)
        //{
        //    if (dgvPhieuXuat.SelectedRows.Count > 0)
        //    {
        //        DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa Phiếu xuất này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //        if (confirm == DialogResult.Yes)
        //        {


        //            try
        //            {
        //                using (var CTPX = _services.GetRequiredService<GUI_ChiTietPhieuXuat>())
        //                {
        //                    CTPX.SetMaPhieuXuat(_maPhieuXuat);
        //                    CTPX.SetConLai(_conLai);
        //                    CTPX.SetTongTien(_tongTien);
        //                    CTPX.SetTraTruoc(_traTruoc);
        //                    this.Enabled = false;
        //                    CTPX.ShowDialog();
        //                    _tongTien = CTPX.GetTongTien();
        //                    _traTruoc = CTPX.GetTraTruoc();
        //                    _conLai = CTPX.GetConLai();
        //                    this.Enabled = true;
        //                }

        //                DTO_PhieuXuat phieuXuat = new DTO_PhieuXuat
        //                {
        //                    MaPhieuXuat = _maPhieuXuat,
        //                    MaDaiLy = _maDaiLy,
        //                    //NgayLapPhieu = dtpNgayLapPhieu.Value,
        //                    TongTien = _tongTien,
        //                    TienTra = _traTruoc,
        //                    ConLai = _conLai
        //                };
        //                if (await _busPhieuXuat.UpdatePhieuXuatAsync(phieuXuat))
        //                {
        //                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    await LoadDataGridViewAsync();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                }
        //            }
        //            catch (BusException busEx)
        //            {
        //                _logger.LogError(busEx,
        //                    "BusException in Edit button");

        //                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            catch (Exception ex)
        //            {
        //                _logger.LogCritical(ex,
        //                    "Unexpected exception in Edit button");

        //                MessageBox.Show("Lỗi hệ thông! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Vui lòng chọn phiếu xuất để sửa!");
        //    }
        //}

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvPhieuXuat.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa loại đại lý này không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (await _busPhieuXuat.DeletePhieuXuatAsync(_maPhieuXuat))
                        {
                            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadDataGridViewAsync();
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
                    MessageBox.Show("Vui lòng chọn phiếu xuất cần xóa!");
                }
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (dgvPhieuXuat.SelectedRows.Count > 0)
            {
                cmbDaiLy.SelectedValue = dgvPhieuXuat.SelectedRows[0].Cells["MaDaiLy"].Value;
                dtpNgayLapPhieu.Value = Convert.ToDateTime(dgvPhieuXuat.SelectedRows[0].Cells["NgayLapPhieu"].Value);
                txtTraTruoc.Text = dgvPhieuXuat.SelectedRows[0].Cells["TienTra"].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            var filters = new List<object>();

            string tenDaiLy = cmbDaiLy.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(tenDaiLy))
                filters.Add($"TenDaiLy LIKE '%{tenDaiLy}%'");

            if (decimal.TryParse(txtTraTruoc.Text, out decimal traTruoc))
                filters.Add($"TienTra = {traTruoc}");

        }
    }
}

