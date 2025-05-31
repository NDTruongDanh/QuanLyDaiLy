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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvChiTietBaoCaoDoanhSo;
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
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            Title title2 = new Title();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnHeader = new Panel();
            txtNam = new TextBox();
            btnFind = new Button();
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
            lblThongKeDoanhThu = new Label();
            dgvChiTietBaoCaoDoanhSo = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flpTongSoPhieuXuat.SuspendLayout();
            flpTongDoanhSo.SuspendLayout();
            flpTongSoDaiLy.SuspendLayout();
            fplThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcThongKeDoanhSo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietBaoCaoDoanhSo).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(txtNam);
            pnHeader.Controls.Add(btnFind);
            pnHeader.Controls.Add(cbbThang);
            pnHeader.Controls.Add(btnXuatFile);
            pnHeader.Controls.Add(lblBaoCao);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Margin = new Padding(10, 12, 10, 12);
            pnHeader.Name = "pnHeader";
            pnHeader.Padding = new Padding(10, 12, 10, 12);
            pnHeader.Size = new Size(1539, 88);
            pnHeader.TabIndex = 0;
            // 
            // txtNam
            // 
            txtNam.Font = new Font("Segoe UI", 12F);
            txtNam.Location = new Point(1059, 27);
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
            btnFind.Location = new Point(1195, 22);
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
            cbbThang.Location = new Point(930, 27);
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
            btnXuatFile.Location = new Point(1346, 12);
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
            tableLayoutPanel1.Size = new Size(1539, 112);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flpTongSoPhieuXuat
            // 
            flpTongSoPhieuXuat.BackColor = Color.PaleGreen;
            flpTongSoPhieuXuat.BorderStyle = BorderStyle.Fixed3D;
            flpTongSoPhieuXuat.Controls.Add(lblTongSoPhieuXuat);
            flpTongSoPhieuXuat.Controls.Add(lblTongSoPhieuXuat_Num);
            flpTongSoPhieuXuat.FlowDirection = FlowDirection.TopDown;
            flpTongSoPhieuXuat.Location = new Point(516, 4);
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
            flpTongDoanhSo.Location = new Point(1029, 4);
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
            fplThongKe.Controls.Add(pcThongKeDoanhSo);
            fplThongKe.Controls.Add(panel1);
            fplThongKe.Controls.Add(dgvChiTietBaoCaoDoanhSo);
            fplThongKe.Location = new Point(3, 222);
            fplThongKe.Margin = new Padding(5);
            fplThongKe.Name = "fplThongKe";
            fplThongKe.Padding = new Padding(4, 5, 4, 5);
            fplThongKe.Size = new Size(1700, 623);
            fplThongKe.TabIndex = 4;
            // 
            // pcThongKeDoanhSo
            // 
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX2.LabelStyle.Enabled = false;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY2.LabelStyle.Enabled = false;
            chartArea2.BorderColor = Color.Transparent;
            chartArea2.BorderDashStyle = ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            pcThongKeDoanhSo.ChartAreas.Add(chartArea2);
            legend2.BorderDashStyle = ChartDashStyle.NotSet;
            legend2.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            legend2.IsTextAutoFit = false;
            legend2.MaximumAutoSize = 100F;
            legend2.Name = "Legend1";
            pcThongKeDoanhSo.Legends.Add(legend2);
            pcThongKeDoanhSo.Location = new Point(7, 9);
            pcThongKeDoanhSo.Margin = new Padding(3, 4, 3, 4);
            pcThongKeDoanhSo.Name = "pcThongKeDoanhSo";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Pie;
            series2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            pcThongKeDoanhSo.Series.Add(series2);
            pcThongKeDoanhSo.Size = new Size(450, 600);
            pcThongKeDoanhSo.TabIndex = 5;
            pcThongKeDoanhSo.Text = "Doanh số";
            title2.Alignment = ContentAlignment.TopLeft;
            title2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title2.Name = "Title1";
            title2.Text = "Doanh số của đại lý";
            pcThongKeDoanhSo.Titles.Add(title2);
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(lblThongKeDoanhThu);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(463, 9);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 607);
            panel1.TabIndex = 4;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvChiTietBaoCaoDoanhSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvChiTietBaoCaoDoanhSo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietBaoCaoDoanhSo.Location = new Point(476, 15);
            dgvChiTietBaoCaoDoanhSo.Margin = new Padding(10);
            dgvChiTietBaoCaoDoanhSo.Name = "dgvChiTietBaoCaoDoanhSo";
            dgvChiTietBaoCaoDoanhSo.ReadOnly = true;
            dgvChiTietBaoCaoDoanhSo.RowHeadersVisible = false;
            dgvChiTietBaoCaoDoanhSo.RowHeadersWidth = 51;
            dgvChiTietBaoCaoDoanhSo.RowTemplate.Height = 24;
            dgvChiTietBaoCaoDoanhSo.Size = new Size(1180, 595);
            dgvChiTietBaoCaoDoanhSo.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 200);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1539, 0);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // GUI_BaoCaoDoanhSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 844);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(fplThongKe);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnHeader);
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
            fplThongKe.ResumeLayout(false);
            fplThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcThongKeDoanhSo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietBaoCaoDoanhSo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnFind;
        private TextBox txtNam;
    }
}
