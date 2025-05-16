namespace GUI_QuanLy
{
    partial class GUI_PhieuThu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNgayThuTien;
        private System.Windows.Forms.Label lblSoTienThu;
        private System.Windows.Forms.DateTimePicker dtpNgayThuTien;
        private System.Windows.Forms.TextBox txtSoTienThu;

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
            lblNgayThuTien = new Label();
            lblSoTienThu = new Label();
            dtpNgayThuTien = new DateTimePicker();
            txtSoTienThu = new TextBox();
            panel1 = new Panel();
            lblDanhSachPhieuThu = new Label();
            label2 = new Label();
            dgvPhieuThu = new DataGridView();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTenDaiLy = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTenDaiLy = new Label();
            lblThongTinPhieuThu = new Label();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuThu).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNgayThuTien
            // 
            lblNgayThuTien.AutoSize = true;
            lblNgayThuTien.Font = new Font("Segoe UI", 12F);
            lblNgayThuTien.Location = new Point(3, 180);
            lblNgayThuTien.Name = "lblNgayThuTien";
            lblNgayThuTien.Size = new Size(176, 32);
            lblNgayThuTien.TabIndex = 2;
            lblNgayThuTien.Text = "Ngày Thu Tiền:";
            // 
            // lblSoTienThu
            // 
            lblSoTienThu.AutoSize = true;
            lblSoTienThu.Font = new Font("Segoe UI", 12F);
            lblSoTienThu.Location = new Point(3, 225);
            lblSoTienThu.Name = "lblSoTienThu";
            lblSoTienThu.Size = new Size(147, 21);
            lblSoTienThu.TabIndex = 4;
            lblSoTienThu.Text = "Số Tiền Thu:";
            // 
            // dtpNgayThuTien
            // 
            dtpNgayThuTien.Dock = DockStyle.Fill;
            dtpNgayThuTien.Font = new Font("Segoe UI", 12F);
            dtpNgayThuTien.Location = new Point(185, 183);
            dtpNgayThuTien.Name = "dtpNgayThuTien";
            dtpNgayThuTien.Size = new Size(1414, 39);
            dtpNgayThuTien.TabIndex = 3;
            // 
            // txtSoTienThu
            // 
            txtSoTienThu.Dock = DockStyle.Fill;
            txtSoTienThu.Font = new Font("Segoe UI", 12F);
            txtSoTienThu.Location = new Point(185, 228);
            txtSoTienThu.Name = "txtSoTienThu";
            txtSoTienThu.Size = new Size(1414, 39);
            txtSoTienThu.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblDanhSachPhieuThu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dgvPhieuThu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(16, 8);
            panel1.Margin = new Padding(16, 8, 16, 16);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16, 16, 16, 8);
            panel1.Size = new Size(1602, 502);
            panel1.TabIndex = 24;
            // 
            // lblDanhSachPhieuThu
            // 
            lblDanhSachPhieuThu.AutoSize = true;
            lblDanhSachPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachPhieuThu.Location = new Point(16, 16);
            lblDanhSachPhieuThu.Name = "lblDanhSachPhieuThu";
            lblDanhSachPhieuThu.Size = new Size(420, 38);
            lblDanhSachPhieuThu.TabIndex = 16;
            lblDanhSachPhieuThu.Text = "Danh sách phiếu thu của đại lý";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(0, 58);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(2000, 2);
            label2.TabIndex = 15;
            // 
            // dgvPhieuThu
            // 
            dgvPhieuThu.AllowUserToResizeColumns = false;
            dgvPhieuThu.BackgroundColor = Color.White;
            dgvPhieuThu.BorderStyle = BorderStyle.None;
            dgvPhieuThu.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvPhieuThu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPhieuThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhieuThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPhieuThu.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPhieuThu.EnableHeadersVisualStyles = false;
            dgvPhieuThu.GridColor = Color.White;
            dgvPhieuThu.Location = new Point(19, 77);
            dgvPhieuThu.Name = "dgvPhieuThu";
            dgvPhieuThu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPhieuThu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPhieuThu.RowHeadersVisible = false;
            dgvPhieuThu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPhieuThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuThu.Size = new Size(1564, 400);
            dgvPhieuThu.TabIndex = 14;
            dgvPhieuThu.SelectionChanged += dgvPhieuThu_SelectionChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(lblThongTinPhieuThu);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(16, 534);
            panel2.Margin = new Padding(16, 8, 16, 16);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(16);
            panel2.Size = new Size(1602, 390);
            panel2.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnEdit);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Location = new Point(1173, 321);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(410, 50);
            flowLayoutPanel1.TabIndex = 24;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.Lime;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 44);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.BackColor = Color.Yellow;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(137, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 44);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(271, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 44);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(txtTenDaiLy, 1, 0);
            tableLayoutPanel1.Controls.Add(lblDiaChi, 0, 6);
            tableLayoutPanel1.Controls.Add(txtSoTienThu, 1, 10);
            tableLayoutPanel1.Controls.Add(lblSoTienThu, 0, 10);
            tableLayoutPanel1.Controls.Add(dtpNgayThuTien, 1, 9);
            tableLayoutPanel1.Controls.Add(lblNgayThuTien, 0, 9);
            tableLayoutPanel1.Controls.Add(txtDiaChi, 1, 6);
            tableLayoutPanel1.Controls.Add(lblSDT, 0, 7);
            tableLayoutPanel1.Controls.Add(txtSDT, 1, 7);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 8);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 8);
            tableLayoutPanel1.Controls.Add(lblTenDaiLy, 0, 0);
            tableLayoutPanel1.Location = new Point(16, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1602, 246);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // txtTenDaiLy
            // 
            txtTenDaiLy.Dock = DockStyle.Fill;
            txtTenDaiLy.Font = new Font("Segoe UI", 12F);
            txtTenDaiLy.Location = new Point(185, 3);
            txtTenDaiLy.Name = "txtTenDaiLy";
            txtTenDaiLy.ReadOnly = true;
            txtTenDaiLy.Size = new Size(1414, 39);
            txtTenDaiLy.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.BackColor = Color.Transparent;
            lblDiaChi.Font = new Font("Segoe UI", 12F);
            lblDiaChi.Location = new Point(3, 45);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(96, 32);
            lblDiaChi.TabIndex = 3;
            lblDiaChi.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Dock = DockStyle.Fill;
            txtDiaChi.Font = new Font("Segoe UI", 12F);
            txtDiaChi.Location = new Point(185, 48);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(1414, 39);
            txtDiaChi.TabIndex = 8;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.BackColor = Color.Transparent;
            lblSDT.Font = new Font("Segoe UI", 12F);
            lblSDT.Location = new Point(3, 90);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(62, 32);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "SĐT:";
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Fill;
            txtSDT.Font = new Font("Segoe UI", 12F);
            txtSDT.Location = new Point(185, 93);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(1414, 39);
            txtSDT.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(3, 135);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 32);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(185, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(1414, 39);
            txtEmail.TabIndex = 10;
            // 
            // lblTenDaiLy
            // 
            lblTenDaiLy.AutoSize = true;
            lblTenDaiLy.BackColor = Color.Transparent;
            lblTenDaiLy.Font = new Font("Segoe UI", 12F);
            lblTenDaiLy.Location = new Point(3, 0);
            lblTenDaiLy.Name = "lblTenDaiLy";
            lblTenDaiLy.Size = new Size(128, 32);
            lblTenDaiLy.TabIndex = 0;
            lblTenDaiLy.Text = "Tên Đại Lý:";
            // 
            // lblThongTinPhieuThu
            // 
            lblThongTinPhieuThu.AutoSize = true;
            lblThongTinPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinPhieuThu.Location = new Point(9, 16);
            lblThongTinPhieuThu.Name = "lblThongTinPhieuThu";
            lblThongTinPhieuThu.Size = new Size(257, 38);
            lblThongTinPhieuThu.TabIndex = 16;
            lblThongTinPhieuThu.Text = "Lập Phiếu thu tiền";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(0, 51);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(2000, 2);
            label4.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 55.9574471F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 44.0425529F));
            tableLayoutPanel2.Size = new Size(1634, 940);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // GUI_PhieuThu
            // 
            ClientSize = new Size(1634, 940);
            Controls.Add(tableLayoutPanel2);
            Name = "GUI_PhieuThu";
            Text = "Quản Lý Phiếu Thu";
            Load += GUI_PhieuThu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuThu).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label lblDanhSachPhieuThu;
        private Label label2;
        private DataGridView dgvPhieuThu;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtTenDaiLy;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTenDaiLy;
        private Label lblThongTinPhieuThu;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}
