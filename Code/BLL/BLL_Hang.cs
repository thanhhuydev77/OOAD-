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
        private DAL_Hang hang = new DAL_Hang();

        public List<DTO_Hang> LayDanhSachMatHangKhac()
        {
            return hang.LayDanhSachMatHangKhac();
        }
        public List<DTO_Hang> LayDanhSachThuoc() {
            return hang.LayDanhSachThuoc();
        }
        public List<DTO_Hang> LayDanhSachKho() {
            return hang.LayDanhSachKho();
        }
        public bool ThemMatHang(DTO_Hang loaidl)
        {
            return hang.ThemMatHang(loaidl);
        }
        public bool XoaMatHang(long id)
        {
            return hang.XoaMatHang(id);
        }
        public bool suaSoluongHangTrongKho(long id,int sl) {
            return hang.Suasoluonghang(id, sl);
        }
        public DTO_Hang timHang(long id) {
            return hang.TimKiemHang(id);
        }
        public bool SuaMatHang(DTO_Hang loaidl)
        {
            return hang.SuaMatHang(loaidl);
        }
        public long timMaHang(string ten) {
            return hang.timMaHang(ten);
        }
        public bool SuaKho(DTO_Hang loaidl) {
            return hang.SuaKho(loaidl);
        }
        public List<DTO_Hang> TimKiem(string tukhoa,int loai)
        {
            return hang.TimKiemHang(tukhoa,loai);
        }
    }
}
