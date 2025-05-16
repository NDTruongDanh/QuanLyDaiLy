namespace GUI_QuanLy
{
    partial class GUI_Quan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenQuan;
        private System.Windows.Forms.TextBox txtTenQuan;
        private System.Windows.Forms.DataGridView dgvQuan;
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
            lblTenQuan = new Label();
            txtTenQuan = new TextBox();
            dgvQuan = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQuan).BeginInit();
            SuspendLayout();
            // 
            // lblTenQuan
            // 
            lblTenQuan.AutoSize = true;
            lblTenQuan.Location = new Point(30, 30);
            lblTenQuan.Name = "lblTenQuan";
            lblTenQuan.Size = new Size(74, 20);
            lblTenQuan.TabIndex = 0;
            lblTenQuan.Text = "Tên Quận:";
            // 
            // txtTenQuan
            // 
            txtTenQuan.Location = new Point(120, 27);
            txtTenQuan.Name = "txtTenQuan";
            txtTenQuan.Size = new Size(200, 27);
            txtTenQuan.TabIndex = 1;
            // 
            // dgvQuan
            // 
            dgvQuan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuan.Location = new Point(30, 70);
            dgvQuan.MultiSelect = false;
            dgvQuan.Name = "dgvQuan";
            dgvQuan.RowHeadersWidth = 51;
            dgvQuan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuan.Size = new Size(500, 200);
            dgvQuan.TabIndex = 2;
            dgvQuan.SelectionChanged += dgvQuan_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(550, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 28);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(550, 70);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 28);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Sửa";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(550, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 28);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(550, 150);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 28);
            btnExit.TabIndex = 6;
            btnExit.Text = "Thoát";
            btnExit.Click += btnExit_Click;
            // 
            // GUI_Quan
            // 
            ClientSize = new Size(680, 300);
            Controls.Add(lblTenQuan);
            Controls.Add(txtTenQuan);
            Controls.Add(dgvQuan);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Name = "GUI_Quan";
            Text = "Quản Lý Quận";
            Load += GUI_Quan_Load;
            ((System.ComponentModel.ISupportInitialize)dgvQuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
