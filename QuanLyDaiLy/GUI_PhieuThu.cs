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
using Microsoft.Extensions.Logging;

namespace GUI_QuanLy
{
    public partial class GUI_PhieuThu : Form
    {
        
        private readonly IBUS_PhieuThu _busPhieuThu;

        private readonly IServiceProvider _service;

        private readonly ILogger<GUI_PhieuThu> _logger;

        private readonly BindingSource _bindingSource = new BindingSource();

        private DTO_DaiLy _DaiLy = new DTO_DaiLy();
        private int _maPhieuThu = 0;

        public GUI_PhieuThu(IBUS_PhieuThu busPhieuThu, IServiceProvider service, ILogger<GUI_PhieuThu> logger)
        {
            _busPhieuThu = busPhieuThu;
            _service = service;
            _logger = logger;
            InitializeComponent();
            dgvPhieuThu.DataSource = _bindingSource;
        }

        public void SetDaiLy(DTO_DaiLy daiLy)
        {
            _DaiLy = daiLy;
        }

        private async void GUI_PhieuThu_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadPhieuThuListByDaiLyAsync();
                LoadControlsContent();
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

        private void LoadControlsContent()
        {
            txtTenDaiLy.Text = _DaiLy.TenDaiLy;
            txtTienThu.Text = _DaiLy.Sdt;
          
        }


        private async Task LoadPhieuThuListByDaiLyAsync()
        {
            /*
            try
            {
                var data = await _busPhieuThu.GetPhieuThuCuaDaiLyListAsync(_DaiLy.MaDaiLy);
                _bindingSource.DataSource = data;
                ModifyDataGridViewColumns();
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
            */
        }


        private void ModifyDataGridViewColumns()
        {
            dgvPhieuThu.Columns["MaPhieuThu"].HeaderText = "Mã phiếu thu";
            dgvPhieuThu.Columns["NgayThuTien"].HeaderText = "Ngày thu tiền";
            dgvPhieuThu.Columns["SoTienThu"].HeaderText = "Số tiền thu";
            dgvPhieuThu.Columns["MaDaiLy"].Visible = false;

            foreach (DataGridViewColumn dataColumn in dgvPhieuThu.Columns)
            {
                dataColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputFields();

                decimal soTienThu = Convert.ToDecimal(txtTienThu.Text);
                DTO_PhieuThu phieuThu = new DTO_PhieuThu(0, _DaiLy.MaDaiLy, DateTime.Now, soTienThu);

                if (await _busPhieuThu.AddPhieuThuAsync(phieuThu))
                {
                    MessageBox.Show("Thêm Phiếu thu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadPhieuThuListByDaiLyAsync();
                    ClearInputFields();

                    _DaiLy.TongNo -= soTienThu;
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

                        decimal soTienThu = Convert.ToDecimal(txtTienThu.Text);
                        DateTime ngayThu = dtpNgayThuTien.Value;
                        DTO_PhieuThu phieuThu = new DTO_PhieuThu(_maPhieuThu, _DaiLy.MaLoaiDaiLy, ngayThu, soTienThu);

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
            if (string.IsNullOrWhiteSpace(txtTienThu.Text) || txtTienThu.Text == "." )
            {
                var valEx = new ValidationException("Vui lòng nhập Số tiền thu!");
                _logger.LogWarning(valEx, 
                                    "Validation failed: {Input}",
                                    txtTienThu.Text);
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
            txtTienThu.Clear();
            dtpNgayThuTien.Value = DateTime.Now;
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
                    dtpNgayThuTien.Value = Convert.ToDateTime(row.Cells["NgayThuTien"].Value);
                    txtTienThu.Text = row.Cells["SoTienThu"].Value.ToString();
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
            if (e.KeyChar == '.' && txtTienThu.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        
    }
}

