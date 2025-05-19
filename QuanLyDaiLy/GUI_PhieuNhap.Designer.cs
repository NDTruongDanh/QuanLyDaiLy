namespace GUI_QuanLy
{
    partial class GUI_PhieuNhap
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_PhieuNhap));
            dgvPhieuNhap = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            flpPhieuNhap = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblDanhSachPhieuXuat = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            lblNhapPhieu = new Label();
            tblThongTinPhieuNhap = new TableLayoutPanel();
            lblNgayLapPhieu = new Label();
            dtpNgayLapPhieu = new DateTimePicker();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            flpPhieuNhap.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            tblThongTinPhieuNhap.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToResizeColumns = false;
            dgvPhieuNhap.AllowUserToResizeRows = false;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.BackgroundColor = Color.White;
            dgvPhieuNhap.BorderStyle = BorderStyle.None;
            dgvPhieuNhap.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPhieuNhap.EnableHeadersVisualStyles = false;
            dgvPhieuNhap.GridColor = Color.White;
            dgvPhieuNhap.Location = new Point(5, 47);
            dgvPhieuNhap.Margin = new Padding(5);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.Size = new Size(1630, 584);
            dgvPhieuNhap.TabIndex = 17;
            dgvPhieuNhap.SelectionChanged += dgvPhieuNhap_SelectionChanged;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // flpPhieuNhap
            // 
            flpPhieuNhap.Controls.Add(flowLayoutPanel2);
            flpPhieuNhap.Controls.Add(flowLayoutPanel1);
            flpPhieuNhap.Controls.Add(panel4);
            flpPhieuNhap.Dock = DockStyle.Fill;
            flpPhieuNhap.FlowDirection = FlowDirection.TopDown;
            flpPhieuNhap.Location = new Point(0, 0);
            flpPhieuNhap.Name = "flpPhieuNhap";
            flpPhieuNhap.Size = new Size(1634, 925);
            flpPhieuNhap.TabIndex = 18;
            flpPhieuNhap.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.Controls.Add(lblDanhSachPhieuXuat);
            flowLayoutPanel2.Controls.Add(dgvPhieuNhap);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(20, 5);
            flowLayoutPanel2.Margin = new Padding(20, 5, 0, 5);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1640, 636);
            flowLayoutPanel2.TabIndex = 31;
            // 
            // lblDanhSachPhieuXuat
            // 
            lblDanhSachPhieuXuat.AutoSize = true;
            lblDanhSachPhieuXuat.BackColor = Color.White;
            lblDanhSachPhieuXuat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachPhieuXuat.Location = new Point(20, 5);
            lblDanhSachPhieuXuat.Margin = new Padding(20, 5, 5, 5);
            lblDanhSachPhieuXuat.Name = "lblDanhSachPhieuXuat";
            lblDanhSachPhieuXuat.Size = new Size(266, 32);
            lblDanhSachPhieuXuat.TabIndex = 17;
            lblDanhSachPhieuXuat.Text = "Danh sách phiếu nhập";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(3, 649);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblNhapPhieu);
            panel4.Controls.Add(tblThongTinPhieuNhap);
            panel4.Controls.Add(flpButtons);
            panel4.Location = new Point(20, 657);
            panel4.Margin = new Padding(20, 5, 5, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1635, 252);
            panel4.TabIndex = 32;
            // 
            // lblNhapPhieu
            // 
            lblNhapPhieu.AutoSize = true;
            lblNhapPhieu.BackColor = Color.White;
            lblNhapPhieu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapPhieu.Location = new Point(27, 11);
            lblNhapPhieu.Margin = new Padding(20, 5, 5, 5);
            lblNhapPhieu.Name = "lblNhapPhieu";
            lblNhapPhieu.Size = new Size(259, 32);
            lblNhapPhieu.TabIndex = 30;
            lblNhapPhieu.Text = "Nhập liệu phiếu nhập";
            // 
            // tblThongTinPhieuNhap
            // 
            tblThongTinPhieuNhap.AutoSize = true;
            tblThongTinPhieuNhap.ColumnCount = 2;
            tblThongTinPhieuNhap.ColumnStyles.Add(new ColumnStyle());
            tblThongTinPhieuNhap.ColumnStyles.Add(new ColumnStyle());
            tblThongTinPhieuNhap.Controls.Add(lblNgayLapPhieu, 0, 0);
            tblThongTinPhieuNhap.Controls.Add(dtpNgayLapPhieu, 1, 0);
            tblThongTinPhieuNhap.Controls.Add(lblTongTien, 0, 1);
            tblThongTinPhieuNhap.Controls.Add(txtTongTien, 1, 1);
            tblThongTinPhieuNhap.Location = new Point(96, 92);
            tblThongTinPhieuNhap.Margin = new Padding(200, 3, 3, 3);
            tblThongTinPhieuNhap.Name = "tblThongTinPhieuNhap";
            tblThongTinPhieuNhap.RowCount = 2;
            tblThongTinPhieuNhap.RowStyles.Add(new RowStyle());
            tblThongTinPhieuNhap.RowStyles.Add(new RowStyle());
            tblThongTinPhieuNhap.Size = new Size(512, 90);
            tblThongTinPhieuNhap.TabIndex = 28;
            // 
            // lblNgayLapPhieu
            // 
            lblNgayLapPhieu.AutoSize = true;
            lblNgayLapPhieu.BackColor = Color.Transparent;
            lblNgayLapPhieu.Dock = DockStyle.Fill;
            lblNgayLapPhieu.Font = new Font("Segoe UI", 12F);
            lblNgayLapPhieu.Location = new Point(3, 0);
            lblNgayLapPhieu.Name = "lblNgayLapPhieu";
            lblNgayLapPhieu.Size = new Size(149, 40);
            lblNgayLapPhieu.TabIndex = 8;
            lblNgayLapPhieu.Text = "Ngày lập phiếu:";
            lblNgayLapPhieu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpNgayLapPhieu
            // 
            dtpNgayLapPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLapPhieu.Location = new Point(158, 3);
            dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            dtpNgayLapPhieu.Size = new Size(350, 34);
            dtpNgayLapPhieu.TabIndex = 13;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Dock = DockStyle.Fill;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(3, 40);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(149, 50);
            lblTongTien.TabIndex = 24;
            lblTongTien.Text = "Tổng tiền:";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.White;
            txtTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(158, 43);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(350, 34);
            txtTongTien.TabIndex = 25;
            // 
            // flpButtons
            // 
            flpButtons.AutoSize = true;
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(btnRefresh);
            flpButtons.Location = new Point(953, 182);
            flpButtons.Margin = new Padding(3, 3, 200, 3);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(604, 50);
            flpButtons.TabIndex = 29;
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
            btnAdd.Margin = new Padding(3, 3, 20, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 44);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.BackColor = Color.FromArgb(255, 152, 0);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(154, 3);
            btnEdit.Margin = new Padding(3, 3, 20, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 44);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(305, 3);
            btnDelete.Margin = new Padding(3, 3, 20, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 44);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.FromArgb(33, 150, 243);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(456, 3);
            btnRefresh.Margin = new Padding(3, 3, 20, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(128, 44);
            btnRefresh.TabIndex = 23;
            btnRefresh.Text = "   Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // GUI_PhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 925);
            Controls.Add(flpPhieuNhap);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GUI_PhieuNhap";
            Text = "Quản Lý Phiếu Nhập";
            Load += GUI_PhieuNhap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            flpPhieuNhap.ResumeLayout(false);
            flpPhieuNhap.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tblThongTinPhieuNhap.ResumeLayout(false);
            tblThongTinPhieuNhap.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }

        private DataGridView dgvPhieuNhap;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private FlowLayoutPanel flpPhieuNhap;
        private TableLayoutPanel tblThongTinPhieuNhap;
        private Label lblNgayLapPhieu;
        private Label lblTongTien;
        private DateTimePicker dtpNgayLapPhieu;
        private TextBox txtTongTien;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblDanhSachPhieuXuat;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel4;
        private Label lblNhapPhieu;
    }
}
