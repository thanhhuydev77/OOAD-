using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhanVien
    {
        private long id;

        private string tenNhanVien;

        private string chucVu;

        private bool gioiTinh;

        private int tuoi;

        private string email;

        private string diaChi;

        private string sDT;

        private int phanQuyen;

        private long taiKhoan;
        [DisplayName("Mã Nhân Viên")]
        public long Id { get => id; set => id = value; }

        [DisplayName("Tên Nhân Viên")]
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }

        [DisplayName("Chức Vụ")]
        public string ChucVu { get => chucVu; set => chucVu = value; }

        [DisplayName("Giới Tính")]
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        [DisplayName("Tuổi")]
        public int Tuoi { get => tuoi; set => tuoi = value; }

        [DisplayName("Email")]
        public string Email { get => email; set => email = value; }

        [DisplayName("Địa Chỉ")]
        public string DiaChi { get => diaChi; set => diaChi = value; }

        [DisplayName("Số Điện Thoại")]
        public string SDT { get => sDT; set => sDT = value; }

        [DisplayName("Phân Quyền")]
        public int PhanQuyen { get => phanQuyen; set => phanQuyen = value; }

        [DisplayName("Tài Khoản")]
        public long TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
    }
}
