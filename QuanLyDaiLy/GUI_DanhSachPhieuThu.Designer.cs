namespace GUI_QuanLy
{
    partial class GUI_DanhSachPhieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DanhSachPhieuThu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel5 = new Panel();
            btnDelete = new Button();
            button5 = new Button();
            panel1 = new Panel();
            lblDanhSachPhieuThu = new Label();
            label2 = new Label();
            dgvDanhSachPhieuThu = new DataGridView();
            label4 = new Label();
            lblThongTinPhieuThu = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblDiaChi = new Label();
            txtSoTienThu = new TextBox();
            lblSoTienThu = new Label();
            dtpNgayThuTien = new DateTimePicker();
            lblNgayThuTien = new Label();
            txtDiaChi = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTenDaiLy = new Label();
            panel4 = new Panel();
            btnEdit = new Button();
            button3 = new Button();
            txtTenDaiLy = new TextBox();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieuThu).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(button5);
            panel5.Location = new Point(1064, 100);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 25, 0, 0);
            panel5.Size = new Size(228, 85);
            panel5.TabIndex = 22;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(-53, -55);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(38, 0, 0, 0);
            btnDelete.Size = new Size(300, 195);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(44, 62, 80);
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-15, -54);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Padding = new Padding(38, 0, 0, 0);
            button5.Size = new Size(325, 195);
            button5.TabIndex = 1;
            button5.Text = "       Phiếu nhập hàng ";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblDanhSachPhieuThu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dgvDanhSachPhieuThu);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(1308, 307);
            panel1.TabIndex = 23;
            // 
            // lblDanhSachPhieuThu
            // 
            lblDanhSachPhieuThu.AutoSize = true;
            lblDanhSachPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachPhieuThu.Location = new Point(27, 26);
            lblDanhSachPhieuThu.Name = "lblDanhSachPhieuThu";
            lblDanhSachPhieuThu.Size = new Size(287, 38);
            lblDanhSachPhieuThu.TabIndex = 16;
            lblDanhSachPhieuThu.Text = "Danh sách phiếu thu";
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
            // dgvDanhSachPhieuThu
            // 
            dgvDanhSachPhieuThu.AllowUserToResizeColumns = false;
            dgvDanhSachPhieuThu.BackgroundColor = Color.White;
            dgvDanhSachPhieuThu.BorderStyle = BorderStyle.None;
            dgvDanhSachPhieuThu.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvDanhSachPhieuThu.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDanhSachPhieuThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhSachPhieuThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDanhSachPhieuThu.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhSachPhieuThu.EnableHeadersVisualStyles = false;
            dgvDanhSachPhieuThu.GridColor = Color.White;
            dgvDanhSachPhieuThu.Location = new Point(15, 83);
            dgvDanhSachPhieuThu.Name = "dgvDanhSachPhieuThu";
            dgvDanhSachPhieuThu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDanhSachPhieuThu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSachPhieuThu.RowHeadersVisible = false;
            dgvDanhSachPhieuThu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDanhSachPhieuThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachPhieuThu.Size = new Size(1275, 206);
            dgvDanhSachPhieuThu.TabIndex = 14;
            dgvDanhSachPhieuThu.CellContentClick += dgvDanhSachPhieuThu_CellContentClick;
            dgvDanhSachPhieuThu.SelectionChanged += dgvDanhSachPhieuThu_SelectionChanged;
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
            // lblThongTinPhieuThu
            // 
            lblThongTinPhieuThu.AutoSize = true;
            lblThongTinPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinPhieuThu.Location = new Point(27, 26);
            lblThongTinPhieuThu.Name = "lblThongTinPhieuThu";
            lblThongTinPhieuThu.Size = new Size(280, 38);
            lblThongTinPhieuThu.TabIndex = 16;
            lblThongTinPhieuThu.Text = "Thông tin phiếu thu";
            lblThongTinPhieuThu.Click += lblThongTinDaiLy_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(lblThongTinPhieuThu);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 338);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15);
            panel2.Size = new Size(1308, 437);
            panel2.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
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
            tableLayoutPanel1.Location = new Point(59, 100);
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
            tableLayoutPanel1.Size = new Size(983, 317);
            tableLayoutPanel1.TabIndex = 20;
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
            // txtSoTienThu
            // 
            txtSoTienThu.Font = new Font("Segoe UI", 12F);
            txtSoTienThu.Location = new Point(185, 228);
            txtSoTienThu.Name = "txtSoTienThu";
            txtSoTienThu.Size = new Size(795, 39);
            txtSoTienThu.TabIndex = 5;
            // 
            // lblSoTienThu
            // 
            lblSoTienThu.AutoSize = true;
            lblSoTienThu.Font = new Font("Segoe UI", 12F);
            lblSoTienThu.Location = new Point(3, 225);
            lblSoTienThu.Name = "lblSoTienThu";
            lblSoTienThu.Size = new Size(147, 32);
            lblSoTienThu.TabIndex = 4;
            lblSoTienThu.Text = "Số Tiền Thu:";
            // 
            // dtpNgayThuTien
            // 
            dtpNgayThuTien.Font = new Font("Segoe UI", 12F);
            dtpNgayThuTien.Location = new Point(185, 183);
            dtpNgayThuTien.Name = "dtpNgayThuTien";
            dtpNgayThuTien.Size = new Size(795, 39);
            dtpNgayThuTien.TabIndex = 3;
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
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F);
            txtDiaChi.Location = new Point(185, 48);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(795, 39);
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
            txtSDT.Font = new Font("Segoe UI", 12F);
            txtSDT.Location = new Point(185, 93);
            txtSDT.Name = "txtSDT";
            txtSDT.ReadOnly = true;
            txtSDT.Size = new Size(795, 39);
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
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(185, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(795, 39);
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
            // panel4
            // 
            panel4.Controls.Add(btnEdit);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(1064, 193);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 25, 0, 0);
            panel4.Size = new Size(228, 85);
            panel4.TabIndex = 23;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(44, 52, 80);
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(-53, -55);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(38, 0, 0, 0);
            btnEdit.Size = new Size(300, 195);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(44, 62, 80);
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-15, -54);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Padding = new Padding(38, 0, 0, 0);
            button3.Size = new Size(325, 195);
            button3.TabIndex = 1;
            button3.Text = "       Phiếu nhập hàng ";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // txtTenDaiLy
            // 
            txtTenDaiLy.Font = new Font("Segoe UI", 12F);
            txtTenDaiLy.Location = new Point(185, 3);
            txtTenDaiLy.Name = "txtTenDaiLy";
            txtTenDaiLy.ReadOnly = true;
            txtTenDaiLy.Size = new Size(795, 39);
            txtTenDaiLy.TabIndex = 7;
            // 
            // GUI_DanhSachPhieuThu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 787);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GUI_DanhSachPhieuThu";
            Text = "GUI_DanhSachPhieuThu";
            Load += GUI_DanhSachPhieuThu_Load;
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachPhieuThu).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel5;
        private Button btnDelete;
        private Button button5;
        private Panel panel1;
        private Label lblDanhSachPhieuThu;
        private Label label2;
        private DataGridView dgvDanhSachPhieuThu;
        private Label label4;
        private Label lblThongTinPhieuThu;
        private Panel panel2;
        private Panel panel4;
        private Button btnEdit;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDiaChi;
        private TextBox txtSoTienThu;
        private Label lblSoTienThu;
        private DateTimePicker dtpNgayThuTien;
        private Label lblNgayThuTien;
        private TextBox txtDiaChi;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTenDaiLy;
        private TextBox txtTenDaiLy;
    }
}