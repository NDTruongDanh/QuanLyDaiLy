﻿namespace GUI_QuanLy
{
    partial class GUI_PhieuXuat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtEmail = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            comboBoxDaiLy = new ComboBox();
            dtpNgayLapPhieu = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            label6 = new Label();
            dgvPhieuXuat = new DataGridView();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuat).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(16, 633);
            panel2.Margin = new Padding(16, 8, 16, 16);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(16);
            panel2.Size = new Size(1602, 291);
            panel2.TabIndex = 26;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnEdit);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Controls.Add(btnFind);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Location = new Point(836, 220);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(747, 52);
            flowLayoutPanel1.TabIndex = 28;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(3, 3);
            btnAdd.Margin = new Padding(3, 3, 20, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 44);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "➕  Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.AutoSize = true;
            btnEdit.BackColor = Color.FromArgb(255, 152, 0);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(160, 3);
            btnEdit.Margin = new Padding(3, 3, 20, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 44);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "✏️ Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(311, 3);
            btnDelete.Margin = new Padding(3, 3, 20, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 44);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "🗑 Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnFind
            // 
            btnFind.AutoSize = true;
            btnFind.BackColor = Color.FromArgb(33, 150, 243);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 12F);
            btnFind.Location = new Point(462, 3);
            btnFind.Margin = new Padding(3, 3, 20, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(128, 44);
            btnFind.TabIndex = 23;
            btnFind.Text = "🔍 Tìm ";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(33, 150, 243);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(613, 3);
            button1.Name = "button1";
            button1.Size = new Size(131, 44);
            button1.TabIndex = 24;
            button1.Text = "🔍 Làm mới";
            button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(txtEmail, 1, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(comboBoxDaiLy, 1, 0);
            tableLayoutPanel2.Controls.Add(dtpNgayLapPhieu, 1, 1);
            tableLayoutPanel2.Location = new Point(12, 79);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1571, 124);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(154, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(1417, 34);
            txtEmail.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(3, 82);
            label5.Name = "label5";
            label5.Size = new Size(145, 42);
            label5.TabIndex = 10;
            label5.Text = "Số tiền trả:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 42);
            label4.Name = "label4";
            label4.Size = new Size(145, 40);
            label4.TabIndex = 9;
            label4.Text = "Ngày lập phiếu";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(145, 42);
            label7.TabIndex = 2;
            label7.Text = "Tên Đại lý:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxDaiLy
            // 
            comboBoxDaiLy.Dock = DockStyle.Fill;
            comboBoxDaiLy.Font = new Font("Segoe UI", 12F);
            comboBoxDaiLy.FormattingEnabled = true;
            comboBoxDaiLy.Location = new Point(154, 3);
            comboBoxDaiLy.Name = "comboBoxDaiLy";
            comboBoxDaiLy.Size = new Size(1417, 36);
            comboBoxDaiLy.TabIndex = 7;
            // 
            // dtpNgayLapPhieu
            // 
            dtpNgayLapPhieu.Dock = DockStyle.Fill;
            dtpNgayLapPhieu.Font = new Font("Segoe UI", 12F);
            dtpNgayLapPhieu.Location = new Point(154, 45);
            dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            dtpNgayLapPhieu.Size = new Size(1417, 34);
            dtpNgayLapPhieu.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(253, 32);
            label1.TabIndex = 16;
            label1.Text = "Thông tin phiếu xuất";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(0, 64);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(2000, 2);
            label3.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.4893646F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.51064F));
            tableLayoutPanel1.Size = new Size(1634, 940);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dgvPhieuXuat);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(16, 16);
            panel1.Margin = new Padding(16, 16, 16, 8);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16);
            panel1.Size = new Size(1602, 601);
            panel1.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 16);
            label2.Name = "label2";
            label2.Size = new Size(259, 32);
            label2.TabIndex = 21;
            label2.Text = "Danh sách phiếu xuất";
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Location = new Point(7, 64);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(2000, 2);
            label6.TabIndex = 20;
            // 
            // dgvPhieuXuat
            // 
            dgvPhieuXuat.AllowUserToResizeColumns = false;
            dgvPhieuXuat.AllowUserToResizeRows = false;
            dgvPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuXuat.BackgroundColor = Color.White;
            dgvPhieuXuat.BorderStyle = BorderStyle.None;
            dgvPhieuXuat.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPhieuXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPhieuXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvPhieuXuat.DefaultCellStyle = dataGridViewCellStyle5;
            dgvPhieuXuat.EnableHeadersVisualStyles = false;
            dgvPhieuXuat.GridColor = Color.White;
            dgvPhieuXuat.Location = new Point(15, 85);
            dgvPhieuXuat.Margin = new Padding(5);
            dgvPhieuXuat.Name = "dgvPhieuXuat";
            dgvPhieuXuat.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvPhieuXuat.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvPhieuXuat.RowHeadersVisible = false;
            dgvPhieuXuat.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvPhieuXuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuXuat.Size = new Size(1566, 495);
            dgvPhieuXuat.TabIndex = 19;
            // 
            // GUI_PhieuXuat
            // 
            ClientSize = new Size(1634, 940);
            Controls.Add(tableLayoutPanel1);
            Name = "GUI_PhieuXuat";
            Text = "Quản Lý Phiếu Xuất";
            Load += GUI_PhieuXuat_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuat).EndInit();
            ResumeLayout(false);
        }

        private Panel panel2;
        private Label label1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label7;
        private ComboBox comboBoxDaiLy;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dtpNgayLapPhieu;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private DataGridView dgvPhieuXuat;
        private Label label2;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnFind;
        private Button button1;
    }
}
