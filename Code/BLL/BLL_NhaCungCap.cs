using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_NhaCungCap
    {
        private DAL_NhaCungCap tg = new DAL_NhaCungCap();
        public List<DTO_NhaCungCap> LayDanhSachNhaCungCap()
        {
            return tg.LayDanhSachnhacungcap();
        }
        public bool themNhaCungCap(DTO_NhaCungCap ncc)
        {
            return tg.ThemNhaCungCap(ncc);
        }
        public bool suaNhaCungCap(DTO_NhaCungCap ncc) {
            return tg.SuaNhaCungCap(ncc);
        }
        public bool xoaNhaCungCap(long id) {
            return tg.XoaNhaCungCap(id);
        }
        public List<DTO_NhaCungCap> timNhaCungCap(string tukhoa) {
            return tg.TimKiemHang(tukhoa);
        }
    }
}
