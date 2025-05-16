using System;
using System.Data;
using DAL_QuanLy;
using DTO_QuanLy;

namespace BUS_QuanLy
{
    public class BUS_ThamSo
    {
        DAL_ThamSo dalThamSo = new DAL_ThamSo();

        // Lấy tất cả tham số
        public DataTable GetThamSo()
        {
            return dalThamSo.GetAllThamSo();
        }

        // Thêm tham số
        public bool ThemThamSo(DTO_ThamSo thamSo)
        {
            return dalThamSo.ThemThamSo(thamSo);
        }

        // Sửa tham số
        public bool SuaThamSo(DTO_ThamSo thamSo)
        {
            return dalThamSo.SuaThamSo(thamSo);
        }

        // Xóa tham số
        public bool XoaThamSo(string tenThamSo)
        {
            return dalThamSo.XoaThamSo(tenThamSo);
        }
    }
}
