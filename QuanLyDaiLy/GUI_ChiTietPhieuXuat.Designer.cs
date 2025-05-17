namespace GUI_QuanLy
{
    partial class GUI_ChiTietPhieuXuat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMaMatHang;
        private System.Windows.Forms.Label lblSoLuongXuat;
        private System.Windows.Forms.Label lblDonGiaXuat;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.ComboBox cboMaMatHang;
        private System.Windows.Forms.TextBox txtSoLuongXuat;
        private System.Windows.Forms.TextBox txtDonGiaXuat;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

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
            lblMaMatHang = new Label();
            lblSoLuongXuat = new Label();
            lblDonGiaXuat = new Label();
            lblThanhTien = new Label();
            cboMaMatHang = new ComboBox();
            txtSoLuongXuat = new TextBox();
            txtDonGiaXuat = new TextBox();
            txtThanhTien = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            textBoxDaiLy = new TextBox();
            txtTraTruoc = new TextBox();
            txtConLai = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            txtTongTien = new TextBox();
            label2 = new Label();
            textBoxMaPhieuXuat = new TextBox();
            label1 = new Label();
            dateTimePickerNgayLapPhieu = new DateTimePicker();
            lblChiTietPhieuXuat = new Label();
            label4 = new Label();
            dgvChiTietPhieuXuat = new DataGridView();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            txtDonViTinh = new TextBox();
            lblThongTinDaiLy = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuXuat).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMaMatHang
            // 
            lblMaMatHang.AutoSize = true;
            lblMaMatHang.Font = new Font("Segoe UI", 12F);
            lblMaMatHang.Location = new Point(3, 0);
            lblMaMatHang.Name = "lblMaMatHang";
            lblMaMatHang.Size = new Size(125, 32);
            lblMaMatHang.TabIndex = 2;
            lblMaMatHang.Text = "Mặt Hàng:";
            // 
            // lblSoLuongXuat
            // 
            lblSoLuongXuat.AutoSize = true;
            lblSoLuongXuat.Font = new Font("Segoe UI", 12F);
            lblSoLuongXuat.Location = new Point(3, 46);
            lblSoLuongXuat.Name = "lblSoLuongXuat";
            lblSoLuongXuat.Size = new Size(175, 32);
            lblSoLuongXuat.TabIndex = 4;
            lblSoLuongXuat.Text = "Số Lượng Xuất:";
            // 
            // lblDonGiaXuat
            // 
            lblDonGiaXuat.AutoSize = true;
            lblDonGiaXuat.Font = new Font("Segoe UI", 12F);
            lblDonGiaXuat.Location = new Point(3, 136);
            lblDonGiaXuat.Name = "lblDonGiaXuat";
            lblDonGiaXuat.Size = new Size(200, 32);
            lblDonGiaXuat.TabIndex = 6;
            lblDonGiaXuat.Text = "Đơn Giá Hiện Tại:";
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.Font = new Font("Segoe UI", 12F);
            lblThanhTien.Location = new Point(3, 181);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(139, 32);
            lblThanhTien.TabIndex = 8;
            lblThanhTien.Text = "Thành Tiền:";
            // 
            // cboMaMatHang
            // 
            cboMaMatHang.Font = new Font("Segoe UI", 12F);
            cboMaMatHang.FormattingEnabled = true;
            cboMaMatHang.Location = new Point(209, 3);
            cboMaMatHang.Name = "cboMaMatHang";
            cboMaMatHang.Size = new Size(811, 40);
            cboMaMatHang.TabIndex = 3;
            // 
            // txtSoLuongXuat
            // 
            txtSoLuongXuat.Font = new Font("Segoe UI", 12F);
            txtSoLuongXuat.Location = new Point(209, 49);
            txtSoLuongXuat.Name = "txtSoLuongXuat";
            txtSoLuongXuat.Size = new Size(811, 39);
            txtSoLuongXuat.TabIndex = 5;
            // 
            // txtDonGiaXuat
            // 
            txtDonGiaXuat.Font = new Font("Segoe UI", 12F);
            txtDonGiaXuat.Location = new Point(209, 139);
            txtDonGiaXuat.Name = "txtDonGiaXuat";
            txtDonGiaXuat.ReadOnly = true;
            txtDonGiaXuat.Size = new Size(811, 39);
            txtDonGiaXuat.TabIndex = 7;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Font = new Font("Segoe UI", 12F);
            txtThanhTien.Location = new Point(209, 184);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(811, 39);
            txtThanhTien.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1117, 97);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 59);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1117, 162);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(109, 50);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1117, 218);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 70);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(lblChiTietPhieuXuat);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dgvChiTietPhieuXuat);
            panel1.Font = new Font("Segoe UI", 12F);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(1308, 451);
            panel1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label6, 0, 1);
            tableLayoutPanel2.Controls.Add(textBoxDaiLy, 1, 0);
            tableLayoutPanel2.Controls.Add(txtTraTruoc, 1, 11);
            tableLayoutPanel2.Controls.Add(txtConLai, 1, 12);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(label8, 0, 5);
            tableLayoutPanel2.Controls.Add(label3, 0, 12);
            tableLayoutPanel2.Controls.Add(txtTongTien, 1, 10);
            tableLayoutPanel2.Controls.Add(label2, 0, 11);
            tableLayoutPanel2.Controls.Add(textBoxMaPhieuXuat, 1, 5);
            tableLayoutPanel2.Controls.Add(label1, 0, 10);
            tableLayoutPanel2.Controls.Add(dateTimePickerNgayLapPhieu, 1, 1);
            tableLayoutPanel2.Location = new Point(9, 102);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 13;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.Size = new Size(493, 316);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(3, 45);
            label6.Name = "label6";
            label6.Size = new Size(181, 32);
            label6.TabIndex = 28;
            label6.Text = "Ngày Lập Phiếu";
            // 
            // textBoxDaiLy
            // 
            textBoxDaiLy.Font = new Font("Segoe UI", 12F);
            textBoxDaiLy.Location = new Point(190, 3);
            textBoxDaiLy.Name = "textBoxDaiLy";
            textBoxDaiLy.ReadOnly = true;
            textBoxDaiLy.Size = new Size(282, 39);
            textBoxDaiLy.TabIndex = 27;
            // 
            // txtTraTruoc
            // 
            txtTraTruoc.Font = new Font("Segoe UI", 12F);
            txtTraTruoc.Location = new Point(190, 183);
            txtTraTruoc.Name = "txtTraTruoc";
            txtTraTruoc.Size = new Size(282, 39);
            txtTraTruoc.TabIndex = 26;
            // 
            // txtConLai
            // 
            txtConLai.Font = new Font("Segoe UI", 12F);
            txtConLai.Location = new Point(190, 230);
            txtConLai.Name = "txtConLai";
            txtConLai.ReadOnly = true;
            txtConLai.Size = new Size(282, 39);
            txtConLai.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(83, 32);
            label7.TabIndex = 2;
            label7.Text = "Đại Lý:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(3, 90);
            label8.Name = "label8";
            label8.Size = new Size(170, 32);
            label8.TabIndex = 6;
            label8.Text = "Mã Phiếu Xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 227);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 23;
            label3.Text = "Còn lại:";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 12F);
            txtTongTien.Location = new Point(190, 138);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(282, 39);
            txtTongTien.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 180);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 22;
            label2.Text = "Trả trước:";
            // 
            // textBoxMaPhieuXuat
            // 
            textBoxMaPhieuXuat.Font = new Font("Segoe UI", 12F);
            textBoxMaPhieuXuat.Location = new Point(190, 93);
            textBoxMaPhieuXuat.Name = "textBoxMaPhieuXuat";
            textBoxMaPhieuXuat.ReadOnly = true;
            textBoxMaPhieuXuat.Size = new Size(282, 39);
            textBoxMaPhieuXuat.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 135);
            label1.Name = "label1";
            label1.Size = new Size(122, 32);
            label1.TabIndex = 21;
            label1.Text = "Tổng tiền:";
            // 
            // dateTimePickerNgayLapPhieu
            // 
            dateTimePickerNgayLapPhieu.Location = new Point(190, 48);
            dateTimePickerNgayLapPhieu.Name = "dateTimePickerNgayLapPhieu";
            dateTimePickerNgayLapPhieu.Size = new Size(282, 39);
            dateTimePickerNgayLapPhieu.TabIndex = 29;
           
            // 
            // lblChiTietPhieuXuat
            // 
            lblChiTietPhieuXuat.AutoSize = true;
            lblChiTietPhieuXuat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChiTietPhieuXuat.Location = new Point(18, 15);
            lblChiTietPhieuXuat.Name = "lblChiTietPhieuXuat";
            lblChiTietPhieuXuat.Size = new Size(466, 38);
            lblChiTietPhieuXuat.TabIndex = 16;
            lblChiTietPhieuXuat.Text = "Thông tin chi tiết phiếu xuất hàng";
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
            // dgvChiTietPhieuXuat
            // 
            dgvChiTietPhieuXuat.AllowUserToResizeColumns = false;
            dgvChiTietPhieuXuat.BackgroundColor = Color.White;
            dgvChiTietPhieuXuat.BorderStyle = BorderStyle.None;
            dgvChiTietPhieuXuat.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvChiTietPhieuXuat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiTietPhieuXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietPhieuXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvChiTietPhieuXuat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTietPhieuXuat.EnableHeadersVisualStyles = false;
            dgvChiTietPhieuXuat.GridColor = Color.White;
            dgvChiTietPhieuXuat.Location = new Point(502, 77);
            dgvChiTietPhieuXuat.Name = "dgvChiTietPhieuXuat";
            dgvChiTietPhieuXuat.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvChiTietPhieuXuat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvChiTietPhieuXuat.RowHeadersVisible = false;
            dgvChiTietPhieuXuat.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvChiTietPhieuXuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietPhieuXuat.Size = new Size(788, 341);
            dgvChiTietPhieuXuat.TabIndex = 14;
         
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(lblThongTinDaiLy);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnDelete);
            panel2.Location = new Point(12, 469);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15);
            panel2.Size = new Size(1308, 306);
            panel2.TabIndex = 28;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(cboMaMatHang, 1, 0);
            tableLayoutPanel1.Controls.Add(lblMaMatHang, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDonGiaXuat, 0, 5);
            tableLayoutPanel1.Controls.Add(lblThanhTien, 0, 6);
            tableLayoutPanel1.Controls.Add(txtDonGiaXuat, 1, 5);
            tableLayoutPanel1.Controls.Add(txtThanhTien, 1, 6);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(lblSoLuongXuat, 0, 1);
            tableLayoutPanel1.Controls.Add(txtSoLuongXuat, 1, 1);
            tableLayoutPanel1.Controls.Add(txtDonViTinh, 1, 3);
            tableLayoutPanel1.Location = new Point(42, 69);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
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
            tableLayoutPanel1.Size = new Size(1023, 226);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(3, 91);
            label9.Name = "label9";
            label9.Size = new Size(133, 32);
            label9.TabIndex = 10;
            label9.Text = "Đơn vị tính";
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Font = new Font("Segoe UI", 12F);
            txtDonViTinh.Location = new Point(209, 94);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.ReadOnly = true;
            txtDonViTinh.Size = new Size(811, 39);
            txtDonViTinh.TabIndex = 11;
            // 
            // lblThongTinDaiLy
            // 
            lblThongTinDaiLy.AutoSize = true;
            lblThongTinDaiLy.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinDaiLy.Location = new Point(9, 15);
            lblThongTinDaiLy.Name = "lblThongTinDaiLy";
            lblThongTinDaiLy.Size = new Size(427, 38);
            lblThongTinDaiLy.TabIndex = 16;
            lblThongTinDaiLy.Text = "Thông tin mặt hàng phiếu xuất";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(0, 64);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(2000, 2);
            label5.TabIndex = 15;
            // 
            // GUI_ChiTietPhieuXuat
            // 
            ClientSize = new Size(1332, 787);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GUI_ChiTietPhieuXuat";
            Text = "Quản Lý Chi Tiết Phiếu Xuất";
            Load += GUI_ChiTietPhieuXuat_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietPhieuXuat).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label lblChiTietPhieuXuat;
        private Label label4;
        private DataGridView dgvChiTietPhieuXuat;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblThongTinDaiLy;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private TextBox textBoxDaiLy;
        private Label label6;
        private TextBox txtTraTruoc;
        private TextBox txtConLai;
        private Label label8;
        private Label label3;
        private TextBox txtTongTien;
        private Label label2;
        private TextBox textBoxMaPhieuXuat;
        private Label label1;
        private Label label9;
        private TextBox txtDonViTinh;
        private DateTimePicker dateTimePickerNgayLapPhieu;
    }
}
