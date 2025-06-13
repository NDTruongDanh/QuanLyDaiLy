namespace GUI_QuanLy
{
    partial class GUI_MatHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenDaiLy;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.DataGridView dgvMatHang;

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
            txtTenMatHang = new TextBox();
            dgvMatHang = new DataGridView();
            pnlData = new Panel();
            lblDanhSachDaiLy = new Label();
            label2 = new Label();
            pnlInput = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            btnRefresh = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cmbDonViTinh = new ComboBox();
            label1 = new Label();
            lblThongTinDaiLy = new Label();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mnItemPhieuXuat = new ToolStripMenuItem();
            mnItemPhieuThu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvMatHang).BeginInit();
            pnlData.SuspendLayout();
            pnlInput.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
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
            lblTenDaiLy.Size = new Size(183, 45);
            lblTenDaiLy.TabIndex = 0;
            lblTenDaiLy.Text = "Tên Mặt hàng:";
            lblTenDaiLy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTenMatHang
            // 
            txtTenMatHang.Dock = DockStyle.Fill;
            txtTenMatHang.Font = new Font("Segoe UI", 12F);
            txtTenMatHang.Location = new Point(192, 3);
            txtTenMatHang.Name = "txtTenMatHang";
            txtTenMatHang.Size = new Size(1374, 39);
            txtTenMatHang.TabIndex = 7;
            // 
            // dgvMatHang
            // 
            dgvMatHang.AllowUserToResizeColumns = false;
            dgvMatHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMatHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatHang.BackgroundColor = Color.White;
            dgvMatHang.BorderStyle = BorderStyle.None;
            dgvMatHang.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvMatHang.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMatHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMatHang.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMatHang.EnableHeadersVisualStyles = false;
            dgvMatHang.GridColor = Color.White;
            dgvMatHang.Location = new Point(12, 69);
            dgvMatHang.Name = "dgvMatHang";
            dgvMatHang.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMatHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMatHang.RowHeadersVisible = false;
            dgvMatHang.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatHang.Size = new Size(1569, 492);
            dgvMatHang.TabIndex = 14;
            dgvMatHang.SelectionChanged += dgvMatHang_SelectionChanged;
            // 
            // pnlData
            // 
            pnlData.BackColor = Color.White;
            pnlData.Controls.Add(lblDanhSachDaiLy);
            pnlData.Controls.Add(label2);
            pnlData.Controls.Add(dgvMatHang);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(16, 16);
            pnlData.Margin = new Padding(16, 16, 16, 8);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(15);
            pnlData.Size = new Size(1602, 592);
            pnlData.TabIndex = 21;
            // 
            // lblDanhSachDaiLy
            // 
            lblDanhSachDaiLy.AutoSize = true;
            lblDanhSachDaiLy.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachDaiLy.Location = new Point(15, 15);
            lblDanhSachDaiLy.Name = "lblDanhSachDaiLy";
            lblDanhSachDaiLy.Size = new Size(287, 38);
            lblDanhSachDaiLy.TabIndex = 16;
            lblDanhSachDaiLy.Text = "Danh sách Mặt hàng";
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
            pnlInput.Controls.Add(flowLayoutPanel2);
            pnlInput.Controls.Add(tableLayoutPanel1);
            pnlInput.Controls.Add(lblThongTinDaiLy);
            pnlInput.Controls.Add(label4);
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Location = new Point(16, 624);
            pnlInput.Margin = new Padding(16, 8, 16, 16);
            pnlInput.Name = "pnlInput";
            pnlInput.Padding = new Padding(15);
            pnlInput.Size = new Size(1602, 285);
            pnlInput.TabIndex = 22;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(btnAdd);
            flowLayoutPanel2.Controls.Add(btnUpdate);
            flowLayoutPanel2.Controls.Add(btnDelete);
            flowLayoutPanel2.Controls.Add(btnFind);
            flowLayoutPanel2.Controls.Add(btnRefresh);
            flowLayoutPanel2.Location = new Point(810, 215);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(774, 52);
            flowLayoutPanel2.TabIndex = 30;
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
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.FromArgb(255, 152, 0);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(160, 3);
            btnUpdate.Margin = new Padding(3, 3, 20, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 44);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "✏️ Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnEdit_Click;
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
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.FromArgb(33, 150, 243);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Location = new Point(613, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(158, 44);
            btnRefresh.TabIndex = 24;
            btnRefresh.Text = "🔍 Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cmbDonViTinh, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(txtTenMatHang, 1, 0);
            tableLayoutPanel1.Controls.Add(lblTenDaiLy, 0, 0);
            tableLayoutPanel1.Location = new Point(18, 79);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1569, 92);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // cmbDonViTinh
            // 
            cmbDonViTinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbDonViTinh.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbDonViTinh.Dock = DockStyle.Fill;
            cmbDonViTinh.Font = new Font("Segoe UI", 12F);
            cmbDonViTinh.FormattingEnabled = true;
            cmbDonViTinh.Location = new Point(192, 48);
            cmbDonViTinh.Name = "cmbDonViTinh";
            cmbDonViTinh.Size = new Size(1374, 40);
            cmbDonViTinh.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 45);
            label1.Name = "label1";
            label1.Size = new Size(183, 47);
            label1.TabIndex = 8;
            label1.Text = "Tên Đơn vị tính:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblThongTinDaiLy
            // 
            lblThongTinDaiLy.AutoSize = true;
            lblThongTinDaiLy.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinDaiLy.Location = new Point(18, 15);
            lblThongTinDaiLy.Name = "lblThongTinDaiLy";
            lblThongTinDaiLy.Size = new Size(279, 38);
            lblThongTinDaiLy.TabIndex = 16;
            lblThongTinDaiLy.Text = "Nhập liệu Mặt hàng";
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 66.5946F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.405407F));
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
            // 
            // mnItemPhieuThu
            // 
            mnItemPhieuThu.Name = "mnItemPhieuThu";
            mnItemPhieuThu.Size = new Size(213, 32);
            mnItemPhieuThu.Text = "Phiếu Thu tiền";
            // 
            // GUI_MatHang
            // 
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1634, 925);
            Controls.Add(tableLayoutPanel2);
            Name = "GUI_MatHang";
            Text = "Quản lý Mặt hàng";
            Load += GUI_MatHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMatHang).EndInit();
            pnlData.ResumeLayout(false);
            pnlData.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnItemPhieuXuat;
        private ToolStripMenuItem mnItemPhieuThu;
        private Label label1;
        private ComboBox cmbDonViTinh;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnFind;
        private Button btnRefresh;
    }
}
