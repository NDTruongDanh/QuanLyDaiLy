using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_DaiLy
    {
        public int MaDaiLy { get; set; }

        public string TenDaiLy { get; set; }

        public int MaLoaiDaiLy { get; set; }

        public string Sdt { get; set; } 

        public string Email { get; set; }

        public string DiaChi { get; set; }

        public int MaQuan { get; set; }

        public DateTime NgayTiepNhan { get; set; }

        public decimal TongNo { get; set; }

        public DTO_DaiLy() { }

        public DTO_DaiLy(int maDaiLy, string tenDaiLy, int maLoaiDaiLy, string sdt, string email, string diaChi, int maQuan, DateTime ngayTiepNhan, decimal tongNo)
        {
            MaDaiLy = maDaiLy;
            TenDaiLy = tenDaiLy;
            MaLoaiDaiLy = maLoaiDaiLy;
            Sdt = sdt;
            Email = email;
            DiaChi = diaChi;
            MaQuan = maQuan;
            NgayTiepNhan = ngayTiepNhan;
            TongNo = tongNo;
        }
    }
}
