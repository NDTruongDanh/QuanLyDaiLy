namespace GUI_QuanLy
{
    partial class GUI_PhieuThu
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_PhieuThu));
            lblDanhSachPhieuThu = new Label();
            dgvPhieuThu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            cbbDaiLy = new ComboBox();
            lblTenDaiLy = new Label();
            lblThongTinPhieuThu = new Label();
            tblFormPhieuThu = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flpNhap = new FlowLayoutPanel();
            tblNhap = new TableLayoutPanel();
            lblNgayThuTien = new Label();
            dtpNgayThuTien = new DateTimePicker();
            lblSoTienThu = new Label();
            txtSoTienThu = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            panel3 = new Panel();
            btnEdit = new Button();
            panel4 = new Panel();
            btnDelete = new Button();
            panel5 = new Panel();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuThu).BeginInit();
            tblFormPhieuThu.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flpNhap.SuspendLayout();
            tblNhap.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblDanhSachPhieuThu
            // 
            lblDanhSachPhieuThu.AutoSize = true;
            lblDanhSachPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachPhieuThu.Location = new Point(5, 5);
            lblDanhSachPhieuThu.Margin = new Padding(5);
            lblDanhSachPhieuThu.Name = "lblDanhSachPhieuThu";
            lblDanhSachPhieuThu.Size = new Size(363, 32);
            lblDanhSachPhieuThu.TabIndex = 16;
            lblDanhSachPhieuThu.Text = "Danh sách phiếu thu của đại lý";
            // 
            // dgvPhieuThu
            // 
            dgvPhieuThu.AllowUserToResizeColumns = false;
            dgvPhieuThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuThu.BackgroundColor = Color.White;
            dgvPhieuThu.BorderStyle = BorderStyle.None;
            dgvPhieuThu.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvPhieuThu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPhieuThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPhieuThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuThu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPhieuThu.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPhieuThu.EnableHeadersVisualStyles = false;
            dgvPhieuThu.GridColor = Color.White;
            dgvPhieuThu.Location = new Point(3, 45);
            dgvPhieuThu.Name = "dgvPhieuThu";
            dgvPhieuThu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPhieuThu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPhieuThu.RowHeadersVisible = false;
            dgvPhieuThu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPhieuThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuThu.Size = new Size(1612, 518);
            dgvPhieuThu.TabIndex = 14;
            dgvPhieuThu.SelectionChanged += dgvPhieuThu_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Đại Lý";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Địa Chỉ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Điện Thoại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Ngày Thu Tiền";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Số Tiền Thu";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // cbbDaiLy
            // 
            cbbDaiLy.Font = new Font("Segoe UI", 12F);
            cbbDaiLy.FormattingEnabled = true;
            cbbDaiLy.Location = new Point(150, 3);
            cbbDaiLy.Name = "cbbDaiLy";
            cbbDaiLy.Size = new Size(350, 36);
            cbbDaiLy.TabIndex = 12;
            // 
            // lblTenDaiLy
            // 
            lblTenDaiLy.AutoSize = true;
            lblTenDaiLy.BackColor = Color.Transparent;
            lblTenDaiLy.Dock = DockStyle.Right;
            lblTenDaiLy.Font = new Font("Segoe UI", 12F);
            lblTenDaiLy.Location = new Point(42, 0);
            lblTenDaiLy.Name = "lblTenDaiLy";
            lblTenDaiLy.Size = new Size(102, 41);
            lblTenDaiLy.TabIndex = 0;
            lblTenDaiLy.Text = "Tên Đại Lý:";
            // 
            // lblThongTinPhieuThu
            // 
            lblThongTinPhieuThu.AutoSize = true;
            lblThongTinPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinPhieuThu.Location = new Point(5, 5);
            lblThongTinPhieuThu.Margin = new Padding(5);
            lblThongTinPhieuThu.Name = "lblThongTinPhieuThu";
            lblThongTinPhieuThu.Size = new Size(221, 32);
            lblThongTinPhieuThu.TabIndex = 16;
            lblThongTinPhieuThu.Text = "Lập Phiếu thu tiền";
            // 
            // tblFormPhieuThu
            // 
            tblFormPhieuThu.ColumnCount = 1;
            tblFormPhieuThu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFormPhieuThu.Controls.Add(flowLayoutPanel1, 0, 0);
            tblFormPhieuThu.Controls.Add(flpNhap, 0, 1);
            tblFormPhieuThu.Dock = DockStyle.Fill;
            tblFormPhieuThu.Location = new Point(0, 0);
            tblFormPhieuThu.Name = "tblFormPhieuThu";
            tblFormPhieuThu.RowCount = 2;
            tblFormPhieuThu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFormPhieuThu.RowStyles.Add(new RowStyle());
            tblFormPhieuThu.Size = new Size(1634, 940);
            tblFormPhieuThu.TabIndex = 26;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lblDanhSachPhieuThu);
            flowLayoutPanel1.Controls.Add(dgvPhieuThu);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1628, 583);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // flpNhap
            // 
            flpNhap.Controls.Add(lblThongTinPhieuThu);
            flpNhap.Controls.Add(tblNhap);
            flpNhap.Controls.Add(flpButtons);
            flpNhap.Dock = DockStyle.Fill;
            flpNhap.FlowDirection = FlowDirection.TopDown;
            flpNhap.Location = new Point(3, 592);
            flpNhap.Name = "flpNhap";
            flpNhap.Size = new Size(1628, 345);
            flpNhap.TabIndex = 32;
            // 
            // tblNhap
            // 
            tblNhap.ColumnCount = 2;
            tblNhap.ColumnStyles.Add(new ColumnStyle());
            tblNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblNhap.Controls.Add(lblTenDaiLy, 0, 0);
            tblNhap.Controls.Add(lblNgayThuTien, 0, 1);
            tblNhap.Controls.Add(dtpNgayThuTien, 1, 1);
            tblNhap.Controls.Add(lblSoTienThu, 0, 2);
            tblNhap.Controls.Add(txtSoTienThu, 1, 2);
            tblNhap.Controls.Add(cbbDaiLy, 1, 0);
            tblNhap.Dock = DockStyle.Right;
            tblNhap.Location = new Point(132, 92);
            tblNhap.Margin = new Padding(5, 50, 5, 50);
            tblNhap.Name = "tblNhap";
            tblNhap.RowCount = 3;
            tblNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tblNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tblNhap.Size = new Size(1382, 126);
            tblNhap.TabIndex = 32;
            // 
            // lblNgayThuTien
            // 
            lblNgayThuTien.AutoSize = true;
            lblNgayThuTien.Dock = DockStyle.Right;
            lblNgayThuTien.Font = new Font("Segoe UI", 12F);
            lblNgayThuTien.Location = new Point(3, 41);
            lblNgayThuTien.Name = "lblNgayThuTien";
            lblNgayThuTien.Size = new Size(141, 42);
            lblNgayThuTien.TabIndex = 2;
            lblNgayThuTien.Text = "Ngày Thu Tiền:";
            // 
            // dtpNgayThuTien
            // 
            dtpNgayThuTien.Font = new Font("Segoe UI", 12F);
            dtpNgayThuTien.Location = new Point(150, 44);
            dtpNgayThuTien.Name = "dtpNgayThuTien";
            dtpNgayThuTien.Size = new Size(350, 34);
            dtpNgayThuTien.TabIndex = 3;
            // 
            // lblSoTienThu
            // 
            lblSoTienThu.AutoSize = true;
            lblSoTienThu.Dock = DockStyle.Right;
            lblSoTienThu.Font = new Font("Segoe UI", 12F);
            lblSoTienThu.Location = new Point(27, 83);
            lblSoTienThu.Name = "lblSoTienThu";
            lblSoTienThu.Size = new Size(117, 43);
            lblSoTienThu.TabIndex = 4;
            lblSoTienThu.Text = "Số Tiền Thu:";
            // 
            // txtSoTienThu
            // 
            txtSoTienThu.Font = new Font("Segoe UI", 12F);
            txtSoTienThu.Location = new Point(150, 86);
            txtSoTienThu.Name = "txtSoTienThu";
            txtSoTienThu.Size = new Size(350, 34);
            txtSoTienThu.TabIndex = 5;
            txtSoTienThu.KeyPress += txtSoTienThu_KeyPress;
            // 
            // flpButtons
            // 
            flpButtons.AutoSize = true;
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Controls.Add(panel3);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(panel4);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(panel5);
            flpButtons.Controls.Add(btnRefresh);
            flpButtons.Dock = DockStyle.Right;
            flpButtons.Location = new Point(900, 273);
            flpButtons.Margin = new Padding(900, 5, 5, 5);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(614, 50);
            flpButtons.TabIndex = 31;
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
            // panel3
            // 
            panel3.Location = new Point(137, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(20, 20);
            panel3.TabIndex = 24;
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
            // panel4
            // 
            panel4.Location = new Point(297, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(20, 20);
            panel4.TabIndex = 25;
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
            // panel5
            // 
            panel5.Location = new Point(457, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(20, 20);
            panel5.TabIndex = 26;
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
            // GUI_PhieuThu
            // 
            ClientSize = new Size(1634, 940);
            Controls.Add(tblFormPhieuThu);
            Name = "GUI_PhieuThu";
            Text = "Quản Lý Phiếu Thu";
            Load += GUI_PhieuThu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhieuThu).EndInit();
            tblFormPhieuThu.ResumeLayout(false);
            tblFormPhieuThu.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flpNhap.ResumeLayout(false);
            flpNhap.PerformLayout();
            tblNhap.ResumeLayout(false);
            tblNhap.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }
        private Label lblDanhSachPhieuThu;
        private DataGridView dgvPhieuThu;
        private Panel panel2;
        private TableLayoutPanel tblNhapPhieu;
        private Label lblTenDaiLy;
        private Label lblThongTinPhieuThu;
        private Label label4;
        private TableLayoutPanel tblFormPhieuThu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox cbbDaiLy;
        private FlowLayoutPanel flpNhap;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Panel panel3;
        private Button btnEdit;
        private Panel panel4;
        private Button btnDelete;
        private Panel panel5;
        private Button btnRefresh;
        private FlowLayoutPanel flowLayoutPanel1;
        private DateTimePicker dtpNgayThuTien;
        private TextBox txtSoTienThu;
        private Label lblNgayThuTien;
        private Label lblSoTienThu;
        private TableLayoutPanel tblNhap;
    }
}
