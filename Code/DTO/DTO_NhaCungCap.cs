using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhaCungCap
    {
        private long id;
        private string name;
        private string sdt;
        private string email;
        private string diaChi;

        [DisplayName("Mã nhà cung cấp")]
        public long Id { get => id; set => id = value; }
        [DisplayName("Tên nhà cung cấp")]
        public string Name { get => name; set => name = value; }
        [DisplayName("Số điện thoại")]
        public string Sdt { get => sdt; set => sdt = value; }
        [DisplayName("Địa chỉ")]
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
    }
}
