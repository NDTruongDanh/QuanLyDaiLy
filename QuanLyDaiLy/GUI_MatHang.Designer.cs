namespace GUI_QuanLy
{
    partial class GUI_MatHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenMatHang;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblDonGiaHienTai;
        private System.Windows.Forms.Label lblTonKho;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.TextBox txtDonGiaHienTai;
        private System.Windows.Forms.TextBox txtTonKho;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTenMatHang = new Label();
            lblDonViTinh = new Label();
            lblDonGiaHienTai = new Label();
            lblTonKho = new Label();
            txtTenMatHang = new TextBox();
            txtDonGiaHienTai = new TextBox();
            txtTonKho = new TextBox();
            cboDonViTinh = new ComboBox();
            dgvMatHang = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMatHang).BeginInit();
            SuspendLayout();
            // 
            // lblTenMatHang
            // 
            lblTenMatHang.AutoSize = true;
            lblTenMatHang.Location = new Point(30, 30);
            lblTenMatHang.Name = "lblTenMatHang";
            lblTenMatHang.Size = new Size(105, 20);
            lblTenMatHang.TabIndex = 0;
            lblTenMatHang.Text = "Tên Mặt Hàng:";
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Location = new Point(30, 70);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new Size(89, 20);
            lblDonViTinh.TabIndex = 1;
            lblDonViTinh.Text = "Đơn Vị Tính:";
            // 
            // lblDonGiaHienTai
            // 
            lblDonGiaHienTai.AutoSize = true;
            lblDonGiaHienTai.Location = new Point(30, 110);
            lblDonGiaHienTai.Name = "lblDonGiaHienTai";
            lblDonGiaHienTai.Size = new Size(125, 20);
            lblDonGiaHienTai.TabIndex = 2;
            lblDonGiaHienTai.Text = "Đơn Giá Hiện Tại:";
            // 
            // lblTonKho
            // 
            lblTonKho.AutoSize = true;
            lblTonKho.Location = new Point(30, 150);
            lblTonKho.Name = "lblTonKho";
            lblTonKho.Size = new Size(67, 20);
            lblTonKho.TabIndex = 3;
            lblTonKho.Text = "Tồn Kho:";
            // 
            // txtTenMatHang
            // 
            txtTenMatHang.Location = new Point(180, 27);
            txtTenMatHang.Name = "txtTenMatHang";
            txtTenMatHang.Size = new Size(200, 27);
            txtTenMatHang.TabIndex = 4;
            // 
            // txtDonGiaHienTai
            // 
            txtDonGiaHienTai.Location = new Point(180, 107);
            txtDonGiaHienTai.Name = "txtDonGiaHienTai";
            txtDonGiaHienTai.Size = new Size(200, 27);
            txtDonGiaHienTai.TabIndex = 6;
            // 
            // txtTonKho
            // 
            txtTonKho.Location = new Point(180, 147);
            txtTonKho.Name = "txtTonKho";
            txtTonKho.Size = new Size(200, 27);
            txtTonKho.TabIndex = 7;
            // 
            // cboDonViTinh
            // 
            cboDonViTinh.FormattingEnabled = true;
            cboDonViTinh.Location = new Point(180, 67);
            cboDonViTinh.Name = "cboDonViTinh";
            cboDonViTinh.Size = new Size(200, 28);
            cboDonViTinh.TabIndex = 5;
            // 
            // dgvMatHang
            // 
            dgvMatHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatHang.Location = new Point(30, 200);
            dgvMatHang.Name = "dgvMatHang";
            dgvMatHang.RowHeadersWidth = 51;
            dgvMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMatHang.Size = new Size(600, 200);
            dgvMatHang.TabIndex = 8;
            dgvMatHang.SelectionChanged += dgvMatHang_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(450, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 28);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(450, 70);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 28);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(450, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 28);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(450, 150);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 28);
            btnExit.TabIndex = 12;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // GUI_MatHang
            // 
            ClientSize = new Size(680, 430);
            Controls.Add(lblTenMatHang);
            Controls.Add(txtTenMatHang);
            Controls.Add(lblDonViTinh);
            Controls.Add(cboDonViTinh);
            Controls.Add(lblDonGiaHienTai);
            Controls.Add(txtDonGiaHienTai);
            Controls.Add(lblTonKho);
            Controls.Add(txtTonKho);
            Controls.Add(dgvMatHang);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Name = "GUI_MatHang";
            Text = "Quản lý Mặt Hàng";
            Load += GUI_MatHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMatHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
