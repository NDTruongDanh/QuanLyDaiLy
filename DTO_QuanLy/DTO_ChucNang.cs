using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ChucNang
    {
        public int MaChucNang { get; set; }
        public string TenManHinhDuocLoad { get; set; }

        public DTO_ChucNang() { }

        public DTO_ChucNang(int maChucNang, string tenManHinhDuocLoad)
        {
            MaChucNang = maChucNang;
            TenManHinhDuocLoad = tenManHinhDuocLoad;
        }
    }
}
