using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_LoaiDaiLy
    {
        public int MaLoaiDaiLy { get; set; }
        
        public string TenLoaiDaiLy { get; set; }
        
        public decimal TienNoToiDa { get; set; }

        public DTO_LoaiDaiLy() { }

        public DTO_LoaiDaiLy(int maLoaiDaiLy, string tenLoaiDaiLy, decimal tienNoToiDa)
        {
            MaLoaiDaiLy = maLoaiDaiLy;
            TenLoaiDaiLy = tenLoaiDaiLy;
            TienNoToiDa = tienNoToiDa;
        }
    }
}
