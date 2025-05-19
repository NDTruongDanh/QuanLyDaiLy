namespace GUI_QuanLy
{
    partial class GUI_DaiLy
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenDaiLy;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtTenDaiLy;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dgvDaiLy;

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
            lblTenDaiLy = new Label();
            lblDiaChi = new Label();
            txtTenDaiLy = new TextBox();
            txtDiaChi = new TextBox();
            dgvDaiLy = new DataGridView();
            pnlData = new Panel();
            lblDanhSachDaiLy = new Label();
            label2 = new Label();
            pnlInput = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cboLoaiDaiLy = new ComboBox();
            lblLoaiDaiLy = new Label();
            cboQuan = new ComboBox();
            dtpNgayTiepNhan = new DateTimePicker();
            lblSDT = new Label();
            lblNgayTiepNhan = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblQuan = new Label();
            lblThongTinDaiLy = new Label();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mnItemPhieuXuat = new ToolStripMenuItem();
            mnItemPhieuThu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvDaiLy).BeginInit();
            pnlData.SuspendLayout();
            pnlInput.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTenDaiLy
            // 
            lblTenDaiLy.AutoSize = true;
            lblTenDaiLy.BackColor = Color.Transparent;
            lblTenDaiLy.Dock = DockStyle.Fill;
            lblTenDaiLy.Font = new Font("Segoe UI", 12F);
            lblTenDaiLy.Location = new Point(3, 0);
            lblTenDaiLy.Name = "lblTenDaiLy";
            lblTenDaiLy.Size = new Size(184, 45);
            lblTenDaiLy.TabIndex = 0;
            lblTenDaiLy.Text = "Tên Đại lý:";
            lblTenDaiLy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.BackColor = Color.Transparent;
            lblDiaChi.Dock = DockStyle.Fill;
            lblDiaChi.Font = new Font("Segoe UI", 12F);
            lblDiaChi.Location = new Point(3, 91);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(184, 45);
            lblDiaChi.TabIndex = 3;
            lblDiaChi.Text = "Địa chỉ:";
            lblDiaChi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTenDaiLy
            // 
            txtTenDaiLy.Dock = DockStyle.Fill;
            txtTenDaiLy.Font = new Font("Segoe UI", 12F);
            txtTenDaiLy.Location = new Point(193, 3);
            txtTenDaiLy.Name = "txtTenDaiLy";
            txtTenDaiLy.Size = new Size(1376, 39);
            txtTenDaiLy.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Dock = DockStyle.Fill;
            txtDiaChi.Font = new Font("Segoe UI", 12F);
            txtDiaChi.Location = new Point(193, 94);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(1376, 39);
            txtDiaChi.TabIndex = 8;
            // 
            // dgvDaiLy
            // 
            dgvDaiLy.AllowUserToResizeColumns = false;
            dgvDaiLy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDaiLy.BackgroundColor = Color.White;
            dgvDaiLy.BorderStyle = BorderStyle.None;
            dgvDaiLy.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvDaiLy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDaiLy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDaiLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDaiLy.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDaiLy.EnableHeadersVisualStyles = false;
            dgvDaiLy.GridColor = Color.White;
            dgvDaiLy.Location = new Point(18, 81);
            dgvDaiLy.Name = "dgvDaiLy";
            dgvDaiLy.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDaiLy.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDaiLy.RowHeadersVisible = false;
            dgvDaiLy.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDaiLy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDaiLy.Size = new Size(1569, 318);
            dgvDaiLy.TabIndex = 14;
            dgvDaiLy.SelectionChanged += dgvDaiLy_SelectionChanged;
            dgvDaiLy.MouseDown += dgvDaiLy_MouseDown;
            // 
            // pnlData
            // 
            pnlData.BackColor = Color.White;
            pnlData.Controls.Add(lblDanhSachDaiLy);
            pnlData.Controls.Add(label2);
            pnlData.Controls.Add(dgvDaiLy);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(16, 16);
            pnlData.Margin = new Padding(16, 16, 16, 8);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(15);
            pnlData.Size = new Size(1602, 417);
            pnlData.TabIndex = 21;
            // 
            // lblDanhSachDaiLy
            // 
            lblDanhSachDaiLy.AutoSize = true;
            lblDanhSachDaiLy.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachDaiLy.Location = new Point(15, 15);
            lblDanhSachDaiLy.Name = "lblDanhSachDaiLy";
            lblDanhSachDaiLy.Size = new Size(232, 38);
            lblDanhSachDaiLy.TabIndex = 16;
            lblDanhSachDaiLy.Text = "Danh sách đại lý";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(0, 64);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(3000, 2);
            label2.TabIndex = 15;
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.Controls.Add(flowLayoutPanel1);
            pnlInput.Controls.Add(tableLayoutPanel1);
            pnlInput.Controls.Add(lblThongTinDaiLy);
            pnlInput.Controls.Add(label4);
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Location = new Point(16, 449);
            pnlInput.Margin = new Padding(16, 8, 16, 16);
            pnlInput.Name = "pnlInput";
            pnlInput.Padding = new Padding(15);
            pnlInput.Size = new Size(1602, 460);
            pnlInput.TabIndex = 22;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnEdit);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnFind);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(813, 390);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(774, 52);
            flowLayoutPanel1.TabIndex = 27;
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
            // btnFind
            // 
            btnFind.AutoSize = true;
            btnFind.BackColor = Color.FromArgb(33, 150, 243);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 12F);
            btnFind.Location = new Point(462, 3);
            btnFind.Margin = new Padding(3, 3, 20, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(128, 44);
            btnFind.TabIndex = 23;
            btnFind.Text = "🔍 Tìm ";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(33, 150, 243);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(613, 3);
            button1.Name = "button1";
            button1.Size = new Size(158, 44);
            button1.TabIndex = 24;
            button1.Text = "🔍 Làm mới";
            button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtTenDaiLy, 1, 0);
            tableLayoutPanel1.Controls.Add(cboLoaiDaiLy, 1, 3);
            tableLayoutPanel1.Controls.Add(lblLoaiDaiLy, 0, 3);
            tableLayoutPanel1.Controls.Add(cboQuan, 1, 6);
            tableLayoutPanel1.Controls.Add(txtDiaChi, 1, 5);
            tableLayoutPanel1.Controls.Add(dtpNgayTiepNhan, 1, 9);
            tableLayoutPanel1.Controls.Add(lblSDT, 0, 7);
            tableLayoutPanel1.Controls.Add(lblNgayTiepNhan, 0, 9);
            tableLayoutPanel1.Controls.Add(txtSDT, 1, 7);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 8);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 8);
            tableLayoutPanel1.Controls.Add(lblTenDaiLy, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDiaChi, 0, 5);
            tableLayoutPanel1.Controls.Add(lblQuan, 0, 6);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(15, 79);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1572, 317);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // cboLoaiDaiLy
            // 
            cboLoaiDaiLy.Dock = DockStyle.Fill;
            cboLoaiDaiLy.Font = new Font("Segoe UI", 12F);
            cboLoaiDaiLy.FormattingEnabled = true;
            cboLoaiDaiLy.Location = new Point(193, 48);
            cboLoaiDaiLy.Name = "cboLoaiDaiLy";
            cboLoaiDaiLy.Size = new Size(1376, 40);
            cboLoaiDaiLy.TabIndex = 11;
            // 
            // lblLoaiDaiLy
            // 
            lblLoaiDaiLy.AutoSize = true;
            lblLoaiDaiLy.BackColor = Color.Transparent;
            lblLoaiDaiLy.Dock = DockStyle.Fill;
            lblLoaiDaiLy.Font = new Font("Segoe UI", 12F);
            lblLoaiDaiLy.Location = new Point(3, 45);
            lblLoaiDaiLy.Name = "lblLoaiDaiLy";
            lblLoaiDaiLy.Size = new Size(184, 46);
            lblLoaiDaiLy.TabIndex = 1;
            lblLoaiDaiLy.Text = "Loại Đại lý:";
            lblLoaiDaiLy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboQuan
            // 
            cboQuan.Dock = DockStyle.Fill;
            cboQuan.Font = new Font("Segoe UI", 12F);
            cboQuan.FormattingEnabled = true;
            cboQuan.Location = new Point(193, 139);
            cboQuan.Name = "cboQuan";
            cboQuan.Size = new Size(1376, 40);
            cboQuan.TabIndex = 12;
            // 
            // dtpNgayTiepNhan
            // 
            dtpNgayTiepNhan.Dock = DockStyle.Fill;
            dtpNgayTiepNhan.Font = new Font("Segoe UI", 12F);
            dtpNgayTiepNhan.Location = new Point(193, 275);
            dtpNgayTiepNhan.Name = "dtpNgayTiepNhan";
            dtpNgayTiepNhan.Size = new Size(1376, 39);
            dtpNgayTiepNhan.TabIndex = 13;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.BackColor = Color.Transparent;
            lblSDT.Dock = DockStyle.Fill;
            lblSDT.Font = new Font("Segoe UI", 12F);
            lblSDT.Location = new Point(3, 182);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(184, 45);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "SĐT:";
            lblSDT.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNgayTiepNhan
            // 
            lblNgayTiepNhan.AutoSize = true;
            lblNgayTiepNhan.BackColor = Color.Transparent;
            lblNgayTiepNhan.Dock = DockStyle.Fill;
            lblNgayTiepNhan.Font = new Font("Segoe UI", 12F);
            lblNgayTiepNhan.Location = new Point(3, 272);
            lblNgayTiepNhan.Name = "lblNgayTiepNhan";
            lblNgayTiepNhan.Size = new Size(184, 45);
            lblNgayTiepNhan.TabIndex = 6;
            lblNgayTiepNhan.Text = "Ngày tiếp nhận:";
            lblNgayTiepNhan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Fill;
            txtSDT.Font = new Font("Segoe UI", 12F);
            txtSDT.Location = new Point(193, 185);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(1376, 39);
            txtSDT.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(3, 227);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(184, 45);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(193, 230);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(1376, 39);
            txtEmail.TabIndex = 10;
            // 
            // lblQuan
            // 
            lblQuan.AutoSize = true;
            lblQuan.BackColor = Color.Transparent;
            lblQuan.Dock = DockStyle.Fill;
            lblQuan.Font = new Font("Segoe UI", 12F);
            lblQuan.Location = new Point(3, 136);
            lblQuan.Name = "lblQuan";
            lblQuan.Size = new Size(184, 46);
            lblQuan.TabIndex = 2;
            lblQuan.Text = "Quận:";
            lblQuan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblThongTinDaiLy
            // 
            lblThongTinDaiLy.AutoSize = true;
            lblThongTinDaiLy.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinDaiLy.Location = new Point(18, 15);
            lblThongTinDaiLy.Name = "lblThongTinDaiLy";
            lblThongTinDaiLy.Size = new Size(225, 38);
            lblThongTinDaiLy.TabIndex = 16;
            lblThongTinDaiLy.Text = "Thông tin đại lý";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(0, 64);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(3000, 2);
            label4.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pnlData, 0, 0);
            tableLayoutPanel2.Controls.Add(pnlInput, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 47.6756744F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 52.3243256F));
            tableLayoutPanel2.Size = new Size(1634, 925);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.ImeMode = ImeMode.NoControl;
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mnItemPhieuXuat, mnItemPhieuThu });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(214, 68);
            // 
            // mnItemPhieuXuat
            // 
            mnItemPhieuXuat.Name = "mnItemPhieuXuat";
            mnItemPhieuXuat.Size = new Size(213, 32);
            mnItemPhieuXuat.Text = "Phiếu Xuất hàng";
            mnItemPhieuXuat.Click += mnPhieuXuatHang_Click;
            // 
            // mnItemPhieuThu
            // 
            mnItemPhieuThu.Name = "mnItemPhieuThu";
            mnItemPhieuThu.Size = new Size(213, 32);
            mnItemPhieuThu.Text = "Phiếu Thu tiền";
            mnItemPhieuThu.Click += mnPhieuThu_Click;
            // 
            // GUI_DaiLy
            // 
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1634, 925);
            Controls.Add(tableLayoutPanel2);
            Name = "GUI_DaiLy";
            Text = "Quản lý Đại lý";
            Load += GUI_DaiLy_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDaiLy).EndInit();
            pnlData.ResumeLayout(false);
            pnlData.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlData;
        private Label label2;
        private Label lblDanhSachDaiLy;
        private Panel pnlInput;
        private Label lblThongTinDaiLy;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cboLoaiDaiLy;
        private Label lblLoaiDaiLy;
        private Label lblQuan;
        private DateTimePicker dtpNgayTiepNhan;
        private Label lblSDT;
        private Label lblNgayTiepNhan;
        private TextBox txtSDT;
        private Label lblEmail;
        private TextBox txtEmail;
        private TableLayoutPanel tableLayoutPanel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnItemPhieuXuat;
        private ToolStripMenuItem mnItemPhieuThu;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnFind;
        private ComboBox cboQuan;
        private Button button1;
    }
}
