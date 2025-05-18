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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_PhieuNhap));
            dgvPhieuNhap = new DataGridView();
            dgvtxtMaPhieuNhap = new DataGridViewTextBoxColumn();
            dgvtxtNgayLapPhieu = new DataGridViewTextBoxColumn();
            dgvtxtTongTien = new DataGridViewTextBoxColumn();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            flpPhieuNhap = new FlowLayoutPanel();
            pnSpace = new Panel();
            tblThongTinPhieuNhap = new TableLayoutPanel();
            lblNgayLapPhieu = new Label();
            lblTongTien = new Label();
            dtpNgayLapPhieu = new DateTimePicker();
            txtTongTien = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnCTPN = new Button();
            panel1 = new Panel();
            btnEdit = new Button();
            panel2 = new Panel();
            btnDelete = new Button();
            panel3 = new Panel();
            btnFind = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            flpPhieuNhap.SuspendLayout();
            tblThongTinPhieuNhap.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToResizeColumns = false;
            dgvPhieuNhap.AllowUserToResizeRows = false;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.BackgroundColor = Color.White;
            dgvPhieuNhap.BorderStyle = BorderStyle.None;
            dgvPhieuNhap.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
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
            dgvPhieuNhap.Dock = DockStyle.Right;
            dgvPhieuNhap.EnableHeadersVisualStyles = false;
            dgvPhieuNhap.GridColor = Color.White;
            dgvPhieuNhap.Location = new Point(20, 76);
            dgvPhieuNhap.Margin = new Padding(20);
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
            dgvPhieuNhap.Size = new Size(1630, 467);
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
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // flpPhieuNhap
            // 
            flpPhieuNhap.Controls.Add(pnSpace);
            flpPhieuNhap.Controls.Add(dgvPhieuNhap);
            flpPhieuNhap.Controls.Add(tblThongTinPhieuNhap);
            flpPhieuNhap.Controls.Add(flpButtons);
            flpPhieuNhap.Dock = DockStyle.Fill;
            flpPhieuNhap.FlowDirection = FlowDirection.TopDown;
            flpPhieuNhap.Location = new Point(0, 0);
            flpPhieuNhap.Name = "flpPhieuNhap";
            flpPhieuNhap.Size = new Size(1634, 925);
            flpPhieuNhap.TabIndex = 18;
            flpPhieuNhap.WrapContents = false;
            // 
            // pnSpace
            // 
            pnSpace.Location = new Point(3, 3);
            pnSpace.Name = "pnSpace";
            pnSpace.Size = new Size(614, 50);
            pnSpace.TabIndex = 30;
            // 
            // tblThongTinPhieuNhap
            // 
            tblThongTinPhieuNhap.AutoSize = true;
            tblThongTinPhieuNhap.ColumnCount = 2;
            tblThongTinPhieuNhap.ColumnStyles.Add(new ColumnStyle());
            tblThongTinPhieuNhap.ColumnStyles.Add(new ColumnStyle());
            tblThongTinPhieuNhap.Controls.Add(lblNgayLapPhieu, 0, 1);
            tblThongTinPhieuNhap.Controls.Add(lblTongTien, 0, 3);
            tblThongTinPhieuNhap.Controls.Add(dtpNgayLapPhieu, 1, 1);
            tblThongTinPhieuNhap.Controls.Add(txtTongTien, 1, 3);
            tblThongTinPhieuNhap.Dock = DockStyle.Left;
            tblThongTinPhieuNhap.Location = new Point(200, 566);
            tblThongTinPhieuNhap.Margin = new Padding(200, 3, 3, 3);
            tblThongTinPhieuNhap.Name = "tblThongTinPhieuNhap";
            tblThongTinPhieuNhap.RowCount = 6;
            tblThongTinPhieuNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblThongTinPhieuNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblThongTinPhieuNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblThongTinPhieuNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblThongTinPhieuNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblThongTinPhieuNhap.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblThongTinPhieuNhap.Size = new Size(512, 240);
            tblThongTinPhieuNhap.TabIndex = 28;
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
            lblTongTien.Location = new Point(3, 120);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(150, 40);
            lblTongTien.TabIndex = 24;
            lblTongTien.Text = "Tổng tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpNgayLapPhieu
            // 
            dtpNgayLapPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLapPhieu.Location = new Point(159, 43);
            dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            dtpNgayLapPhieu.Size = new Size(350, 34);
            dtpNgayLapPhieu.TabIndex = 13;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(159, 123);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(350, 34);
            txtTongTien.TabIndex = 25;
            // 
            // flpButtons
            // 
            flpButtons.AutoSize = true;
            flpButtons.Controls.Add(btnCTPN);
            flpButtons.Controls.Add(panel1);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(panel2);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(panel3);
            flpButtons.Controls.Add(btnFind);
            flpButtons.Dock = DockStyle.Right;
            flpButtons.Location = new Point(856, 812);
            flpButtons.Margin = new Padding(3, 3, 200, 3);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(614, 50);
            flpButtons.TabIndex = 29;
            // 
            // btnCTPN
            // 
            btnCTPN.AutoSize = true;
            btnCTPN.BackColor = Color.FromArgb(76, 175, 80);
            btnCTPN.FlatStyle = FlatStyle.Flat;
            btnCTPN.Font = new Font("Segoe UI", 12F);
            btnCTPN.Image = (Image)resources.GetObject("btnCTPN.Image");
            btnCTPN.ImageAlign = ContentAlignment.MiddleLeft;
            btnCTPN.Location = new Point(3, 3);
            btnCTPN.Name = "btnCTPN";
            btnCTPN.Size = new Size(128, 44);
            btnCTPN.TabIndex = 22;
            btnCTPN.Text = "CTPN";
            btnCTPN.UseVisualStyleBackColor = false;
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
            // GUI_PhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 925);
            Controls.Add(flpPhieuNhap);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GUI_PhieuNhap";
            Text = "Quản Lý Phiếu Nhập";
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            flpPhieuNhap.ResumeLayout(false);
            flpPhieuNhap.PerformLayout();
            tblThongTinPhieuNhap.ResumeLayout(false);
            tblThongTinPhieuNhap.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }
        private DataGridView dgvPhieuNhap;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridViewTextBoxColumn dgvtxtMaPhieuNhap;
        private DataGridViewTextBoxColumn dgvtxtNgayLapPhieu;
        private DataGridViewTextBoxColumn dgvtxtTongTien;
        private FlowLayoutPanel flpPhieuNhap;
        private Panel pnSpace;
        private TableLayoutPanel tblThongTinPhieuNhap;
        private Label lblNgayLapPhieu;
        private Label lblTongTien;
        private DateTimePicker dtpNgayLapPhieu;
        private TextBox txtTongTien;
        private FlowLayoutPanel flpButtons;
        private Button btnCTPN;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnFind;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
