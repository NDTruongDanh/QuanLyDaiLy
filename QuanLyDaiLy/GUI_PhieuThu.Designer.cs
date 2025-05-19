namespace GUI_QuanLy
{
    partial class GUI_PhieuThu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNgayThuTien;
        private System.Windows.Forms.Label lblSoTienThu;
        private System.Windows.Forms.DateTimePicker dtpNgayThuTien;

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
            lblNgayThuTien = new Label();
            lblSoTienThu = new Label();
            dtpNgayThuTien = new DateTimePicker();
            panel1 = new Panel();
            lblDanhSachPhieuThu = new Label();
            label2 = new Label();
            dgvPhieuThu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cboLoaiDaiLy = new ComboBox();
            txtSoTienThu = new TextBox();
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
            lblNgayThuTien.Location = new Point(3, 46);
            lblNgayThuTien.Name = "lblNgayThuTien";
            lblNgayThuTien.Size = new Size(176, 32);
            lblNgayThuTien.TabIndex = 2;
            lblNgayThuTien.Text = "Ngày Thu Tiền:";
            // 
            // lblSoTienThu
            // 
            lblSoTienThu.AutoSize = true;
            lblSoTienThu.Font = new Font("Segoe UI", 12F);
            lblSoTienThu.Location = new Point(3, 91);
            lblSoTienThu.Name = "lblSoTienThu";
            lblSoTienThu.Size = new Size(147, 32);
            lblSoTienThu.TabIndex = 4;
            lblSoTienThu.Text = "Số Tiền Thu:";
            // 
            // dtpNgayThuTien
            // 
            dtpNgayThuTien.Dock = DockStyle.Fill;
            dtpNgayThuTien.Font = new Font("Segoe UI", 12F);
            dtpNgayThuTien.Location = new Point(237, 49);
            dtpNgayThuTien.Name = "dtpNgayThuTien";
            dtpNgayThuTien.Size = new Size(1324, 39);
            dtpNgayThuTien.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblDanhSachPhieuThu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dgvPhieuThu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(16, 16);
            panel1.Margin = new Padding(16, 16, 16, 8);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16);
            panel1.Size = new Size(1602, 601);
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
            label2.Size = new Size(3000, 2);
            label2.TabIndex = 15;
            // 
            // dgvPhieuThu
            // 
            dgvPhieuThu.AllowUserToResizeColumns = false;
            dgvPhieuThu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhieuThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuThu.BackgroundColor = Color.White;
            dgvPhieuThu.BorderStyle = BorderStyle.None;
            dgvPhieuThu.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvPhieuThu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPhieuThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPhieuThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuThu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPhieuThu.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPhieuThu.EnableHeadersVisualStyles = false;
            dgvPhieuThu.GridColor = Color.White;
            dgvPhieuThu.Location = new Point(19, 77);
            dgvPhieuThu.Name = "dgvPhieuThu";
            dgvPhieuThu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPhieuThu.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPhieuThu.RowHeadersVisible = false;
            dgvPhieuThu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPhieuThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuThu.Size = new Size(1564, 505);
            dgvPhieuThu.TabIndex = 14;
            dgvPhieuThu.SelectionChanged += dgvPhieuThu_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Đại Lý";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Địa Chỉ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Điện Thoại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Ngày Thu Tiền";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Số Tiền Thu";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(lblThongTinPhieuThu);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(16, 633);
            panel2.Margin = new Padding(16, 8, 16, 16);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(16);
            panel2.Size = new Size(1602, 291);
            panel2.TabIndex = 25;
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
            flowLayoutPanel1.Location = new Point(809, 220);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(774, 52);
            flowLayoutPanel1.TabIndex = 29;
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(cboLoaiDaiLy, 1, 0);
            tableLayoutPanel1.Controls.Add(txtSoTienThu, 1, 10);
            tableLayoutPanel1.Controls.Add(lblSoTienThu, 0, 10);
            tableLayoutPanel1.Controls.Add(dtpNgayThuTien, 1, 9);
            tableLayoutPanel1.Controls.Add(lblNgayThuTien, 0, 9);
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
            tableLayoutPanel1.Size = new Size(1564, 148);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // cboLoaiDaiLy
            // 
            cboLoaiDaiLy.Dock = DockStyle.Fill;
            cboLoaiDaiLy.Font = new Font("Segoe UI", 12F);
            cboLoaiDaiLy.FormattingEnabled = true;
            cboLoaiDaiLy.Location = new Point(237, 3);
            cboLoaiDaiLy.Name = "cboLoaiDaiLy";
            cboLoaiDaiLy.Size = new Size(1324, 40);
            cboLoaiDaiLy.TabIndex = 12;
            // 
            // txtSoTienThu
            // 
            txtSoTienThu.Dock = DockStyle.Fill;
            txtSoTienThu.Font = new Font("Segoe UI", 12F);
            txtSoTienThu.Location = new Point(237, 94);
            txtSoTienThu.Name = "txtSoTienThu";
            txtSoTienThu.Size = new Size(1324, 39);
            txtSoTienThu.TabIndex = 5;
            txtSoTienThu.KeyPress += txtSoTienThu_KeyPress;
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
            lblThongTinPhieuThu.Location = new Point(19, 13);
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
            label4.Size = new Size(3000, 2);
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 66.4893646F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.51064F));
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
        private Label lblTenDaiLy;
        private Label lblThongTinPhieuThu;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox txtSoTienThu;
        private ComboBox cboLoaiDaiLy;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnFind;
        private Button button1;
    }
}
