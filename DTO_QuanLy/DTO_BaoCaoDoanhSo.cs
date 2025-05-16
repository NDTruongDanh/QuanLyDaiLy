using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_BaoCaoDoanhSo
    {
        public int MaBaoCaoDoanhSo { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public decimal TongDoanhSo { get; set; }

        public DTO_BaoCaoDoanhSo() { }

        public DTO_BaoCaoDoanhSo(int maBaoCao, int thang, int nam, decimal tongDoanhSo)
        {
            MaBaoCaoDoanhSo = maBaoCao;
            Thang = thang;
            Nam = nam;
            TongDoanhSo = tongDoanhSo;
        }

    }
}

