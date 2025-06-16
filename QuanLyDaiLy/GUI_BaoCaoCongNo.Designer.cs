using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QuanLy
{
    partial class GUI_BaoCaoCongNo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.FlowLayoutPanel flpTongNoDauKy;
        private System.Windows.Forms.Label lblTongNoDauKy;
        private System.Windows.Forms.FlowLayoutPanel flpTongPhatSinh;
        private System.Windows.Forms.Label lblTongPhatSinh;
        private System.Windows.Forms.Label lblTongPhatSinh_num;
        private System.Windows.Forms.FlowLayoutPanel flpTongNoCuoiKy;
        private System.Windows.Forms.Label lblTongNoCuoiKy;
        private System.Windows.Forms.Label lblTongNoCuoiKy_num;
        private System.Windows.Forms.Label lblTongNoDauKy_num;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvBaoCaoCongNo;
        private ProgressBarColumn progressCol;
        private ComboBox cboDaiLy;
        private Chart pcThongKeCongNo;
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
            DataPoint dataPoint1 = new DataPoint(1D, 100D);
            DataPoint dataPoint2 = new DataPoint(0D, 0D);
            Title title1 = new Title();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnHeader = new Panel();
            txtNam = new TextBox();
            btnFind = new Button();
            cmbThang = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            flpTongPhatSinh = new FlowLayoutPanel();
            lblTongPhatSinh = new Label();
            lblTongPhatSinh_num = new Label();
            flpTongNoCuoiKy = new FlowLayoutPanel();
            lblTongNoCuoiKy = new Label();
            lblTongNoCuoiKy_num = new Label();
            flpTongNoDauKy = new FlowLayoutPanel();
            lblTongNoDauKy = new Label();
            lblTongNoDauKy_num = new Label();
            pcThongKeCongNo = new Chart();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvBaoCaoCongNo = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnDelete = new Button();
            pnHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flpTongPhatSinh.SuspendLayout();
            flpTongNoCuoiKy.SuspendLayout();
            flpTongNoDauKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcThongKeCongNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCaoCongNo).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.WhiteSmoke;
            pnHeader.Controls.Add(btnDelete);
            pnHeader.Controls.Add(txtNam);
            pnHeader.Controls.Add(btnFind);
            pnHeader.Controls.Add(cmbThang);
            pnHeader.Dock = DockStyle.Fill;
            pnHeader.Location = new Point(10, 12);
            pnHeader.Margin = new Padding(10, 12, 10, 12);
            pnHeader.Name = "pnHeader";
            pnHeader.Padding = new Padding(10, 12, 10, 12);
            pnHeader.Size = new Size(1614, 57);
            pnHeader.TabIndex = 0;
            pnHeader.Paint += pnHeader_Paint;
            // 
            // txtNam
            // 
            txtNam.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNam.Location = new Point(1206, 11);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(106, 34);
            txtNam.TabIndex = 27;
            // 
            // btnFind
            // 
            btnFind.AutoSize = true;
            btnFind.BackColor = Color.FromArgb(33, 150, 243);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 12F);
            btnFind.Location = new Point(1476, 7);
            btnFind.Margin = new Padding(3, 3, 20, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(128, 44);
            btnFind.TabIndex = 26;
            btnFind.Text = "🔍 Tìm ";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // cmbThang
            // 
            cmbThang.FlatStyle = FlatStyle.Popup;
            cmbThang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbThang.FormattingEnabled = true;
            cmbThang.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cmbThang.Location = new Point(1077, 9);
            cmbThang.Margin = new Padding(10, 12, 20, 12);
            cmbThang.Name = "cmbThang";
            cmbThang.Size = new Size(106, 36);
            cmbThang.TabIndex = 3;
            cmbThang.Tag = "";
            cmbThang.Text = "Tháng";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(flpTongPhatSinh, 1, 0);
            tableLayoutPanel1.Controls.Add(flpTongNoCuoiKy, 2, 0);
            tableLayoutPanel1.Controls.Add(flpTongNoDauKy, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(16, 89);
            tableLayoutPanel1.Margin = new Padding(16, 8, 16, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1602, 113);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flpTongPhatSinh
            // 
            flpTongPhatSinh.BackColor = Color.PaleGreen;
            flpTongPhatSinh.Controls.Add(lblTongPhatSinh);
            flpTongPhatSinh.Controls.Add(lblTongPhatSinh_num);
            flpTongPhatSinh.Dock = DockStyle.Fill;
            flpTongPhatSinh.FlowDirection = FlowDirection.TopDown;
            flpTongPhatSinh.Location = new Point(538, 5);
            flpTongPhatSinh.Margin = new Padding(5);
            flpTongPhatSinh.Name = "flpTongPhatSinh";
            flpTongPhatSinh.Padding = new Padding(5, 6, 5, 6);
            flpTongPhatSinh.Size = new Size(523, 103);
            flpTongPhatSinh.TabIndex = 2;
            // 
            // lblTongPhatSinh
            // 
            lblTongPhatSinh.AutoSize = true;
            lblTongPhatSinh.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongPhatSinh.Location = new Point(8, 6);
            lblTongPhatSinh.Name = "lblTongPhatSinh";
            lblTongPhatSinh.Size = new Size(175, 31);
            lblTongPhatSinh.TabIndex = 0;
            lblTongPhatSinh.Text = "Tổng phát sinh";
            // 
            // lblTongPhatSinh_num
            // 
            lblTongPhatSinh_num.AutoSize = true;
            lblTongPhatSinh_num.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongPhatSinh_num.Location = new Point(8, 37);
            lblTongPhatSinh_num.Name = "lblTongPhatSinh_num";
            lblTongPhatSinh_num.Size = new Size(26, 31);
            lblTongPhatSinh_num.TabIndex = 1;
            lblTongPhatSinh_num.Text = "4";
            // 
            // flpTongNoCuoiKy
            // 
            flpTongNoCuoiKy.BackColor = Color.Gold;
            flpTongNoCuoiKy.Controls.Add(lblTongNoCuoiKy);
            flpTongNoCuoiKy.Controls.Add(lblTongNoCuoiKy_num);
            flpTongNoCuoiKy.Dock = DockStyle.Fill;
            flpTongNoCuoiKy.FlowDirection = FlowDirection.TopDown;
            flpTongNoCuoiKy.Location = new Point(1071, 5);
            flpTongNoCuoiKy.Margin = new Padding(5);
            flpTongNoCuoiKy.Name = "flpTongNoCuoiKy";
            flpTongNoCuoiKy.Padding = new Padding(5, 6, 5, 6);
            flpTongNoCuoiKy.Size = new Size(526, 103);
            flpTongNoCuoiKy.TabIndex = 3;
            // 
            // lblTongNoCuoiKy
            // 
            lblTongNoCuoiKy.AutoSize = true;
            lblTongNoCuoiKy.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongNoCuoiKy.Location = new Point(8, 6);
            lblTongNoCuoiKy.Name = "lblTongNoCuoiKy";
            lblTongNoCuoiKy.Size = new Size(186, 31);
            lblTongNoCuoiKy.TabIndex = 0;
            lblTongNoCuoiKy.Text = "Tổng nợ cuối kỳ";
            // 
            // lblTongNoCuoiKy_num
            // 
            lblTongNoCuoiKy_num.AutoSize = true;
            lblTongNoCuoiKy_num.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongNoCuoiKy_num.Location = new Point(8, 37);
            lblTongNoCuoiKy_num.Name = "lblTongNoCuoiKy_num";
            lblTongNoCuoiKy_num.Size = new Size(26, 31);
            lblTongNoCuoiKy_num.TabIndex = 1;
            lblTongNoCuoiKy_num.Text = "4";
            // 
            // flpTongNoDauKy
            // 
            flpTongNoDauKy.BackColor = Color.LightSteelBlue;
            flpTongNoDauKy.Controls.Add(lblTongNoDauKy);
            flpTongNoDauKy.Controls.Add(lblTongNoDauKy_num);
            flpTongNoDauKy.Dock = DockStyle.Fill;
            flpTongNoDauKy.FlowDirection = FlowDirection.TopDown;
            flpTongNoDauKy.Location = new Point(5, 5);
            flpTongNoDauKy.Margin = new Padding(5);
            flpTongNoDauKy.Name = "flpTongNoDauKy";
            flpTongNoDauKy.Padding = new Padding(5, 6, 5, 6);
            flpTongNoDauKy.Size = new Size(523, 103);
            flpTongNoDauKy.TabIndex = 0;
            // 
            // lblTongNoDauKy
            // 
            lblTongNoDauKy.AutoSize = true;
            lblTongNoDauKy.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongNoDauKy.Location = new Point(8, 6);
            lblTongNoDauKy.Name = "lblTongNoDauKy";
            lblTongNoDauKy.Size = new Size(181, 31);
            lblTongNoDauKy.TabIndex = 0;
            lblTongNoDauKy.Text = "Tổng nợ đầu kỳ";
            // 
            // lblTongNoDauKy_num
            // 
            lblTongNoDauKy_num.AutoSize = true;
            lblTongNoDauKy_num.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongNoDauKy_num.Location = new Point(8, 37);
            lblTongNoDauKy_num.Name = "lblTongNoDauKy_num";
            lblTongNoDauKy_num.Size = new Size(26, 31);
            lblTongNoDauKy_num.TabIndex = 1;
            lblTongNoDauKy_num.Text = "4";
            // 
            // pcThongKeCongNo
            // 
            chartArea1.Name = "NoCuoiChartArea";
            pcThongKeCongNo.ChartAreas.Add(chartArea1);
            pcThongKeCongNo.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            pcThongKeCongNo.Legends.Add(legend1);
            pcThongKeCongNo.Location = new Point(16, 218);
            pcThongKeCongNo.Margin = new Padding(16, 8, 16, 8);
            pcThongKeCongNo.Name = "pcThongKeCongNo";
            series1.ChartArea = "NoCuoiChartArea";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "NoCuoiSeries";
            dataPoint1.AxisLabel = "dfs";
            dataPoint1.IsValueShownAsLabel = true;
            dataPoint1.Label = "";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.XValueType = ChartValueType.String;
            series1.YValueType = ChartValueType.Int64;
            pcThongKeCongNo.Series.Add(series1);
            pcThongKeCongNo.Size = new Size(1602, 467);
            pcThongKeCongNo.TabIndex = 7;
            title1.Alignment = ContentAlignment.TopLeft;
            title1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "Nợ cuối kỳ theo đại lý";
            pcThongKeCongNo.Titles.Add(title1);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1634, 0);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // dgvBaoCaoCongNo
            // 
            dgvBaoCaoCongNo.AllowUserToAddRows = false;
            dgvBaoCaoCongNo.AllowUserToDeleteRows = false;
            dgvBaoCaoCongNo.AllowUserToResizeColumns = false;
            dgvBaoCaoCongNo.AllowUserToResizeRows = false;
            dgvBaoCaoCongNo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCaoCongNo.BackgroundColor = Color.White;
            dgvBaoCaoCongNo.BorderStyle = BorderStyle.None;
            dgvBaoCaoCongNo.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvBaoCaoCongNo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBaoCaoCongNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBaoCaoCongNo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBaoCaoCongNo.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBaoCaoCongNo.Dock = DockStyle.Fill;
            dgvBaoCaoCongNo.Location = new Point(16, 701);
            dgvBaoCaoCongNo.Margin = new Padding(16, 8, 16, 16);
            dgvBaoCaoCongNo.Name = "dgvBaoCaoCongNo";
            dgvBaoCaoCongNo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBaoCaoCongNo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvBaoCaoCongNo.RowHeadersVisible = false;
            dgvBaoCaoCongNo.RowHeadersWidth = 51;
            dgvBaoCaoCongNo.RowTemplate.Height = 24;
            dgvBaoCaoCongNo.Size = new Size(1602, 208);
            dgvBaoCaoCongNo.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pnHeader, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvBaoCaoCongNo, 0, 3);
            tableLayoutPanel2.Controls.Add(pcThongKeCongNo, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.756757F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9459457F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 52.216217F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(1634, 925);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.FromArgb(221, 121, 115);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(1334, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 44);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "🔄 Tạo mới";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // GUI_BaoCaoCongNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1634, 925);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GUI_BaoCaoCongNo";
            Text = "Quản Lý Báo Cáo Công Nợ";
            Load += GUI_BaoCaoCongNo_Load;
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flpTongPhatSinh.ResumeLayout(false);
            flpTongPhatSinh.PerformLayout();
            flpTongNoCuoiKy.ResumeLayout(false);
            flpTongNoCuoiKy.PerformLayout();
            flpTongNoDauKy.ResumeLayout(false);
            flpTongNoDauKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcThongKeCongNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCaoCongNo).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnFind;
        private TextBox txtNam;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnDelete;
    }
}
