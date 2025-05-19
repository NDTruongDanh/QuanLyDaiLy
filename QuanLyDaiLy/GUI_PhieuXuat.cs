﻿using System;
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

        private DTO_DaiLy _daiLy = new DTO_DaiLy();

        private int _maDaiLy = 0;
        private int _maPhieuXuat = 0;

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

        public void SetDaiLy(DTO_DaiLy daiLy)
        {
            _daiLy = daiLy;
        }

        public DTO_DaiLy GetDaiLy()
        {
            return _daiLy;
        }

        private async void GUI_PhieuXuat_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadComboBoxDaiLyAsync();
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



        private async Task LoadComboBoxDaiLyAsync()
        {
            try
            {
                if (_daiLy.MaDaiLy == 0)
                {
                    var data = await _busDaiLy.GetDTODaiLyListAsync();
                    cmbDaiLy.DataSource = data;
                }
                else
                {
                    var data = await _busDaiLy.GetDaiLyByMaAsync(_daiLy.MaDaiLy);
                    cmbDaiLy.DataSource = data;
                }
                cmbDaiLy.DisplayMember = "TenDaiLy";
                cmbDaiLy.ValueMember = "MaDaiLy";
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading combo box DaiLy: {Message}",
                    busEx.Message);

                MessageBox.Show($"Lỗi nghiệp vụ: {busEx.Message}",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private async Task LoadDataGridViewAsync()
        {
            try
            {
                if (_daiLy.MaDaiLy == 0)
                {
                    var data = await _busPhieuXuat.GetDataTablePhieuXuatAsync();
                    _bindingSource.DataSource = data;
                }
                else
                {
                    var data = await _busPhieuXuat.GetDataTablePhieuXuatCuaDaiLyAsync(_daiLy.MaDaiLy);
                    _bindingSource.DataSource = data;
                    ModifyDataGridViewColumns();
                }

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

        private void ModifyDataGridViewColumns()
        {
            dgvPhieuXuat.Columns["MaPhieuXuat"].HeaderText = "Mã Phiếu Xuất";
            dgvPhieuXuat.Columns["MaDaiLy"].HeaderText = "Mã Đại Lý";
            dgvPhieuXuat.Columns["TenDaiLy"].HeaderText = "Tên Đại Lý";
            dgvPhieuXuat.Columns["NgayLapPhieu"].HeaderText = "Ngày Lập Phiếu";
            dgvPhieuXuat.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvPhieuXuat.Columns["TienTra"].HeaderText = "Tiền Trả";
            dgvPhieuXuat.Columns["ConLai"].HeaderText = "Còn Lại";
            dgvPhieuXuat.Columns["MaDaiLy"].Visible = false;

            foreach (DataGridViewColumn dataColumn in dgvPhieuXuat.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }



        private void ClearInputFields()
        {
            cmbDaiLy.SelectedIndex = -1;
            dtpNgayLapPhieu.Value = DateTime.Now;
            txtTraTruoc.Clear();

            dgvPhieuXuat.ClearSelection();
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_PhieuXuat phieuXuat = new DTO_PhieuXuat(0, _daiLy.MaDaiLy, dtpNgayLapPhieu.Value, 0, 0, 0);

                int maPhieuXuat = await _busPhieuXuat.GetMaPhieuXuatDefaultAsync(phieuXuat);

                using (var CTPX = _services.GetRequiredService<GUI_ChiTietPhieuXuat>())
                {
                    this.Enabled = false;
                    CTPX.SetPhieuXuat(phieuXuat);
                    CTPX.ShowDialog();
                    phieuXuat = CTPX.GetPhieuXuat();
                }
                if (phieuXuat.TongTien != 0)
                {
                    if (await _busPhieuXuat.UpdatePhieuXuatAsync(phieuXuat))
                    {
                        MessageBox.Show("Thêm Phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadDataGridViewAsync();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    await _busPhieuXuat.DeletePhieuXuatAsync(maPhieuXuat);
                    MessageBox.Show("Thêm Phiếu xuất thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPhieuXuat.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa Phiếu xuất này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        DTO_PhieuXuat phieuXuat = new DTO_PhieuXuat
                        {
                            MaPhieuXuat = _maPhieuXuat,
                            MaDaiLy = _maDaiLy,
                            NgayLapPhieu = dtpNgayLapPhieu.Value,
                            TongTien = Convert.ToDecimal(dgvPhieuXuat.SelectedRows[0].Cells["TongTien"].Value),
                            TienTra = Convert.ToDecimal(dgvPhieuXuat.SelectedRows[0].Cells["TienTra"].Value),
                            ConLai = Convert.ToDecimal(dgvPhieuXuat.SelectedRows[0].Cells["ConLai"].Value)
                        };

                        using (var CTPX = _services.GetRequiredService<GUI_ChiTietPhieuXuat>())
                        {
                            this.Enabled = false;
                            CTPX.SetPhieuXuat(phieuXuat);
                            CTPX.ShowDialog();
                            this.Enabled = true;
                        }

                        if (await _busPhieuXuat.UpdatePhieuXuatAsync(phieuXuat))
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadDataGridViewAsync();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất để sửa!");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvPhieuXuat.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa Phiếu nhập này không?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (await _busCTPX.DeleteChiTietPhieuXuatByMPXAsync(_maPhieuXuat))
                        {
                            if (await _busPhieuXuat.DeletePhieuXuatAsync(_maPhieuXuat))
                            {
                                MessageBox.Show("Xoá Phiếu xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                await LoadDataGridViewAsync();
                            }
                            else
                            {
                                MessageBox.Show("Xoá Phiếu xuất thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xoá Chi tiết phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgvPhieuXuat_SelectionChanged(object sender, EventArgs e)
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

