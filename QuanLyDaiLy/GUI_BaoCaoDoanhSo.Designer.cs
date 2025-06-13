using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QuanLy
{
    partial class GUI_BaoCaoDoanhSo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnHeader;
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
            Title title1 = new Title();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pnHeader = new Panel();
            txtNam = new TextBox();
            btnFind = new Button();
            cbbThang = new ComboBox();
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
            tableLayoutPanel3 = new TableLayoutPanel();
            pcThongKeDoanhSo = new Chart();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblThongKeDoanhThu = new Label();
            dgvChiTietBaoCaoDoanhSo = new DataGridView();
            pnHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flpTongSoPhieuXuat.SuspendLayout();
            flpTongDoanhSo.SuspendLayout();
            flpTongSoDaiLy.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcThongKeDoanhSo).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietBaoCaoDoanhSo).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(txtNam);
            pnHeader.Controls.Add(btnFind);
            pnHeader.Controls.Add(cbbThang);
            pnHeader.Dock = DockStyle.Fill;
            pnHeader.Location = new Point(10, 12);
            pnHeader.Margin = new Padding(10, 12, 10, 12);
            pnHeader.Name = "pnHeader";
            pnHeader.Padding = new Padding(10, 12, 10, 12);
            pnHeader.Size = new Size(1614, 52);
            pnHeader.TabIndex = 0;
            // 
            // txtNam
            // 
            txtNam.Font = new Font("Segoe UI", 12F);
            txtNam.Location = new Point(1338, 9);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(106, 34);
            txtNam.TabIndex = 25;
            txtNam.Text = "Năm";
            txtNam.KeyPress += txtNam_KeyPress;
            // 
            // btnFind
            // 
            btnFind.AutoSize = true;
            btnFind.BackColor = Color.FromArgb(33, 150, 243);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 12F);
            btnFind.Location = new Point(1474, 4);
            btnFind.Margin = new Padding(3, 3, 5, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(128, 44);
            btnFind.TabIndex = 24;
            btnFind.Text = "🔍 Tìm ";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // cbbThang
            // 
            cbbThang.FlatStyle = FlatStyle.Popup;
            cbbThang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbbThang.FormattingEnabled = true;
            cbbThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbbThang.Location = new Point(1209, 9);
            cbbThang.Margin = new Padding(10, 12, 20, 12);
            cbbThang.Name = "cbbThang";
            cbbThang.Size = new Size(106, 36);
            cbbThang.TabIndex = 3;
            cbbThang.Tag = "";
            cbbThang.Text = "Tháng";
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(16, 84);
            tableLayoutPanel1.Margin = new Padding(16, 8, 16, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1602, 146);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flpTongSoPhieuXuat
            // 
            flpTongSoPhieuXuat.BackColor = Color.PaleGreen;
            flpTongSoPhieuXuat.Controls.Add(lblTongSoPhieuXuat);
            flpTongSoPhieuXuat.Controls.Add(lblTongSoPhieuXuat_Num);
            flpTongSoPhieuXuat.Dock = DockStyle.Fill;
            flpTongSoPhieuXuat.FlowDirection = FlowDirection.TopDown;
            flpTongSoPhieuXuat.Location = new Point(537, 4);
            flpTongSoPhieuXuat.Margin = new Padding(3, 4, 3, 4);
            flpTongSoPhieuXuat.Name = "flpTongSoPhieuXuat";
            flpTongSoPhieuXuat.Padding = new Padding(5, 6, 5, 6);
            flpTongSoPhieuXuat.Size = new Size(528, 138);
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
            flpTongDoanhSo.Controls.Add(lblTongDoanhSo);
            flpTongDoanhSo.Controls.Add(lblTongDoanhSo_Num);
            flpTongDoanhSo.Dock = DockStyle.Fill;
            flpTongDoanhSo.FlowDirection = FlowDirection.TopDown;
            flpTongDoanhSo.Location = new Point(1071, 4);
            flpTongDoanhSo.Margin = new Padding(3, 4, 3, 4);
            flpTongDoanhSo.Name = "flpTongDoanhSo";
            flpTongDoanhSo.Padding = new Padding(5, 6, 5, 6);
            flpTongDoanhSo.Size = new Size(528, 138);
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
            flpTongSoDaiLy.Controls.Add(lblTongSoDaiLy);
            flpTongSoDaiLy.Controls.Add(lblTongSoDaiLy_Num);
            flpTongSoDaiLy.Dock = DockStyle.Fill;
            flpTongSoDaiLy.FlowDirection = FlowDirection.TopDown;
            flpTongSoDaiLy.Location = new Point(3, 4);
            flpTongSoDaiLy.Margin = new Padding(3, 4, 3, 4);
            flpTongSoDaiLy.Name = "flpTongSoDaiLy";
            flpTongSoDaiLy.Padding = new Padding(5, 6, 5, 6);
            flpTongSoDaiLy.Size = new Size(528, 138);
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(pcThongKeDoanhSo, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 241);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1628, 681);
            tableLayoutPanel3.TabIndex = 8;
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
            pcThongKeDoanhSo.Dock = DockStyle.Fill;
            legend1.BorderDashStyle = ChartDashStyle.NotSet;
            legend1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            legend1.IsTextAutoFit = false;
            legend1.MaximumAutoSize = 100F;
            legend1.Name = "Legend1";
            pcThongKeDoanhSo.Legends.Add(legend1);
            pcThongKeDoanhSo.Location = new Point(16, 8);
            pcThongKeDoanhSo.Margin = new Padding(16, 8, 8, 16);
            pcThongKeDoanhSo.Name = "pcThongKeDoanhSo";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Pie;
            series1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            pcThongKeDoanhSo.Series.Add(series1);
            pcThongKeDoanhSo.Size = new Size(790, 657);
            pcThongKeDoanhSo.TabIndex = 5;
            pcThongKeDoanhSo.Text = "Doanh số";
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "Doanh số của đại lý";
            pcThongKeDoanhSo.Titles.Add(title1);
            pcThongKeDoanhSo.Click += pcThongKeDoanhSo_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pnHeader, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.216216F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.5135136F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 74.1706161F));
            tableLayoutPanel2.Size = new Size(1634, 925);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lblThongKeDoanhThu, 0, 0);
            tableLayoutPanel4.Controls.Add(dgvChiTietBaoCaoDoanhSo, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(822, 8);
            tableLayoutPanel4.Margin = new Padding(8, 8, 16, 16);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tableLayoutPanel4.Size = new Size(790, 657);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // lblThongKeDoanhThu
            // 
            lblThongKeDoanhThu.AutoSize = true;
            lblThongKeDoanhThu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThongKeDoanhThu.Location = new Point(10, 10);
            lblThongKeDoanhThu.Margin = new Padding(10);
            lblThongKeDoanhThu.Name = "lblThongKeDoanhThu";
            lblThongKeDoanhThu.Size = new Size(231, 31);
            lblThongKeDoanhThu.TabIndex = 7;
            lblThongKeDoanhThu.Text = "Thống kê doanh thu";
            // 
            // dgvChiTietBaoCaoDoanhSo
            // 
            dgvChiTietBaoCaoDoanhSo.AllowUserToAddRows = false;
            dgvChiTietBaoCaoDoanhSo.AllowUserToDeleteRows = false;
            dgvChiTietBaoCaoDoanhSo.AllowUserToResizeColumns = false;
            dgvChiTietBaoCaoDoanhSo.AllowUserToResizeRows = false;
            dgvChiTietBaoCaoDoanhSo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietBaoCaoDoanhSo.BackgroundColor = Color.White;
            dgvChiTietBaoCaoDoanhSo.BorderStyle = BorderStyle.None;
            dgvChiTietBaoCaoDoanhSo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvChiTietBaoCaoDoanhSo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvChiTietBaoCaoDoanhSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvChiTietBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietBaoCaoDoanhSo.Dock = DockStyle.Fill;
            dgvChiTietBaoCaoDoanhSo.Location = new Point(0, 52);
            dgvChiTietBaoCaoDoanhSo.Margin = new Padding(0);
            dgvChiTietBaoCaoDoanhSo.Name = "dgvChiTietBaoCaoDoanhSo";
            dgvChiTietBaoCaoDoanhSo.ReadOnly = true;
            dgvChiTietBaoCaoDoanhSo.RowHeadersVisible = false;
            dgvChiTietBaoCaoDoanhSo.RowHeadersWidth = 51;
            dgvChiTietBaoCaoDoanhSo.RowTemplate.Height = 24;
            dgvChiTietBaoCaoDoanhSo.Size = new Size(790, 605);
            dgvChiTietBaoCaoDoanhSo.TabIndex = 8;
            // 
            // GUI_BaoCaoDoanhSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 925);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GUI_BaoCaoDoanhSo";
            Text = "Quản Lý Báo Cáo Doanh Số";
            Load += GUI_BaoCaoDoanhSo_Load;
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flpTongSoPhieuXuat.ResumeLayout(false);
            flpTongSoPhieuXuat.PerformLayout();
            flpTongDoanhSo.ResumeLayout(false);
            flpTongDoanhSo.PerformLayout();
            flpTongSoDaiLy.ResumeLayout(false);
            flpTongSoDaiLy.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcThongKeDoanhSo).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietBaoCaoDoanhSo).EndInit();
            ResumeLayout(false);
        }

        private Button btnFind;
        private TextBox txtNam;
        private TableLayoutPanel tableLayoutPanel3;
        private Chart pcThongKeDoanhSo;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dgvChiTietBaoCaoDoanhSo;
        private Label lblThongKeDoanhThu;
    }
}
