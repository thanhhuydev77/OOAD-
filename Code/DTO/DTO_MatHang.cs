using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class DTO_Hang
    {
        #region prop
        private long maMatHang;

        private string tenMatHang;

        private long maNhomHang;

        private string congDung;

        private string thanhPhan;

        private string xuatXu;

        private int soLuong;

        private double giaNhap;

        private double giaBan;

        private long maDVT;

        [DisplayName("Mã Mặt Hàng")]
        public long MaMatHang { get => maMatHang; set => maMatHang = value; }

        [DisplayName("Tên Mặt Hàng")]
        public string TenMatHang { get => tenMatHang; set => tenMatHang = value; }

        [DisplayName("Mã đơn vị tính")]
        public long MaDVT { get => maDVT; set => maDVT = value; }

        [DisplayName(" Mã Nhóm Hàng")]
        public long MaNhomHang { get => maNhomHang; set => maNhomHang = value; }

        [DisplayName("Công Dụng")]
        public string CongDung { get => congDung; set => congDung = value; }

        [DisplayName("Thành Phần")]
        public string ThanhPhan { get => thanhPhan; set => thanhPhan = value; }

        [DisplayName("Xuất Xứ")]
        public string XuatXu { get => xuatXu; set => xuatXu = value; }

        [DisplayName("Số Lượng")]
        public int SoLuong { get => soLuong; set => soLuong = value; }

        [DisplayName("Giá Nhập")]
        public double GiaNhap { get => giaNhap; set => giaNhap = value; }

        [DisplayName("Giá Bán")]
        public double GiaBan { get => giaBan; set => giaBan = value; }
        #endregion
    }
}
