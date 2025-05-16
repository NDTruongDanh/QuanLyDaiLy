using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Data;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_ChiTietBaoCaoDoanhSo : Form
    {
        private BUS_ChiTietBaoCaoDoanhSo busCTBCDS = new BUS_ChiTietBaoCaoDoanhSo();
        // Giả sử có BUS cho BaoCaoDoanhSo và DaiLy để load dữ liệu cho ComboBox
        private BUS_BaoCaoDoanhSo busBaoCaoDoanhSo = new BUS_BaoCaoDoanhSo();
        private BUS_DaiLy busDaiLy = new BUS_DaiLy();

        int maBaoCaoDoanhSo = 0;
        public GUI_ChiTietBaoCaoDoanhSo()
        {
            InitializeComponent();
        }

        public GUI_ChiTietBaoCaoDoanhSo(int maBaoCaoDoanhSo)
        {
            this.maBaoCaoDoanhSo = maBaoCaoDoanhSo;
            InitializeComponent();
        }

        private void GUI_ChiTietBaoCaoDoanhSo_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadChiTietBaoCaoDoanhSo();
        }

        private void LoadComboBoxes()
        {
            DataTable dtDaiLy = busDaiLy.GetDaiLy();
            cboMaDaiLy.DataSource = dtDaiLy;
            cboMaDaiLy.DisplayMember = "TenDaiLy";
            cboMaDaiLy.ValueMember = "MaDaiLy";
        }

        private void LoadChiTietBaoCaoDoanhSo()
        {
            DataTable dt = busCTBCDS.GetChiTietBaoCaoDoanhSo(maBaoCaoDoanhSo);
            dgvChiTietBaoCaoDoanhSo.DataSource = dt;
        }

        private void dgvChiTietBaoCaoDoanhSo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChiTietBaoCaoDoanhSo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvChiTietBaoCaoDoanhSo.SelectedRows[0];
                cboMaDaiLy.SelectedValue = row.Cells["MaDaiLy"].Value;
                txtSoLuongPhieuXuat.Text = row.Cells["SoLuongPhieuXuat"].Value.ToString();
                txtTongTriGia.Text = row.Cells["TongTriGia"].Value.ToString();
                txtTiLe.Text = row.Cells["TiLe"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( cboMaDaiLy.SelectedValue != null &&
                !string.IsNullOrEmpty(txtSoLuongPhieuXuat.Text) &&
                !string.IsNullOrEmpty(txtTongTriGia.Text) &&
                !string.IsNullOrEmpty(txtTiLe.Text))
            {
                DTO_ChiTietBaoCaoDoanhSo ct = new DTO_ChiTietBaoCaoDoanhSo(maBaoCaoDoanhSo, Convert.ToInt32(cboMaDaiLy.SelectedValue), Convert.ToInt32(txtSoLuongPhieuXuat.Text), Convert.ToDecimal(txtTongTriGia.Text), Convert.ToSingle(txtTiLe.Text));

                if (busCTBCDS.ThemChiTietBaoCaoDoanhSo(ct))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadChiTietBaoCaoDoanhSo();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvChiTietBaoCaoDoanhSo.SelectedRows.Count > 0)
            {
                DTO_ChiTietBaoCaoDoanhSo ct = new DTO_ChiTietBaoCaoDoanhSo(maBaoCaoDoanhSo, Convert.ToInt32(cboMaDaiLy.SelectedValue), Convert.ToInt32(txtSoLuongPhieuXuat.Text), Convert.ToDecimal(txtTongTriGia.Text), Convert.ToSingle(txtTiLe.Text));

                if (busCTBCDS.SuaChiTietBaoCaoDoanhSo(ct))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadChiTietBaoCaoDoanhSo();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvChiTietBaoCaoDoanhSo.SelectedRows.Count > 0)
            {
                int maDaiLy = Convert.ToInt32(dgvChiTietBaoCaoDoanhSo.SelectedRows[0].Cells["MaDaiLy"].Value);

                if (busCTBCDS.XoaChiTietBaoCaoDoanhSo(maBaoCaoDoanhSo, maDaiLy))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadChiTietBaoCaoDoanhSo();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
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
    }
}

