using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using BUS_QuanLy;
using DTO_QuanLy;
using BUS_Library;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;

namespace GUI_QuanLy
{
    public partial class GUI_PhieuNhap : Form
    {
        private readonly IBUS_PhieuNhap _busPhieuNhap;
        private readonly IBUS_ChiTietPhieuNhap _busCTPN;
        private readonly ILogger<GUI_PhieuNhap> _logger;
        private readonly IServiceProvider _services;
        private readonly BindingSource _bindingSource = new BindingSource();

        private decimal _tongTien = 0;
        private int _maPhieuNhap = 0;

        public GUI_PhieuNhap(IBUS_PhieuNhap busPhieuNhap, IBUS_ChiTietPhieuNhap busCTPN, ILogger<GUI_PhieuNhap> logger, IServiceProvider services)
        {
            _busPhieuNhap = busPhieuNhap;
            _busCTPN = busCTPN;
            _logger = logger;
            _services = services;
            InitializeComponent();
            dgvPhieuNhap.DataSource = _bindingSource;
        }

        private async void GUI_PhieuNhap_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadPhieuNhapAsync();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Unhandled exception in form PhieuNhap load");

                MessageBox.Show(
                    "Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async Task LoadPhieuNhapAsync()
        {
            try
            {
                var data = await _busPhieuNhap.GetPhieuNhapListAsync();
                if (dgvPhieuNhap.InvokeRequired)
                {
                    dgvPhieuNhap.Invoke(() => _bindingSource.DataSource = data);
                }
                else
                {
                    _bindingSource.DataSource = data;
                    dgvPhieuNhap.DataSource = _bindingSource;
                }
                dgvPhieuNhap.AutoResizeColumns();
            }
            catch (BusException busEx)
            {
                _logger.LogWarning(busEx,
                    "Business error loading grid PhieuNhap: {Message}",
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
                DateTime ngayLap = dtpNgayLapPhieu.Value;
                DTO_PhieuNhap phieuNhap = new DTO_PhieuNhap(0, ngayLap, 0);
                int maPhieuNhap = await _busPhieuNhap.GetMaPhieuNhapDefault(phieuNhap);
                phieuNhap.MaPhieuNhap = maPhieuNhap;

                using (var CTPN = _services.GetRequiredService<GUI_ChiTietPhieuNhap>())
                {
                    this.Enabled = false;
                    CTPN.SetPhieuNhap(phieuNhap);
                    CTPN.ShowDialog();
                    phieuNhap.TongTien = CTPN.GetTongTien();
                    this.Enabled = true;
                }

                if (phieuNhap.TongTien != 0)
                {
                    if (await _busPhieuNhap.UpdatePhieuNhapAsync(phieuNhap)) 
                    {
                        MessageBox.Show("Thêm Phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadPhieuNhapAsync();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (await _busPhieuNhap.DeletePhieuNhapAsync(phieuNhap.MaPhieuNhap))
                    {
                        MessageBox.Show("Thêm Phiếu nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
            if (dgvPhieuNhap.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn sửa Phiếu nhập này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        DTO_PhieuNhap phieuNhap = new DTO_PhieuNhap
                        {
                            MaPhieuNhap = _maPhieuNhap,
                            NgayLapPhieu = dtpNgayLapPhieu.Value,
                            TongTien = _tongTien
                        };

                        using (var CTPN = _services.GetRequiredService<GUI_ChiTietPhieuNhap>())
                        {
                            this.Enabled = false;
                            CTPN.SetPhieuNhap(phieuNhap);
                            CTPN.ShowDialog();
                            phieuNhap.TongTien = CTPN.GetTongTien();
                            this.Enabled = true;
                        }

                        if (await _busPhieuNhap.UpdatePhieuNhapAsync(phieuNhap))
                        {
                            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadPhieuNhapAsync();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
                MessageBox.Show("Vui lòng chọn phiếu nhập để sửa!");
            }
        }





        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá Phiếu nhập này không?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (await _busCTPN.DeleteChiTietPhieuNhapByMPNAsync(_maPhieuNhap))
                        {
                            if (await _busPhieuNhap.DeletePhieuNhapAsync(_maPhieuNhap))
                            {
                                MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                await LoadPhieuNhapAsync();
                            }
                            else
                            {
                                MessageBox.Show("Xoá thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                  
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để xóa!");
            }
        }




        private void dgvPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuNhap.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvPhieuNhap.SelectedRows[0];
                    _maPhieuNhap = Convert.ToInt32(row.Cells["MaPhieuNhap"].Value);
                    dtpNgayLapPhieu.Value = Convert.ToDateTime(row.Cells["NgayLapPhieu"].Value);
                    _tongTien = Convert.ToDecimal(row.Cells["TongTien"].Value);
                    txtTongTien.Text = _tongTien.ToString();
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex,
                        "Unexpected exception in dgv change selection");

                    MessageBox.Show("Hệ thống đang gặp sự cố. Vui lòng thử lại sau hoặc liên hệ hỗ trợ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

