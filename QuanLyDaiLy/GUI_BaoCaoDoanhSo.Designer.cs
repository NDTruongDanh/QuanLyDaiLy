using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QuanLy
{
    partial class GUI_BaoCaoDoanhSo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblBaoCao;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.FlowLayoutPanel flpTongSoDaiLy;
        private System.Windows.Forms.Label lblTongSoDaiLy;
        private System.Windows.Forms.FlowLayoutPanel flpTongSoPhieuXuat;
        private System.Windows.Forms.Label lblTongSoPhieuXuat;
        private System.Windows.Forms.Label lblTongSoPhieuXuat_Num;
        private System.Windows.Forms.FlowLayoutPanel flpTongDoanhSo;
        private System.Windows.Forms.Label lblTongDoanhSo;
        private System.Windows.Forms.Label lblTongDoanhSo_Num;
        private System.Windows.Forms.Label lblTongSoDaiLy_Num;
        private System.Windows.Forms.FlowLayoutPanel fplThongKe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThongKeDoanhThu;
        private System.Windows.Forms.DataGridView dgvBangThongKeDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTenDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTiLe;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvBangTongKet;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSoPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTongTriGia;
        private ProgressBarColumn progressCol;
        private Chart pcThongKeDoanhSo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        public class ProgressBarColumn : DataGridViewColumn
        {
            public ProgressBarColumn() : base(new ProgressBarCell())
            {
                this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
        }

        public class ProgressBarCell : DataGridViewTextBoxCell
        {
            protected override void Paint(Graphics g, Rectangle clipBounds, Rectangle cellBounds,
                                    int rowIndex, DataGridViewElementStates cellState, object value,
                                    object formattedValue, string errorText,
                                    DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
                                    DataGridViewPaintParts paintParts)
            {
                // Vẽ border (nếu có)
                if ((paintParts & DataGridViewPaintParts.Border) != 0)
                {
                    PaintBorder(g, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
                }

                // Vẽ background
                using (Brush backBrush = new SolidBrush(cellStyle.BackColor))
                {
                    g.FillRectangle(backBrush, cellBounds);
                }

                // Parse giá trị %
                int percent = 0;
                if (value != null && int.TryParse(value.ToString().Replace("%", ""), out int val))
                    percent = val;

                // Vẽ chữ phần trăm (ví dụ: "35%")
                string text = $"{percent}%";
                var textSize = g.MeasureString(text, cellStyle.Font);
                var textPoint = new PointF(cellBounds.X + 6, cellBounds.Y + (cellBounds.Height - textSize.Height) / 2);
                g.DrawString(text, cellStyle.Font, Brushes.Black, textPoint);

                // Vẽ thanh progress bên phải
                int barX = cellBounds.X + (int)textSize.Width + 12;
                int barY = cellBounds.Y + (cellBounds.Height - 10) / 2;
                int barWidth = cellBounds.Width - (int)textSize.Width - 20;
                Rectangle backRect = new Rectangle(barX, barY, barWidth, 10);
                g.FillRectangle(Brushes.LightGray, backRect);
                Rectangle fillRect = new Rectangle(barX, barY, (int)(barWidth * percent / 100.0), 10);
                g.FillRectangle(Brushes.RoyalBlue, fillRect);
            }

        }

        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_BaoCaoDoanhSo));
            pnHeader = new Panel();
            cbbThang = new ComboBox();
            btnXuatFile = new Button();
            lblBaoCao = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flpTongSoPhieuXuat = new FlowLayoutPanel();
            lblTongSoPhieuXuat = new Label();
            lblTongSoPhieuXuat_Num = new Label();
            flpTongDoanhSo = new FlowLayoutPanel();
            lblTongDoanhSo = new Label();
            lblTongDoanhSo_Num = new Label();
            flpTongSoDaiLy = new FlowLayoutPanel();
            lblTongSoDaiLy = new Label();
            lblTongSoDaiLy_Num = new Label();
            fplThongKe = new FlowLayoutPanel();
            pcThongKeDoanhSo = new Chart();
            panel1 = new Panel();
            dgvBangThongKeDoanhThu = new DataGridView();
            dgvtxtTenDL = new DataGridViewTextBoxColumn();
            dgvtxtDoanhThu = new DataGridViewTextBoxColumn();
            dgvtxtTiLe = new DataGridViewTextBoxColumn();
            lblThongKeDoanhThu = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvBangTongKet = new DataGridView();
            txtSTT = new DataGridViewTextBoxColumn();
            txtDaiLy = new DataGridViewTextBoxColumn();
            txtSoPhieuXuat = new DataGridViewTextBoxColumn();
            txtTongTriGia = new DataGridViewTextBoxColumn();
            progressCol = new ProgressBarColumn();
            cbbYear = new ComboBox();
            btnFind = new Button();
            pnHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flpTongSoPhieuXuat.SuspendLayout();
            flpTongDoanhSo.SuspendLayout();
            flpTongSoDaiLy.SuspendLayout();
            fplThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcThongKeDoanhSo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBangThongKeDoanhThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBangTongKet).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(btnFind);
            pnHeader.Controls.Add(cbbYear);
            pnHeader.Controls.Add(cbbThang);
            pnHeader.Controls.Add(btnXuatFile);
            pnHeader.Controls.Add(lblBaoCao);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Margin = new Padding(10, 12, 10, 12);
            pnHeader.Name = "pnHeader";
            pnHeader.Padding = new Padding(10, 12, 10, 12);
            pnHeader.Size = new Size(1634, 88);
            pnHeader.TabIndex = 0;
            // 
            // cbbThang
            // 
            cbbThang.FlatStyle = FlatStyle.Popup;
            cbbThang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbThang.FormattingEnabled = true;
            cbbThang.Location = new Point(1048, 27);
            cbbThang.Margin = new Padding(10, 12, 20, 12);
            cbbThang.Name = "cbbThang";
            cbbThang.Size = new Size(106, 36);
            cbbThang.TabIndex = 3;
            cbbThang.Tag = "";
            cbbThang.Text = "Tháng";
            // 
            // btnXuatFile
            // 
            btnXuatFile.BackColor = Color.DarkGreen;
            btnXuatFile.Dock = DockStyle.Right;
            btnXuatFile.FlatStyle = FlatStyle.Popup;
            btnXuatFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXuatFile.ForeColor = Color.White;
            btnXuatFile.Location = new Point(1441, 12);
            btnXuatFile.Margin = new Padding(3, 4, 20, 4);
            btnXuatFile.Name = "btnXuatFile";
            btnXuatFile.Size = new Size(183, 64);
            btnXuatFile.TabIndex = 2;
            btnXuatFile.Text = "Xuất file Excel";
            btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // lblBaoCao
            // 
            lblBaoCao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblBaoCao.AutoSize = true;
            lblBaoCao.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBaoCao.Location = new Point(13, 12);
            lblBaoCao.Name = "lblBaoCao";
            lblBaoCao.Size = new Size(401, 38);
            lblBaoCao.TabIndex = 1;
            lblBaoCao.Text = "Báo cáo doanh số theo tháng";
            lblBaoCao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.Controls.Add(flpTongSoPhieuXuat, 1, 0);
            tableLayoutPanel1.Controls.Add(flpTongDoanhSo, 2, 0);
            tableLayoutPanel1.Controls.Add(flpTongSoDaiLy, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 88);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1634, 112);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flpTongSoPhieuXuat
            // 
            flpTongSoPhieuXuat.BackColor = Color.PaleGreen;
            flpTongSoPhieuXuat.BorderStyle = BorderStyle.Fixed3D;
            flpTongSoPhieuXuat.Controls.Add(lblTongSoPhieuXuat);
            flpTongSoPhieuXuat.Controls.Add(lblTongSoPhieuXuat_Num);
            flpTongSoPhieuXuat.FlowDirection = FlowDirection.TopDown;
            flpTongSoPhieuXuat.Location = new Point(547, 4);
            flpTongSoPhieuXuat.Margin = new Padding(3, 4, 3, 4);
            flpTongSoPhieuXuat.Name = "flpTongSoPhieuXuat";
            flpTongSoPhieuXuat.Padding = new Padding(5, 6, 5, 6);
            flpTongSoPhieuXuat.Size = new Size(500, 104);
            flpTongSoPhieuXuat.TabIndex = 2;
            // 
            // lblTongSoPhieuXuat
            // 
            lblTongSoPhieuXuat.AutoSize = true;
            lblTongSoPhieuXuat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongSoPhieuXuat.Location = new Point(8, 6);
            lblTongSoPhieuXuat.Name = "lblTongSoPhieuXuat";
            lblTongSoPhieuXuat.Size = new Size(220, 31);
            lblTongSoPhieuXuat.TabIndex = 0;
            lblTongSoPhieuXuat.Text = "Tổng số phiếu xuất";
            // 
            // lblTongSoPhieuXuat_Num
            // 
            lblTongSoPhieuXuat_Num.AutoSize = true;
            lblTongSoPhieuXuat_Num.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongSoPhieuXuat_Num.Location = new Point(8, 37);
            lblTongSoPhieuXuat_Num.Name = "lblTongSoPhieuXuat_Num";
            lblTongSoPhieuXuat_Num.Size = new Size(26, 31);
            lblTongSoPhieuXuat_Num.TabIndex = 1;
            lblTongSoPhieuXuat_Num.Text = "4";
            // 
            // flpTongDoanhSo
            // 
            flpTongDoanhSo.BackColor = Color.Gold;
            flpTongDoanhSo.BorderStyle = BorderStyle.Fixed3D;
            flpTongDoanhSo.Controls.Add(lblTongDoanhSo);
            flpTongDoanhSo.Controls.Add(lblTongDoanhSo_Num);
            flpTongDoanhSo.FlowDirection = FlowDirection.TopDown;
            flpTongDoanhSo.Location = new Point(1091, 4);
            flpTongDoanhSo.Margin = new Padding(3, 4, 3, 4);
            flpTongDoanhSo.Name = "flpTongDoanhSo";
            flpTongDoanhSo.Padding = new Padding(5, 6, 5, 6);
            flpTongDoanhSo.Size = new Size(500, 104);
            flpTongDoanhSo.TabIndex = 3;
            // 
            // lblTongDoanhSo
            // 
            lblTongDoanhSo.AutoSize = true;
            lblTongDoanhSo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongDoanhSo.Location = new Point(8, 6);
            lblTongDoanhSo.Name = "lblTongDoanhSo";
            lblTongDoanhSo.Size = new Size(173, 31);
            lblTongDoanhSo.TabIndex = 0;
            lblTongDoanhSo.Text = "Tổng doanh số";
            // 
            // lblTongDoanhSo_Num
            // 
            lblTongDoanhSo_Num.AutoSize = true;
            lblTongDoanhSo_Num.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongDoanhSo_Num.Location = new Point(8, 37);
            lblTongDoanhSo_Num.Name = "lblTongDoanhSo_Num";
            lblTongDoanhSo_Num.Size = new Size(26, 31);
            lblTongDoanhSo_Num.TabIndex = 1;
            lblTongDoanhSo_Num.Text = "4";
            // 
            // flpTongSoDaiLy
            // 
            flpTongSoDaiLy.BackColor = Color.LightSteelBlue;
            flpTongSoDaiLy.BorderStyle = BorderStyle.Fixed3D;
            flpTongSoDaiLy.Controls.Add(lblTongSoDaiLy);
            flpTongSoDaiLy.Controls.Add(lblTongSoDaiLy_Num);
            flpTongSoDaiLy.FlowDirection = FlowDirection.TopDown;
            flpTongSoDaiLy.Location = new Point(3, 4);
            flpTongSoDaiLy.Margin = new Padding(3, 4, 3, 4);
            flpTongSoDaiLy.Name = "flpTongSoDaiLy";
            flpTongSoDaiLy.Padding = new Padding(5, 6, 5, 6);
            flpTongSoDaiLy.Size = new Size(500, 104);
            flpTongSoDaiLy.TabIndex = 0;
            // 
            // lblTongSoDaiLy
            // 
            lblTongSoDaiLy.AutoSize = true;
            lblTongSoDaiLy.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongSoDaiLy.Location = new Point(8, 6);
            lblTongSoDaiLy.Name = "lblTongSoDaiLy";
            lblTongSoDaiLy.Size = new Size(164, 31);
            lblTongSoDaiLy.TabIndex = 0;
            lblTongSoDaiLy.Text = "Tổng số đại lý";
            // 
            // lblTongSoDaiLy_Num
            // 
            lblTongSoDaiLy_Num.AutoSize = true;
            lblTongSoDaiLy_Num.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongSoDaiLy_Num.Location = new Point(8, 37);
            lblTongSoDaiLy_Num.Name = "lblTongSoDaiLy_Num";
            lblTongSoDaiLy_Num.Size = new Size(26, 31);
            lblTongSoDaiLy_Num.TabIndex = 1;
            lblTongSoDaiLy_Num.Text = "4";
            // 
            // fplThongKe
            // 
            fplThongKe.AutoSize = true;
            fplThongKe.Controls.Add(pcThongKeDoanhSo);
            fplThongKe.Controls.Add(panel1);
            fplThongKe.Dock = DockStyle.Top;
            fplThongKe.Location = new Point(0, 200);
            fplThongKe.Margin = new Padding(3, 4, 3, 4);
            fplThongKe.Name = "fplThongKe";
            fplThongKe.Padding = new Padding(4, 5, 4, 5);
            fplThongKe.Size = new Size(1634, 473);
            fplThongKe.TabIndex = 4;
            // 
            // pcThongKeDoanhSo
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX2.LabelStyle.Enabled = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.BorderColor = Color.Transparent;
            chartArea1.BorderDashStyle = ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            pcThongKeDoanhSo.ChartAreas.Add(chartArea1);
            pcThongKeDoanhSo.Dock = DockStyle.Left;
            legend1.BorderDashStyle = ChartDashStyle.NotSet;
            legend1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.MaximumAutoSize = 100F;
            legend1.Name = "Legend1";
            pcThongKeDoanhSo.Legends.Add(legend1);
            pcThongKeDoanhSo.Location = new Point(7, 9);
            pcThongKeDoanhSo.Margin = new Padding(3, 4, 3, 4);
            pcThongKeDoanhSo.Name = "pcThongKeDoanhSo";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Pie;
            series1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            pcThongKeDoanhSo.Series.Add(series1);
            pcThongKeDoanhSo.Size = new Size(450, 455);
            pcThongKeDoanhSo.TabIndex = 5;
            pcThongKeDoanhSo.Text = "Doanh số";
            pcThongKeDoanhSo.Click += pcThongKeDoanhSo_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(dgvBangThongKeDoanhThu);
            panel1.Controls.Add(lblThongKeDoanhThu);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(463, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 455);
            panel1.TabIndex = 4;
            // 
            // dgvBangThongKeDoanhThu
            // 
            dgvBangThongKeDoanhThu.AllowUserToAddRows = false;
            dgvBangThongKeDoanhThu.AllowUserToDeleteRows = false;
            dgvBangThongKeDoanhThu.AllowUserToResizeColumns = false;
            dgvBangThongKeDoanhThu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBangThongKeDoanhThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBangThongKeDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBangThongKeDoanhThu.BackgroundColor = Color.WhiteSmoke;
            dgvBangThongKeDoanhThu.BorderStyle = BorderStyle.None;
            dgvBangThongKeDoanhThu.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBangThongKeDoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBangThongKeDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBangThongKeDoanhThu.Columns.AddRange(new DataGridViewColumn[] { dgvtxtTenDL, dgvtxtDoanhThu, dgvtxtTiLe });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvBangThongKeDoanhThu.DefaultCellStyle = dataGridViewCellStyle4;
            dgvBangThongKeDoanhThu.GridColor = Color.WhiteSmoke;
            dgvBangThongKeDoanhThu.Location = new Point(0, 39);
            dgvBangThongKeDoanhThu.Margin = new Padding(3, 4, 3, 4);
            dgvBangThongKeDoanhThu.Name = "dgvBangThongKeDoanhThu";
            dgvBangThongKeDoanhThu.ReadOnly = true;
            dgvBangThongKeDoanhThu.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBangThongKeDoanhThu.RowHeadersVisible = false;
            dgvBangThongKeDoanhThu.RowHeadersWidth = 51;
            dgvBangThongKeDoanhThu.RowTemplate.Height = 24;
            dgvBangThongKeDoanhThu.Size = new Size(1161, 412);
            dgvBangThongKeDoanhThu.TabIndex = 1;
            dgvBangThongKeDoanhThu.Click += dgvBangThongKeDoanhThu_Click;
            // 
            // dgvtxtTenDL
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvtxtTenDL.DefaultCellStyle = dataGridViewCellStyle3;
            dgvtxtTenDL.HeaderText = "Tên đại lý";
            dgvtxtTenDL.MinimumWidth = 6;
            dgvtxtTenDL.Name = "dgvtxtTenDL";
            dgvtxtTenDL.ReadOnly = true;
            // 
            // dgvtxtDoanhThu
            // 
            dgvtxtDoanhThu.HeaderText = "Doanh Thu";
            dgvtxtDoanhThu.MinimumWidth = 6;
            dgvtxtDoanhThu.Name = "dgvtxtDoanhThu";
            dgvtxtDoanhThu.ReadOnly = true;
            // 
            // dgvtxtTiLe
            // 
            dgvtxtTiLe.HeaderText = "Tỉ lệ";
            dgvtxtTiLe.MinimumWidth = 6;
            dgvtxtTiLe.Name = "dgvtxtTiLe";
            dgvtxtTiLe.ReadOnly = true;
            // 
            // lblThongKeDoanhThu
            // 
            lblThongKeDoanhThu.AutoSize = true;
            lblThongKeDoanhThu.Dock = DockStyle.Top;
            lblThongKeDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKeDoanhThu.Location = new Point(0, 0);
            lblThongKeDoanhThu.Name = "lblThongKeDoanhThu";
            lblThongKeDoanhThu.Size = new Size(203, 28);
            lblThongKeDoanhThu.TabIndex = 0;
            lblThongKeDoanhThu.Text = "Thống kê doanh thu";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 673);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1634, 0);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // dgvBangTongKet
            // 
            dgvBangTongKet.AllowUserToAddRows = false;
            dgvBangTongKet.AllowUserToDeleteRows = false;
            dgvBangTongKet.AllowUserToResizeColumns = false;
            dgvBangTongKet.AllowUserToResizeRows = false;
            dgvBangTongKet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBangTongKet.BackgroundColor = Color.White;
            dgvBangTongKet.BorderStyle = BorderStyle.None;
            dgvBangTongKet.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBangTongKet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvBangTongKet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvBangTongKet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBangTongKet.Columns.AddRange(new DataGridViewColumn[] { txtSTT, txtDaiLy, txtSoPhieuXuat, txtTongTriGia, progressCol });
            dgvBangTongKet.Dock = DockStyle.Top;
            dgvBangTongKet.Location = new Point(0, 673);
            dgvBangTongKet.Margin = new Padding(10);
            dgvBangTongKet.Name = "dgvBangTongKet";
            dgvBangTongKet.ReadOnly = true;
            dgvBangTongKet.RowHeadersVisible = false;
            dgvBangTongKet.RowHeadersWidth = 51;
            dgvBangTongKet.RowTemplate.Height = 24;
            dgvBangTongKet.Size = new Size(1634, 242);
            dgvBangTongKet.TabIndex = 6;
            dgvBangTongKet.Click += dgvBangTongKet_Click;
            // 
            // txtSTT
            // 
            txtSTT.HeaderText = "STT";
            txtSTT.MinimumWidth = 6;
            txtSTT.Name = "txtSTT";
            txtSTT.ReadOnly = true;
            // 
            // txtDaiLy
            // 
            txtDaiLy.HeaderText = "Đại Lý";
            txtDaiLy.MinimumWidth = 6;
            txtDaiLy.Name = "txtDaiLy";
            txtDaiLy.ReadOnly = true;
            // 
            // txtSoPhieuXuat
            // 
            txtSoPhieuXuat.HeaderText = "Số phiếu xuất";
            txtSoPhieuXuat.MinimumWidth = 6;
            txtSoPhieuXuat.Name = "txtSoPhieuXuat";
            txtSoPhieuXuat.ReadOnly = true;
            // 
            // txtTongTriGia
            // 
            txtTongTriGia.HeaderText = "Tổng trị giá";
            txtTongTriGia.MinimumWidth = 6;
            txtTongTriGia.Name = "txtTongTriGia";
            txtTongTriGia.ReadOnly = true;
            // 
            // progressCol
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            progressCol.DefaultCellStyle = dataGridViewCellStyle6;
            progressCol.HeaderText = "Tỷ Lệ";
            progressCol.MinimumWidth = 6;
            progressCol.Name = "progressCol";
            progressCol.ReadOnly = true;
            // 
            // cbbYear
            // 
            cbbYear.FlatStyle = FlatStyle.Popup;
            cbbYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbYear.FormattingEnabled = true;
            cbbYear.Location = new Point(1168, 27);
            cbbYear.Margin = new Padding(10, 12, 20, 12);
            cbbYear.Name = "cbbYear";
            cbbYear.Size = new Size(106, 36);
            cbbYear.TabIndex = 4;
            cbbYear.Tag = "";
            cbbYear.Text = "Năm";
            // 
            // btnFind
            // 
            btnFind.AutoSize = true;
            btnFind.BackColor = Color.DeepSkyBlue;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFind.Image = (Image)resources.GetObject("btnFind.Image");
            btnFind.ImageAlign = ContentAlignment.MiddleLeft;
            btnFind.Location = new Point(1318, 24);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 40);
            btnFind.TabIndex = 5;
            btnFind.Text = "Tìm";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // GUI_BaoCaoDoanhSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 925);
            Controls.Add(dgvBangTongKet);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(fplThongKe);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnHeader);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GUI_BaoCaoDoanhSo";
            Text = "Quản Lý Báo Cáo Doanh Số";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flpTongSoPhieuXuat.ResumeLayout(false);
            flpTongSoPhieuXuat.PerformLayout();
            flpTongDoanhSo.ResumeLayout(false);
            flpTongDoanhSo.PerformLayout();
            flpTongSoDaiLy.ResumeLayout(false);
            flpTongSoDaiLy.PerformLayout();
            fplThongKe.ResumeLayout(false);
            fplThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcThongKeDoanhSo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBangThongKeDoanhThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBangTongKet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnFind;
        private ComboBox cbbYear;
    }
}
