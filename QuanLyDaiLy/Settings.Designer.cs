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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            dgvDVT = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnFind = new Button();
            dgvLoaiDaiLy = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label8 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            txtTenQuan = new TextBox();
            lblsdl = new Label();
            checkBox1 = new CheckBox();
            label2 = new Label();
            lblDanhSachPhieuThu = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            cbApDungKTQD = new CheckBox();
            panel1 = new Panel();
            btnEdit = new Button();
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
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 2);
            tableLayoutPanel1.Controls.Add(panel3, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(panel1, 0, 4);
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
            tableLayoutPanel4.Controls.Add(dgvDVT, 0, 2);
            tableLayoutPanel4.Controls.Add(label5, 0, 1);
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(16, 16);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 330F));
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDVT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDVT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDVT.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDVT.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDVT.EnableHeadersVisualStyles = false;
            dgvDVT.GridColor = Color.White;
            dgvDVT.Location = new Point(3, 73);
            dgvDVT.Name = "dgvDVT";
            dgvDVT.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDVT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDVT.RowHeadersVisible = false;
            dgvDVT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDVT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDVT.Size = new Size(2494, 468);
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
            tableLayoutPanel3.Controls.Add(btnFind, 0, 3);
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
            // btnFind
            // 
            btnFind.AutoSize = true;
            btnFind.BackColor = Color.FromArgb(33, 150, 243);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 12F);
            btnFind.Location = new Point(3, 521);
            btnFind.Margin = new Padding(3, 3, 20, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(255, 44);
            btnFind.TabIndex = 24;
            btnFind.Text = "➕  Thêm loại đại lý";
            btnFind.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvLoaiDaiLy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvLoaiDaiLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiDaiLy.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvLoaiDaiLy.DefaultCellStyle = dataGridViewCellStyle5;
            dgvLoaiDaiLy.EnableHeadersVisualStyles = false;
            dgvLoaiDaiLy.GridColor = Color.White;
            dgvLoaiDaiLy.Location = new Point(3, 73);
            dgvLoaiDaiLy.Margin = new Padding(3, 3, 3, 10);
            dgvLoaiDaiLy.Name = "dgvLoaiDaiLy";
            dgvLoaiDaiLy.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvLoaiDaiLy.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            tableLayoutPanel5.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel5.Controls.Add(label7, 0, 1);
            tableLayoutPanel5.Controls.Add(txtTenQuan, 1, 0);
            tableLayoutPanel5.Controls.Add(lblsdl, 0, 0);
            tableLayoutPanel5.Controls.Add(checkBox1, 1, 2);
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
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(371, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(2120, 39);
            textBox1.TabIndex = 10;
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
            // txtTenQuan
            // 
            txtTenQuan.Dock = DockStyle.Fill;
            txtTenQuan.Font = new Font("Segoe UI", 12F);
            txtTenQuan.Location = new Point(371, 3);
            txtTenQuan.Name = "txtTenQuan";
            txtTenQuan.Size = new Size(2120, 39);
            txtTenQuan.TabIndex = 8;
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.Location = new Point(371, 93);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(22, 21);
            checkBox1.TabIndex = 12;
            checkBox1.UseVisualStyleBackColor = true;
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
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(cbApDungKTQD);
            flowLayoutPanel2.Location = new Point(3, 1488);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5);
            flowLayoutPanel2.Size = new Size(439, 14);
            flowLayoutPanel2.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(350, 38);
            label1.TabIndex = 0;
            label1.Text = "Áp dụng KTQĐ số tiền thu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbApDungKTQD
            // 
            cbApDungKTQD.CheckAlign = ContentAlignment.MiddleCenter;
            cbApDungKTQD.FlatStyle = FlatStyle.Popup;
            cbApDungKTQD.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbApDungKTQD.Location = new Point(411, 15);
            cbApDungKTQD.Margin = new Padding(50, 10, 3, 3);
            cbApDungKTQD.Name = "cbApDungKTQD";
            cbApDungKTQD.Size = new Size(20, 25);
            cbApDungKTQD.TabIndex = 1;
            cbApDungKTQD.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEdit);
            panel1.Location = new Point(3, 1508);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 14);
            panel1.TabIndex = 19;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(695, 14);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 28);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
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
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private CheckBox cbApDungKTQD;
        private Panel panel1;
        private Button btnEdit;
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
        private TextBox txtTenQuan;
        private Label label8;
        private TextBox textBox1;
        private Label label7;
        private CheckBox checkBox1;
        private DataGridView dgvLoaiDaiLy;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnFind;
        private DataGridView dgvDVT;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}