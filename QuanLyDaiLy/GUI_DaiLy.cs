using System;
using System.Data;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_DaiLy : Form
    {
        //BUS_DaiLy busDaiLy = new BUS_DaiLy();
        //BUS_LoaiDaiLy busLoai = new BUS_LoaiDaiLy();
        //BUS_Quan busQuan = new BUS_Quan();

        int maDaiLy = 0;
        public GUI_DaiLy()
        {
            InitializeComponent();
        }
        /*

        private void GUI_DaiLy_Load(object sender, EventArgs e)
        {
            //dgvDaiLy.EnableHeadersVisualStyles = false;  
            //dgvDaiLy.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;  
            //dgvDaiLy.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#C4C4C4");  

            cboLoaiDaiLy.DataSource = busLoai.GetLoaiDaiLy();
            cboLoaiDaiLy.DisplayMember = "TenLoaiDaiLy";
            cboLoaiDaiLy.ValueMember = "MaLoaiDaiLy";

            cboQuan.DataSource = busQuan.GetQuan();
            cboQuan.DisplayMember = "TenQuan";
            cboQuan.ValueMember = "MaQuan";
            dgvDaiLy.DataSource = busDaiLy.GetDaiLy();
            dgvDaiLy.Columns["MaDaiLy"].HeaderText = "Mã Đại Lý";
            dgvDaiLy.Columns["TenDaiLy"].HeaderText = "Tên Đại Lý";
            dgvDaiLy.Columns["TenLoaiDaiLy"].HeaderText = "Loại Đại Lý";
            dgvDaiLy.Columns["TenQuan"].HeaderText = "Quận";
            dgvDaiLy.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvDaiLy.Columns["SDT"].HeaderText = "Số Điện Thoại";
            dgvDaiLy.Columns["Email"].HeaderText = "Email";
            dgvDaiLy.Columns["NgayTiepNhan"].HeaderText = "Ngày Tiếp Nhận";
            dgvDaiLy.Columns["TongNo"].HeaderText = "Tổng Nợ";
            dgvDaiLy.Columns["MaLoaiDaiLy"].Visible = false; // Hide this column  
            dgvDaiLy.Columns["MaQuan"].Visible = false; // Hide this column
            dgvDaiLy.ReadOnly = true; // Set DataGridView to read-only mode
            for (int i = 0; i < dgvDaiLy.Columns.Count; i++)
            {
                dgvDaiLy.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTenDaiLy.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtEmail.Text != "")
            {
                DTO_DaiLy dl = new DTO_DaiLy(0, txtTenDaiLy.Text, Convert.ToInt32(cboLoaiDaiLy.SelectedValue), txtSDT.Text, txtEmail.Text, txtDiaChi.Text, Convert.ToInt32(cboQuan.SelectedValue), dtpNgayTiepNhan.Value, 0);
                if (busDaiLy.ThemDaiLy(dl))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvDaiLy.DataSource = busDaiLy.GetDaiLy();
                }
                else MessageBox.Show("Thêm thất bại");
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDaiLy.SelectedRows.Count > 0)
            {
                int maDL = Convert.ToInt32(dgvDaiLy.SelectedRows[0].Cells[0].Value);
                DTO_DaiLy dl = new DTO_DaiLy(maDL, txtTenDaiLy.Text, Convert.ToInt32(cboLoaiDaiLy.SelectedValue), txtSDT.Text, txtEmail.Text, txtDiaChi.Text, Convert.ToInt32(cboQuan.SelectedValue), dtpNgayTiepNhan.Value, Convert.ToDecimal(dgvDaiLy.SelectedRows[0].Cells["TongNo"].Value));
                if (busDaiLy.SuaDaiLy(dl))
                {
                    MessageBox.Show("Sửa thành công");
                    dgvDaiLy.DataSource = busDaiLy.GetDaiLy();
                }
                else MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDaiLy.SelectedRows.Count > 0)
            {
                int maDL = Convert.ToInt32(dgvDaiLy.SelectedRows[0].Cells[0].Value);
                if (busDaiLy.XoaDaiLy(maDL))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvDaiLy.DataSource = busDaiLy.GetDaiLy();
                }
                else MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDaiLy_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                // Xác định xem chuột có nhấn vào dòng dữ liệu không
                var hitTestInfo = dgvDaiLy.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0)
                {
                    dgvDaiLy.ClearSelection();
                    dgvDaiLy.Rows[hitTestInfo.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dgvDaiLy, e.Location);
                }
            }
        }

        private void tạoPhiếuXuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_PhieuXuat phieuXuat = new GUI_PhieuXuat(maDaiLy);
            this.Enabled = false; // Vô hiệu hóa form hiện tại
            phieuXuat.ShowDialog();
            this.Enabled = true; // Kích hoạt lại form hiện tại
            this.GUI_DaiLy_Load(sender, e);
        }

        private void tạoPhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_PhieuThu phieuThu = new GUI_PhieuThu(maDaiLy);
            this.Enabled = false; // Vô hiệu hóa form hiện tại
            phieuThu.ShowDialog();
            this.Enabled = true; // Kích hoạt lại form hiện tại
            this.GUI_DaiLy_Load(sender, e);
        }

        private void dgvDaiLy_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDaiLy.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDaiLy.SelectedRows[0];
                maDaiLy = Convert.ToInt32(row.Cells["MaDaiLy"].Value);
                txtTenDaiLy.Text = row.Cells["TenDaiLy"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                cboLoaiDaiLy.SelectedValue = row.Cells["MaLoaiDaiLy"].Value;
                cboQuan.SelectedValue = row.Cells["MaQuan"].Value;
                dtpNgayTiepNhan.Value = Convert.ToDateTime(row.Cells["NgayTiepNhan"].Value);
                //txtTongNo.Text = row.Cells["TongNo"].Value.ToString();
            }
        }
        */
    }
}
