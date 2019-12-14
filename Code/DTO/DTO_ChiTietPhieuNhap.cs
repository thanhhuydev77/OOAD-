using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietPhieuNhap
    {
        private long id;
        private string mahd;
        private string mah;
        private long dongiaban;
        private int soluong;

        public long Id { get => id; set => id = value; }
        public string MaHD { get => mahd; set => mahd = value; }
        public string MaHang { get => mah; set => mah = value; }
        public long DonGiaBan { get => dongiaban; set => dongiaban = value; }
        public int SoLuong { get => soluong; set => soluong = value; }
    }
}
