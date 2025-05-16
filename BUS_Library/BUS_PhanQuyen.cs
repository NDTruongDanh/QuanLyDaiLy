using System;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLy;
using DAL_QuanLy;
using System.Data;

namespace BUS_Library
{
    public class BUS_PhanQuyen
    {
        DAL_PhanQuyen dalPhanQuyen = new DAL_PhanQuyen();

        public void SetChucNang(ref Dictionary<string, bool> chucNang, string userID)
        {
            DataTable dt = dalPhanQuyen.getChucNang(userID);
            foreach (DataRow row in dt.Rows)
            {
                string tenManHinhDuocLoad = row["TenManHinhDuocLoad"].ToString();
                
                if (chucNang.ContainsKey(tenManHinhDuocLoad))
                {
                    chucNang[tenManHinhDuocLoad] = true;
                }
            }
        }
    }
}
