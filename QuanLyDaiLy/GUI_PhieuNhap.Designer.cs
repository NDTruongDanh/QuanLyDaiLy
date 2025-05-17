namespace GUI_QuanLy
{
    partial class GUI_PhieuNhap
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
            tblPhieuNhap = new TableLayoutPanel();
            pnlData = new Panel();
            dgvPhieuNhap = new DataGridView();
            dgvtxtMaPhieuNhap = new DataGridViewTextBoxColumn();
            dgvtxtNgayLapPhieu = new DataGridViewTextBoxColumn();
            dgvtxtTongTien = new DataGridViewTextBoxColumn();
            lblDanhSachDaiLy = new Label();
            label2 = new Label();
            pnlInput = new Panel();
            tblThongTinPhieuNhap = new TableLayoutPanel();
            lblNgayLapPhieu = new Label();
            lblTongTien = new Label();
            txtTenDaiLy = new TextBox();
            lblTenDaiLy = new Label();
            dtpNgayLapPhieu = new DateTimePicker();
            txtTongTien = new TextBox();
            lblThongTinDaiLy = new Label();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            tblPhieuNhap.SuspendLayout();
            pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            pnlInput.SuspendLayout();
            tblThongTinPhieuNhap.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblPhieuNhap
            // 
            tblPhieuNhap.ColumnCount = 1;
            tblPhieuNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPhieuNhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblPhieuNhap.Controls.Add(pnlData, 0, 0);
            tblPhieuNhap.Controls.Add(pnlInput, 0, 1);
            tblPhieuNhap.Dock = DockStyle.Fill;
            tblPhieuNhap.Location = new Point(0, 0);
            tblPhieuNhap.Name = "tblPhieuNhap";
            tblPhieuNhap.RowCount = 2;
            tblPhieuNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 63.93617F));
            tblPhieuNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 36.06383F));
            tblPhieuNhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblPhieuNhap.Size = new Size(1634, 925);
            tblPhieuNhap.TabIndex = 3;
            // 
            // pnlData
            // 
            pnlData.BackColor = Color.White;
            pnlData.Controls.Add(dgvPhieuNhap);
            pnlData.Controls.Add(lblDanhSachDaiLy);
            pnlData.Controls.Add(label2);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(16, 16);
            pnlData.Margin = new Padding(16, 16, 16, 8);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(15);
            pnlData.Size = new Size(1602, 567);
            pnlData.TabIndex = 24;
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToResizeColumns = false;
            dgvPhieuNhap.AllowUserToResizeRows = false;
            dgvPhieuNhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.BackgroundColor = Color.White;
            dgvPhieuNhap.BorderStyle = BorderStyle.None;
            dgvPhieuNhap.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvPhieuNhap.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.Columns.AddRange(new DataGridViewColumn[] { dgvtxtMaPhieuNhap, dgvtxtNgayLapPhieu, dgvtxtTongTien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPhieuNhap.EnableHeadersVisualStyles = false;
            dgvPhieuNhap.GridColor = Color.White;
            dgvPhieuNhap.Location = new Point(15, 82);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dgvPhieuNhap.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.Size = new Size(1569, 467);
            dgvPhieuNhap.TabIndex = 17;
            // 
            // dgvtxtMaPhieuNhap
            // 
            dgvtxtMaPhieuNhap.HeaderText = "Mã phiếu nhập";
            dgvtxtMaPhieuNhap.MinimumWidth = 6;
            dgvtxtMaPhieuNhap.Name = "dgvtxtMaPhieuNhap";
            dgvtxtMaPhieuNhap.ReadOnly = true;
            // 
            // dgvtxtNgayLapPhieu
            // 
            dgvtxtNgayLapPhieu.HeaderText = "Ngày lập phiếu";
            dgvtxtNgayLapPhieu.MinimumWidth = 6;
            dgvtxtNgayLapPhieu.Name = "dgvtxtNgayLapPhieu";
            dgvtxtNgayLapPhieu.ReadOnly = true;
            // 
            // dgvtxtTongTien
            // 
            dgvtxtTongTien.HeaderText = "Tổng tiền";
            dgvtxtTongTien.MinimumWidth = 6;
            dgvtxtTongTien.Name = "dgvtxtTongTien";
            dgvtxtTongTien.ReadOnly = true;
            // 
            // lblDanhSachDaiLy
            // 
            lblDanhSachDaiLy.AutoSize = true;
            lblDanhSachDaiLy.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachDaiLy.Location = new Point(30, 30);
            lblDanhSachDaiLy.Name = "lblDanhSachDaiLy";
            lblDanhSachDaiLy.Size = new Size(330, 32);
            lblDanhSachDaiLy.TabIndex = 16;
            lblDanhSachDaiLy.Text = "Danh sách phiếu nhập hàng";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(0, 64);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(2000, 2);
            label2.TabIndex = 15;
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.Controls.Add(flowLayoutPanel1);
            pnlInput.Controls.Add(tblThongTinPhieuNhap);
            pnlInput.Controls.Add(lblThongTinDaiLy);
            pnlInput.Controls.Add(label4);
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Location = new Point(16, 599);
            pnlInput.Margin = new Padding(16, 8, 16, 16);
            pnlInput.Name = "pnlInput";
            pnlInput.Padding = new Padding(15);
            pnlInput.Size = new Size(1602, 310);
            pnlInput.TabIndex = 23;
            // 
            // tblThongTinPhieuNhap
            // 
            tblThongTinPhieuNhap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tblThongTinPhieuNhap.ColumnCount = 2;
            tblThongTinPhieuNhap.ColumnStyles.Add(new ColumnStyle());
            tblThongTinPhieuNhap.ColumnStyles.Add(new ColumnStyle());
            tblThongTinPhieuNhap.Controls.Add(lblNgayLapPhieu, 0, 1);
            tblThongTinPhieuNhap.Controls.Add(lblTongTien, 0, 2);
            tblThongTinPhieuNhap.Controls.Add(txtTenDaiLy, 1, 0);
            tblThongTinPhieuNhap.Controls.Add(lblTenDaiLy, 0, 0);
            tblThongTinPhieuNhap.Controls.Add(dtpNgayLapPhieu, 1, 1);
            tblThongTinPhieuNhap.Controls.Add(txtTongTien, 1, 2);
            tblThongTinPhieuNhap.Location = new Point(15, 109);
            tblThongTinPhieuNhap.Name = "tblThongTinPhieuNhap";
            tblThongTinPhieuNhap.RowCount = 3;
            tblThongTinPhieuNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblThongTinPhieuNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblThongTinPhieuNhap.RowStyles.Add(new RowStyle());
            tblThongTinPhieuNhap.Size = new Size(1569, 120);
            tblThongTinPhieuNhap.TabIndex = 19;
            // 
            // lblNgayLapPhieu
            // 
            lblNgayLapPhieu.AutoSize = true;
            lblNgayLapPhieu.BackColor = Color.Transparent;
            lblNgayLapPhieu.Dock = DockStyle.Fill;
            lblNgayLapPhieu.Font = new Font("Segoe UI", 12F);
            lblNgayLapPhieu.Location = new Point(3, 40);
            lblNgayLapPhieu.Name = "lblNgayLapPhieu";
            lblNgayLapPhieu.Size = new Size(150, 40);
            lblNgayLapPhieu.TabIndex = 8;
            lblNgayLapPhieu.Text = "Ngày lập phiếu ";
            lblNgayLapPhieu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Dock = DockStyle.Fill;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(3, 80);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(150, 40);
            lblTongTien.TabIndex = 24;
            lblTongTien.Text = "Tổng tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTenDaiLy
            // 
            txtTenDaiLy.Font = new Font("Segoe UI", 12F);
            txtTenDaiLy.Location = new Point(159, 3);
            txtTenDaiLy.Name = "txtTenDaiLy";
            txtTenDaiLy.Size = new Size(1410, 34);
            txtTenDaiLy.TabIndex = 7;
            // 
            // lblTenDaiLy
            // 
            lblTenDaiLy.AutoSize = true;
            lblTenDaiLy.BackColor = Color.Transparent;
            lblTenDaiLy.Dock = DockStyle.Fill;
            lblTenDaiLy.Font = new Font("Segoe UI", 12F);
            lblTenDaiLy.Location = new Point(3, 0);
            lblTenDaiLy.Name = "lblTenDaiLy";
            lblTenDaiLy.Size = new Size(150, 40);
            lblTenDaiLy.TabIndex = 0;
            lblTenDaiLy.Text = "Mã phiếu nhập";
            lblTenDaiLy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpNgayLapPhieu
            // 
            dtpNgayLapPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLapPhieu.Location = new Point(159, 43);
            dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            dtpNgayLapPhieu.Size = new Size(1410, 34);
            dtpNgayLapPhieu.TabIndex = 13;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(159, 83);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(125, 34);
            txtTongTien.TabIndex = 25;
            // 
            // lblThongTinDaiLy
            // 
            lblThongTinDaiLy.AutoSize = true;
            lblThongTinDaiLy.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinDaiLy.Location = new Point(33, 30);
            lblThongTinDaiLy.Name = "lblThongTinDaiLy";
            lblThongTinDaiLy.Size = new Size(324, 32);
            lblThongTinDaiLy.TabIndex = 16;
            lblThongTinDaiLy.Text = "Thông tin phiếu nhập hàng";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(0, 64);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(2000, 2);
            label4.TabIndex = 15;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnEdit);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnFind);
            flowLayoutPanel1.Location = new Point(1040, 240);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(544, 52);
            flowLayoutPanel1.TabIndex = 27;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 44);
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
            btnEdit.Location = new Point(137, 3);
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
            btnDelete.Location = new Point(271, 3);
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
            btnFind.Location = new Point(405, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(128, 44);
            btnFind.TabIndex = 23;
            btnFind.Text = "🔍 Tìm ";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // GUI_PhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 925);
            Controls.Add(tblPhieuNhap);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GUI_PhieuNhap";
            Text = "Quản Lý Phiếu Nhập";
            tblPhieuNhap.ResumeLayout(false);
            pnlData.ResumeLayout(false);
            pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            tblThongTinPhieuNhap.ResumeLayout(false);
            tblThongTinPhieuNhap.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tblPhieuNhap;
        private Panel pnlData;
        private DataGridView dgvPhieuNhap;
        private Label lblDanhSachDaiLy;
        private Label label2;
        private Panel pnlInput;
        private TableLayoutPanel tblThongTinPhieuNhap;
        private Label lblNgayLapPhieu;
        private TextBox txtTenDaiLy;
        private Label lblTenDaiLy;
        private Label lblThongTinDaiLy;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker dtpNgayLapPhieu;
        private Label lblTongTien;
        private TextBox txtTongTien;
        private DataGridViewTextBoxColumn dgvtxtMaPhieuNhap;
        private DataGridViewTextBoxColumn dgvtxtNgayLapPhieu;
        private DataGridViewTextBoxColumn dgvtxtTongTien;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnFind;
    }
}
