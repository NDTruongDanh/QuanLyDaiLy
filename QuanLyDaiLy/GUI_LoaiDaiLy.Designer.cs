namespace GUI_QuanLy
{
    partial class GUI_LoaiDaiLy
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.Label lblTienNo;
        private System.Windows.Forms.TextBox txtTenLoaiDaiLy;
        private System.Windows.Forms.TextBox txtTienNoToiDa;
        private System.Windows.Forms.DataGridView dgvLoaiDaiLy;
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
            lblTenLoai = new Label();
            lblTienNo = new Label();
            txtTenLoaiDaiLy = new TextBox();
            txtTienNoToiDa = new TextBox();
            dgvLoaiDaiLy = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDaiLy).BeginInit();
            SuspendLayout();
            // 
            // lblTenLoai
            // 
            lblTenLoai.AutoSize = true;
            lblTenLoai.Location = new Point(30, 30);
            lblTenLoai.Name = "lblTenLoai";
            lblTenLoai.Size = new Size(111, 20);
            lblTenLoai.TabIndex = 0;
            lblTenLoai.Text = "Tên Loại Đại Lý:";
            // 
            // lblTienNo
            // 
            lblTienNo.AutoSize = true;
            lblTienNo.Location = new Point(30, 70);
            lblTienNo.Name = "lblTienNo";
            lblTienNo.Size = new Size(112, 20);
            lblTienNo.TabIndex = 1;
            lblTienNo.Text = "Tiền Nợ Tối Đa:";
            // 
            // txtTenLoaiDaiLy
            // 
            txtTenLoaiDaiLy.Location = new Point(160, 30);
            txtTenLoaiDaiLy.Name = "txtTenLoaiDaiLy";
            txtTenLoaiDaiLy.Size = new Size(200, 27);
            txtTenLoaiDaiLy.TabIndex = 2;
            // 
            // txtTienNoToiDa
            // 
            txtTienNoToiDa.Location = new Point(160, 70);
            txtTienNoToiDa.Name = "txtTienNoToiDa";
            txtTienNoToiDa.Size = new Size(200, 27);
            txtTienNoToiDa.TabIndex = 3;
            // 
            // dgvLoaiDaiLy
            // 
            dgvLoaiDaiLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiDaiLy.Location = new Point(30, 120);
            dgvLoaiDaiLy.MultiSelect = false;
            dgvLoaiDaiLy.Name = "dgvLoaiDaiLy";
            dgvLoaiDaiLy.RowHeadersWidth = 51;
            dgvLoaiDaiLy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiDaiLy.Size = new Size(550, 200);
            dgvLoaiDaiLy.TabIndex = 4;
            dgvLoaiDaiLy.SelectionChanged += dgvLoaiDaiLy_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(600, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 28);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(600, 70);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 28);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(600, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 28);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(600, 150);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 28);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // GUI_LoaiDaiLy
            // 
            ClientSize = new Size(750, 350);
            Controls.Add(lblTenLoai);
            Controls.Add(lblTienNo);
            Controls.Add(txtTenLoaiDaiLy);
            Controls.Add(txtTienNoToiDa);
            Controls.Add(dgvLoaiDaiLy);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Name = "GUI_LoaiDaiLy";
            Text = "Quản lý Loại Đại Lý";
            Load += GUI_LoaiDaiLy_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDaiLy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
