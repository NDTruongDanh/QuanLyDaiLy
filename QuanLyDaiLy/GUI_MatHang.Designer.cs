namespace GUI_QuanLy
{
    partial class GUI_MatHang
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_MatHang));
            contextMenuStrip1 = new ContextMenuStrip(components);
            mnItemPhieuXuat = new ToolStripMenuItem();
            mnItemPhieuThu = new ToolStripMenuItem();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblDsMatHang = new Label();
            dgvMatHang = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            flpNhap = new FlowLayoutPanel();
            lblNhapLieu = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            cboDVT = new ComboBox();
            lblDVT = new Label();
            txtMatHang = new TextBox();
            lblTenMatHang = new Label();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            contextMenuStrip1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatHang).BeginInit();
            flpNhap.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.ImeMode = ImeMode.NoControl;
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mnItemPhieuXuat, mnItemPhieuThu });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 52);
            // 
            // mnItemPhieuXuat
            // 
            mnItemPhieuXuat.Name = "mnItemPhieuXuat";
            mnItemPhieuXuat.Size = new Size(185, 24);
            mnItemPhieuXuat.Text = "Phiếu Xuất hàng";
            // 
            // mnItemPhieuThu
            // 
            mnItemPhieuThu.Name = "mnItemPhieuThu";
            mnItemPhieuThu.Size = new Size(185, 24);
            mnItemPhieuThu.Text = "Phiếu Thu tiền";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel2.Controls.Add(flpNhap, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1634, 925);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(lblDsMatHang);
            flowLayoutPanel2.Controls.Add(dgvMatHang);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1628, 585);
            flowLayoutPanel2.TabIndex = 17;
            // 
            // lblDsMatHang
            // 
            lblDsMatHang.AutoSize = true;
            lblDsMatHang.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDsMatHang.Location = new Point(3, 0);
            lblDsMatHang.Name = "lblDsMatHang";
            lblDsMatHang.Size = new Size(247, 32);
            lblDsMatHang.TabIndex = 16;
            lblDsMatHang.Text = "Danh sách Mặt hàng";
            // 
            // dgvMatHang
            // 
            dgvMatHang.AllowUserToResizeColumns = false;
            dgvMatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatHang.BackgroundColor = Color.White;
            dgvMatHang.BorderStyle = BorderStyle.None;
            dgvMatHang.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvMatHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvMatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvMatHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatHang.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvMatHang.DefaultCellStyle = dataGridViewCellStyle5;
            dgvMatHang.EnableHeadersVisualStyles = false;
            dgvMatHang.GridColor = Color.White;
            dgvMatHang.Location = new Point(5, 37);
            dgvMatHang.Margin = new Padding(5);
            dgvMatHang.Name = "dgvMatHang";
            dgvMatHang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvMatHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvMatHang.RowHeadersVisible = false;
            dgvMatHang.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatHang.Size = new Size(1616, 531);
            dgvMatHang.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Mặt Hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên Đơn Vị Tính";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn giá hiện tại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Tồn kho";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // flpNhap
            // 
            flpNhap.AutoSize = true;
            flpNhap.BackColor = Color.White;
            flpNhap.Controls.Add(lblNhapLieu);
            flpNhap.Controls.Add(tableLayoutPanel1);
            flpNhap.Controls.Add(flpButtons);
            flpNhap.Dock = DockStyle.Fill;
            flpNhap.Location = new Point(5, 596);
            flpNhap.Margin = new Padding(5);
            flpNhap.Name = "flpNhap";
            flpNhap.Size = new Size(1624, 324);
            flpNhap.TabIndex = 17;
            // 
            // lblNhapLieu
            // 
            lblNhapLieu.AutoSize = true;
            lblNhapLieu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapLieu.Location = new Point(3, 0);
            lblNhapLieu.Name = "lblNhapLieu";
            lblNhapLieu.Size = new Size(240, 32);
            lblNhapLieu.TabIndex = 16;
            lblNhapLieu.Text = "Nhập liệu Mặt hàng";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(cboDVT, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDVT, 0, 1);
            tableLayoutPanel1.Controls.Add(txtMatHang, 1, 0);
            tableLayoutPanel1.Controls.Add(lblTenMatHang, 0, 0);
            tableLayoutPanel1.Location = new Point(50, 82);
            tableLayoutPanel1.Margin = new Padding(50, 50, 5, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1569, 87);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // cboDVT
            // 
            cboDVT.Font = new Font("Segoe UI", 12F);
            cboDVT.FormattingEnabled = true;
            cboDVT.Location = new Point(155, 43);
            cboDVT.Name = "cboDVT";
            cboDVT.Size = new Size(400, 36);
            cboDVT.TabIndex = 13;
            // 
            // lblDVT
            // 
            lblDVT.AutoSize = true;
            lblDVT.BackColor = Color.Transparent;
            lblDVT.Dock = DockStyle.Fill;
            lblDVT.Font = new Font("Segoe UI", 12F);
            lblDVT.Location = new Point(3, 40);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new Size(146, 47);
            lblDVT.TabIndex = 8;
            lblDVT.Text = "Tên Đơn vị tính:";
            lblDVT.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMatHang
            // 
            txtMatHang.Font = new Font("Segoe UI", 12F);
            txtMatHang.Location = new Point(155, 3);
            txtMatHang.Name = "txtMatHang";
            txtMatHang.Size = new Size(400, 34);
            txtMatHang.TabIndex = 7;
            // 
            // lblTenMatHang
            // 
            lblTenMatHang.AutoSize = true;
            lblTenMatHang.BackColor = Color.Transparent;
            lblTenMatHang.Dock = DockStyle.Fill;
            lblTenMatHang.Font = new Font("Segoe UI", 12F);
            lblTenMatHang.Location = new Point(3, 0);
            lblTenMatHang.Name = "lblTenMatHang";
            lblTenMatHang.Size = new Size(146, 40);
            lblTenMatHang.TabIndex = 0;
            lblTenMatHang.Text = "Tên Mặt hàng:";
            lblTenMatHang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpButtons
            // 
            flpButtons.AutoSize = true;
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(btnRefresh);
            flpButtons.Dock = DockStyle.Top;
            flpButtons.Location = new Point(900, 224);
            flpButtons.Margin = new Padding(900, 5, 5, 50);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(604, 50);
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
            btnAdd.Margin = new Padding(3, 3, 20, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 44);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
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
            // GUI_MatHang
            // 
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1634, 925);
            Controls.Add(tableLayoutPanel2);
            Name = "GUI_MatHang";
            Text = "Quản lý Mặt hàng";
            contextMenuStrip1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatHang).EndInit();
            flpNhap.ResumeLayout(false);
            flpNhap.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnItemPhieuXuat;
        private ToolStripMenuItem mnItemPhieuThu;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnlData;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblDanhSachDaiLy;
        private Label label2;
        private DataGridView dgvMatHang;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Panel pnlInput;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox cboDVT;
        private Label lblDVT;
        private TextBox txtMatHang;
        private Label lblTenMatHang;
        private Label lblNhapLieu;
        private FlowLayoutPanel flpNhap;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Panel panel3;
        private Button btnEdit;
        private Panel panel4;
        private Button btnDelete;
        private Panel panel5;
        private Button btnRefresh;
        private Label lblDsMatHang;
    }
}
