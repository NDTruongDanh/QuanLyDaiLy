namespace GUI_QuanLy
{
    partial class GUI_Quan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Quan));
            this.lblDsQuan = new Label();
            dgvQuan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            tlbFormQuan = new TableLayoutPanel();
            flpDanhSachQuan = new FlowLayoutPanel();
            lblNhapQuan = new Label();
            lblTenQuan = new Label();
            txtTenQuan = new TextBox();
            flpControls = new FlowLayoutPanel();
            flpNhapQuan = new FlowLayoutPanel();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            panel1 = new Panel();
            btnEdit = new Button();
            panel2 = new Panel();
            btnDelete = new Button();
            panel3 = new Panel();
            btnFind = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQuan).BeginInit();
            tlbFormQuan.SuspendLayout();
            flpDanhSachQuan.SuspendLayout();
            flpControls.SuspendLayout();
            flpNhapQuan.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblDsQuan
            // 
            this.lblDsQuan.AutoSize = true;
            this.lblDsQuan.BackColor = SystemColors.Control;
            this.lblDsQuan.Dock = DockStyle.Top;
            this.lblDsQuan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblDsQuan.Location = new Point(5, 5);
            this.lblDsQuan.Margin = new Padding(5);
            this.lblDsQuan.Name = "lblDsQuan";
            this.lblDsQuan.Size = new Size(1617, 38);
            this.lblDsQuan.TabIndex = 16;
            this.lblDsQuan.Text = "Danh sách Quận";
            // 
            // dgvQuan
            // 
            dgvQuan.AllowUserToResizeColumns = false;
            dgvQuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuan.BackgroundColor = Color.White;
            dgvQuan.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvQuan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQuan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQuan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuan.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQuan.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQuan.EnableHeadersVisualStyles = false;
            dgvQuan.GridColor = Color.White;
            dgvQuan.Location = new Point(10, 53);
            dgvQuan.Margin = new Padding(10, 5, 5, 5);
            dgvQuan.Name = "dgvQuan";
            dgvQuan.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvQuan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvQuan.RowHeadersVisible = false;
            dgvQuan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvQuan.ScrollBars = ScrollBars.Vertical;
            dgvQuan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuan.Size = new Size(1612, 605);
            dgvQuan.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Quận";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
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
            tlbFormQuan.TabIndex = 26;
            // 
            // flpDanhSachQuan
            // 
            flpDanhSachQuan.AutoSize = true;
            flpDanhSachQuan.BackColor = SystemColors.Control;
            flpDanhSachQuan.Controls.Add(this.lblDsQuan);
            flpDanhSachQuan.Controls.Add(dgvQuan);
            flpDanhSachQuan.Dock = DockStyle.Fill;
            flpDanhSachQuan.FlowDirection = FlowDirection.TopDown;
            flpDanhSachQuan.Location = new Point(3, 3);
            flpDanhSachQuan.Name = "flpDanhSachQuan";
            flpDanhSachQuan.Size = new Size(1628, 677);
            flpDanhSachQuan.TabIndex = 26;
            // 
            // lblNhapQuan
            // 
            lblNhapQuan.AutoSize = true;
            lblNhapQuan.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhapQuan.Location = new Point(5, 5);
            lblNhapQuan.Margin = new Padding(5);
            lblNhapQuan.Name = "lblNhapQuan";
            lblNhapQuan.Size = new Size(222, 38);
            lblNhapQuan.TabIndex = 16;
            lblNhapQuan.Text = "Nhập liệu Quận";
            // 
            // lblTenQuan
            // 
            lblTenQuan.AutoSize = true;
            lblTenQuan.BackColor = Color.Transparent;
            lblTenQuan.Dock = DockStyle.Fill;
            lblTenQuan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenQuan.Location = new Point(3, 0);
            lblTenQuan.Name = "lblTenQuan";
            lblTenQuan.Size = new Size(104, 28);
            lblTenQuan.TabIndex = 0;
            lblTenQuan.Text = "Tên Quận:";
            // 
            // txtTenQuan
            // 
            txtTenQuan.Dock = DockStyle.Fill;
            txtTenQuan.Font = new Font("Segoe UI", 12F);
            txtTenQuan.Location = new Point(113, 3);
            txtTenQuan.Name = "txtTenQuan";
            txtTenQuan.Size = new Size(500, 34);
            txtTenQuan.TabIndex = 7;
            // 
            // flpControls
            // 
            flpControls.AutoSize = true;
            flpControls.Controls.Add(lblNhapQuan);
            flpControls.Controls.Add(flpNhapQuan);
            flpControls.Controls.Add(flpButtons);
            flpControls.Dock = DockStyle.Top;
            flpControls.FlowDirection = FlowDirection.TopDown;
            flpControls.Location = new Point(3, 686);
            flpControls.Name = "flpControls";
            flpControls.Size = new Size(1628, 251);
            flpControls.TabIndex = 27;
            // 
            // flpNhapQuan
            // 
            flpNhapQuan.AutoSize = true;
            flpNhapQuan.Controls.Add(lblTenQuan);
            flpNhapQuan.Controls.Add(txtTenQuan);
            flpNhapQuan.Location = new Point(5, 68);
            flpNhapQuan.Margin = new Padding(5, 20, 5, 50);
            flpNhapQuan.Name = "flpNhapQuan";
            flpNhapQuan.Size = new Size(616, 28);
            flpNhapQuan.TabIndex = 27;
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
            flpButtons.Dock = DockStyle.Top;
            flpButtons.Location = new Point(900, 151);
            flpButtons.Margin = new Padding(900, 5, 5, 50);
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
            // GUI_Quan
            // 
            ClientSize = new Size(1634, 940);
            Controls.Add(tlbFormQuan);
            Name = "GUI_Quan";
            Text = "Quản Lý Quận";
            ((System.ComponentModel.ISupportInitialize)dgvQuan).EndInit();
            tlbFormQuan.ResumeLayout(false);
            tlbFormQuan.PerformLayout();
            flpDanhSachQuan.ResumeLayout(false);
            flpDanhSachQuan.PerformLayout();
            flpControls.ResumeLayout(false);
            flpControls.PerformLayout();
            flpNhapQuan.ResumeLayout(false);
            flpNhapQuan.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }
        private Label lblDanhSachPhieuThu;
        private Label label2;
        private DataGridView dgvQuan;
        private TableLayoutPanel tlbFormQuan;
        private DataGridViewTextBoxColumn Column1;
        private FlowLayoutPanel flpDanhSachQuan;
        private TextBox txtTenQuan;
        private Label lblTenQuan;
        private Label lblNhapQuan;
        private FlowLayoutPanel flpControls;
        private FlowLayoutPanel flpNhapQuan;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Panel panel1;
        private Button btnEdit;
        private Panel panel2;
        private Button btnDelete;
        private Panel panel3;
        private Button btnFind;
    }
}
