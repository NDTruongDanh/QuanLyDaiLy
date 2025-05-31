﻿namespace GUI_QuanLy
{
    partial class GUI_Quan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            lblDanhSachPhieuThu = new Label();
            label2 = new Label();
            dgvQuan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAddQuan = new Button();
            btnEditQuan = new Button();
            btnXoaQuan = new Button();
            btnRefreshQuan = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTenQuan = new TextBox();
            lblTenDaiLy = new Label();
            lblThongTinPhieuThu = new Label();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuan).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblDanhSachPhieuThu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dgvQuan);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(16, 16);
            panel1.Margin = new Padding(16, 16, 16, 8);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(16, 16, 16, 8);
            panel1.Size = new Size(1602, 502);
            panel1.TabIndex = 24;
            // 
            // lblDanhSachPhieuThu
            // 
            lblDanhSachPhieuThu.AutoSize = true;
            lblDanhSachPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachPhieuThu.Location = new Point(16, 16);
            lblDanhSachPhieuThu.Name = "lblDanhSachPhieuThu";
            lblDanhSachPhieuThu.Size = new Size(230, 38);
            lblDanhSachPhieuThu.TabIndex = 16;
            lblDanhSachPhieuThu.Text = "Danh sách Quận";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(0, 58);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(3000, 2);
            label2.TabIndex = 15;
            // 
            // dgvQuan
            // 
            dgvQuan.AllowUserToResizeColumns = false;
            dgvQuan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvQuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuan.BackgroundColor = Color.White;
            dgvQuan.BorderStyle = BorderStyle.None;
            dgvQuan.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvQuan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQuan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQuan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuan.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQuan.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQuan.EnableHeadersVisualStyles = false;
            dgvQuan.GridColor = Color.White;
            dgvQuan.Location = new Point(19, 77);
            dgvQuan.Name = "dgvQuan";
            dgvQuan.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvQuan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvQuan.RowHeadersVisible = false;
            dgvQuan.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvQuan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuan.Size = new Size(1564, 400);
            dgvQuan.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Quận";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(lblThongTinPhieuThu);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(16, 534);
            panel2.Margin = new Padding(16, 8, 16, 16);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(16);
            panel2.Size = new Size(1602, 390);
            panel2.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(btnAddQuan);
            flowLayoutPanel1.Controls.Add(btnEditQuan);
            flowLayoutPanel1.Controls.Add(btnXoaQuan);
            flowLayoutPanel1.Controls.Add(btnRefreshQuan);
            flowLayoutPanel1.Location = new Point(960, 319);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(623, 52);
            flowLayoutPanel1.TabIndex = 30;
            // 
            // btnAddQuan
            // 
            btnAddQuan.AutoSize = true;
            btnAddQuan.BackColor = Color.FromArgb(76, 175, 80);
            btnAddQuan.FlatStyle = FlatStyle.Flat;
            btnAddQuan.Font = new Font("Segoe UI", 12F);
            btnAddQuan.Location = new Point(3, 3);
            btnAddQuan.Margin = new Padding(3, 3, 20, 3);
            btnAddQuan.Name = "btnAddQuan";
            btnAddQuan.Size = new Size(134, 44);
            btnAddQuan.TabIndex = 22;
            btnAddQuan.Text = "➕  Thêm";
            btnAddQuan.UseVisualStyleBackColor = false;
            // 
            // btnEditQuan
            // 
            btnEditQuan.AutoSize = true;
            btnEditQuan.BackColor = Color.FromArgb(255, 152, 0);
            btnEditQuan.FlatStyle = FlatStyle.Flat;
            btnEditQuan.Font = new Font("Segoe UI", 12F);
            btnEditQuan.Location = new Point(160, 3);
            btnEditQuan.Margin = new Padding(3, 3, 20, 3);
            btnEditQuan.Name = "btnEditQuan";
            btnEditQuan.Size = new Size(128, 44);
            btnEditQuan.TabIndex = 21;
            btnEditQuan.Text = "✏️ Sửa";
            btnEditQuan.UseVisualStyleBackColor = false;
            // 
            // btnXoaQuan
            // 
            btnXoaQuan.AutoSize = true;
            btnXoaQuan.BackColor = Color.FromArgb(244, 67, 54);
            btnXoaQuan.FlatStyle = FlatStyle.Flat;
            btnXoaQuan.Font = new Font("Segoe UI", 12F);
            btnXoaQuan.Location = new Point(311, 3);
            btnXoaQuan.Margin = new Padding(3, 3, 20, 3);
            btnXoaQuan.Name = "btnXoaQuan";
            btnXoaQuan.Size = new Size(128, 44);
            btnXoaQuan.TabIndex = 20;
            btnXoaQuan.Text = "🗑 Xóa";
            btnXoaQuan.UseVisualStyleBackColor = false;
            // 
            // btnRefreshQuan
            // 
            btnRefreshQuan.AutoSize = true;
            btnRefreshQuan.BackColor = Color.FromArgb(33, 150, 243);
            btnRefreshQuan.FlatStyle = FlatStyle.Flat;
            btnRefreshQuan.Font = new Font("Segoe UI", 12F);
            btnRefreshQuan.Location = new Point(462, 3);
            btnRefreshQuan.Name = "btnRefreshQuan";
            btnRefreshQuan.Size = new Size(158, 44);
            btnRefreshQuan.TabIndex = 24;
            btnRefreshQuan.Text = "🔍 Làm mới";
            btnRefreshQuan.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtTenQuan, 1, 0);
            tableLayoutPanel1.Controls.Add(lblTenDaiLy, 0, 0);
            tableLayoutPanel1.Location = new Point(16, 77);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1564, 45);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // txtTenQuan
            // 
            txtTenQuan.Dock = DockStyle.Fill;
            txtTenQuan.Font = new Font("Segoe UI", 12F);
            txtTenQuan.Location = new Point(131, 3);
            txtTenQuan.Name = "txtTenQuan";
            txtTenQuan.Size = new Size(1430, 39);
            txtTenQuan.TabIndex = 7;
            // 
            // lblTenDaiLy
            // 
            lblTenDaiLy.AutoSize = true;
            lblTenDaiLy.BackColor = Color.Transparent;
            lblTenDaiLy.Font = new Font("Segoe UI", 12F);
            lblTenDaiLy.Location = new Point(3, 0);
            lblTenDaiLy.Name = "lblTenDaiLy";
            lblTenDaiLy.Size = new Size(122, 32);
            lblTenDaiLy.TabIndex = 0;
            lblTenDaiLy.Text = "Tên Quận:";
            // 
            // lblThongTinPhieuThu
            // 
            lblThongTinPhieuThu.AutoSize = true;
            lblThongTinPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinPhieuThu.Location = new Point(16, 13);
            lblThongTinPhieuThu.Name = "lblThongTinPhieuThu";
            lblThongTinPhieuThu.Size = new Size(222, 38);
            lblThongTinPhieuThu.TabIndex = 16;
            lblThongTinPhieuThu.Text = "Nhập liệu Quận";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(0, 51);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(3000, 2);
            label4.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 55.9574471F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 44.0425529F));
            tableLayoutPanel2.Size = new Size(1634, 940);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // GUI_Quan
            // 
            ClientSize = new Size(1634, 940);
            Controls.Add(tableLayoutPanel2);
            Name = "GUI_Quan";
            Text = "Quản Lý Quận";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label lblDanhSachPhieuThu;
        private Label label2;
        private DataGridView dgvQuan;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTenDaiLy;
        private Label lblThongTinPhieuThu;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn Column1;
        private TextBox txtTenQuan;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAddQuan;
        private Button btnEditQuan;
        private Button btnXoaQuan;
        private Button btnRefreshQuan;
    }
}
