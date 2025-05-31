namespace GUI_QuanLy
{
    partial class GUI_ChiTietPhieuXuat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            notifyIcon1 = new NotifyIcon(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            txtConLai = new TextBox();
            txtSoTienTra = new TextBox();
            label12 = new Label();
            txtTongTien = new TextBox();
            label10 = new Label();
            label13 = new Label();
            dgvChiTietPhieuXuat = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtDaiLy = new TextBox();
            label11 = new Label();
            txtMaPhieuXuat = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dtpNgayLap = new DateTimePicker();
            lblDanhSachPhieuThu = new Label();
            label2 = new Label();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtThanhTien = new TextBox();
            label9 = new Label();
            txtDonGiaXuat = new TextBox();
            txtSoLuong = new TextBox();
            cbbMatHang = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            lblThongTinPhieuThu = new Label();
            label4 = new Label();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuXuat).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
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
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 65.13076F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 34.86924F));
            tableLayoutPanel2.Size = new Size(1258, 904);
            tableLayoutPanel2.TabIndex = 34;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(lblDanhSachPhieuThu);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(16, 16);
            panel1.Margin = new Padding(16, 16, 16, 8);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16, 16, 16, 8);
            panel1.Size = new Size(1226, 564);
            panel1.TabIndex = 24;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(dgvChiTietPhieuXuat, 0, 0);
            tableLayoutPanel4.Location = new Point(19, 119);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 89.17051F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.8294935F));
            tableLayoutPanel4.Size = new Size(1188, 434);
            tableLayoutPanel4.TabIndex = 18;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 6;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(txtConLai, 5, 0);
            tableLayoutPanel5.Controls.Add(txtSoTienTra, 3, 0);
            tableLayoutPanel5.Controls.Add(label12, 2, 0);
            tableLayoutPanel5.Controls.Add(txtTongTien, 1, 0);
            tableLayoutPanel5.Controls.Add(label10, 0, 0);
            tableLayoutPanel5.Controls.Add(label13, 4, 0);
            tableLayoutPanel5.Dock = DockStyle.Right;
            tableLayoutPanel5.Location = new Point(3, 390);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(1182, 41);
            tableLayoutPanel5.TabIndex = 15;
            // 
            // txtConLai
            // 
            txtConLai.Dock = DockStyle.Fill;
            txtConLai.Font = new Font("Segoe UI", 12F);
            txtConLai.Location = new Point(886, 3);
            txtConLai.Name = "txtConLai";
            txtConLai.ReadOnly = true;
            txtConLai.Size = new Size(293, 34);
            txtConLai.TabIndex = 18;
            // 
            // txtSoTienTra
            // 
            txtSoTienTra.Dock = DockStyle.Fill;
            txtSoTienTra.Font = new Font("Segoe UI", 12F);
            txtSoTienTra.Location = new Point(510, 3);
            txtSoTienTra.Name = "txtSoTienTra";
            txtSoTienTra.Size = new Size(292, 34);
            txtSoTienTra.TabIndex = 17;
            txtSoTienTra.TextChanged += txtSoTienTra_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(402, 3);
            label12.Margin = new Padding(3);
            label12.Name = "label12";
            label12.Size = new Size(102, 28);
            label12.TabIndex = 15;
            label12.Text = "Số tiền trả";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTongTien
            // 
            txtTongTien.Dock = DockStyle.Fill;
            txtTongTien.Font = new Font("Segoe UI", 12F);
            txtTongTien.Location = new Point(104, 3);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(292, 34);
            txtTongTien.TabIndex = 14;
            txtTongTien.TextChanged += txtTongTien_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(3, 3);
            label10.Margin = new Padding(3);
            label10.Name = "label10";
            label10.Size = new Size(95, 28);
            label10.TabIndex = 13;
            label10.Text = "Tổng tiền";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(808, 3);
            label13.Margin = new Padding(3);
            label13.Name = "label13";
            label13.Size = new Size(72, 28);
            label13.TabIndex = 16;
            label13.Text = "Còn lại";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvChiTietPhieuXuat
            // 
            dgvChiTietPhieuXuat.AllowUserToResizeColumns = false;
            dgvChiTietPhieuXuat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiTietPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietPhieuXuat.BackgroundColor = Color.White;
            dgvChiTietPhieuXuat.BorderStyle = BorderStyle.None;
            dgvChiTietPhieuXuat.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvChiTietPhieuXuat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiTietPhieuXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietPhieuXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvChiTietPhieuXuat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTietPhieuXuat.EnableHeadersVisualStyles = false;
            dgvChiTietPhieuXuat.GridColor = Color.White;
            dgvChiTietPhieuXuat.Location = new Point(3, 3);
            dgvChiTietPhieuXuat.Name = "dgvChiTietPhieuXuat";
            dgvChiTietPhieuXuat.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvChiTietPhieuXuat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvChiTietPhieuXuat.RowHeadersVisible = false;
            dgvChiTietPhieuXuat.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvChiTietPhieuXuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietPhieuXuat.Size = new Size(1182, 381);
            dgvChiTietPhieuXuat.TabIndex = 14;
            dgvChiTietPhieuXuat.SelectionChanged += dgvChiTietPhieuXuat_SelectionChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4641352F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.1181431F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.4683552F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5316448F));
            tableLayoutPanel1.Controls.Add(txtDaiLy, 3, 0);
            tableLayoutPanel1.Controls.Add(label11, 2, 0);
            tableLayoutPanel1.Controls.Add(txtMaPhieuXuat, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 4, 0);
            tableLayoutPanel1.Controls.Add(dtpNgayLap, 6, 0);
            tableLayoutPanel1.Location = new Point(22, 63);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1185, 50);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // txtDaiLy
            // 
            txtDaiLy.Dock = DockStyle.Fill;
            txtDaiLy.Font = new Font("Segoe UI", 12F);
            txtDaiLy.Location = new Point(521, 3);
            txtDaiLy.Name = "txtDaiLy";
            txtDaiLy.ReadOnly = true;
            txtDaiLy.Size = new Size(185, 34);
            txtDaiLy.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(397, 3);
            label11.Margin = new Padding(3);
            label11.Name = "label11";
            label11.Size = new Size(61, 28);
            label11.TabIndex = 14;
            label11.Text = "Đại lý";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMaPhieuXuat
            // 
            txtMaPhieuXuat.Dock = DockStyle.Fill;
            txtMaPhieuXuat.Font = new Font("Segoe UI", 12F);
            txtMaPhieuXuat.Location = new Point(200, 3);
            txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            txtMaPhieuXuat.ReadOnly = true;
            txtMaPhieuXuat.Size = new Size(191, 34);
            txtMaPhieuXuat.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 3);
            label3.Margin = new Padding(3);
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
            label1.Location = new Point(712, 3);
            label1.Margin = new Padding(3);
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
            dtpNgayLap.Location = new Point(919, 3);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(263, 34);
            dtpNgayLap.TabIndex = 10;
            // 
            // lblDanhSachPhieuThu
            // 
            lblDanhSachPhieuThu.AutoSize = true;
            lblDanhSachPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachPhieuThu.Location = new Point(19, 16);
            lblDanhSachPhieuThu.Name = "lblDanhSachPhieuThu";
            lblDanhSachPhieuThu.Size = new Size(338, 32);
            lblDanhSachPhieuThu.TabIndex = 16;
            lblDanhSachPhieuThu.Text = "Thông tin chi tiết Phiếu xuất";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(0, 58);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(3000, 2);
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
            panel2.Location = new Point(16, 604);
            panel2.Margin = new Padding(16);
            panel2.Name = "panel2";
            panel2.Size = new Size(1226, 284);
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
            tableLayoutPanel3.Controls.Add(txtDonGiaXuat, 3, 1);
            tableLayoutPanel3.Controls.Add(txtSoLuong, 1, 1);
            tableLayoutPanel3.Controls.Add(cbbMatHang, 1, 0);
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.Controls.Add(label6, 0, 1);
            tableLayoutPanel3.Controls.Add(label8, 2, 1);
            tableLayoutPanel3.Location = new Point(19, 75);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1188, 142);
            tableLayoutPanel3.TabIndex = 33;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Dock = DockStyle.Fill;
            txtThanhTien.Font = new Font("Segoe UI", 12F);
            txtThanhTien.Location = new Point(112, 85);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(490, 34);
            txtThanhTien.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(3, 85);
            label9.Margin = new Padding(3);
            label9.Name = "label9";
            label9.Size = new Size(103, 28);
            label9.TabIndex = 22;
            label9.Text = "Thành tiền";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDonGiaXuat
            // 
            txtDonGiaXuat.Dock = DockStyle.Fill;
            txtDonGiaXuat.Font = new Font("Segoe UI", 12F);
            txtDonGiaXuat.Location = new Point(695, 45);
            txtDonGiaXuat.Name = "txtDonGiaXuat";
            txtDonGiaXuat.ReadOnly = true;
            txtDonGiaXuat.Size = new Size(490, 34);
            txtDonGiaXuat.TabIndex = 20;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Dock = DockStyle.Fill;
            txtSoLuong.Font = new Font("Segoe UI", 12F);
            txtSoLuong.Location = new Point(112, 45);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(490, 34);
            txtSoLuong.TabIndex = 19;
            txtSoLuong.Text = "1";
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            // 
            // cbbMatHang
            // 
            cbbMatHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbMatHang.AutoCompleteSource = AutoCompleteSource.ListItems;
            tableLayoutPanel3.SetColumnSpan(cbbMatHang, 3);
            cbbMatHang.Dock = DockStyle.Fill;
            cbbMatHang.Font = new Font("Segoe UI", 12F);
            cbbMatHang.FormattingEnabled = true;
            cbbMatHang.Location = new Point(112, 3);
            cbbMatHang.Name = "cbbMatHang";
            cbbMatHang.Size = new Size(1073, 36);
            cbbMatHang.TabIndex = 17;
            cbbMatHang.SelectedIndexChanged += cbbMatHang_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 3);
            label5.Margin = new Padding(3);
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
            label6.Location = new Point(3, 45);
            label6.Margin = new Padding(3);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 14;
            label6.Text = "Số lượng";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(608, 45);
            label8.Margin = new Padding(3);
            label8.Name = "label8";
            label8.Size = new Size(81, 28);
            label8.TabIndex = 16;
            label8.Text = "Đơn giá";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnEdit);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnRefresh);
            flowLayoutPanel1.Location = new Point(600, 232);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(623, 52);
            flowLayoutPanel1.TabIndex = 32;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(3, 3);
            btnAdd.Margin = new Padding(3, 3, 20, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 44);
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
            btnEdit.Location = new Point(160, 3);
            btnEdit.Margin = new Padding(3, 3, 20, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 44);
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
            btnDelete.Location = new Point(311, 3);
            btnDelete.Margin = new Padding(3, 3, 20, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 44);
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
            btnRefresh.Location = new Point(462, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(158, 44);
            btnRefresh.TabIndex = 24;
            btnRefresh.Text = "🔍 Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblThongTinPhieuThu
            // 
            lblThongTinPhieuThu.AutoSize = true;
            lblThongTinPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinPhieuThu.Location = new Point(19, 13);
            lblThongTinPhieuThu.Name = "lblThongTinPhieuThu";
            lblThongTinPhieuThu.Size = new Size(240, 32);
            lblThongTinPhieuThu.TabIndex = 16;
            lblThongTinPhieuThu.Text = "Thông tin mặt hàng";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(0, 51);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(3000, 2);
            label4.TabIndex = 15;
            // 
            // GUI_ChiTietPhieuXuat
            // 
            ClientSize = new Size(1258, 904);
            Controls.Add(tableLayoutPanel2);
            Name = "GUI_ChiTietPhieuXuat";
            Text = "Quản Lý Chi Tiết Phiếu Xuất";
            FormClosed += GUI_ChiTietPhieuXuat_FormClosed;
            Load += GUI_ChiTietPhieuXuat_Load;
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuXuat).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private NotifyIcon notifyIcon1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dgvChiTietPhieuXuat;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox txtTongTien;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtMaPhieuXuat;
        private Label label3;
        private Label label1;
        private DateTimePicker dtpNgayLap;
        private Label lblDanhSachPhieuThu;
        private Label label2;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtThanhTien;
        private Label label9;
        private TextBox txtDonGiaXuat;
        private TextBox txtSoLuong;
        private ComboBox cbbMatHang;
        private Label label5;
        private Label label6;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Label lblThongTinPhieuThu;
        private Label label4;
        private TextBox txtDaiLy;
        private Label label11;
        private TextBox txtConLai;
        private TextBox txtSoTienTra;
        private Label label12;
        private Label label13;
    }
}
