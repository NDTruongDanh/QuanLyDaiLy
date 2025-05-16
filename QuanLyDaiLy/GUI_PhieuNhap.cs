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
    public partial class GUI_PhieuNhap : Form
    {
        //Các tham số để cập nhật PhieuNhap khi tạo mới xong các ChiTietPhieuNhap
        private decimal tongTien = 0;


        private BUS_PhieuNhap busPhieuNhap = new BUS_PhieuNhap();

        int maPhieuNhap = 0;
        public GUI_PhieuNhap()
        {
            InitializeComponent();
        }

        private void GUI_PhieuNhap_Load(object sender, EventArgs e)
        {
            LoadPhieuNhap();
        }

        private void LoadPhieuNhap()
        {
            DataTable dt = busPhieuNhap.GetPhieuNhap();
            dgvDsPhieuNhap.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDsPhieuNhap.SelectedRows.Count > 0)
            {
                if (busPhieuNhap.XoaPhieuNhap(maPhieuNhap))
                {
                    MessageBox.Show("Xóa phiếu nhập thành công!");
                    LoadPhieuNhap();
                }
                else
                {
                    MessageBox.Show("Xóa phiếu nhập thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để xóa!");
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhieuNhap_DoubleClick(object sender, EventArgs e)
        {
            GUI_ChiTietPhieuNhap chiTietPhieuNhap = new GUI_ChiTietPhieuNhap(maPhieuNhap);
            chiTietPhieuNhap.Show();
        }
    }
}

