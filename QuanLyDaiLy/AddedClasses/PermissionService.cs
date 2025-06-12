using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLy;
using DTO_QuanLy;

namespace GUI_QuanLy.AddedClasses
{
    public class PermissionService
    {
        private readonly IDAL_ChiTietPhanQuyen _dalPhanQuyen;
        private static DTO_NguoiDung? CurrentUser;

        
        public PermissionService(IDAL_ChiTietPhanQuyen dalPhanQuyen)
        {
            _dalPhanQuyen = dalPhanQuyen;
            
        }

        public void SetCurrentUser(DTO_NguoiDung user)
        {
            CurrentUser = user;
        }
        public async Task<DTO_ChiTietPhanQuyen?> GetPermissionCurrentUserAsync(string tenChucNang)
        {
            // Kiểm tra người dùng hiện tại
            if (CurrentUser == null)
            {
                throw new InvalidOperationException("Người dùng chưa được đăng nhập.");
            }
            // Gọi DAL để lấy quyền
            return await _dalPhanQuyen.GetQuyenForUserAsync(CurrentUser.TenNguoiDung, tenChucNang);
        }
        public async Task<DTO_ChiTietPhanQuyen?> GetPermissionAsync(DTO_NguoiDung user, string tenChucNang)
        {
            // Gọi DAL để lấy quyền
            return await _dalPhanQuyen.GetQuyenForUserAsync(user.TenNguoiDung, tenChucNang);
        }

        public async Task<DataTable> GetAllQuyenForCurrentUserAsync()
        {
            // Kiểm tra người dùng hiện tại
            if (CurrentUser == null)
            {
                throw new InvalidOperationException("Người dùng chưa được đăng nhập.");
            }
            // Gọi DAL để lấy tất cả quyền
            return await _dalPhanQuyen.GetAllQuyenForUserAsync(CurrentUser.TenNguoiDung);
        }
    }
}
