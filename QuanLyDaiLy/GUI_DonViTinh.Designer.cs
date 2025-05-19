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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DonViTinh));
            lblDsDVT = new Label();
            dgvDVT = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();

            txtDonViTinh = new TextBox();
            lblTenDVT = new Label();

            tblFormDVT = new TableLayoutPanel();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            panel3 = new Panel();
            btnEdit = new Button();
            panel4 = new Panel();
            btnDelete = new Button();
            panel5 = new Panel();
            btnFind = new Button();
            flpDanhSachDVT = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvDVT).BeginInit();

            tblFormDVT.SuspendLayout();
            flpButtons.SuspendLayout();
            flpDanhSachDVT.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDVT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDVT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDVT.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDVT.DefaultCellStyle = dataGridViewCellStyle5;
            dgvDVT.EnableHeadersVisualStyles = false;
            dgvDVT.GridColor = Color.White;
            dgvDVT.Location = new Point(5, 47);
            dgvDVT.Margin = new Padding(5);
            dgvDVT.Name = "dgvDVT";
            dgvDVT.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvDVT.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // flpButtons
            // 
            flpButtons.AutoSize = true;
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Controls.Add(panel3);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(panel4);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(panel5);
            flpButtons.Controls.Add(btnFind);
            flpButtons.Location = new Point(900, 177);
            flpButtons.Margin = new Padding(900, 5, 5, 5);
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

            flowLayoutPanel1.Controls.Add(flpButtons);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 653);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1628, 284);
            flowLayoutPanel1.TabIndex = 31;
            // 
            // GUI_DonViTinh
            // 
            ClientSize = new Size(1634, 940);
            Controls.Add(tblFormDVT);
            Name = "GUI_DonViTinh";
            Text = "Quản Lý Đơn Vị Tính";
            ((System.ComponentModel.ISupportInitialize)dgvDVT).EndInit();
            tblFormDVT.ResumeLayout(false);
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            flpDanhSachDVT.ResumeLayout(false);
            flpDanhSachDVT.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label lblDsDVT;
        private Label label2;
        private DataGridView dgvDVT;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTenDVT;
        private Label lblThongTinPhieuThu;
        private Label label4;
        private TableLayoutPanel tblFormDVT;
        private TextBox txtDonViTinh;
        private DataGridViewTextBoxColumn Column1;
        private FlowLayoutPanel flpDanhSachDVT;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Panel panel3;
        private Button btnEdit;
        private Panel panel4;
        private Button btnDelete;
        private Panel panel5;
        private Button btnFind;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
