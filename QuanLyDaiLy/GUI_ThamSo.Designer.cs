namespace GUI_QuanLy
{
    partial class GUI_ThamSo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.DataGridView dgvThamSo;
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
            txtGiaTri = new TextBox();
            dgvThamSo = new DataGridView();
            dgvtxtThamSo = new DataGridViewTextBoxColumn();
            dgvtxtGiaTri = new DataGridViewTextBoxColumn();
            dgvtxtThuocTinh = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            cbbThamSo = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblDanhSachThamSo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvThamSo).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtGiaTri
            // 
            txtGiaTri.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGiaTri.Location = new Point(170, 13);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(101, 34);
            txtGiaTri.TabIndex = 3;
            // 
            // dgvThamSo
            // 
            dgvThamSo.AllowUserToResizeColumns = false;
            dgvThamSo.AllowUserToResizeRows = false;
            dgvThamSo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThamSo.BorderStyle = BorderStyle.None;
            dgvThamSo.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvThamSo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThamSo.Columns.AddRange(new DataGridViewColumn[] { dgvtxtThamSo, dgvtxtGiaTri, dgvtxtThuocTinh });
            dgvThamSo.Location = new Point(8, 39);
            dgvThamSo.Name = "dgvThamSo";
            dgvThamSo.ReadOnly = true;
            dgvThamSo.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvThamSo.RowHeadersVisible = false;
            dgvThamSo.RowHeadersWidth = 51;
            dgvThamSo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThamSo.Size = new Size(754, 186);
            dgvThamSo.TabIndex = 4;
            // 
            // dgvtxtThamSo
            // 
            dgvtxtThamSo.HeaderText = "Tên tham số";
            dgvtxtThamSo.MinimumWidth = 6;
            dgvtxtThamSo.Name = "dgvtxtThamSo";
            dgvtxtThamSo.ReadOnly = true;
            // 
            // dgvtxtGiaTri
            // 
            dgvtxtGiaTri.HeaderText = "Giá trị";
            dgvtxtGiaTri.MinimumWidth = 6;
            dgvtxtGiaTri.Name = "dgvtxtGiaTri";
            dgvtxtGiaTri.ReadOnly = true;
            // 
            // dgvtxtThuocTinh
            // 
            dgvtxtThuocTinh.HeaderText = "Thuộc tính liên quan";
            dgvtxtThuocTinh.MinimumWidth = 6;
            dgvtxtThuocTinh.Name = "dgvtxtThuocTinh";
            dgvtxtThuocTinh.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 28);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(3, 71);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 28);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(3, 37);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 28);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbbThamSo
            // 
            cbbThamSo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbThamSo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbThamSo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbThamSo.FormattingEnabled = true;
            cbbThamSo.Items.AddRange(new object[] { "test" });
            cbbThamSo.Location = new Point(13, 13);
            cbbThamSo.Name = "cbbThamSo";
            cbbThamSo.Size = new Size(151, 36);
            cbbThamSo.TabIndex = 9;
            cbbThamSo.Text = "Tham số";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblDanhSachThamSo);
            flowLayoutPanel1.Controls.Add(dgvThamSo);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(774, 359);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // lblDanhSachThamSo
            // 
            lblDanhSachThamSo.AutoSize = true;
            lblDanhSachThamSo.Dock = DockStyle.Top;
            lblDanhSachThamSo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachThamSo.Location = new Point(8, 5);
            lblDanhSachThamSo.Name = "lblDanhSachThamSo";
            lblDanhSachThamSo.Size = new Size(754, 31);
            lblDanhSachThamSo.TabIndex = 10;
            lblDanhSachThamSo.Text = "Danh sách tham số";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(8, 231);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(616, 108);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(btnAdd);
            flowLayoutPanel3.Controls.Add(btnDelete);
            flowLayoutPanel3.Controls.Add(btnEdit);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(507, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(106, 102);
            flowLayoutPanel3.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(cbbThamSo);
            flowLayoutPanel2.Controls.Add(txtGiaTri);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(199, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(10);
            flowLayoutPanel2.Size = new Size(302, 102);
            flowLayoutPanel2.TabIndex = 11;
            // 
            // GUI_ThamSo
            // 
            ClientSize = new Size(774, 359);
            Controls.Add(flowLayoutPanel1);
            Name = "GUI_ThamSo";
            Text = "Quản Lý Tham Số";
            ((System.ComponentModel.ISupportInitialize)dgvThamSo).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }
        private ComboBox cbbThamSo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblDanhSachThamSo;
        private DataGridViewTextBoxColumn dgvtxtThamSo;
        private DataGridViewTextBoxColumn dgvtxtGiaTri;
        private DataGridViewTextBoxColumn dgvtxtThuocTinh;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
    }
}
