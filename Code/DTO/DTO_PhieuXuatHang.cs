using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuXuatHang
    {
        private long id;
        private long manv;
        private long makh;
        private DateTime ngaylapphieu;
        private uint tongtien;

        [DisplayName("Mã Phiếu Xuất")]
        public long Id
        { get => id; set => id = value; }
        [DisplayName("Mã Nhân Viên")]
        public long MaNV
        { get => manv; set => manv = value; }
        [DisplayName("Mã Khách Hàng")]
        public long MaKH
        { get => makh; set => makh = value; }
        [DisplayName("Ngày xuất")]
        public DateTime NgayLapPhieu
        { get => ngaylapphieu; set => ngaylapphieu = value; }
        [DisplayName("Tổng tiền")]
        public uint TongTriGia
        { get => tongtien; set => tongtien = value; }

    }
}
