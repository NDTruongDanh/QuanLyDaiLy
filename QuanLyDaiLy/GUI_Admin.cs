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

using System;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class GUI_Admin : Form
    {
        public GUI_Admin()
        {
            InitializeComponent();
        }

        private void GUI_Admin_Load(object sender, EventArgs e)
        {
            // Khi Admin Form được load, không cần mở GUI nào tự động.
            // Các GUI sẽ được mở khi người dùng click vào các menu item.
        }

        // Hàm thêm TabPage chứa form cần thiết nếu chưa tồn tại, ngược lại focus Tab đó.

        // Các sự kiện xử lý Menu Item Click
        private void mnuLoaiDaiLy_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_LoaiDaiLy(), "Loại Đại Lý", tabControl);
        }

        private void mnuQuan_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_Quan(), "Quận", tabControl);
        }

        private void mnuDaiLy_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_DaiLy(), "Đại Lý", tabControl);
        }

        private void mnuDonViTinh_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_DonViTinh(), "Đơn Vị Tính", tabControl);
        }   

        private void mnuMatHang_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_MatHang(), "Mặt Hàng", tabControl);
        }

        private void mnuPhieuNhap_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_PhieuNhap(), "Phiếu Nhập", tabControl);
        }

        private void mnuChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_ChiTietPhieuNhap(1), "Chi Tiết Phiếu Nhập", tabControl);
        }

        private void mnuPhieuXuat_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_PhieuXuat(), "Phiếu Xuất", tabControl);
        }

        private void mnuChiTietPhieuXuat_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_ChiTietPhieuXuat(), "Chi Tiết Phiếu Xuất", tabControl);
        }

        private void mnuPhieuThu_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_PhieuThu(), "Phiếu Thu", tabControl);
        }

        private void mnuThamSo_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_ThamSo(), "Tham Số", tabControl);
        }

        private void mnuBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_BaoCaoDoanhSo(), "Báo Cáo Doanh Số", tabControl);
        }

        private void mnuChiTietBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_ChiTietBaoCaoDoanhSo(), "Chi Tiết Báo Cáo Doanh Số", tabControl);
        }

        private void mnuBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            CommonControls.AddTab(new GUI_BaoCaoCongNo(), "Báo Cáo Công Nợ", tabControl);
        }
    }
}

