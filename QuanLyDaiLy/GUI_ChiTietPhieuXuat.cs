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
using DTO_QuanLy;
using BUS_Library;
using BUS_QuanLy;
namespace GUI_QuanLy
{
    public partial class GUI_ChiTietPhieuXuat : Form
    {
        // Sự kiện trả về các giá trị để cập nhật PhieuXuat khi tạo mới


        private readonly BUS_PhieuXuat busPhieuXuat;
        private readonly BUS_DaiLy busDaiLy;
        private readonly BUS_ChiTietPhieuXuat busChiTietPhieuXuat;

        public DTO_PhieuXuat phieuXuat;
        DTO_DaiLy daiLy; 
        public GUI_ChiTietPhieuXuat(int maPhieuXuat)
        {
            InitializeComponent();
        

        }
        private void GUI_ChiTietPhieuXuat_Load(object sender, EventArgs e)
        {
        }

    }
}

