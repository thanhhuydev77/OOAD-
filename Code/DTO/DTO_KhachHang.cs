using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_KhachHang
    {
        private long id;
        private string name;
        private string sdt;
        private string email;


        [DisplayName("Mã Khách Hàng")]
        public long Id { get => id; set => id = value; }
        [DisplayName("Tên khách Hàng")]
        public string Name { get => name; set => name = value; }
        [DisplayName("Số điện thoại")]
        public string Sdt { get => sdt; set => sdt = value; }
        [DisplayName("Địa chỉ")]
        public string Email { get => email; set => email = value; }
    }
}
