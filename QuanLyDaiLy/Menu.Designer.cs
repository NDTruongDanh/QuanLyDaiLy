﻿namespace GUI_QuanLy
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
            btnPhieuNhapHang = new Button();
            panel2 = new Panel();
            flpSidebar = new FlowLayoutPanel();
            panel5 = new Panel();
            btnDaily = new Button();
            panel1 = new Panel();
            btnPhieuXuatHang = new Button();
            panel3 = new Panel();
            btnPhieuThuTien = new Button();
            panel9 = new Panel();
            btnProduct = new Button();
            reportContainer = new FlowLayoutPanel();
            panel7 = new Panel();
            btnReport = new Button();
            panel6 = new Panel();
            btnBaoCaoDoanhSo = new Button();
            panel4 = new Panel();
            btnBaoCaoCongNo = new Button();
            menuTransition1 = new System.Windows.Forms.Timer(components);
            panel8 = new Panel();
            tbTimKiem = new TextBox();
            pbSettingThamSo = new PictureBox();
            lblFormName = new Label();
            panelMain = new Panel();
            panel2.SuspendLayout();
            flpSidebar.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            reportContainer.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSettingThamSo).BeginInit();
            SuspendLayout();
            // 
            // Seperator
            // 
            Seperator.BorderStyle = BorderStyle.Fixed3D;
            Seperator.Location = new Point(4, 112);
            Seperator.Margin = new Padding(4, 0, 4, 0);
            Seperator.Name = "Seperator";
            Seperator.Size = new Size(312, 2);
            Seperator.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 112);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ ĐẠI LÝ ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPhieuNhapHang
            // 
            btnPhieuNhapHang.BackColor = Color.FromArgb(44, 62, 80);
            btnPhieuNhapHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhieuNhapHang.ForeColor = Color.White;
            btnPhieuNhapHang.Image = (Image)resources.GetObject("btnPhieuNhapHang.Image");
            btnPhieuNhapHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhapHang.Location = new Point(-15, -54);
            btnPhieuNhapHang.Margin = new Padding(4, 4, 4, 4);
            btnPhieuNhapHang.Name = "btnPhieuNhapHang";
            btnPhieuNhapHang.Padding = new Padding(38, 0, 0, 0);
            btnPhieuNhapHang.Size = new Size(390, 195);
            btnPhieuNhapHang.TabIndex = 1;
            btnPhieuNhapHang.Text = "       Phiếu nhập hàng ";
            btnPhieuNhapHang.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhapHang.UseVisualStyleBackColor = false;
            btnPhieuNhapHang.Click += btnPhieuNhapHang_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPhieuNhapHang);
            panel2.Location = new Point(4, 211);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 25, 0, 0);
            panel2.Size = new Size(312, 85);
            panel2.TabIndex = 2;
            // 
            // flpSidebar
            // 
            flpSidebar.BackColor = Color.FromArgb(44, 62, 80);
            flpSidebar.Controls.Add(label1);
            flpSidebar.Controls.Add(Seperator);
            flpSidebar.Controls.Add(panel5);
            flpSidebar.Controls.Add(panel2);
            flpSidebar.Controls.Add(panel1);
            flpSidebar.Controls.Add(panel3);
            flpSidebar.Controls.Add(panel9);
            flpSidebar.Controls.Add(reportContainer);
            flpSidebar.Dock = DockStyle.Left;
            flpSidebar.Location = new Point(0, 0);
            flpSidebar.Margin = new Padding(0);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Size = new Size(312, 1291);
            flpSidebar.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnDaily);
            panel5.Location = new Point(4, 118);
            panel5.Margin = new Padding(4, 4, 4, 4);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 25, 0, 0);
            panel5.Size = new Size(312, 85);
            panel5.TabIndex = 4;
            // 
            // btnDaily
            // 
            btnDaily.BackColor = Color.FromArgb(44, 62, 80);
            btnDaily.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDaily.ForeColor = Color.White;
            btnDaily.Image = (Image)resources.GetObject("btnDaily.Image");
            btnDaily.ImageAlign = ContentAlignment.MiddleLeft;
            btnDaily.Location = new Point(-15, -54);
            btnDaily.Margin = new Padding(4, 4, 4, 4);
            btnDaily.Name = "btnDaily";
            btnDaily.Padding = new Padding(38, 0, 0, 0);
            btnDaily.Size = new Size(372, 195);
            btnDaily.TabIndex = 1;
            btnDaily.Text = "       Đại lý ";
            btnDaily.TextAlign = ContentAlignment.MiddleLeft;
            btnDaily.UseVisualStyleBackColor = false;
            btnDaily.Click += btnDaily_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPhieuXuatHang);
            panel1.Location = new Point(4, 304);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 38, 0, 0);
            panel1.Size = new Size(312, 85);
            panel1.TabIndex = 3;
            // 
            // btnPhieuXuatHang
            // 
            btnPhieuXuatHang.BackColor = Color.FromArgb(44, 62, 80);
            btnPhieuXuatHang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhieuXuatHang.ForeColor = Color.White;
            btnPhieuXuatHang.Image = (Image)resources.GetObject("btnPhieuXuatHang.Image");
            btnPhieuXuatHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuXuatHang.Location = new Point(-15, -54);
            btnPhieuXuatHang.Margin = new Padding(4, 4, 4, 4);
            btnPhieuXuatHang.Name = "btnPhieuXuatHang";
            btnPhieuXuatHang.Padding = new Padding(38, 0, 0, 0);
            btnPhieuXuatHang.Size = new Size(366, 195);
            btnPhieuXuatHang.TabIndex = 1;
            btnPhieuXuatHang.Text = "       Phiếu xuất hàng ";
            btnPhieuXuatHang.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuXuatHang.UseVisualStyleBackColor = false;
            btnPhieuXuatHang.Click += btnPhieuXuatHang_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPhieuThuTien);
            panel3.Location = new Point(4, 397);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 38, 0, 0);
            panel3.Size = new Size(312, 85);
            panel3.TabIndex = 3;
            // 
            // btnPhieuThuTien
            // 
            btnPhieuThuTien.BackColor = Color.FromArgb(44, 62, 80);
            btnPhieuThuTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPhieuThuTien.ForeColor = Color.White;
            btnPhieuThuTien.Image = (Image)resources.GetObject("btnPhieuThuTien.Image");
            btnPhieuThuTien.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuThuTien.Location = new Point(-15, -54);
            btnPhieuThuTien.Margin = new Padding(4, 4, 4, 4);
            btnPhieuThuTien.Name = "btnPhieuThuTien";
            btnPhieuThuTien.Padding = new Padding(38, 0, 0, 0);
            btnPhieuThuTien.Size = new Size(366, 195);
            btnPhieuThuTien.TabIndex = 1;
            btnPhieuThuTien.Text = "       Phiếu thu tiền ";
            btnPhieuThuTien.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuThuTien.UseVisualStyleBackColor = false;
            btnPhieuThuTien.Click += btnPhieuThuTien_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnProduct);
            panel9.Location = new Point(4, 490);
            panel9.Margin = new Padding(4, 4, 4, 4);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 25, 0, 0);
            panel9.Size = new Size(312, 85);
            panel9.TabIndex = 5;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(44, 62, 80);
            btnProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct.ForeColor = Color.White;
            btnProduct.Image = (Image)resources.GetObject("btnProduct.Image");
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(-16, -55);
            btnProduct.Margin = new Padding(4, 4, 4, 4);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(38, 0, 0, 0);
            btnProduct.Size = new Size(372, 195);
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
            reportContainer.Controls.Add(panel6);
            reportContainer.Controls.Add(panel4);
            reportContainer.Location = new Point(4, 583);
            reportContainer.Margin = new Padding(4, 4, 4, 4);
            reportContainer.Name = "reportContainer";
            reportContainer.Size = new Size(312, 85);
            reportContainer.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnReport);
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(0, 38, 0, 0);
            panel7.Size = new Size(312, 85);
            panel7.TabIndex = 5;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(44, 62, 80);
            btnReport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.White;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-15, -54);
            btnReport.Margin = new Padding(4, 4, 4, 4);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(38, 0, 0, 0);
            btnReport.Size = new Size(350, 195);
            btnReport.TabIndex = 1;
            btnReport.Text = "       Báo cáo";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnBaoCaoDoanhSo);
            panel6.Location = new Point(0, 85);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 38, 0, 0);
            panel6.Size = new Size(312, 85);
            panel6.TabIndex = 4;
            // 
            // btnBaoCaoDoanhSo
            // 
            btnBaoCaoDoanhSo.BackColor = Color.FromArgb(60, 84, 108);
            btnBaoCaoDoanhSo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBaoCaoDoanhSo.ForeColor = Color.White;
            btnBaoCaoDoanhSo.Image = (Image)resources.GetObject("btnBaoCaoDoanhSo.Image");
            btnBaoCaoDoanhSo.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoDoanhSo.Location = new Point(-15, -54);
            btnBaoCaoDoanhSo.Margin = new Padding(4, 4, 4, 4);
            btnBaoCaoDoanhSo.Name = "btnBaoCaoDoanhSo";
            btnBaoCaoDoanhSo.Padding = new Padding(38, 0, 0, 0);
            btnBaoCaoDoanhSo.Size = new Size(376, 195);
            btnBaoCaoDoanhSo.TabIndex = 1;
            btnBaoCaoDoanhSo.Text = "       Báo cáo doanh số ";
            btnBaoCaoDoanhSo.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoDoanhSo.UseVisualStyleBackColor = false;
            btnBaoCaoDoanhSo.Click += btnBaoCaoDoanhSo_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnBaoCaoCongNo);
            panel4.Location = new Point(0, 170);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 38, 0, 0);
            panel4.Size = new Size(312, 85);
            panel4.TabIndex = 3;
            // 
            // btnBaoCaoCongNo
            // 
            btnBaoCaoCongNo.BackColor = Color.FromArgb(60, 84, 108);
            btnBaoCaoCongNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBaoCaoCongNo.ForeColor = Color.White;
            btnBaoCaoCongNo.Image = (Image)resources.GetObject("btnBaoCaoCongNo.Image");
            btnBaoCaoCongNo.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoCongNo.Location = new Point(-15, -54);
            btnBaoCaoCongNo.Margin = new Padding(4, 4, 4, 4);
            btnBaoCaoCongNo.Name = "btnBaoCaoCongNo";
            btnBaoCaoCongNo.Padding = new Padding(38, 0, 0, 0);
            btnBaoCaoCongNo.Size = new Size(410, 195);
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
            panel8.Controls.Add(tbTimKiem);
            panel8.Controls.Add(pbSettingThamSo);
            panel8.Controls.Add(lblFormName);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(312, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(2066, 76);
            panel8.TabIndex = 4;
            // 
            // tbTimKiem
            // 
            tbTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbTimKiem.BackColor = Color.FromArgb(236, 240, 241);
            tbTimKiem.BorderStyle = BorderStyle.None;
            tbTimKiem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTimKiem.Location = new Point(508, 20);
            tbTimKiem.Margin = new Padding(4, 4, 4, 4);
            tbTimKiem.Name = "tbTimKiem";
            tbTimKiem.Size = new Size(1172, 37);
            tbTimKiem.TabIndex = 2;
            tbTimKiem.Text = "       Tìm kiếm...";
            // 
            // pbSettingThamSo
            // 
            pbSettingThamSo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbSettingThamSo.Image = (Image)resources.GetObject("pbSettingThamSo.Image");
            pbSettingThamSo.InitialImage = (Image)resources.GetObject("pbSettingThamSo.InitialImage");
            pbSettingThamSo.Location = new Point(1992, 20);
            pbSettingThamSo.Margin = new Padding(4, 4, 4, 4);
            pbSettingThamSo.Name = "pbSettingThamSo";
            pbSettingThamSo.Size = new Size(40, 40);
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
            lblFormName.Location = new Point(11, 11);
            lblFormName.Margin = new Padding(4, 0, 4, 0);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(299, 45);
            lblFormName.TabIndex = 0;
            lblFormName.Text = "Tên Form Hiện Tại";
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.ForeColor = Color.Black;
            panelMain.Location = new Point(312, 76);
            panelMain.Margin = new Padding(0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(2066, 1215);
            panelMain.TabIndex = 5;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2378, 1291);
            Controls.Add(panelMain);
            Controls.Add(panel8);
            Controls.Add(flpSidebar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 5, 5, 5);
            Name = "Menu";
            Text = "Quản lý đại lý ";
            panel2.ResumeLayout(false);
            flpSidebar.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            reportContainer.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
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
        private Button btnPhieuNhapHang;
        private Panel panel2;
        private FlowLayoutPanel flpSidebar;
        private Panel panel5;
        private Button btnDaily;
        private Panel panel1;
        private Button btnPhieuXuatHang;
        private Panel panel3;
        private Button btnPhieuThuTien;
        private Panel panel4;
        private Button btnBaoCaoCongNo;
        private FlowLayoutPanel reportContainer;
        private Panel panel6;
        private Button btnBaoCaoDoanhSo;
        private Panel panel7;
        private Button btnReport;
        private System.Windows.Forms.Timer menuTransition1;
        private Panel panel8;
        private Label lblFormName;
        private PictureBox pbSettingThamSo;
        private TextBox tbTimKiem;
        private Panel panelMain;
        private Panel panel9;
        private Button btnProduct;
    }
}