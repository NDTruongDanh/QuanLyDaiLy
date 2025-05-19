namespace GUI_QuanLy
{
    partial class GUI_LoaiDaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_LoaiDaiLy));
            tlbFormQuan = new TableLayoutPanel();
            flpDanhSachQuan = new FlowLayoutPanel();
            lblDsLoaiDL = new Label();
            dgvLoaiDL = new DataGridView();
            dgvtxtLoaiDL = new DataGridViewTextBoxColumn();
            dgvtxtTienNoTD = new DataGridViewTextBoxColumn();
            flpControls = new FlowLayoutPanel();
            lblNhapLoaiDL = new Label();
            flpNhapLoaiDL = new FlowLayoutPanel();
            lblTenLoaiDL = new Label();
            txtTenLoaiDL = new TextBox();
            flpTienNo = new FlowLayoutPanel();
            lblTienNoTD = new Label();
            txtTienNoTD = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            tlbFormQuan.SuspendLayout();
            flpDanhSachQuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDL).BeginInit();
            flpControls.SuspendLayout();
            flpNhapLoaiDL.SuspendLayout();
            flpTienNo.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlbFormQuan
            // 
            tlbFormQuan.ColumnCount = 1;
            tlbFormQuan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlbFormQuan.Controls.Add(flpDanhSachQuan, 0, 0);
            tlbFormQuan.Controls.Add(flpControls, 0, 1);
            tlbFormQuan.Dock = DockStyle.Fill;
            tlbFormQuan.Location = new Point(0, 0);
            tlbFormQuan.Name = "tlbFormQuan";
            tlbFormQuan.RowCount = 2;
            tlbFormQuan.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlbFormQuan.RowStyles.Add(new RowStyle());
            tlbFormQuan.Size = new Size(1634, 940);
            tlbFormQuan.TabIndex = 27;
            // 
            // flpDanhSachQuan
            // 
            flpDanhSachQuan.AutoSize = true;
            flpDanhSachQuan.BackColor = SystemColors.Control;
            flpDanhSachQuan.Controls.Add(lblDsLoaiDL);
            flpDanhSachQuan.Controls.Add(dgvLoaiDL);
            flpDanhSachQuan.Dock = DockStyle.Fill;
            flpDanhSachQuan.FlowDirection = FlowDirection.TopDown;
            flpDanhSachQuan.Location = new Point(3, 3);
            flpDanhSachQuan.Name = "flpDanhSachQuan";
            flpDanhSachQuan.Size = new Size(1628, 699);
            flpDanhSachQuan.TabIndex = 26;
            // 
            // lblDsLoaiDL
            // 
            lblDsLoaiDL.AutoSize = true;
            lblDsLoaiDL.BackColor = SystemColors.Control;
            lblDsLoaiDL.Dock = DockStyle.Top;
            lblDsLoaiDL.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDsLoaiDL.Location = new Point(5, 5);
            lblDsLoaiDL.Margin = new Padding(5);
            lblDsLoaiDL.Name = "lblDsLoaiDL";
            lblDsLoaiDL.Size = new Size(1617, 38);
            lblDsLoaiDL.TabIndex = 16;
            lblDsLoaiDL.Text = "Danh sách loại đại lý";
            // 
            // dgvLoaiDL
            // 
            dgvLoaiDL.AllowUserToResizeColumns = false;
            dgvLoaiDL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiDL.BackgroundColor = Color.White;
            dgvLoaiDL.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvLoaiDL.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLoaiDL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoaiDL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiDL.Columns.AddRange(new DataGridViewColumn[] { dgvtxtLoaiDL, dgvtxtTienNoTD });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLoaiDL.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLoaiDL.EnableHeadersVisualStyles = false;
            dgvLoaiDL.GridColor = Color.White;
            dgvLoaiDL.Location = new Point(10, 53);
            dgvLoaiDL.Margin = new Padding(10, 5, 5, 5);
            dgvLoaiDL.Name = "dgvLoaiDL";
            dgvLoaiDL.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLoaiDL.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLoaiDL.RowHeadersVisible = false;
            dgvLoaiDL.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvLoaiDL.ScrollBars = ScrollBars.Vertical;
            dgvLoaiDL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiDL.Size = new Size(1612, 605);
            dgvLoaiDL.TabIndex = 14;
            // 
            // dgvtxtLoaiDL
            // 
            dgvtxtLoaiDL.HeaderText = "Loại Đại Lý";
            dgvtxtLoaiDL.MinimumWidth = 6;
            dgvtxtLoaiDL.Name = "dgvtxtLoaiDL";
            // 
            // dgvtxtTienNoTD
            // 
            dgvtxtTienNoTD.HeaderText = "Tiền Nợ Tối Đa";
            dgvtxtTienNoTD.MinimumWidth = 6;
            dgvtxtTienNoTD.Name = "dgvtxtTienNoTD";
            // 
            // flpControls
            // 
            flpControls.AutoSize = true;
            flpControls.BackColor = Color.White;
            flpControls.Controls.Add(lblNhapLoaiDL);
            flpControls.Controls.Add(flpNhapLoaiDL);
            flpControls.Controls.Add(flpTienNo);
            flpControls.Controls.Add(flpButtons);
            flpControls.Dock = DockStyle.Top;
            flpControls.FlowDirection = FlowDirection.TopDown;
            flpControls.Location = new Point(3, 708);
            flpControls.Name = "flpControls";
            flpControls.Size = new Size(1628, 229);
            flpControls.TabIndex = 27;
            // 
            // lblNhapLoaiDL
            // 
            lblNhapLoaiDL.AutoSize = true;
            lblNhapLoaiDL.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapLoaiDL.Location = new Point(5, 5);
            lblNhapLoaiDL.Margin = new Padding(5);
            lblNhapLoaiDL.Name = "lblNhapLoaiDL";
            lblNhapLoaiDL.Size = new Size(224, 38);
            lblNhapLoaiDL.TabIndex = 16;
            lblNhapLoaiDL.Text = "Nhập loại đại lý";
            // 
            // flpNhapLoaiDL
            // 
            flpNhapLoaiDL.AutoSize = true;
            flpNhapLoaiDL.Controls.Add(lblTenLoaiDL);
            flpNhapLoaiDL.Controls.Add(txtTenLoaiDL);
            flpNhapLoaiDL.Location = new Point(100, 53);
            flpNhapLoaiDL.Margin = new Padding(100, 5, 5, 5);
            flpNhapLoaiDL.Name = "flpNhapLoaiDL";
            flpNhapLoaiDL.Size = new Size(656, 28);
            flpNhapLoaiDL.TabIndex = 27;
            // 
            // lblTenLoaiDL
            // 
            lblTenLoaiDL.AutoSize = true;
            lblTenLoaiDL.BackColor = Color.Transparent;
            lblTenLoaiDL.Dock = DockStyle.Fill;
            lblTenLoaiDL.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenLoaiDL.Location = new Point(3, 0);
            lblTenLoaiDL.Margin = new Padding(3, 0, 6, 0);
            lblTenLoaiDL.Name = "lblTenLoaiDL";
            lblTenLoaiDL.Size = new Size(141, 28);
            lblTenLoaiDL.TabIndex = 0;
            lblTenLoaiDL.Text = "Tên loại đại lý:";
            // 
            // txtTenLoaiDL
            // 
            txtTenLoaiDL.Dock = DockStyle.Fill;
            txtTenLoaiDL.Font = new Font("Segoe UI", 12F);
            txtTenLoaiDL.Location = new Point(153, 3);
            txtTenLoaiDL.Name = "txtTenLoaiDL";
            txtTenLoaiDL.Size = new Size(500, 34);
            txtTenLoaiDL.TabIndex = 7;
            // 
            // flpTienNo
            // 
            flpTienNo.AutoSize = true;
            flpTienNo.Controls.Add(lblTienNoTD);
            flpTienNo.Controls.Add(txtTienNoTD);
            flpTienNo.Location = new Point(100, 91);
            flpTienNo.Margin = new Padding(100, 5, 5, 5);
            flpTienNo.Name = "flpTienNo";
            flpTienNo.Size = new Size(656, 28);
            flpTienNo.TabIndex = 31;
            // 
            // lblTienNoTD
            // 
            lblTienNoTD.AutoSize = true;
            lblTienNoTD.BackColor = Color.Transparent;
            lblTienNoTD.Dock = DockStyle.Fill;
            lblTienNoTD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTienNoTD.Location = new Point(3, 0);
            lblTienNoTD.Name = "lblTienNoTD";
            lblTienNoTD.Size = new Size(144, 28);
            lblTienNoTD.TabIndex = 0;
            lblTienNoTD.Text = "Tiền nợ tối đa:";
            // 
            // txtTienNoTD
            // 
            txtTienNoTD.Dock = DockStyle.Fill;
            txtTienNoTD.Font = new Font("Segoe UI", 12F);
            txtTienNoTD.Location = new Point(153, 3);
            txtTienNoTD.Name = "txtTienNoTD";
            txtTienNoTD.Size = new Size(500, 34);
            txtTienNoTD.TabIndex = 7;
            // 
            // flpButtons
            // 
            flpButtons.AutoSize = true;
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(btnRefresh);
            flpButtons.Dock = DockStyle.Top;
            flpButtons.Location = new Point(900, 129);
            flpButtons.Margin = new Padding(900, 5, 5, 50);
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
            // GUI_LoaiDaiLy
            // 
            ClientSize = new Size(1634, 940);
            Controls.Add(tlbFormQuan);
            Name = "GUI_LoaiDaiLy";
            Text = "Quản Lý Loại Đại Lý";
            tlbFormQuan.ResumeLayout(false);
            tlbFormQuan.PerformLayout();
            flpDanhSachQuan.ResumeLayout(false);
            flpDanhSachQuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDL).EndInit();
            flpControls.ResumeLayout(false);
            flpControls.PerformLayout();
            flpNhapLoaiDL.ResumeLayout(false);
            flpNhapLoaiDL.PerformLayout();
            flpTienNo.ResumeLayout(false);
            flpTienNo.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }
        private TableLayoutPanel tlbFormQuan;
        private FlowLayoutPanel flpDanhSachQuan;
        private Label lblDsLoaiDL;
        private DataGridView dgvLoaiDL;
        private DataGridViewTextBoxColumn dgvtxtLoaiDL;
        private DataGridViewTextBoxColumn dgvtxtTienNoTD;
        private FlowLayoutPanel flpControls;
        private Label lblNhapLoaiDL;
        private FlowLayoutPanel flpNhapLoaiDL;
        private Label lblTenLoaiDL;
        private TextBox txtTenLoaiDL;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Panel panel1;
        private Button btnEdit;
        private Panel panel2;
        private Button btnDelete;
        private Panel panel3;
        private Button btnRefresh;
        private FlowLayoutPanel flpTienNo;
        private Label lblTienNoTD;
        private TextBox txtTienNoTD;
    }
}
