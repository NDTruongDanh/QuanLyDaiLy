namespace GUI_QuanLy
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            Seperator = new Label();
            label1 = new Label();
            flpSidebar = new FlowLayoutPanel();
            panelDaiLy = new Panel();
            btnDaily = new Button();
            panelPhieuNhap = new Panel();
            btnPhieuNhapHang = new Button();
            panelPhieuXuat = new Panel();
            btnPhieuXuatHang = new Button();
            panelPhieuThu = new Panel();
            btnPhieuThuTien = new Button();
            panelMatHang = new Panel();
            btnProduct = new Button();
            reportContainer = new FlowLayoutPanel();
            panel7 = new Panel();
            btnReport = new Button();
            panelBaoCaoDoanhSo = new Panel();
            btnBaoCaoDoanhSo = new Button();
            panelBaoCaoCongNo = new Panel();
            btnBaoCaoCongNo = new Button();
            menuTransition1 = new System.Windows.Forms.Timer(components);
            panel8 = new Panel();
            pbPhanQuyen = new PictureBox();
            tbTimKiem = new TextBox();
            pbSettingThamSo = new PictureBox();
            lblFormName = new Label();
            panelMain = new Panel();
            flpSidebar.SuspendLayout();
            panelDaiLy.SuspendLayout();
            panelPhieuNhap.SuspendLayout();
            panelPhieuXuat.SuspendLayout();
            panelPhieuThu.SuspendLayout();
            panelMatHang.SuspendLayout();
            reportContainer.SuspendLayout();
            panel7.SuspendLayout();
            panelBaoCaoDoanhSo.SuspendLayout();
            panelBaoCaoCongNo.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPhanQuyen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSettingThamSo).BeginInit();
            SuspendLayout();
            // 
            // Seperator
            // 
            Seperator.BorderStyle = BorderStyle.Fixed3D;
            Seperator.Location = new Point(3, 90);
            Seperator.Name = "Seperator";
            Seperator.Size = new Size(250, 2);
            Seperator.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(235, 90);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ ĐẠI LÝ ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpSidebar
            // 
            flpSidebar.BackColor = Color.FromArgb(44, 62, 80);
            flpSidebar.Controls.Add(label1);
            flpSidebar.Controls.Add(Seperator);
            flpSidebar.Controls.Add(panelDaiLy);
            flpSidebar.Controls.Add(panelPhieuNhap);
            flpSidebar.Controls.Add(panelPhieuXuat);
            flpSidebar.Controls.Add(panelPhieuThu);
            flpSidebar.Controls.Add(panelMatHang);
            flpSidebar.Controls.Add(reportContainer);
            flpSidebar.Dock = DockStyle.Left;
            flpSidebar.Location = new Point(0, 0);
            flpSidebar.Margin = new Padding(0);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Size = new Size(250, 819);
            flpSidebar.TabIndex = 3;
            // 
            // panelDaiLy
            // 
            panelDaiLy.Controls.Add(btnDaily);
            panelDaiLy.Location = new Point(3, 95);
            panelDaiLy.Name = "panelDaiLy";
            panelDaiLy.Padding = new Padding(0, 20, 0, 0);
            panelDaiLy.Size = new Size(250, 68);
            panelDaiLy.TabIndex = 4;
            // 
            // btnDaily
            // 
            btnDaily.BackColor = Color.FromArgb(44, 62, 80);
            btnDaily.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDaily.ForeColor = Color.White;
            btnDaily.Image = (Image)resources.GetObject("btnDaily.Image");
            btnDaily.ImageAlign = ContentAlignment.MiddleLeft;
            btnDaily.Location = new Point(-12, -43);
            btnDaily.Name = "btnDaily";
            btnDaily.Padding = new Padding(30, 0, 0, 0);
            btnDaily.Size = new Size(298, 156);
            btnDaily.TabIndex = 1;
            btnDaily.Text = "       Đại lý ";
            btnDaily.TextAlign = ContentAlignment.MiddleLeft;
            btnDaily.UseVisualStyleBackColor = false;
            btnDaily.Click += btnDaily_Click;
            // 
            // panelPhieuNhap
            // 
            panelPhieuNhap.Controls.Add(btnPhieuNhapHang);
            panelPhieuNhap.Location = new Point(3, 169);
            panelPhieuNhap.Name = "panelPhieuNhap";
            panelPhieuNhap.Padding = new Padding(0, 20, 0, 0);
            panelPhieuNhap.Size = new Size(250, 68);
            panelPhieuNhap.TabIndex = 2;
            // 
            // btnPhieuNhapHang
            // 
            btnPhieuNhapHang.BackColor = Color.FromArgb(44, 62, 80);
            btnPhieuNhapHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhieuNhapHang.ForeColor = Color.White;
            btnPhieuNhapHang.Image = (Image)resources.GetObject("btnPhieuNhapHang.Image");
            btnPhieuNhapHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhapHang.Location = new Point(-12, -43);
            btnPhieuNhapHang.Name = "btnPhieuNhapHang";
            btnPhieuNhapHang.Padding = new Padding(30, 0, 0, 0);
            btnPhieuNhapHang.Size = new Size(312, 156);
            btnPhieuNhapHang.TabIndex = 1;
            btnPhieuNhapHang.Text = "       Phiếu nhập hàng ";
            btnPhieuNhapHang.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhapHang.UseVisualStyleBackColor = false;
            btnPhieuNhapHang.Click += btnPhieuNhapHang_Click;
            // 
            // panelPhieuXuat
            // 
            panelPhieuXuat.Controls.Add(btnPhieuXuatHang);
            panelPhieuXuat.Location = new Point(3, 243);
            panelPhieuXuat.Name = "panelPhieuXuat";
            panelPhieuXuat.Padding = new Padding(0, 30, 0, 0);
            panelPhieuXuat.Size = new Size(250, 68);
            panelPhieuXuat.TabIndex = 3;
            // 
            // btnPhieuXuatHang
            // 
            btnPhieuXuatHang.BackColor = Color.FromArgb(44, 62, 80);
            btnPhieuXuatHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhieuXuatHang.ForeColor = Color.White;
            btnPhieuXuatHang.Image = (Image)resources.GetObject("btnPhieuXuatHang.Image");
            btnPhieuXuatHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuXuatHang.Location = new Point(-12, -43);
            btnPhieuXuatHang.Name = "btnPhieuXuatHang";
            btnPhieuXuatHang.Padding = new Padding(30, 0, 0, 0);
            btnPhieuXuatHang.Size = new Size(293, 156);
            btnPhieuXuatHang.TabIndex = 1;
            btnPhieuXuatHang.Text = "       Phiếu xuất hàng ";
            btnPhieuXuatHang.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuXuatHang.UseVisualStyleBackColor = false;
            btnPhieuXuatHang.Click += btnPhieuXuatHang_Click;
            // 
            // panelPhieuThu
            // 
            panelPhieuThu.Controls.Add(btnPhieuThuTien);
            panelPhieuThu.Location = new Point(3, 317);
            panelPhieuThu.Name = "panelPhieuThu";
            panelPhieuThu.Padding = new Padding(0, 30, 0, 0);
            panelPhieuThu.Size = new Size(250, 68);
            panelPhieuThu.TabIndex = 3;
            // 
            // btnPhieuThuTien
            // 
            btnPhieuThuTien.BackColor = Color.FromArgb(44, 62, 80);
            btnPhieuThuTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhieuThuTien.ForeColor = Color.White;
            btnPhieuThuTien.Image = (Image)resources.GetObject("btnPhieuThuTien.Image");
            btnPhieuThuTien.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuThuTien.Location = new Point(-12, -43);
            btnPhieuThuTien.Name = "btnPhieuThuTien";
            btnPhieuThuTien.Padding = new Padding(30, 0, 0, 0);
            btnPhieuThuTien.Size = new Size(293, 156);
            btnPhieuThuTien.TabIndex = 1;
            btnPhieuThuTien.Text = "       Phiếu thu tiền ";
            btnPhieuThuTien.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuThuTien.UseVisualStyleBackColor = false;
            btnPhieuThuTien.Click += btnPhieuThuTien_Click;
            // 
            // panelMatHang
            // 
            panelMatHang.Controls.Add(btnProduct);
            panelMatHang.Location = new Point(3, 391);
            panelMatHang.Name = "panelMatHang";
            panelMatHang.Padding = new Padding(0, 20, 0, 0);
            panelMatHang.Size = new Size(250, 68);
            panelMatHang.TabIndex = 5;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(44, 62, 80);
            btnProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.White;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(-13, -44);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(30, 0, 0, 0);
            btnProduct.Size = new Size(298, 156);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "       Mặt hàng";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // reportContainer
            // 
            reportContainer.BackColor = Color.FromArgb(60, 84, 108);
            reportContainer.Controls.Add(panel7);
            reportContainer.Controls.Add(panelBaoCaoDoanhSo);
            reportContainer.Controls.Add(panelBaoCaoCongNo);
            reportContainer.Location = new Point(3, 465);
            reportContainer.Name = "reportContainer";
            reportContainer.Size = new Size(250, 68);
            reportContainer.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnReport);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(0, 30, 0, 0);
            panel7.Size = new Size(250, 68);
            panel7.TabIndex = 5;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(44, 62, 80);
            btnReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-12, -43);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(30, 0, 0, 0);
            btnReport.Size = new Size(280, 156);
            btnReport.TabIndex = 1;
            btnReport.Text = "       Báo cáo";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // panelBaoCaoDoanhSo
            // 
            panelBaoCaoDoanhSo.Controls.Add(btnBaoCaoDoanhSo);
            panelBaoCaoDoanhSo.Location = new Point(0, 68);
            panelBaoCaoDoanhSo.Margin = new Padding(0);
            panelBaoCaoDoanhSo.Name = "panelBaoCaoDoanhSo";
            panelBaoCaoDoanhSo.Padding = new Padding(0, 30, 0, 0);
            panelBaoCaoDoanhSo.Size = new Size(250, 68);
            panelBaoCaoDoanhSo.TabIndex = 4;
            // 
            // btnBaoCaoDoanhSo
            // 
            btnBaoCaoDoanhSo.BackColor = Color.FromArgb(60, 84, 108);
            btnBaoCaoDoanhSo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBaoCaoDoanhSo.ForeColor = Color.White;
            btnBaoCaoDoanhSo.Image = (Image)resources.GetObject("btnBaoCaoDoanhSo.Image");
            btnBaoCaoDoanhSo.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoDoanhSo.Location = new Point(-12, -43);
            btnBaoCaoDoanhSo.Name = "btnBaoCaoDoanhSo";
            btnBaoCaoDoanhSo.Padding = new Padding(30, 0, 0, 0);
            btnBaoCaoDoanhSo.Size = new Size(301, 156);
            btnBaoCaoDoanhSo.TabIndex = 1;
            btnBaoCaoDoanhSo.Text = "       Báo cáo doanh số ";
            btnBaoCaoDoanhSo.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoDoanhSo.UseVisualStyleBackColor = false;
            btnBaoCaoDoanhSo.Click += btnBaoCaoDoanhSo_Click;
            // 
            // panelBaoCaoCongNo
            // 
            panelBaoCaoCongNo.Controls.Add(btnBaoCaoCongNo);
            panelBaoCaoCongNo.Location = new Point(0, 136);
            panelBaoCaoCongNo.Margin = new Padding(0);
            panelBaoCaoCongNo.Name = "panelBaoCaoCongNo";
            panelBaoCaoCongNo.Padding = new Padding(0, 30, 0, 0);
            panelBaoCaoCongNo.Size = new Size(250, 68);
            panelBaoCaoCongNo.TabIndex = 3;
            // 
            // btnBaoCaoCongNo
            // 
            btnBaoCaoCongNo.BackColor = Color.FromArgb(60, 84, 108);
            btnBaoCaoCongNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBaoCaoCongNo.ForeColor = Color.White;
            btnBaoCaoCongNo.Image = (Image)resources.GetObject("btnBaoCaoCongNo.Image");
            btnBaoCaoCongNo.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoCongNo.Location = new Point(-12, -43);
            btnBaoCaoCongNo.Name = "btnBaoCaoCongNo";
            btnBaoCaoCongNo.Padding = new Padding(30, 0, 0, 0);
            btnBaoCaoCongNo.Size = new Size(328, 156);
            btnBaoCaoCongNo.TabIndex = 1;
            btnBaoCaoCongNo.Text = "       Báo cáo Công nợ ";
            btnBaoCaoCongNo.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoCongNo.UseVisualStyleBackColor = false;
            btnBaoCaoCongNo.Click += btnBaoCaoCongNo_Click;
            // 
            // menuTransition1
            // 
            menuTransition1.Interval = 10;
            menuTransition1.Tick += menuTransition1_Tick;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(pbPhanQuyen);
            panel8.Controls.Add(tbTimKiem);
            panel8.Controls.Add(pbSettingThamSo);
            panel8.Controls.Add(lblFormName);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(250, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1268, 61);
            panel8.TabIndex = 4;
            // 
            // pbPhanQuyen
            // 
            pbPhanQuyen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbPhanQuyen.Image = (Image)resources.GetObject("pbPhanQuyen.Image");
            pbPhanQuyen.InitialImage = (Image)resources.GetObject("pbPhanQuyen.InitialImage");
            pbPhanQuyen.Location = new Point(1161, 16);
            pbPhanQuyen.Name = "pbPhanQuyen";
            pbPhanQuyen.Size = new Size(42, 32);
            pbPhanQuyen.TabIndex = 3;
            pbPhanQuyen.TabStop = false;
            pbPhanQuyen.Click += pbPhanQuyen_Click;
            // 
            // tbTimKiem
            // 
            tbTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbTimKiem.BackColor = Color.FromArgb(236, 240, 241);
            tbTimKiem.BorderStyle = BorderStyle.None;
            tbTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTimKiem.Location = new Point(406, 16);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Size = new Size(553, 31);
            tbTimKiem.TabIndex = 2;
            tbTimKiem.Text = "       Tìm kiếm...";
            // 
            // pbSettingThamSo
            // 
            pbSettingThamSo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbSettingThamSo.Image = (Image)resources.GetObject("pbSettingThamSo.Image");
            pbSettingThamSo.InitialImage = (Image)resources.GetObject("pbSettingThamSo.InitialImage");
            pbSettingThamSo.Location = new Point(1209, 16);
            pbSettingThamSo.Name = "pbSettingThamSo";
            pbSettingThamSo.Size = new Size(32, 32);
            pbSettingThamSo.TabIndex = 1;
            pbSettingThamSo.TabStop = false;
            pbSettingThamSo.Click += pbSettingThamSo_Click_1;
            // 
            // lblFormName
            // 
            lblFormName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFormName.AutoSize = true;
            lblFormName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormName.ForeColor = Color.Black;
            lblFormName.Location = new Point(9, 9);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(255, 38);
            lblFormName.TabIndex = 0;
            lblFormName.Text = "Tên Form Hiện Tại";
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = Color.Black;
            panelMain.Location = new Point(250, 61);
            panelMain.Margin = new Padding(0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1268, 758);
            panelMain.TabIndex = 5;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 819);
            Controls.Add(panelMain);
            Controls.Add(panel8);
            Controls.Add(flpSidebar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Menu";
            Text = "Quản lý đại lý ";
            flpSidebar.ResumeLayout(false);
            panelDaiLy.ResumeLayout(false);
            panelPhieuNhap.ResumeLayout(false);
            panelPhieuXuat.ResumeLayout(false);
            panelPhieuThu.ResumeLayout(false);
            panelMatHang.ResumeLayout(false);
            reportContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panelBaoCaoDoanhSo.ResumeLayout(false);
            panelBaoCaoCongNo.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPhanQuyen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSettingThamSo).EndInit();
            ResumeLayout(false);
        }

        private void PbSettingThamSo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label1;
        private Label Seperator;
        private FlowLayoutPanel flpSidebar;
        private Panel panelDaiLy;
        private Button btnDaily;
        private Panel panelPhieuXuat;
        private Button btnPhieuXuatHang;
        private Panel panelPhieuThu;
        private Button btnPhieuThuTien;
        private Panel panelBaoCaoCongNo;
        private Button btnBaoCaoCongNo;
        private FlowLayoutPanel reportContainer;
        private Panel panelBaoCaoDoanhSo;
        private Button btnBaoCaoDoanhSo;
        private Panel panel7;
        private Button btnReport;
        private System.Windows.Forms.Timer menuTransition1;
        private Panel panel8;
        private Label lblFormName;
        private PictureBox pbSettingThamSo;
        private TextBox tbTimKiem;
        private Panel panelMain;
        private Panel panelMatHang;
        private Button btnProduct;
        private Panel panelPhieuNhap;
        private Button btnPhieuNhapHang;
        private PictureBox pbPhanQuyen;
    }
}