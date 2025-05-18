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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ChiTietPhieuXuat));
            flpForm = new FlowLayoutPanel();
            flpMaPhieu = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblMaPhieuNhap = new Label();
            txtMaPhieuNhap = new TextBox();
            flpNgayLap = new FlowLayoutPanel();
            lblNgayLapPhieu = new Label();
            dtpNgayLap = new DateTimePicker();
            dgvDsChiTiet = new DataGridView();
            dgvtxtMatHang = new DataGridViewTextBoxColumn();
            dgvtxtDCT = new DataGridViewTextBoxColumn();
            dgvtxtSL = new DataGridViewTextBoxColumn();
            dgvtxtDG = new DataGridViewTextBoxColumn();
            dgvtxtThanhTien = new DataGridViewTextBoxColumn();
            flpTongTien = new FlowLayoutPanel();
            lblTongTien = new Label();
            textBox1 = new TextBox();
            tblInput = new TableLayoutPanel();
            lblDG = new Label();
            cbbMatHang = new ComboBox();
            txtSL = new TextBox();
            txtThanhTien = new TextBox();
            txtDG = new TextBox();
            cbbDVT = new ComboBox();
            lblDVT = new Label();
            lblThanhTien = new Label();
            lblSL = new Label();
            lblTenMatHang = new Label();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            panel1 = new Panel();
            btnEdit = new Button();
            panel2 = new Panel();
            btnDelete = new Button();
            panel3 = new Panel();
            btnFind = new Button();
            flpDaiLy = new FlowLayoutPanel();
            lblDaily = new Label();
            txtDaiLy = new TextBox();
            flpConLai = new FlowLayoutPanel();
            lblConLai = new Label();
            txtConLai = new TextBox();
            flpTienTra = new FlowLayoutPanel();
            lblSoTienTra = new Label();
            txtSoTienTra = new TextBox();
            flpForm.SuspendLayout();
            flpMaPhieu.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flpNgayLap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTiet).BeginInit();
            flpTongTien.SuspendLayout();
            tblInput.SuspendLayout();
            flpButtons.SuspendLayout();
            flpDaiLy.SuspendLayout();
            flpConLai.SuspendLayout();
            flpTienTra.SuspendLayout();
            SuspendLayout();
            // 
            // flpForm
            // 
            flpForm.Controls.Add(flpMaPhieu);
            flpForm.Controls.Add(dgvDsChiTiet);
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
            flpMaPhieu.Size = new Size(1139, 50);
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
            // dgvDsChiTiet
            // 
            dgvDsChiTiet.AllowUserToResizeColumns = false;
            dgvDsChiTiet.AllowUserToResizeRows = false;
            dgvDsChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDsChiTiet.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDsChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDsChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsChiTiet.Columns.AddRange(new DataGridViewColumn[] { dgvtxtMatHang, dgvtxtDCT, dgvtxtSL, dgvtxtDG, dgvtxtThanhTien });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvDsChiTiet.DefaultCellStyle = dataGridViewCellStyle4;
            dgvDsChiTiet.Dock = DockStyle.Top;
            dgvDsChiTiet.Location = new Point(10, 80);
            dgvDsChiTiet.Margin = new Padding(10);
            dgvDsChiTiet.Name = "dgvDsChiTiet";
            dgvDsChiTiet.RowHeadersVisible = false;
            dgvDsChiTiet.RowHeadersWidth = 51;
            dgvDsChiTiet.Size = new Size(1139, 233);
            dgvDsChiTiet.TabIndex = 0;
            // 
            // dgvtxtMatHang
            // 
            dgvtxtMatHang.HeaderText = "Tên Mặt Hàng";
            dgvtxtMatHang.MinimumWidth = 6;
            dgvtxtMatHang.Name = "dgvtxtMatHang";
            dgvtxtMatHang.ReadOnly = true;
            dgvtxtMatHang.Resizable = DataGridViewTriState.True;
            dgvtxtMatHang.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDCT
            // 
            dgvtxtDCT.HeaderText = "Đơn Vị Tính";
            dgvtxtDCT.MinimumWidth = 6;
            dgvtxtDCT.Name = "dgvtxtDCT";
            dgvtxtDCT.ReadOnly = true;
            dgvtxtDCT.Resizable = DataGridViewTriState.True;
            dgvtxtDCT.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtSL
            // 
            dgvtxtSL.HeaderText = "Số Lượng";
            dgvtxtSL.MinimumWidth = 6;
            dgvtxtSL.Name = "dgvtxtSL";
            // 
            // dgvtxtDG
            // 
            dgvtxtDG.HeaderText = "Đơn Giá";
            dgvtxtDG.MinimumWidth = 6;
            dgvtxtDG.Name = "dgvtxtDG";
            // 
            // dgvtxtThanhTien
            // 
            dgvtxtThanhTien.HeaderText = "Thành Tiền";
            dgvtxtThanhTien.MinimumWidth = 6;
            dgvtxtThanhTien.Name = "dgvtxtThanhTien";
            dgvtxtThanhTien.ReadOnly = true;
            // 
            // flpTongTien
            // 
            flpTongTien.AutoSize = true;
            flpTongTien.Controls.Add(lblTongTien);
            flpTongTien.Controls.Add(textBox1);
            flpTongTien.Dock = DockStyle.Right;
            flpTongTien.Location = new Point(692, 328);
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            textBox1.Location = new Point(154, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(300, 43);
            textBox1.TabIndex = 1;
            // 
            // tblInput
            // 
            tblInput.AutoSize = true;
            tblInput.ColumnCount = 5;
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.Controls.Add(lblDG, 3, 2);
            tblInput.Controls.Add(cbbMatHang, 1, 0);
            tblInput.Controls.Add(txtSL, 1, 2);
            tblInput.Controls.Add(txtThanhTien, 1, 4);
            tblInput.Controls.Add(txtDG, 4, 2);
            tblInput.Controls.Add(cbbDVT, 4, 0);
            tblInput.Controls.Add(lblDVT, 3, 0);
            tblInput.Controls.Add(lblThanhTien, 0, 4);
            tblInput.Controls.Add(lblSL, 0, 2);
            tblInput.Controls.Add(lblTenMatHang, 0, 0);
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
            tblInput.Size = new Size(1139, 154);
            tblInput.TabIndex = 32;
            // 
            // lblDG
            // 
            lblDG.AutoSize = true;
            lblDG.Dock = DockStyle.Right;
            lblDG.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDG.Location = new Point(799, 58);
            lblDG.Name = "lblDG";
            lblDG.Size = new Size(124, 38);
            lblDG.TabIndex = 6;
            lblDG.Text = "Đơn giá:";
            lblDG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbMatHang
            // 
            cbbMatHang.FormattingEnabled = true;
            cbbMatHang.Location = new Point(206, 3);
            cbbMatHang.Name = "cbbMatHang";
            cbbMatHang.Size = new Size(200, 28);
            cbbMatHang.TabIndex = 0;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(206, 61);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(200, 27);
            txtSL.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(206, 119);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(200, 27);
            txtThanhTien.TabIndex = 9;
            // 
            // txtDG
            // 
            txtDG.Location = new Point(929, 61);
            txtDG.Name = "txtDG";
            txtDG.Size = new Size(200, 27);
            txtDG.TabIndex = 8;
            // 
            // cbbDVT
            // 
            cbbDVT.FormattingEnabled = true;
            cbbDVT.Location = new Point(929, 3);
            cbbDVT.Name = "cbbDVT";
            cbbDVT.Size = new Size(200, 28);
            cbbDVT.TabIndex = 2;
            // 
            // lblDVT
            // 
            lblDVT.AutoSize = true;
            lblDVT.Dock = DockStyle.Right;
            lblDVT.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDVT.Location = new Point(712, 0);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new Size(211, 38);
            lblDVT.TabIndex = 4;
            lblDVT.Text = "Tên đơn vị tính:";
            lblDVT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Dock = DockStyle.Right;
            lblThanhTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThanhTien.Location = new Point(42, 116);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(158, 38);
            lblThanhTien.TabIndex = 7;
            lblThanhTien.Text = "Thành tiền:";
            lblThanhTien.TextAlign = ContentAlignment.MiddleCenter;
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
            // flpButtons
            // 
            flpButtons.AutoSize = true;
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Controls.Add(panel1);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(panel2);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(panel3);
            flpButtons.Controls.Add(btnFind);
            flpButtons.Dock = DockStyle.Right;
            flpButtons.Location = new Point(535, 684);
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
            // 
            // panel3
            // 
            panel3.Location = new Point(457, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(20, 20);
            panel3.TabIndex = 26;
            // 
            // btnFind
            // 
            btnFind.AutoSize = true;
            btnFind.BackColor = Color.FromArgb(33, 150, 243);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 12F);
            btnFind.Image = (Image)resources.GetObject("btnFind.Image");
            btnFind.ImageAlign = ContentAlignment.MiddleLeft;
            btnFind.Location = new Point(483, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(128, 44);
            btnFind.TabIndex = 23;
            btnFind.Text = "   Làm mới";
            btnFind.UseVisualStyleBackColor = false;
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
            // flpConLai
            // 
            flpConLai.AutoSize = true;
            flpConLai.Controls.Add(lblConLai);
            flpConLai.Controls.Add(txtConLai);
            flpConLai.Dock = DockStyle.Right;
            flpConLai.Location = new Point(726, 446);
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
            // flpTienTra
            // 
            flpTienTra.AutoSize = true;
            flpTienTra.Controls.Add(lblSoTienTra);
            flpTienTra.Controls.Add(txtSoTienTra);
            flpTienTra.Dock = DockStyle.Right;
            flpTienTra.Location = new Point(682, 387);
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
            flpNgayLap.ResumeLayout(false);
            flpNgayLap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTiet).EndInit();
            flpTongTien.ResumeLayout(false);
            flpTongTien.PerformLayout();
            tblInput.ResumeLayout(false);
            tblInput.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            flpDaiLy.ResumeLayout(false);
            flpDaiLy.PerformLayout();
            flpConLai.ResumeLayout(false);
            flpConLai.PerformLayout();
            flpTienTra.ResumeLayout(false);
            flpTienTra.PerformLayout();
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
        private DataGridView dgvDsChiTiet;
        private DataGridViewTextBoxColumn dgvtxtMatHang;
        private DataGridViewTextBoxColumn dgvtxtDCT;
        private DataGridViewTextBoxColumn dgvtxtSL;
        private DataGridViewTextBoxColumn dgvtxtDG;
        private DataGridViewTextBoxColumn dgvtxtThanhTien;
        private FlowLayoutPanel flpTongTien;
        private Label lblTongTien;
        private TextBox textBox1;
        private TableLayoutPanel tblInput;
        private Label lblDG;
        private ComboBox cbbMatHang;
        private TextBox txtSL;
        private TextBox txtThanhTien;
        private TextBox txtDG;
        private ComboBox cbbDVT;
        private Label lblDVT;
        private Label lblThanhTien;
        private Label lblSL;
        private Label lblTenMatHang;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Panel panel1;
        private Button btnEdit;
        private Panel panel2;
        private Button btnDelete;
        private Panel panel3;
        private Button btnFind;
        private FlowLayoutPanel flpTienTra;
        private Label lblSoTienTra;
        private TextBox txtSoTienTra;
        private FlowLayoutPanel flpConLai;
        private Label lblConLai;
        private TextBox txtConLai;
    }
}
