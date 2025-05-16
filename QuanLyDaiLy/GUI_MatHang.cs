using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_MatHang : Form
    {
        private BUS_MatHang busMatHang = new BUS_MatHang();
        private BUS_DonViTinh busDonViTinh = new BUS_DonViTinh();

        public GUI_MatHang()
        {
            InitializeComponent();
        }

        private void GUI_MatHang_Load(object sender, EventArgs e)
        {
            dgvMatHang.DataSource = busMatHang.GetMatHang();
            cboDonViTinh.DataSource = busDonViTinh.GetDonViTinh();
            cboDonViTinh.DisplayMember = "TenDonViTinh";
            cboDonViTinh.ValueMember = "MaDonViTinh";
        }

        private void dgvMatHang_Click(object sender, EventArgs e)
        {
            if (dgvMatHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMatHang.SelectedRows[0];
                txtTenMatHang.Text = row.Cells["TenMatHang"].Value.ToString();
                cboDonViTinh.SelectedValue = row.Cells["MaDonViTinh"].Value;
                txtDonGiaHienTai.Text = row.Cells["DonGiaHienTai"].Value.ToString();
                txtTonKho.Text = row.Cells["TonKho"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTenMatHang.Text != "" && cboDonViTinh.SelectedValue != null && txtDonGiaHienTai.Text != "" && txtTonKho.Text != "")
            {
                DTO_MatHang mh = new DTO_MatHang (0, txtTenMatHang.Text, Convert.ToInt32(cboDonViTinh.SelectedValue), Convert.ToDecimal(txtDonGiaHienTai.Text), Convert.ToInt32(txtTonKho.Text));

                if (busMatHang.ThemMatHang(mh))
                {
                    MessageBox.Show("Thêm mặt hàng thành công!");
                    dgvMatHang.DataSource = busMatHang.GetMatHang();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMatHang.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMatHang.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["MaMatHang"].Value);

                DTO_MatHang mh = new DTO_MatHang(id, txtTenMatHang.Text, Convert.ToInt32(cboDonViTinh.SelectedValue), Convert.ToDecimal(txtDonGiaHienTai.Text), Convert.ToInt32(txtTonKho.Text));

                if (busMatHang.SuaMatHang(mh))
                {
                    MessageBox.Show("Sửa mặt hàng thành công!");
                    dgvMatHang.DataSource = busMatHang.GetMatHang();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần sửa.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMatHang.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMatHang.SelectedRows[0].Cells["MaMatHang"].Value);

                if (busMatHang.XoaMatHang(id))
                {
                    MessageBox.Show("Xóa mặt hàng thành công!");
                    dgvMatHang.DataSource = busMatHang.GetMatHang();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần xóa.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
