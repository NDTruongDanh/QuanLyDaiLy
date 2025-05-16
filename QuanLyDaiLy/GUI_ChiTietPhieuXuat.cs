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
using System.Data;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_ChiTietPhieuXuat : Form
    {
        // Sự kiện trả về các giá trị để cập nhật PhieuXuat khi tạo mới


        private BUS_ChiTietPhieuXuat busCTPX = new BUS_ChiTietPhieuXuat();
        private BUS_DaiLy busDaiLy = new BUS_DaiLy();
        private BUS_PhieuXuat busPhieuXuat = new BUS_PhieuXuat();
        private BUS_MatHang busMatHang = new BUS_MatHang();
        BUS_DonViTinh busDonViTinh = new BUS_DonViTinh();
        private int maPhieuXuat = 0;
        private int maDaiLy = 0;

        public DTO_PhieuXuat phieuXuat;
        DTO_DaiLy daiLy;
        public GUI_ChiTietPhieuXuat()
        {
            InitializeComponent();
            this.Close();
        }
        public GUI_ChiTietPhieuXuat(int maPhieuXuat, int maDaiLy)
        {
            InitializeComponent();
            this.maPhieuXuat = maPhieuXuat;
            this.maDaiLy = maDaiLy;
            phieuXuat = busPhieuXuat.GetPhieuXuatByMa(maPhieuXuat);
            daiLy = busDaiLy.GetByMaDaiLy(maDaiLy);
           
         
            if (phieuXuat != null && phieuXuat.NgayLapPhieu != null)
                dateTimePickerNgayLapPhieu.Value = phieuXuat.NgayLapPhieu;
            else
                dateTimePickerNgayLapPhieu.Value = DateTime.Now;
 

        }



        private void GUI_ChiTietPhieuXuat_Load(object sender, EventArgs e)
        {


            LoadChiTietPhieuXuat();
        }

        private void LoadComboBoxes()
        {
            // Load dữ liệu cho ComboBox của Mặt Hàng
            DataTable dtMatHang = busMatHang.GetMatHang();
            cboMaMatHang.DataSource = dtMatHang;
            cboMaMatHang.DisplayMember = "TenMatHang"; // Hiển thị tên mặt hàng
            cboMaMatHang.ValueMember = "MaMatHang";




        }

        private void LoadChiTietPhieuXuat()
        {
            phieuXuat = busPhieuXuat.GetPhieuXuatByMa(maPhieuXuat);
            daiLy = busDaiLy.GetByMaDaiLy(maDaiLy);

            LoadComboBoxes();
            DataTable dt = busCTPX.GetChiTietPhieuXuat(maPhieuXuat);
            dgvChiTietPhieuXuat.DataSource = dt;
            dgvChiTietPhieuXuat.Columns["MaPhieuXuat"].Visible = false;
            dgvChiTietPhieuXuat.Columns["MaMatHang"].Visible = false;
            dgvChiTietPhieuXuat.Columns["MaDonViTinh"].Visible = false;
            dgvChiTietPhieuXuat.Columns["MaMatHang"].HeaderText = "Mã Mặt Hàng";
            dgvChiTietPhieuXuat.Columns["TenMatHang"].HeaderText = "Tên Mặt Hàng";
            dgvChiTietPhieuXuat.Columns["TenDonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvChiTietPhieuXuat.Columns["SoLuongXuat"].HeaderText = "Số Lượng Xuất";
            dgvChiTietPhieuXuat.Columns["DonGiaXuat"].HeaderText = "Đơn Giá Xuất";
            dgvChiTietPhieuXuat.Columns["ThanhTien"].HeaderText = "Thành Tiền";

            foreach (DataGridViewColumn column in dgvChiTietPhieuXuat.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            textBoxDaiLy.Text = daiLy.TenDaiLy;

            textBoxMaPhieuXuat.Text = phieuXuat.MaPhieuXuat.ToString();
            txtTongTien.Text = phieuXuat.TongTien.ToString();
            txtTraTruoc.Text = phieuXuat.TienTra.ToString();
            txtConLai.Text = phieuXuat.ConLai.ToString();
           

        }



        private void dgvChiTietPhieuXuat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuXuat.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvChiTietPhieuXuat.SelectedRows[0];
                cboMaMatHang.SelectedValue = row.Cells["MaMatHang"].Value;
                txtSoLuongXuat.Text = row.Cells["SoLuongXuat"].Value.ToString();
                txtDonGiaXuat.Text = row.Cells["DonGiaXuat"].Value.ToString();
                txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboMaMatHang.SelectedValue != null &&
                !string.IsNullOrEmpty(txtSoLuongXuat.Text))
            {

                // Tạo đối tượng DTO_ChiTietPhieuXuat
                int maMatHang = Convert.ToInt32(cboMaMatHang.SelectedValue);
                int soLuongXuat = Convert.ToInt32(txtSoLuongXuat.Text);
                decimal donGiaXuat = Convert.ToDecimal(txtDonGiaXuat.Text);
                decimal thanhTien = soLuongXuat * donGiaXuat;
                DTO_ChiTietPhieuXuat ctp = new DTO_ChiTietPhieuXuat(phieuXuat.MaPhieuXuat, maMatHang, soLuongXuat, donGiaXuat, thanhTien);

                if (busCTPX.ThemChiTietPhieuXuat(ctp))
                {

                    MessageBox.Show("Thêm thành công!");
                    LoadChiTietPhieuXuat();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuXuat.SelectedRows.Count > 0)
            {
                int maMatHang = Convert.ToInt32(cboMaMatHang.SelectedValue);

                decimal thanhTienCu = Convert.ToDecimal(dgvChiTietPhieuXuat.SelectedRows[0].Cells["ThanhTien"].Value);
                int soLuong = Convert.ToInt32(txtSoLuongXuat.Text);
                decimal donGia = Convert.ToDecimal(txtDonGiaXuat.Text);
                decimal thanhTienMoi = soLuong * donGia;
                DTO_ChiTietPhieuXuat ctp = new DTO_ChiTietPhieuXuat(phieuXuat.MaPhieuXuat, maMatHang, soLuong, donGia, thanhTienMoi);

                if (busCTPX.SuaChiTietPhieuXuat(ctp))
                {

                    LoadChiTietPhieuXuat();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvChiTietPhieuXuat.SelectedRows.Count > 0)
            {
                int maMH = Convert.ToInt32(dgvChiTietPhieuXuat.SelectedRows[0].Cells["MaMatHang"].Value);
                decimal thanhTienCu = Convert.ToDecimal(dgvChiTietPhieuXuat.SelectedRows[0].Cells["ThanhTien"].Value);

                if (busCTPX.XoaChiTietPhieuXuat(phieuXuat.MaPhieuXuat, maMH))
                {

                    MessageBox.Show("Xóa thành công!");
                    LoadChiTietPhieuXuat();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }

        private void txtTraTruoc_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTraTruoc.Text, out decimal traTruoc))
            {
                txtConLai.Text = (phieuXuat.TongTien - traTruoc).ToString();
            }
            else
            {
                txtConLai.Text = phieuXuat.TongTien.ToString(); // Default value or handle invalid input
            }
        }

        private void GUI_ChiTietPhieuXuat_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            this.phieuXuat.TienTra = Convert.ToDecimal(txtTraTruoc.Text);
            this.phieuXuat.ConLai = Convert.ToDecimal(txtConLai.Text);
            this.phieuXuat.TongTien = Convert.ToDecimal(txtTongTien.Text);
         
            this.phieuXuat.NgayLapPhieu = dateTimePickerNgayLapPhieu.Value;
            if (busPhieuXuat.SuaPhieuXuat(phieuXuat))
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
            

        }

        private void cboMaMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaMatHang.SelectedValue is int selectedValue)
            {
                DTO_MatHang selectedMatHang = busMatHang.GetMatHangByMa(selectedValue);
                if (selectedMatHang != null)
                {

                    txtDonGiaXuat.Text = selectedMatHang.DonGiaHienTai.ToString();
                    txtDonViTinh.Text = busDonViTinh.GetDonViTinhByMa(selectedMatHang.MaDonViTinh).TenDonViTinh;
                    txtSoLuongXuat.Text = "1"; // Mặc định số lượng là 1
                    txtThanhTien.Text = selectedMatHang.DonGiaHienTai.ToString();
                }

            }
        }

        private void txtSoLuongXuat_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSoLuongXuat.Text, out decimal soLuongXuat) &&
                 decimal.TryParse(txtDonGiaXuat.Text, out decimal donGiaXuat))
            {
                txtThanhTien.Text = (soLuongXuat * donGiaXuat).ToString();
            }
            else
            {
                txtThanhTien.Text = "0"; // Or handle invalid input appropriately
            }
        }

        private void dateTimePickerNgayLapPhieu_ValueChanged(object sender, EventArgs e)
        {

            
        }
    }
}

