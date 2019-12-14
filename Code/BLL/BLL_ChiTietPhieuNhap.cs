using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_ChiTietPhieuNhap
    {
        DAL_ChiTietPhieuNhap ChiTietPhieuNhap = new DAL_ChiTietPhieuNhap();
        public List<DTO_ChiTietPhieuNhap> LayDanhSachChiTietPhieuNhap()
        {
            return ChiTietPhieuNhap.LayDanhSachChiTiet();
        }
        public List<DTO_ChiTietPhieuNhap> timkiem(string tukhoa)
        {
            return ChiTietPhieuNhap.timkiem(tukhoa);
        }
        public bool ThemChiTietPX(DTO_ChiTietPhieuNhap ctpn)
        {
            return ChiTietPhieuNhap.ThemChiTiet(ctpn);
        }
        public bool XoaChiTietPX(long id)
        {
            return ChiTietPhieuNhap.XoaChiTiet(id);
        }
        public bool SuaChiTietPX(DTO_ChiTietPhieuNhap ctpn)
        {
            return ChiTietPhieuNhap.SuaChiTietPX(ctpn);
        }
    }
}
