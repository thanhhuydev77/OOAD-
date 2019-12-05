using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public  class BLL_NhanVien
    {
        #region prop
        private DAL_NhanVien nhanvien = new DAL_NhanVien();
        #endregion
        #region method
        public List<DTO_NhanVien> LayDanhSachNhanVien() {
            return nhanvien.LayDanhSachNhanVien();
        }

        public List<DTO_Right> LayDanhSachQuyen() {
            return nhanvien.LayDanhSachQuyen();
        }
        public string timTaiKhoan(string tenNhanVien) {
            return nhanvien.timTaiKhoan(tenNhanVien);
        }
        //public string LayDanhSachMatHang(long id)
        //{
        //    return nhanvien.timTaiKhoan(id);
        //}

        public bool ThemNhanVien(DTO_NhanVien dl) {
            return nhanvien.ThemNhanVien(dl);
        }

        public bool XoaNhanVien(long id) {
            return nhanvien.XoaNhanVien(id);
        }

        public bool SuaNhanVien(DTO_NhanVien dl) {
             return nhanvien.SuaNhanVien(dl);
        }


        public List<DTO_NhanVien> TimKiemNhanVien(string tukhoa) {
             return nhanvien.TimKiemNhanVien(tukhoa);
        }
        #endregion
    }
}
