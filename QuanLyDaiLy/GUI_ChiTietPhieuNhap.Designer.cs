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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ChiTietPhieuNhap));
            flpForm = new FlowLayoutPanel();
            flpMaPhieu = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblMaPhieuNhap = new Label();
            txtMaPhieuNhap = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblNgayLapPhieu = new Label();
            dtpNgayLap = new DateTimePicker();
            dgvChiTietPhieuNhap = new DataGridView();
            flpTongTien = new FlowLayoutPanel();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            tblInput = new TableLayoutPanel();
            txtDonGiaNhap = new TextBox();
            lblDG = new Label();
            cbbMatHang = new ComboBox();
            txtSoLuong = new TextBox();
            txtThanhTien = new TextBox();
            lblDVT = new Label();
            lblSL = new Label();
            lblTenMatHang = new Label();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            panel1 = new Panel();
            btnEdit = new Button();
            panel2 = new Panel();
            btnDelete = new Button();
            panel3 = new Panel();
            btnRefresh = new Button();
            flpForm.SuspendLayout();
            flpMaPhieu.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).BeginInit();
            flpTongTien.SuspendLayout();
            tblInput.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // flpForm
            // 
            flpForm.Controls.Add(flpMaPhieu);
            flpForm.Controls.Add(dgvChiTietPhieuNhap);
            flpForm.Controls.Add(flpTongTien);
            flpForm.Controls.Add(tblInput);
            flpForm.Controls.Add(flpButtons);
            flpForm.Dock = DockStyle.Fill;
            flpForm.FlowDirection = FlowDirection.TopDown;
            flpForm.Location = new Point(0, 0);
            flpForm.Margin = new Padding(4, 4, 4, 4);
            flpForm.Name = "flpForm";
            flpForm.Size = new Size(1515, 923);
            flpForm.TabIndex = 0;
            // 
            // flpMaPhieu
            // 
            flpMaPhieu.AutoSize = true;
            flpMaPhieu.Controls.Add(flowLayoutPanel2);
            flpMaPhieu.Controls.Add(flowLayoutPanel1);
            flpMaPhieu.Dock = DockStyle.Top;
            flpMaPhieu.Location = new Point(12, 12);
            flpMaPhieu.Margin = new Padding(12, 12, 12, 12);
            flpMaPhieu.Name = "flpMaPhieu";
            flpMaPhieu.Size = new Size(1474, 60);
            flpMaPhieu.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(lblMaPhieuNhap);
            flowLayoutPanel2.Controls.Add(txtMaPhieuNhap);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(4, 4);
            flowLayoutPanel2.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(348, 52);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // lblMaPhieuNhap
            // 
            lblMaPhieuNhap.AutoSize = true;
            lblMaPhieuNhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaPhieuNhap.Location = new Point(4, 4);
            lblMaPhieuNhap.Margin = new Padding(4, 4, 4, 4);
            lblMaPhieuNhap.Name = "lblMaPhieuNhap";
            lblMaPhieuNhap.Size = new Size(140, 38);
            lblMaPhieuNhap.TabIndex = 1;
            lblMaPhieuNhap.Text = "Số phiếu:";
            lblMaPhieuNhap.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMaPhieuNhap
            // 
            txtMaPhieuNhap.BackColor = Color.White;
            txtMaPhieuNhap.BorderStyle = BorderStyle.None;
            txtMaPhieuNhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaPhieuNhap.Location = new Point(154, 6);
            txtMaPhieuNhap.Margin = new Padding(6, 6, 6, 6);
            txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            txtMaPhieuNhap.Size = new Size(188, 37);
            txtMaPhieuNhap.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lblNgayLapPhieu);
            flowLayoutPanel1.Controls.Add(dtpNgayLap);
            flowLayoutPanel1.Location = new Point(731, 4);
            flowLayoutPanel1.Margin = new Padding(375, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(739, 52);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // lblNgayLapPhieu
            // 
            lblNgayLapPhieu.AutoSize = true;
            lblNgayLapPhieu.Dock = DockStyle.Fill;
            lblNgayLapPhieu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNgayLapPhieu.Location = new Point(4, 0);
            lblNgayLapPhieu.Margin = new Padding(4, 0, 4, 0);
            lblNgayLapPhieu.Name = "lblNgayLapPhieu";
            lblNgayLapPhieu.Size = new Size(224, 52);
            lblNgayLapPhieu.TabIndex = 4;
            lblNgayLapPhieu.Text = "Ngày lập phiếu:";
            lblNgayLapPhieu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLap.Location = new Point(236, 4);
            dtpNgayLap.Margin = new Padding(4, 4, 4, 4);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(499, 44);
            dtpNgayLap.TabIndex = 3;
            // 
            // dgvChiTietPhieuNhap
            // 
            dgvChiTietPhieuNhap.AllowUserToResizeColumns = false;
            dgvChiTietPhieuNhap.AllowUserToResizeRows = false;
            dgvChiTietPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietPhieuNhap.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvChiTietPhieuNhap.DefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTietPhieuNhap.Dock = DockStyle.Top;
            dgvChiTietPhieuNhap.Location = new Point(12, 96);
            dgvChiTietPhieuNhap.Margin = new Padding(12, 12, 12, 12);
            dgvChiTietPhieuNhap.Name = "dgvChiTietPhieuNhap";
            dgvChiTietPhieuNhap.RowHeadersVisible = false;
            dgvChiTietPhieuNhap.RowHeadersWidth = 51;
            dgvChiTietPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietPhieuNhap.Size = new Size(1474, 464);
            dgvChiTietPhieuNhap.TabIndex = 0;
            dgvChiTietPhieuNhap.SelectionChanged += dgvChiTietPhieuNhap_SelectionChanged;
            // 
            // flpTongTien
            // 
            flpTongTien.AutoSize = true;
            flpTongTien.Controls.Add(lblTongTien);
            flpTongTien.Controls.Add(txtTongTien);
            flpTongTien.Dock = DockStyle.Right;
            flpTongTien.Location = new Point(924, 584);
            flpTongTien.Margin = new Padding(12, 12, 12, 12);
            flpTongTien.Name = "flpTongTien";
            flpTongTien.Size = new Size(562, 59);
            flpTongTien.TabIndex = 27;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Dock = DockStyle.Fill;
            lblTongTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblTongTien.Location = new Point(4, 0);
            lblTongTien.Margin = new Padding(4, 0, 4, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(172, 59);
            lblTongTien.TabIndex = 0;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            txtTongTien.Location = new Point(184, 4);
            txtTongTien.Margin = new Padding(4, 4, 4, 4);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(374, 51);
            txtTongTien.TabIndex = 1;
            txtTongTien.Text = "0";
            // 
            // tblInput
            // 
            tblInput.AutoSize = true;
            tblInput.ColumnCount = 5;
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 375F));
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.ColumnStyles.Add(new ColumnStyle());
            tblInput.Controls.Add(txtDonGiaNhap, 4, 0);
            tblInput.Controls.Add(lblDG, 3, 2);
            tblInput.Controls.Add(cbbMatHang, 1, 0);
            tblInput.Controls.Add(txtSoLuong, 1, 2);
            tblInput.Controls.Add(txtThanhTien, 4, 2);
            tblInput.Controls.Add(lblDVT, 3, 0);
            tblInput.Controls.Add(lblSL, 0, 2);
            tblInput.Controls.Add(lblTenMatHang, 0, 0);
            tblInput.Dock = DockStyle.Top;
            tblInput.Location = new Point(12, 667);
            tblInput.Margin = new Padding(12, 12, 12, 12);
            tblInput.Name = "tblInput";
            tblInput.RowCount = 5;
            tblInput.RowStyles.Add(new RowStyle());
            tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblInput.RowStyles.Add(new RowStyle());
            tblInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tblInput.RowStyles.Add(new RowStyle());
            tblInput.Size = new Size(1474, 140);
            tblInput.TabIndex = 32;
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(1046, 4);
            txtDonGiaNhap.Margin = new Padding(4, 4, 4, 4);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(249, 31);
            txtDonGiaNhap.TabIndex = 10;
            txtDonGiaNhap.Text = "0";
            txtDonGiaNhap.TextChanged += txtDonGiaNhap_TextChanged;
            txtDonGiaNhap.KeyPress += txtDonGiaNhap_KeyPress;
            // 
            // lblDG
            // 
            lblDG.AutoSize = true;
            lblDG.Dock = DockStyle.Right;
            lblDG.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDG.Location = new Point(851, 70);
            lblDG.Margin = new Padding(4, 0, 4, 0);
            lblDG.Name = "lblDG";
            lblDG.Size = new Size(187, 45);
            lblDG.TabIndex = 6;
            lblDG.Text = "Thành tiền:";
            lblDG.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbbMatHang
            // 
            cbbMatHang.FormattingEnabled = true;
            cbbMatHang.Location = new Point(184, 4);
            cbbMatHang.Margin = new Padding(4, 4, 4, 4);
            cbbMatHang.Name = "cbbMatHang";
            cbbMatHang.Size = new Size(249, 33);
            cbbMatHang.TabIndex = 0;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(184, 74);
            txtSoLuong.Margin = new Padding(4, 4, 4, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(249, 31);
            txtSoLuong.TabIndex = 1;
            txtSoLuong.Text = "1";
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(1046, 74);
            txtThanhTien.Margin = new Padding(4, 4, 4, 4);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(249, 31);
            txtThanhTien.TabIndex = 8;
            txtThanhTien.Text = "0";
            // 
            // lblDVT
            // 
            lblDVT.AutoSize = true;
            lblDVT.Dock = DockStyle.Right;
            lblDVT.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDVT.Location = new Point(816, 0);
            lblDVT.Margin = new Padding(4, 0, 4, 0);
            lblDVT.Name = "lblDVT";
            lblDVT.Size = new Size(222, 45);
            lblDVT.TabIndex = 4;
            lblDVT.Text = "Đơn giá nhập";
            lblDVT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSL
            // 
            lblSL.AutoSize = true;
            lblSL.Dock = DockStyle.Right;
            lblSL.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSL.Location = new Point(12, 70);
            lblSL.Margin = new Padding(4, 0, 4, 0);
            lblSL.Name = "lblSL";
            lblSL.Size = new Size(164, 45);
            lblSL.TabIndex = 5;
            lblSL.Text = "Số lượng:";
            lblSL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenMatHang
            // 
            lblTenMatHang.AutoSize = true;
            lblTenMatHang.Dock = DockStyle.Right;
            lblTenMatHang.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenMatHang.Location = new Point(4, 0);
            lblTenMatHang.Margin = new Padding(4, 0, 4, 0);
            lblTenMatHang.Name = "lblTenMatHang";
            lblTenMatHang.Size = new Size(172, 45);
            lblTenMatHang.TabIndex = 3;
            lblTenMatHang.Text = "Mặt hàng:";
            lblTenMatHang.TextAlign = ContentAlignment.MiddleCenter;
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
            flpButtons.Controls.Add(btnRefresh);
            flpButtons.Dock = DockStyle.Right;
            flpButtons.Location = new Point(701, 831);
            flpButtons.Margin = new Padding(12, 12, 12, 12);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(785, 63);
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
            btnAdd.Location = new Point(4, 4);
            btnAdd.Margin = new Padding(4, 4, 4, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 55);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(172, 4);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(25, 25);
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
            btnEdit.Location = new Point(205, 4);
            btnEdit.Margin = new Padding(4, 4, 4, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(160, 55);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(373, 4);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(25, 25);
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
            btnDelete.Location = new Point(406, 4);
            btnDelete.Margin = new Padding(4, 4, 4, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 55);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(574, 4);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(25, 25);
            panel3.TabIndex = 26;
            // 
            // btnRefresh
            // 
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.FromArgb(33, 150, 243);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 12F);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(607, 4);
            btnRefresh.Margin = new Padding(4, 4, 4, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(174, 55);
            btnRefresh.TabIndex = 23;
            btnRefresh.Text = "   Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // GUI_ChiTietPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1515, 923);
            Controls.Add(flpForm);
            Margin = new Padding(4, 4, 4, 4);
            Name = "GUI_ChiTietPhieuNhap";
            Text = "GUI_ChiTietPhieuNhap";
            Load += GUI_ChiTietPhieuNhap_Load;
            flpForm.ResumeLayout(false);
            flpForm.PerformLayout();
            flpMaPhieu.ResumeLayout(false);
            flpMaPhieu.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuNhap).EndInit();
            flpTongTien.ResumeLayout(false);
            flpTongTien.PerformLayout();
            tblInput.ResumeLayout(false);
            tblInput.PerformLayout();
            flpButtons.ResumeLayout(false);
            flpButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpForm;
        private FlowLayoutPanel flpMaPhieu;
        private Label lblMaPhieuNhap;
        private TextBox txtMaPhieuNhap;
        private DataGridView dgvChiTietPhieuNhap;
        private ComboBox cbbMatHang;
        private TextBox txtSoLuong;
        private Label lblTenMatHang;
        private Label lblDVT;
        private Label lblSL;
        private Label lblDG;
        private TextBox txtThanhTien;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lblNgayLapPhieu;
        private DateTimePicker dtpNgayLap;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Panel panel1;
        private Button btnEdit;
        private Panel panel2;
        private Button btnDelete;
        private Panel panel3;
        private Button btnRefresh;
        private FlowLayoutPanel flpTongTien;
        private Label lblTongTien;
        private TextBox txtTongTien;
        private TableLayoutPanel tblInput;
        private TextBox txtDonGiaNhap;
    }
}