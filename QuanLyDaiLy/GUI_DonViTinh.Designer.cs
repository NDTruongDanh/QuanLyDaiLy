namespace GUI_QuanLy
{
    partial class GUI_DonViTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DonViTinh));
            lblDsDVT = new Label();
            dgvDVT = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            tblNhapDVT = new TableLayoutPanel();
            txtDonViTinh = new TextBox();
            lblTenDVT = new Label();
            lblNhapDVT = new Label();
            tblFormDVT = new TableLayoutPanel();
            flpDanhSachDVT = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDVT).BeginInit();
            tblNhapDVT.SuspendLayout();
            tblFormDVT.SuspendLayout();
            flpDanhSachDVT.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblDsDVT
            // 
            lblDsDVT.AutoSize = true;
            lblDsDVT.Dock = DockStyle.Top;
            lblDsDVT.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDsDVT.Location = new Point(5, 5);
            lblDsDVT.Margin = new Padding(5);
            lblDsDVT.Name = "lblDsDVT";
            lblDsDVT.Size = new Size(1612, 32);
            lblDsDVT.TabIndex = 16;
            lblDsDVT.Text = "Danh sách Đơn Vị Tính";
            // 
            // dgvDVT
            // 
            dgvDVT.AllowUserToResizeColumns = false;
            dgvDVT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDVT.BackgroundColor = Color.White;
            dgvDVT.BorderStyle = BorderStyle.None;
            dgvDVT.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvDVT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDVT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDVT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDVT.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDVT.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDVT.EnableHeadersVisualStyles = false;
            dgvDVT.GridColor = Color.White;
            dgvDVT.Location = new Point(5, 47);
            dgvDVT.Margin = new Padding(5);
            dgvDVT.Name = "dgvDVT";
            dgvDVT.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDVT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDVT.RowHeadersVisible = false;
            dgvDVT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDVT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDVT.Size = new Size(1612, 579);
            dgvDVT.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Đơn Vị Tính";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // tblNhapDVT
            // 
            tblNhapDVT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblNhapDVT.AutoSize = true;
            tblNhapDVT.ColumnCount = 2;
            tblNhapDVT.ColumnStyles.Add(new ColumnStyle());
            tblNhapDVT.ColumnStyles.Add(new ColumnStyle());
            tblNhapDVT.Controls.Add(txtDonViTinh, 1, 0);
            tblNhapDVT.Controls.Add(lblTenDVT, 0, 0);
            tblNhapDVT.Location = new Point(50, 82);
            tblNhapDVT.Margin = new Padding(50, 50, 5, 50);
            tblNhapDVT.Name = "tblNhapDVT";
            tblNhapDVT.RowCount = 1;
            tblNhapDVT.RowStyles.Add(new RowStyle());
            tblNhapDVT.Size = new Size(1454, 40);
            tblNhapDVT.TabIndex = 19;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Segoe UI", 12F);
            txtDonViTinh.Location = new Point(155, 3);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(500, 34);
            txtDonViTinh.TabIndex = 7;
            // 
            // lblTenDVT
            // 
            lblTenDVT.AutoSize = true;
            lblTenDVT.BackColor = Color.Transparent;
            lblTenDVT.Dock = DockStyle.Fill;
            lblTenDVT.Font = new Font("Segoe UI", 12F);
            lblTenDVT.Location = new Point(3, 0);
            lblTenDVT.Name = "lblTenDVT";
            lblTenDVT.Size = new Size(146, 40);
            lblTenDVT.TabIndex = 0;
            lblTenDVT.Text = "Tên Đơn vị tính:";
            // 
            // lblNhapDVT
            // 
            lblNhapDVT.AutoSize = true;
            lblNhapDVT.Dock = DockStyle.Top;
            lblNhapDVT.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapDVT.Location = new Point(3, 0);
            lblNhapDVT.Name = "lblNhapDVT";
            lblNhapDVT.Size = new Size(1503, 32);
            lblNhapDVT.TabIndex = 16;
            lblNhapDVT.Text = "Nhập liệu Đơn vị tính";
            // 
            // tblFormDVT
            // 
            tblFormDVT.ColumnCount = 1;
            tblFormDVT.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFormDVT.Controls.Add(flpDanhSachDVT, 0, 0);
            tblFormDVT.Controls.Add(flowLayoutPanel1, 0, 1);
            tblFormDVT.Dock = DockStyle.Fill;
            tblFormDVT.Location = new Point(0, 0);
            tblFormDVT.Name = "tblFormDVT";
            tblFormDVT.RowCount = 2;
            tblFormDVT.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblFormDVT.RowStyles.Add(new RowStyle());
            tblFormDVT.Size = new Size(1634, 940);
            tblFormDVT.TabIndex = 26;
            // 
            // flpDanhSachDVT
            // 
            flpDanhSachDVT.Controls.Add(lblDsDVT);
            flpDanhSachDVT.Controls.Add(dgvDVT);
            flpDanhSachDVT.Dock = DockStyle.Fill;
            flpDanhSachDVT.FlowDirection = FlowDirection.TopDown;
            flpDanhSachDVT.Location = new Point(3, 3);
            flpDanhSachDVT.Name = "flpDanhSachDVT";
            flpDanhSachDVT.Size = new Size(1628, 644);
            flpDanhSachDVT.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(lblNhapDVT);
            flowLayoutPanel1.Controls.Add(tblNhapDVT);
            flowLayoutPanel1.Controls.Add(flpButtons);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 653);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1628, 284);
            flowLayoutPanel1.TabIndex = 31;
            // 
            // flpButtons
            // 
            flpButtons.AutoSize = true;
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(btnRefresh);
            flpButtons.Location = new Point(900, 177);
            flpButtons.Margin = new Padding(900, 5, 5, 5);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(604, 50);
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
            // GUI_DonViTinh
            // 
            ClientSize = new Size(1634, 940);
            Controls.Add(tblFormDVT);
            Name = "GUI_DonViTinh";
            Text = "Quản Lý Đơn Vị Tính";
            ((System.ComponentModel.ISupportInitialize)dgvDVT).EndInit();
            tblNhapDVT.ResumeLayout(false);
            tblNhapDVT.PerformLayout();
            tblFormDVT.ResumeLayout(false);
            flpDanhSachDVT.ResumeLayout(false);
            flpDanhSachDVT.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label lblDsDVT;
        private Label label2;
        private DataGridView dgvDVT;
        private Panel panel2;
        private TableLayoutPanel tblNhapDVT;
        private Label lblTenDVT;
        private Label lblThongTinPhieuThu;
        private Label lblNhapDVT;
        private TableLayoutPanel tblFormDVT;
        private TextBox txtDonViTinh;
        private DataGridViewTextBoxColumn Column1;
        private FlowLayoutPanel flpDanhSachDVT;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
