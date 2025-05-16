using System;
using System.Data;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_Quan : Form
    {
        BUS_Quan busQuan = new BUS_Quan();

        public GUI_Quan()
        {
            InitializeComponent();
        }

        private void GUI_Quan_Load(object sender, EventArgs e)
        {
            dgvQuan.DataSource = busQuan.GetQuan();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenQuan.Text))
            {
                DTO_Quan quan = new DTO_Quan(0, txtTenQuan.Text);
                if (busQuan.ThemQuan(quan))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvQuan.DataSource = busQuan.GetQuan();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên quận.");
            }
        }

        private void dgvQuan_Click(object sender, EventArgs e)
        {
            if (dgvQuan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvQuan.SelectedRows[0];
                txtTenQuan.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvQuan.SelectedRows.Count > 0 && !string.IsNullOrEmpty(txtTenQuan.Text))
            {
                int maQuan = Convert.ToInt32(dgvQuan.SelectedRows[0].Cells[0].Value.ToString());
                DTO_Quan quan = new DTO_Quan(maQuan, txtTenQuan.Text);
                if (busQuan.SuaQuan(quan))
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvQuan.DataSource = busQuan.GetQuan();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa và nhập tên mới.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvQuan.SelectedRows.Count > 0)
            {
                int maQuan = Convert.ToInt32(dgvQuan.SelectedRows[0].Cells[0].Value.ToString());
                if (busQuan.XoaQuan(maQuan))
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvQuan.DataSource = busQuan.GetQuan();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn quận để xóa.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
