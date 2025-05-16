using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_LoaiDaiLy : Form
    {
        BUS_LoaiDaiLy busLoai = new BUS_LoaiDaiLy();

        public GUI_LoaiDaiLy()
        {
            InitializeComponent();
        }

        private void GUI_LoaiDaiLy_Load(object sender, EventArgs e)
        {
            dgvLoaiDaiLy.DataSource = busLoai.GetLoaiDaiLy();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiDaiLy.Text != "" && txtTienNoToiDa.Text != "")
            {
                DTO_LoaiDaiLy loai = new DTO_LoaiDaiLy(0, txtTenLoaiDaiLy.Text, decimal.Parse(txtTienNoToiDa.Text));
                if (busLoai.ThemLoaiDaiLy(loai))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvLoaiDaiLy.DataSource = busLoai.GetLoaiDaiLy();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvLoaiDaiLy.SelectedRows.Count > 0)
            {
                if (txtTenLoaiDaiLy.Text != "" && txtTienNoToiDa.Text != "")
                {
                    int id = Convert.ToInt32(dgvLoaiDaiLy.SelectedRows[0].Cells[0].Value);
                    DTO_LoaiDaiLy loai = new DTO_LoaiDaiLy(id, txtTenLoaiDaiLy.Text, decimal.Parse(txtTienNoToiDa.Text));

                    if (busLoai.SuaLoaiDaiLy(loai))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvLoaiDaiLy.DataSource = busLoai.GetLoaiDaiLy();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại đại lý cần sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLoaiDaiLy.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvLoaiDaiLy.SelectedRows[0].Cells[0].Value);
                if (busLoai.XoaLoaiDaiLy(id))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvLoaiDaiLy.DataSource = busLoai.GetLoaiDaiLy();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại đại lý cần xóa");
            }
        }

        private void dgvLoaiDaiLy_Click(object sender, EventArgs e)
        {
            if (dgvLoaiDaiLy.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvLoaiDaiLy.SelectedRows[0];
                txtTenLoaiDaiLy.Text = row.Cells[1].Value.ToString();
                txtTienNoToiDa.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

