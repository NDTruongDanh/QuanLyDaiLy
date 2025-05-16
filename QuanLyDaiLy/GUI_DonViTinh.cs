using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_DonViTinh : Form
    {
        BUS_DonViTinh busDVT = new BUS_DonViTinh();

        public GUI_DonViTinh()
        {
            InitializeComponent();
        }

        private void GUI_DonViTinh_Load(object sender, EventArgs e)
        {
            dgvDVT.DataSource = busDVT.GetDonViTinh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTenDonViTinh.Text != "")
            {
                DTO_DonViTinh dvt = new DTO_DonViTinh(0, txtTenDonViTinh.Text); // 0 nếu MaDonViTinh là identity

                if (busDVT.ThemDonViTinh(dvt))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvDVT.DataSource = busDVT.GetDonViTinh();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên đơn vị tính.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDVT.SelectedRows.Count > 0)
            {
                if (txtTenDonViTinh.Text != "")
                {
                    DataGridViewRow row = dgvDVT.SelectedRows[0];
                    int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                    DTO_DonViTinh dvt = new DTO_DonViTinh(id, txtTenDonViTinh.Text);

                    if (busDVT.SuaDonViTinh(dvt))
                    {
                        MessageBox.Show("Sửa thành công!");
                        dgvDVT.DataSource = busDVT.GetDonViTinh();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên đơn vị tính.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính để sửa.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDVT.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDVT.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                if (busDVT.XoaDonViTinh(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvDVT.DataSource = busDVT.GetDonViTinh();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính để xóa.");
            }
        }

        private void dgvDVT_Click(object sender, EventArgs e)
        {
            if (dgvDVT.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDVT.SelectedRows[0];
                txtTenDonViTinh.Text = row.Cells[1].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtTenDonViTinh.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
