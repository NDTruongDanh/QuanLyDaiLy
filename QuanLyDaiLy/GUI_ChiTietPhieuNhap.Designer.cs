﻿using System.Windows.Forms;

namespace GUI_QuanLy
{
    partial class GUI_ChiTietPhieuNhap
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvChiTietPhieuNhap = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtTongTien = new TextBox();
            label10 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtMaPhieuNhap = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dtpNgayLap = new DateTimePicker();
            lblDanhSachPhieuThu = new Label();
            label2 = new Label();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtThanhTien = new TextBox();
            label9 = new Label();
            cbbDonViTinh = new ComboBox();
            txtDonGiaNhap = new TextBox();
            txtSoLuong = new TextBox();
            cbbMatHang = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblThongTinPhieuThu = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnEdit);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnRefresh);
            flowLayoutPanel1.Location = new Point(470, 173);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(502, 44);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(2, 2);
            btnAdd.Margin = new Padding(2, 2, 16, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 40);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "➕  Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.BackColor = Color.FromArgb(255, 152, 0);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(129, 2);
            btnEdit.Margin = new Padding(2, 2, 16, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 40);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "✏️ Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(249, 2);
            btnDelete.Margin = new Padding(2, 2, 16, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 40);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "🗑 Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.FromArgb(33, 150, 243);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Location = new Point(369, 2);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 40);
            btnRefresh.TabIndex = 24;
            btnRefresh.Text = "🔍 Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 65.13076F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 34.86924F));
            tableLayoutPanel2.Size = new Size(1006, 723);
            tableLayoutPanel2.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(lblDanhSachPhieuThu);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(13, 13);
            panel1.Margin = new Padding(13, 13, 13, 6);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(13, 13, 13, 6);
            panel1.Size = new Size(980, 451);
            panel1.TabIndex = 24;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(dgvChiTietPhieuNhap, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Location = new Point(13, 95);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 89.17051F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8294935F));
            tableLayoutPanel4.Size = new Size(952, 340);
            tableLayoutPanel4.TabIndex = 18;
            // 
            // dgvChiTietPhieuNhap
            // 
            dgvChiTietPhieuNhap.AllowUserToResizeColumns = false;
            dgvChiTietPhieuNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietPhieuNhap.BackgroundColor = Color.White;
            dgvChiTietPhieuNhap.BorderStyle = BorderStyle.None;
            dgvChiTietPhieuNhap.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvChiTietPhieuNhap.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvChiTietPhieuNhap.DefaultCellStyle = dataGridViewCellStyle5;
            dgvChiTietPhieuNhap.EnableHeadersVisualStyles = false;
            dgvChiTietPhieuNhap.GridColor = Color.White;
            dgvChiTietPhieuNhap.Location = new Point(2, 2);
            dgvChiTietPhieuNhap.Margin = new Padding(2);
            dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            dgvChiTietPhieuNhap.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvChiTietPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvChiTietPhieuNhap.RowHeadersVisible = false;
            dgvChiTietPhieuNhap.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvChiTietPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietPhieuNhap.Size = new Size(948, 299);
            dgvChiTietPhieuNhap.TabIndex = 14;
            dgvChiTietPhieuNhap.SelectionChanged += dgvChiTietPhieuNhap_SelectionChanged;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(txtTongTien, 1, 0);
            tableLayoutPanel5.Controls.Add(label10, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Right;
            tableLayoutPanel5.Location = new Point(640, 305);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(310, 33);
            tableLayoutPanel5.TabIndex = 15;
            // 
            // txtTongTien
            // 
            txtTongTien.Dock = DockStyle.Fill;
            txtTongTien.Font = new Font("Segoe UI", 12F);
            txtTongTien.Location = new Point(101, 2);
            txtTongTien.Margin = new Padding(2);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(207, 34);
            txtTongTien.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(2, 2);
            label10.Margin = new Padding(2);
            label10.Name = "label10";
            label10.Size = new Size(95, 28);
            label10.TabIndex = 13;
            label10.Text = "Tổng tiền";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.Controls.Add(txtMaPhieuNhap, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Controls.Add(dtpNgayLap, 3, 0);
            tableLayoutPanel1.Location = new Point(15, 50);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(952, 40);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.Dock = DockStyle.Fill;
            txtMaPhieuNhap.Font = new Font("Segoe UI", 12F);
            txtMaPhieuNhap.Location = new Point(95, 2);
            txtMaPhieuNhap.Margin = new Padding(2);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.ReadOnly = true;
            txtMaPhieuNhap.Size = new Size(232, 34);
            txtMaPhieuNhap.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(2, 2);
            label3.Margin = new Padding(2);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 12;
            label3.Text = "Số phiếu";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(331, 2);
            label1.Margin = new Padding(2);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 11;
            label1.Text = "Ngày lập phiếu";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Dock = DockStyle.Fill;
            dtpNgayLap.Font = new Font("Segoe UI", 12F);
            dtpNgayLap.Location = new Point(480, 2);
            dtpNgayLap.Margin = new Padding(2);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(470, 34);
            dtpNgayLap.TabIndex = 10;
            // 
            // lblDanhSachPhieuThu
            // 
            lblDanhSachPhieuThu.AutoSize = true;
            lblDanhSachPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachPhieuThu.Location = new Point(15, 13);
            lblDanhSachPhieuThu.Margin = new Padding(2, 0, 2, 0);
            lblDanhSachPhieuThu.Name = "lblDanhSachPhieuThu";
            lblDanhSachPhieuThu.Size = new Size(345, 32);
            lblDanhSachPhieuThu.TabIndex = 16;
            lblDanhSachPhieuThu.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(0, 46);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(2400, 2);
            label2.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(lblThongTinPhieuThu);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(13, 483);
            panel2.Margin = new Padding(13);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 227);
            panel2.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(txtThanhTien, 1, 2);
            tableLayoutPanel3.Controls.Add(label9, 0, 2);
            tableLayoutPanel3.Controls.Add(cbbDonViTinh, 3, 0);
            tableLayoutPanel3.Controls.Add(txtDonGiaNhap, 3, 1);
            tableLayoutPanel3.Controls.Add(txtSoLuong, 1, 1);
            tableLayoutPanel3.Controls.Add(cbbMatHang, 1, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(label6, 0, 1);
            tableLayoutPanel3.Controls.Add(label7, 2, 0);
            tableLayoutPanel3.Controls.Add(label8, 2, 1);
            tableLayoutPanel3.Location = new Point(15, 52);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(949, 107);
            tableLayoutPanel3.TabIndex = 33;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Dock = DockStyle.Fill;
            txtThanhTien.Font = new Font("Segoe UI", 12F);
            txtThanhTien.Location = new Point(109, 80);
            txtThanhTien.Margin = new Padding(2);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(361, 34);
            txtThanhTien.TabIndex = 23;
            txtThanhTien.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(2, 80);
            label9.Margin = new Padding(2);
            label9.Name = "label9";
            label9.Size = new Size(103, 28);
            label9.TabIndex = 22;
            label9.Text = "Thành tiền";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbDonViTinh
            // 
            cbbDonViTinh.Dock = DockStyle.Fill;
            cbbDonViTinh.Font = new Font("Segoe UI", 12F);
            cbbDonViTinh.FormattingEnabled = true;
            cbbDonViTinh.Location = new Point(586, 2);
            cbbDonViTinh.Margin = new Padding(2);
            cbbDonViTinh.Name = "cbbDonViTinh";
            cbbDonViTinh.Size = new Size(361, 36);
            cbbDonViTinh.TabIndex = 21;
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Dock = DockStyle.Fill;
            txtDonGiaNhap.Font = new Font("Segoe UI", 12F);
            txtDonGiaNhap.Location = new Point(586, 42);
            txtDonGiaNhap.Margin = new Padding(2);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(361, 34);
            txtDonGiaNhap.TabIndex = 20;
            txtDonGiaNhap.Text = "0";
            txtDonGiaNhap.TextChanged += txtDonGiaNhap_TextChanged;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Dock = DockStyle.Fill;
            txtSoLuong.Font = new Font("Segoe UI", 12F);
            txtSoLuong.Location = new Point(109, 42);
            txtSoLuong.Margin = new Padding(2);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(361, 34);
            txtSoLuong.TabIndex = 19;
            txtSoLuong.Text = "0";
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // cbbMatHang
            // 
            cbbMatHang.Dock = DockStyle.Fill;
            cbbMatHang.Font = new Font("Segoe UI", 12F);
            cbbMatHang.FormattingEnabled = true;
            cbbMatHang.Location = new Point(109, 2);
            cbbMatHang.Margin = new Padding(2);
            cbbMatHang.Name = "cbbMatHang";
            cbbMatHang.Size = new Size(361, 36);
            cbbMatHang.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(2, 2);
            label5.Margin = new Padding(2);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 13;
            label5.Text = "Mặt hàng";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(2, 42);
            label6.Margin = new Padding(2);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 14;
            label6.Text = "Số lượng";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(474, 2);
            label7.Margin = new Padding(2);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 15;
            label7.Text = "Đơn vị tính";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(474, 42);
            label8.Margin = new Padding(2);
            label8.Name = "label8";
            label8.Size = new Size(81, 28);
            label8.TabIndex = 16;
            label8.Text = "Đơn giá";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblThongTinPhieuThu
            // 
            lblThongTinPhieuThu.AutoSize = true;
            lblThongTinPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinPhieuThu.Location = new Point(15, 10);
            lblThongTinPhieuThu.Margin = new Padding(2, 0, 2, 0);
            lblThongTinPhieuThu.Name = "lblThongTinPhieuThu";
            lblThongTinPhieuThu.Size = new Size(240, 32);
            lblThongTinPhieuThu.TabIndex = 16;
            lblThongTinPhieuThu.Text = "Thông tin mặt hàng";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(0, 41);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(2400, 2);
            label4.TabIndex = 15;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(76, 175, 80);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(2, 2);
            button1.Margin = new Padding(2, 2, 16, 2);
            button1.Name = "button1";
            button1.Size = new Size(109, 40);
            button1.TabIndex = 22;
            button1.Text = "➕  Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(255, 152, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(129, 2);
            button2.Margin = new Padding(2, 2, 16, 2);
            button2.Name = "button2";
            button2.Size = new Size(102, 40);
            button2.TabIndex = 21;
            button2.Text = "✏️ Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(244, 67, 54);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(249, 2);
            button3.Margin = new Padding(2, 2, 16, 2);
            button3.Name = "button3";
            button3.Size = new Size(102, 40);
            button3.TabIndex = 20;
            button3.Text = "🗑 Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.FromArgb(33, 150, 243);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(369, 2);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(131, 40);
            button4.TabIndex = 24;
            button4.Text = "🔍 Làm mới";
            button4.UseVisualStyleBackColor = false;
            // 
            // GUI_ChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 723);
            Controls.Add(tableLayoutPanel2);
            Name = "GUI_ChiTietPhieuNhap";
            Text = "GUI_ChiTietPhieuNhap";
            Load += GUI_ChiTietPhieuNhap_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label lblDanhSachPhieuThu;
        private Label label2;
        private DataGridView dgvChiTietPhieuNhap;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblThongTinPhieuThu;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DateTimePicker dtpNgayLap;
        private Label label3;
        private TextBox txtMaPhieuNhap;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private ComboBox cbbMatHang;
        private TextBox txtDonGiaNhap;
        private TextBox txtSoLuong;
        private TextBox txtThanhTien;
        private Label label9;
        private ComboBox cbbDonViTinh;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtTongTien;
        private Label label10;
    }
}