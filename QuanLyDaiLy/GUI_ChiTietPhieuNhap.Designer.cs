using System.Windows.Forms;

namespace GUI_QuanLy
{
    partial class GUI_ChiTietPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            flpForm = new FlowLayoutPanel();
            flpMaPhieu = new FlowLayoutPanel();
            lblMaPhieuNhap = new Label();
            txtMaPhieuNhap = new TextBox();
            tlbChiTiet = new TableLayoutPanel();
            cbbMatHang = new ComboBox();
            cbbDVT = new ComboBox();
            txtSL = new TextBox();
            lblTenMatHang = new Label();
            lblDVT = new Label();
            lblSL = new Label();
            lblDG = new Label();
            lblThanhTien = new Label();
            txtDG = new TextBox();
            txtThanhTien = new TextBox();
            flpTongTien = new FlowLayoutPanel();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            dgvDsChiTiet = new DataGridView();
            dgvcbbMatHang = new DataGridViewComboBoxColumn();
            dgvcbbDCT = new DataGridViewComboBoxColumn();
            dgvtxtSL = new DataGridViewTextBoxColumn();
            dgvtxtDG = new DataGridViewTextBoxColumn();
            dgvtxtThanhTien = new DataGridViewTextBoxColumn();
            flpButtons = new FlowLayoutPanel();
            btnDone = new Button();
            btnRefresh = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            flpForm.SuspendLayout();
            flpMaPhieu.SuspendLayout();
            tlbChiTiet.SuspendLayout();
            flpTongTien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTiet).BeginInit();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // flpForm
            // 
            flpForm.Controls.Add(flpMaPhieu);
            flpForm.Controls.Add(tlbChiTiet);
            flpForm.Controls.Add(flpTongTien);
            flpForm.Controls.Add(dgvDsChiTiet);
            flpForm.Controls.Add(flpButtons);
            flpForm.Dock = DockStyle.Fill;
            flpForm.FlowDirection = FlowDirection.TopDown;
            flpForm.Location = new Point(0, 0);
            flpForm.Name = "flpForm";
            flpForm.Size = new Size(1616, 878);
            flpForm.TabIndex = 0;
            // 
            // flpMaPhieu
            // 
            flpMaPhieu.AutoSize = true;
            flpMaPhieu.Controls.Add(lblMaPhieuNhap);
            flpMaPhieu.Controls.Add(txtMaPhieuNhap);
            flpMaPhieu.Location = new Point(3, 3);
            flpMaPhieu.Name = "flpMaPhieu";
            flpMaPhieu.Size = new Size(425, 52);
            flpMaPhieu.TabIndex = 3;
            // 
            // lblMaPhieuNhap
            // 
            lblMaPhieuNhap.AutoSize = true;
            lblMaPhieuNhap.Dock = DockStyle.Left;
            lblMaPhieuNhap.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaPhieuNhap.Location = new Point(3, 3);
            lblMaPhieuNhap.Margin = new Padding(3);
            lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            lblMaPhieuNhap.Size = new Size(259, 46);
            lblMaPhieuNhap.TabIndex = 1;
            lblMaPhieuNhap.Text = "Mã phiếu nhập";
            lblMaPhieuNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.BackColor = Color.White;
            txtMaPhieuNhap.BorderStyle = BorderStyle.None;
            txtMaPhieuNhap.Dock = DockStyle.Right;
            txtMaPhieuNhap.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaPhieuNhap.Location = new Point(270, 5);
            txtMaPhieuNhap.Margin = new Padding(5);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.Size = new Size(150, 36);
            txtMaPhieuNhap.TabIndex = 2;
            // 
            // tlbChiTiet
            // 
            tlbChiTiet.AutoSize = true;
            tlbChiTiet.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tlbChiTiet.ColumnCount = 5;
            tlbChiTiet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbChiTiet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbChiTiet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbChiTiet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbChiTiet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlbChiTiet.Controls.Add(cbbMatHang, 0, 1);
            tlbChiTiet.Controls.Add(cbbDVT, 1, 1);
            tlbChiTiet.Controls.Add(txtSL, 2, 1);
            tlbChiTiet.Controls.Add(lblTenMatHang, 0, 0);
            tlbChiTiet.Controls.Add(lblDVT, 1, 0);
            tlbChiTiet.Controls.Add(lblSL, 2, 0);
            tlbChiTiet.Controls.Add(lblDG, 3, 0);
            tlbChiTiet.Controls.Add(lblThanhTien, 4, 0);
            tlbChiTiet.Controls.Add(txtDG, 3, 1);
            tlbChiTiet.Controls.Add(txtThanhTien, 4, 1);
            tlbChiTiet.Dock = DockStyle.Top;
            tlbChiTiet.Location = new Point(5, 63);
            tlbChiTiet.Margin = new Padding(5);
            tlbChiTiet.Name = "tlbChiTiet";
            tlbChiTiet.RowCount = 2;
            tlbChiTiet.RowStyles.Add(new RowStyle());
            tlbChiTiet.RowStyles.Add(new RowStyle());
            tlbChiTiet.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlbChiTiet.Size = new Size(1597, 78);
            tlbChiTiet.TabIndex = 4;
            // 
            // cbbMatHang
            // 
            cbbMatHang.Dock = DockStyle.Fill;
            cbbMatHang.FormattingEnabled = true;
            cbbMatHang.Location = new Point(5, 45);
            cbbMatHang.Name = "cbbMatHang";
            cbbMatHang.Size = new Size(311, 28);
            cbbMatHang.TabIndex = 0;
            // 
            // cbbDVT
            // 
            cbbDVT.Dock = DockStyle.Fill;
            cbbDVT.FormattingEnabled = true;
            cbbDVT.Location = new Point(324, 45);
            cbbDVT.Name = "cbbDVT";
            cbbDVT.Size = new Size(311, 28);
            cbbDVT.TabIndex = 2;
            // 
            // txtSL
            // 
            txtSL.Dock = DockStyle.Fill;
            txtSL.Location = new Point(643, 45);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(311, 27);
            txtSL.TabIndex = 1;
            // 
            // lblTenMatHang
            // 
            lblTenMatHang.AutoSize = true;
            lblTenMatHang.Dock = DockStyle.Fill;
            lblTenMatHang.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenMatHang.Location = new Point(5, 2);
            lblTenMatHang.Name = "lblTenMatHang";
            lblTenMatHang.Size = new Size(311, 38);
            lblTenMatHang.TabIndex = 3;
            lblTenMatHang.Text = "Tên mặt hàng";
            lblTenMatHang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDVT
            // 
            lblDVT.AutoSize = true;
            lblDVT.Dock = DockStyle.Fill;
            lblDVT.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDVT.Location = new Point(324, 2);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new Size(311, 38);
            lblDVT.TabIndex = 4;
            lblDVT.Text = "Tên đơn vị tính";
            lblDVT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSL
            // 
            lblSL.AutoSize = true;
            lblSL.Dock = DockStyle.Fill;
            lblSL.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSL.Location = new Point(643, 2);
            lblSL.Name = "lblSL";
            lblSL.Size = new Size(311, 38);
            lblSL.TabIndex = 5;
            lblSL.Text = "Số lượng";
            lblSL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDG
            // 
            lblDG.AutoSize = true;
            lblDG.Dock = DockStyle.Fill;
            lblDG.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDG.Location = new Point(962, 2);
            lblDG.Name = "lblDG";
            lblDG.Size = new Size(311, 38);
            lblDG.TabIndex = 6;
            lblDG.Text = "Đơn giá";
            lblDG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Dock = DockStyle.Fill;
            lblThanhTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThanhTien.Location = new Point(1281, 2);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(311, 38);
            lblThanhTien.TabIndex = 7;
            lblThanhTien.Text = "Thành tiền";
            lblThanhTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDG
            // 
            txtDG.Dock = DockStyle.Fill;
            txtDG.Location = new Point(962, 45);
            txtDG.Name = "txtDG";
            txtDG.Size = new Size(311, 27);
            txtDG.TabIndex = 8;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Dock = DockStyle.Fill;
            txtThanhTien.Location = new Point(1281, 45);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(311, 27);
            txtThanhTien.TabIndex = 9;
            // 
            // flpTongTien
            // 
            flpTongTien.AutoSize = true;
            flpTongTien.Controls.Add(lblTongTien);
            flpTongTien.Controls.Add(txtTongTien);
            flpTongTien.Dock = DockStyle.Top;
            flpTongTien.Location = new Point(3, 149);
            flpTongTien.Name = "flpTongTien";
            flpTongTien.Padding = new Padding(3);
            flpTongTien.Size = new Size(1601, 52);
            flpTongTien.TabIndex = 4;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Dock = DockStyle.Left;
            lblTongTien.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(6, 3);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(143, 46);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.White;
            txtTongTien.BorderStyle = BorderStyle.None;
            txtTongTien.Dock = DockStyle.Top;
            txtTongTien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(157, 8);
            txtTongTien.Margin = new Padding(5);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(125, 36);
            txtTongTien.TabIndex = 2;
            // 
            // dgvDsChiTiet
            // 
            dgvDsChiTiet.AllowUserToResizeColumns = false;
            dgvDsChiTiet.AllowUserToResizeRows = false;
            dgvDsChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDsChiTiet.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDsChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDsChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsChiTiet.Columns.AddRange(new DataGridViewColumn[] { dgvcbbMatHang, dgvcbbDCT, dgvtxtSL, dgvtxtDG, dgvtxtThanhTien });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDsChiTiet.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDsChiTiet.Dock = DockStyle.Top;
            dgvDsChiTiet.Location = new Point(10, 214);
            dgvDsChiTiet.Margin = new Padding(10);
            dgvDsChiTiet.Name = "dgvDsChiTiet";
            dgvDsChiTiet.RowHeadersVisible = false;
            dgvDsChiTiet.RowHeadersWidth = 51;
            dgvDsChiTiet.Size = new Size(1587, 569);
            dgvDsChiTiet.TabIndex = 0;
            // 
            // dgvcbbMatHang
            // 
            dgvcbbMatHang.HeaderText = "Tên Mặt Hàng";
            dgvcbbMatHang.MinimumWidth = 6;
            dgvcbbMatHang.Name = "dgvcbbMatHang";
            dgvcbbMatHang.ReadOnly = true;
            // 
            // dgvcbbDCT
            // 
            dgvcbbDCT.HeaderText = "Đơn Vị Tính";
            dgvcbbDCT.MinimumWidth = 6;
            dgvcbbDCT.Name = "dgvcbbDCT";
            dgvcbbDCT.ReadOnly = true;
            // 
            // dgvtxtSL
            // 
            dgvtxtSL.HeaderText = "Số Lượng";
            dgvtxtSL.MinimumWidth = 6;
            dgvtxtSL.Name = "dgvtxtSL";
            // 
            // dgvtxtDG
            // 
            dgvtxtDG.HeaderText = "Đơn Giá";
            dgvtxtDG.MinimumWidth = 6;
            dgvtxtDG.Name = "dgvtxtDG";
            // 
            // dgvtxtThanhTien
            // 
            dgvtxtThanhTien.HeaderText = "Thành Tiền";
            dgvtxtThanhTien.MinimumWidth = 6;
            dgvtxtThanhTien.Name = "dgvtxtThanhTien";
            dgvtxtThanhTien.ReadOnly = true;
            // 
            // flpButtons
            // 
            flpButtons.AutoSize = true;
            flpButtons.Controls.Add(btnDone);
            flpButtons.Controls.Add(btnRefresh);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Dock = DockStyle.Top;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(3, 796);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(1601, 46);
            flpButtons.TabIndex = 5;
            // 
            // btnDone
            // 
            btnDone.AutoSize = true;
            btnDone.BackColor = Color.CornflowerBlue;
            btnDone.FlatStyle = FlatStyle.Flat;
            btnDone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDone.Location = new Point(1489, 3);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(109, 40);
            btnDone.TabIndex = 4;
            btnDone.Text = "Hoàn tất";
            btnDone.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.FromArgb(128, 255, 255);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(1376, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 40);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.BackColor = Color.FromArgb(255, 152, 0);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(1263, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 40);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✏️ Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1148, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "🗑 Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(1033, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "➕  Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // GUI_ChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1616, 878);
            Controls.Add(flpForm);
            Name = "GUI_ChiTietPhieuNhap";
            Text = "GUI_ChiTietPhieuNhap";
            flpForm.ResumeLayout(false);
            flpForm.PerformLayout();
            flpMaPhieu.ResumeLayout(false);
            flpMaPhieu.PerformLayout();
            tlbChiTiet.ResumeLayout(false);
            tlbChiTiet.PerformLayout();
            flpTongTien.ResumeLayout(false);
            flpTongTien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTiet).EndInit();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpForm;
        private FlowLayoutPanel flpMaPhieu;
        private Label lblMaPhieuNhap;
        private TextBox txtMaPhieuNhap;
        private DataGridView dgvDsChiTiet;
        private TableLayoutPanel tlbChiTiet;
        private ComboBox cbbMatHang;
        private ComboBox cbbDVT;
        private TextBox txtSL;
        private Label lblTenMatHang;
        private Label lblDVT;
        private Label lblSL;
        private Label lblDG;
        private Label lblThanhTien;
        private FlowLayoutPanel flpTongTien;
        private Label lblTongTien;
        private TextBox txtTongTien;
        private TextBox txtDG;
        private TextBox txtThanhTien;
        private DataGridViewComboBoxColumn dgvcbbMatHang;
        private DataGridViewComboBoxColumn dgvcbbDCT;
        private DataGridViewTextBoxColumn dgvtxtSL;
        private DataGridViewTextBoxColumn dgvtxtDG;
        private DataGridViewTextBoxColumn dgvtxtThanhTien;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnDone;
    }
}