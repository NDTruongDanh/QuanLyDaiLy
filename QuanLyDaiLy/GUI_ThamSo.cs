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
    public partial class GUI_ThamSo : Form
    {
        private BUS_ThamSo busThamSo = new BUS_ThamSo();

        public GUI_ThamSo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newItem = cbbThamSo.Text.Trim();
            if (!string.IsNullOrEmpty(newItem) && !cbbThamSo.Items.Contains(newItem))
            {
                cbbThamSo.Items.Add(newItem);
                cbbThamSo.Text = "";
            }
            else
            {
                MessageBox.Show("Không hợp lệ!", "Thông báo");
            }

        }

        //private void GUI_ThamSo_Load(object sender, EventArgs e)
        //{
        //    LoadThamSo();
        //}

        //private void LoadThamSo()
        //{
        //    DataTable dt = busThamSo.GetThamSo();
        //    dgvThamSo.DataSource = dt;
        //}
        /*
        private void dgvThamSo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThamSo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvThamSo.SelectedRows[0];
                txtTenThamSo.Text = row.Cells["TenThamSo"].Value.ToString();
                txtGiaTri.Text = row.Cells["GiaTri"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenThamSo.Text) && !string.IsNullOrEmpty(txtGiaTri.Text))
            {
                DTO_ThamSo ts = new DTO_ThamSo
                {
                    TenThamSo = txtTenThamSo.Text,
                    GiaTri = Convert.ToInt32(txtGiaTri.Text)
                };

                if (busThamSo.ThemThamSo(ts))
                {
                    MessageBox.Show("Thêm tham số thành công!");
                    LoadThamSo();
                }
                else
                {
                    MessageBox.Show("Thêm tham số thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvThamSo.SelectedRows.Count > 0 && !string.IsNullOrEmpty(txtTenThamSo.Text))
            {
                DTO_ThamSo ts = new DTO_ThamSo
                {
                    TenThamSo = txtTenThamSo.Text,
                    GiaTri = Convert.ToInt32(txtGiaTri.Text)
                };

                if (busThamSo.SuaThamSo(ts))
                {
                    MessageBox.Show("Sửa tham số thành công!");
                    LoadThamSo();
                }
                else
                {
                    MessageBox.Show("Sửa tham số thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa và nhập thông tin mới!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvThamSo.SelectedRows.Count > 0)
            {
                string ten = dgvThamSo.SelectedRows[0].Cells["TenThamSo"].Value.ToString();
                if (busThamSo.XoaThamSo(ten))
                {
                    MessageBox.Show("Xóa tham số thành công!");
                    LoadThamSo();
                }
                else
                {
                    MessageBox.Show("Xóa tham số thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        */
    }
}
