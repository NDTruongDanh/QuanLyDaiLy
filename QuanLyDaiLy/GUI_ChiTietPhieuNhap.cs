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
    public partial class GUI_ChiTietPhieuNhap : Form
    {
        //Sự kiện trả về các giá trị để cập nhật PhieuNhap khi tạo mới
        public event Action<decimal> OnPhieuNhapUpdated;

        //Các giá trị trả về để cập nhật PhieuNhap khi tạo mới
        private decimal tongTien = 0;

        private BUS_ChiTietPhieuNhap busCTPN = new BUS_ChiTietPhieuNhap();
        private BUS_PhieuNhap busPhieuNhap = new BUS_PhieuNhap();
        private BUS_MatHang busMatHang = new BUS_MatHang();

        int maPhieuNhap = 0;
        public GUI_ChiTietPhieuNhap()
        {
            InitializeComponent();
        }
        public GUI_ChiTietPhieuNhap(int maPhieuNhap)
        {
            this.maPhieuNhap = maPhieuNhap;
            InitializeComponent();
        }

    }
}

