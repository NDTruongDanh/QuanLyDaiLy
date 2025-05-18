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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ChiTietPhieuNhap));
            flpForm = new FlowLayoutPanel();
            flpMaPhieu = new FlowLayoutPanel();
            lblMaPhieuNhap = new Label();
            txtMaPhieuNhap = new TextBox();
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
            dgvDsChiTiet = new DataGridView();
            dtpNgayLap = new DateTimePicker();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblNgayLapPhieu = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flpButtons = new FlowLayoutPanel();
            btnCTPN = new Button();
            panel1 = new Panel();
            btnEdit = new Button();
            panel2 = new Panel();
            btnDelete = new Button();
            panel3 = new Panel();
            btnFind = new Button();
            dgvtxtMatHang = new DataGridViewTextBoxColumn();
            dgvtxtDCT = new DataGridViewTextBoxColumn();
            dgvtxtSL = new DataGridViewTextBoxColumn();
            dgvtxtDG = new DataGridViewTextBoxColumn();
            dgvtxtThanhTien = new DataGridViewTextBoxColumn();
            flpTongTien = new FlowLayoutPanel();
            lblTongTien = new Label();
            textBox1 = new TextBox();
            tblInput = new TableLayoutPanel();
            flpForm.SuspendLayout();
            flpMaPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTiet).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flpButtons.SuspendLayout();
            flpTongTien.SuspendLayout();
            tblInput.SuspendLayout();
            SuspendLayout();
            // 
            // flpForm
            // 
            flpForm.Controls.Add(flpMaPhieu);
            flpForm.Controls.Add(dgvDsChiTiet);
            flpForm.Controls.Add(flpTongTien);
            flpForm.Controls.Add(tblInput);
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
            flpMaPhieu.Controls.Add(flowLayoutPanel2);
            flpMaPhieu.Controls.Add(flowLayoutPanel1);
            flpMaPhieu.Dock = DockStyle.Top;
            flpMaPhieu.Location = new Point(10, 10);
            flpMaPhieu.Margin = new Padding(10);
            flpMaPhieu.Name = "flpMaPhieu";
            flpMaPhieu.Size = new Size(1183, 50);
            flpMaPhieu.TabIndex = 3;
            // 
            // lblMaPhieuNhap
            // 
            lblMaPhieuNhap.AutoSize = true;
            lblMaPhieuNhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaPhieuNhap.Location = new Point(3, 3);
            lblMaPhieuNhap.Margin = new Padding(3);
            lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            lblMaPhieuNhap.Size = new Size(114, 31);
            lblMaPhieuNhap.TabIndex = 1;
            lblMaPhieuNhap.Text = "Số phiếu:";
            lblMaPhieuNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.BackColor = Color.White;
            txtMaPhieuNhap.BorderStyle = BorderStyle.None;
            txtMaPhieuNhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaPhieuNhap.Location = new Point(125, 5);
            txtMaPhieuNhap.Margin = new Padding(5);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.Size = new Size(150, 31);
            txtMaPhieuNhap.TabIndex = 2;
            // 
            // cbbMatHang
            // 
            cbbMatHang.FormattingEnabled = true;
            cbbMatHang.Location = new Point(206, 3);
            cbbMatHang.Name = "cbbMatHang";
            cbbMatHang.Size = new Size(200, 28);
            cbbMatHang.TabIndex = 0;
            // 
            // cbbDVT
            // 
            cbbDVT.FormattingEnabled = true;
            cbbDVT.Location = new Point(929, 3);
            cbbDVT.Name = "cbbDVT";
            cbbDVT.Size = new Size(200, 28);
            cbbDVT.TabIndex = 2;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(206, 61);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(200, 27);
            txtSL.TabIndex = 1;
            // 
            // lblTenMatHang
            // 
            lblTenMatHang.AutoSize = true;
            lblTenMatHang.Dock = DockStyle.Right;
            lblTenMatHang.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenMatHang.Location = new Point(3, 0);
            lblTenMatHang.Name = "lblTenMatHang";
            lblTenMatHang.Size = new Size(197, 38);
            lblTenMatHang.TabIndex = 3;
            lblTenMatHang.Text = "Tên mặt hàng:";
            lblTenMatHang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDVT
            // 
            lblDVT.AutoSize = true;
            lblDVT.Dock = DockStyle.Right;
            lblDVT.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDVT.Location = new Point(712, 0);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new Size(211, 38);
            lblDVT.TabIndex = 4;
            lblDVT.Text = "Tên đơn vị tính:";
            lblDVT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSL
            // 
            lblSL.AutoSize = true;
            lblSL.Dock = DockStyle.Right;
            lblSL.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSL.Location = new Point(62, 58);
            lblSL.Name = "lblSL";
            lblSL.Size = new Size(138, 38);
            lblSL.TabIndex = 5;
            lblSL.Text = "Số lượng:";
            lblSL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDG
            // 
            lblDG.AutoSize = true;
            lblDG.Dock = DockStyle.Right;
            lblDG.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDG.Location = new Point(799, 58);
            lblDG.Name = "lblDG";
            lblDG.Size = new Size(124, 38);
            lblDG.TabIndex = 6;
            lblDG.Text = "Đơn giá:";
            lblDG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Dock = DockStyle.Right;
            lblThanhTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThanhTien.Location = new Point(42, 116);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(158, 38);
            lblThanhTien.TabIndex = 7;
            lblThanhTien.Text = "Thành tiền:";
            lblThanhTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDG
            // 
            txtDG.Location = new Point(929, 61);
            txtDG.Name = "txtDG";
            txtDG.Size = new Size(200, 27);
            txtDG.TabIndex = 8;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(206, 119);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(200, 27);
            txtThanhTien.TabIndex = 9;
            // 
            // dgvDsChiTiet
            // 
            dgvDsChiTiet.AllowUserToResizeColumns = false;
            dgvDsChiTiet.AllowUserToResizeRows = false;
            dgvDsChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDsChiTiet.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDsChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvDsChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDsChiTiet.Columns.AddRange(new DataGridViewColumn[] { dgvtxtMatHang, dgvtxtDCT, dgvtxtSL, dgvtxtDG, dgvtxtThanhTien });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvDsChiTiet.DefaultCellStyle = dataGridViewCellStyle8;
            dgvDsChiTiet.Dock = DockStyle.Top;
            dgvDsChiTiet.Location = new Point(10, 80);
            dgvDsChiTiet.Margin = new Padding(10);
            dgvDsChiTiet.Name = "dgvDsChiTiet";
            dgvDsChiTiet.RowHeadersVisible = false;
            dgvDsChiTiet.RowHeadersWidth = 51;
            dgvDsChiTiet.Size = new Size(1183, 371);
            dgvDsChiTiet.TabIndex = 0;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLap.Location = new Point(191, 3);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(400, 38);
            dtpNgayLap.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lblNgayLapPhieu);
            flowLayoutPanel1.Controls.Add(dtpNgayLap);
            flowLayoutPanel1.Location = new Point(586, 3);
            flowLayoutPanel1.Margin = new Padding(300, 3, 3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(594, 44);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // lblNgayLapPhieu
            // 
            lblNgayLapPhieu.AutoSize = true;
            lblNgayLapPhieu.Dock = DockStyle.Fill;
            lblNgayLapPhieu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNgayLapPhieu.Location = new Point(3, 0);
            lblNgayLapPhieu.Name = "lblNgayLapPhieu";
            lblNgayLapPhieu.Size = new Size(182, 44);
            lblNgayLapPhieu.TabIndex = 4;
            lblNgayLapPhieu.Text = "Ngày lập phiếu:";
            lblNgayLapPhieu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(lblMaPhieuNhap);
            flowLayoutPanel2.Controls.Add(txtMaPhieuNhap);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(280, 44);
            flowLayoutPanel2.TabIndex = 5;
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
            flpButtons.Location = new Point(579, 714);
            flpButtons.Margin = new Padding(10);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(614, 50);
            flpButtons.TabIndex = 30;
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
            // dgvtxtMatHang
            // 
            dgvtxtMatHang.HeaderText = "Tên Mặt Hàng";
            dgvtxtMatHang.MinimumWidth = 6;
            dgvtxtMatHang.Name = "dgvtxtMatHang";
            dgvtxtMatHang.ReadOnly = true;
            dgvtxtMatHang.Resizable = DataGridViewTriState.True;
            dgvtxtMatHang.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDCT
            // 
            dgvtxtDCT.HeaderText = "Đơn Vị Tính";
            dgvtxtDCT.MinimumWidth = 6;
            dgvtxtDCT.Name = "dgvtxtDCT";
            dgvtxtDCT.ReadOnly = true;
            dgvtxtDCT.Resizable = DataGridViewTriState.True;
            dgvtxtDCT.SortMode = DataGridViewColumnSortMode.NotSortable;
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
            // flpTongTien
            // 
            flpTongTien.AutoSize = true;
            flpTongTien.Controls.Add(lblTongTien);
            flpTongTien.Controls.Add(textBox1);
            flpTongTien.Dock = DockStyle.Right;
            flpTongTien.Location = new Point(743, 471);
            flpTongTien.Margin = new Padding(10);
            flpTongTien.Name = "flpTongTien";
            flpTongTien.Size = new Size(450, 49);
            flpTongTien.TabIndex = 27;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Dock = DockStyle.Fill;
            lblTongTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblTongTien.Location = new Point(3, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(138, 49);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            textBox1.Location = new Point(147, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(300, 43);
            textBox1.TabIndex = 1;
            // 
            // tblInput
            // 
            tblInput.AutoSize = true;
            tblInput.ColumnCount = 5;
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.Controls.Add(lblDG, 3, 2);
            tblInput.Controls.Add(cbbMatHang, 1, 0);
            tblInput.Controls.Add(txtSL, 1, 2);
            tblInput.Controls.Add(txtThanhTien, 1, 4);
            tblInput.Controls.Add(txtDG, 4, 2);
            tblInput.Controls.Add(cbbDVT, 4, 0);
            tblInput.Controls.Add(lblDVT, 3, 0);
            tblInput.Controls.Add(lblThanhTien, 0, 4);
            tblInput.Controls.Add(lblSL, 0, 2);
            tblInput.Controls.Add(lblTenMatHang, 0, 0);
            tblInput.Dock = DockStyle.Top;
            tblInput.Location = new Point(10, 540);
            tblInput.Margin = new Padding(10);
            tblInput.Name = "tblInput";
            tblInput.RowCount = 5;
            tblInput.RowStyles.Add(new RowStyle());
            tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblInput.RowStyles.Add(new RowStyle());
            tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblInput.RowStyles.Add(new RowStyle());
            tblInput.Size = new Size(1183, 154);
            tblInput.TabIndex = 32;
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
            ((System.ComponentModel.ISupportInitialize)dgvDsChiTiet).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            flpTongTien.ResumeLayout(false);
            flpTongTien.PerformLayout();
            tblInput.ResumeLayout(false);
            tblInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpForm;
        private FlowLayoutPanel flpMaPhieu;
        private Label lblMaPhieuNhap;
        private TextBox txtMaPhieuNhap;
        private DataGridView dgvDsChiTiet;
        private ComboBox cbbMatHang;
        private ComboBox cbbDVT;
        private TextBox txtSL;
        private Label lblTenMatHang;
        private Label lblDVT;
        private Label lblSL;
        private Label lblDG;
        private Label lblThanhTien;
        private TextBox txtDG;
        private TextBox txtThanhTien;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblNgayLapPhieu;
        private DateTimePicker dtpNgayLap;
        private FlowLayoutPanel flpButtons;
        private Button btnCTPN;
        private Panel panel1;
        private Button btnEdit;
        private Panel panel2;
        private Button btnDelete;
        private Panel panel3;
        private Button btnFind;
        private DataGridViewTextBoxColumn dgvtxtMatHang;
        private DataGridViewTextBoxColumn dgvtxtDCT;
        private DataGridViewTextBoxColumn dgvtxtSL;
        private DataGridViewTextBoxColumn dgvtxtDG;
        private DataGridViewTextBoxColumn dgvtxtThanhTien;
        private FlowLayoutPanel flpTongTien;
        private Label lblTongTien;
        private TextBox textBox1;
        private TableLayoutPanel tblInput;
    }
}