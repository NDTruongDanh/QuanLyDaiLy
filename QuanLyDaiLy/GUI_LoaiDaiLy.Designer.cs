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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblDanhSachPhieuThu = new Label();
            label2 = new Label();
            dgvLoaiDaiLy = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            button5 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            txtTenLoaiDaiLy = new TextBox();
            lblTenDaiLy = new Label();
            lblThongTinPhieuThu = new Label();
            label4 = new Label();
            txtTienNoToiDa = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDaiLy).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblDanhSachPhieuThu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dgvLoaiDaiLy);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(16, 16);
            panel1.Margin = new Padding(16, 16, 16, 8);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16, 16, 16, 8);
            panel1.Size = new Size(1602, 612);
            panel1.TabIndex = 24;
            // 
            // lblDanhSachPhieuThu
            // 
            lblDanhSachPhieuThu.AutoSize = true;
            lblDanhSachPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachPhieuThu.Location = new Point(16, 16);
            lblDanhSachPhieuThu.Name = "lblDanhSachPhieuThu";
            lblDanhSachPhieuThu.Size = new Size(254, 32);
            lblDanhSachPhieuThu.TabIndex = 16;
            lblDanhSachPhieuThu.Text = "Danh sách Loại đại lý";
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
            // dgvLoaiDaiLy
            // 
            dgvLoaiDaiLy.AllowUserToResizeColumns = false;
            dgvLoaiDaiLy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLoaiDaiLy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiDaiLy.BackgroundColor = Color.White;
            dgvLoaiDaiLy.BorderStyle = BorderStyle.None;
            dgvLoaiDaiLy.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvLoaiDaiLy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvLoaiDaiLy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvLoaiDaiLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiDaiLy.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvLoaiDaiLy.DefaultCellStyle = dataGridViewCellStyle8;
            dgvLoaiDaiLy.EnableHeadersVisualStyles = false;
            dgvLoaiDaiLy.GridColor = Color.White;
            dgvLoaiDaiLy.Location = new Point(19, 77);
            dgvLoaiDaiLy.Name = "dgvLoaiDaiLy";
            dgvLoaiDaiLy.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvLoaiDaiLy.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvLoaiDaiLy.RowHeadersVisible = false;
            dgvLoaiDaiLy.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvLoaiDaiLy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiDaiLy.Size = new Size(1564, 512);
            dgvLoaiDaiLy.TabIndex = 14;
            dgvLoaiDaiLy.CellContentClick += dgvLoaiDaiLy_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Loại Đại Lý";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tiền Nợ Tối Đa";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(lblThongTinPhieuThu);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(16, 644);
            panel2.Margin = new Padding(16, 8, 16, 16);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(16);
            panel2.Size = new Size(1602, 280);
            panel2.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnEdit);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Location = new Point(981, 209);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(602, 52);
            flowLayoutPanel1.TabIndex = 35;
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
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.FromArgb(221, 121, 115);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(462, 3);
            button5.Name = "button5";
            button5.Size = new Size(136, 44);
            button5.TabIndex = 24;
            button5.Text = "🔄 Làm mới";
            button5.UseVisualStyleBackColor = false;
            button5.Click += btnRefresh_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(txtTenLoaiDaiLy, 1, 0);
            tableLayoutPanel1.Controls.Add(lblTenDaiLy, 0, 0);
            tableLayoutPanel1.Location = new Point(16, 81);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1567, 90);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 7;
            label1.Text = "Tiền nợ tối đa:";
            // 
            // txtTenLoaiDaiLy
            // 
            txtTenLoaiDaiLy.Dock = DockStyle.Fill;
            txtTenLoaiDaiLy.Font = new Font("Segoe UI", 12F);
            txtTenLoaiDaiLy.Location = new Point(152, 3);
            txtTenLoaiDaiLy.Name = "txtTenLoaiDaiLy";
            txtTenLoaiDaiLy.Size = new Size(1412, 34);
            txtTenLoaiDaiLy.TabIndex = 6;
            // 
            // lblTenDaiLy
            // 
            lblTenDaiLy.AutoSize = true;
            lblTenDaiLy.BackColor = Color.Transparent;
            lblTenDaiLy.Font = new Font("Segoe UI", 12F);
            lblTenDaiLy.Location = new Point(3, 0);
            lblTenDaiLy.Name = "lblTenDaiLy";
            lblTenDaiLy.Size = new Size(143, 28);
            lblTenDaiLy.TabIndex = 0;
            lblTenDaiLy.Text = "Tên Loại Đại Lý:";
            // 
            // lblThongTinPhieuThu
            // 
            lblThongTinPhieuThu.AutoSize = true;
            lblThongTinPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinPhieuThu.Location = new Point(16, 13);
            lblThongTinPhieuThu.Name = "lblThongTinPhieuThu";
            lblThongTinPhieuThu.Size = new Size(247, 32);
            lblThongTinPhieuThu.TabIndex = 16;
            lblThongTinPhieuThu.Text = "Nhập liệu Loại đại lý";
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
            // txtTienNoToiDa
            // 
            txtTienNoToiDa.Dock = DockStyle.Fill;
            txtTienNoToiDa.Font = new Font("Segoe UI", 12F);
            txtTienNoToiDa.Location = new Point(187, 48);
            txtTienNoToiDa.Name = "txtTienNoToiDa";
            txtTienNoToiDa.Size = new Size(1377, 34);
            txtTienNoToiDa.TabIndex = 8;
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 67.65958F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32.3404274F));
            tableLayoutPanel2.Size = new Size(1634, 940);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // GUI_LoaiDaiLy
            // 
            ClientSize = new Size(1634, 940);
            Controls.Add(tableLayoutPanel2);
            Name = "GUI_LoaiDaiLy";
            Text = "Quản Lý Loại Đại Lý";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDaiLy).EndInit();
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
        private DataGridView dgvLoaiDaiLy;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTenDaiLy;
        private Label lblThongTinPhieuThu;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtTienNoToiDa;
        private Label label1;
        private TextBox txtTenLoaiDaiLy;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button button5;
    }
}
