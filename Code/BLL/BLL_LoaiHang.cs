using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
  public class BLL_LoaiHang
    {
        private DAL_LoaiHang loaihang = new DAL_LoaiHang();
        public List<DTO_LoaiHang> laydanhsachloaihang()
        {
            return loaihang.LayDanhSachLoaiHang();
        }

        public bool ThemLoaiHang(DTO_LoaiHang dl)
        {
            return loaihang.ThemLoaiHang(dl);
        }

        public bool XoaLoaiHang(long id)
        {
            return loaihang.XoaNhomHang(id);
        }

        public bool SuaLoaiHang(DTO_LoaiHang dl)
        {
            return loaihang.SuaLoaiHang(dl);
        }

        public List<DTO_LoaiHang> TimKiemLoaiHang(string tukhoa)
        {
            return loaihang.TimKiemLoaiHang(tukhoa);
        }
    }
}
