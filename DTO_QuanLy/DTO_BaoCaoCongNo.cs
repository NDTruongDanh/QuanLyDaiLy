using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_BaoCaoCongNo
    {
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int MaDaiLy { get; set; }
        public decimal NoDau { get; set; }
        public decimal PhatSinh { get; set; }
        public decimal NoCuoi { get; set; }

        public DTO_BaoCaoCongNo() { }

        public DTO_BaoCaoCongNo(int thang, int nam, int maDaiLy, decimal noDau, decimal phatSinh, decimal noCuoi)
        {
            Thang = thang;
            Nam = nam;
            MaDaiLy = maDaiLy;
            NoDau = noDau;
            PhatSinh = phatSinh;
            NoCuoi = noCuoi;
        }
    }
}
