namespace GUI_QuanLy
{
    partial class Settings
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvDVT = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnThemLoaiDaiLy = new Button();
            dgvLoaiDaiLy = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label8 = new Label();
            txtTiLeDonGia = new TextBox();
            label7 = new Label();
            txtSoDaiLyToiDaTrongQuan = new TextBox();
            lblsdl = new Label();
            checkBoxApDungKTQD = new CheckBox();
            label2 = new Label();
            lblDanhSachPhieuThu = new Label();
            btnThemDonViTinh = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDVT).BeginInit();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDaiLy).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(2564, 1570);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(tableLayoutPanel4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(16, 901);
            panel4.Margin = new Padding(16, 16, 16, 8);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(16);
            panel4.Size = new Size(2532, 576);
            panel4.TabIndex = 29;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(btnThemDonViTinh, 0, 3);
            tableLayoutPanel4.Controls.Add(label5, 0, 1);
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(dgvDVT, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(16, 16);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(2500, 544);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // dgvDVT
            // 
            dgvDVT.AllowUserToResizeColumns = false;
            dgvDVT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDVT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDVT.BackgroundColor = Color.White;
            dgvDVT.BorderStyle = BorderStyle.None;
            dgvDVT.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvDVT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvDVT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvDVT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDVT.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvDVT.DefaultCellStyle = dataGridViewCellStyle14;
            dgvDVT.EnableHeadersVisualStyles = false;
            dgvDVT.GridColor = Color.White;
            dgvDVT.Location = new Point(3, 73);
            dgvDVT.Margin = new Padding(3, 3, 3, 10);
            dgvDVT.Name = "dgvDVT";
            dgvDVT.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dgvDVT.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dgvDVT.RowHeadersVisible = false;
            dgvDVT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDVT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDVT.Size = new Size(2494, 404);
            dgvDVT.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Tên Đơn Vị Tính";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(0, 48);
            label5.Margin = new Padding(0, 0, 0, 20);
            label5.Name = "label5";
            label5.Size = new Size(2500, 2);
            label5.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Margin = new Padding(3, 0, 3, 10);
            label6.Name = "label6";
            label6.Size = new Size(305, 38);
            label6.TabIndex = 16;
            label6.Text = "Danh sách đơn vị tính";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(16, 277);
            panel3.Margin = new Padding(16, 16, 16, 8);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(16);
            panel3.Size = new Size(2532, 600);
            panel3.TabIndex = 28;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(btnThemLoaiDaiLy, 0, 3);
            tableLayoutPanel3.Controls.Add(dgvLoaiDaiLy, 0, 2);
            tableLayoutPanel3.Controls.Add(label3, 0, 1);
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(16, 16);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(2500, 568);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // btnThemLoaiDaiLy
            // 
            btnThemLoaiDaiLy.AutoSize = true;
            btnThemLoaiDaiLy.BackColor = Color.FromArgb(33, 150, 243);
            btnThemLoaiDaiLy.FlatStyle = FlatStyle.Flat;
            btnThemLoaiDaiLy.Font = new Font("Segoe UI", 12F);
            btnThemLoaiDaiLy.Location = new Point(3, 521);
            btnThemLoaiDaiLy.Margin = new Padding(3, 3, 20, 3);
            btnThemLoaiDaiLy.Name = "btnThemLoaiDaiLy";
            btnThemLoaiDaiLy.Size = new Size(255, 44);
            btnThemLoaiDaiLy.TabIndex = 24;
            btnThemLoaiDaiLy.Text = "➕  Thêm loại đại lý";
            btnThemLoaiDaiLy.UseVisualStyleBackColor = false;
            // 
            // dgvLoaiDaiLy
            // 
            dgvLoaiDaiLy.AllowUserToResizeColumns = false;
            dgvLoaiDaiLy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvLoaiDaiLy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiDaiLy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoaiDaiLy.BackgroundColor = Color.White;
            dgvLoaiDaiLy.BorderStyle = BorderStyle.None;
            dgvLoaiDaiLy.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvLoaiDaiLy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvLoaiDaiLy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvLoaiDaiLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiDaiLy.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.White;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle17.ForeColor = Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle17.SelectionForeColor = Color.Black;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgvLoaiDaiLy.DefaultCellStyle = dataGridViewCellStyle17;
            dgvLoaiDaiLy.EnableHeadersVisualStyles = false;
            dgvLoaiDaiLy.GridColor = Color.White;
            dgvLoaiDaiLy.Location = new Point(3, 73);
            dgvLoaiDaiLy.Margin = new Padding(3, 3, 3, 10);
            dgvLoaiDaiLy.Name = "dgvLoaiDaiLy";
            dgvLoaiDaiLy.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dgvLoaiDaiLy.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dgvLoaiDaiLy.RowHeadersVisible = false;
            dgvLoaiDaiLy.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvLoaiDaiLy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiDaiLy.Size = new Size(2494, 435);
            dgvLoaiDaiLy.TabIndex = 17;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Loại Đại Lý";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tiền Nợ Tối Đa";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(0, 48);
            label3.Margin = new Padding(0, 0, 0, 20);
            label3.Name = "label3";
            label3.Size = new Size(2500, 2);
            label3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Margin = new Padding(3, 0, 3, 10);
            label4.Name = "label4";
            label4.Size = new Size(288, 38);
            label4.TabIndex = 16;
            label4.Text = "Danh sách loại đại lý";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(16, 16);
            panel2.Margin = new Padding(16, 16, 16, 8);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(16);
            panel2.Size = new Size(2532, 237);
            panel2.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(lblDanhSachPhieuThu, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(16, 16);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 330F));
            tableLayoutPanel2.Size = new Size(2500, 205);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label8, 0, 2);
            tableLayoutPanel5.Controls.Add(txtTiLeDonGia, 1, 1);
            tableLayoutPanel5.Controls.Add(label7, 0, 1);
            tableLayoutPanel5.Controls.Add(txtSoDaiLyToiDaTrongQuan, 1, 0);
            tableLayoutPanel5.Controls.Add(lblsdl, 0, 0);
            tableLayoutPanel5.Controls.Add(checkBoxApDungKTQD, 1, 2);
            tableLayoutPanel5.Location = new Point(3, 73);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Size = new Size(2494, 135);
            tableLayoutPanel5.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(3, 90);
            label8.Margin = new Padding(3, 0, 10, 0);
            label8.Name = "label8";
            label8.Size = new Size(302, 32);
            label8.TabIndex = 11;
            label8.Text = "Áp dụng KTQĐ số tiền thu:";
            // 
            // txtTiLeDonGia
            // 
            txtTiLeDonGia.Dock = DockStyle.Fill;
            txtTiLeDonGia.Font = new Font("Segoe UI", 12F);
            txtTiLeDonGia.Location = new Point(371, 48);
            txtTiLeDonGia.Name = "txtTiLeDonGia";
            txtTiLeDonGia.Size = new Size(2120, 39);
            txtTiLeDonGia.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 45);
            label7.Margin = new Padding(3, 0, 10, 0);
            label7.Name = "label7";
            label7.Size = new Size(355, 32);
            label7.TabIndex = 9;
            label7.Text = "Tỉ lệ đơn giá xuất/đơn giá nhập:";
            // 
            // txtSoDaiLyToiDaTrongQuan
            // 
            txtSoDaiLyToiDaTrongQuan.Dock = DockStyle.Fill;
            txtSoDaiLyToiDaTrongQuan.Font = new Font("Segoe UI", 12F);
            txtSoDaiLyToiDaTrongQuan.Location = new Point(371, 3);
            txtSoDaiLyToiDaTrongQuan.Name = "txtSoDaiLyToiDaTrongQuan";
            txtSoDaiLyToiDaTrongQuan.Size = new Size(2120, 39);
            txtSoDaiLyToiDaTrongQuan.TabIndex = 8;
            // 
            // lblsdl
            // 
            lblsdl.AutoSize = true;
            lblsdl.BackColor = Color.Transparent;
            lblsdl.Font = new Font("Segoe UI", 12F);
            lblsdl.Location = new Point(3, 0);
            lblsdl.Margin = new Padding(3, 0, 10, 0);
            lblsdl.Name = "lblsdl";
            lblsdl.Size = new Size(304, 32);
            lblsdl.TabIndex = 1;
            lblsdl.Text = "Số đại lý tối đa trong quận:";
            // 
            // checkBoxApDungKTQD
            // 
            checkBoxApDungKTQD.AutoSize = true;
            checkBoxApDungKTQD.Font = new Font("Segoe UI", 12F);
            checkBoxApDungKTQD.Location = new Point(371, 93);
            checkBoxApDungKTQD.Name = "checkBoxApDungKTQD";
            checkBoxApDungKTQD.Size = new Size(22, 21);
            checkBoxApDungKTQD.TabIndex = 12;
            checkBoxApDungKTQD.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(0, 48);
            label2.Margin = new Padding(0, 0, 0, 20);
            label2.Name = "label2";
            label2.Size = new Size(2500, 2);
            label2.TabIndex = 15;
            // 
            // lblDanhSachPhieuThu
            // 
            lblDanhSachPhieuThu.AutoSize = true;
            lblDanhSachPhieuThu.BackColor = Color.Transparent;
            lblDanhSachPhieuThu.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachPhieuThu.Location = new Point(3, 0);
            lblDanhSachPhieuThu.Margin = new Padding(3, 0, 3, 10);
            lblDanhSachPhieuThu.Name = "lblDanhSachPhieuThu";
            lblDanhSachPhieuThu.Size = new Size(255, 38);
            lblDanhSachPhieuThu.TabIndex = 16;
            lblDanhSachPhieuThu.Text = "Tham số hệ thống";
            // 
            // btnThemDonViTinh
            // 
            btnThemDonViTinh.AutoSize = true;
            btnThemDonViTinh.BackColor = Color.FromArgb(33, 150, 243);
            btnThemDonViTinh.FlatStyle = FlatStyle.Flat;
            btnThemDonViTinh.Font = new Font("Segoe UI", 12F);
            btnThemDonViTinh.Location = new Point(3, 490);
            btnThemDonViTinh.Name = "btnThemDonViTinh";
            btnThemDonViTinh.Size = new Size(257, 44);
            btnThemDonViTinh.TabIndex = 25;
            btnThemDonViTinh.Text = "➕  Thêm đơn vị tính";
            btnThemDonViTinh.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(2564, 1570);
            Controls.Add(tableLayoutPanel1);
            Name = "Settings";
            Text = "Settings";
            Load += Settings_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDVT).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiDaiLy).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label lblDanhSachPhieuThu;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private Label label6;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblsdl;
        private TextBox txtSoDaiLyToiDaTrongQuan;
        private Label label8;
        private TextBox txtTiLeDonGia;
        private Label label7;
        private CheckBox checkBoxApDungKTQD;
        private DataGridView dgvLoaiDaiLy;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnThemLoaiDaiLy;
        private DataGridView dgvDVT;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnThemDonViTinh;
    }
}