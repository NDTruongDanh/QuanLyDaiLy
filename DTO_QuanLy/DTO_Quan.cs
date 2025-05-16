using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_Quan
    {
        public int MaQuan { get; set; } 

        public string TenQuan { get; set; }

        public DTO_Quan() { }

        public DTO_Quan(int maQuan, string tenQuan)
        {
            MaQuan = maQuan;
            TenQuan = tenQuan;
        }
    }
}

