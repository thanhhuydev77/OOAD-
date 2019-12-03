using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_MatHangKhac
    {
        private DAL_MatHangKhac mhk = new DAL_MatHangKhac();

        public List<DTO_MatHang> LayDanhSachMatHangKhac()
        {
            return mhk.LayDanhSachMatHangKhac();
        }
        public bool ThemMatHang(DTO_MatHang loaidl)
        {
            return mhk.ThemMatHang(loaidl);
        }
        public bool XoaMatHang(long id)
        {
            return mhk.XoaMatHang(id);
        }
        public bool SuaLoaiDaiLy(DTO_MatHang loaidl)
        {
            return mhk.SuaMatHang(loaidl);
        }
        public List<DTO_MatHang> TimKiem(string tukhoa)
        {
            return mhk.TimKiemLoaiDaiLy(tukhoa);
        }
    }
}
