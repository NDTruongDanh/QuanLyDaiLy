using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DTO_QuanLy;
using DAL_QuanLy;

namespace BUS_Library
{
    public static class ValidationHelper
    {
        public static void ValidateLoaiDaiLy(DTO_LoaiDaiLy loaiDaiLy)
        {
            if (string.IsNullOrWhiteSpace(loaiDaiLy.TenLoaiDaiLy))
                throw new ValidationException("Tên loại đại lý không được để trống");
            if (loaiDaiLy.TienNoToiDa <= 0)
                throw new ValidationException("Tiền nợ tối đa phải lớn hơn 0");
        }
    }
}
