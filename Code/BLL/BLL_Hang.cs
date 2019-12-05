using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Hang
    {
        private DAL_Hang mhk = new DAL_Hang();

        public List<DTO_Hang> LayDanhSachMatHangKhac()
        {
            return mhk.LayDanhSachMatHangKhac();
        }
        public List<DTO_Hang> LayDanhSachThuoc() {
            return mhk.LayDanhSachThuoc();
        }
        public List<DTO_Hang> LayDanhSachKho() {
            return mhk.LayDanhSachKho();
        }
        public bool ThemMatHang(DTO_Hang loaidl)
        {
            return mhk.ThemMatHang(loaidl);
        }
        public bool XoaMatHang(long id)
        {
            return mhk.XoaMatHang(id);
        }
        public bool SuaMatHang(DTO_Hang loaidl)
        {
            return mhk.SuaMatHang(loaidl);
        }
        public bool SuaKho(DTO_Hang loaidl) {
            return mhk.SuaKho(loaidl);
        }
        public List<DTO_Hang> TimKiem(string tukhoa,int loai)
        {
            return mhk.TimKiemHang(tukhoa,loai);
        }
    }
}
