using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietPhieuXuat
    {
        private long id;
        private long mapx;
        private long madvt;
        private long mamh;
        private int soluong;
        private uint thanhtien;
        [DisplayName("Mã Chi Tiết")]
        public long Id { get => id; set => id = value; }
        [DisplayName("Mã Phiếu")]
        public long MaPx { get => mapx; set => mapx = value; }
        [DisplayName("Mã ĐVT")]
        public long MaDvt { get => madvt; set => madvt = value; }
        [DisplayName("Mã Mặt Hàng")]
        public long MaMh { get => mamh; set => mamh = value; }
        [DisplayName("Số Lượng")]
        public int SoLuong { get => soluong; set => soluong = value; }
        [DisplayName("Thành Tiền")]
        public uint ThanhTien { get => thanhtien; set => thanhtien = value; }
    }
}
