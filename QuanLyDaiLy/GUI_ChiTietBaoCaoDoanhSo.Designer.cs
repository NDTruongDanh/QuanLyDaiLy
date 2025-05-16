namespace GUI_QuanLy
{
    partial class GUI_ChiTietBaoCaoDoanhSo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMaDaiLy;
        private System.Windows.Forms.Label lblSoLuongPhieuXuat;
        private System.Windows.Forms.Label lblTongTriGia;
        private System.Windows.Forms.Label lblTiLe;
        private System.Windows.Forms.ComboBox cboMaDaiLy;
        private System.Windows.Forms.TextBox txtSoLuongPhieuXuat;
        private System.Windows.Forms.TextBox txtTongTriGia;
        private System.Windows.Forms.TextBox txtTiLe;
        private System.Windows.Forms.DataGridView dgvChiTietBaoCaoDoanhSo;
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
            lblMaDaiLy = new Label();
            lblSoLuongPhieuXuat = new Label();
            lblTongTriGia = new Label();
            lblTiLe = new Label();
            cboMaDaiLy = new ComboBox();
            txtSoLuongPhieuXuat = new TextBox();
            txtTongTriGia = new TextBox();
            txtTiLe = new TextBox();
            dgvChiTietBaoCaoDoanhSo = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietBaoCaoDoanhSo).BeginInit();
            SuspendLayout();
            // 
            // lblMaDaiLy
            // 
            lblMaDaiLy.AutoSize = true;
            lblMaDaiLy.Location = new Point(30, 70);
            lblMaDaiLy.Name = "lblMaDaiLy";
            lblMaDaiLy.Size = new Size(77, 20);
            lblMaDaiLy.TabIndex = 2;
            lblMaDaiLy.Text = "Mã Đại Lý:";
            // 
            // lblSoLuongPhieuXuat
            // 
            lblSoLuongPhieuXuat.AutoSize = true;
            lblSoLuongPhieuXuat.Location = new Point(30, 110);
            lblSoLuongPhieuXuat.Name = "lblSoLuongPhieuXuat";
            lblSoLuongPhieuXuat.Size = new Size(149, 20);
            lblSoLuongPhieuXuat.TabIndex = 4;
            lblSoLuongPhieuXuat.Text = "Số Lượng Phiếu Xuất:";
            // 
            // lblTongTriGia
            // 
            lblTongTriGia.AutoSize = true;
            lblTongTriGia.Location = new Point(30, 150);
            lblTongTriGia.Name = "lblTongTriGia";
            lblTongTriGia.Size = new Size(92, 20);
            lblTongTriGia.TabIndex = 6;
            lblTongTriGia.Text = "Tổng Trị Giá:";
            // 
            // lblTiLe
            // 
            lblTiLe.AutoSize = true;
            lblTiLe.Location = new Point(30, 190);
            lblTiLe.Name = "lblTiLe";
            lblTiLe.Size = new Size(43, 20);
            lblTiLe.TabIndex = 8;
            lblTiLe.Text = "Tỉ Lệ:";
            // 
            // cboMaDaiLy
            // 
            cboMaDaiLy.FormattingEnabled = true;
            cboMaDaiLy.Location = new Point(200, 67);
            cboMaDaiLy.Name = "cboMaDaiLy";
            cboMaDaiLy.Size = new Size(200, 28);
            cboMaDaiLy.TabIndex = 3;
            // 
            // txtSoLuongPhieuXuat
            // 
            txtSoLuongPhieuXuat.Location = new Point(200, 107);
            txtSoLuongPhieuXuat.Name = "txtSoLuongPhieuXuat";
            txtSoLuongPhieuXuat.ReadOnly = true;
            txtSoLuongPhieuXuat.Size = new Size(200, 27);
            txtSoLuongPhieuXuat.TabIndex = 5;
            // 
            // txtTongTriGia
            // 
            txtTongTriGia.Location = new Point(200, 147);
            txtTongTriGia.Name = "txtTongTriGia";
            txtTongTriGia.ReadOnly = true;
            txtTongTriGia.Size = new Size(200, 27);
            txtTongTriGia.TabIndex = 7;
            // 
            // txtTiLe
            // 
            txtTiLe.Location = new Point(200, 187);
            txtTiLe.Name = "txtTiLe";
            txtTiLe.ReadOnly = true;
            txtTiLe.Size = new Size(200, 27);
            txtTiLe.TabIndex = 9;
            // 
            // dgvChiTietBaoCaoDoanhSo
            // 
            dgvChiTietBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietBaoCaoDoanhSo.Location = new Point(30, 240);
            dgvChiTietBaoCaoDoanhSo.Name = "dgvChiTietBaoCaoDoanhSo";
            dgvChiTietBaoCaoDoanhSo.RowHeadersWidth = 51;
            dgvChiTietBaoCaoDoanhSo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietBaoCaoDoanhSo.Size = new Size(600, 150);
            dgvChiTietBaoCaoDoanhSo.TabIndex = 10;
            dgvChiTietBaoCaoDoanhSo.SelectionChanged += dgvChiTietBaoCaoDoanhSo_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(450, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(450, 80);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 35);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(450, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(450, 180);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 35);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // GUI_ChiTietBaoCaoDoanhSo
            // 
            ClientSize = new Size(680, 420);
            Controls.Add(lblMaDaiLy);
            Controls.Add(cboMaDaiLy);
            Controls.Add(lblSoLuongPhieuXuat);
            Controls.Add(txtSoLuongPhieuXuat);
            Controls.Add(lblTongTriGia);
            Controls.Add(txtTongTriGia);
            Controls.Add(lblTiLe);
            Controls.Add(txtTiLe);
            Controls.Add(dgvChiTietBaoCaoDoanhSo);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Name = "GUI_ChiTietBaoCaoDoanhSo";
            Text = "Quản Lý Chi Tiết Báo Cáo Doanh Số";
            Load += GUI_ChiTietBaoCaoDoanhSo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietBaoCaoDoanhSo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
