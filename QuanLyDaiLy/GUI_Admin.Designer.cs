namespace GUI_QuanLy
{
    partial class GUI_Admin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDaiLy;
        private ToolStripMenuItem báoCáoToolStripMenuItem;
        private ToolStripMenuItem mnuBaoCaoDoanhSo;
        private ToolStripMenuItem mnuBaoCaoCongNo;
        private ToolStripMenuItem mnuNhapHang;
        private System.Windows.Forms.ToolStripMenuItem mnuMatHang;
        private System.Windows.Forms.ToolStripMenuItem mnuThamSo;
        private System.Windows.Forms.TabControl tabControl;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            quảnLýToolStripMenuItem = new ToolStripMenuItem();
            mnuDaiLy = new ToolStripMenuItem();
            mnuLoaiDaiLy = new ToolStripMenuItem();
            mnuQuan = new ToolStripMenuItem();
            mnuMatHang = new ToolStripMenuItem();
            mnDonViTinh = new ToolStripMenuItem();
            mnuThamSo = new ToolStripMenuItem();
            báoCáoToolStripMenuItem = new ToolStripMenuItem();
            mnuBaoCaoDoanhSo = new ToolStripMenuItem();
            mnuBaoCaoCongNo = new ToolStripMenuItem();
            mnuNhapHang = new ToolStripMenuItem();
            tabControl = new TabControl();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { quảnLýToolStripMenuItem, báoCáoToolStripMenuItem, mnuNhapHang });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuDaiLy, mnuMatHang, mnuThamSo });
            quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            quảnLýToolStripMenuItem.Size = new Size(75, 24);
            quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // mnuDaiLy
            // 
            mnuDaiLy.DropDownItems.AddRange(new ToolStripItem[] { mnuLoaiDaiLy, mnuQuan });
            mnuDaiLy.Name = "mnuDaiLy";
            mnuDaiLy.Size = new Size(224, 26);
            mnuDaiLy.Text = "Đại Lý";
            mnuDaiLy.Click += mnuDaiLy_Click;
            // 
            // mnuLoaiDaiLy
            // 
            mnuLoaiDaiLy.Name = "mnuLoaiDaiLy";
            mnuLoaiDaiLy.Size = new Size(224, 26);
            mnuLoaiDaiLy.Text = "Loại Đại Lý";
            mnuLoaiDaiLy.Click += mnuLoaiDaiLy_Click;
            // 
            // mnuQuan
            // 
            mnuQuan.Name = "mnuQuan";
            mnuQuan.Size = new Size(224, 26);
            mnuQuan.Text = "Quận";
            mnuQuan.Click += mnuQuan_Click;
            // 
            // mnuMatHang
            // 
            mnuMatHang.DropDownItems.AddRange(new ToolStripItem[] { mnDonViTinh });
            mnuMatHang.Name = "mnuMatHang";
            mnuMatHang.Size = new Size(224, 26);
            mnuMatHang.Text = "Mặt Hàng";
            mnuMatHang.Click += mnuMatHang_Click;
            // 
            // mnDonViTinh
            // 
            mnDonViTinh.Name = "mnDonViTinh";
            mnDonViTinh.Size = new Size(169, 26);
            mnDonViTinh.Text = "Đơn Vị Tính";
            mnDonViTinh.Click += mnuDonViTinh_Click;
            // 
            // mnuThamSo
            // 
            mnuThamSo.Name = "mnuThamSo";
            mnuThamSo.Size = new Size(224, 26);
            mnuThamSo.Text = "Tham Số";
            mnuThamSo.Click += mnuThamSo_Click;
            // 
            // báoCáoToolStripMenuItem
            // 
            báoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuBaoCaoDoanhSo, mnuBaoCaoCongNo });
            báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            báoCáoToolStripMenuItem.Size = new Size(77, 24);
            báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // mnuBaoCaoDoanhSo
            // 
            mnuBaoCaoDoanhSo.Name = "mnuBaoCaoDoanhSo";
            mnuBaoCaoDoanhSo.Size = new Size(213, 26);
            mnuBaoCaoDoanhSo.Text = "Báo cáo Doanh số";
            mnuBaoCaoDoanhSo.Click += mnuBaoCaoDoanhSo_Click;
            // 
            // mnuBaoCaoCongNo
            // 
            mnuBaoCaoCongNo.Name = "mnuBaoCaoCongNo";
            mnuBaoCaoCongNo.Size = new Size(213, 26);
            mnuBaoCaoCongNo.Text = "Báo cáo Công nợ";
            mnuBaoCaoCongNo.Click += mnuBaoCaoCongNo_Click;
            // 
            // mnuNhapHang
            // 
            mnuNhapHang.Name = "mnuNhapHang";
            mnuNhapHang.Size = new Size(96, 24);
            mnuNhapHang.Text = "Nhập hàng";
            mnuNhapHang.Click += mnuPhieuNhap_Click;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 28);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(900, 572);
            tabControl.TabIndex = 1;
            // 
            // GUI_Admin
            // 
            ClientSize = new Size(900, 600);
            Controls.Add(tabControl);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "GUI_Admin";
            Text = "Admin - Quản Lý Toàn Bộ Dữ Liệu";
            Load += GUI_Admin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private ToolStripMenuItem mnuLoaiDaiLy;
        private ToolStripMenuItem mnuQuan;
        private ToolStripMenuItem mnDonViTinh;
        //private ToolStripMenuItem mnuDonViTinh;
    }
}
