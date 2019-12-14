using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietPhieuNhap
    {
        private long id;
        private long mahd;
        private long mahang;
        private string tenhang;
        private long dongiaban;
        private int soluong;
        [DisplayName("Mã Mặt Hàng")]
        public long Id { get => id; set => id = value; }
        
        public long MaHD { get => mahd; set => mahd = value; }
        [DisplayName("Tên Mặt Hàng")]
        public string TenHang { get => tenhang; set => tenhang = value; }
        [DisplayName("Đơn giá")]
        public long DonGiaBan { get => dongiaban; set => dongiaban = value; }
        [DisplayName("Số lượng")]
        public int SoLuong { get => soluong; set => soluong = value; }
        public long Mahang { get => mahang; set => mahang = value; }
    }
}
