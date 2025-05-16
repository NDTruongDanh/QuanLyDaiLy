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

namespace GUI_QuanLy
{
    public partial class GUI_PhieuThu : Form
    {
        static int maDaiLy = 0;
        private BUS_PhieuThu busPhieuThu = new BUS_PhieuThu();
        private BUS_DaiLy busDaiLy = new BUS_DaiLy();
        DTO_DaiLy? selectedDaiLy;
        DTO_PhieuThu? selectedPhieuThu;
        public GUI_PhieuThu()
        {
            InitializeComponent();
        }

        public GUI_PhieuThu(int maDL)
        {
            maDaiLy = maDL;
            InitializeComponent();
            selectedDaiLy = busDaiLy.GetByMaDaiLy(maDaiLy);
        }

        private void GUI_PhieuThu_Load(object sender, EventArgs e)
        {
            LoadPhieuThu();
        }

        private void LoadPhieuThu()
        {
            DataTable dt = busPhieuThu.GetPhieuThuByDaiLy(maDaiLy);

            dgvPhieuThu.DataSource = dt;
            dgvPhieuThu.Columns["MaPhieuThu"].HeaderText = "Mã Phiếu Thu";
            dgvPhieuThu.Columns["NgayThuTien"].HeaderText = "Ngày Thu Tiền";
            dgvPhieuThu.Columns["SoTienThu"].HeaderText = "Số Tiền Thu";

            foreach (DataGridViewColumn column in dgvPhieuThu.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            txtDiaChi.Text = selectedDaiLy?.DiaChi;
            txtSDT.Text = selectedDaiLy?.Sdt;
            txtEmail.Text = selectedDaiLy?.Email;
            txtTenDaiLy.Text = selectedDaiLy?.TenDaiLy;
            txtSoTienThu.Text = "";
            dgvPhieuThu.ClearSelection();

        }

        private void dgvPhieuThu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieuThu.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPhieuThu.SelectedRows[0];
                if (row.Cells["NgayThuTien"].Value != DBNull.Value)
                {
                    dtpNgayThuTien.Value = Convert.ToDateTime(row.Cells["NgayThuTien"].Value);
                }
                else
                {
                    dtpNgayThuTien.Value = DateTime.Now; // Or set a default value
                }
                txtSoTienThu.Text = row.Cells["SoTienThu"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSoTienThu.Text))
            {
                DTO_PhieuThu pt = new DTO_PhieuThu(0, maDaiLy, dtpNgayThuTien.Value, Convert.ToDecimal(txtSoTienThu.Text));

                if (busPhieuThu.ThemPhieuThu(pt))
                {
                    MessageBox.Show("Thêm phiếu thu thành công!");
                    LoadPhieuThu();
                }
                else
                {
                    MessageBox.Show("Thêm phiếu thu thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPhieuThu.SelectedRows.Count > 0)
            {
                int maPhieuThu = Convert.ToInt32(dgvPhieuThu.SelectedRows[0].Cells["MaPhieuThu"].Value);
                DTO_PhieuThu pt = new DTO_PhieuThu(maPhieuThu, maDaiLy, dtpNgayThuTien.Value, Convert.ToDecimal(txtSoTienThu.Text));


                if (busPhieuThu.SuaPhieuThu(pt))
                {
                    MessageBox.Show("Sửa phiếu thu thành công!");
                    LoadPhieuThu();
                }
                else
                {
                    MessageBox.Show("Sửa phiếu thu thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu thu để sửa!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPhieuThu.SelectedRows.Count > 0)
            {
                int maPhieuThu = Convert.ToInt32(dgvPhieuThu.SelectedRows[0].Cells["MaPhieuThu"].Value);
                if (busPhieuThu.XoaPhieuThu(maPhieuThu))
                {
                    MessageBox.Show("Xóa phiếu thu thành công!");
                    LoadPhieuThu();
                }
                else
                {
                    MessageBox.Show("Xóa phiếu thu thất bại!");
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

        private void dgvPhieuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDanhSachPhieuThu_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayThuTien_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

