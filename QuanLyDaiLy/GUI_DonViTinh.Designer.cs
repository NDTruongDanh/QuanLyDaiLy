namespace GUI_QuanLy
{
    partial class GUI_DonViTinh
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenDonViTinh;
        private System.Windows.Forms.TextBox txtTenDonViTinh;
        private System.Windows.Forms.DataGridView dgvDVT;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTenDonViTinh = new Label();
            txtTenDonViTinh = new TextBox();
            dgvDVT = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDVT).BeginInit();
            SuspendLayout();
            // 
            // lblTenDonViTinh
            // 
            lblTenDonViTinh.AutoSize = true;
            lblTenDonViTinh.Location = new Point(30, 25);
            lblTenDonViTinh.Name = "lblTenDonViTinh";
            lblTenDonViTinh.Size = new Size(109, 20);
            lblTenDonViTinh.TabIndex = 0;
            lblTenDonViTinh.Text = "Tên đơn vị tính:";
            // 
            // txtTenDonViTinh
            // 
            txtTenDonViTinh.Location = new Point(160, 22);
            txtTenDonViTinh.Name = "txtTenDonViTinh";
            txtTenDonViTinh.Size = new Size(220, 27);
            txtTenDonViTinh.TabIndex = 1;
            // 
            // dgvDVT
            // 
            dgvDVT.AllowUserToAddRows = false;
            dgvDVT.AllowUserToDeleteRows = false;
            dgvDVT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDVT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDVT.Location = new Point(30, 60);
            dgvDVT.Name = "dgvDVT";
            dgvDVT.ReadOnly = true;
            dgvDVT.RowHeadersWidth = 51;
            dgvDVT.RowTemplate.Height = 24;
            dgvDVT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDVT.Size = new Size(520, 200);
            dgvDVT.TabIndex = 2;
            dgvDVT.SelectionChanged += dgvDVT_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 280);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(150, 280);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 35);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(270, 280);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(450, 280);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 35);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // GUI_DonViTinh
            // 
            ClientSize = new Size(600, 340);
            Controls.Add(lblTenDonViTinh);
            Controls.Add(txtTenDonViTinh);
            Controls.Add(dgvDVT);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Name = "GUI_DonViTinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Đơn Vị Tính";
            Load += GUI_DonViTinh_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDVT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
