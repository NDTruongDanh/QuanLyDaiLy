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
    public partial class GUI_DanhSachPhieuThu : Form
    {
        private int MaPhieuThu = 0;
        private BUS_PhieuThu busPhieuThu = new BUS_PhieuThu();
        private BUS_DaiLy busDaiLy = new BUS_DaiLy();
        private DTO_DaiLy? objDaiLy;

        public GUI_DanhSachPhieuThu()
        {
            InitializeComponent();
        }
        private void GUI_DanhSachPhieuThu_Load(object sender, EventArgs e)
        {
           LoadPhieuThu();

        }
        private void LoadPhieuThu()
        {
            DataTable dataDanhSachPhieuThu = busPhieuThu.GetAllPhieuThu();
            dgvDanhSachPhieuThu.DataSource = dataDanhSachPhieuThu;
            dgvDanhSachPhieuThu.Columns["MaPhieuThu"].HeaderText = "Mã Phiếu Thu";
            dgvDanhSachPhieuThu.Columns["MaDaiLy"].HeaderText = "Mã Đại Lý";
            dgvDanhSachPhieuThu.Columns["TenDaiLy"].HeaderText = "Tên Đại Lý";
            dgvDanhSachPhieuThu.Columns["NgayThuTien"].HeaderText = "Ngày Thu Tiền";
            dgvDanhSachPhieuThu.Columns["SoTienThu"].HeaderText = "Số Tiền Thu";
            foreach (DataGridViewColumn column in dgvDanhSachPhieuThu.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            txtDiaChi.Text = objDaiLy?.DiaChi;
            txtSDT.Text = objDaiLy?.Sdt;
            txtEmail.Text = objDaiLy?.Email;
            txtTenDaiLy.Text = objDaiLy?.TenDaiLy;

        }
        private void lblThongTinDaiLy_Click(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachPhieuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSachPhieuThu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachPhieuThu.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDanhSachPhieuThu.SelectedRows[0];
                dtpNgayThuTien.Value = Convert.ToDateTime(row.Cells["NgayThuTien"].Value);
                txtSoTienThu.Text = row.Cells["SoTienThu"].Value.ToString();

                objDaiLy = busDaiLy.GetByMaDaiLy(Convert.ToInt32(row.Cells["MaDaiLy"].Value));
                txtDiaChi.Text = objDaiLy?.DiaChi;
                txtSDT.Text = objDaiLy?.Sdt;
                txtEmail.Text = objDaiLy?.Email;
                txtTenDaiLy.Text = objDaiLy?.TenDaiLy;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachPhieuThu.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgvDanhSachPhieuThu.SelectedRows.Count; i++)
                {
                    int maPhieuThu = Convert.ToInt32(dgvDanhSachPhieuThu.SelectedRows[0].Cells["MaPhieuThu"].Value);
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
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu thu cần xóa!");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int maPhieuThu = Convert.ToInt32(dgvDanhSachPhieuThu.SelectedRows[0].Cells["MaPhieuThu"].Value);
            DTO_PhieuThu pt = new DTO_PhieuThu(maPhieuThu, (int) dgvDanhSachPhieuThu.SelectedRows[0].Cells["MaDaiLy"].Value , dtpNgayThuTien.Value, Convert.ToDecimal(txtSoTienThu.Text));


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
           
    }
}
