namespace GUI_QuanLy
{
    partial class GUI_MatHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTenDaiLy;
        private System.Windows.Forms.TextBox txtTenDaiLy;
        private System.Windows.Forms.DataGridView dgvDaiLy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTenDaiLy = new Label();
            txtTenDaiLy = new TextBox();
            dgvDaiLy = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            pnlData = new Panel();
            lblDanhSachDaiLy = new Label();
            label2 = new Label();
            pnlInput = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            cboLoaiDaiLy = new ComboBox();
            label1 = new Label();
            lblThongTinDaiLy = new Label();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            mnItemPhieuXuat = new ToolStripMenuItem();
            mnItemPhieuThu = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvDaiLy).BeginInit();
            pnlData.SuspendLayout();
            pnlInput.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTenDaiLy
            // 
            lblTenDaiLy.AutoSize = true;
            lblTenDaiLy.BackColor = Color.Transparent;
            lblTenDaiLy.Dock = DockStyle.Fill;
            lblTenDaiLy.Font = new Font("Segoe UI", 12F);
            lblTenDaiLy.Location = new Point(3, 0);
            lblTenDaiLy.Name = "lblTenDaiLy";
            lblTenDaiLy.Size = new Size(146, 40);
            lblTenDaiLy.TabIndex = 0;
            lblTenDaiLy.Text = "Tên Mặt hàng:";
            lblTenDaiLy.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTenDaiLy
            // 
            txtTenDaiLy.Dock = DockStyle.Fill;
            txtTenDaiLy.Font = new Font("Segoe UI", 12F);
            txtTenDaiLy.Location = new Point(155, 3);
            txtTenDaiLy.Name = "txtTenDaiLy";
            txtTenDaiLy.Size = new Size(1449, 34);
            txtTenDaiLy.TabIndex = 7;
            // 
            // dgvDaiLy
            // 
            dgvDaiLy.AllowUserToResizeColumns = false;
            dgvDaiLy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDaiLy.BackgroundColor = Color.White;
            dgvDaiLy.BorderStyle = BorderStyle.None;
            dgvDaiLy.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgvDaiLy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(196, 196, 196);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDaiLy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDaiLy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDaiLy.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 155, 249);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDaiLy.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDaiLy.EnableHeadersVisualStyles = false;
            dgvDaiLy.GridColor = Color.White;
            dgvDaiLy.Location = new Point(18, 82);
            dgvDaiLy.Name = "dgvDaiLy";
            dgvDaiLy.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDaiLy.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDaiLy.RowHeadersVisible = false;
            dgvDaiLy.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvDaiLy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDaiLy.Size = new Size(1569, 492);
            dgvDaiLy.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.HeaderText = "Tên Mặt Hàng";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên Đơn Vị Tính";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn giá hiện tại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tồn kho";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // pnlData
            // 
            pnlData.BackColor = Color.White;
            pnlData.Controls.Add(lblDanhSachDaiLy);
            pnlData.Controls.Add(label2);
            pnlData.Controls.Add(dgvDaiLy);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(16, 16);
            pnlData.Margin = new Padding(16, 16, 16, 8);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(15);
            pnlData.Size = new Size(1602, 592);
            pnlData.TabIndex = 21;
            // 
            // lblDanhSachDaiLy
            // 
            lblDanhSachDaiLy.AutoSize = true;
            lblDanhSachDaiLy.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDanhSachDaiLy.Location = new Point(15, 15);
            lblDanhSachDaiLy.Name = "lblDanhSachDaiLy";
            lblDanhSachDaiLy.Size = new Size(247, 32);
            lblDanhSachDaiLy.TabIndex = 16;
            lblDanhSachDaiLy.Text = "Danh sách Mặt hàng";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(0, 64);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(2000, 2);
            label2.TabIndex = 15;
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.Controls.Add(flowLayoutPanel2);
            pnlInput.Controls.Add(tableLayoutPanel1);
            pnlInput.Controls.Add(lblThongTinDaiLy);
            pnlInput.Controls.Add(label4);
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Location = new Point(16, 624);
            pnlInput.Margin = new Padding(16, 8, 16, 16);
            pnlInput.Name = "pnlInput";
            pnlInput.Padding = new Padding(15);
            pnlInput.Size = new Size(1602, 285);
            pnlInput.TabIndex = 22;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Location = new Point(837, 215);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(747, 52);
            flowLayoutPanel2.TabIndex = 30;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(76, 175, 80);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(3, 3);
            button2.Margin = new Padding(3, 3, 20, 3);
            button2.Name = "button2";
            button2.Size = new Size(134, 44);
            button2.TabIndex = 22;
            button2.Text = "➕  Thêm";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(255, 152, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(160, 3);
            button3.Margin = new Padding(3, 3, 20, 3);
            button3.Name = "button3";
            button3.Size = new Size(128, 44);
            button3.TabIndex = 21;
            button3.Text = "✏️ Sửa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.FromArgb(244, 67, 54);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(311, 3);
            button4.Margin = new Padding(3, 3, 20, 3);
            button4.Name = "button4";
            button4.Size = new Size(128, 44);
            button4.TabIndex = 20;
            button4.Text = "🗑 Xóa";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.FromArgb(33, 150, 243);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(462, 3);
            button5.Margin = new Padding(3, 3, 20, 3);
            button5.Name = "button5";
            button5.Size = new Size(128, 44);
            button5.TabIndex = 23;
            button5.Text = "🔍 Tìm ";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.BackColor = Color.FromArgb(33, 150, 243);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F);
            button6.Location = new Point(613, 3);
            button6.Name = "button6";
            button6.Size = new Size(131, 44);
            button6.TabIndex = 24;
            button6.Text = "🔍 Làm mới";
            button6.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(cboLoaiDaiLy, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(txtTenDaiLy, 1, 0);
            tableLayoutPanel1.Controls.Add(lblTenDaiLy, 0, 0);
            tableLayoutPanel1.Location = new Point(15, 94);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1569, 87);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // cboLoaiDaiLy
            // 
            cboLoaiDaiLy.Dock = DockStyle.Fill;
            cboLoaiDaiLy.Font = new Font("Segoe UI", 12F);
            cboLoaiDaiLy.FormattingEnabled = true;
            cboLoaiDaiLy.Location = new Point(155, 43);
            cboLoaiDaiLy.Name = "cboLoaiDaiLy";
            cboLoaiDaiLy.Size = new Size(1449, 36);
            cboLoaiDaiLy.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(146, 47);
            label1.TabIndex = 8;
            label1.Text = "Tên Đơn vị tính:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblThongTinDaiLy
            // 
            lblThongTinDaiLy.AutoSize = true;
            lblThongTinDaiLy.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongTinDaiLy.Location = new Point(18, 15);
            lblThongTinDaiLy.Name = "lblThongTinDaiLy";
            lblThongTinDaiLy.Size = new Size(240, 32);
            lblThongTinDaiLy.TabIndex = 16;
            lblThongTinDaiLy.Text = "Nhập liệu Mặt hàng";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(0, 64);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(2000, 2);
            label4.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pnlData, 0, 0);
            tableLayoutPanel2.Controls.Add(pnlInput, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 66.5946F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.405407F));
            tableLayoutPanel2.Size = new Size(1634, 925);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.ImeMode = ImeMode.NoControl;
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { mnItemPhieuXuat, mnItemPhieuThu });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 52);
            // 
            // mnItemPhieuXuat
            // 
            mnItemPhieuXuat.Name = "mnItemPhieuXuat";
            mnItemPhieuXuat.Size = new Size(185, 24);
            mnItemPhieuXuat.Text = "Phiếu Xuất hàng";
            // 
            // mnItemPhieuThu
            // 
            mnItemPhieuThu.Name = "mnItemPhieuThu";
            mnItemPhieuThu.Size = new Size(185, 24);
            mnItemPhieuThu.Text = "Phiếu Thu tiền";
            // 
            // GUI_MatHang
            // 
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1634, 925);
            Controls.Add(tableLayoutPanel2);
            Name = "GUI_MatHang";
            Text = "Quản lý Mặt hàng";
            ((System.ComponentModel.ISupportInitialize)dgvDaiLy).EndInit();
            pnlData.ResumeLayout(false);
            pnlData.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlData;
        private Label label2;
        private Label lblDanhSachDaiLy;
        private Panel pnlInput;
        private Label lblThongTinDaiLy;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnItemPhieuXuat;
        private ToolStripMenuItem mnItemPhieuThu;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cboLoaiDaiLy;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
