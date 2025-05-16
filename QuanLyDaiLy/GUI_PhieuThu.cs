using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS_QuanLy;
using DTO_QuanLy;
using GUI_QuanLy.CommonClass;

namespace GUI_QuanLy
{
    public partial class GUI_PhieuThu : Form
    {
        private readonly IBUS_PhieuThu _busPhieuThu;

        private readonly IServiceProvider _service;

        private readonly BindingSource _bindingSource = new BindingSource();

        private int _maDaiLy = 0;
        public GUI_PhieuThu(IBUS_PhieuThu busPhieuThu, IServiceProvider service)
        {
            _busPhieuThu = busPhieuThu;
            _service = service;
            InitializeComponent();
            dgvPhieuThu.DataSource = _bindingSource;
        }

        public void SetMaDaiLy(int maDaiLy)
        {
            _maDaiLy = maDaiLy;
        }

        private async void GUI_PhieuThu_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadPhieuThuAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadPhieuThuAsync()
        {
            try
            {
                var data = await _busPhieuThu.GetPhieuThuCuaDaiLyListAsync(_maDaiLy);
                if (dgvPhieuThu.InvokeRequired)
                {
                    dgvPhieuThu.Invoke(() => _bindingSource.DataSource = data);
                }
                else
                {
                    _bindingSource.DataSource = data;
                }

                dgvPhieuThu.AutoResizeColumns();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tienThu;
                if (decimal.TryParse(txtSoTienThu.Text, out tienThu))
                {
                    DTO_PhieuThu pt = new DTO_PhieuThu(0, _maDaiLy, dtpNgayThuTien.Value, tienThu);

                    if (await _busPhieuThu.AddPhieuThuAsync(pt))
                    {
                        MessageBox.Show("Thêm phiếu thu thành công!");
                        await LoadPhieuThuAsync();
                    }
                    else
                    {
                        MessageBox.Show("Thêm phiếu thu thất bại!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số tiền thu hợp lệ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        decimal soTienThu;

                        if (decimal.TryParse(txtSoTienThu.Text, out soTienThu))
                        {
                            var row = dgvPhieuThu.SelectedRows[0];

                            DateTime dtpNgayThuTien = Convert.ToDateTime(row.Cells["NgayThuTien"].Value);
                            int maPhieuThu = Convert.ToInt32(row.Cells["MaPhieuThu"].Value);

                            DTO_PhieuThu pt = new DTO_PhieuThu(maPhieuThu, _maDaiLy, dtpNgayThuTien, soTienThu);


                            if (await _busPhieuThu.UpdatePhieuThuAsync(pt))
                            {
                                MessageBox.Show("Sửa phiếu thu thành công!");
                                await LoadPhieuThuAsync();
                            }
                            else
                            {
                                MessageBox.Show("Sửa phiếu thu thất bại!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập số tiền thu hợp lệ!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu thu để sửa!");
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
                        int maPhieuThu = Convert.ToInt32(dgvPhieuThu.SelectedRows[0].Cells["MaPhieuThu"].Value);
                        if (await _busPhieuThu.DeletePhieuThuAsync(maPhieuThu))
                        {
                            MessageBox.Show("Xóa phiếu thu thành công!");
                            await LoadPhieuThuAsync();
                        }
                        else
                        {
                            MessageBox.Show("Xóa phiếu thu thất bại!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            else
            {
                MessageBox.Show("Vui lòng chọn phiếu thu cần xóa!");
            }
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
                    dtpNgayThuTien.Value = Convert.ToDateTime(row.Cells["NgayThuTien"].Value);
                    txtSoTienThu.Text = row.Cells["SoTienThu"].Value.ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

