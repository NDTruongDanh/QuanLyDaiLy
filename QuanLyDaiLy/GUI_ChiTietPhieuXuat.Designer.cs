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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ChiTietPhieuXuat));
            flpForm = new FlowLayoutPanel();
            flpMaPhieu = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblMaPhieuNhap = new Label();
            txtMaPhieuNhap = new TextBox();
            flpDaiLy = new FlowLayoutPanel();
            lblDaily = new Label();
            txtDaiLy = new TextBox();
            flpNgayLap = new FlowLayoutPanel();
            lblNgayLapPhieu = new Label();
            dtpNgayLap = new DateTimePicker();
            dgvChiTietPhieuXuat = new DataGridView();
            flpTongTien = new FlowLayoutPanel();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            flpTienTra = new FlowLayoutPanel();
            lblSoTienTra = new Label();
            txtSoTienTra = new TextBox();
            flpConLai = new FlowLayoutPanel();
            lblConLai = new Label();
            txtConLai = new TextBox();
            tblInput = new TableLayoutPanel();
            label9 = new Label();
            txtDonGiaXuat = new TextBox();
            label2 = new Label();
            txtSoLuong = new TextBox();
            txtThanhTien = new TextBox();
            lblSL = new Label();
            lblTenMatHang = new Label();
            cbbMatHang = new ComboBox();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            panel1 = new Panel();
            btnEdit = new Button();
            panel2 = new Panel();
            btnDelete = new Button();
            panel3 = new Panel();
            btnRefresh = new Button();
            notifyIcon1 = new NotifyIcon(components);
            flpForm.SuspendLayout();
            flpMaPhieu.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flpDaiLy.SuspendLayout();
            flpNgayLap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuXuat).BeginInit();
            flpTongTien.SuspendLayout();
            flpTienTra.SuspendLayout();
            flpConLai.SuspendLayout();
            tblInput.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // flpForm
            // 
            flpForm.Controls.Add(flpMaPhieu);
            flpForm.Controls.Add(dgvChiTietPhieuXuat);
            flpForm.Controls.Add(flpTongTien);
            flpForm.Controls.Add(flpTienTra);
            flpForm.Controls.Add(flpConLai);
            flpForm.Controls.Add(tblInput);
            flpForm.Controls.Add(flpButtons);
            flpForm.Dock = DockStyle.Fill;
            flpForm.FlowDirection = FlowDirection.TopDown;
            flpForm.Location = new Point(0, 0);
            flpForm.Name = "flpForm";
            flpForm.Size = new Size(1332, 787);
            flpForm.TabIndex = 1;
            // 
            // flpMaPhieu
            // 
            flpMaPhieu.AutoSize = true;
            flpMaPhieu.Controls.Add(flowLayoutPanel2);
            flpMaPhieu.Controls.Add(flpDaiLy);
            flpMaPhieu.Controls.Add(flpNgayLap);
            flpMaPhieu.Dock = DockStyle.Top;
            flpMaPhieu.Location = new Point(10, 10);
            flpMaPhieu.Margin = new Padding(10);
            flpMaPhieu.Name = "flpMaPhieu";
            flpMaPhieu.Size = new Size(1173, 50);
            flpMaPhieu.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(lblMaPhieuNhap);
            flowLayoutPanel2.Controls.Add(txtMaPhieuNhap);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(280, 44);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // lblMaPhieuNhap
            // 
            lblMaPhieuNhap.AutoSize = true;
            lblMaPhieuNhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaPhieuNhap.Location = new Point(3, 3);
            lblMaPhieuNhap.Margin = new Padding(3);
            lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            lblMaPhieuNhap.Size = new Size(114, 31);
            lblMaPhieuNhap.TabIndex = 1;
            lblMaPhieuNhap.Text = "Số phiếu:";
            lblMaPhieuNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.BackColor = Color.White;
            txtMaPhieuNhap.BorderStyle = BorderStyle.None;
            txtMaPhieuNhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaPhieuNhap.Location = new Point(125, 5);
            txtMaPhieuNhap.Margin = new Padding(5);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.Size = new Size(150, 31);
            txtMaPhieuNhap.TabIndex = 2;
            // 
            // flpDaiLy
            // 
            flpDaiLy.AutoSize = true;
            flpDaiLy.Controls.Add(lblDaily);
            flpDaiLy.Controls.Add(txtDaiLy);
            flpDaiLy.Location = new Point(289, 3);
            flpDaiLy.Name = "flpDaiLy";
            flpDaiLy.Size = new Size(247, 41);
            flpDaiLy.TabIndex = 6;
            // 
            // lblDaily
            // 
            lblDaily.AutoSize = true;
            lblDaily.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDaily.Location = new Point(3, 3);
            lblDaily.Margin = new Padding(3);
            lblDaily.Name = "lblDaily";
            lblDaily.Size = new Size(81, 31);
            lblDaily.TabIndex = 2;
            lblDaily.Text = "Đại lý:";
            lblDaily.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDaiLy
            // 
            txtDaiLy.BackColor = Color.White;
            txtDaiLy.BorderStyle = BorderStyle.None;
            txtDaiLy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDaiLy.Location = new Point(92, 5);
            txtDaiLy.Margin = new Padding(5);
            txtDaiLy.Name = "txtDaiLy";
            txtDaiLy.Size = new Size(150, 31);
            txtDaiLy.TabIndex = 3;
            // 
            // flpNgayLap
            // 
            flpNgayLap.AutoSize = true;
            flpNgayLap.Controls.Add(lblNgayLapPhieu);
            flpNgayLap.Controls.Add(dtpNgayLap);
            flpNgayLap.Location = new Point(542, 3);
            flpNgayLap.Name = "flpNgayLap";
            flpNgayLap.Size = new Size(594, 44);
            flpNgayLap.TabIndex = 4;
            // 
            // lblNgayLapPhieu
            // 
            lblNgayLapPhieu.AutoSize = true;
            lblNgayLapPhieu.Dock = DockStyle.Fill;
            lblNgayLapPhieu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNgayLapPhieu.Location = new Point(3, 0);
            lblNgayLapPhieu.Name = "lblNgayLapPhieu";
            lblNgayLapPhieu.Size = new Size(182, 44);
            lblNgayLapPhieu.TabIndex = 4;
            lblNgayLapPhieu.Text = "Ngày lập phiếu:";
            lblNgayLapPhieu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLap.Location = new Point(191, 3);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(400, 38);
            dtpNgayLap.TabIndex = 3;
            // 
            // dgvChiTietPhieuXuat
            // 
            dgvChiTietPhieuXuat.AllowUserToResizeColumns = false;
            dgvChiTietPhieuXuat.AllowUserToResizeRows = false;
            dgvChiTietPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietPhieuXuat.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiTietPhieuXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietPhieuXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvChiTietPhieuXuat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTietPhieuXuat.Dock = DockStyle.Top;
            dgvChiTietPhieuXuat.Location = new Point(10, 80);
            dgvChiTietPhieuXuat.Margin = new Padding(10);
            dgvChiTietPhieuXuat.Name = "dgvChiTietPhieuXuat";
            dgvChiTietPhieuXuat.RowHeadersVisible = false;
            dgvChiTietPhieuXuat.RowHeadersWidth = 51;
            dgvChiTietPhieuXuat.Size = new Size(1173, 233);
            dgvChiTietPhieuXuat.TabIndex = 0;
            dgvChiTietPhieuXuat.SelectionChanged += dgvChiTietPhieuXuat_SelectionChanged;
            // 
            // flpTongTien
            // 
            flpTongTien.AutoSize = true;
            flpTongTien.Controls.Add(lblTongTien);
            flpTongTien.Controls.Add(txtTongTien);
            flpTongTien.Dock = DockStyle.Right;
            flpTongTien.Location = new Point(726, 328);
            flpTongTien.Margin = new Padding(10, 5, 10, 5);
            flpTongTien.Name = "flpTongTien";
            flpTongTien.Size = new Size(457, 49);
            flpTongTien.TabIndex = 27;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Dock = DockStyle.Fill;
            lblTongTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblTongTien.Location = new Point(3, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(145, 49);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            txtTongTien.Location = new Point(154, 3);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(300, 43);
            txtTongTien.TabIndex = 1;
            // 
            // flpTienTra
            // 
            flpTienTra.AutoSize = true;
            flpTienTra.Controls.Add(lblSoTienTra);
            flpTienTra.Controls.Add(txtSoTienTra);
            flpTienTra.Dock = DockStyle.Right;
            flpTienTra.Location = new Point(716, 387);
            flpTienTra.Margin = new Padding(10, 5, 10, 5);
            flpTienTra.Name = "flpTienTra";
            flpTienTra.Size = new Size(467, 49);
            flpTienTra.TabIndex = 34;
            // 
            // lblSoTienTra
            // 
            lblSoTienTra.AutoSize = true;
            lblSoTienTra.Dock = DockStyle.Fill;
            lblSoTienTra.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblSoTienTra.Location = new Point(3, 0);
            lblSoTienTra.Name = "lblSoTienTra";
            lblSoTienTra.Size = new Size(155, 49);
            lblSoTienTra.TabIndex = 0;
            lblSoTienTra.Text = "Số tiền trả:";
            // 
            // txtSoTienTra
            // 
            txtSoTienTra.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            txtSoTienTra.Location = new Point(164, 3);
            txtSoTienTra.Name = "txtSoTienTra";
            txtSoTienTra.Size = new Size(300, 43);
            txtSoTienTra.TabIndex = 1;
            // 
            // flpConLai
            // 
            flpConLai.AutoSize = true;
            flpConLai.Controls.Add(lblConLai);
            flpConLai.Controls.Add(txtConLai);
            flpConLai.Dock = DockStyle.Right;
            flpConLai.Location = new Point(760, 446);
            flpConLai.Margin = new Padding(10, 5, 10, 5);
            flpConLai.Name = "flpConLai";
            flpConLai.Size = new Size(423, 49);
            flpConLai.TabIndex = 33;
            // 
            // lblConLai
            // 
            lblConLai.AutoSize = true;
            lblConLai.Dock = DockStyle.Fill;
            lblConLai.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblConLai.Location = new Point(3, 0);
            lblConLai.Name = "lblConLai";
            lblConLai.Size = new Size(111, 49);
            lblConLai.TabIndex = 0;
            lblConLai.Text = "Còn lại:";
            // 
            // txtConLai
            // 
            txtConLai.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            txtConLai.Location = new Point(120, 3);
            txtConLai.Name = "txtConLai";
            txtConLai.ReadOnly = true;
            txtConLai.Size = new Size(300, 43);
            txtConLai.TabIndex = 1;
            // 
            // tblInput
            // 
            tblInput.AutoSize = true;
            tblInput.ColumnCount = 5;
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5647659F));
            tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.07772F));
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.2279778F));
            tblInput.Controls.Add(label9, 3, 2);
            tblInput.Controls.Add(txtDonGiaXuat, 4, 0);
            tblInput.Controls.Add(label2, 3, 0);
            tblInput.Controls.Add(txtSoLuong, 1, 2);
            tblInput.Controls.Add(txtThanhTien, 4, 2);
            tblInput.Controls.Add(lblSL, 0, 2);
            tblInput.Controls.Add(lblTenMatHang, 0, 0);
            tblInput.Controls.Add(cbbMatHang, 1, 0);
            tblInput.Dock = DockStyle.Top;
            tblInput.Location = new Point(10, 510);
            tblInput.Margin = new Padding(10);
            tblInput.Name = "tblInput";
            tblInput.RowCount = 5;
            tblInput.RowStyles.Add(new RowStyle());
            tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblInput.RowStyles.Add(new RowStyle());
            tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblInput.RowStyles.Add(new RowStyle());
            tblInput.Size = new Size(1173, 116);
            tblInput.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Right;
            label9.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(671, 58);
            label9.Name = "label9";
            label9.Size = new Size(158, 38);
            label9.TabIndex = 21;
            label9.Text = "Thành tiền:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDonGiaXuat
            // 
            txtDonGiaXuat.Dock = DockStyle.Fill;
            txtDonGiaXuat.Location = new Point(835, 3);
            txtDonGiaXuat.Name = "txtDonGiaXuat";
            txtDonGiaXuat.ReadOnly = true;
            txtDonGiaXuat.Size = new Size(335, 27);
            txtDonGiaXuat.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(705, 0);
            label2.Name = "label2";
            label2.Size = new Size(124, 38);
            label2.TabIndex = 11;
            label2.Text = "Đơn giá:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Dock = DockStyle.Fill;
            txtSoLuong.Location = new Point(206, 61);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(297, 27);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Dock = DockStyle.Fill;
            txtThanhTien.Location = new Point(835, 61);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(335, 27);
            txtThanhTien.TabIndex = 8;
            // 
            // lblSL
            // 
            lblSL.AutoSize = true;
            lblSL.Dock = DockStyle.Right;
            lblSL.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSL.Location = new Point(62, 58);
            lblSL.Name = "lblSL";
            lblSL.Size = new Size(138, 38);
            lblSL.TabIndex = 5;
            lblSL.Text = "Số lượng:";
            lblSL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenMatHang
            // 
            lblTenMatHang.AutoSize = true;
            lblTenMatHang.Dock = DockStyle.Right;
            lblTenMatHang.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenMatHang.Location = new Point(3, 0);
            lblTenMatHang.Name = "lblTenMatHang";
            lblTenMatHang.Size = new Size(197, 38);
            lblTenMatHang.TabIndex = 3;
            lblTenMatHang.Text = "Tên mặt hàng:";
            lblTenMatHang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbMatHang
            // 
            cbbMatHang.Dock = DockStyle.Fill;
            cbbMatHang.FormattingEnabled = true;
            cbbMatHang.Location = new Point(206, 3);
            cbbMatHang.Name = "cbbMatHang";
            cbbMatHang.Size = new Size(297, 28);
            cbbMatHang.TabIndex = 0;
            // 
            // flpButtons
            // 
            flpButtons.AutoSize = true;
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Controls.Add(panel1);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(panel2);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(panel3);
            flpButtons.Controls.Add(btnRefresh);
            flpButtons.Dock = DockStyle.Right;
            flpButtons.Location = new Point(569, 646);
            flpButtons.Margin = new Padding(10);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(614, 50);
            flpButtons.TabIndex = 30;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 44);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(137, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(20, 20);
            panel1.TabIndex = 24;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.BackColor = Color.FromArgb(255, 152, 0);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(163, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 44);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(297, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 20);
            panel2.TabIndex = 25;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(323, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 44);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(457, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(20, 20);
            panel3.TabIndex = 26;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.FromArgb(33, 150, 243);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(483, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(128, 44);
            btnRefresh.TabIndex = 23;
            btnRefresh.Text = "   Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // GUI_ChiTietPhieuXuat
            // 
            ClientSize = new Size(1332, 787);
            Controls.Add(flpForm);
            Name = "GUI_ChiTietPhieuXuat";
            Text = "Quản Lý Chi Tiết Phiếu Xuất";
            Load += GUI_ChiTietPhieuXuat_Load;
            flpForm.ResumeLayout(false);
            flpForm.PerformLayout();
            flpMaPhieu.ResumeLayout(false);
            flpMaPhieu.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flpDaiLy.ResumeLayout(false);
            flpDaiLy.PerformLayout();
            flpNgayLap.ResumeLayout(false);
            flpNgayLap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuXuat).EndInit();
            flpTongTien.ResumeLayout(false);
            flpTongTien.PerformLayout();
            flpTienTra.ResumeLayout(false);
            flpTienTra.PerformLayout();
            flpConLai.ResumeLayout(false);
            flpConLai.PerformLayout();
            tblInput.ResumeLayout(false);
            tblInput.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }

        private FlowLayoutPanel flpForm;
        private FlowLayoutPanel flpMaPhieu;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblMaPhieuNhap;
        private TextBox txtMaPhieuNhap;
        private FlowLayoutPanel flpDaiLy;
        private Label lblDaily;
        private TextBox txtDaiLy;
        private FlowLayoutPanel flpNgayLap;
        private Label lblNgayLapPhieu;
        private DateTimePicker dtpNgayLap;
        private DataGridView dgvChiTietPhieuXuat;
        private FlowLayoutPanel flpTongTien;
        private Label lblTongTien;
        private TextBox txtTongTien;
        private TableLayoutPanel tblInput;
        private ComboBox cbbMatHang;
        private TextBox txtSoLuong;
        private TextBox txtThanhTien;
        private Label lblTenMatHang;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Panel panel1;
        private Button btnEdit;
        private Panel panel2;
        private Button btnDelete;
        private Panel panel3;
        private Button btnRefresh;
        private FlowLayoutPanel flpTienTra;
        private Label lblSoTienTra;
        private TextBox txtSoTienTra;
        private FlowLayoutPanel flpConLai;
        private Label lblConLai;
        private TextBox txtConLai;
        private NotifyIcon notifyIcon1;
        private Label label9;
        private TextBox txtDonGiaXuat;
        private Label label2;
        private Label lblSL;
    }
}
