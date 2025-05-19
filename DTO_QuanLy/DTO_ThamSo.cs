using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ThamSo
    {
        public int DaiLyToiDa { get; set; }
        public bool ApDungQDKiemTraTienThu { get; set; }
        public float TiLeTinhDonGiaXuat { get; set; }
        

        public DTO_ThamSo() { }

        public DTO_ThamSo(int daiLyToiDa, bool apDungQDKiemTraTienThu, float tiLeTinhDonGiaXuat)
        {
            DaiLyToiDa = daiLyToiDa;
            ApDungQDKiemTraTienThu = apDungQDKiemTraTienThu;
            TiLeTinhDonGiaXuat = tiLeTinhDonGiaXuat;
        }
    }
}
