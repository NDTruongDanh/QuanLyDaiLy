using DAL_QuanLy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Library
{
    public class BusException : Exception
    {
        public BusException(string message, Exception inner) : base(message, inner) { }

        public BusException(string message) : base(message) { }
    }

    public static class MyLogEvents
    {
        //LoaiDaiLy
        public const int GetLoaiDaiLyListFailure = 0001;
        public const int AddLoaiDaiLyFailure = 0002;
        public const int UpdateLoaiDaiLyFailure = 0003;
        public const int DeleteLoaiDaiLyFailure = 0004;

        //Quan 
        public const int GetQuanListFailure = 0101;
        public const int AddQuanFailure = 0102;
        public const int UpdateQuanFailure = 0103;
        public const int DeleteQuanFailure = 0104;

        //DaiLy
        public const int GetDTODaiLyListAsync = 0201;
        public const int GetDataTableDaiLyListFailure = 0206;
        public const int GetDaiLyByMaFailure = 0207;
        public const int AddDaiLyFailure = 0202;
        public const int UpdateDaiLyFailure = 0203;
        public const int UpdateDaiLySauXuatHangFailure = 0204;
        public const int DeleteDaiLyFailure = 0205;
        public const int FindDaiLyFailure = 0208;

        //DonViTinh
        public const int GetDonViTinhListFailure = 0301;
        public const int AddDonViTinhFailure = 0302;
        public const int UpdateDonViTinhFailure = 0303;
        public const int DeleteDonViTinhFailure = 0304;

        //MatHang
        public const int GetMatHangListFailure = 0401;
        public const int AddMatHangFailure = 0402;
        public const int AddMatHangDefaultFailure = 0403;
        public const int UpdateMatHangFailure = 0404;
        public const int DeleteMatHangFailure = 0405;
        public const int GetMatHangForNhapFailure = 0406;
        public const int GetMatHangForXuatFailure = 0407;

        //PhieuNhap
        public const int GetPhieuNhapListFailure = 0501;
        public const int AddPhieuNhapFailure = 0502;
        public const int UpdatePhieuNhapFailure = 0503;
        public const int DeletePhieuNhapFailure = 0504;
        public const int GetMaPhieuNhapDefaultFailure = 0505;

        //ChitietPhieuNhap
        public const int GetChiTietPhieuNhapListFailure = 0505;
        public const int AddChiTietPhieuNhapFailure = 0506;
        public const int UpdateChiTietPhieuNhapFailure = 0507;
        public const int DeleteChiTietPhieuNhapFailure = 0508;
        public const int GetDataTableChiTietPhieuNhapFailure = 0509;
        public const int GetDataTableChiTietPhieuNhapsByMPNFailure = 0510;
        public const int DeleteChiTietPhieuNhapByMPNFailure = 0511;

        //PhieuXuat
        public const int GetPhieuXuatListFailure = 0601;
        public const int GetPhieuXuatListByDaiLyFailure = 0602;
        public const int AddPhieuXuatFailure = 0603;
        public const int AddPhieuXuatDefaultFailure = 0604;
        public const int UpdatePhieuXuatFailure = 0605;
        public const int DeletePhieuXuatFailure = 0606;
        public const int GetDataTablePhieuXuatFailure = 0607;
        public const int GetDataTablePhieuXuatCuaDaiLyFailure = 0608;
        public const int GetMaPhieuXuatDefaultFailure = 0609;

        //ChiTietPhieuXuat
        public const int GetChiTietPhieuXuatListFailure = 0606;
        public const int GetChiTietPhieuXuatListByMPXFailure = 0607;
        public const int AddChiTietPhieuXuatFailure = 0608;
        public const int UpdateChiTietPhieuXuatFailure = 0609;
        public const int DeleteChiTietPhieuXuatFailure = 0610;
        public const int GetChiTietPhieuXuatDataTableFailure = 0611;
        public const int GetChiTietPhieuXuatDataTableByMPXFailure = 0612;
        public const int DeleteChiTietPhieuXuatByMPXFailure = 0613;

        //PhieuThu
        public const int GetPhieuThuListFailure = 0701;
        public const int GetPhieuThuCuaDaiLyListFailure = 0702;
        public const int AddPhieuThuFailure = 0703;
        public const int UpdatePhieuThuFailure = 0704;
        public const int DeletePhieuThuFailure = 0705;

        //BaoCaoCongNo
        public const int GetAllBaoCaoCongNoListFailure = 0801;
        public const int GetBaoCaoCongNoListByThangFailure = 0802;
        public const int AddBaoCaoCongNoFailure = 0803;
        public const int AddBaoCaoCongNoByTimeFailure = 0804;
        public const int UpdateBaoCaoCongNoFailure = 0805;
        public const int DeleteBaoCaoCongNoFailure = 0806;

        //BaoCaoDoanhSo
        public const int GetAllBaoCaoDoanhSoListFailure = 0901;
        public const int GetBaoCaoDoanhSoListByTimeFailure = 0902;
        public const int AddBaoCaoDoanhSoFailure = 0903;
        public const int AddBaoCaoDoanhSoByTimeFailure = 0904;
        public const int AddBaoCaoDoanhSoAutoFailure = 0905;
        public const int UpdateBaoCaoDoanhSoFailure = 0906;
        public const int DeleteBaoCaoDoanhSoFailure = 0907;
        

        //ChiTietBaoCaoDoanhSo
        public const int GetChiTietBaoCaoDoanhSoListFailure = 0906;
        public const int GetChiTietBaoCaoDoanhSoByMaBaoCaoListFailure = 0907;
        public const int AddChiTietBaoCaoDoanhSoFailure = 0908;
        public const int AddChiTietBaoCaoDoanhSoAutoFailure = 0909;
        public const int UpdateChiTietBaoCaoDoanhSoFailure = 0910;
        public const int DeleteChiTietBaoCaoDoanhSoFailure = 0911;


        //Thamso
        public const int GetTiLeXuatFailure = 1001;
        public const int GetDaiLyToiDaFailure = 1002;
        public const int GetApDungQDKiemTraTienThuFailure = 1003;


    }
}
