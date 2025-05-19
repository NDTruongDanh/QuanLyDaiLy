namespace GUI_QuanLy
{
    partial class GUI_ThamSo
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnEdit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnEdit = new Button();
            flpLayoutThamSo = new FlowLayoutPanel();
            pCanLe = new Panel();
            flpDLToiDa = new FlowLayoutPanel();
            lblSoQLToiDa = new Label();
            txtSoQLToiDa = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTiLeDonGiaXuat = new Label();
            txtTiLeDGXuat = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            cbApDungKTQD = new CheckBox();
            panel1 = new Panel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            flpLayoutThamSo.SuspendLayout();
            flpDLToiDa.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(391, 14);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 28);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // flpLayoutThamSo
            // 
            flpLayoutThamSo.BackColor = Color.White;
            flpLayoutThamSo.Controls.Add(pCanLe);
            flpLayoutThamSo.Controls.Add(flpDLToiDa);
            flpLayoutThamSo.Controls.Add(flowLayoutPanel1);
            flpLayoutThamSo.Controls.Add(flowLayoutPanel2);
            flpLayoutThamSo.Controls.Add(panel1);
            flpLayoutThamSo.Dock = DockStyle.Fill;
            flpLayoutThamSo.FlowDirection = FlowDirection.TopDown;
            flpLayoutThamSo.Location = new Point(5, 5);
            flpLayoutThamSo.Name = "flpLayoutThamSo";
            flpLayoutThamSo.Padding = new Padding(5);
            flpLayoutThamSo.Size = new Size(772, 343);
            flpLayoutThamSo.TabIndex = 10;
            // 
            // pCanLe
            // 
            pCanLe.Location = new Point(8, 8);
            pCanLe.Name = "pCanLe";
            pCanLe.Size = new Size(250, 31);
            pCanLe.TabIndex = 15;
            // 
            // flpDLToiDa
            // 
            flpDLToiDa.AutoSize = true;
            flpDLToiDa.Controls.Add(lblSoQLToiDa);
            flpDLToiDa.Controls.Add(txtSoQLToiDa);
            flpDLToiDa.Location = new Point(8, 45);
            flpDLToiDa.Name = "flpDLToiDa";
            flpDLToiDa.Padding = new Padding(5);
            flpDLToiDa.Size = new Size(487, 55);
            flpDLToiDa.TabIndex = 11;
            // 
            // lblSoQLToiDa
            // 
            lblSoQLToiDa.AutoSize = true;
            lblSoQLToiDa.Dock = DockStyle.Fill;
            lblSoQLToiDa.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoQLToiDa.Location = new Point(8, 5);
            lblSoQLToiDa.Name = "lblSoQLToiDa";
            lblSoQLToiDa.Size = new Size(340, 45);
            lblSoQLToiDa.TabIndex = 0;
            lblSoQLToiDa.Text = "Số đại lý tối đa mỗi Quận";
            lblSoQLToiDa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSoQLToiDa
            // 
            txtSoQLToiDa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoQLToiDa.Location = new Point(354, 8);
            txtSoQLToiDa.Name = "txtSoQLToiDa";
            txtSoQLToiDa.Size = new Size(125, 39);
            txtSoQLToiDa.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lblTiLeDonGiaXuat);
            flowLayoutPanel1.Controls.Add(txtTiLeDGXuat);
            flowLayoutPanel1.Location = new Point(8, 106);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(491, 55);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // lblTiLeDonGiaXuat
            // 
            lblTiLeDonGiaXuat.AutoSize = true;
            lblTiLeDonGiaXuat.Dock = DockStyle.Fill;
            lblTiLeDonGiaXuat.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTiLeDonGiaXuat.Location = new Point(8, 5);
            lblTiLeDonGiaXuat.Name = "lblTiLeDonGiaXuat";
            lblTiLeDonGiaXuat.Size = new Size(344, 45);
            lblTiLeDonGiaXuat.TabIndex = 0;
            lblTiLeDonGiaXuat.Text = "Tỉ lệ tính đơn giá xuất (%)";
            lblTiLeDonGiaXuat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTiLeDGXuat
            // 
            txtTiLeDGXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTiLeDGXuat.Location = new Point(358, 8);
            txtTiLeDGXuat.Name = "txtTiLeDGXuat";
            txtTiLeDGXuat.Size = new Size(125, 39);
            txtTiLeDGXuat.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(cbApDungKTQD);
            flowLayoutPanel2.Location = new Point(8, 167);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(5);
            flowLayoutPanel2.Size = new Size(439, 48);
            flowLayoutPanel2.TabIndex = 13;
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
            panel1.Location = new Point(8, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 57);
            panel1.TabIndex = 14;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // GUI_ThamSo
            // 
            ClientSize = new Size(782, 353);
            Controls.Add(flpLayoutThamSo);
            Name = "GUI_ThamSo";
            Padding = new Padding(5);
            Text = "Quản Lý Tham Số";
            flpLayoutThamSo.ResumeLayout(false);
            flpLayoutThamSo.PerformLayout();
            flpDLToiDa.ResumeLayout(false);
            flpDLToiDa.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private FlowLayoutPanel flpLayoutThamSo;
        private FlowLayoutPanel flpDLToiDa;
        private Label lblSoQLToiDa;
        private TextBox txtSoQLToiDa;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblTiLeDonGiaXuat;
        private TextBox txtTiLeDGXuat;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private CheckBox cbApDungKTQD;
        private Panel panel1;
        private Panel pCanLe;
    }
}
