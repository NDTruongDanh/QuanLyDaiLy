namespace GUI_QuanLy
{
    partial class GUI_ChiTietPhieuNhap
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.TextBox txtMaSoPhieu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblNgayLapPhieu;
        private System.Windows.Forms.Label lblMaSoPhieu;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbbMaMatHang;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbbDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtThanhTien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtpNgayLapPhieu = new DateTimePicker();
            txtMaSoPhieu = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            lblMaSoPhieu = new Label();
            lblNgayLapPhieu = new Label();
            lblLine = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            cbbMaMatHang = new DataGridViewComboBoxColumn();
            cbbDonGia = new DataGridViewComboBoxColumn();
            txtSoLuong = new DataGridViewTextBoxColumn();
            txtThanhTien = new DataGridViewTextBoxColumn();
            flowLayoutPanel2 = new FlowLayoutPanel();
            txtTongTien = new TextBox();
            lblTongTien = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // dtpNgayLapPhieu
            // 
            dtpNgayLapPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayLapPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLapPhieu.Location = new Point(623, 25);
            dtpNgayLapPhieu.Margin = new Padding(3, 25, 3, 3);
            dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            dtpNgayLapPhieu.Size = new Size(379, 39);
            dtpNgayLapPhieu.TabIndex = 1;
            // 
            // txtMaSoPhieu
            // 
            txtMaSoPhieu.AllowDrop = true;
            txtMaSoPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMaSoPhieu.BackColor = SystemColors.Window;
            txtMaSoPhieu.Location = new Point(180, 35);
            txtMaSoPhieu.Margin = new Padding(2, 35, 2, 2);
            txtMaSoPhieu.Name = "txtMaSoPhieu";
            txtMaSoPhieu.Size = new Size(153, 31);
            txtMaSoPhieu.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightGray;
            btnThem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(160, 50);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.IndianRed;
            btnXoa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(169, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(160, 50);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(335, 3);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(160, 50);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // lblMaSoPhieu
            // 
            lblMaSoPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMaSoPhieu.AutoSize = true;
            lblMaSoPhieu.BackColor = Color.Transparent;
            lblMaSoPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMaSoPhieu.Location = new Point(2, 2);
            lblMaSoPhieu.Margin = new Padding(2);
            lblMaSoPhieu.Name = "lblMaSoPhieu";
            lblMaSoPhieu.Size = new Size(174, 83);
            lblMaSoPhieu.TabIndex = 0;
            lblMaSoPhieu.Text = "Mã số phiếu";
            lblMaSoPhieu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgayLapPhieu
            // 
            lblNgayLapPhieu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNgayLapPhieu.BackColor = Color.Transparent;
            lblNgayLapPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNgayLapPhieu.Location = new Point(408, 2);
            lblNgayLapPhieu.Margin = new Padding(2);
            lblNgayLapPhieu.Name = "lblNgayLapPhieu";
            lblNgayLapPhieu.Size = new Size(210, 83);
            lblNgayLapPhieu.TabIndex = 2;
            lblNgayLapPhieu.Text = "Ngày lập phiếu";
            lblNgayLapPhieu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLine
            // 
            lblLine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLine.AutoSize = true;
            lblLine.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLine.ForeColor = Color.Silver;
            lblLine.Location = new Point(338, 3);
            lblLine.Margin = new Padding(3);
            lblLine.Name = "lblLine";
            lblLine.Size = new Size(65, 81);
            lblLine.TabIndex = 11;
            lblLine.Text = "l";
            lblLine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.7458F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.70743F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.086614F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.37233F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.00959F));
            tableLayoutPanel2.Controls.Add(dtpNgayLapPhieu, 4, 0);
            tableLayoutPanel2.Controls.Add(txtMaSoPhieu, 1, 0);
            tableLayoutPanel2.Controls.Add(lblLine, 2, 0);
            tableLayoutPanel2.Controls.Add(lblNgayLapPhieu, 3, 0);
            tableLayoutPanel2.Controls.Add(lblMaSoPhieu, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1005, 87);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1011, 406);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { STT, cbbMaMatHang, cbbDonGia, txtSoLuong, txtThanhTien });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(3, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1005, 307);
            dataGridView1.TabIndex = 14;
            // 
            // STT
            // 
            STT.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            STT.HeaderText = "STT";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            STT.Resizable = DataGridViewTriState.False;
            STT.Width = 76;
            // 
            // cbbMaMatHang
            // 
            cbbMaMatHang.HeaderText = "Mã Mặt Hàng";
            cbbMaMatHang.MinimumWidth = 6;
            cbbMaMatHang.Name = "cbbMaMatHang";
            cbbMaMatHang.Resizable = DataGridViewTriState.False;
            // 
            // cbbDonGia
            // 
            cbbDonGia.HeaderText = "Đơn Giá";
            cbbDonGia.MinimumWidth = 6;
            cbbDonGia.Name = "cbbDonGia";
            cbbDonGia.Resizable = DataGridViewTriState.False;
            // 
            // txtSoLuong
            // 
            txtSoLuong.HeaderText = "Số Lượng";
            txtSoLuong.MinimumWidth = 6;
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Resizable = DataGridViewTriState.False;
            // 
            // txtThanhTien
            // 
            txtThanhTien.HeaderText = "Thành Tiền";
            txtThanhTien.MinimumWidth = 6;
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Resizable = DataGridViewTriState.False;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(txtTongTien);
            flowLayoutPanel2.Controls.Add(lblTongTien);
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(812, 424);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(233, 56);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTongTien.Location = new Point(130, 15);
            txtTongTien.Margin = new Padding(3, 15, 3, 3);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(100, 35);
            txtTongTien.TabIndex = 6;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(5, 12);
            lblTongTien.Margin = new Padding(5, 12, 5, 5);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(117, 32);
            lblTongTien.TabIndex = 5;
            lblTongTien.Text = "Tổng tiền";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(btnThem);
            flowLayoutPanel3.Controls.Add(btnXoa);
            flowLayoutPanel3.Controls.Add(btnThoat);
            flowLayoutPanel3.Location = new Point(12, 424);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(498, 56);
            flowLayoutPanel3.TabIndex = 15;
            // 
            // GUI_ChiTietPhieuNhap
            // 
            ClientSize = new Size(1032, 489);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "GUI_ChiTietPhieuNhap";
            Text = "Quản Lý Chi Tiết Phiếu Nhập";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
