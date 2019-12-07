using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_KhachHang
    {
        private DAL_KhachHang   tg = new DAL_KhachHang();
        public List<DTO_KhachHang> LayDanhSachKhachHang()
        {
            return tg.LayDanhSachKhachHang();
        }
        public bool themKhachHang(DTO_KhachHang ncc)
        {
            return tg.ThemKhachHang(ncc);
        }
        public bool suaKhachHang(DTO_KhachHang ncc) {
            return tg.SuaKhachHang(ncc);
        }
        public bool xoaKhachHang(long id) {
            return tg.XoaKhachHang(id);
        }
        public List<DTO_KhachHang> timKhachHang(string tukhoa) {
            return tg.TimKiemKhachHang(tukhoa);
        }
    }
}
