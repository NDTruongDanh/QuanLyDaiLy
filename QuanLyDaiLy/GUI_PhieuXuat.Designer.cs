namespace GUI_QuanLy
{
    partial class GUI_PhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_PhieuXuat));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel2 = new Panel();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            panel3 = new Panel();
            btnEdit = new Button();
            panel4 = new Panel();
            btnDelete = new Button();
            panel5 = new Panel();
            btnRefresh = new Button();
            panel6 = new Panel();
            btnFind = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtTraTruoc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            cmbDaiLy = new ComboBox();
            dtpNgayLapPhieu = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblDanhSachPhieuXuat = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flpDs = new FlowLayoutPanel();
            dgvPhieuXuat = new DataGridView();
            panel2.SuspendLayout();
            flpButtons.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flpDs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuat).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flpButtons);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(16, 633);
            panel2.Margin = new Padding(16, 8, 16, 16);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(16);
            panel2.Size = new Size(1602, 291);
            panel2.TabIndex = 26;
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
            flpButtons.Controls.Add(panel6);
            flpButtons.Controls.Add(btnFind);
            flpButtons.Location = new Point(802, 222);
            flpButtons.Margin = new Padding(3, 3, 200, 3);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(774, 50);
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
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(617, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(20, 20);
            panel6.TabIndex = 27;
            // 
            // btnFind
            // 
            btnFind.AutoSize = true;
            btnFind.BackColor = Color.FromArgb(33, 150, 243);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 12F);
            btnFind.Location = new Point(643, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(128, 44);
            btnFind.TabIndex = 23;
            btnFind.Text = "🔍 Tìm ";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(txtTraTruoc, 1, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(cmbDaiLy, 1, 0);
            tableLayoutPanel2.Controls.Add(dtpNgayLapPhieu, 1, 1);
            tableLayoutPanel2.Location = new Point(12, 79);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1564, 124);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // txtTraTruoc
            // 
            txtTraTruoc.Dock = DockStyle.Fill;
            txtTraTruoc.Font = new Font("Segoe UI", 12F);
            txtTraTruoc.Location = new Point(167, 85);
            txtTraTruoc.Name = "txtTraTruoc";
            txtTraTruoc.Size = new Size(1417, 34);
            txtTraTruoc.TabIndex = 13;
            txtTraTruoc.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 82);
            label5.Name = "label5";
            label5.Size = new Size(158, 42);
            label5.TabIndex = 10;
            label5.Text = "Số tiền trả trước:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 42);
            label4.Name = "label4";
            label4.Size = new Size(158, 40);
            label4.TabIndex = 9;
            label4.Text = "Ngày lập phiếu";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(158, 42);
            label7.TabIndex = 2;
            label7.Text = "Tên Đại lý:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbDaiLy
            // 
            cmbDaiLy.Dock = DockStyle.Fill;
            cmbDaiLy.Font = new Font("Segoe UI", 12F);
            cmbDaiLy.FormattingEnabled = true;
            cmbDaiLy.Location = new Point(167, 3);
            cmbDaiLy.Name = "cmbDaiLy";
            cmbDaiLy.Size = new Size(1417, 36);
            cmbDaiLy.TabIndex = 7;
            // 
            // dtpNgayLapPhieu
            // 
            dtpNgayLapPhieu.Dock = DockStyle.Fill;
            dtpNgayLapPhieu.Font = new Font("Segoe UI", 12F);
            dtpNgayLapPhieu.Location = new Point(167, 45);
            dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            dtpNgayLapPhieu.Size = new Size(1417, 34);
            dtpNgayLapPhieu.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(253, 32);
            label1.TabIndex = 16;
            label1.Text = "Thông tin phiếu xuất";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(0, 64);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(2000, 2);
            label3.TabIndex = 15;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 32);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(1622, 4);
            label2.TabIndex = 15;
            // 
            // lblDanhSachPhieuXuat
            // 
            lblDanhSachPhieuXuat.AutoSize = true;
            lblDanhSachPhieuXuat.Dock = DockStyle.Top;
            lblDanhSachPhieuXuat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachPhieuXuat.Location = new Point(3, 0);
            lblDanhSachPhieuXuat.Name = "lblDanhSachPhieuXuat";
            lblDanhSachPhieuXuat.Size = new Size(1616, 32);
            lblDanhSachPhieuXuat.TabIndex = 16;
            lblDanhSachPhieuXuat.Text = "Danh sách phiếu xuất";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flpDs, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.4893646F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.51064F));
            tableLayoutPanel1.Size = new Size(1634, 940);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // flpDs
            // 
            flpDs.BackColor = Color.White;
            flpDs.Controls.Add(lblDanhSachPhieuXuat);
            flpDs.Controls.Add(label2);
            flpDs.Controls.Add(dgvPhieuXuat);
            flpDs.Dock = DockStyle.Fill;
            flpDs.FlowDirection = FlowDirection.TopDown;
            flpDs.Location = new Point(3, 3);
            flpDs.Name = "flpDs";
            flpDs.Size = new Size(1628, 619);
            flpDs.TabIndex = 19;
            // 
            // dgvPhieuXuat
            // 
            dgvPhieuXuat.AllowUserToResizeColumns = false;
            dgvPhieuXuat.AllowUserToResizeRows = false;
            dgvPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuXuat.BackgroundColor = Color.White;
            dgvPhieuXuat.BorderStyle = BorderStyle.None;
            dgvPhieuXuat.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPhieuXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPhieuXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPhieuXuat.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPhieuXuat.EnableHeadersVisualStyles = false;
            dgvPhieuXuat.GridColor = Color.White;
            dgvPhieuXuat.Location = new Point(5, 41);
            dgvPhieuXuat.Margin = new Padding(5);
            dgvPhieuXuat.Name = "dgvPhieuXuat";
            dgvPhieuXuat.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvPhieuXuat.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvPhieuXuat.RowHeadersVisible = false;
            dgvPhieuXuat.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPhieuXuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuXuat.Size = new Size(1612, 566);
            dgvPhieuXuat.TabIndex = 18;
            dgvPhieuXuat.SelectionChanged += dgvPhieuXuat_SelectionChanged;
            // 
            // GUI_PhieuXuat
            // 
            ClientSize = new Size(1634, 940);
            Controls.Add(tableLayoutPanel1);
            Name = "GUI_PhieuXuat";
            Text = "Quản Lý Phiếu Xuất";
            Load += GUI_PhieuXuat_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flpDs.ResumeLayout(false);
            flpDs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuat).EndInit();
            ResumeLayout(false);
        }

        private Panel panel2;
        private Label label1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private ComboBox cmbDaiLy;
        private Label label2;
        private Label lblDanhSachPhieuXuat;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dtpNgayLapPhieu;
        private Button btnFind;
        private Label label4;
        private Label label5;
        private TextBox txtTraTruoc;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Panel panel3;
        private Button btnEdit;
        private Panel panel4;
        private Button btnDelete;
        private Panel panel5;
        private Button btnRefresh;
        private Panel panel6;
        private DataGridView dgvPhieuXuat;
        private FlowLayoutPanel flpDs;
    }
}
